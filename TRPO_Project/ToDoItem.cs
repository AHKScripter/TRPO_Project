using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_Project
{
    public partial class ToDoItem : UserControl
    {
        public ToDoItem()
        {
            InitializeComponent();
        }
        public ToDoItem(string text)
        {
            InitializeComponent();
            ToDoItem_lable_text.Text = text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlConnection SQL = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Targets;Integrated Security=True;Pooling=False");
            using (SQL)
            {
                SQL.Open();
                SqlCommand command = new SqlCommand("DELETE FROM TargetTab WHERE TargetText = '" + ToDoItem_lable_text.Text + "'", SQL);
                command.ExecuteNonQuery();
            }

            this.BackColor = Color.FromArgb(40, 177, 231);
            ToDoItem_lable_text.Text = "Deleted";
        }
    }
}
