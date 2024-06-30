namespace _4PH_PAGIBIG_HOUSING
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
            lblMRID = new Label();
            lblLoanAmount = new Label();
            lblLoanTerm = new Label();
            lblModeOfPayment = new Label();
            lblTCT = new Label();
            btnLoanInfo = new Button();
            btnPersonalInfo = new Button();
            panel1 = new Panel();
            txtMRID = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            panel2 = new Panel();
            btnBack = new Button();
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
            // 
            // lblMRID
            // 
            lblMRID.AutoSize = true;
            lblMRID.BackColor = Color.Transparent;
            lblMRID.FlatStyle = FlatStyle.Flat;
            lblMRID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMRID.Location = new Point(73, 255);
            lblMRID.Name = "lblMRID";
            lblMRID.Size = new Size(124, 15);
            lblMRID.TabIndex = 18;
            lblMRID.Text = "PAG-IBIG MRID/RTN";
            // 
            // lblLoanAmount
            // 
            lblLoanAmount.AutoSize = true;
            lblLoanAmount.BackColor = Color.Transparent;
            lblLoanAmount.FlatStyle = FlatStyle.Flat;
            lblLoanAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoanAmount.Location = new Point(73, 349);
            lblLoanAmount.Name = "lblLoanAmount";
            lblLoanAmount.Size = new Size(95, 15);
            lblLoanAmount.TabIndex = 19;
            lblLoanAmount.Text = "LOAN AMOUNT";
            // 
            // lblLoanTerm
            // 
            lblLoanTerm.AutoSize = true;
            lblLoanTerm.BackColor = Color.Transparent;
            lblLoanTerm.FlatStyle = FlatStyle.Flat;
            lblLoanTerm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoanTerm.Location = new Point(73, 442);
            lblLoanTerm.Name = "lblLoanTerm";
            lblLoanTerm.Size = new Size(74, 15);
            lblLoanTerm.TabIndex = 20;
            lblLoanTerm.Text = "LOAN TERM";
            // 
            // lblModeOfPayment
            // 
            lblModeOfPayment.AutoSize = true;
            lblModeOfPayment.BackColor = Color.Transparent;
            lblModeOfPayment.FlatStyle = FlatStyle.Flat;
            lblModeOfPayment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModeOfPayment.Location = new Point(381, 442);
            lblModeOfPayment.Name = "lblModeOfPayment";
            lblModeOfPayment.Size = new Size(116, 15);
            lblModeOfPayment.TabIndex = 21;
            lblModeOfPayment.Text = "MODE OF PAYMENT";
            // 
            // lblTCT
            // 
            lblTCT.AutoSize = true;
            lblTCT.BackColor = Color.Transparent;
            lblTCT.FlatStyle = FlatStyle.Flat;
            lblTCT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTCT.Location = new Point(73, 537);
            lblTCT.Name = "lblTCT";
            lblTCT.Size = new Size(106, 15);
            lblTCT.TabIndex = 22;
            lblTCT.Text = "TCT/OCT/CCT NO.";
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
            btnLoanInfo.Location = new Point(250, 123);
            btnLoanInfo.Name = "btnLoanInfo";
            btnLoanInfo.Size = new Size(53, 51);
            btnLoanInfo.TabIndex = 23;
            btnLoanInfo.UseVisualStyleBackColor = true;
            btnLoanInfo.Click += btnLoan_Click;
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
            btnPersonalInfo.Location = new Point(84, 122);
            btnPersonalInfo.Name = "btnPersonalInfo";
            btnPersonalInfo.Size = new Size(53, 51);
            btnPersonalInfo.TabIndex = 24;
            btnPersonalInfo.UseVisualStyleBackColor = true;
            btnPersonalInfo.Click += btnPersonalInfo_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(640, 227);
            panel1.Name = "panel1";
            panel1.Size = new Size(528, 324);
            panel1.TabIndex = 25;
            // 
            // txtMRID
            // 
            txtMRID.BorderStyle = BorderStyle.None;
            txtMRID.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMRID.Location = new Point(82, 289);
            txtMRID.Name = "txtMRID";
            txtMRID.Size = new Size(197, 18);
            txtMRID.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(84, 383);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(478, 18);
            textBox1.TabIndex = 27;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(84, 478);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(254, 18);
            textBox2.TabIndex = 28;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(390, 476);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 18);
            textBox3.TabIndex = 29;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(82, 572);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(480, 18);
            textBox4.TabIndex = 30;
            // 
            // panel2
            // 
            panel2.Location = new Point(639, 229);
            panel2.Name = "panel2";
            panel2.Size = new Size(529, 323);
            panel2.TabIndex = 31;
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
            // ApplicationPart2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1280, 800);
            Controls.Add(btnBack);
            Controls.Add(panel2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtMRID);
            Controls.Add(panel1);
            Controls.Add(btnPersonalInfo);
            Controls.Add(btnLoanInfo);
            Controls.Add(lblTCT);
            Controls.Add(lblModeOfPayment);
            Controls.Add(lblLoanTerm);
            Controls.Add(lblLoanAmount);
            Controls.Add(lblMRID);
            Controls.Add(btnNext);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ApplicationPart2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ApplicationPart2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNext;
        private Label lblMRID;
        private Label lblLoanAmount;
        private Label lblLoanTerm;
        private Label lblModeOfPayment;
        private Label lblTCT;
        private Button btnLoanInfo;
        private Button btnPersonalInfo;
        private Panel panel1;
        private TextBox txtMRID;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Panel panel2;
        private Button btnBack;
    }
}