using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp2.DAL;
using WinFormsApp2.BLL;

namespace WinFormsApp2
{
    public partial class EditStudent : Form
    {
        private string studentId;

        string connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString ?? string.Empty;

        public EditStudent(string id)
        {
            InitializeComponent();
            studentId = id;
        }

        private void lblGrd_Click(object sender, EventArgs e)
        {

        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            try
            {
                StudentService studentService = new StudentService();

                // Load lookups via BLL
                DataTable gradeTable = studentService.GetGrades();
                cmbLG.DataSource = gradeTable;
                cmbLG.DisplayMember = "grade_name";
                cmbLG.ValueMember = "id";

                DataTable houseTable = studentService.GetHouses();
                cmb_House.DataSource = houseTable;
                cmb_House.DisplayMember = "house_name";
                cmb_House.ValueMember = "id";

                DataTable familyTable = studentService.GetFamilies();
                cmb_Family.DataSource = familyTable;
                cmb_Family.DisplayMember = "mobile_number";
                cmb_Family.ValueMember = "id";

                // Load Student Data into Form Controls
                DataTable dt = studentService.GetStudentById(this.studentId);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Student not found");
                    return;
                }

                DataRow dr = dt.Rows[0];

                //Load Student Data into TextBoxes
                txtFna.Text = dr["first_name"].ToString();
                txtL.Text = dr["last_name"].ToString();
                txtADD.Text = dr["per_address"].ToString();
                txt_Addn.Text = dr["admission_number"].ToString();
                txtNIC.Text = dr["nic_number"].ToString();
                txtTel.Text = dr["tele_number"].ToString();

                //Load Gender
                string gender = dr["gender"].ToString();

                rdoM.Checked = gender == "M";
                rdoF.Checked = gender == "F";

                //Load Grade into ComboBoxes
                if (dr["grade_id"] != DBNull.Value)
                {
                    cmbLG.SelectedValue = Convert.ToInt32(dr["grade_id"]);
                }
                else
                {
                    cmbLG.SelectedIndex = -1;
                    cmbLG.Text = "N/A";
                }

                //Load admission date into DateTimePicker
                if (dr["date_of_birth"] != DBNull.Value)

                {
                    dtpBirthOFDate.Value = Convert.ToDateTime(dr["date_of_birth"]);
                }
                else
                {
                    dtpBirthOFDate.Value = DateTime.Now;
                }

                //Load admission date into DateTimePicker
                if (dr["date_of_admission"] != DBNull.Value)
                {
                    dtpAddmission.Value = Convert.ToDateTime(dr["date_of_admission"]);
                }
                else
                {
                    dtpAddmission.Value = DateTime.Now;
                }

                //Load House into ComboBoxes
                if (dr["house_id"] != DBNull.Value)
                {
                    int houseId = Convert.ToInt32(dr["house_id"]);
                    cmb_House.SelectedValue = houseId;
                }
                else
                {
                    cmb_House.SelectedIndex = -1;
                    cmb_House.Text = "N/A";
                }

                //Load Medium into ComboBoxes
                if (dr["medium"] != DBNull.Value)
                {
                    cmb_Medium.Text = dr["medium"].ToString();
                }
                else
                {
                    cmb_Medium.Text = "N/A";
                }

                // Family ID
                if (dr["family_id"] != DBNull.Value)
                {
                    cmb_Family.SelectedValue = Convert.ToInt32(dr["family_id"]);
                }
                else
                {
                    cmb_Family.SelectedIndex = -1;
                    cmb_Family.Text = "N/A";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            StudentService studentService = new StudentService();
            studentService.Update(
                studentId,
                txtFna.Text.Trim(),
                txtL.Text.Trim(),
                rdoM.Checked ? "M" : "F",
                dtpBirthOFDate.Value,
                dtpAddmission.Value,
                string.IsNullOrWhiteSpace(txtNIC.Text) ? null : txtNIC.Text.Trim(),
                txtTel.Text.Trim(),
                txtADD.Text.Trim(),
                cmbLG.SelectedValue != null ? Convert.ToInt32(cmbLG.SelectedValue) : (int?)null,
                cmb_House.SelectedValue != null ? Convert.ToInt32(cmb_House.SelectedValue) : (int?)null,
                cmb_Family.SelectedValue != null ? Convert.ToInt32(cmb_Family.SelectedValue) : (int?)null,
                cmb_Medium.Text,
                txt_Addn.Text.Trim()
            );  

            //try
            //{
            //    conn.Open();

            //    string gender = rdoM.Checked ? "M" : "F";

            //    // Check duplicate NIC
            //    if (!string.IsNullOrWhiteSpace(txtNIC.Text))
            //    {
            //        string checkQuery = @"
            //    SELECT COUNT(*) 
            //    FROM students 
            //    WHERE nic_number = @nic_number
            //    AND id <> @id";

            //        MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);

            //        checkCmd.Parameters.AddWithValue("@nic_number", txtNIC.Text.Trim());
            //        checkCmd.Parameters.AddWithValue("@id", studentId);

            //        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

            //        if (count > 0)
            //        {
            //            MessageBox.Show(
            //                "This NIC number is already used by another student.",
            //                "Duplicate NIC",
            //                MessageBoxButtons.OK,
            //                MessageBoxIcon.Warning
            //            );

            //            return;
            //        }
            //    }

            //    string query = @"
            //UPDATE students SET
            //    first_name = @first_name,
            //    last_name = @last_name,
            //    gender = @gender,
            //    date_of_birth = @date_of_birth,
            //    date_of_admission = @date_of_admission,
            //    nic_number = @nic_number,
            //    tele_number = @tele_number,
            //    per_address = @per_address,
            //    grade_id = @grade_id,
            //    house_id = @house_id,
            //    family_id = @family_id,
            //    medium = @medium,
            //    admission_number = @admission_number
            //WHERE id = @id";

            //    MySqlCommand cmd = new MySqlCommand(query, conn);

            //    cmd.Parameters.AddWithValue("@first_name", txtFna.Text.Trim());
            //    cmd.Parameters.AddWithValue("@last_name", txtL.Text.Trim());
            //    cmd.Parameters.AddWithValue("@gender", gender);

            //    cmd.Parameters.AddWithValue("@date_of_birth", dtpBirthOFDate.Value);
            //    cmd.Parameters.AddWithValue("@date_of_admission", dtpAddmission.Value);

            //    // NIC
            //    if (string.IsNullOrWhiteSpace(txtNIC.Text))
            //    {
            //        cmd.Parameters.AddWithValue("@nic_number", DBNull.Value);
            //    }
            //    else
            //    {
            //        cmd.Parameters.AddWithValue("@nic_number", txtNIC.Text.Trim());
            //    }

            //    cmd.Parameters.AddWithValue("@tele_number", txtTel.Text.Trim());
            //    cmd.Parameters.AddWithValue("@per_address", txtADD.Text.Trim());

            //    cmd.Parameters.AddWithValue("@grade_id", cmbLG.SelectedValue);
            //    cmd.Parameters.AddWithValue("@house_id", cmb_House.SelectedValue);
            //    cmd.Parameters.AddWithValue("@family_id", cmb_Family.SelectedValue);

            //    cmd.Parameters.AddWithValue("@medium", cmb_Medium.Text);
            //    cmd.Parameters.AddWithValue("@admission_number", txt_Addn.Text.Trim());

            //    cmd.Parameters.AddWithValue("@id", studentId);

            //    int result = cmd.ExecuteNonQuery();

            //    if (result > 0)
            //    {
            //        MessageBox.Show(
            //            "Student updated successfully!",
            //            "Success",
            //            MessageBoxButtons.OK,
            //            MessageBoxIcon.Information
            //        );

            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Student was not updated.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(
            //        "Update Error: " + ex.Message,
            //        "Error",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error
            //    );
            //}
            //finally
            //{
       //     conn.Close();
            }
        }
    }   