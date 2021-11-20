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
    public partial class Ideas : UserControl
    {
        public Ideas()
        {
            InitializeComponent();
            getTargets();
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
            addTargets(tarName);
            Ideas_text_box.Text = "";
        }

        void getTargets()
        {
            SqlConnection SQL = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Targets;Integrated Security=True;Pooling=False");
            using (SQL)
            {
                SQL.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM TargetTab WHERE TargetID = 4", SQL);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        addItem("" + reader["TargetText"]);
                    }
                }
            }
        }

        public void addTargets(string insert)
        {
            SqlConnection SQL = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Targets;Integrated Security=True;Pooling=False");
            using (SQL)
            {
                SQL.Open();
                SqlCommand commandSec = new SqlCommand("INSERT INTO TargetTab (TargetText, TargetID) VALUES ('" + insert + "', '4')", SQL);
                commandSec.ExecuteNonQuery();
            }
        }
    }
}
