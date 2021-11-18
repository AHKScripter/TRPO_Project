using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_Project
{
    public partial class Ideas : UserControl
    {
        public Ideas()
        {
            InitializeComponent();
        }

        int poss = 10;
        public void addItem(string text)
        {
            ToDoItem item = new TRPO_Project.ToDoItem(text);
            Ideas_list.Controls.Add(item);
            item.Top = poss;
            poss = (item.Top + item.Height + 10);

        }

        private void Ideas_add_button_Click(object sender, EventArgs e)
        {
            string tarName = Ideas_text_box.Text;
            addItem(tarName);
            Ideas_text_box.Text = "";
        }
    }
}
