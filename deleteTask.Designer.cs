﻿namespace TaskMastrProgram
{
    partial class deleteTask
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
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F);
            label1.Location = new Point(133, 92);
            label1.Name = "label1";
            label1.Size = new Size(382, 19);
            label1.TabIndex = 0;
            label1.Text = "Confirm Deletion of Task - Task will be permanently forgotten";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(245, 173);
            button1.Name = "button1";
            button1.Size = new Size(142, 29);
            button1.TabIndex = 1;
            button1.Text = "Delete and Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // deleteTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 319);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "deleteTask";
            Text = "deleteTask";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}