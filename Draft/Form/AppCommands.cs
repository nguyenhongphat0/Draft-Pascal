using MaterialSkin;
using MaterialSkin.Controls;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Draft
{
    public partial class MainForm : MaterialForm
    {
        Process executeProcess;

        public void go()
        {
            if (executeThread != null && executeThread.IsAlive)
            {
                if (MessageBox.Show(this, "The current program is still running. Click \"Yes\" to stop it and start a new one, or \"No\" to wait for it to complete?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    executeThread.Abort();
                }
                else
                {
                    return;
                }
            }
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

        public void toRunMode()
        {
            darkPrimaryColor = Primary.Orange500;
            statusBar.BackColor = Color.Orange;
            this.Update();
            updateColorScheme();
            runBtn.Visible = false;
            stopBtn.Visible = true;
        }

        public void toBugMode()
        {
            darkPrimaryColor = Primary.Red700;
            updateColorScheme();
            runBtn.Visible = true;
            stopBtn.Visible = false;
        }

        public void toEditorMode()
        {
            darkPrimaryColor = Primary.Green500;
            updateColorScheme();
            runBtn.Visible = true;
            stopBtn.Visible = false;
        }
    }
}
