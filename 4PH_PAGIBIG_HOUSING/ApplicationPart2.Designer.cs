﻿namespace _4PH_PAGIBIG_HOUSING
{
    partial class ApplicationPart2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationPart2));
            btnNext = new Button();
            lblLoanAmount = new Label();
            lblLoanTerm = new Label();
            lblModeOfPayment = new Label();
            btnBack = new Button();
            txtLoanAmount = new TextBox();
            cbLoanTerm = new ComboBox();
            cbModeOfPayment = new ComboBox();
            btnOtherLoanInfo = new Button();
            btnRealEstateInfo = new Button();
            btnBankInfo = new Button();
            btnLoanInfo = new Button();
            btnPersonalInfo = new Button();
            label1 = new Label();
            lblEmploymentInfo = new Label();
            lblRealEstateInfo = new Label();
            lblBankInfo = new Label();
            lblLoanInfo = new Label();
            lblCollateralInfo = new Label();
            lblOtherInfo = new Label();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            btnNext.TabIndex = 17;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblLoanAmount
            // 
            lblLoanAmount.AutoSize = true;
            lblLoanAmount.BackColor = Color.Transparent;
            lblLoanAmount.FlatStyle = FlatStyle.Flat;
            lblLoanAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoanAmount.Location = new Point(73, 255);
            lblLoanAmount.Name = "lblLoanAmount";
            lblLoanAmount.Size = new Size(95, 15);
            lblLoanAmount.TabIndex = 18;
            lblLoanAmount.Text = "LOAN AMOUNT";
            // 
            // lblLoanTerm
            // 
            lblLoanTerm.AutoSize = true;
            lblLoanTerm.BackColor = Color.Transparent;
            lblLoanTerm.FlatStyle = FlatStyle.Flat;
            lblLoanTerm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoanTerm.Location = new Point(73, 349);
            lblLoanTerm.Name = "lblLoanTerm";
            lblLoanTerm.Size = new Size(74, 15);
            lblLoanTerm.TabIndex = 19;
            lblLoanTerm.Text = "LOAN TERM";
            // 
            // lblModeOfPayment
            // 
            lblModeOfPayment.AutoSize = true;
            lblModeOfPayment.BackColor = Color.Transparent;
            lblModeOfPayment.FlatStyle = FlatStyle.Flat;
            lblModeOfPayment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModeOfPayment.Location = new Point(73, 442);
            lblModeOfPayment.Name = "lblModeOfPayment";
            lblModeOfPayment.Size = new Size(116, 15);
            lblModeOfPayment.TabIndex = 20;
            lblModeOfPayment.Text = "MODE OF PAYMENT";
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
            btnBack.TabIndex = 32;
            btnBack.UseVisualStyleBackColor = true;
            // 
            // txtLoanAmount
            // 
            txtLoanAmount.BackColor = Color.WhiteSmoke;
            txtLoanAmount.Location = new Point(73, 273);
            txtLoanAmount.Name = "txtLoanAmount";
            txtLoanAmount.Size = new Size(328, 23);
            txtLoanAmount.TabIndex = 33;
            // 
            // cbLoanTerm
            // 
            cbLoanTerm.FormattingEnabled = true;
            cbLoanTerm.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            cbLoanTerm.Location = new Point(73, 367);
            cbLoanTerm.Name = "cbLoanTerm";
            cbLoanTerm.Size = new Size(328, 23);
            cbLoanTerm.TabIndex = 45;
            cbLoanTerm.Text = " ";
            // 
            // cbModeOfPayment
            // 
            cbModeOfPayment.FormattingEnabled = true;
            cbModeOfPayment.Items.AddRange(new object[] { "Salary deduction", "Over-the-Counter (Post-Dated Checks)", "Over-the-Counter (Cash/Check)", "Collecting Agent (Bank)", "Collecting Agent (Developer)", "Collecting Agent (Remittance Center)" });
            cbModeOfPayment.Location = new Point(73, 460);
            cbModeOfPayment.Name = "cbModeOfPayment";
            cbModeOfPayment.Size = new Size(328, 23);
            cbModeOfPayment.TabIndex = 46;
            cbModeOfPayment.Text = " ";
            // 
            // btnOtherLoanInfo
            // 
            btnOtherLoanInfo.BackColor = Color.Transparent;
            btnOtherLoanInfo.Cursor = Cursors.Hand;
            btnOtherLoanInfo.FlatAppearance.BorderSize = 0;
            btnOtherLoanInfo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnOtherLoanInfo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnOtherLoanInfo.FlatStyle = FlatStyle.Flat;
            btnOtherLoanInfo.Image = (Image)resources.GetObject("btnOtherLoanInfo.Image");
            btnOtherLoanInfo.Location = new Point(1077, 118);
            btnOtherLoanInfo.Name = "btnOtherLoanInfo";
            btnOtherLoanInfo.Size = new Size(53, 51);
            btnOtherLoanInfo.TabIndex = 61;
            btnOtherLoanInfo.UseVisualStyleBackColor = true;
            // 
            // btnRealEstateInfo
            // 
            btnRealEstateInfo.BackColor = Color.Transparent;
            btnRealEstateInfo.Cursor = Cursors.Hand;
            btnRealEstateInfo.FlatAppearance.BorderSize = 0;
            btnRealEstateInfo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRealEstateInfo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRealEstateInfo.FlatStyle = FlatStyle.Flat;
            btnRealEstateInfo.Image = (Image)resources.GetObject("btnRealEstateInfo.Image");
            btnRealEstateInfo.Location = new Point(908, 118);
            btnRealEstateInfo.Name = "btnRealEstateInfo";
            btnRealEstateInfo.Size = new Size(53, 51);
            btnRealEstateInfo.TabIndex = 60;
            btnRealEstateInfo.UseVisualStyleBackColor = true;
            // 
            // btnBankInfo
            // 
            btnBankInfo.BackColor = Color.Transparent;
            btnBankInfo.Cursor = Cursors.Hand;
            btnBankInfo.FlatAppearance.BorderSize = 0;
            btnBankInfo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBankInfo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBankInfo.FlatStyle = FlatStyle.Flat;
            btnBankInfo.Image = (Image)resources.GetObject("btnBankInfo.Image");
            btnBankInfo.Location = new Point(738, 118);
            btnBankInfo.Name = "btnBankInfo";
            btnBankInfo.Size = new Size(53, 51);
            btnBankInfo.TabIndex = 59;
            btnBankInfo.UseVisualStyleBackColor = true;
            // 
            // btnLoanInfo
            // 
            btnLoanInfo.BackColor = Color.Transparent;
            btnLoanInfo.Cursor = Cursors.Hand;
            btnLoanInfo.FlatAppearance.BorderSize = 0;
            btnLoanInfo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLoanInfo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLoanInfo.FlatStyle = FlatStyle.Flat;
            btnLoanInfo.Image = (Image)resources.GetObject("btnLoanInfo.Image");
            btnLoanInfo.Location = new Point(555, 109);
            btnLoanInfo.Name = "btnLoanInfo";
            btnLoanInfo.Size = new Size(53, 51);
            btnLoanInfo.TabIndex = 56;
            btnLoanInfo.UseVisualStyleBackColor = true;
            // 
            // btnPersonalInfo
            // 
            btnPersonalInfo.BackColor = Color.Transparent;
            btnPersonalInfo.Cursor = Cursors.Hand;
            btnPersonalInfo.FlatAppearance.BorderSize = 0;
            btnPersonalInfo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPersonalInfo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPersonalInfo.FlatStyle = FlatStyle.Flat;
            btnPersonalInfo.Image = (Image)resources.GetObject("btnPersonalInfo.Image");
            btnPersonalInfo.Location = new Point(88, 118);
            btnPersonalInfo.Name = "btnPersonalInfo";
            btnPersonalInfo.Size = new Size(53, 51);
            btnPersonalInfo.TabIndex = 55;
            btnPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 172);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 62;
            label1.Text = "PERSONAL INFO";
            // 
            // lblEmploymentInfo
            // 
            lblEmploymentInfo.AutoSize = true;
            lblEmploymentInfo.BackColor = Color.Transparent;
            lblEmploymentInfo.FlatStyle = FlatStyle.Flat;
            lblEmploymentInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmploymentInfo.ForeColor = SystemColors.ActiveCaptionText;
            lblEmploymentInfo.Location = new Point(192, 172);
            lblEmploymentInfo.Name = "lblEmploymentInfo";
            lblEmploymentInfo.Size = new Size(117, 15);
            lblEmploymentInfo.TabIndex = 63;
            lblEmploymentInfo.Text = "EMPLOYMENT INFO";
            // 
            // lblRealEstateInfo
            // 
            lblRealEstateInfo.AutoSize = true;
            lblRealEstateInfo.BackColor = Color.Transparent;
            lblRealEstateInfo.FlatStyle = FlatStyle.Flat;
            lblRealEstateInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRealEstateInfo.ForeColor = SystemColors.AppWorkspace;
            lblRealEstateInfo.Location = new Point(882, 172);
            lblRealEstateInfo.Name = "lblRealEstateInfo";
            lblRealEstateInfo.Size = new Size(108, 15);
            lblRealEstateInfo.TabIndex = 67;
            lblRealEstateInfo.Text = "REAL ESTATE INFO";
            // 
            // lblBankInfo
            // 
            lblBankInfo.AutoSize = true;
            lblBankInfo.BackColor = Color.Transparent;
            lblBankInfo.FlatStyle = FlatStyle.Flat;
            lblBankInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBankInfo.ForeColor = SystemColors.AppWorkspace;
            lblBankInfo.Location = new Point(730, 172);
            lblBankInfo.Name = "lblBankInfo";
            lblBankInfo.Size = new Size(71, 15);
            lblBankInfo.TabIndex = 66;
            lblBankInfo.Text = "BANK INFO";
            // 
            // lblLoanInfo
            // 
            lblLoanInfo.AutoSize = true;
            lblLoanInfo.BackColor = Color.Transparent;
            lblLoanInfo.FlatStyle = FlatStyle.Flat;
            lblLoanInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoanInfo.ForeColor = SystemColors.AppWorkspace;
            lblLoanInfo.Location = new Point(538, 172);
            lblLoanInfo.Name = "lblLoanInfo";
            lblLoanInfo.Size = new Size(70, 15);
            lblLoanInfo.TabIndex = 65;
            lblLoanInfo.Text = "LOAN INFO";
            // 
            // lblCollateralInfo
            // 
            lblCollateralInfo.AutoSize = true;
            lblCollateralInfo.BackColor = Color.Transparent;
            lblCollateralInfo.FlatStyle = FlatStyle.Flat;
            lblCollateralInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCollateralInfo.ForeColor = SystemColors.AppWorkspace;
            lblCollateralInfo.Location = new Point(357, 172);
            lblCollateralInfo.Name = "lblCollateralInfo";
            lblCollateralInfo.Size = new Size(108, 15);
            lblCollateralInfo.TabIndex = 64;
            lblCollateralInfo.Text = "COLLATERAL INFO";
            // 
            // lblOtherInfo
            // 
            lblOtherInfo.AutoSize = true;
            lblOtherInfo.BackColor = Color.Transparent;
            lblOtherInfo.FlatStyle = FlatStyle.Flat;
            lblOtherInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOtherInfo.ForeColor = SystemColors.AppWorkspace;
            lblOtherInfo.Location = new Point(1048, 172);
            lblOtherInfo.Name = "lblOtherInfo";
            lblOtherInfo.Size = new Size(112, 15);
            lblOtherInfo.TabIndex = 68;
            lblOtherInfo.Text = "OTHER LOAN INFO";
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
            button1.Location = new Point(232, 118);
            button1.Name = "button1";
            button1.Size = new Size(53, 51);
            button1.TabIndex = 69;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(391, 118);
            button2.Name = "button2";
            button2.Size = new Size(53, 51);
            button2.TabIndex = 70;
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(683, 298);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(495, 268);
            pictureBox1.TabIndex = 71;
            pictureBox1.TabStop = false;
            // 
            // ApplicationPart2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1280, 800);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblOtherInfo);
            Controls.Add(lblRealEstateInfo);
            Controls.Add(lblBankInfo);
            Controls.Add(lblLoanInfo);
            Controls.Add(lblCollateralInfo);
            Controls.Add(lblEmploymentInfo);
            Controls.Add(label1);
            Controls.Add(btnOtherLoanInfo);
            Controls.Add(btnRealEstateInfo);
            Controls.Add(btnBankInfo);
            Controls.Add(btnLoanInfo);
            Controls.Add(btnPersonalInfo);
            Controls.Add(cbModeOfPayment);
            Controls.Add(cbLoanTerm);
            Controls.Add(txtLoanAmount);
            Controls.Add(btnBack);
            Controls.Add(lblModeOfPayment);
            Controls.Add(lblLoanTerm);
            Controls.Add(lblLoanAmount);
            Controls.Add(btnNext);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ApplicationPart2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ApplicationPart2";
            Load += ApplicationPart2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNext;
        private Label lblLoanAmount;
        private Label lblLoanTerm;
        private Label lblModeOfPayment;
        private Button btnBack;
        private TextBox txtLoanAmount;
        private ComboBox cbLoanTerm;
        private ComboBox cbModeOfPayment;
        private Button btnOtherLoanInfo;
        private Button btnRealEstateInfo;
        private Button btnBankInfo;
        private Button btnLoanInfo;
        private Button btnPersonalInfo;
        private Label label1;
        private Label lblEmploymentInfo;
        private Label lblRealEstateInfo;
        private Label lblBankInfo;
        private Label lblLoanInfo;
        private Label lblCollateralInfo;
        private Label lblOtherInfo;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}