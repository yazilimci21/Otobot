using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

static class PluginList
{
    public static string pluginpath = Application.StartupPath + "\\Plugin\\";
    public static List<Type> RunnerTypeList = new List<Type>();
    public static List<Types.Runner> RunnerList = new List<Types.Runner>();

    public static void ReadAllPluginsInTypes()
    {
        getAssemblyRead(Assembly.GetExecutingAssembly());
        if (!Directory.Exists(pluginpath)) Directory.CreateDirectory(pluginpath);
        foreach (string plugin in Directory.GetFiles(pluginpath, "*.dll", SearchOption.AllDirectories))
        {
            try
            {
                getAssemblyRead(Assembly.LoadFile(plugin));
            }
            catch {
                //System.Windows.Forms.MessageBox.Show("Plugin read error : " + plugin);
            }
        }
    }

    private static void getAssemblyRead(Assembly asm)
    {
        foreach (Type type in asm.GetTypes())
        {
            if (type.BaseType == null) continue;
            if (type.BaseType == Type.GetType("Types.Runner"))
            {
                RunnerTypeList.Add(type);
                RunnerList.Add((Types.Runner)Activator.CreateInstance(type));
            }
        }
    }

    public static T TypeCreator<T>(Type type)
    {
        return (T)Activator.CreateInstance(type);
    }
}