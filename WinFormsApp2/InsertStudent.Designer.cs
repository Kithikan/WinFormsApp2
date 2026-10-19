namespace WinFormsApp2
{
    partial class InsertStudent
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
            dtpAddm = new DateTimePicker();
            DTPbod = new DateTimePicker();
            radioButtonM = new RadioButton();
            cmb_Family = new ComboBox();
            cmb_House = new ComboBox();
            cmb_Medium = new ComboBox();
            cmbLG = new ComboBox();
            txtADD = new TextBox();
            txtTel = new TextBox();
            txtNIC = new TextBox();
            txtL = new TextBox();
            txt_Sid = new TextBox();
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
            lbl_StudentID = new Label();
            lblF = new Label();
            btn_Insert = new Button();
            radioButtonF = new RadioButton();
            SuspendLayout();
            // 
            // txt_Addn
            // 
            txt_Addn.Location = new Point(204, 574);
            txt_Addn.Name = "txt_Addn";
            txt_Addn.Size = new Size(257, 27);
            txt_Addn.TabIndex = 122;
            txt_Addn.TextChanged += txt_Addn_TextChanged;
            // 
            // lblAddmNO
            // 
            lblAddmNO.AutoSize = true;
            lblAddmNO.Location = new Point(16, 577);
            lblAddmNO.Name = "lblAddmNO";
            lblAddmNO.Size = new Size(145, 20);
            lblAddmNO.TabIndex = 121;
            lblAddmNO.Text = "Addmission Number";
            // 
            // dtpAddm
            // 
            dtpAddm.Location = new Point(204, 299);
            dtpAddm.Name = "dtpAddm";
            dtpAddm.Size = new Size(250, 27);
            dtpAddm.TabIndex = 120;
            dtpAddm.ValueChanged += dtpAddm_ValueChanged;
            // 
            // DTPbod
            // 
            DTPbod.Location = new Point(204, 251);
            DTPbod.Name = "DTPbod";
            DTPbod.Size = new Size(250, 27);
            DTPbod.TabIndex = 119;
            // 
            // radioButtonM
            // 
            radioButtonM.AutoSize = true;
            radioButtonM.Location = new Point(204, 149);
            radioButtonM.Name = "radioButtonM";
            radioButtonM.Size = new Size(63, 24);
            radioButtonM.TabIndex = 118;
            radioButtonM.TabStop = true;
            radioButtonM.Text = "Male";
            radioButtonM.UseVisualStyleBackColor = true;
            // 
            // cmb_Family
            // 
            cmb_Family.FormattingEnabled = true;
            cmb_Family.Location = new Point(204, 534);
            cmb_Family.Name = "cmb_Family";
            cmb_Family.Size = new Size(255, 28);
            cmb_Family.TabIndex = 117;
            // 
            // cmb_House
            // 
            cmb_House.FormattingEnabled = true;
            cmb_House.Location = new Point(204, 498);
            cmb_House.Name = "cmb_House";
            cmb_House.Size = new Size(255, 28);
            cmb_House.TabIndex = 116;
            // 
            // cmb_Medium
            // 
            cmb_Medium.FormattingEnabled = true;
            cmb_Medium.Items.AddRange(new object[] { "Tamil ", "English" });
            cmb_Medium.Location = new Point(206, 462);
            cmb_Medium.Name = "cmb_Medium";
            cmb_Medium.Size = new Size(255, 28);
            cmb_Medium.TabIndex = 115;
            // 
            // cmbLG
            // 
            cmbLG.FormattingEnabled = true;
            cmbLG.Location = new Point(202, 179);
            cmbLG.Name = "cmbLG";
            cmbLG.Size = new Size(257, 28);
            cmbLG.TabIndex = 114;
            // 
            // txtADD
            // 
            txtADD.Location = new Point(204, 423);
            txtADD.Name = "txtADD";
            txtADD.Size = new Size(255, 27);
            txtADD.TabIndex = 112;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(202, 383);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(257, 27);
            txtTel.TabIndex = 113;
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(204, 342);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(255, 27);
            txtNIC.TabIndex = 111;
            // 
            // txtL
            // 
            txtL.Location = new Point(202, 116);
            txtL.Name = "txtL";
            txtL.Size = new Size(259, 27);
            txtL.TabIndex = 110;
            // 
            // txt_Sid
            // 
            txt_Sid.Location = new Point(204, 11);
            txt_Sid.Name = "txt_Sid";
            txt_Sid.Size = new Size(255, 27);
            txt_Sid.TabIndex = 109;
            txt_Sid.TextChanged += txt_Sid_TextChanged;
            // 
            // txtF
            // 
            txtF.Location = new Point(204, 60);
            txtF.Name = "txtF";
            txtF.Size = new Size(255, 27);
            txtF.TabIndex = 108;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(16, 423);
            label3.Name = "label3";
            label3.Size = new Size(144, 32);
            label3.TabIndex = 106;
            label3.Text = "Address";
            label3.UseCompatibleTextRendering = true;
            // 
            // lblTel
            // 
            lblTel.Font = new Font("Segoe UI", 9F);
            lblTel.Location = new Point(15, 378);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(144, 32);
            lblTel.TabIndex = 105;
            lblTel.Text = "Tel Number";
            lblTel.UseCompatibleTextRendering = true;
            // 
            // lblDOA
            // 
            lblDOA.Font = new Font("Segoe UI", 9F);
            lblDOA.Location = new Point(17, 299);
            lblDOA.Name = "lblDOA";
            lblDOA.Size = new Size(181, 32);
            lblDOA.TabIndex = 104;
            lblDOA.Text = "Date of Admission";
            lblDOA.UseCompatibleTextRendering = true;
            // 
            // lblNIC
            // 
            lblNIC.Font = new Font("Segoe UI", 9F);
            lblNIC.Location = new Point(15, 337);
            lblNIC.Name = "lblNIC";
            lblNIC.Size = new Size(144, 32);
            lblNIC.TabIndex = 103;
            lblNIC.Text = "NIC number";
            lblNIC.UseCompatibleTextRendering = true;
            // 
            // lblDOB
            // 
            lblDOB.Font = new Font("Segoe UI", 9F);
            lblDOB.Location = new Point(15, 246);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(144, 32);
            lblDOB.TabIndex = 102;
            lblDOB.Text = "Date of Birth";
            lblDOB.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(15, 534);
            label4.Name = "label4";
            label4.Size = new Size(144, 32);
            label4.TabIndex = 101;
            label4.Text = "Family ";
            label4.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(15, 498);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 100;
            label2.Text = "House ";
            label2.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(16, 462);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 99;
            label1.Text = "Medium";
            label1.UseCompatibleTextRendering = true;
            // 
            // lblGrd
            // 
            lblGrd.Font = new Font("Segoe UI", 9F);
            lblGrd.Location = new Point(15, 182);
            lblGrd.Name = "lblGrd";
            lblGrd.Size = new Size(144, 32);
            lblGrd.TabIndex = 98;
            lblGrd.Text = "Grade";
            lblGrd.UseCompatibleTextRendering = true;
            // 
            // lblGen
            // 
            lblGen.Font = new Font("Segoe UI", 9F);
            lblGen.Location = new Point(15, 147);
            lblGen.Name = "lblGen";
            lblGen.Size = new Size(110, 32);
            lblGen.TabIndex = 97;
            lblGen.Text = "Gender";
            lblGen.UseCompatibleTextRendering = true;
            // 
            // lblL
            // 
            lblL.Font = new Font("Segoe UI", 9F);
            lblL.Location = new Point(15, 110);
            lblL.Name = "lblL";
            lblL.Size = new Size(142, 27);
            lblL.TabIndex = 107;
            lblL.Text = "Last Name ";
            lblL.UseCompatibleTextRendering = true;
            // 
            // lbl_StudentID
            // 
            lbl_StudentID.Font = new Font("Segoe UI", 9F);
            lbl_StudentID.Location = new Point(15, 14);
            lbl_StudentID.Name = "lbl_StudentID";
            lbl_StudentID.Size = new Size(110, 32);
            lbl_StudentID.TabIndex = 96;
            lbl_StudentID.Text = "Student ID";
            lbl_StudentID.UseCompatibleTextRendering = true;
            // 
            // lblF
            // 
            lblF.Font = new Font("Segoe UI", 9F);
            lblF.Location = new Point(15, 55);
            lblF.Name = "lblF";
            lblF.Size = new Size(110, 32);
            lblF.TabIndex = 95;
            lblF.Text = "First Name ";
            lblF.UseCompatibleTextRendering = true;
            // 
            // btn_Insert
            // 
            btn_Insert.Location = new Point(367, 615);
            btn_Insert.Name = "btn_Insert";
            btn_Insert.Size = new Size(94, 29);
            btn_Insert.TabIndex = 123;
            btn_Insert.Text = "Insert";
            btn_Insert.UseVisualStyleBackColor = true;
            btn_Insert.Click += btn_Insert_Click;
            // 
            // radioButtonF
            // 
            radioButtonF.AutoSize = true;
            radioButtonF.Location = new Point(361, 149);
            radioButtonF.Name = "radioButtonF";
            radioButtonF.Size = new Size(78, 24);
            radioButtonF.TabIndex = 118;
            radioButtonF.TabStop = true;
            radioButtonF.Text = "Female";
            radioButtonF.UseVisualStyleBackColor = true;
            // 
            // InsertStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 656);
            Controls.Add(btn_Insert);
            Controls.Add(txt_Addn);
            Controls.Add(lblAddmNO);
            Controls.Add(dtpAddm);
            Controls.Add(DTPbod);
            Controls.Add(radioButtonF);
            Controls.Add(radioButtonM);
            Controls.Add(cmb_Family);
            Controls.Add(cmb_House);
            Controls.Add(cmb_Medium);
            Controls.Add(cmbLG);
            Controls.Add(txtADD);
            Controls.Add(txtTel);
            Controls.Add(txtNIC);
            Controls.Add(txtL);
            Controls.Add(txt_Sid);
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
            Controls.Add(lbl_StudentID);
            Controls.Add(lblF);
            Name = "InsertStudent";
            Text = "InsertStudent";
            Load += InsertStudent_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Addn;
        private Label lblAddmNO;
        private DateTimePicker dtpAddm;
        private DateTimePicker DTPbod;
        private RadioButton radioButtonM;
        private ComboBox cmb_Family;
        private ComboBox cmb_House;
        private ComboBox cmb_Medium;
        private ComboBox cmbLG;
        private TextBox txtADD;
        private TextBox txtTel;
        private TextBox txtNIC;
        private TextBox txtL;
        private TextBox txt_Sid;
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
        private Label lbl_StudentID;
        private Label lblF;
        private Button btn_Insert;
        private RadioButton radioButtonF;
    }
}