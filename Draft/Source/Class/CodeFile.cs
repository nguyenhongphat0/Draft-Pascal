﻿using FastColoredTextBoxNS;
using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DraftPascal
{
    public class CodeFile
    {
        public IDEBox editor;
        public MaterialFlatButton button;
        public string realPath;
        public string virtualPath;
        public bool isSaved;
        public bool isModified = false;

        public CodeFile()
        {
            this.virtualPath = StringGenerator.aRandomFile(this.realPath, CodeFileManager.virtualFilePrefix);
            this.isSaved = false;
            this.createOnDisk(virtualPath);
        }

        public CodeFile(string path)
        {
            this.realPath = path;
            this.virtualPath = StringGenerator.aRandomFile(this.realPath, CodeFileManager.virtualFilePrefix);
            File.WriteAllText(virtualPath, File.ReadAllText(realPath));
            this.isSaved = true;
        }

        public CodeFile(string[] param)
        {
            this.realPath = param[0];
            this.virtualPath = param[1];
            this.isSaved = bool.Parse(param[2]);
            this.isModified = bool.Parse(param[3]);
        }

        public string getFilename(bool isRealPath)
        {
            return new FileInfo(isRealPath? realPath : virtualPath).Name;
        }

        public string getDirectory(bool isRealPath)
        {
            return new FileInfo(isRealPath ? realPath : virtualPath).DirectoryName;
        }

        public string getExtension()
        {
            return new FileInfo(virtualPath).Extension;
        }
        
        public void bindToView()
        {
            editor = new IDEBox();
            editor.Language = Language.Custom;
            editor.AutoIndentNeeded += (Object sender, AutoIndentEventArgs e) =>
            {
                if (e.LineText.Trim().ToLower() == "begin")
                {
                    e.ShiftNextLines = e.TabLength;
                    return;
                }
                if (Regex.IsMatch(e.LineText.Trim().ToLower(), @"end(;|.)"))
                {
                    e.Shift = -e.TabLength;
                    e.ShiftNextLines = -e.TabLength;
                    return;
                }
                if (Regex.IsMatch(e.PrevLineText.ToLower(), @"\b(do|then|else)\b") && !Regex.IsMatch(e.PrevLineText.ToLower(), @"\b(begin)\b"))
                {
                    e.Shift = e.TabLength;
                    return;
                }
            };
            switch (getExtension())
            {
                case ".pas":
                    editor.DescriptionFile = "syntax\\" + Properties.Settings.Default.SyntaxHighlightColor;
                    break;
                default:
                    editor.DescriptionFile = null;
                    break;
            }
            editor.Text = File.ReadAllText(virtualPath);
            editor.KeyDown += Editor_KeyDown;
            editor.TextChanged += Editor_TextChanged;
            MainForm.activeForm.idePanel.Controls.Add(editor);
            button = new MaterialFlatButton();
            button.MouseUp += Button_MouseUp;
            MainForm.activeForm.leftPanel.Controls.Add(button);
            updateView();
        }

        public void dropFromView()
        {
            MainForm.activeForm.leftPanel.Controls.Remove(this.button);
            MainForm.activeForm.idePanel.Controls.Remove(this.editor);
        }

        public void updateView()
        {
            string s = "";
            if (isSaved)
            {
                s += Path.GetFileName(realPath);
                if (isModified) s += "*";
            }
            else s += "{DRAFT}";
            button.Text = s;
            MainForm.activeForm.title.Text = s;
        }

        public void focus()
        {
            this.editor.Focus();
        }

        private void Editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!isModified)
            {
                modify();
            }
        }

        private void Editor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.S)
                {
                    this.save();
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                synchronize();
            }
        }

        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainForm.fileManager.changeFile(this);
            }
            else if (e.Button == MouseButtons.Right)
            {
                MainForm.fileManager.removeFile(this);
            }
        }

        public void createOnDisk(string filename)
        {
            if (!Directory.Exists(Path.GetDirectoryName(filename)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filename));
            }
            FileStream fs = File.Create(filename);
            fs.Close();
        }

        public void browse()
        {
            editor.BringToFront();
            updateView();
        }

        public void close()
        {
            MainForm.fileManager.removeFile(this);
        }

        public void save()
        {
            if (isSaved)
            {
                File.WriteAllText(this.realPath, editor.Text);
                synchronize();
                isModified = false;
                updateView();
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PAS files|*.pas|All files|*.*";
                sfd.Title = "Save file to";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    realPath = sfd.FileName;
                    isSaved = true;
                    save();
                }
                else return;
            }
        }

        public void synchronize()
        {
            File.WriteAllText(this.virtualPath, editor.Text);
            updateView();
        }

        public void modify()
        {
            isModified = true;
            updateView();
        }
        
        public bool compile(ConsoleBox log)
        {
            try
            {
                Process p = SystemCommand.init(SystemCommand.fpc(), this.getFilename(false));
                p.Start();
                p.WaitForExit();
                string output = p.StandardOutput.ReadToEnd();
                string error = p.StandardError.ReadToEnd();
                if (p.ExitCode == 0) return true;
                else
                {
                    log.textField.Text = StringGenerator.beautify(error + output, this.getFilename(false));
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(MainForm.activeForm, "FPC could not be found on your computer! Please visit our homepage for the resolution", "Compile error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public override string ToString()
        {
            return realPath + "|" + virtualPath + "|" + isSaved + "|" + isModified;
        }
    }
}
