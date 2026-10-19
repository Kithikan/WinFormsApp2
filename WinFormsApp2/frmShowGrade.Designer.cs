namespace WinFormsApp2
{
    partial class frmShowGrade
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
            lblGrID = new Label();
            lblGrName = new Label();
            lblGrGroup = new Label();
            lblGrOrder = new Label();
            lblGrColor = new Label();
            txtGrID = new TextBox();
            txtGrName = new TextBox();
            txtGrGroup = new TextBox();
            txtGrOrder = new TextBox();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // lblGrID
            // 
            lblGrID.AutoSize = true;
            lblGrID.Location = new Point(10, 24);
            lblGrID.Name = "lblGrID";
            lblGrID.Size = new Size(68, 20);
            lblGrID.TabIndex = 0;
            lblGrID.Text = "Grade ID";
            // 
            // lblGrName
            // 
            lblGrName.AutoSize = true;
            lblGrName.Location = new Point(10, 84);
            lblGrName.Name = "lblGrName";
            lblGrName.Size = new Size(93, 20);
            lblGrName.TabIndex = 0;
            lblGrName.Text = "Grade Name";
            // 
            // lblGrGroup
            // 
            lblGrGroup.AutoSize = true;
            lblGrGroup.Location = new Point(10, 146);
            lblGrGroup.Name = "lblGrGroup";
            lblGrGroup.Size = new Size(94, 20);
            lblGrGroup.TabIndex = 0;
            lblGrGroup.Text = "Grade Group";
            // 
            // lblGrOrder
            // 
            lblGrOrder.AutoSize = true;
            lblGrOrder.Location = new Point(10, 207);
            lblGrOrder.Name = "lblGrOrder";
            lblGrOrder.Size = new Size(91, 20);
            lblGrOrder.TabIndex = 0;
            lblGrOrder.Text = "Grade Order";
            // 
            // lblGrColor
            // 
            lblGrColor.AutoSize = true;
            lblGrColor.Location = new Point(10, 260);
            lblGrColor.Name = "lblGrColor";
            lblGrColor.Size = new Size(89, 20);
            lblGrColor.TabIndex = 0;
            lblGrColor.Text = "Grade Color";
            // 
            // txtGrID
            // 
            txtGrID.Location = new Point(111, 21);
            txtGrID.Name = "txtGrID";
            txtGrID.Size = new Size(285, 27);
            txtGrID.TabIndex = 1;
            txtGrID.TextChanged += textBox1_TextChanged;
            // 
            // txtGrName
            // 
            txtGrName.Location = new Point(111, 81);
            txtGrName.Name = "txtGrName";
            txtGrName.Size = new Size(285, 27);
            txtGrName.TabIndex = 1;
            txtGrName.TextChanged += textBox1_TextChanged;
            // 
            // txtGrGroup
            // 
            txtGrGroup.Location = new Point(111, 143);
            txtGrGroup.Name = "txtGrGroup";
            txtGrGroup.Size = new Size(285, 27);
            txtGrGroup.TabIndex = 1;
            txtGrGroup.TextChanged += textBox1_TextChanged;
            // 
            // txtGrOrder
            // 
            txtGrOrder.Location = new Point(111, 207);
            txtGrOrder.Name = "txtGrOrder";
            txtGrOrder.Size = new Size(285, 27);
            txtGrOrder.TabIndex = 1;
            txtGrOrder.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.Location = new Point(105, 260);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 30);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // frmShowGrade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 307);
            Controls.Add(panel1);
            Controls.Add(txtGrOrder);
            Controls.Add(txtGrGroup);
            Controls.Add(txtGrName);
            Controls.Add(txtGrID);
            Controls.Add(lblGrColor);
            Controls.Add(lblGrOrder);
            Controls.Add(lblGrGroup);
            Controls.Add(lblGrName);
            Controls.Add(lblGrID);
            Name = "frmShowGrade";
            Text = "frmShowGrade";
            Load += frmShowGrade_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGrID;
        private Label lblGrName;
        private Label lblGrGroup;
        private Label lblGrOrder;
        private Label lblGrColor;
        private TextBox txtGrID;
        private TextBox txtGrName;
        private TextBox txtGrGroup;
        private TextBox txtGrOrder;
        private Panel panel1;
    }
}