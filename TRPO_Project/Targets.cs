using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TRPO_Project
{
    public partial class Targets : UserControl
    {
        public Targets()
        {
            InitializeComponent();
            getTargets();
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
            addTargets(tarName);
            Targets_text_box.Text = "";
        }

        void getTargets()
        {
            SqlConnection SQL = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Targets;Integrated Security=True;Pooling=False");
            using (SQL)
            {
                SQL.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM TargetTab WHERE TargetID = 3", SQL);
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
                SqlCommand commandSec = new SqlCommand("INSERT INTO TargetTab (TargetText, TargetID) VALUES ('" + insert + "', '3')", SQL);
                commandSec.ExecuteNonQuery();
            }
        }
    }
}
