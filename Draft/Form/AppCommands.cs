using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Draft
{
    public partial class MainForm : MaterialForm
    {
        private void TextField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (commandBar.textField.Text.ToLower())
                {
                    case "load":
                        loadBtn_Click(null, null);
                        break;

                    case "save":
                        saveBtn_Click(null, null);
                        break;

                    case "new":
                        newBtn_Click(null, null);
                        break;

                    case "close":
                        Close();
                        break;

                    case "go":
                        go();
                        break;

                    case "stop":
                        stop();
                        break;

                    case "saveas":
                        saveAs();
                        break;

                    case "build":
                        build();
                        break;

                    case "spoj":
                        toggleInternalMode();
                        break;

                    case "std":
                        toggleDebugBox();
                        break;

                    default:
                        break;
                }

                e.SuppressKeyPress = true;
                fileManager.currentFile.focus();
            }
        }

        public void go()
        {
            if (executeThread != null && executeThread.IsAlive) stop();
            fileManager.currentFile.synchronize();
            if (fileManager.currentFile.compile(outputBox))
            {
                toRunMode();
                if (isInternalMode)
                {
                    executeProcess = SystemCommand.init(CodeFileManager.virtualFilePrefix + "a.exe", "");
                    executeProcess.Start();
                    executeThread = new Thread(new ThreadStart(() =>
                    {
                        executeProcess.StandardInput.WriteAsync(inputBox.textField.Text + "\n");
                        executeProcess.WaitForExit();
                        string output = executeProcess.StandardOutput.ReadToEnd();
                        string error = executeProcess.StandardError.ReadToEnd();
                        this.Invoke(new SafeSetText((string text, TextBox textbox) =>
                        {
                            textbox.Text = text;
                            toEditorMode();
                        }), error + output, outputBox.textField);
                    }));
                    executeThread.IsBackground = true;
                    executeThread.Start();
                }
                else
                {
                    SystemCommand.go("a.exe", "");
                    toEditorMode();
                }
            }
            else
            {
                toBugMode();
                showDebugBox();
            }
        }

        public void stop()
        {
            try
            {
                executeThread.Abort();
                executeProcess.Kill();
                toEditorMode();
            }
            catch
            {

            }
        }

        public void build()
        {
            if (fileManager.currentFile.compile(outputBox))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Execute file|*.exe";
                sfd.Title = "Compile to";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(CodeFileManager.virtualFilePrefix + "a.exe", sfd.FileName);
                    MessageBox.Show("Program successfully compiled to " + sfd.FileName);
                }
            }
        }

        public void saveAs()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "C files|*.c|All files|*.*";
            sfd.Title = "Save as";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fileManager.currentFile.realPath = sfd.FileName;
                fileManager.currentFile.save();
            }
        }
    }
}
