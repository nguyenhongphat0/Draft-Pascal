using MaterialSkin.Controls;
using System.Windows.Forms;
using System.Drawing;
using MaterialSkin;

namespace DraftPascal
{
    public partial class MainForm : MaterialForm
    {
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
            if (Properties.Settings.Default.SyntaxHighlightColor == null)
            {
                Properties.Settings.Default.SyntaxHighlightColor = "default.xml";
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
