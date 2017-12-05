using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using System.Drawing;
using MaterialSkin;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Threading;

namespace Draft
{
	public partial class MainForm : MaterialForm
	{
        public static MainForm activeForm;
        public static CodeFileManager fileManager;

        public CommandBar commandBar;
        public MaterialSkinManager skinManager;
        Primary primaryColor = Primary.Grey900;
        Primary darkPrimaryColor = Primary.Red700;
        Primary lightPrimaryColor = Primary.Grey800;
        Accent accentColor = Accent.Green400;
        TextShade textShadeColor = TextShade.WHITE;
        public ConsoleBox inputBox;
        public ConsoleBox outputBox;

		public MainForm()
		{
			InitializeComponent();
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
                        fileManager.currentFile.synchronize();
                        if (fileManager.currentFile.compile(outputBox))
                        {
                            darkPrimaryColor = Primary.Orange500;
                            statusBar.BackColor = Color.Orange;
                            this.Update();
                            updateColorScheme();
                            SystemCommand.go("a.exe", "");
                            darkPrimaryColor = Primary.Green500;
                            updateColorScheme();
                        }
                        else
                        {
                            darkPrimaryColor = Primary.Red700;
                            updateColorScheme();
                            showDebugBox();
                        }
                        break;

                    default:
						break;
				}
                
				e.SuppressKeyPress = true;
				fileManager.currentFile.focus();
			}
		}

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
            accentColor = Accent.Green400;
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
            outputBox = new ConsoleBox("Output here", skinManager.ColorScheme.PrimaryColor, skinManager.ColorScheme.LightPrimaryColor, skinManager.ColorScheme.TextColor);
            rightTableLayoutPanel.Controls.Add(inputBox);
            rightTableLayoutPanel.Controls.Add(outputBox);
        }

        private void toggleDebugBox()
        {
            if (rightTableLayoutPanel.ColumnStyles[1].Width == 0)
            {
                showDebugBox();
            }
            else
            {
                hideDebugBox();
            }
        }

        private void hideDebugBox()
        {
            rightTableLayoutPanel.ColumnStyles[1].Width = 0;
        }

        private void showDebugBox()
        {
            rightTableLayoutPanel.ColumnStyles[1].Width = 300;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            activeForm = this;
            fileManager = new CodeFileManager();
            fileManager.import();
            addScrollBar();
            loadTheme();
            loadConsoleBox();
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
            mainTblLayout.Width = this.Width - 2;
            mainTblLayout.Height = this.Height - 65;
            commandBar.Top = 24;
            commandBar.Left = this.Width - commandBar.Width - 1;
        }
    }
}
