using MySql.Data.MySqlClient;
using SqlDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            LOGIN_TEXTBOX.GotFocus += textBox1_GotFocus;
            LOGIN_TEXTBOX.MouseUp += textBox1_MouseUp;
            LOGIN_TEXTBOX.Leave += textBox1_Leave;

            passFieldCheck.GotFocus += textBox2_GotFocus;
            passFieldCheck.MouseUp += textBox2_MouseUp;
            passFieldCheck.Leave += textBox2_Leave;

            PASS_WORD_TEXTBOX.GotFocus += textBox3_GotFocus;
            PASS_WORD_TEXTBOX.MouseUp += textBox3_MouseUp;
            PASS_WORD_TEXTBOX.Leave += textBox3_Leave;

            REGISTRATION_BUTTON.MouseEnter += (s, e) =>
            {
                if (LOGIN_TEXTBOX.Text.Length >= 3 && PASS_WORD_TEXTBOX.Text.Length > 6 && PASS_WORD_TEXTBOX.Text == passFieldCheck.Text)
                {
                    REGISTRATION_BUTTON.BackColor = Color.ForestGreen;
                }
                else
                {
                    REGISTRATION_BUTTON.BackColor = Color.LightCoral;
                };
            };
            REGISTRATION_BUTTON.MouseLeave += (s, e) =>
            {
                REGISTRATION_BUTTON.BackColor = Color.FromKnownColor(KnownColor.Red);
            };
        }
        #region UX
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
                this.LOGIN_TEXTBOX.SelectAll();
                alreadyFocused = true;
            }
        }
        void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!alreadyFocused && this.LOGIN_TEXTBOX.SelectionLength == 0)
            {
                alreadyFocused = true;
                this.LOGIN_TEXTBOX.SelectAll();
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
                this.passFieldCheck.SelectAll();
                alreadyFocused = true;
            }
        }
        void textBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (!alreadyFocused && this.passFieldCheck.SelectionLength == 0)
            {
                alreadyFocused = true;
                this.passFieldCheck.SelectAll();
                passFieldCheck.UseSystemPasswordChar = true;
            }
        }

        void textBox3_Leave(object sender, EventArgs e)
        {
            alreadyFocused = false;
        }
        void textBox3_GotFocus(object sender, EventArgs e)
        {
            if (MouseButtons == MouseButtons.None)
            {
                this.PASS_WORD_TEXTBOX.SelectAll();
                alreadyFocused = true;
            }
        }
        void textBox3_MouseUp(object sender, MouseEventArgs e)
        {
            if (!alreadyFocused && this.PASS_WORD_TEXTBOX.SelectionLength == 0)
            {
                alreadyFocused = true;
                this.PASS_WORD_TEXTBOX.SelectAll();
                PASS_WORD_TEXTBOX.UseSystemPasswordChar = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LOGIN_TEXTBOX.ForeColor = Color.Black;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            passFieldCheck.ForeColor = Color.Black;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            PASS_WORD_TEXTBOX.ForeColor = Color.Black;
        }

        private void LOGIN_TEXTBOX_Enter(object sender, EventArgs e)
        {
            if (LOGIN_TEXTBOX.Text == "Логин")
            {
                LOGIN_TEXTBOX.Text = "";
            }
        }
        private void LOGIN_TEXTBOX_Leave(object sender, EventArgs e)
        {
            if (LOGIN_TEXTBOX.Text == "")
            {
                LOGIN_TEXTBOX.Text = "Логин";
            }
            else if
                (LOGIN_TEXTBOX.Text.Length >= 3)
            {
                helpLogin.ForeColor = SystemColors.ButtonHighlight;
            }
            else
            {
                helpLogin.ForeColor = Color.Red;
            }


        }
        private void passFieldCheck_Enter(object sender, EventArgs e)
        {
            if (passFieldCheck.Text == "Пороль")
                passFieldCheck.Text = "";
        }
        private void passFieldCheck_Leave(object sender, EventArgs e)
        {
            if (passFieldCheck.Text == "")
                passFieldCheck.Text = "Пороль";
            else if
                (PASS_WORD_TEXTBOX.Text.Length > 6 && PASS_WORD_TEXTBOX.Text == passFieldCheck.Text)
            {
                helpPass.ForeColor = SystemColors.ButtonHighlight;
            }
            else
            {
                helpPass.ForeColor = Color.Red;
            }
        }
        private void PASS_WORD_TEXTBOX_Enter(object sender, EventArgs e)
        {
            if (PASS_WORD_TEXTBOX.Text == "Пороль")
                PASS_WORD_TEXTBOX.Text = "";
        }
        private void PASS_WORD_TEXTBOX_Leave(object sender, EventArgs e)
        {
            if (PASS_WORD_TEXTBOX.Text == "")
                PASS_WORD_TEXTBOX.Text = "Пороль";
            else if
                (PASS_WORD_TEXTBOX.Text.Length > 6 && PASS_WORD_TEXTBOX.Text == passFieldCheck.Text)
            {
                helpPass.ForeColor = SystemColors.ButtonHighlight;
            }
            else
            {
                helpPass.ForeColor = Color.Red;
            }
        }



        #endregion
        #region(DB)
        private void REGISTRATION_BUTTON_Click(object sender, EventArgs e)
        {
            if (LOGIN_TEXTBOX.Text == "Логин")
            {
                MessageBox.Show("Введите логин!");
                return;
            }
            if (LOGIN_TEXTBOX.Text.Length <= 3)
            {
                MessageBox.Show("Длина логина менее 3 символов");
                return;
            }
            if (PASS_WORD_TEXTBOX.Text == "Пороль")
            {
                MessageBox.Show("Введите пороль!");
                return;
            }
            if (PASS_WORD_TEXTBOX.Text.Length <= 6)
            {
                MessageBox.Show("Длина логина менее 3 символов");
                return;
            }
            if (isUserExists())
            {
                return;
            }
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`,`pass`) VALUES (@login, @pass)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LOGIN_TEXTBOX.Text.ToLower();
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PASS_WORD_TEXTBOX.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Вы успешно зарегистрировались!");
                if (saveChecksBox.Checked)
                {
                    File.WriteAllText("C:\\Users\\wekol\\source\\repos\\new\\savedCokes\\login.txt", $"{LOGIN_TEXTBOX.Text}");
                    File.WriteAllText("C:\\Users\\wekol\\source\\repos\\new\\savedCokes\\pass.txt", $"{PASS_WORD_TEXTBOX.Text}");
                }
                this.Hide();
                AutorizationForm autorizationForm = new AutorizationForm();
                autorizationForm.Show();

            }
            else
            {
                MessageBox.Show("Ошибка регистрации!");
            }

            db.closeConnection();
        }

        public Boolean isUserExists()
        {
            string loginUser = LOGIN_TEXTBOX.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @lU", db.getConnection());
            command.Parameters.Add("@lU", MySqlDbType.VarChar).Value = loginUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Данный пользователь уже зарегистрирован");
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutorizationForm autorizationForm = new AutorizationForm();
            autorizationForm.Show();
        }
    }
}
