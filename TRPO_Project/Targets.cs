using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_Project
{
    public partial class Targets : UserControl
    {
        public Targets()
        {
            InitializeComponent();
        }

        int poss = 10;

        public void addItem(string text)
        {
            ToDoItem item = new TRPO_Project.ToDoItem(text);
            Targets_list.Controls.Add(item);
            item.Top = poss;
            poss = (item.Top + item.Height + 10);

        }
        private void Targets_add_button_Click(object sender, EventArgs e)
        {
            string tarName = Targets_text_box.Text;
            addItem(tarName);
            Targets_text_box.Text = "";
        }
    }
}
