namespace Register
{
    partial class AutorizationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 

        private void InitializeComponent()
        {
            panel2 = new Panel();
            label1 = new Label();
            checkBox3 = new CheckBox();
            linkRegis = new LinkLabel();
            passField = new TextBox();
            loginField = new TextBox();
            ButtonAuthorization = new Button();
            listView1 = new ListView();
            listView2 = new ListView();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(checkBox3);
            panel2.Controls.Add(linkRegis);
            panel2.Controls.Add(passField);
            panel2.Controls.Add(loginField);
            panel2.Controls.Add(ButtonAuthorization);
            panel2.Location = new Point(1052, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 220);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 20);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 7;
            label1.Text = "Авторизация";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = SystemColors.ControlLight;
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Checked;
            checkBox3.Location = new Point(15, 132);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(113, 19);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Сохранить вход";
            checkBox3.UseVisualStyleBackColor = false;
            // 
            // linkRegis
            // 
            linkRegis.AutoSize = true;
            linkRegis.Cursor = Cursors.Hand;
            linkRegis.LinkBehavior = LinkBehavior.NeverUnderline;
            linkRegis.Location = new Point(63, 189);
            linkRegis.Name = "linkRegis";
            linkRegis.Size = new Size(76, 15);
            linkRegis.TabIndex = 5;
            linkRegis.TabStop = true;
            linkRegis.Text = "Регистрация";
            linkRegis.UseMnemonic = false;
            linkRegis.LinkClicked += linkRegis_LinkClicked;
            // 
            // passField
            // 
            passField.BackColor = SystemColors.Control;
            passField.BorderStyle = BorderStyle.FixedSingle;
            passField.ForeColor = SystemColors.ActiveBorder;
            passField.Location = new Point(15, 99);
            passField.MaxLength = 24;
            passField.Name = "passField";
            passField.Size = new Size(171, 23);
            passField.TabIndex = 4;
            passField.Text = "Пороль";
            passField.TextChanged += textBox2_TextChanged;
            // 
            // loginField
            // 
            loginField.BackColor = SystemColors.Control;
            loginField.BorderStyle = BorderStyle.FixedSingle;
            loginField.ForeColor = SystemColors.ActiveBorder;
            loginField.Location = new Point(14, 47);
            loginField.MaxLength = 24;
            loginField.Name = "loginField";
            loginField.Size = new Size(171, 23);
            loginField.TabIndex = 3;
            loginField.Text = "Логин";
            loginField.TextChanged += textBox1_TextChanged;
            // 
            // ButtonAuthorization
            // 
            ButtonAuthorization.BackColor = Color.Red;
            ButtonAuthorization.Cursor = Cursors.Hand;
            ButtonAuthorization.Location = new Point(64, 157);
            ButtonAuthorization.Name = "ButtonAuthorization";
            ButtonAuthorization.Size = new Size(75, 29);
            ButtonAuthorization.TabIndex = 2;
            ButtonAuthorization.Text = "Вход";
            ButtonAuthorization.UseVisualStyleBackColor = false;
            ButtonAuthorization.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.BorderStyle = BorderStyle.None;
            listView1.Location = new Point(12, 238);
            listView1.Name = "listView1";
            listView1.Size = new Size(1240, 700);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.BorderStyle = BorderStyle.None;
            listView2.Location = new Point(12, 12);
            listView2.Name = "listView2";
            listView2.Size = new Size(1024, 220);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // AutorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1280, 1024);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(panel2);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            ImeMode = ImeMode.On;
            Name = "AutorizationForm";
            Text = "AutoRider";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CheckBox checkBox1;
        private ContextMenuStrip contextMenuStrip1;
        private CheckBox checkBox2;
        private ToolStripMenuItem toolStripMenuItem2;
        private Panel panel2;
        private ListView listView1;
        private ListView listView2;
        private Button ButtonAuthorization;
        private TextBox passField;
        private TextBox loginField;
        private LinkLabel linkRegis;
        private CheckBox checkBox3;
        private Label label1;
    }
}
