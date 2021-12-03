using System;
using System.Windows.Forms;

/**
 * Drew Buchwald
 * buchwasa@mail.uc.edu
 * Final Project
 * Course: IT3045 Fall 2021
 * Due Date: 12/7/2021
 * Description: Main class to initialize Program
 */
namespace JokeManagerGUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new JokeManagerApp());
        }
    }
}
