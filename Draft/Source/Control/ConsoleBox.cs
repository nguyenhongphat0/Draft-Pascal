using System;
using System.Drawing;
using System.Windows.Forms;

namespace Draft
{
	public partial class ConsoleBox : UserControl
	{
        public Color defaultColor;
        public Color focusColor;
        public Color textColor;

		public ConsoleBox(string placeholder, Color defaultColor, Color focusColor, Color textColor)
		{
			InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.placeholder.Text = placeholder.ToUpper();
            this.defaultColor = defaultColor;
            this.focusColor = focusColor;
            this.textColor = textColor;
            textField.ForeColor = textColor;
            setBackColor(defaultColor);
		}

		public void setBackColor(Color color)
		{
			this.textField.BackColor = color;
			this.BackColor = color;
		}

		private void textField_Enter(object sender, EventArgs e)
        {
            setBackColor(focusColor);
		}

		private void textField_Leave(object sender, EventArgs e)
        {
            setBackColor(defaultColor);
		}

        private void textField_TextChanged(object sender, EventArgs e)
        {
            if (textField.Text == "") placeholder.Visible = true;
            else placeholder.Visible = false;
        }

        private void ConsoleBox_Resize(object sender, EventArgs e)
        {
            placeholder.Left = this.Width / 2 - placeholder.Width / 2;
            placeholder.Top = this.Height / 2 - placeholder.Height / 2;
        }

        private void placeholder_Click(object sender, EventArgs e)
        {
            textField.Focus();
        }
    }
}
