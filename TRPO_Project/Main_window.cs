using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_Project
{
    public partial class Main_Window : Form
    {
        public Main_Window()
        {
            InitializeComponent();
        }

        private void Menu_button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_button_minimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
            time.Text = DateTime.Now.ToLongTimeString();
        }

        private void Menu_Button_Learning_Click(object sender, EventArgs e)
        {
            learning1.BringToFront();
        }

        private void Menu_button_books_Click(object sender, EventArgs e)
        {
            books1.BringToFront();
        }

        private void Menu_button_targets_Click(object sender, EventArgs e)
        {
            targets1.BringToFront();
        }

        private void Menu_button_ideas_Click(object sender, EventArgs e)
        {
            ideas1.BringToFront();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Chikipooki/TRPO_Project"); 
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/AHKScripter/TRPO_Project");
        }
    }
}
