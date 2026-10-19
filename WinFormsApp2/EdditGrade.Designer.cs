namespace WinFormsApp2
{
    partial class EdditGrade
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
            txt_Ord = new TextBox();
            txt_Grg = new TextBox();
            txt_Grn = new TextBox();
            txt_Gid = new TextBox();
            lbl_Gco = new Label();
            lbl_Gro = new Label();
            lbl_Grg = new Label();
            lbl_Grn = new Label();
            lbl_Gid = new Label();
            btnUpdate = new Button();
            pnlGrdclr = new Panel();
            btnPickColor = new Button();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // txt_Ord
            // 
            txt_Ord.Location = new Point(167, 177);
            txt_Ord.Name = "txt_Ord";
            txt_Ord.Size = new Size(273, 27);
            txt_Ord.TabIndex = 10;
            // 
            // txt_Grg
            // 
            txt_Grg.Location = new Point(167, 126);
            txt_Grg.Name = "txt_Grg";
            txt_Grg.Size = new Size(273, 27);
            txt_Grg.TabIndex = 11;
            txt_Grg.TextChanged += txt_Grg_TextChanged;
            // 
            // txt_Grn
            // 
            txt_Grn.Location = new Point(167, 75);
            txt_Grn.Name = "txt_Grn";
            txt_Grn.Size = new Size(273, 27);
            txt_Grn.TabIndex = 12;
            txt_Grn.TextChanged += txt_Grn_TextChanged;
            // 
            // txt_Gid
            // 
            txt_Gid.Location = new Point(167, 28);
            txt_Gid.Name = "txt_Gid";
            txt_Gid.ReadOnly = true;
            txt_Gid.Size = new Size(273, 27);
            txt_Gid.TabIndex = 13;
            // 
            // lbl_Gco
            // 
            lbl_Gco.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lbl_Gco.Location = new Point(2, 231);
            lbl_Gco.Name = "lbl_Gco";
            lbl_Gco.Size = new Size(144, 40);
            lbl_Gco.TabIndex = 4;
            lbl_Gco.Text = "Grade Color";
            // 
            // lbl_Gro
            // 
            lbl_Gro.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lbl_Gro.Location = new Point(2, 176);
            lbl_Gro.Name = "lbl_Gro";
            lbl_Gro.Size = new Size(144, 40);
            lbl_Gro.TabIndex = 5;
            lbl_Gro.Text = "Grade Order";
            // 
            // lbl_Grg
            // 
            lbl_Grg.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lbl_Grg.Location = new Point(2, 125);
            lbl_Grg.Name = "lbl_Grg";
            lbl_Grg.Size = new Size(144, 40);
            lbl_Grg.TabIndex = 6;
            lbl_Grg.Text = "Grade Group";
            // 
            // lbl_Grn
            // 
            lbl_Grn.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lbl_Grn.Location = new Point(2, 78);
            lbl_Grn.Name = "lbl_Grn";
            lbl_Grn.Size = new Size(144, 40);
            lbl_Grn.TabIndex = 7;
            lbl_Grn.Text = "Grade Name";
            // 
            // lbl_Gid
            // 
            lbl_Gid.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Gid.Location = new Point(21, 28);
            lbl_Gid.Name = "lbl_Gid";
            lbl_Gid.Size = new Size(90, 40);
            lbl_Gid.TabIndex = 8;
            lbl_Gid.Text = "Grade ID";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(167, 291);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // pnlGrdclr
            // 
            pnlGrdclr.Location = new Point(167, 231);
            pnlGrdclr.Name = "pnlGrdclr";
            pnlGrdclr.Size = new Size(145, 31);
            pnlGrdclr.TabIndex = 15;
            pnlGrdclr.Paint += pnlGrdclr_Paint;
            // 
            // btnPickColor
            // 
            btnPickColor.Location = new Point(332, 231);
            btnPickColor.Name = "btnPickColor";
            btnPickColor.Size = new Size(121, 31);
            btnPickColor.TabIndex = 16;
            btnPickColor.Text = "Pick Color";
            btnPickColor.UseVisualStyleBackColor = true;
            btnPickColor.Click += btnPickColor_Click;
            // 
            // EdditGrade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 361);
            Controls.Add(btnPickColor);
            Controls.Add(pnlGrdclr);
            Controls.Add(btnUpdate);
            Controls.Add(txt_Ord);
            Controls.Add(txt_Grg);
            Controls.Add(txt_Grn);
            Controls.Add(txt_Gid);
            Controls.Add(lbl_Gco);
            Controls.Add(lbl_Gro);
            Controls.Add(lbl_Grg);
            Controls.Add(lbl_Grn);
            Controls.Add(lbl_Gid);
            Name = "EdditGrade";
            Text = "EdditGrade";
            Load += EdditGrade_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_Ord;
        private TextBox txt_Grg;
        private TextBox txt_Grn;
        private TextBox txt_Gid;
        private Label lbl_Gco;
        private Label lbl_Gro;
        private Label lbl_Grg;
        private Label lbl_Grn;
        private Label lbl_Gid;
        private Button btnUpdate;
        private Panel pnlGrdclr;
        private Button btnPickColor;
        private ColorDialog colorDialog1;
    }
}