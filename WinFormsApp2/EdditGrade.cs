using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp2.BLL;

namespace WinFormsApp2
{
    public partial class EdditGrade : Form
    {
        string id;

        public EdditGrade(string id, string grade_name, string grade_group, string grade_order, string grade_colour)
        {
            InitializeComponent();
            this.id = id;
           
        }

        private void EdditGrade_Load(object sender, EventArgs e)
        {
            try
            {
                var gradeService = new WinFormsApp2.BLL.GradeService();
                DataTable dt = gradeService.GetById(id);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Grade not found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataRow row = dt.Rows[0];

                txt_Grn.Text = row["grade_name"].ToString();
                txt_Grg.Text = row["grade_group"].ToString();
                txt_Ord.Text = row["grade_order"].ToString();
                string colour = row["colour"].ToString();

                // restore previously selected colour if provided
                if (!string.IsNullOrWhiteSpace(colour))
                {
                    try
                    {
                        pnlGrdclr.BackColor = ColorTranslator.FromHtml(colour);
                    }
                    catch
                    {
                        // ignore invalid colour string
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadNextGradeId()
        {
            string connString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT IFNULL(MAX(id), 0) + 1 FROM grades", conn);
                    object result = cmd.ExecuteScalar();
                    txt_Gid.Text = result.ToString();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error generating grade ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_Grg_TextChanged(object sender, EventArgs e)
        {
            // Keep in sync or validate grade group text if needed.
            // Currently no action required; method added to satisfy designer event hookup.
        }

        private void pnlGrdclr_Paint(object sender, PaintEventArgs e)
        {
            Color c = pnlGrdclr.BackColor;

            using (SolidBrush b = new SolidBrush(c))
            {
                e.Graphics.FillRectangle(b, pnlGrdclr.ClientRectangle);
            }
        }



       private void btnUpdate_Click(object sender, EventArgs e)
{
    try
    {
        GradeService gradeService = new GradeService();

        bool updated = gradeService.Update(
            id,
            txt_Grn.Text,
            txt_Grg.Text,
            txt_Ord.Text,
            ColorTranslator.ToHtml(pnlGrdclr.BackColor)
        );

        if (updated)
        {
            MessageBox.Show("Grade updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        else
        {
            MessageBox.Show("No grade was updated.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    catch (MySqlException ex)
    {
        MessageBox.Show("Error while updating grade: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}


        private void btnPickColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnlGrdclr.BackColor = colorDialog1.Color;
                // store selected colour as HTML hex string
                string colour = ColorTranslator.ToHtml(colorDialog1.Color);
            }
        }

        private void txt_Grn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

