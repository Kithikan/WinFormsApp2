namespace WinFormsApp2
{
    partial class DBshow
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
            txt_Addn = new TextBox();
            lblAddmNO = new Label();
            DTPAddm = new DateTimePicker();
            DTPBIR = new DateTimePicker();
            rdoF = new RadioButton();
            rdoM = new RadioButton();
            txtADD = new TextBox();
            txtTel = new TextBox();
            txtNIC = new TextBox();
            txtL = new TextBox();
            txtF = new TextBox();
            label3 = new Label();
            lblTel = new Label();
            lblDOA = new Label();
            lblNIC = new Label();
            lblDOB = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblGrd = new Label();
            lblGen = new Label();
            lblL = new Label();
            lblF = new Label();
            txtGrade = new MaskedTextBox();
            txtMedium = new MaskedTextBox();
            txtFamilyID = new MaskedTextBox();
            txtHouseID = new MaskedTextBox();
            SuspendLayout();
            // 
            // txt_Addn
            // 
            txt_Addn.Location = new Point(211, 545);
            txt_Addn.Name = "txt_Addn";
            txt_Addn.Size = new Size(257, 27);
            txt_Addn.TabIndex = 121;
            // 
            // lblAddmNO
            // 
            lblAddmNO.AutoSize = true;
            lblAddmNO.Location = new Point(23, 548);
            lblAddmNO.Name = "lblAddmNO";
            lblAddmNO.Size = new Size(145, 20);
            lblAddmNO.TabIndex = 120;
            lblAddmNO.Text = "Addmission Number";
            // 
            // DTPAddm
            // 
            DTPAddm.Location = new Point(211, 270);
            DTPAddm.Name = "DTPAddm";
            DTPAddm.Size = new Size(250, 27);
            DTPAddm.TabIndex = 119;
            DTPAddm.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // DTPBIR
            // 
            DTPBIR.Location = new Point(211, 222);
            DTPBIR.Name = "DTPBIR";
            DTPBIR.Size = new Size(250, 27);
            DTPBIR.TabIndex = 118;
            // 
            // rdoF
            // 
            rdoF.AutoSize = true;
            rdoF.Location = new Point(388, 120);
            rdoF.Name = "rdoF";
            rdoF.Size = new Size(78, 24);
            rdoF.TabIndex = 117;
            rdoF.TabStop = true;
            rdoF.Text = "Female";
            rdoF.UseVisualStyleBackColor = true;
            // 
            // rdoM
            // 
            rdoM.AutoSize = true;
            rdoM.Location = new Point(211, 120);
            rdoM.Name = "rdoM";
            rdoM.Size = new Size(63, 24);
            rdoM.TabIndex = 116;
            rdoM.TabStop = true;
            rdoM.Text = "Male";
            rdoM.UseVisualStyleBackColor = true;
            // 
            // txtADD
            // 
            txtADD.Location = new Point(211, 394);
            txtADD.Name = "txtADD";
            txtADD.Size = new Size(255, 27);
            txtADD.TabIndex = 110;
            txtADD.TextChanged += txtADD_TextChanged;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(209, 354);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(257, 27);
            txtTel.TabIndex = 111;
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(211, 313);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(255, 27);
            txtNIC.TabIndex = 109;
            // 
            // txtL
            // 
            txtL.Location = new Point(209, 87);
            txtL.Name = "txtL";
            txtL.Size = new Size(259, 27);
            txtL.TabIndex = 108;
            txtL.TextChanged += txtL_TextChanged;
            // 
            // txtF
            // 
            txtF.Location = new Point(211, 31);
            txtF.Name = "txtF";
            txtF.Size = new Size(255, 27);
            txtF.TabIndex = 107;
            txtF.TextChanged += txtF_TextChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(23, 394);
            label3.Name = "label3";
            label3.Size = new Size(144, 32);
            label3.TabIndex = 105;
            label3.Text = "Address";
            label3.UseCompatibleTextRendering = true;
            // 
            // lblTel
            // 
            lblTel.Font = new Font("Segoe UI", 9F);
            lblTel.Location = new Point(22, 349);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(144, 32);
            lblTel.TabIndex = 104;
            lblTel.Text = "Tel Number";
            lblTel.UseCompatibleTextRendering = true;
            // 
            // lblDOA
            // 
            lblDOA.Font = new Font("Segoe UI", 9F);
            lblDOA.Location = new Point(24, 270);
            lblDOA.Name = "lblDOA";
            lblDOA.Size = new Size(181, 32);
            lblDOA.TabIndex = 103;
            lblDOA.Text = "Date of Admission";
            lblDOA.UseCompatibleTextRendering = true;
            // 
            // lblNIC
            // 
            lblNIC.Font = new Font("Segoe UI", 9F);
            lblNIC.Location = new Point(22, 308);
            lblNIC.Name = "lblNIC";
            lblNIC.Size = new Size(144, 32);
            lblNIC.TabIndex = 102;
            lblNIC.Text = "NIC number";
            lblNIC.UseCompatibleTextRendering = true;
            // 
            // lblDOB
            // 
            lblDOB.Font = new Font("Segoe UI", 9F);
            lblDOB.Location = new Point(22, 217);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(144, 32);
            lblDOB.TabIndex = 101;
            lblDOB.Text = "Date of Birth";
            lblDOB.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(22, 505);
            label4.Name = "label4";
            label4.Size = new Size(144, 32);
            label4.TabIndex = 100;
            label4.Text = "Family id";
            label4.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(22, 469);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 99;
            label2.Text = "House id";
            label2.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(23, 433);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 98;
            label1.Text = "Medium";
            label1.UseCompatibleTextRendering = true;
            // 
            // lblGrd
            // 
            lblGrd.Font = new Font("Segoe UI", 9F);
            lblGrd.Location = new Point(20, 169);
            lblGrd.Name = "lblGrd";
            lblGrd.Size = new Size(144, 32);
            lblGrd.TabIndex = 97;
            lblGrd.Text = "Grade";
            lblGrd.UseCompatibleTextRendering = true;
            // 
            // lblGen
            // 
            lblGen.Font = new Font("Segoe UI", 9F);
            lblGen.Location = new Point(22, 118);
            lblGen.Name = "lblGen";
            lblGen.Size = new Size(110, 32);
            lblGen.TabIndex = 96;
            lblGen.Text = "Gender";
            lblGen.UseCompatibleTextRendering = true;
            // 
            // lblL
            // 
            lblL.Font = new Font("Segoe UI", 9F);
            lblL.Location = new Point(22, 81);
            lblL.Name = "lblL";
            lblL.Size = new Size(142, 27);
            lblL.TabIndex = 106;
            lblL.Text = "Last Name ";
            lblL.UseCompatibleTextRendering = true;
            // 
            // lblF
            // 
            lblF.Font = new Font("Segoe UI", 9F);
            lblF.Location = new Point(22, 26);
            lblF.Name = "lblF";
            lblF.Size = new Size(110, 32);
            lblF.TabIndex = 95;
            lblF.Text = "First Name ";
            lblF.UseCompatibleTextRendering = true;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(209, 174);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(252, 27);
            txtGrade.TabIndex = 122;
            // 
            // txtMedium
            // 
            txtMedium.Location = new Point(209, 433);
            txtMedium.Name = "txtMedium";
            txtMedium.Size = new Size(252, 27);
            txtMedium.TabIndex = 123;
            // 
            // txtFamilyID
            // 
            txtFamilyID.Location = new Point(209, 505);
            txtFamilyID.Name = "txtFamilyID";
            txtFamilyID.Size = new Size(252, 27);
            txtFamilyID.TabIndex = 124;
            txtFamilyID.MaskInputRejected += txtFmilyID_MaskInputRejected;
            // 
            // txtHouseID
            // 
            txtHouseID.Location = new Point(211, 466);
            txtHouseID.Name = "txtHouseID";
            txtHouseID.Size = new Size(252, 27);
            txtHouseID.TabIndex = 125;
            txtHouseID.MaskInputRejected += txtHouseID_MaskInputRejected;
            // 
            // DBshow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 628);
            Controls.Add(txtHouseID);
            Controls.Add(txtFamilyID);
            Controls.Add(txtMedium);
            Controls.Add(txtGrade);
            Controls.Add(txt_Addn);
            Controls.Add(lblAddmNO);
            Controls.Add(DTPAddm);
            Controls.Add(DTPBIR);
            Controls.Add(rdoF);
            Controls.Add(rdoM);
            Controls.Add(txtADD);
            Controls.Add(txtTel);
            Controls.Add(txtNIC);
            Controls.Add(txtL);
            Controls.Add(txtF);
            Controls.Add(label3);
            Controls.Add(lblTel);
            Controls.Add(lblDOA);
            Controls.Add(lblNIC);
            Controls.Add(lblDOB);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblGrd);
            Controls.Add(lblGen);
            Controls.Add(lblL);
            Controls.Add(lblF);
            Name = "DBshow";
            Text = "DBshow";
            Load += DBshow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Addn;
        private Label lblAddmNO;
        private DateTimePicker DTPAddm;
        private DateTimePicker DTPBIR;
        private RadioButton rdoF;
        private RadioButton rdoM;
        private TextBox txtADD;
        private TextBox txtTel;
        private TextBox txtNIC;
        private TextBox txtL;
        private TextBox txtF;
        private Label label3;
        private Label lblTel;
        private Label lblDOA;
        private Label lblNIC;
        private Label lblDOB;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label lblGrd;
        private Label lblGen;
        private Label lblL;
        private Label lblF;
        private MaskedTextBox txtGrade;
        private MaskedTextBox txtMedium;
        private MaskedTextBox txtFamilyID;
        private MaskedTextBox txtHouseID;
    }
}