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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace KR_Michalev
{
    public partial class AdminPanel : Form
    {
        DataSet dsUsers;
        MySqlDataAdapter adapterUsers;
        DataSet dsResourse;
        MySqlDataAdapter adapterResourse;
        MySqlCommandBuilder commandBuilder;
        string connectionString = @"server=localhost;user=root;database=workc;port=3306;password=root";
        string sqlUsers = "SELECT * FROM Users";
        string sqlResourse = "SELECT * FROM Resourse";

        public AdminPanel()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                adapterUsers = new MySqlDataAdapter(sqlUsers, connection);

                dsUsers = new DataSet();
                adapterUsers.Fill(dsUsers);
                dataGridView1.DataSource = dsUsers.Tables[0];
                // делаем недоступным столбец id для изменения
                dataGridView1.Columns["id"].ReadOnly = true;
            }

            //

            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.AllowUserToAddRows = false;

            string sqlResourse = "SELECT * FROM resourse";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                adapterResourse = new MySqlDataAdapter(sqlResourse, connection);

                dsResourse = new DataSet();
                adapterResourse.Fill(dsResourse);
                dataGridView2.DataSource = dsResourse.Tables[0];
                // делаем недоступным столбец id для изменения
                dataGridView2.Columns["id"].ReadOnly = true;
            }
        }

        // Закрыть окно/прикрыть окно
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


        // кнопка добавления
        private void addButton_Clic_Click(object sender, EventArgs e)
        {
            DataRow row = dsUsers.Tables[0].NewRow(); // добавляем новую строку в DataTable
            dsUsers.Tables[0].Rows.Add(row);
        }

        // кнопка сохранения
        private void saveButton_Clic_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                adapterUsers = new MySqlDataAdapter(sqlUsers, connection);
                commandBuilder = new MySqlCommandBuilder(adapterUsers);
                adapterUsers.InsertCommand = new MySqlCommand("sp_CreateUser", connection);
                adapterUsers.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapterUsers.InsertCommand.Parameters.Add(new MySqlParameter("@login", MySqlDbType.VarChar, 50, "Логин"));
                adapterUsers.InsertCommand.Parameters.Add(new MySqlParameter("@pass", MySqlDbType.VarChar, 0, "Пороль"));
                adapterUsers.InsertCommand.Parameters.Add(new MySqlParameter("@acess_level", MySqlDbType.Int32, 0, "Уровень"));


                MySqlParameter parameter = adapterUsers.InsertCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "id");
                parameter.Direction = ParameterDirection.Output;

                adapterUsers.Update(dsUsers);
            }
        }
        // кнопка удаления
        private void deleteButton_Clic_Click(object sender, EventArgs e)
        {
            // удаляем выделенные строки из dataGridView1
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }


        private void add_Click(object sender, EventArgs e)
        {
            DataRow row = dsResourse.Tables[0].NewRow(); // добавляем новую строку в DataTable
            dsResourse.Tables[0].Rows.Add(row);
        }

        private void save_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                adapterResourse = new MySqlDataAdapter(sqlResourse, connection);
                commandBuilder = new MySqlCommandBuilder(adapterResourse);
                adapterResourse.InsertCommand = new MySqlCommand("sp_CreateResourse", connection);
                adapterResourse.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapterResourse.InsertCommand.Parameters.Add(new MySqlParameter("@name_resourse", MySqlDbType.VarChar, 50, "Наименование"));
                adapterResourse.InsertCommand.Parameters.Add(new MySqlParameter("@price", MySqlDbType.VarChar, 0, "Цена"));
                adapterResourse.InsertCommand.Parameters.Add(new MySqlParameter("@weight", MySqlDbType.Int32, 0, "Вес"));


                MySqlParameter parameter = adapterResourse.InsertCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "id");
                parameter.Direction = ParameterDirection.Output;

                adapterResourse.Update(dsResourse);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            // удаляем выделенные строки из dataGridView1
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Sort(dataGridView2.Columns[comboBox3.Text], ListSortDirection.Ascending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[comboBox2.Text], ListSortDirection.Ascending);
        }
    }
}
