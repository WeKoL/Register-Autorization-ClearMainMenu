namespace Register
{
    partial class NewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAccount));
            Exit_Button = new Button();
            Back_Button = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Exit_Button
            // 
            Exit_Button.Location = new Point(1206, -1);
            Exit_Button.Name = "Exit_Button";
            Exit_Button.Size = new Size(75, 23);
            Exit_Button.TabIndex = 3;
            Exit_Button.Text = "Exit";
            Exit_Button.UseVisualStyleBackColor = true;
            Exit_Button.Click += Exit_Button_Click_1;
            // 
            // Back_Button
            // 
            Back_Button.Location = new Point(1133, -1);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new Size(75, 23);
            Back_Button.TabIndex = 12;
            Back_Button.Text = "Back";
            Back_Button.UseVisualStyleBackColor = true;
            Back_Button.Click += Back_Button_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(462, 28);
            label1.TabIndex = 13;
            label1.Text = "Ожидайте потверждения аккаунта модератором";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(968, 689);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(497, 50);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(451, 843);
            richTextBox1.TabIndex = 16;
            richTextBox1.ForeColor = System.Drawing.Color.LightGreen;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 17F);
            label2.Location = new Point(607, 9);
            label2.Name = "label2";
            label2.Size = new Size(237, 29);
            label2.TabIndex = 17;
            label2.Text = "Список обновлений";
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1280, 1001);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(Back_Button);
            Controls.Add(Exit_Button);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenuForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Exit_Button;
        private Button Back_Button;
        private Label label1;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
        private Label label2;
    }
}