using MySql.Data.MySqlClient;
using Register;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR_Michalev
{
    public partial class WarehouseWorker : Form
    {
        DataSet dsResourse;
        MySqlDataAdapter adapterResourse;
        MySqlCommandBuilder commandBuilder;
        string connectionString = @"server=localhost;user=root;database=workc;port=3306;password=root";
        string sqlResourse = "SELECT * FROM Resourse";
        public WarehouseWorker()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;



            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                adapterResourse = new MySqlDataAdapter(sqlResourse, connection);

                dsResourse = new DataSet();
                adapterResourse.Fill(dsResourse);
                dataGridView1.DataSource = dsResourse.Tables[0];
                // делаем недоступным столбец id для изменения
                dataGridView1.Columns["id"].ReadOnly = true;


            }

            // Закрыть окно/прикрыть окно
        }
        public void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutorizationForm autorizationForm = new AutorizationForm();
            autorizationForm.Show();
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
            dataGridView1.Sort(dataGridView1.Columns[comboBox1.Text], ListSortDirection.Ascending);
        }


        // сортировка bubble
        static int[] BubbleSort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }

    }
}
