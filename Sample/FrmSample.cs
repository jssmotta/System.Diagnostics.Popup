using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace DebugPopup
{
    public partial class FrmSample : Form
    {
        public FrmSample() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            var eml = new MailAddress("test@google.com", "test");

            eml.PopupBox();

            var n = 0;

            n.PopupBox();

            Handle.PopupBox();

            decimal.Zero.PopupBox(n==0, "n is equals zero!");
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Button)sender).PopupBox();
        }
    }
}
