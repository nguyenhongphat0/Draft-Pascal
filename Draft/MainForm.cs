using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using System.Drawing;
using MaterialSkin;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace Draft
{
	public partial class MainForm : MaterialForm
	{
        public static MainForm activeForm;
        public static CodeFileManager fileManager;

        public CommandBar commandBar;
        public MaterialSkinManager skinManager;

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

					default:
						break;
				}
                
				e.SuppressKeyPress = true;
				fileManager.currentFile.focus();
			}
		}

		private void mainForm_Resize(object sender, EventArgs e)
		{
            this.WindowState = FormWindowState.Normal;
            mainTblLayout.Width = this.Width - 2;
            mainTblLayout.Height = this.Height - 65;
            commandBar.Top = 24;
            commandBar.Left = this.Width - 241;
        }

        private void setTheme()
        {
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            Primary primary = Primary.Grey900;
            Primary darkPrimary = Primary.Green500;
            Primary lightPrimary = Primary.Grey800;
            Accent accent = Accent.Green400;
            TextShade textShade = TextShade.WHITE;
            skinManager.ColorScheme = new ColorScheme(primary, darkPrimary, lightPrimary, accent, textShade);
            statusBar.BackColor = skinManager.ColorScheme.DarkPrimaryColor;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            activeForm = this;
            fileManager = new CodeFileManager();
            fileManager.import();
            leftPanel.HorizontalScroll.Enabled = false;
            leftPanel.HorizontalScroll.Visible = false;
            leftPanel.HorizontalScroll.Maximum = 0;
            leftPanel.AutoScroll = true;

            skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            setTheme();
            commandBar = new CommandBar(skinManager.ColorScheme.PrimaryColor, skinManager.ColorScheme.LightPrimaryColor, skinManager.ColorScheme.TextColor);
            commandBar.textField.KeyDown += TextField_KeyDown;
            this.Controls.Add(commandBar);
            mainForm_Resize(null, null);
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
    }
}
