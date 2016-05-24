using System;
using System.Runtime.InteropServices;
using System.Drawing;

#region IconExtractor
    class IconExtractor
    {
        [DllImport("shell32.dll", EntryPoint = "ExtractIconEx")]
        private static extern int ExtractIconExA(string lpszFile, int nIconIndex, ref IntPtr phiconLarge, ref IntPtr phiconSmall, int nIcons);

        [DllImport("user32")]
        private static extern int DestroyIcon(IntPtr hIcon);

        #region IconExractor //Emrah KAYNAR
        static Image icon;
        static string foldericon;
        static int foldericonindex;
        static int nicon;

        public static Image geticon(string file)
        {
            System.IO.FileInfo info = new System.IO.FileInfo(file);
            try
            {
                icon = ExtractIconLarge(file, 0).ToBitmap();
                return icon;
            }
            catch
            {
                try
                {
                    string icopath = string.Empty;
                    icopath = Microsoft.Win32.Registry.GetValue(@"HKEY_CLASSES_ROOT\" + info.Extension, "", icopath).ToString();
                    string icona = string.Empty;
                    icona = Microsoft.Win32.Registry.GetValue(@"HKEY_CLASSES_ROOT\" + icopath + @"\DefaultIcon", "", icona).ToString();
                    try
                    {
                        string[] ico = icona.Split(',');
                        icona = ico[0];
                        if (icona.IndexOf('"') > -1) icona = icona.Substring(1, (icona.Length - 2));
                        //icon getir
                        icon = ExtractIconLarge(icona, Convert.ToInt32(ico[1])).ToBitmap();
                        return icon;
                    }
                    catch
                    {
                        if (icona.IndexOf('"') > -1) icona = icona.Substring(1, (icona.Length - 2));
                        icon = Icon.ExtractAssociatedIcon(icona).ToBitmap();
                        return icon;
                    }
                }
                catch
                {
                    try
                    {
                        info = new System.IO.FileInfo(file);
                        icon = ExtractIconLarge(Bac(info), 0).ToBitmap();
                        return icon;
                    }
                    catch
                    {
                        #region Klasör
                        try
                        {
                            string yazi = System.IO.File.ReadAllText(file);
                            icon = ExtractIconLarge(@"%SystemRoot%\system32\SHELL32.dll", 0).ToBitmap();
                            return icon;
                        }
                        catch
                        {
                            try
                            {
                                try
                                {
                                    System.IO.DirectoryInfo inf = new System.IO.DirectoryInfo(file);
                                    foreach (string desktop in System.IO.File.ReadAllLines(file + @"\desktop.ini"))
                                    {
                                        string[] str = desktop.Split('=');
                                        switch (str[0])
                                        {
                                            case "IconFile":
                                                foldericon = str[1];
                                                nicon = 1;
                                                break;
                                            case "IconIndex":
                                                foldericonindex = Convert.ToInt32(str[1]);
                                                nicon = 2;
                                                break;
                                            default:
                                                nicon = 0;
                                                break;
                                        }
                                    }
                                    if (nicon == 1)
                                    {
                                        try
                                        {
                                            icon = ExtractIconLarge(foldericon, 0).ToBitmap();
                                        }
                                        catch
                                        {
                                            icon = Icon.ExtractAssociatedIcon(foldericon).ToBitmap();

                                        }
                                    }
                                    if (nicon == 2)
                                    {
                                        icon = ExtractIconLarge(foldericon, foldericonindex).ToBitmap();
                                    }
                                    if (nicon == 0)
                                    {
                                        icon = ExtractIconLarge(@"%SystemRoot%\system32\SHELL32.dll", 3).ToBitmap();
                                    }
                                    return icon;
                                }
                                catch
                                {
                                    System.IO.DirectoryInfo inf = new System.IO.DirectoryInfo(file);
                                    icon = ExtractIconLarge(@"%SystemRoot%\system32\SHELL32.dll", 3).ToBitmap();
                                    return icon;
                                }
                            }
                            catch
                            {
                                icon = ExtractIconLarge(@"%SystemRoot%\system32\SHELL32.dll", 0).ToBitmap();
                                return icon;
                            }
                        }
                        #endregion
                    }
                }
            }
        }

        private static string Bac(System.IO.FileInfo info)
        {
            string _tur = string.Empty;
            _tur = Microsoft.Win32.Registry.GetValue(@"HKEY_CLASSES_ROOT\" + info.Extension, "", _tur).ToString();
            string bac = string.Empty;
            bac = Microsoft.Win32.Registry.GetValue(@"HKEY_CLASSES_ROOT\" + _tur + @"\shell\open\command", "", bac).ToString();
            if (bac.IndexOf('"') > -1) bac = bac.Substring(1, (bac.Length - 7));
            else bac = bac.Substring(1, (bac.Length - 4));
            if(bac.Substring(0, 18).ToLower() == @":\windows\system32") bac = Environment.SystemDirectory + bac.Substring(18, bac.Length-18);
            return bac;
        }
        #endregion

        //Attempts to extract the small-version of the applicaiton's icon
        public static Icon ExtractIconSmall(string path, int IconIndex)
        {
            IntPtr largeIcon = IntPtr.Zero;
            IntPtr smallIcon = IntPtr.Zero;
            ExtractIconExA(path, IconIndex, ref largeIcon, ref smallIcon, 1);

            //Transform the bits into the icon image
            Icon returnIcon = null;
            if (smallIcon != IntPtr.Zero)
                returnIcon = Icon.FromHandle(smallIcon);

            //clean up
            DestroyIcon(largeIcon);

            return returnIcon;
        }

        //Attempts to extract the large-version of the application's icon
        public static Icon ExtractIconLarge(string path, int IconIndex)
        {
            IntPtr largeIcon = IntPtr.Zero;
            IntPtr smallIcon = IntPtr.Zero;
            ExtractIconExA(path, IconIndex, ref largeIcon, ref smallIcon, 1);

            //Transform the bits into the icon image
            Icon returnIcon = null;
            if (largeIcon != IntPtr.Zero)
                returnIcon = Icon.FromHandle(largeIcon);

            //clean up
            DestroyIcon(smallIcon);

            return returnIcon;
        }

        //Returns the large icon if found, if not the small icon
        public static Icon ExtractIcon(string path, int IconIndex)
        {
            Icon largeIcon = ExtractIconLarge(path, IconIndex);

            if (largeIcon == null)
                return ExtractIconSmall(path, IconIndex);
            else
                return largeIcon;
        }
    }
    #endregion
