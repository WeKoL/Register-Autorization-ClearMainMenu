namespace KR_Michalev
{
    partial class AdminPanel
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
            Exit_Button = new Button();
            Back_Button = new Button();
            startSearch = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtSearch = new TextBox();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            button2 = new Button();
            deleteButton = new Button();
            changeButton = new Button();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            login = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // Exit_Button
            // 
            Exit_Button.Location = new Point(1206, -1);
            Exit_Button.Name = "Exit_Button";
            Exit_Button.Size = new Size(75, 23);
            Exit_Button.TabIndex = 15;
            Exit_Button.Text = "Exit";
            Exit_Button.UseVisualStyleBackColor = true;
            Exit_Button.Click += Exit_Button_Click1;
            // 
            // Back_Button
            // 
            Back_Button.Location = new Point(1133, -1);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new Size(75, 23);
            Back_Button.TabIndex = 14;
            Back_Button.Text = "Back";
            Back_Button.UseVisualStyleBackColor = true;
            Back_Button.Click += Back_Button_Click1;
            // 
            // startSearch
            // 
            startSearch.FlatStyle = FlatStyle.Flat;
            startSearch.Font = new Font("Lucida Fax", 12F);
            startSearch.Location = new Point(746, 17);
            startSearch.Name = "startSearch";
            startSearch.Size = new Size(89, 38);
            startSearch.TabIndex = 16;
            startSearch.Text = "Search";
            startSearch.UseVisualStyleBackColor = true;
            startSearch.Click += startSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.Location = new Point(85, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(648, 82);
            dataGridView1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 12F);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(67, 18);
            label1.TabIndex = 18;
            label1.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Lucida Fax", 12F);
            txtSearch.Location = new Point(85, 24);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(648, 26);
            txtSearch.TabIndex = 19;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(929, 65);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(339, 116);
            dataGridView2.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 12F);
            label2.Location = new Point(929, 31);
            label2.Name = "label2";
            label2.Size = new Size(82, 18);
            label2.TabIndex = 23;
            label2.Text = "All users:";
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Lucida Fax", 12F);
            button2.Location = new Point(1017, 21);
            button2.Name = "button2";
            button2.Size = new Size(110, 38);
            button2.TabIndex = 25;
            button2.Text = "Отобразить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // deleteButton
            // 
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.Font = new Font("Lucida Fax", 12F);
            deleteButton.Location = new Point(746, 65);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(89, 55);
            deleteButton.TabIndex = 21;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // changeButton
            // 
            changeButton.Cursor = Cursors.Hand;
            changeButton.Font = new Font("Lucida Fax", 12F);
            changeButton.Location = new Point(480, 165);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(89, 55);
            changeButton.TabIndex = 20;
            changeButton.Text = "Сhange";
            changeButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Lucida Fax", 12F);
            textBox1.Location = new Point(275, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 26);
            textBox1.TabIndex = 26;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Lucida Fax", 12F);
            textBox3.Location = new Point(275, 229);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(51, 26);
            textBox3.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Lucida Fax", 12F);
            textBox2.Location = new Point(275, 197);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 26);
            textBox2.TabIndex = 30;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Lucida Fax", 12F);
            textBox4.Location = new Point(275, 261);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(51, 26);
            textBox4.TabIndex = 31;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Lucida Fax", 12F);
            textBox5.Location = new Point(275, 293);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(51, 26);
            textBox5.TabIndex = 32;
            // 
            // login
            // 
            login.AutoSize = true;
            login.Font = new Font("Lucida Fax", 12F);
            login.Location = new Point(98, 170);
            login.Name = "login";
            login.Size = new Size(49, 18);
            login.TabIndex = 33;
            login.Text = "login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 12F);
            label3.Location = new Point(98, 197);
            label3.Name = "label3";
            label3.Size = new Size(44, 18);
            label3.TabIndex = 34;
            label3.Text = "pass";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 12F);
            label4.Location = new Point(98, 229);
            label4.Name = "label4";
            label4.Size = new Size(92, 18);
            label4.TabIndex = 35;
            label4.Text = "isNewUser";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Fax", 12F);
            label5.Location = new Point(98, 264);
            label5.Name = "label5";
            label5.Size = new Size(168, 18);
            label5.TabIndex = 36;
            label5.Text = "isWarehouseWorker";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Fax", 12F);
            label6.Location = new Point(98, 296);
            label6.Name = "label6";
            label6.Size = new Size(75, 18);
            label6.TabIndex = 37;
            label6.Text = "isAdmin";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Location = new Point(85, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(530, 225);
            panel1.TabIndex = 38;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1280, 1001);
            Controls.Add(login);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(deleteButton);
            Controls.Add(changeButton);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(startSearch);
            Controls.Add(Exit_Button);
            Controls.Add(Back_Button);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPanel";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Exit_Button;
        private Button Back_Button;
        private Button startSearch;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtSearch;
        private DataGridView dataGridView2;
        private Label label2;
        private Button button2;
        private Button deleteButton;
        private Button changeButton;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label login;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
    }
}