using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;
using System.Text;

public class XmlSerializer
{
	private object obj;
    public bool X_Base64 = true;
    BindingFlags flags = BindingFlags.CreateInstance | BindingFlags.DeclaredOnly | BindingFlags.Default | BindingFlags.ExactBinding | BindingFlags.FlattenHierarchy | BindingFlags.GetField | BindingFlags.GetProperty | BindingFlags.IgnoreCase | BindingFlags.IgnoreReturn | BindingFlags.Instance | BindingFlags.InvokeMethod | BindingFlags.NonPublic | BindingFlags.OptionalParamBinding | BindingFlags.Public | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty | BindingFlags.SetField | BindingFlags.SetProperty | BindingFlags.Static | BindingFlags.SuppressChangeType;

	public XmlSerializer()
	{
		this.obj = this;
	}
    public string EnSerialize()
    {
        return EnSerialize(null, true);
    }

	public string EnSerialize(string[] EnserializeNames, bool baseTypes)
	{
		string lineend = System.Environment.NewLine;
		string xml = "<?xml version='1.0' encoding='UTF-8'?>"+lineend;
		xml += "<object Type='"+obj.GetType().FullName.ToString()+"'>"+lineend;
        List<string> serializeList = null;
        if (EnserializeNames != null) serializeList = new List<string>(EnserializeNames);
		foreach (FieldInfo info in obj.GetType().GetFields(flags))
        {
            try
            {
                if(serializeList != null) if(serializeList.IndexOf(info.Name)<=-1) continue;
                string xval = "";
                if (X_Base64)
                {
                    xval = Convert.ToBase64String(Encoding.Default.GetBytes(getTypeValue(info)));
                }
                else xval = getTypeValue(info);
                xml += "<" + info.Name + " Type='" + info.GetValue(obj).GetType().FullName + "'>" + xval + "</" + info.Name + ">" + lineend;
            }
            catch { }
        }
        if (baseTypes)
        {
            try
            {
                Type type = obj.GetType().BaseType;
                while (type != null)
                {
                    foreach (FieldInfo info in type.GetFields(flags))
                    {
                        try
                        {
                            if (serializeList != null) if (serializeList.IndexOf(info.Name) <= -1) continue;
                            string xval = "";
                            if (X_Base64)
                            {
                                xval = Convert.ToBase64String(Encoding.Default.GetBytes(getTypeValue(info)));
                            }
                            else xval = getTypeValue(info);
                            xml += "<" + info.Name + " Type='" + info.GetValue(obj).GetType().FullName + "'>" + xval + "</" + info.Name + ">" + lineend;
                        }
                        catch
                        { }
                    }
                    try
                    {
                        type = type.BaseType;
                    }
                    catch { type = null; }
                }
            }
            catch
            { }
        }
		xml += "</object>";
		return xml;
	}
	
	public byte[] EnByteSerialize()
	{
		return System.Text.Encoding.Default.GetBytes(EnSerialize());
	}
	
	public object DeSerialize(byte[] bytes)
	{
		return DeSerialize(System.Text.Encoding.Default.GetString(bytes));
	}
	
	public object DeSerialize(string xmlcodes)
	{
		string[] strings = xmlcodes.Split('\n');
		string anaregexstr = @"<(.*) Type='(.*)'>";
		Match regex = Regex.Match(strings[1], anaregexstr);
		Type anatip = Type.GetType(regex.Groups[2].Value);
		if(obj.GetType() != anatip) throw new Exception("obj türü ile xml nesne türü uyusmadi");
		
		string regexstr = @"<(.*) Type='(.*)'>(.*)</(.*)>";
		
		foreach(string str in strings)
		{
			if(str == "" || str == "<nullreferance>") continue;
			try
			{
				regex = Regex.Match(str, regexstr);
				if(regex.Groups[1].Value != "" |
				   regex.Groups[2].Value != "" |
				   regex.Groups[3].Value != "")
				{
                    string xval = "";
                    if (X_Base64) xval = Encoding.Default.GetString(Convert.FromBase64String(regex.Groups[3].Value));
                    else xval = regex.Groups[3].Value;
					setTypeValue(regex.Groups[1].Value, regex.Groups[2].Value, xval);
				}
			}
			catch
			{}
		}
		return obj;
	}

