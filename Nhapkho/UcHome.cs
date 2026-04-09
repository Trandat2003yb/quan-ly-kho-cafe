using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
        }

        public void SetTitle(string text)
        {
            if (!string.IsNullOrWhiteSpace(text))
                lblTitle.Text = text;
        }
    }
}
