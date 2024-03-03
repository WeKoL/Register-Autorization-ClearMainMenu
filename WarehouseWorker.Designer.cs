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
            Back_Button = new Button();
            Exit_Button = new Button();
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
            // WarehouseWorker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1280, 1001);
            Controls.Add(Exit_Button);
            Controls.Add(Back_Button);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WarehouseWorker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WarehouseWorker";
            ResumeLayout(false);
        }

        #endregion

        private Button Back_Button;
        private Button Exit_Button;
    }
}