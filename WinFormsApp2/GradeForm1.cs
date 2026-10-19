using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using WinFormsApp2.DAL;
using WinFormsApp2.BLL;
using System.Configuration;

namespace WinFormsApp2
{
    public partial class GradeForm1 : Form
    {
        private string selectedColourHex = "#000000"; // holds the picked color's hex value
        //private readonly string connString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
        private string id;

        string connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;


        public GradeForm1()
        {
            InitializeComponent();
            //LoadNextGradeId();
        }

        private void btn_Allgrade_Click(object sender, EventArgs e)
        {

            GradeService gradeService = new GradeService();
            DataTable dt = gradeService.GetAll();
            dgvGrade.DataSource = dt;

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


        private void Gd_Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGrade.CurrentRow == null)
                {
                    MessageBox.Show("Please select a grade first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                txt_Gid.Text = dgvGrade.CurrentRow.Cells["id"].Value.ToString();
                txt_Grn.Text = dgvGrade.CurrentRow.Cells["grade_name"].Value.ToString();
                txt_Grg.Text = dgvGrade.CurrentRow.Cells["grade_group"].Value.ToString();
                txt_Gro.Text = dgvGrade.CurrentRow.Cells["grade_order"].Value.ToString();

                string colorfromgrid = dgvGrade.CurrentRow.Cells["colour"].Value.ToString();

                Color loadedcolor = ColorTranslator.FromHtml(colorfromgrid);
                panel1.BackColor = loadedcolor;
                selectedColourHex = colorfromgrid;

                //string colourFromGrid = dgvGrade.CurrentRow.Cells["colour"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void btn_Insert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Grn.Text))
            {
                MessageBox.Show("Please enter a grade name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                GradeService gradeService = new GradeService();
                bool result = gradeService.Insert(txt_Grn.Text, txt_Grg.Text, txt_Gro.Text, selectedColourHex);

                if (result)
                {
                    MessageBox.Show("Inserted successfully.", "Insert Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Grade was not inserted.", "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while inserting the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txt_Gid.Text = "";
            txt_Grn.Text = "";
            txt_Grg.Text = "";
            txt_Gro.Text = "";
            panel1.BackColor = Color.White;
            selectedColourHex = "";
        }




        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgvGrade.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a grade.");
                return;
            }

            DataGridViewRow row = dgvGrade.SelectedRows[0];

            string id = row.Cells["id"].Value.ToString();
            string grade_name = row.Cells["grade_name"].Value.ToString();
            string grade_group = row.Cells["grade_group"].Value.ToString();
            string grade_order = row.Cells["grade_order"].Value.ToString();
            string grade_colour = row.Cells["colour"].Value.ToString();

            EdditGrade editForm = new EdditGrade(
                id,
                grade_name,
                grade_group,
                grade_order,
                grade_colour
            );

            DialogResult result = editForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadGrades();
            }
        }

        private void LoadGrades()
        {
            string connectionString =
                "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";

            using (MySqlConnection conn =
                   new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM grades";

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    dgvGrade.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(
                        "Error loading grades: " + ex.Message
                    );
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            string connString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                if (dgvGrade.Rows.Count == 0)
                {
                    MessageBox.Show("No records found.", "Delete Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string Gradeid = dgvGrade.CurrentRow.Cells["id"].Value.ToString();
                string gradeName = dgvGrade.CurrentRow.Cells["grade_name"].Value.ToString();

                DialogResult confirm = MessageBox.Show($"Are you sure you want to delete grade '{gradeName}' (ID: {Gradeid})?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes)
                {
                    return; // user clicked No, cancel the delete
                }


                GradeService gradeService = new GradeService();
                bool deleted = gradeService.Delete(Gradeid);

                if (deleted)
                {
                    MessageBox.Show("Deleted successfully.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Grade was not deleted.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while deleting the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void lbl_Gid_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Gco_Click(object sender, EventArgs e)
        {

        }

        private void btn_PickColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = colorDialog1.Color;
                selectedColourHex = ColorTranslator.ToHtml(colorDialog1.Color);
                panel1.BackColor = colorDialog1.Color;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDBshow_Click(object sender, EventArgs e)
        {
            string grade_name = dgvGrade.CurrentRow.Cells["grade_name"].Value.ToString();
            string grade_group = dgvGrade.CurrentRow.Cells["grade_group"].Value.ToString();
            string grade_order = dgvGrade.CurrentRow.Cells["grade_order"].Value.ToString();
            string colour = dgvGrade.CurrentRow.Cells["colour"].Value.ToString();
            string grade_id = dgvGrade.CurrentRow.Cells["id"].Value.ToString();
            frmShowGrade f = new frmShowGrade(grade_name, grade_group, grade_order, colour, grade_id);
            f.ShowDialog();
        }
    }
}