    public object DeSerializeWithCreateInstance(byte[] bytes)
    {
        return DeSerializeWithCreateInstance(System.Text.Encoding.Default.GetString(bytes));
    }

    public object DeSerializeWithCreateInstance(string xmlcodes)
    {
        string[] strings = xmlcodes.Split('\n');
        string anaregexstr = @"<(.*) Type='(.*)'>";
        Match regex = Regex.Match(strings[1], anaregexstr);
        Type anatip = Type.GetType(regex.Groups[2].Value);
        this.obj = Activator.CreateInstance(anatip);
        string regexstr = @"<(.*) Type='(.*)'>(.*)</(.*)>";

        foreach (string str in strings)
        {
            if (str == "" || str == "<nullreferance>") continue;
            try
            {
                regex = Regex.Match(str, regexstr);
                if (regex.Groups[1].Value != "" |
                   regex.Groups[2].Value != "" |
                   regex.Groups[3].Value != "")
                {
                    string xval = "";
                    if (X_Base64) xval = Encoding.Default.GetString(Convert.FromBase64String(regex.Groups[3].Value));
                    else xval = regex.Groups[3].Value;
                    setTypeValue(regex.Groups[1].Value, regex.Groups[2].Value, xval);
                }
            }
            catch
            { }
        }
        return obj;
    }

