using System;
using System.Drawing;
using System.Windows.Forms;

namespace _4PH_PAGIBIG_HOUSING
{
    partial class A_Launch
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_Launch));
            btnApply = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnApply
            // 
            btnApply.BackColor = Color.Transparent;
            btnApply.Cursor = Cursors.Hand;
            btnApply.FlatAppearance.BorderSize = 0;
            btnApply.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnApply.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnApply.FlatStyle = FlatStyle.Flat;
            btnApply.Image = (Image)resources.GetObject("btnApply.Image");
            btnApply.Location = new Point(366, 506);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(303, 128);
            btnApply.TabIndex = 0;
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(675, 506);
            button1.Name = "button1";
            button1.Size = new Size(303, 128);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // A_Launch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1280, 800);
            Controls.Add(button1);
            Controls.Add(btnApply);
            FormBorderStyle = FormBorderStyle.None;
            Name = "A_Launch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += A_Launch_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnApply;
        private Button button1;
    }
}
