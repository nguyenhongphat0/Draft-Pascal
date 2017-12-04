using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Draft
{
    public class CodeFileManager
    {
        public static string managerFile = "manager";
        public static string virtualFilePrefix = Path.GetTempPath() + "void\\";
        public CodeFile currentFile;
        public List<CodeFile> openedFiles;

        public void updateView()
        {
            foreach (var file in openedFiles)
            {
                try
                {
                    file.bindToView();
                }
                catch (Exception)
                {
                    openedFiles.Remove(file);
                }
            }
            currentFile.browse();
        }

        public void newFile()
        {
            CodeFile file = new CodeFile();
            file.bindToView();
            openedFiles.Add(file);
            changeFile(file);
            export();
        }

        public void loadFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open file";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (var file in ofd.FileNames)
                {
                    loadFile(file);
                }
            }
        }

        public void loadFile(string filename)
        {
            foreach (var f in openedFiles)
            {
                if (f.realPath == filename)
                {
                    f.browse();
                    return;
                }
            }
            CodeFile file = new CodeFile(filename);
            file.bindToView();
            openedFiles.Add(file);
            changeFile(file);
            export();
        }

        public void saveFile()
        {
            currentFile.save();
            export();
        }

        public void synchronizeAll()
        {
            foreach (var file in openedFiles)
            {
                file.synchronize();
            }
        }

        public void changeFile(CodeFile file)
        {
            this.currentFile = file;
            file.browse();
            file.focus();
            export();
        }

        public void removeFile(CodeFile file)
        {
            if (openedFiles.Count == 1) newFile();
            file.dropFromView();
            openedFiles.Remove(file);
            if (!openedFiles.Contains(currentFile)) changeFile(openedFiles[0]);
            export();
        }

        public void import()
        {
            this.openedFiles = new List<CodeFile>();
            if (!File.Exists(managerFile))
            {
                File.Create(managerFile).Close();
                newFile();
            }
            else
            {
                try
                {
                    string[] lines = File.ReadAllLines(managerFile);
                    for (int i = lines.Length-1; i > 0; i--)
                    {
                        string[] ss = lines[i].Split('|');
                        if (!File.Exists(ss[0]) && ss[2] == "True") continue;
                        this.openedFiles.Insert(0, new CodeFile(ss));
                    }
                    int d = int.Parse(lines[0]);
                    if (d >= openedFiles.Count) d = 0;
                    this.currentFile = this.openedFiles[d];
                    updateView();
                }
                catch (Exception)
                {
                    File.Delete(managerFile);
                    import();
                }
            }
        }

        public void export()
        {
            List<string> lines = new List<string>();
            lines.Add(this.openedFiles.IndexOf(this.currentFile) + "");
            foreach (var file in openedFiles)
            {
                lines.Add(file.ToString());
            }
            File.WriteAllLines(managerFile, lines);
        }
    }
}
