using System.Windows.Forms;

namespace Draft
{
    public partial class IDEBox : FastColoredTextBoxNS.FastColoredTextBox
    {
        public IDEBox()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
    }
}
