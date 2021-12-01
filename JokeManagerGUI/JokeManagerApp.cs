using JokeManagerNamespace;
using System;
using System.Windows.Forms;

namespace JokeManagerGUI
{
    public partial class JokeManagerApp : Form
    {
        public JokeManagerApp()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String ucid = this.txtUCID.Text;
            String joke = this.txtJoke.Text;

            int submittedJoke = JokeManager.SaveJoke(ucid, joke);
            if (submittedJoke == -1)
            {
                SuccessDialog popup = new SuccessDialog();
                popup.ShowDialog();
            } 
            else
            {
                FailedDialog popup = new FailedDialog();
                popup.ShowDialog();
            }
        }
    }
}
