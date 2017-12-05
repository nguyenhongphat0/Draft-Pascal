using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using System.Drawing;
using MaterialSkin;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
using System.ComponentModel;

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

        bool isSafeMode = false;
        bool isInternalMode = false;
        bool isDebugShowed = false;

		public MainForm()
		{
			InitializeComponent();
            addScrollBar();
            loadTheme();
            loadConsoleBox();
            stopBtn.Visible = false;
        }

		private void TextField_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				switch (commandBar.textField.Text)
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

                    default:
						break;
				}
                
				e.SuppressKeyPress = true;
				fileManager.currentFile.focus();
			}
		}

        private delegate void SafeSetText(string text, TextBox textbox);

        private void addScrollBar()
        {
            leftPanel.HorizontalScroll.Enabled = false;
            leftPanel.HorizontalScroll.Visible = false;
            leftPanel.HorizontalScroll.Maximum = 0;
            leftPanel.AutoScroll = true;
        }
        
        private void updateColorScheme()
        {
            skinManager.ColorScheme = new ColorScheme(primaryColor, darkPrimaryColor, lightPrimaryColor, accentColor, textShadeColor);
            statusBar.BackColor = skinManager.ColorScheme.DarkPrimaryColor;
        }

        private void loadTheme()
        {
            skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            primaryColor = Primary.Grey900;
            darkPrimaryColor = Primary.Green500;
            lightPrimaryColor = Primary.Grey800;
            accentColor = Accent.LightGreen700;
            textShadeColor = TextShade.WHITE;
            updateColorScheme();
            commandBar = new CommandBar(skinManager.ColorScheme.PrimaryColor, skinManager.ColorScheme.LightPrimaryColor, skinManager.ColorScheme.TextColor);
            commandBar.textField.KeyDown += TextField_KeyDown;
            this.Controls.Add(commandBar);
            mainForm_Resize(null, null);
        }

        private void loadConsoleBox()
        {
            inputBox = new ConsoleBox("Input here", skinManager.ColorScheme.PrimaryColor, skinManager.ColorScheme.LightPrimaryColor, skinManager.ColorScheme.TextColor);
            //inputBox.Margin = new Padding(6);
            outputBox = new ConsoleBox("Output here", skinManager.ColorScheme.PrimaryColor, skinManager.ColorScheme.LightPrimaryColor, skinManager.ColorScheme.TextColor);
            //outputBox.Margin = new Padding(6, 0, 6, 6);
            rightTableLayoutPanel.Controls.Add(inputBox);
            rightTableLayoutPanel.Controls.Add(outputBox);
        }

        private void toggleDebugBox()
        {
            if (isDebugShowed)
            {
                hideDebugBox();
            }
            else
            {
                showDebugBox();
            }
        }

        private void hideDebugBox()
        {
            rightTableLayoutPanel.ColumnStyles[1].Width = 0;
            toggleDebugBtn.BackColor = Color.Transparent;
            isDebugShowed = false;
        }

        private void showDebugBox()
        {
            rightTableLayoutPanel.ColumnStyles[1].Width = 300;
            toggleDebugBtn.BackColor = skinManager.ColorScheme.LightPrimaryColor;
            isDebugShowed = true;
        }

        private void saveLastState()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                Properties.Settings.Default.Location = RestoreBounds.Location;
                Properties.Settings.Default.Size = RestoreBounds.Size;
                Properties.Settings.Default.Maximized = true;
                Properties.Settings.Default.Minimized = false;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.Location = Location;
                Properties.Settings.Default.Size = Size;
                Properties.Settings.Default.Maximized = false;
                Properties.Settings.Default.Minimized = false;
            }
            else
            {
                Properties.Settings.Default.Location = RestoreBounds.Location;
                Properties.Settings.Default.Size = RestoreBounds.Size;
                Properties.Settings.Default.Maximized = false;
                Properties.Settings.Default.Minimized = true;
            }
            Properties.Settings.Default.Save();
        }

        private void loadLastState()
        {
            if (Properties.Settings.Default.Maximized)
            {
                WindowState = FormWindowState.Maximized;
                Location = Properties.Settings.Default.Location;
                Size = Properties.Settings.Default.Size;
            }
            else if (Properties.Settings.Default.Minimized)
            {
                WindowState = FormWindowState.Minimized;
                Location = Properties.Settings.Default.Location;
                Size = Properties.Settings.Default.Size;
            }
            else
            {
                Location = Properties.Settings.Default.Location;
                Size = Properties.Settings.Default.Size;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            activeForm = this;
            loadLastState();
            fileManager = new CodeFileManager();
            fileManager.import();
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
                else if (e.KeyCode == Keys.Oemtilde)
                {
                    toggleDebugBox();
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

        private void stopBtn_Click(object sender, EventArgs e)
        {
            executeThread.Abort();
            executeProcess.Kill();
            toEditorMode();
        }
    }
}
