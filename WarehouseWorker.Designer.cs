namespace KR_Michalev
{
    partial class WarehouseWorker
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseWorker));
            Back_Button = new Button();
            Exit_Button = new Button();
            dataGridView1 = new DataGridView();
            delete = new Button();
            save = new Button();
            add = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Back_Button
            // 
            Back_Button.Location = new Point(1133, -1);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new Size(75, 23);
            Back_Button.TabIndex = 12;
            Back_Button.Text = "Back";
            Back_Button.UseVisualStyleBackColor = true;
            Back_Button.Click += Back_Button_Click;
            // 
            // Exit_Button
            // 
            Exit_Button.Location = new Point(1206, -1);
            Exit_Button.Name = "Exit_Button";
            Exit_Button.Size = new Size(75, 23);
            Exit_Button.TabIndex = 13;
            Exit_Button.Text = "Exit";
            Exit_Button.UseVisualStyleBackColor = true;
            Exit_Button.Click += Exit_Button_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(643, 409);
            dataGridView1.TabIndex = 29;
            // 
            // delete
            // 
            delete.Location = new Point(459, 427);
            delete.Name = "delete";
            delete.Size = new Size(196, 64);
            delete.TabIndex = 28;
            delete.Text = "Удалить";
            delete.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            save.Location = new Point(244, 427);
            save.Name = "save";
            save.Size = new Size(209, 64);
            save.TabIndex = 27;
            save.Text = "Сохранить";
            save.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            add.Location = new Point(12, 427);
            add.Name = "add";
            add.Size = new Size(226, 64);
            add.TabIndex = 26;
            add.Text = "Добавить";
            add.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 508);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 30;
            label1.Text = "Сортировать по";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "id", "name_resourse", "price", "weight" });
            comboBox1.Location = new Point(113, 505);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 31;
            // 
            // button1
            // 
            button1.Location = new Point(240, 505);
            button1.Name = "button1";
            button1.Size = new Size(92, 23);
            button1.TabIndex = 32;
            button1.Text = "Сортировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(682, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(433, 409);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // WarehouseWorker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1280, 1001);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(delete);
            Controls.Add(save);
            Controls.Add(add);
            Controls.Add(Exit_Button);
            Controls.Add(Back_Button);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WarehouseWorker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WarehouseWorker";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back_Button;
        private Button Exit_Button;
        private DataGridView dataGridView1;
        private Button delete;
        private Button save;
        private Button add;
        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
        private PictureBox pictureBox1;
    }
}