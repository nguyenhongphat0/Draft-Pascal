using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using System.Drawing;
using MaterialSkin;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace Draft
{
    public partial class MainForm : MaterialForm
    {
        public static MainForm activeForm;
        public static CodeFileManager fileManager;
        public static Thread executeThread;

        public CommandBar commandBar;
        public MaterialSkinManager skinManager;
        Primary primaryColor = Primary.Grey900;
        Primary darkPrimaryColor = Primary.Green500;
        Primary lightPrimaryColor = Primary.Grey800;
        Accent accentColor = Accent.LightGreen700;
        TextShade textShadeColor = TextShade.WHITE;
        public ConsoleBox inputBox;
        public ConsoleBox outputBox;
        public Process executeProcess;
        public string[] args;

        bool isSafeMode = false;
        bool isInternalMode = false;
        bool isDebugShowed = false;

        public MainForm(string[] args)
		{
			InitializeComponent();
            addScrollBar();
            loadTheme();
            loadConsoleBox();
            stopBtn.Visible = false;
            this.args = args;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            activeForm = this;
            loadLastState();
            fileManager = new CodeFileManager();
            fileManager.import();
            foreach (var f in args)
            {
                fileManager.loadFile(f);
            }
        }
        
        private void saveBtn_Click(object sender, EventArgs e)
        {
            fileManager.saveFile();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            fileManager.loadFile();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            fileManager.newFile();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            fileManager.synchronizeAll();
            fileManager.export();
            saveLastState();
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    commandBar.Focus();
                }
                else if (e.KeyCode == Keys.O)
                {
                    fileManager.loadFile();
                }
                else if (e.KeyCode == Keys.F9)
                {
                    go();
                }
                else if (e.KeyCode == Keys.F8)
                {
                    stop();
                }
                else if (e.KeyCode == Keys.Oemtilde)
                {
                    toggleDebugBox();
                }
                else if (e.KeyCode == Keys.P)
                {
                    toggleInternalMode();
                }
                else if (e.KeyCode == Keys.ControlKey)
                {
                    // only Ctrl here
                }
                //else
                //{
                //    MessageBox.Show(e.KeyCode.ToString());
                //}
            }
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            commandBar.Top = 24;
            commandBar.Left = this.Width - commandBar.Width - 1;
            mainTblLayout.Width = this.Width - 2;
            mainTblLayout.Height = this.Height - 65;
        }

        private void toggleDebugBtn_Click(object sender, EventArgs e)
        {
            toggleDebugBox();
        }

        private void toggleInternalMode()
        {
            if (isInternalMode)
            {
                toggleInternalModeBtn.BackColor = Color.Transparent;
            }
            else
            {
                toggleInternalModeBtn.BackColor = skinManager.ColorScheme.LightPrimaryColor;
            }
            isInternalMode = !isInternalMode;
        }

        private void toggleInternalModeBtn_Click(object sender, EventArgs e)
        {
            toggleInternalMode();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            go();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            stop();
        }

        private void buildBtn_Click(object sender, EventArgs e)
        {
            build();
        }

        private void saveAsBtn_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            fileManager.currentFile.editor.Undo();
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            fileManager.currentFile.editor.Redo();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            fileManager.currentFile.editor.ShowFindDialog();
        }

        private void replaceBtn_Click(object sender, EventArgs e)
        {
            fileManager.currentFile.editor.ShowReplaceDialog();
        }
    }
}
