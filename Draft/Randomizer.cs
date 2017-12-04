using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft
{
    class Randomizer
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
            string extension = ".c";
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
    }
}
