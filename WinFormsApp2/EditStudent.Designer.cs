namespace WinFormsApp2
{
    partial class EditStudent
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
            btnUpdate = new Button();
            rdoF = new RadioButton();
            txt_Addn = new TextBox();
            lblAddmNO = new Label();
            dtpAddmission = new DateTimePicker();
            dtpBirthOFDate = new DateTimePicker();
            rdoM = new RadioButton();
            cmb_Family = new ComboBox();
            cmb_House = new ComboBox();
            cmb_Medium = new ComboBox();
            cmbLG = new ComboBox();
            txtADD = new TextBox();
            txtTel = new TextBox();
            txtNIC = new TextBox();
            txtL = new TextBox();
            txtFna = new TextBox();
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
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(148, 597);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 152;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // rdoF
            // 
            rdoF.AutoSize = true;
            rdoF.Location = new Point(345, 126);
            rdoF.Name = "rdoF";
            rdoF.Size = new Size(78, 24);
            rdoF.TabIndex = 151;
            rdoF.TabStop = true;
            rdoF.Text = "Female";
            rdoF.UseVisualStyleBackColor = true;
            // 
            // txt_Addn
            // 
            txt_Addn.Location = new Point(195, 551);
            txt_Addn.Name = "txt_Addn";
            txt_Addn.Size = new Size(257, 27);
            txt_Addn.TabIndex = 150;
            // 
            // lblAddmNO
            // 
            lblAddmNO.AutoSize = true;
            lblAddmNO.Location = new Point(7, 554);
            lblAddmNO.Name = "lblAddmNO";
            lblAddmNO.Size = new Size(145, 20);
            lblAddmNO.TabIndex = 149;
            lblAddmNO.Text = "Addmission Number";
            // 
            // dtpAddmission
            // 
            dtpAddmission.Location = new Point(195, 276);
            dtpAddmission.Name = "dtpAddmission";
            dtpAddmission.Size = new Size(250, 27);
            dtpAddmission.TabIndex = 148;
            // 
            // dtpBirthOFDate
            // 
            dtpBirthOFDate.Cursor = Cursors.Cross;
            dtpBirthOFDate.Location = new Point(195, 228);
            dtpBirthOFDate.Name = "dtpBirthOFDate";
            dtpBirthOFDate.Size = new Size(250, 27);
            dtpBirthOFDate.TabIndex = 147;
            // 
            // rdoM
            // 
            rdoM.AutoSize = true;
            rdoM.Location = new Point(195, 126);
            rdoM.Name = "rdoM";
            rdoM.Size = new Size(63, 24);
            rdoM.TabIndex = 146;
            rdoM.TabStop = true;
            rdoM.Text = "Male";
            rdoM.UseVisualStyleBackColor = true;
            // 
            // cmb_Family
            // 
            cmb_Family.FormattingEnabled = true;
            cmb_Family.Location = new Point(195, 511);
            cmb_Family.Name = "cmb_Family";
            cmb_Family.Size = new Size(255, 28);
            cmb_Family.TabIndex = 145;
            // 
            // cmb_House
            // 
            cmb_House.FormattingEnabled = true;
            cmb_House.Location = new Point(195, 475);
            cmb_House.Name = "cmb_House";
            cmb_House.Size = new Size(255, 28);
            cmb_House.TabIndex = 144;
            // 
            // cmb_Medium
            // 
            cmb_Medium.FormattingEnabled = true;
            cmb_Medium.Items.AddRange(new object[] { "Tamil ", "English" });
            cmb_Medium.Location = new Point(197, 439);
            cmb_Medium.Name = "cmb_Medium";
            cmb_Medium.Size = new Size(255, 28);
            cmb_Medium.TabIndex = 143;
            // 
            // cmbLG
            // 
            cmbLG.FormattingEnabled = true;
            cmbLG.Location = new Point(193, 156);
            cmbLG.Name = "cmbLG";
            cmbLG.Size = new Size(257, 28);
            cmbLG.TabIndex = 142;
            // 
            // txtADD
            // 
            txtADD.Location = new Point(195, 400);
            txtADD.Name = "txtADD";
            txtADD.Size = new Size(255, 27);
            txtADD.TabIndex = 140;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(193, 360);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(257, 27);
            txtTel.TabIndex = 141;
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(195, 319);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(255, 27);
            txtNIC.TabIndex = 139;
            // 
            // txtL
            // 
            txtL.Location = new Point(193, 93);
            txtL.Name = "txtL";
            txtL.Size = new Size(259, 27);
            txtL.TabIndex = 138;
            // 
            // txtFna
            // 
            txtFna.Location = new Point(196, 37);
            txtFna.Name = "txtFna";
            txtFna.Size = new Size(255, 27);
            txtFna.TabIndex = 137;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(7, 400);
            label3.Name = "label3";
            label3.Size = new Size(144, 32);
            label3.TabIndex = 135;
            label3.Text = "Address";
            label3.UseCompatibleTextRendering = true;
            // 
            // lblTel
            // 
            lblTel.Font = new Font("Segoe UI", 9F);
            lblTel.Location = new Point(6, 355);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(144, 32);
            lblTel.TabIndex = 134;
            lblTel.Text = "Tel Number";
            lblTel.UseCompatibleTextRendering = true;
            // 
            // lblDOA
            // 
            lblDOA.Font = new Font("Segoe UI", 9F);
            lblDOA.Location = new Point(8, 276);
            lblDOA.Name = "lblDOA";
            lblDOA.Size = new Size(181, 32);
            lblDOA.TabIndex = 133;
            lblDOA.Text = "Date of Admission";
            lblDOA.UseCompatibleTextRendering = true;
            // 
            // lblNIC
            // 
            lblNIC.Font = new Font("Segoe UI", 9F);
            lblNIC.Location = new Point(6, 314);
            lblNIC.Name = "lblNIC";
            lblNIC.Size = new Size(144, 32);
            lblNIC.TabIndex = 132;
            lblNIC.Text = "NIC number";
            lblNIC.UseCompatibleTextRendering = true;
            // 
            // lblDOB
            // 
            lblDOB.Font = new Font("Segoe UI", 9F);
            lblDOB.Location = new Point(6, 223);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(144, 32);
            lblDOB.TabIndex = 131;
            lblDOB.Text = "Date of Birth";
            lblDOB.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(6, 511);
            label4.Name = "label4";
            label4.Size = new Size(144, 32);
            label4.TabIndex = 130;
            label4.Text = "Family id";
            label4.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(6, 475);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 129;
            label2.Text = "House id";
            label2.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(7, 439);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 128;
            label1.Text = "Medium";
            label1.UseCompatibleTextRendering = true;
            // 
            // lblGrd
            // 
            lblGrd.Font = new Font("Segoe UI", 9F);
            lblGrd.Location = new Point(6, 159);
            lblGrd.Name = "lblGrd";
            lblGrd.Size = new Size(144, 32);
            lblGrd.TabIndex = 127;
            lblGrd.Text = "Grade";
            lblGrd.UseCompatibleTextRendering = true;
            lblGrd.Click += lblGrd_Click;
            // 
            // lblGen
            // 
            lblGen.Font = new Font("Segoe UI", 9F);
            lblGen.Location = new Point(6, 124);
            lblGen.Name = "lblGen";
            lblGen.Size = new Size(110, 32);
            lblGen.TabIndex = 126;
            lblGen.Text = "Gender";
            lblGen.UseCompatibleTextRendering = true;
            // 
            // lblL
            // 
            lblL.Font = new Font("Segoe UI", 9F);
            lblL.Location = new Point(6, 87);
            lblL.Name = "lblL";
            lblL.Size = new Size(142, 27);
            lblL.TabIndex = 136;
            lblL.Text = "Last Name ";
            lblL.UseCompatibleTextRendering = true;
            // 
            // lblF
            // 
            lblF.Font = new Font("Segoe UI", 9F);
            lblF.Location = new Point(7, 32);
            lblF.Name = "lblF";
            lblF.Size = new Size(110, 32);
            lblF.TabIndex = 125;
            lblF.Text = "First Name ";
            lblF.UseCompatibleTextRendering = true;
            // 
            // EditStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 656);
            Controls.Add(btnUpdate);
            Controls.Add(rdoF);
            Controls.Add(txt_Addn);
            Controls.Add(lblAddmNO);
            Controls.Add(dtpAddmission);
            Controls.Add(dtpBirthOFDate);
            Controls.Add(rdoM);
            Controls.Add(cmb_Family);
            Controls.Add(cmb_House);
            Controls.Add(cmb_Medium);
            Controls.Add(cmbLG);
            Controls.Add(txtADD);
            Controls.Add(txtTel);
            Controls.Add(txtNIC);
            Controls.Add(txtL);
            Controls.Add(txtFna);
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
            Name = "EditStudent";
            Text = "EditStudent";
            Load += EditStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private RadioButton rdoF;
        private TextBox txt_Addn;
        private Label lblAddmNO;
        private DateTimePicker dtpAddmission;
        private DateTimePicker dtpBirthOFDate;
        private RadioButton rdoM;
        private ComboBox cmb_Family;
        private ComboBox cmb_House;
        private ComboBox cmb_Medium;
        private ComboBox cmbLG;
        private TextBox txtADD;
        private TextBox txtTel;
        private TextBox txtNIC;
        private TextBox txtL;
        private TextBox txtFna;
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
    }
}