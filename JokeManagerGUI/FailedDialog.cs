using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokeManagerGUI
{
    public partial class FailedDialog : Form
    {
        public FailedDialog()
        {
            InitializeComponent();
        }

        private void btnCloseFailed_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
