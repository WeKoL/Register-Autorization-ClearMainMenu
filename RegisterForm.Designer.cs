namespace Register
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            panel1 = new Panel();
            helpPass = new Label();
            helpLogin = new Label();
            maxSymbolsLabel = new Label();
            PASS_WORD_TEXTBOX = new TextBox();
            registerLabel = new Label();
            saveChecksBox = new CheckBox();
            passFieldCheck = new TextBox();
            LOGIN_TEXTBOX = new TextBox();
            REGISTRATION_BUTTON = new Button();
            panel3 = new Panel();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            panel2 = new Panel();
            Exit_Button = new Button();
            Back_Button = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(helpPass);
            panel1.Controls.Add(helpLogin);
            panel1.Controls.Add(maxSymbolsLabel);
            panel1.Controls.Add(registerLabel);
            panel1.Controls.Add(LOGIN_TEXTBOX);
            panel1.Controls.Add(passFieldCheck);
            panel1.Controls.Add(PASS_WORD_TEXTBOX);
            panel1.Controls.Add(saveChecksBox);
            panel1.Controls.Add(REGISTRATION_BUTTON);
            panel1.Location = new Point(520, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 380);
            panel1.TabIndex = 4;
            // 
            // helpPass
            // 
            helpPass.AutoSize = true;
            helpPass.ForeColor = SystemColors.ButtonHighlight;
            helpPass.Location = new Point(13, 232);
            helpPass.Name = "helpPass";
            helpPass.Size = new Size(165, 15);
            helpPass.TabIndex = 11;
            helpPass.Text = "Вы неверно указали пороль!";
            // 
            // helpLogin
            // 
            helpLogin.AutoSize = true;
            helpLogin.ForeColor = SystemColors.ButtonHighlight;
            helpLogin.Location = new Point(14, 77);
            helpLogin.Name = "helpLogin";
            helpLogin.Size = new Size(157, 15);
            helpLogin.TabIndex = 10;
            helpLogin.Text = "Вы неверно указали логин!";
            // 
            // maxSymbolsLabel
            // 
            maxSymbolsLabel.AutoSize = true;
            maxSymbolsLabel.Location = new Point(13, 110);
            maxSymbolsLabel.Name = "maxSymbolsLabel";
            maxSymbolsLabel.Size = new Size(118, 15);
            maxSymbolsLabel.TabIndex = 9;
            maxSymbolsLabel.Text = "Больше 6 символов";
            // 
            // PASS_WORD_TEXTBOX
            // 
            PASS_WORD_TEXTBOX.BackColor = SystemColors.Control;
            PASS_WORD_TEXTBOX.BorderStyle = BorderStyle.FixedSingle;
            PASS_WORD_TEXTBOX.ForeColor = SystemColors.ActiveBorder;
            PASS_WORD_TEXTBOX.Location = new Point(13, 181);
            PASS_WORD_TEXTBOX.MaxLength = 24;
            PASS_WORD_TEXTBOX.Name = "PASS_WORD_TEXTBOX";
            PASS_WORD_TEXTBOX.Size = new Size(171, 23);
            PASS_WORD_TEXTBOX.TabIndex = 8;
            PASS_WORD_TEXTBOX.Text = "Пороль";
            PASS_WORD_TEXTBOX.TextChanged += textBox3_TextChanged;
            PASS_WORD_TEXTBOX.Enter += PASS_WORD_TEXTBOX_Enter;
            PASS_WORD_TEXTBOX.Leave += PASS_WORD_TEXTBOX_Leave;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Location = new Point(64, 22);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(76, 15);
            registerLabel.TabIndex = 7;
            registerLabel.Text = "Регистрация";
            // 
            // saveChecksBox
            // 
            saveChecksBox.AutoSize = true;
            saveChecksBox.BackColor = SystemColors.ControlLight;
            saveChecksBox.Checked = true;
            saveChecksBox.CheckState = CheckState.Checked;
            saveChecksBox.Location = new Point(14, 210);
            saveChecksBox.Name = "saveChecksBox";
            saveChecksBox.Size = new Size(113, 19);
            saveChecksBox.TabIndex = 6;
            saveChecksBox.Text = "Сохранить вход";
            saveChecksBox.UseVisualStyleBackColor = false;
            // 
            // passFieldCheck
            // 
            passFieldCheck.BackColor = SystemColors.Control;
            passFieldCheck.BorderStyle = BorderStyle.FixedSingle;
            passFieldCheck.ForeColor = SystemColors.ActiveBorder;
            passFieldCheck.Location = new Point(13, 137);
            passFieldCheck.MaxLength = 24;
            passFieldCheck.Name = "passFieldCheck";
            passFieldCheck.Size = new Size(171, 23);
            passFieldCheck.TabIndex = 4;
            passFieldCheck.Text = "Пороль";
            passFieldCheck.TextChanged += textBox2_TextChanged;
            passFieldCheck.Enter += passFieldCheck_Enter;
            passFieldCheck.Leave += passFieldCheck_Leave;
            // 
            // LOGIN_TEXTBOX
            // 
            LOGIN_TEXTBOX.BackColor = SystemColors.Control;
            LOGIN_TEXTBOX.BorderStyle = BorderStyle.FixedSingle;
            LOGIN_TEXTBOX.ForeColor = SystemColors.ActiveBorder;
            LOGIN_TEXTBOX.Location = new Point(13, 51);
            LOGIN_TEXTBOX.MaxLength = 24;
            LOGIN_TEXTBOX.Name = "LOGIN_TEXTBOX";
            LOGIN_TEXTBOX.Size = new Size(171, 23);
            LOGIN_TEXTBOX.TabIndex = 3;
            LOGIN_TEXTBOX.Text = "Логин";
            LOGIN_TEXTBOX.TextChanged += textBox1_TextChanged;
            LOGIN_TEXTBOX.Enter += LOGIN_TEXTBOX_Enter;
            LOGIN_TEXTBOX.Leave += LOGIN_TEXTBOX_Leave;
            // 
            // REGISTRATION_BUTTON
            // 
            REGISTRATION_BUTTON.BackColor = Color.Red;
            REGISTRATION_BUTTON.Cursor = Cursors.Hand;
            REGISTRATION_BUTTON.Location = new Point(29, 277);
            REGISTRATION_BUTTON.Name = "REGISTRATION_BUTTON";
            REGISTRATION_BUTTON.Size = new Size(172, 62);
            REGISTRATION_BUTTON.TabIndex = 2;
            REGISTRATION_BUTTON.Text = "Зарегистрироваться";
            REGISTRATION_BUTTON.UseVisualStyleBackColor = false;
            REGISTRATION_BUTTON.Click += REGISTRATION_BUTTON_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(richTextBox1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(25, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(480, 900);
            panel3.TabIndex = 8;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(17, 40);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(451, 843);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 17F);
            label1.Location = new Point(115, 8);
            label1.Name = "label1";
            label1.Size = new Size(237, 29);
            label1.TabIndex = 0;
            label1.Text = "Список обновлений";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(773, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(480, 900);
            panel2.TabIndex = 9;
            // 
            // Exit_Button
            // 
            Exit_Button.Location = new Point(1206, -1);
            Exit_Button.Name = "Exit_Button";
            Exit_Button.Size = new Size(75, 23);
            Exit_Button.TabIndex = 10;
            Exit_Button.Text = "Exit";
            Exit_Button.UseVisualStyleBackColor = true;
            Exit_Button.Click += Exit_Button_Click;
            // 
            // Back_Button
            // 
            Back_Button.Location = new Point(1133, -1);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new Size(75, 23);
            Back_Button.TabIndex = 11;
            Back_Button.Text = "Back";
            Back_Button.UseVisualStyleBackColor = true;
            Back_Button.Click += Back_Button_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1280, 1001);
            Controls.Add(Back_Button);
            Controls.Add(Exit_Button);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            ImeMode = ImeMode.On;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.Manual;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label registerLabel;
        private CheckBox saveChecksBox;
        private TextBox passFieldCheck;
        private TextBox LOGIN_TEXTBOX;
        private Button REGISTRATION_BUTTON;
        private Panel panel3;
        private Panel panel2;
        private TextBox PASS_WORD_TEXTBOX;
        private Label maxSymbolsLabel;
        private Label helpLogin;
        private Label helpPass;
        private Button Exit_Button;
        private Button Back_Button;
        private Label label1;
        private RichTextBox richTextBox1;
    }
}