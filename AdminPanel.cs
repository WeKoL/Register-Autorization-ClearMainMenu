using MySql.Data.MySqlClient;
using Register;
using SqlDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
namespace KR_Michalev
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();

        }
        public void Exit_Button_Click1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Back_Button_Click1(object sender, EventArgs e)
        {
            this.Hide();
            AutorizationForm autorizationForm = new AutorizationForm();
            autorizationForm.Show();
        }

        private void startSearch_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string query = "SELECT * FROM `users` WHERE `ID` = @IDuser OR `login` = @lg";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            command.Parameters.AddWithValue("IDuser", txtSearch.Text);
            command.Parameters.AddWithValue("lg", txtSearch.Text);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns["Id"].ReadOnly = true;
        }
        

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                startSearch.PerformClick();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users`", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView2.DataSource = table;
            dataGridView2.Columns["Id"].ReadOnly = true;
        }

    }
}
