﻿namespace _4PH_PAGIBIG_HOUSING
{
    partial class ApplicationBriefing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationBriefing));
            btnApply = new Button();
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
            btnApply.Location = new Point(875, 643);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(217, 61);
            btnApply.TabIndex = 1;
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // ApplicationBriefing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1280, 800);
            Controls.Add(btnApply);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ApplicationBriefing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ApplicationBriefing";
            Load += ApplicationBriefing_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnApply;
    }
}