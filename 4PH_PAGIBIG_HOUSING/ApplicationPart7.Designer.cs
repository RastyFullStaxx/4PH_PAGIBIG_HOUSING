namespace _4PH_PAGIBIG_HOUSING
{
    partial class ApplicationPart7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationPart7));
            lblMRID = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAddMoreAcc = new Button();
            btnNext = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblMRID
            // 
            lblMRID.AutoSize = true;
            lblMRID.BackColor = Color.Transparent;
            lblMRID.FlatStyle = FlatStyle.Flat;
            lblMRID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMRID.Location = new Point(65, 297);
            lblMRID.Name = "lblMRID";
            lblMRID.Size = new Size(87, 15);
            lblMRID.TabIndex = 22;
            lblMRID.Text = "TYPE OF LOAN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 382);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 23;
            label1.Text = "AMOUNT/BALANCE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(388, 297);
            label2.Name = "label2";
            label2.Size = new Size(196, 15);
            label2.TabIndex = 24;
            label2.Text = "TYPE OF SECURITY FOR THE LOAN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(603, 385);
            label3.Name = "label3";
            label3.Size = new Size(167, 15);
            label3.TabIndex = 25;
            label3.Text = "MORTGAGE AMORTIZATION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(813, 297);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 26;
            label4.Text = "MATURITY DATE";
            // 
            // btnAddMoreAcc
            // 
            btnAddMoreAcc.BackColor = Color.Transparent;
            btnAddMoreAcc.Cursor = Cursors.Hand;
            btnAddMoreAcc.FlatAppearance.BorderSize = 0;
            btnAddMoreAcc.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAddMoreAcc.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAddMoreAcc.FlatStyle = FlatStyle.Flat;
            btnAddMoreAcc.Image = (Image)resources.GetObject("btnAddMoreAcc.Image");
            btnAddMoreAcc.Location = new Point(397, 588);
            btnAddMoreAcc.Name = "btnAddMoreAcc";
            btnAddMoreAcc.Size = new Size(413, 45);
            btnAddMoreAcc.TabIndex = 38;
            btnAddMoreAcc.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Transparent;
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnNext.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.Location = new Point(1112, 713);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(126, 45);
            btnNext.TabIndex = 37;
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBack.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(56, 713);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(126, 45);
            btnBack.TabIndex = 36;
            btnBack.UseVisualStyleBackColor = true;
            // 
            // ApplicationPart7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1280, 800);
            Controls.Add(btnAddMoreAcc);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblMRID);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ApplicationPart7";
            Text = "ApplicationPart7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMRID;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAddMoreAcc;
        private Button btnNext;
        private Button btnBack;
    }
}