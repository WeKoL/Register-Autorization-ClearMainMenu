using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using Register;
using SqlDB;
using System.Data;
using System.IO;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Register
{
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            String pass;
            string login;
            
            loginField.GotFocus += textBox1_GotFocus;
            loginField.MouseUp += textBox1_MouseUp;
            loginField.Leave += textBox1_Leave;
            passField.GotFocus += textBox2_GotFocus;
            passField.MouseUp += textBox2_MouseUp;
            passField.Leave += textBox2_Leave;
            ButtonAuthorization.MouseEnter += (s, e) =>
            {
                if (loginField.Text.Length >= 3 && passField.Text.Length > 6)
                {
                    ButtonAuthorization.BackColor = Color.ForestGreen;
                }
                else
                {
                    ButtonAuthorization.BackColor = Color.LightCoral;
                };
            };
            ButtonAuthorization.MouseLeave += (s, e) =>
            {
                ButtonAuthorization.BackColor = Color.FromKnownColor(KnownColor.Red);
            };
            try
            {
                string completedPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "completed");
                Directory.CreateDirectory(completedPath);
                string filePathforPass = Path.Combine(completedPath, "Pass.bat");
                string filePathforLogin = Path.Combine(completedPath, "Login.bat");
                //Pass the file path and file name to the StreamReader constructor
                StreamReader passReader = new StreamReader(filePathforPass);
                StreamReader loginReader = new StreamReader(filePathforLogin);
                //Read the first line of text
                pass = passReader.ReadLine();
                login = loginReader.ReadLine();
                //Continue to read until you reach end of file
                passField.Text = pass;
                loginField.Text = login;
                //close the file
                passReader.Close();
                loginReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
        }
        #region Выделение логин и пороль
        bool alreadyFocused;
        bool allChecked;

        void textBox1_Leave(object sender, EventArgs e)
        {
            alreadyFocused = false;
        }
        void textBox1_GotFocus(object sender, EventArgs e)
        {
            if (MouseButtons == MouseButtons.None)
            {
                this.loginField.SelectAll();
                alreadyFocused = true;
            }
        }
        void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!alreadyFocused && this.loginField.SelectionLength == 0)
            {
                alreadyFocused = true;
                this.loginField.SelectAll();
            }
        }

        void textBox2_Leave(object sender, EventArgs e)
        {
            alreadyFocused = false;
        }
        void textBox2_GotFocus(object sender, EventArgs e)
        {
            if (MouseButtons == MouseButtons.None)
            {
                this.passField.SelectAll();
                alreadyFocused = true;
            }
        }
        void textBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (!alreadyFocused && this.passField.SelectionLength == 0)
            {
                alreadyFocused = true;
                this.passField.SelectAll();
                passField.UseSystemPasswordChar = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loginField.ForeColor = Color.Black;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            passField.ForeColor = Color.Black;
        }

        void Button1_GotFocus(object sender, EventArgs e)
        {
            if (MouseButtons == MouseButtons.None)
            {
                this.loginField.SelectAll();
                alreadyFocused = true;
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passUser = passField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @lU AND `pass` = @pU", db.getConnection());
            command.Parameters.Add("@lU", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@pU", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0 && loginUser.Length >= 3 && passUser.Length > 6)
            {
                MessageBox.Show("Успех авторизации");
                if (checkBox3.Checked)
                {
                    string completedPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "completed");
                    Directory.CreateDirectory(completedPath);
                    string filePathforPass = Path.Combine(completedPath, "Pass.bat");
                    string filePathforLogin = Path.Combine(completedPath, "Login.bat");
                    using (StreamWriter writer = new StreamWriter(filePathforPass))
                    {
                        writer.Write(passField.Text);
                    }
                    using (StreamWriter writer = new StreamWriter(filePathforLogin))
                    {
                        writer.Write(loginField.Text);
                    }
                }
                else
                {
                    string completedPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "completed");
                    Directory.CreateDirectory(completedPath);
                    string filePathforPass = Path.Combine(completedPath, "Pass.bat");
                    string filePathforLogin = Path.Combine(completedPath, "Login.bat");
                    using (StreamWriter writer = new StreamWriter(filePathforPass))
                    {
                        writer.Write("");
                    }
                    using (StreamWriter writer = new StreamWriter(filePathforLogin))
                    {
                        writer.Write("");
                    }
                }
                this.Hide();
                MainMenuForm mainMenuForm = new MainMenuForm();
                mainMenuForm.Show();
            }
            else
            {
                MessageBox.Show("Вы неверно указали данные для авторизации!");
            }
        }

        private void linkRegis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm register = new RegisterForm();
            register.Show();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}



