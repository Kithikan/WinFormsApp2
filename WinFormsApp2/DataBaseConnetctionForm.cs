using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Versioning;
using System.Text;
using System.Windows.Forms;
using WinFormsApp2;
using WinFormsApp2.DAL;
using WinFormsApp2.BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp2
{
    public partial class DataBaseConnetctionForm : Form
    {

        string connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString ?? string.Empty;
        public DataBaseConnetctionForm()
        {
            InitializeComponent();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            //string connString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                MessageBox.Show("Conncection Successful", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void btnA_Click(object sender, EventArgs e)
        {
            StudentService studentService = new StudentService();
            DataTable dt = studentService.GetAll();
            dgvStu.DataSource = dt;

        }

        private void GetAll()
        {
            string connString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from students", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvStu.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while accessing the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void lblF_Click(object sender, EventArgs e)
        {

        }

        private void btnSW_Click(object sender, EventArgs e)
        {
            //string connString = "Server=localhost;Port=3307 ;Database=school ;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                if (dgvStu.Rows.Count == 0)
                {
                    MessageBox.Show("No records found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string fname = dgvStu.CurrentRow.Cells["first_name"].Value.ToString();
                txtF.Text = fname;

                string lname = dgvStu.CurrentRow.Cells["last_name"].Value.ToString();
                txtL.Text = lname;

                if (dgvStu.CurrentRow.Cells["gender"].Value.ToString() == "M")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }


                string nic = dgvStu.CurrentRow.Cells["nic_number"].Value.ToString();
                txtNIC.Text = nic;

                string tel = dgvStu.CurrentRow.Cells["tele_number"].Value.ToString();
                txtTel.Text = tel;

                string dob = dgvStu.CurrentRow.Cells["date_of_birth"].Value?.ToString();

                if (!string.IsNullOrEmpty(dob) &&
                    DateTime.TryParse(dob, out DateTime dobValue) &&
                    dobValue >= dateTimePicker1.MinDate &&
                    dobValue <= dateTimePicker1.MaxDate)
                {
                    dateTimePicker1.Value = dobValue;
                }
                else
                {
                    dateTimePicker1.Value = DateTime.Today;
                }
                // duplicate date_of_birth parsing removed

                string doa = dgvStu.CurrentRow.Cells["date_of_admission"].Value?.ToString();
                if (!string.IsNullOrEmpty(doa) && DateTime.TryParse(doa, out DateTime doaValue))
                {
                    dateTimePicker2.Value = doaValue;
                }
                else
                {
                    dateTimePicker2.Value = DateTime.Now; // fallback for missing/invalid dates
                }

                string address = dgvStu.CurrentRow.Cells["per_address"].Value.ToString();
                txtADD.Text = address;

                string grade = dgvStu.CurrentRow.Cells["grade_id"].Value.ToString();

                string house = dgvStu.CurrentRow.Cells["house_id"].Value.ToString();
                comboBox2.Text = house;

                string family = dgvStu.CurrentRow.Cells["family_id"].Value.ToString();
                comboBox3.Text = family;

                string medium = dgvStu.CurrentRow.Cells["medium"].Value.ToString();
                comboBox1.Text = medium;

                string adno = dgvStu.CurrentRow.Cells["admission_numb"].Value.ToString();
                textBox1.Text = adno;

                // GRADE ID
                //MySqlConnection conn = new MySqlConnection(connString);
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT * FROM grades";
                        using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            cmbLG.DataSource = dt;
                            // what user sees
                            cmbLG.DisplayMember = "grade_name";
                            // hidden value
                            cmbLG.ValueMember = "id";

                            // select student's grade
                            if (!string.IsNullOrEmpty(grade))
                            {
                                cmbLG.SelectedValue = Convert.ToInt32(grade);
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error occurred while fetching student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // HOUSE ID
                //using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    try
                    {
                        string queryy = "SELECT * FROM houses";
                        using (MySqlDataAdapter daa = new MySqlDataAdapter(queryy, conn))
                        {
                            DataTable dtt = new DataTable();
                            daa.Fill(dtt);

                            comboBox2.DataSource = dtt;
                            // what user sees
                            comboBox2.DisplayMember = "house_name";
                            // hidden value
                            comboBox2.ValueMember = "id";
                            // select student's house
                            if (!string.IsNullOrEmpty(house))
                            {
                                comboBox2.SelectedValue = Convert.ToInt32(house);
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error occurred while fetching house data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // FAMILY ID
                if (family != "")
                {
                    comboBox3.SelectedValue = Convert.ToInt32(family);
                }

                // MEDIUM
                if (medium != "")
                {
                    comboBox1.Text = medium;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }


        private void btnLG_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from grades", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbLG.DataSource = dt;
                cmbLG.DisplayMember = "grade_name"; // column showing grade name in the dropdown
                cmbLG.ValueMember = "id";           // primary key column of the grades table
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while accessing the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbLG.SelectedValue.ToString());
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    cmbLG.SelectedValue = 10;
        //}

        private void button21_Click(object sender, EventArgs e)
        {

            try
            {
                string id = dgvStu.CurrentRow.Cells["id"].Value.ToString();
                DBshow f = new DBshow(id);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDiaSW_Click(object sender, EventArgs e)
        {
            try
            {

                string id = dgvStu.CurrentRow.Cells["id"].Value.ToString();
                string fname = dgvStu.CurrentRow.Cells["first_name"].Value.ToString();
                string lname = dgvStu.CurrentRow.Cells["last_name"].Value.ToString();
                string gender = dgvStu.CurrentRow.Cells["gender"].Value.ToString();
                string DOB = Convert.ToDateTime(dgvStu.CurrentRow.Cells["date_of_birth"].Value).ToString("yyyy-MM-dd");
                string DOA = Convert.ToDateTime(dgvStu.CurrentRow.Cells["date_of_admission"].Value).ToString("yyyy-MM-dd");
                string nic = dgvStu.CurrentRow.Cells["nic_number"].Value.ToString();
                string tel = dgvStu.CurrentRow.Cells["tele_number"].Value.ToString();
                string address = dgvStu.CurrentRow.Cells["per_address"].Value.ToString();
                string grade = dgvStu.CurrentRow.Cells["grade_id"].Value.ToString();
                string family = dgvStu.CurrentRow.Cells["family_id"].Value.ToString();
                string house = dgvStu.CurrentRow.Cells["house_id"].Value.ToString();
                string admission = dgvStu.CurrentRow.Cells["admission_numb"].Value.ToString();
                string medium = dgvStu.CurrentRow.Cells["medium"].Value.ToString();


                ShowStudent1 f = new ShowStudent1(id, fname, lname, gender, DOB, DOA, nic, tel, address, house, family, grade, admission, medium);
                f.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = dgvStu.CurrentRow.Cells["id"].Value.ToString();
            EditStudent f = new EditStudent(id);
            f.ShowDialog();


            // EditStudent form only requires the student id. The form will load full details itself.
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertStudent f = new InsertStudent();
            f.ShowDialog();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStu.CurrentRow == null ||
                dgvStu.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            string studentId =
                dgvStu.CurrentRow.Cells["id"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this student?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                StudentService studentService = new StudentService();

                bool deleted = studentService.Delete(studentId);

                if (deleted)
                {
                    MessageBox.Show("Student deleted successfully!");

                    dgvStu.DataSource = studentService.GetAll();
                }
                else
                {
                    MessageBox.Show("Student was not found or was not deleted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error deleting student: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        // Added missing event handlers referenced by Designer.cs
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Intentionally left blank - wired to Designer event
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Intentionally left blank - wired to Designer event
        }

        //private void button2_Click_1(object sender, EventArgs e)
        //{               
        //    cmbLG.SelectedValue = 10;
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            cmbLG.SelectedValue = 10;
        }
    }
}
