using System;
using System.Data;
using System.Windows.Forms;
using WinFormsApp2.BLL;

namespace WinFormsApp2
{
    public partial class DBshow : Form
    {
        string studentId;
        public DBshow(string id)
        {
            InitializeComponent();
            this.studentId = id;
        }

        private void DBshow_Load(object sender, EventArgs e)
        {
            try
            {
                var studentService = new StudentService();
                DataTable dt = studentService.GetStudentDetailsById(this.studentId);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Student not found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataRow dr = dt.Rows[0];

                //Load Student Data into TextBoxes
                txtF.Text = dr["first_name"].ToString();
                txtL.Text = dr["last_name"].ToString();
                txtADD.Text = dr["per_address"].ToString();
                txt_Addn.Text = dr["admission_number"].ToString();
                txtNIC.Text = dr["nic_number"].ToString();
                txtTel.Text = dr["tele_number"].ToString();

                //Load Gender
                string gender = dr["gender"].ToString();
                rdoM.Checked = gender == "M";
                rdoF.Checked = gender == "F";

                //Load Grade into TextBox
                if (dr.Table.Columns.Contains("grade_name") && dr["grade_name"] != DBNull.Value)
                    txtGrade.Text = dr["grade_name"].ToString();
                else
                    txtGrade.Text = "N/A";

                //Load Date of Birth into DateTimePicker
                if (dr["date_of_birth"] != DBNull.Value)
                    DTPBIR.Value = Convert.ToDateTime(dr["date_of_birth"]);
                else
                    DTPBIR.Value = DateTime.Now;

                //load Date of Admission into DateTimePicker
                if (dr["date_of_admission"] != DBNull.Value)
                    DTPAddm.Value = Convert.ToDateTime(dr["date_of_admission"]);
                else
                    DTPAddm.Value = DateTime.Now;

                //Load House into TextBox
                if (dr.Table.Columns.Contains("house_name") && dr["house_name"] != DBNull.Value)
                    txtHouseID.Text = dr["house_name"].ToString();
                else
                    txtHouseID.Text = "N/A";

                //Load Medium into TextBox
                if (dr["medium"] != DBNull.Value)
                    txtMedium.Text = dr["medium"].ToString();
                else
                    txtMedium.Text = "N/A";

                //Family ID
                if (dr.Table.Columns.Contains("family_id") && dr["family_id"] != DBNull.Value)
                    txtFamilyID.Text = dr["family_id"].ToString();
                else
                    txtFamilyID.Text = "N/A";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            // Handler added to satisfy designer event wiring. No action required.
        }

        private void txtADD_TextChanged(object sender, EventArgs e)
        {
            // No action required; placeholder for designer event.
        }

        private void txtL_TextChanged(object sender, EventArgs e)
        {
            // No action required; placeholder for designer event.
        }

        private void txtF_TextChanged(object sender, EventArgs e)
        {
            // No action required; placeholder for designer event.
        }

        private void txtFmilyID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // No action required; placeholder for designer event.
        }

        private void txtHouseID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // No action required; placeholder for designer event.
        }
    }
}
