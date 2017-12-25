using System;
using System.Drawing;
using System.Windows.Forms;

namespace DraftPascal
{
	public partial class CommandBar : UserControl
	{
        public Color defaultColor;
        public Color focusColor;
        public Color textColor;
        public String placeholder;

		public CommandBar(Color defaultColor, Color focusColor, Color textColor)
		{
			InitializeComponent();
            this.placeholder = textField.Text;
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
            textField.Font = new Font(textField.Font, FontStyle.Bold);
            textField.Text = "";
            setBackColor(focusColor);
		}

		private void textField_Leave(object sender, EventArgs e)
        {
            textField.Font = new Font(textField.Font, FontStyle.Italic);
            textField.Text = placeholder;
            setBackColor(defaultColor);
		}
	}
}
