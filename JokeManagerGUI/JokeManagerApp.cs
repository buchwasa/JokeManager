using JokeManagerNamespace;
using System;
using System.Windows.Forms;

/**
 * Drew Buchwald
 * buchwasa@mail.uc.edu
 * Final Project
 * Course: IT3045 Fall 2021
 * Due Date: 12/7/2021
 * Description: GUI for JokeManager
 */
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
            string ucid = txtUCID.Text;
            string joke = txtJoke.Text;

            int submittedJoke = JokeManager.SaveJoke(ucid, joke);
            if (submittedJoke == -1)
            {
                UpdateNodes();
                SuccessDialog popup = new SuccessDialog();
                popup.ShowDialog();
            } 
            else
            {
                FailedDialog popup = new FailedDialog();
                popup.ShowDialog();
            }
        }

        private void JokeManagerApp_Load(object sender, EventArgs e)
        {
            UpdateNodes();
        }

        private void UpdateNodes()
        {
            tvJokes.Nodes.Clear();
            foreach (var jokes in JokeManager.GetJokes())
            {
                TreeNode currentNode = tvJokes.Nodes.Add(jokes.Key);
                currentNode.Nodes.Add(jokes.Value);
            }
        }
    }
}
