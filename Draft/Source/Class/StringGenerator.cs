using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftPascal
{
    class StringGenerator
    {
        public static string aRandomString(int n)
        {
            string s = "";
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                s += (char)rand.Next(97, 122);
            }
            return s;
        }

        public static string aRandomFile(string basefile, string prefix)
        {
            string extension = ".pas";
            if (basefile != null)
            {
                FileInfo fi = new FileInfo(basefile);
                extension = fi.Extension;
            }
            string s;
            do
            {
                s = prefix + aRandomString(10) + extension;
            } while (File.Exists(s));
            return s;
        }

        public static string getBaseName(string fullname)
        {
            return Path.GetFileNameWithoutExtension(fullname);
        }

        public static string beautify(string std, string filePath)
        {
            return std.Replace(filePath, "").TrimStart(':', ' ');
        }
    }
}