    private string getArrayValues(object value)
    {
        string lineend = System.Environment.NewLine;
        Array arr = (Array)value;
        string arrval = "<List Length='" + arr.Length + "' Type='" + arr.GetType().FullName + "'>" + lineend;
        for (int i = 0; i < arr.Length; i++)
        {
            arrval += "<Arr_" + i.ToString() + " Type='" + arr.GetValue(i).GetType() +"'>" + getArrayValue(arr.GetValue(i)) + "</Arr_" + i.ToString() + ">"+lineend;
        }
        arrval += "</List>";
        return Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(arrval));
    }

    private string getArrayValue(object value)
    {
        Type valueType = value.GetType();
        string val;
        if (valueType == typeof(string) |
           valueType == typeof(char) |
           valueType == typeof(bool) |
           valueType == typeof(sbyte) |
           valueType == typeof(byte) |
           valueType == typeof(ushort) |
           valueType == typeof(short) |
           valueType == typeof(uint) |
           valueType == typeof(int) |
           valueType == typeof(ulong) |
           valueType == typeof(long) |
           valueType == typeof(float) |
           valueType == typeof(Single) |
           valueType == typeof(double) |
           valueType == typeof(decimal) |
           valueType == typeof(DateTime))
        {
            val = value.ToString();
        }
        else if (valueType.BaseType == typeof(Array))
        {
            val = getArrayValues(value);
        }
        else if (valueType.BaseType == typeof(XmlSerializer))
        {
            val = Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(((XmlSerializer)value).EnSerialize()));
        }
        else
        {
            MemoryStream ms = new MemoryStream();
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            bf.Serialize(ms, value);
            byte[] bytes = new byte[ms.Length];
            ms.Read(bytes, 0, bytes.Length);
            val = Convert.ToBase64String(bytes);
        }
        return val;
    }

    private void setArrayValue(FieldInfo info, string Value)
    {
        Match regex;
        string xmlcodes = System.Text.Encoding.Default.GetString(Convert.FromBase64String(Value));
        string[] strings = xmlcodes.Split('\n');
        string regexstr = @"<List Length='(.*)' Type='(.*)'>";
        int length = 0;
        Type listType = null;
        foreach (string str in strings)
        {
            if (str == "" || str == "<nullreferance>") continue;
            try
            {
                regex = Regex.Match(str, regexstr);
                if (regex.Groups[1].Value != "")
                {
                    length = Convert.ToInt32(regex.Groups[1].Value);
                    listType = Type.GetType(regex.Groups[2].Value);
                }
            }
            catch { 
            
            }
        }
        Array arr=null;
        int selectval=-1;
        regexstr = @"<Arr_(.*) Type='(.*)'>(.*)</Arr_(.*)>";
        foreach (string str in strings)
        {
            if (str == "" || str == "<nullreferance>") continue;
            try
            {
                regex = Regex.Match(str, regexstr);
                if (regex.Groups[1].Value != "" |
                   regex.Groups[2].Value != "" |
                   regex.Groups[3].Value != "")
                {
                    selectval++;
                    Type valueType = Type.GetType(regex.Groups[2].Value);
                    if (arr == null) arr = Array.CreateInstance(valueType, length);
                    if (valueType == typeof(string))
                    {
                        arr.SetValue(regex.Groups[3].Value, selectval);
                    }
                    else if (valueType == typeof(char))
                    {
                        arr.SetValue(char.Parse(regex.Groups[3].Value), selectval);
                    }
                    else if (valueType == typeof(bool))
                    {
                        arr.SetValue(Boolean.Parse(regex.Groups[3].Value), selectval);
                    }
                    else if (valueType == typeof(sbyte))
                    {
                        arr.SetValue(sbyte.Parse(regex.Groups[3].Value), selectval);
                    }
                    else if (valueType == typeof(byte))
                    {
                        arr.SetValue(byte.Parse(regex.Groups[3].Value), selectval);
                    }
                    else if (valueType == typeof(ushort))
                    {
                        arr.SetValue(ushort.Parse(regex.Groups[3].Value), selectval);
                    }
                    else if (valueType == typeof(short))
                    {
                        arr.SetValue(short.Parse(regex.Groups[3].Value), selectval);
                    }
                    else if (valueType == typeof(uint))
                    {
                        arr.SetValue(uint.Parse(regex.Groups[3].Value), selectval);
                    }
                    else if (valueType == typeof(int))
                    {
                        arr.SetValue(int.Parse(regex.Groups[3].Value), selectval);
                    }
                    else if (valueType == typeof(ulong))
                    {
                        arr.SetValue(ulong.Parse(regex.Groups[3].Value), selectval);
                    }
                    else if (valueType == typeof(long))
                    {
                        arr.SetValue(long.Parse(regex.Groups[3].Value), selectval);
                    }
                    else if (valueType == typeof(float))
                    {
                        arr.SetValue(float.Parse(regex.Groups[3].Value), selectval);
                    }
                    else if (valueType == typeof(Single))
                    {
                        arr.SetValue(Single.Parse(regex.Groups[3].Value), selectval);
                    }
                    else if (valueType == typeof(double))
                    {
                        arr.SetValue(double.Parse(regex.Groups[3].Value), selectval);
                    }
                    else if (valueType == typeof(decimal))
                    {
                        arr.SetValue(decimal.Parse(regex.Groups[3].Value), selectval);
                    }
                    else if (valueType == typeof(DateTime))
                    {
                        arr.SetValue(DateTime.Parse(regex.Groups[3].Value), selectval);
                    }
                    else if (valueType == typeof(Array))
                    {
                        setArrayValue(info, regex.Groups[3].Value);
                    }
                    else if (valueType.BaseType == typeof(XmlSerializer))
                    {
                        string xmlcode = System.Text.Encoding.Default.GetString(Convert.FromBase64String(regex.Groups[3].Value));
                        object o = Activator.CreateInstance(valueType);
                        arr.SetValue(((XmlSerializer)o).DeSerialize(xmlcode), selectval);
                    }
                    else
                    {
                        byte[] bytes = Convert.FromBase64String(regex.Groups[3].Value);
                        MemoryStream ms = new MemoryStream();
                        ms.Write(bytes, 0, bytes.Length);
                        System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        object obj3 = bf.Deserialize(ms);
                        arr.SetValue(obj3, selectval);
                    }
                }
            }
            catch { 
            
            }
        }
        info.SetValue(obj, arr);
    }

    private string getTypeValue(FieldInfo value)
	{
		string val="";
		Type valueType = value.FieldType;
		if(valueType == typeof(string)|
		   valueType == typeof(char) |
		   valueType == typeof(bool)|
		   valueType == typeof(sbyte)|
		   valueType == typeof(byte)|
		   valueType == typeof(ushort)|
		   valueType == typeof(short)|
		   valueType == typeof(uint)|
		   valueType == typeof(int)|
		   valueType == typeof(ulong)|
		   valueType == typeof(long)|
		   valueType == typeof(float)|
		   valueType == typeof(Single)|
		   valueType == typeof(double)|
		   valueType == typeof(decimal)|
		   valueType == typeof(DateTime))
		{
			val = value.GetValue(obj).ToString();
		}
        else if (valueType.BaseType == typeof(Array))
        {
            val = getArrayValues(value.GetValue(obj));
        }
        else if (valueType.BaseType == typeof(XmlSerializer))
        {
            val = Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(((XmlSerializer)value.GetValue(obj)).EnSerialize()));
        }
        else
        {
            MemoryStream ms = new MemoryStream();
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            bf.Serialize(ms, value.GetValue(obj));
            byte[] bytes = new byte[ms.Length];
            ms.Read(bytes, 0, bytes.Length);
            val = Convert.ToBase64String(bytes);
        }
		return val;
	}
	
	private void setTypeValue(string fieldname, string type, string Value)
	{
		FieldInfo info = obj.GetType().GetField(fieldname, flags);
        if (info == null)
        {
            try
            {
                Type type1 = obj.GetType().BaseType;
                while (type1 != null)
                {
                    info = type1.GetField(fieldname, flags);
                    if (info == null)
                    {
                        try
                        {
                            type1 = type1.BaseType;
                        }
                        catch { type = null; }
                    }
                    else break;
                }
            }
            catch
            {

            }
        }
		Type valueType = info.FieldType;
		if(valueType == typeof(string))
		{
			info.SetValue(obj, Value);
		}
		else if(valueType == typeof(char))
		{
			info.SetValue(obj, char.Parse(Value));
		}
		else if(valueType == typeof(bool))
		{
			info.SetValue(obj, Boolean.Parse(Value));
		}
		else if(valueType == typeof(sbyte))
		{
			info.SetValue(obj, sbyte.Parse(Value));
		}
		else if(valueType == typeof(byte))
		{
			info.SetValue(obj, byte.Parse(Value));
		}
		else if(valueType == typeof(ushort))
		{
			info.SetValue(obj, ushort.Parse(Value));
		}
		else if(valueType == typeof(short))
		{
			info.SetValue(obj, short.Parse(Value));
		}
		else if(valueType == typeof(uint))
		{
			info.SetValue(obj, uint.Parse(Value));
		}
		else if(valueType == typeof(int))
		{
			info.SetValue(obj, int.Parse(Value));
		}
		else if(valueType == typeof(ulong))
		{
			info.SetValue(obj, ulong.Parse(Value));
		}
		else if(valueType == typeof(long))
		{
			info.SetValue(obj, long.Parse(Value));
		}
		else if(valueType == typeof(float))
		{
			info.SetValue(obj, float.Parse(Value));
		}
		else if(valueType == typeof(Single))
		{
			info.SetValue(obj, Single.Parse(Value));
		}
		else if(valueType == typeof(double))
		{
			info.SetValue(obj, double.Parse(Value));
		}
		else if(valueType == typeof(decimal))
		{
			info.SetValue(obj, decimal.Parse(Value));
		}
		else if(valueType == typeof(DateTime))
		{
			info.SetValue(obj, DateTime.Parse(Value));
		}
        else if (valueType.BaseType == typeof(Array))
        {
            setArrayValue(info, Value);
        }
        else if (valueType.BaseType == typeof(XmlSerializer))
        {
            string xmlcode = System.Text.Encoding.Default.GetString(Convert.FromBase64String(Value));
            object o = Activator.CreateInstance(valueType);
            info.SetValue(obj, ((XmlSerializer)o).DeSerialize(xmlcode));
        }
        else
        {
            byte[] bytes = Convert.FromBase64String(Value);
            MemoryStream ms = new MemoryStream();
            ms.Write(bytes, 0, bytes.Length);
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            object obj3 = bf.Deserialize(ms);
            info.SetValue(obj, obj3);
        }
	}
}
