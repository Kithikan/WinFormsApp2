namespace WinFormsApp2
{
    partial class ShowStudent1
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
            radioButtonF = new RadioButton();
            radioButtonM = new RadioButton();
            cmb_Family = new ComboBox();
            cmb_House = new ComboBox();
            cmb_Medium = new ComboBox();
            cmbLG = new ComboBox();
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
            lbl_StudentID = new Label();
            txt_Sid = new TextBox();
            btn_Insert = new Button();
            SuspendLayout();
            // 
            // txt_Addn
            // 
            txt_Addn.Location = new Point(201, 580);
            txt_Addn.Name = "txt_Addn";
            txt_Addn.Size = new Size(257, 27);
            txt_Addn.TabIndex = 94;
            // 
            // lblAddmNO
            // 
            lblAddmNO.AutoSize = true;
            lblAddmNO.Location = new Point(13, 583);
            lblAddmNO.Name = "lblAddmNO";
            lblAddmNO.Size = new Size(145, 20);
            lblAddmNO.TabIndex = 93;
            lblAddmNO.Text = "Addmission Number";
            // 
            // dtpAddm
            // 
            dtpAddm.Location = new Point(201, 305);
            dtpAddm.Name = "dtpAddm";
            dtpAddm.Size = new Size(250, 27);
            dtpAddm.TabIndex = 92;
            // 
            // DTPbod
            // 
            DTPbod.Location = new Point(201, 257);
            DTPbod.Name = "DTPbod";
            DTPbod.Size = new Size(250, 27);
            DTPbod.TabIndex = 91;
            // 
            // radioButtonF
            // 
            radioButtonF.AutoSize = true;
            radioButtonF.Location = new Point(349, 153);
            radioButtonF.Name = "radioButtonF";
            radioButtonF.Size = new Size(78, 24);
            radioButtonF.TabIndex = 90;
            radioButtonF.TabStop = true;
            radioButtonF.Text = "Female";
            radioButtonF.UseVisualStyleBackColor = true;
            // 
            // radioButtonM
            // 
            radioButtonM.AutoSize = true;
            radioButtonM.Location = new Point(201, 155);
            radioButtonM.Name = "radioButtonM";
            radioButtonM.Size = new Size(63, 24);
            radioButtonM.TabIndex = 89;
            radioButtonM.TabStop = true;
            radioButtonM.Text = "Male";
            radioButtonM.UseVisualStyleBackColor = true;
            // 
            // cmb_Family
            // 
            cmb_Family.FormattingEnabled = true;
            cmb_Family.Location = new Point(201, 540);
            cmb_Family.Name = "cmb_Family";
            cmb_Family.Size = new Size(255, 28);
            cmb_Family.TabIndex = 87;
            // 
            // cmb_House
            // 
            cmb_House.FormattingEnabled = true;
            cmb_House.Location = new Point(201, 504);
            cmb_House.Name = "cmb_House";
            cmb_House.Size = new Size(255, 28);
            cmb_House.TabIndex = 86;
            // 
            // cmb_Medium
            // 
            cmb_Medium.FormattingEnabled = true;
            cmb_Medium.Items.AddRange(new object[] { "Tamil ", "English" });
            cmb_Medium.Location = new Point(203, 468);
            cmb_Medium.Name = "cmb_Medium";
            cmb_Medium.Size = new Size(255, 28);
            cmb_Medium.TabIndex = 85;
            // 
            // cmbLG
            // 
            cmbLG.FormattingEnabled = true;
            cmbLG.Location = new Point(199, 185);
            cmbLG.Name = "cmbLG";
            cmbLG.Size = new Size(257, 28);
            cmbLG.TabIndex = 84;
            // 
            // txtADD
            // 
            txtADD.Location = new Point(201, 429);
            txtADD.Name = "txtADD";
            txtADD.Size = new Size(255, 27);
            txtADD.TabIndex = 82;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(199, 389);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(257, 27);
            txtTel.TabIndex = 83;
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(201, 348);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(255, 27);
            txtNIC.TabIndex = 81;
            // 
            // txtL
            // 
            txtL.Location = new Point(199, 122);
            txtL.Name = "txtL";
            txtL.Size = new Size(259, 27);
            txtL.TabIndex = 80;
            // 
            // txtF
            // 
            txtF.Location = new Point(201, 66);
            txtF.Name = "txtF";
            txtF.Size = new Size(255, 27);
            txtF.TabIndex = 79;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(13, 429);
            label3.Name = "label3";
            label3.Size = new Size(144, 32);
            label3.TabIndex = 77;
            label3.Text = "Address";
            label3.UseCompatibleTextRendering = true;
            // 
            // lblTel
            // 
            lblTel.Font = new Font("Segoe UI", 9F);
            lblTel.Location = new Point(12, 384);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(144, 32);
            lblTel.TabIndex = 76;
            lblTel.Text = "Tel Number";
            lblTel.UseCompatibleTextRendering = true;
            // 
            // lblDOA
            // 
            lblDOA.Font = new Font("Segoe UI", 9F);
            lblDOA.Location = new Point(14, 305);
            lblDOA.Name = "lblDOA";
            lblDOA.Size = new Size(181, 32);
            lblDOA.TabIndex = 75;
            lblDOA.Text = "Date of Admission";
            lblDOA.UseCompatibleTextRendering = true;
            // 
            // lblNIC
            // 
            lblNIC.Font = new Font("Segoe UI", 9F);
            lblNIC.Location = new Point(12, 343);
            lblNIC.Name = "lblNIC";
            lblNIC.Size = new Size(144, 32);
            lblNIC.TabIndex = 74;
            lblNIC.Text = "NIC number";
            lblNIC.UseCompatibleTextRendering = true;
            // 
            // lblDOB
            // 
            lblDOB.Font = new Font("Segoe UI", 9F);
            lblDOB.Location = new Point(12, 252);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(144, 32);
            lblDOB.TabIndex = 73;
            lblDOB.Text = "Date of Birth";
            lblDOB.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(12, 540);
            label4.Name = "label4";
            label4.Size = new Size(144, 32);
            label4.TabIndex = 72;
            label4.Text = "Family id";
            label4.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(12, 504);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 71;
            label2.Text = "House id";
            label2.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(13, 468);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 70;
            label1.Text = "Medium";
            label1.UseCompatibleTextRendering = true;
            // 
            // lblGrd
            // 
            lblGrd.Font = new Font("Segoe UI", 9F);
            lblGrd.Location = new Point(12, 188);
            lblGrd.Name = "lblGrd";
            lblGrd.Size = new Size(144, 32);
            lblGrd.TabIndex = 69;
            lblGrd.Text = "Grade";
            lblGrd.UseCompatibleTextRendering = true;
            // 
            // lblGen
            // 
            lblGen.Font = new Font("Segoe UI", 9F);
            lblGen.Location = new Point(12, 153);
            lblGen.Name = "lblGen";
            lblGen.Size = new Size(110, 32);
            lblGen.TabIndex = 68;
            lblGen.Text = "Gender";
            lblGen.UseCompatibleTextRendering = true;
            // 
            // lblL
            // 
            lblL.Font = new Font("Segoe UI", 9F);
            lblL.Location = new Point(12, 116);
            lblL.Name = "lblL";
            lblL.Size = new Size(142, 27);
            lblL.TabIndex = 78;
            lblL.Text = "Last Name ";
            lblL.UseCompatibleTextRendering = true;
            // 
            // lblF
            // 
            lblF.Font = new Font("Segoe UI", 9F);
            lblF.Location = new Point(12, 61);
            lblF.Name = "lblF";
            lblF.Size = new Size(110, 32);
            lblF.TabIndex = 67;
            lblF.Text = "First Name ";
            lblF.UseCompatibleTextRendering = true;
            // 
            // lbl_StudentID
            // 
            lbl_StudentID.Font = new Font("Segoe UI", 9F);
            lbl_StudentID.Location = new Point(12, 20);
            lbl_StudentID.Name = "lbl_StudentID";
            lbl_StudentID.Size = new Size(110, 32);
            lbl_StudentID.TabIndex = 67;
            lbl_StudentID.Text = "Student ID";
            lbl_StudentID.UseCompatibleTextRendering = true;
            // 
            // txt_Sid
            // 
            txt_Sid.Location = new Point(201, 17);
            txt_Sid.Name = "txt_Sid";
            txt_Sid.Size = new Size(255, 27);
            txt_Sid.TabIndex = 79;
            txt_Sid.TextChanged += txt_Sid_TextChanged;
            // 
            // btn_Insert
            // 
            btn_Insert.Location = new Point(124, 629);
            btn_Insert.Name = "btn_Insert";
            btn_Insert.Size = new Size(145, 29);
            btn_Insert.TabIndex = 95;
            btn_Insert.Text = "Insert";
            btn_Insert.UseVisualStyleBackColor = true;
            btn_Insert.Click += btn_Insert_Click;
            // 
            // ShowStudent1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 675);
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
            Name = "ShowStudent1";
            Text = "ShowStudent1";
            Load += ShowStudent1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_Addn;
        private Label lblAddmNO;
        private DateTimePicker dtpAddm;
        private DateTimePicker DTPbod;
        private RadioButton radioButtonF;
        private RadioButton radioButtonM;
        private ComboBox cmb_Family;
        private ComboBox cmb_House;
        private ComboBox cmb_Medium;
        private ComboBox cmbLG;
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
        private Label lbl_StudentID;
        private TextBox txt_Sid;
        private Button btn_Insert;
    }
}