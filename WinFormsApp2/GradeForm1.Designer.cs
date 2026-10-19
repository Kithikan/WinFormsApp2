namespace WinFormsApp2
{
    partial class GradeForm1
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
            lbl_Gid = new Label();
            dgvGrade = new DataGridView();
            txt_Gid = new TextBox();
            lbl_Grn = new Label();
            txt_Grn = new TextBox();
            lbl_Grg = new Label();
            lbl_Gro = new Label();
            btn_Insert = new Button();
            btn_Delete = new Button();
            btn_Edit = new Button();
            btn_Show = new Button();
            btn_Allgrade = new Button();
            txt_Grg = new TextBox();
            txt_Gro = new TextBox();
            btn_Clear = new Button();
            colorDialog1 = new ColorDialog();
            lbl_Gco = new Label();
            panel1 = new Panel();
            btn_PickColor = new Button();
            btnDBshow = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGrade).BeginInit();
            SuspendLayout();
            // 
            // lbl_Gid
            // 
            lbl_Gid.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Gid.Location = new Point(457, 118);
            lbl_Gid.Name = "lbl_Gid";
            lbl_Gid.Size = new Size(90, 40);
            lbl_Gid.TabIndex = 1;
            lbl_Gid.Text = "Grade ID";
            lbl_Gid.Click += lbl_Gid_Click;
            // 
            // dgvGrade
            // 
            dgvGrade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrade.Location = new Point(12, 92);
            dgvGrade.Name = "dgvGrade";
            dgvGrade.RowHeadersWidth = 51;
            dgvGrade.Size = new Size(418, 331);
            dgvGrade.TabIndex = 2;
            // 
            // txt_Gid
            // 
            txt_Gid.Location = new Point(607, 118);
            txt_Gid.Name = "txt_Gid";
            txt_Gid.ReadOnly = true;
            txt_Gid.Size = new Size(273, 27);
            txt_Gid.TabIndex = 3;
            // 
            // lbl_Grn
            // 
            lbl_Grn.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lbl_Grn.Location = new Point(457, 165);
            lbl_Grn.Name = "lbl_Grn";
            lbl_Grn.Size = new Size(144, 40);
            lbl_Grn.TabIndex = 1;
            lbl_Grn.Text = "Grade Name";
            // 
            // txt_Grn
            // 
            txt_Grn.Location = new Point(607, 168);
            txt_Grn.Name = "txt_Grn";
            txt_Grn.Size = new Size(273, 27);
            txt_Grn.TabIndex = 3;
            // 
            // lbl_Grg
            // 
            lbl_Grg.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lbl_Grg.Location = new Point(457, 212);
            lbl_Grg.Name = "lbl_Grg";
            lbl_Grg.Size = new Size(144, 40);
            lbl_Grg.TabIndex = 1;
            lbl_Grg.Text = "Grade Group";
            // 
            // lbl_Gro
            // 
            lbl_Gro.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lbl_Gro.Location = new Point(457, 254);
            lbl_Gro.Name = "lbl_Gro";
            lbl_Gro.Size = new Size(144, 40);
            lbl_Gro.TabIndex = 1;
            lbl_Gro.Text = "Grade Order";
            // 
            // btn_Insert
            // 
            btn_Insert.Location = new Point(457, 377);
            btn_Insert.Name = "btn_Insert";
            btn_Insert.Size = new Size(176, 46);
            btn_Insert.TabIndex = 4;
            btn_Insert.Text = "Insert";
            btn_Insert.UseVisualStyleBackColor = true;
            btn_Insert.Click += btn_Insert_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(693, 377);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(176, 46);
            btn_Delete.TabIndex = 4;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.Location = new Point(531, 17);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(149, 46);
            btn_Edit.TabIndex = 4;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_Show
            // 
            btn_Show.Location = new Point(352, 17);
            btn_Show.Name = "btn_Show";
            btn_Show.Size = new Size(149, 46);
            btn_Show.TabIndex = 4;
            btn_Show.Text = "Show";
            btn_Show.UseVisualStyleBackColor = true;
            btn_Show.Click += btn_Show_Click;
            // 
            // btn_Allgrade
            // 
            btn_Allgrade.Location = new Point(8, 12);
            btn_Allgrade.Name = "btn_Allgrade";
            btn_Allgrade.Size = new Size(149, 49);
            btn_Allgrade.TabIndex = 4;
            btn_Allgrade.Text = "All Grade";
            btn_Allgrade.UseVisualStyleBackColor = true;
            btn_Allgrade.Click += btn_Allgrade_Click;
            // 
            // txt_Grg
            // 
            txt_Grg.Location = new Point(607, 216);
            txt_Grg.Name = "txt_Grg";
            txt_Grg.Size = new Size(273, 27);
            txt_Grg.TabIndex = 3;
            // 
            // txt_Gro
            // 
            txt_Gro.Location = new Point(607, 258);
            txt_Gro.Name = "txt_Gro";
            txt_Gro.Size = new Size(273, 27);
            txt_Gro.TabIndex = 3;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(190, 14);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(140, 49);
            btn_Clear.TabIndex = 10;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // lbl_Gco
            // 
            lbl_Gco.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lbl_Gco.Location = new Point(457, 297);
            lbl_Gco.Name = "lbl_Gco";
            lbl_Gco.Size = new Size(144, 40);
            lbl_Gco.TabIndex = 1;
            lbl_Gco.Text = "Grade Color";
            // 
            // panel1
            // 
            panel1.Location = new Point(607, 300);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 31);
            panel1.TabIndex = 11;
            panel1.Click += btn_Show_Click;
            panel1.Paint += panel1_Paint;
            // 
            // btn_PickColor
            // 
            btn_PickColor.Location = new Point(773, 300);
            btn_PickColor.Name = "btn_PickColor";
            btn_PickColor.Size = new Size(107, 32);
            btn_PickColor.TabIndex = 12;
            btn_PickColor.Text = "Pick Color";
            btn_PickColor.UseVisualStyleBackColor = true;
            btn_PickColor.Click += btn_PickColor_Click;
            // 
            // btnDBshow
            // 
            btnDBshow.Location = new Point(693, 17);
            btnDBshow.Name = "btnDBshow";
            btnDBshow.Size = new Size(98, 46);
            btnDBshow.TabIndex = 13;
            btnDBshow.Text = "DB Show";
            btnDBshow.UseVisualStyleBackColor = true;
            btnDBshow.Click += btnDBshow_Click;
            // 
            // GradeForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 438);
            Controls.Add(btnDBshow);
            Controls.Add(btn_PickColor);
            Controls.Add(panel1);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Allgrade);
            Controls.Add(btn_Show);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Insert);
            Controls.Add(txt_Gro);
            Controls.Add(txt_Grg);
            Controls.Add(txt_Grn);
            Controls.Add(txt_Gid);
            Controls.Add(dgvGrade);
            Controls.Add(lbl_Gco);
            Controls.Add(lbl_Gro);
            Controls.Add(lbl_Grg);
            Controls.Add(lbl_Grn);
            Controls.Add(lbl_Gid);
            Name = "GradeForm1";
            Text = "Gd_Form2";
            Load += Gd_Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGrade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_Gid;
        private DataGridView dgvGrade;
        private TextBox txt_Gid;
        private Label lbl_Grn;
        private TextBox txt_Grn;
        private Label lbl_Grg;
        private Label lbl_Gro;
        private Button btn_Insert;
        private Button btn_Delete;
        private Button btn_Edit;
        private Button btn_Show;
        private Button btn_Allgrade;
        private TextBox txt_Grg;
        private TextBox txt_Gro;
        private Button btn_Clear;
        private ColorDialog colorDialog1;
        private Label lbl_Gco;
        private Panel panel1;
        private Button btn_PickColor;
        private Button btnDBshow;
    }
}