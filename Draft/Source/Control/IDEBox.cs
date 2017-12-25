using System.Windows.Forms;

namespace DraftPascal
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
