namespace _4PH_PAGIBIG_HOUSING
{
    partial class ApplicationPart1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationPart1));
            btnPersonalInfo = new Button();
            lblMID = new Label();
            lblFullname = new Label();
            lblSex = new Label();
            lblNationality = new Label();
            lblBirthdate = new Label();
            lblPresentAddress = new Label();
            lblPermanentAddress = new Label();
            lblMaritalStatus = new Label();
            lblLandline = new Label();
            lblCellphoneNumber = new Label();
            lblEmailAddress = new Label();
            lblHomeOwnership = new Label();
            lblYearsOfStay = new Label();
            lblSSS = new Label();
            btnNext = new Button();
            btnBack = new Button();
            txtMRID = new TextBox();
            txtFullname = new TextBox();
            txtNationality = new TextBox();
            txtPresentAddress = new TextBox();
            txtPermanentAddress = new TextBox();
            txtCellphoneNumber = new TextBox();
            txtEmailAddress = new TextBox();
            txtLandline = new TextBox();
            txtSSS = new TextBox();
            cbSex = new ComboBox();
            cbMaritalStatus = new ComboBox();
            cbHomeOwnership = new ComboBox();
            cbYearsOfStay = new ComboBox();
            dtBirthdate = new DateTimePicker();
            btnLoanInfo = new Button();
            btnCollateralInfo = new Button();
            btnEmploymentInfo = new Button();
            btnBankInfo = new Button();
            btnRealEstateInfo = new Button();
            btnOtherLoanInfo = new Button();
            label1 = new Label();
            lblLoanInfo = new Label();
            lblCollateralInfo = new Label();
            lblEmploymentInfo = new Label();
            lblBankInfo = new Label();
            lblRealEstateInfo = new Label();
            lblOtherInfo = new Label();
            SuspendLayout();
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
            btnPersonalInfo.TabIndex = 1;
            btnPersonalInfo.UseVisualStyleBackColor = true;
            btnPersonalInfo.Click += btnPersonalInfo_Click;
            // 
            // lblMID
            // 
            lblMID.AutoSize = true;
            lblMID.BackColor = Color.Transparent;
            lblMID.FlatStyle = FlatStyle.Flat;
            lblMID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMID.Location = new Point(70, 255);
            lblMID.Name = "lblMID";
            lblMID.Size = new Size(124, 15);
            lblMID.TabIndex = 2;
            lblMID.Text = "PAG-IBIG MRID/RTN";
            lblMID.Click += lblMID_Click;
            // 
            // lblFullname
            // 
            lblFullname.AutoSize = true;
            lblFullname.BackColor = Color.Transparent;
            lblFullname.FlatStyle = FlatStyle.Flat;
            lblFullname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullname.Location = new Point(70, 348);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(305, 15);
            lblFullname.TabIndex = 3;
            lblFullname.Text = "FULL NAME (SURNAME, FIRSTNAME MIDDLE INITIAL)";
            lblFullname.Click += label1_Click;
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.BackColor = Color.Transparent;
            lblSex.FlatStyle = FlatStyle.Flat;
            lblSex.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSex.Location = new Point(598, 348);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(28, 15);
            lblSex.TabIndex = 4;
            lblSex.Text = "SEX";
            lblSex.Click += label1_Click_1;
            // 
            // lblNationality
            // 
            lblNationality.AutoSize = true;
            lblNationality.BackColor = Color.Transparent;
            lblNationality.FlatStyle = FlatStyle.Flat;
            lblNationality.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNationality.Location = new Point(675, 348);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(84, 15);
            lblNationality.TabIndex = 5;
            lblNationality.Text = "NATIONALITY";
            // 
            // lblBirthdate
            // 
            lblBirthdate.AutoSize = true;
            lblBirthdate.BackColor = Color.Transparent;
            lblBirthdate.FlatStyle = FlatStyle.Flat;
            lblBirthdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBirthdate.Location = new Point(886, 348);
            lblBirthdate.Name = "lblBirthdate";
            lblBirthdate.Size = new Size(72, 15);
            lblBirthdate.TabIndex = 6;
            lblBirthdate.Text = "BIRTHDATE";
            // 
            // lblPresentAddress
            // 
            lblPresentAddress.AutoSize = true;
            lblPresentAddress.BackColor = Color.Transparent;
            lblPresentAddress.FlatStyle = FlatStyle.Flat;
            lblPresentAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPresentAddress.Location = new Point(70, 433);
            lblPresentAddress.Name = "lblPresentAddress";
            lblPresentAddress.Size = new Size(114, 15);
            lblPresentAddress.TabIndex = 7;
            lblPresentAddress.Text = "PRESENT ADDRESS";
            // 
            // lblPermanentAddress
            // 
            lblPermanentAddress.AutoSize = true;
            lblPermanentAddress.BackColor = Color.Transparent;
            lblPermanentAddress.FlatStyle = FlatStyle.Flat;
            lblPermanentAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPermanentAddress.Location = new Point(598, 433);
            lblPermanentAddress.Name = "lblPermanentAddress";
            lblPermanentAddress.Size = new Size(135, 15);
            lblPermanentAddress.TabIndex = 8;
            lblPermanentAddress.Text = "PERMANENT ADDRESS";
            // 
            // lblMaritalStatus
            // 
            lblMaritalStatus.AutoSize = true;
            lblMaritalStatus.BackColor = Color.Transparent;
            lblMaritalStatus.FlatStyle = FlatStyle.Flat;
            lblMaritalStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaritalStatus.Location = new Point(70, 526);
            lblMaritalStatus.Name = "lblMaritalStatus";
            lblMaritalStatus.Size = new Size(104, 15);
            lblMaritalStatus.TabIndex = 9;
            lblMaritalStatus.Text = "MARITAL STATUS";
            // 
            // lblLandline
            // 
            lblLandline.AutoSize = true;
            lblLandline.BackColor = Color.Transparent;
            lblLandline.FlatStyle = FlatStyle.Flat;
            lblLandline.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLandline.Location = new Point(291, 526);
            lblLandline.Name = "lblLandline";
            lblLandline.Size = new Size(64, 15);
            lblLandline.TabIndex = 10;
            lblLandline.Text = "LANDLINE";
            lblLandline.Click += label4_Click;
            // 
            // lblCellphoneNumber
            // 
            lblCellphoneNumber.AutoSize = true;
            lblCellphoneNumber.BackColor = Color.Transparent;
            lblCellphoneNumber.FlatStyle = FlatStyle.Flat;
            lblCellphoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCellphoneNumber.Location = new Point(598, 526);
            lblCellphoneNumber.Name = "lblCellphoneNumber";
            lblCellphoneNumber.Size = new Size(126, 15);
            lblCellphoneNumber.TabIndex = 11;
            lblCellphoneNumber.Text = "CELLPHONE NUMBER";
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.BackColor = Color.Transparent;
            lblEmailAddress.FlatStyle = FlatStyle.Flat;
            lblEmailAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailAddress.Location = new Point(813, 526);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(99, 15);
            lblEmailAddress.TabIndex = 12;
            lblEmailAddress.Text = "EMAIL ADDRESS";
            // 
            // lblHomeOwnership
            // 
            lblHomeOwnership.AutoSize = true;
            lblHomeOwnership.BackColor = Color.Transparent;
            lblHomeOwnership.FlatStyle = FlatStyle.Flat;
            lblHomeOwnership.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHomeOwnership.Location = new Point(70, 613);
            lblHomeOwnership.Name = "lblHomeOwnership";
            lblHomeOwnership.Size = new Size(116, 15);
            lblHomeOwnership.TabIndex = 13;
            lblHomeOwnership.Text = "HOME OWNERSHIP";
            // 
            // lblYearsOfStay
            // 
            lblYearsOfStay.AutoSize = true;
            lblYearsOfStay.BackColor = Color.Transparent;
            lblYearsOfStay.FlatStyle = FlatStyle.Flat;
            lblYearsOfStay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYearsOfStay.Location = new Point(383, 613);
            lblYearsOfStay.Name = "lblYearsOfStay";
            lblYearsOfStay.Size = new Size(91, 15);
            lblYearsOfStay.TabIndex = 14;
            lblYearsOfStay.Text = "YEARS OF STAY";
            // 
            // lblSSS
            // 
            lblSSS.AutoSize = true;
            lblSSS.BackColor = Color.Transparent;
            lblSSS.FlatStyle = FlatStyle.Flat;
            lblSSS.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSSS.Location = new Point(598, 613);
            lblSSS.Name = "lblSSS";
            lblSSS.RightToLeft = RightToLeft.No;
            lblSSS.Size = new Size(115, 15);
            lblSSS.TabIndex = 15;
            lblSSS.Text = "EE SSS/GSIS ID NO.";
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
            btnNext.Size = new Size(127, 45);
            btnNext.TabIndex = 16;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
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
            btnBack.TabIndex = 29;
            btnBack.UseVisualStyleBackColor = true;
            // 
            // txtMRID
            // 
            txtMRID.BackColor = Color.WhiteSmoke;
            txtMRID.Location = new Point(70, 277);
            txtMRID.Multiline = true;
            txtMRID.Name = "txtMRID";
            txtMRID.Size = new Size(218, 42);
            txtMRID.TabIndex = 30;
            // 
            // txtFullname
            // 
            txtFullname.BackColor = Color.WhiteSmoke;
            txtFullname.Location = new Point(70, 366);
            txtFullname.Multiline = true;
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(495, 42);
            txtFullname.TabIndex = 31;
            // 
            // txtNationality
            // 
            txtNationality.BackColor = Color.WhiteSmoke;
            txtNationality.Location = new Point(675, 366);
            txtNationality.Multiline = true;
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(191, 42);
            txtNationality.TabIndex = 32;
            // 
            // txtPresentAddress
            // 
            txtPresentAddress.BackColor = Color.WhiteSmoke;
            txtPresentAddress.Location = new Point(70, 451);
            txtPresentAddress.Multiline = true;
            txtPresentAddress.Name = "txtPresentAddress";
            txtPresentAddress.Size = new Size(495, 42);
            txtPresentAddress.TabIndex = 34;
            // 
            // txtPermanentAddress
            // 
            txtPermanentAddress.BackColor = Color.WhiteSmoke;
            txtPermanentAddress.Location = new Point(598, 451);
            txtPermanentAddress.Multiline = true;
            txtPermanentAddress.Name = "txtPermanentAddress";
            txtPermanentAddress.Size = new Size(498, 42);
            txtPermanentAddress.TabIndex = 35;
            // 
            // txtCellphoneNumber
            // 
            txtCellphoneNumber.BackColor = Color.WhiteSmoke;
            txtCellphoneNumber.Location = new Point(598, 544);
            txtCellphoneNumber.Multiline = true;
            txtCellphoneNumber.Name = "txtCellphoneNumber";
            txtCellphoneNumber.Size = new Size(193, 42);
            txtCellphoneNumber.TabIndex = 38;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.BackColor = Color.WhiteSmoke;
            txtEmailAddress.Location = new Point(813, 544);
            txtEmailAddress.Multiline = true;
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(283, 42);
            txtEmailAddress.TabIndex = 39;
            // 
            // txtLandline
            // 
            txtLandline.BackColor = Color.WhiteSmoke;
            txtLandline.Location = new Point(291, 544);
            txtLandline.Multiline = true;
            txtLandline.Name = "txtLandline";
            txtLandline.Size = new Size(274, 42);
            txtLandline.TabIndex = 40;
            // 
            // txtSSS
            // 
            txtSSS.BackColor = Color.WhiteSmoke;
            txtSSS.Location = new Point(598, 631);
            txtSSS.Multiline = true;
            txtSSS.Name = "txtSSS";
            txtSSS.Size = new Size(498, 42);
            txtSSS.TabIndex = 43;
            // 
            // cbSex
            // 
            cbSex.FormattingEnabled = true;
            cbSex.Items.AddRange(new object[] { "Male", "Female", "Beks" });
            cbSex.Location = new Point(598, 366);
            cbSex.Name = "cbSex";
            cbSex.Size = new Size(56, 23);
            cbSex.TabIndex = 44;
            cbSex.Text = " ";
            // 
            // cbMaritalStatus
            // 
            cbMaritalStatus.FormattingEnabled = true;
            cbMaritalStatus.Items.AddRange(new object[] { "Male", "Female", "Beks" });
            cbMaritalStatus.Location = new Point(70, 544);
            cbMaritalStatus.Name = "cbMaritalStatus";
            cbMaritalStatus.Size = new Size(204, 23);
            cbMaritalStatus.TabIndex = 45;
            cbMaritalStatus.Text = " ";
            // 
            // cbHomeOwnership
            // 
            cbHomeOwnership.FormattingEnabled = true;
            cbHomeOwnership.Items.AddRange(new object[] { "Male", "Female", "Beks" });
            cbHomeOwnership.Location = new Point(70, 631);
            cbHomeOwnership.Name = "cbHomeOwnership";
            cbHomeOwnership.Size = new Size(285, 23);
            cbHomeOwnership.TabIndex = 46;
            cbHomeOwnership.Text = " ";
            // 
            // cbYearsOfStay
            // 
            cbYearsOfStay.FormattingEnabled = true;
            cbYearsOfStay.Items.AddRange(new object[] { "Male", "Female", "Beks" });
            cbYearsOfStay.Location = new Point(383, 631);
            cbYearsOfStay.Name = "cbYearsOfStay";
            cbYearsOfStay.Size = new Size(182, 23);
            cbYearsOfStay.TabIndex = 47;
            cbYearsOfStay.Text = " ";
            // 
            // dtBirthdate
            // 
            dtBirthdate.Location = new Point(886, 366);
            dtBirthdate.Name = "dtBirthdate";
            dtBirthdate.Size = new Size(210, 23);
            dtBirthdate.TabIndex = 48;
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
            btnLoanInfo.Location = new Point(221, 118);
            btnLoanInfo.Name = "btnLoanInfo";
            btnLoanInfo.Size = new Size(53, 51);
            btnLoanInfo.TabIndex = 49;
            btnLoanInfo.UseVisualStyleBackColor = true;
            // 
            // btnCollateralInfo
            // 
            btnCollateralInfo.BackColor = Color.Transparent;
            btnCollateralInfo.Cursor = Cursors.Hand;
            btnCollateralInfo.FlatAppearance.BorderSize = 0;
            btnCollateralInfo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCollateralInfo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCollateralInfo.FlatStyle = FlatStyle.Flat;
            btnCollateralInfo.Image = (Image)resources.GetObject("btnCollateralInfo.Image");
            btnCollateralInfo.Location = new Point(383, 118);
            btnCollateralInfo.Name = "btnCollateralInfo";
            btnCollateralInfo.Size = new Size(53, 51);
            btnCollateralInfo.TabIndex = 50;
            btnCollateralInfo.UseVisualStyleBackColor = true;
            // 
            // btnEmploymentInfo
            // 
            btnEmploymentInfo.BackColor = Color.Transparent;
            btnEmploymentInfo.Cursor = Cursors.Hand;
            btnEmploymentInfo.FlatAppearance.BorderSize = 0;
            btnEmploymentInfo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEmploymentInfo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEmploymentInfo.FlatStyle = FlatStyle.Flat;
            btnEmploymentInfo.Image = (Image)resources.GetObject("btnEmploymentInfo.Image");
            btnEmploymentInfo.Location = new Point(555, 118);
            btnEmploymentInfo.Name = "btnEmploymentInfo";
            btnEmploymentInfo.Size = new Size(53, 51);
            btnEmploymentInfo.TabIndex = 51;
            btnEmploymentInfo.UseVisualStyleBackColor = true;
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
            btnBankInfo.TabIndex = 52;
            btnBankInfo.UseVisualStyleBackColor = true;
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
            btnRealEstateInfo.TabIndex = 53;
            btnRealEstateInfo.UseVisualStyleBackColor = true;
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
            btnOtherLoanInfo.TabIndex = 54;
            btnOtherLoanInfo.UseVisualStyleBackColor = true;
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
            label1.TabIndex = 55;
            label1.Text = "PERSONAL INFO";
            label1.Click += label1_Click_2;
            // 
            // lblLoanInfo
            // 
            lblLoanInfo.AutoSize = true;
            lblLoanInfo.BackColor = Color.Transparent;
            lblLoanInfo.FlatStyle = FlatStyle.Flat;
            lblLoanInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoanInfo.ForeColor = SystemColors.AppWorkspace;
            lblLoanInfo.Location = new Point(211, 172);
            lblLoanInfo.Name = "lblLoanInfo";
            lblLoanInfo.Size = new Size(70, 15);
            lblLoanInfo.TabIndex = 56;
            lblLoanInfo.Text = "LOAN INFO";
            // 
            // lblCollateralInfo
            // 
            lblCollateralInfo.AutoSize = true;
            lblCollateralInfo.BackColor = Color.Transparent;
            lblCollateralInfo.FlatStyle = FlatStyle.Flat;
            lblCollateralInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCollateralInfo.ForeColor = SystemColors.AppWorkspace;
            lblCollateralInfo.Location = new Point(358, 172);
            lblCollateralInfo.Name = "lblCollateralInfo";
            lblCollateralInfo.Size = new Size(108, 15);
            lblCollateralInfo.TabIndex = 57;
            lblCollateralInfo.Text = "COLLATERAL INFO";
            // 
            // lblEmploymentInfo
            // 
            lblEmploymentInfo.AutoSize = true;
            lblEmploymentInfo.BackColor = Color.Transparent;
            lblEmploymentInfo.FlatStyle = FlatStyle.Flat;
            lblEmploymentInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmploymentInfo.ForeColor = SystemColors.AppWorkspace;
            lblEmploymentInfo.Location = new Point(525, 172);
            lblEmploymentInfo.Name = "lblEmploymentInfo";
            lblEmploymentInfo.Size = new Size(117, 15);
            lblEmploymentInfo.TabIndex = 58;
            lblEmploymentInfo.Text = "EMPLOYMENT INFO";
            // 
            // lblBankInfo
            // 
            lblBankInfo.AutoSize = true;
            lblBankInfo.BackColor = Color.Transparent;
            lblBankInfo.FlatStyle = FlatStyle.Flat;
            lblBankInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBankInfo.ForeColor = SystemColors.AppWorkspace;
            lblBankInfo.Location = new Point(731, 172);
            lblBankInfo.Name = "lblBankInfo";
            lblBankInfo.Size = new Size(71, 15);
            lblBankInfo.TabIndex = 59;
            lblBankInfo.Text = "BANK INFO";
            // 
            // lblRealEstateInfo
            // 
            lblRealEstateInfo.AutoSize = true;
            lblRealEstateInfo.BackColor = Color.Transparent;
            lblRealEstateInfo.FlatStyle = FlatStyle.Flat;
            lblRealEstateInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRealEstateInfo.ForeColor = SystemColors.AppWorkspace;
            lblRealEstateInfo.Location = new Point(883, 172);
            lblRealEstateInfo.Name = "lblRealEstateInfo";
            lblRealEstateInfo.Size = new Size(108, 15);
            lblRealEstateInfo.TabIndex = 60;
            lblRealEstateInfo.Text = "REAL ESTATE INFO";
            // 
            // lblOtherInfo
            // 
            lblOtherInfo.AutoSize = true;
            lblOtherInfo.BackColor = Color.Transparent;
            lblOtherInfo.FlatStyle = FlatStyle.Flat;
            lblOtherInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOtherInfo.ForeColor = SystemColors.AppWorkspace;
            lblOtherInfo.Location = new Point(1053, 172);
            lblOtherInfo.Name = "lblOtherInfo";
            lblOtherInfo.Size = new Size(112, 15);
            lblOtherInfo.TabIndex = 61;
            lblOtherInfo.Text = "OTHER LOAN INFO";
            // 
            // ApplicationPart1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1280, 800);
            Controls.Add(lblOtherInfo);
            Controls.Add(lblRealEstateInfo);
            Controls.Add(lblBankInfo);
            Controls.Add(lblEmploymentInfo);
            Controls.Add(lblCollateralInfo);
            Controls.Add(lblLoanInfo);
            Controls.Add(label1);
            Controls.Add(btnOtherLoanInfo);
            Controls.Add(btnRealEstateInfo);
            Controls.Add(btnBankInfo);
            Controls.Add(btnEmploymentInfo);
            Controls.Add(btnCollateralInfo);
            Controls.Add(btnLoanInfo);
            Controls.Add(dtBirthdate);
            Controls.Add(cbYearsOfStay);
            Controls.Add(cbHomeOwnership);
            Controls.Add(cbMaritalStatus);
            Controls.Add(cbSex);
            Controls.Add(txtSSS);
            Controls.Add(txtLandline);
            Controls.Add(txtEmailAddress);
            Controls.Add(txtCellphoneNumber);
            Controls.Add(txtPermanentAddress);
            Controls.Add(txtPresentAddress);
            Controls.Add(txtNationality);
            Controls.Add(txtFullname);
            Controls.Add(txtMRID);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Controls.Add(lblSSS);
            Controls.Add(lblYearsOfStay);
            Controls.Add(lblHomeOwnership);
            Controls.Add(lblEmailAddress);
            Controls.Add(lblCellphoneNumber);
            Controls.Add(lblLandline);
            Controls.Add(lblMaritalStatus);
            Controls.Add(lblPermanentAddress);
            Controls.Add(lblPresentAddress);
            Controls.Add(lblBirthdate);
            Controls.Add(lblNationality);
            Controls.Add(lblSex);
            Controls.Add(lblFullname);
            Controls.Add(lblMID);
            Controls.Add(btnPersonalInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ApplicationPart1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "+";
            Load += ApplicationPart1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPersonalInfo;
        private Label lblMID;
        private Label lblFullname;
        private Label lblSex;
        private Label lblNationality;
        private Label lblBirthdate;
        private Label lblPresentAddress;
        private Label lblPermanentAddress;
        private Label lblMaritalStatus;
        private Label lblLandline;
        private Label lblCellphoneNumber;
        private Label lblEmailAddress;
        private Label lblHomeOwnership;
        private Label lblYearsOfStay;
        private Label lblSSS;
        private Button btnNext;
        private Button btnBack;
        private TextBox txtMRID;
        private TextBox txtFullname;
        private TextBox txtNationality;
        private TextBox txtPresentAddress;
        private TextBox txtPermanentAddress;
        private TextBox txtCellphoneNumber;
        private TextBox txtEmailAddress;
        private TextBox txtLandline;
        private TextBox txtSSS;
        private ComboBox cbSex;
        private ComboBox cbMaritalStatus;
        private ComboBox cbHomeOwnership;
        private ComboBox cbYearsOfStay;
        private DateTimePicker dtBirthdate;
        private Button btnLoanInfo;
        private Button btnCollateralInfo;
        private Button btnEmploymentInfo;
        private Button btnBankInfo;
        private Button btnRealEstateInfo;
        private Button btnOtherLoanInfo;
        private Label label1;
        private Label lblLoanInfo;
        private Label lblCollateralInfo;
        private Label lblEmploymentInfo;
        private Label lblBankInfo;
        private Label lblRealEstateInfo;
        private Label lblOtherInfo;
    }
}