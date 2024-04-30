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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Exit_Button = new Button();
            Back_Button = new Button();
            addButton_Clic = new Button();
            saveButton_Clic = new Button();
            deleteButton_Clic = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            delete = new Button();
            save = new Button();
            add = new Button();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            comboBox2 = new ComboBox();
            label2 = new Label();
            comboBox3 = new ComboBox();
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
            // addButton_Clic
            // 
            addButton_Clic.Location = new Point(12, 427);
            addButton_Clic.Name = "addButton_Clic";
            addButton_Clic.Size = new Size(115, 64);
            addButton_Clic.TabIndex = 16;
            addButton_Clic.Text = "Добавить";
            addButton_Clic.UseVisualStyleBackColor = true;
            addButton_Clic.Click += addButton_Clic_Click;
            // 
            // saveButton_Clic
            // 
            saveButton_Clic.Location = new Point(133, 427);
            saveButton_Clic.Name = "saveButton_Clic";
            saveButton_Clic.Size = new Size(125, 64);
            saveButton_Clic.TabIndex = 17;
            saveButton_Clic.Text = "Сохранить";
            saveButton_Clic.UseVisualStyleBackColor = true;
            saveButton_Clic.Click += saveButton_Clic_Click;
            // 
            // deleteButton_Clic
            // 
            deleteButton_Clic.Location = new Point(264, 427);
            deleteButton_Clic.Name = "deleteButton_Clic";
            deleteButton_Clic.Size = new Size(127, 64);
            deleteButton_Clic.TabIndex = 18;
            deleteButton_Clic.Text = "Удалить";
            deleteButton_Clic.UseVisualStyleBackColor = true;
            deleteButton_Clic.Click += deleteButton_Clic_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.Gainsboro;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(379, 409);
            dataGridView1.TabIndex = 19;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(469, 12);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(643, 409);
            dataGridView2.TabIndex = 23;
            // 
            // delete
            // 
            delete.Location = new Point(916, 427);
            delete.Name = "delete";
            delete.Size = new Size(196, 64);
            delete.TabIndex = 22;
            delete.Text = "Удалить";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // save
            // 
            save.Location = new Point(701, 427);
            save.Name = "save";
            save.Size = new Size(209, 64);
            save.TabIndex = 21;
            save.Text = "Сохранить";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // add
            // 
            add.Location = new Point(469, 427);
            add.Name = "add";
            add.Size = new Size(226, 64);
            add.TabIndex = 20;
            add.Text = "Добавить";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // button1
            // 
            button1.Location = new Point(700, 503);
            button1.Name = "button1";
            button1.Size = new Size(92, 23);
            button1.TabIndex = 35;
            button1.Text = "Сортировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(472, 506);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 33;
            label1.Text = "Сортировать по";
            // 
            // button2
            // 
            button2.Location = new Point(240, 502);
            button2.Name = "button2";
            button2.Size = new Size(92, 23);
            button2.TabIndex = 38;
            button2.Text = "Сортировать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "id", "login", "pass", "acess_level" });
            comboBox2.Location = new Point(113, 502);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 505);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 36;
            label2.Text = "Сортировать по";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "id", "name_resourse", "price", "weight" });
            comboBox3.Location = new Point(573, 503);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 39;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1280, 1001);
            Controls.Add(comboBox3);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(delete);
            Controls.Add(save);
            Controls.Add(add);
            Controls.Add(dataGridView1);
            Controls.Add(deleteButton_Clic);
            Controls.Add(saveButton_Clic);
            Controls.Add(addButton_Clic);
            Controls.Add(Exit_Button);
            Controls.Add(Back_Button);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPanel";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Exit_Button;
        private Button Back_Button;
        private Button addButton_Clic;
        private Button saveButton_Clic;
        private DataGridView dataGridView1;
        private Button deleteButton_Clic;
        private DataGridView dataGridView2;
        private Button delete;
        private Button save;
        private Button add;
        private Button button1;
        private Label label1;
        private Button button2;
        private ComboBox comboBox2;
        private Label label2;
        private ComboBox comboBox3;
    }
}