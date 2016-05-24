using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

static class SaveList
{
    public static string savePath = Application.StartupPath + "\\Saves\\";
    public static List<Items.ItemList> saveList = new List<Items.ItemList>();

    public static void ReadAllSaveFiles()
    {
        if (!Directory.Exists(savePath)) Directory.CreateDirectory(savePath);
        foreach (string file in Directory.GetFiles(savePath, "*.*", SearchOption.AllDirectories))
        {
            try
            {
                getSaveFileRead(file);
            }
            catch {
                //System.Windows.Forms.MessageBox.Show("Plugin read error : " + plugin);
            }
        }
    }

    public static void getSaveFileRead(string file)
    {
        byte[] bytes = File.ReadAllBytes(file);
        bytes = Compression.gZipDecompress(bytes);
        bytes = Cryptations.RC4(bytes, Encoding.Default.GetBytes("Emrah.?Kaynar.?20657580"));
        Items.ItemList itemList = ((Items.ItemList)(new XmlSerializer()).DeSerializeWithCreateInstance(bytes));
        saveList.Add(itemList);
    }

    public static T TypeCreator<T>(Type type)
    {
        return (T)Activator.CreateInstance(type);
    }

    public static void AddedOrChangeItemList(Items.ItemList itemList)
    {
        int itemint = -1;
        for(int i=0;i<saveList.Count;i++)
        {
            Items.ItemList item = saveList[i];
            if (item.GroupName == itemList.GroupName)
            {
                itemint = i;
                saveList[i] = itemList;
                return;
            }
        }
        if (itemint == -1) saveList.Add(itemList);
    }

    public static void SaveAllSaveFiles()
    {
        foreach (Items.ItemList item in saveList.ToArray())
        {
            string str = item.EnSerialize();
            byte[] bytes = Encoding.Default.GetBytes(str);
            bytes = Cryptations.RC4(bytes, Encoding.Default.GetBytes("Emrah.?Kaynar.?20657580"));
            bytes = Compression.gZipCompress(bytes);
            FileStream fstream = new FileStream(savePath + item.GroupName+".save", FileMode.Create);
            fstream.Write(bytes, 0, bytes.Length);
            fstream.Close();
            fstream = null;
        }
    }
}