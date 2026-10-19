using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;      
using System.Windows.Forms;
using WinFormsApp2.DAL;
using WinFormsApp2.BLL;

namespace WinFormsApp2
{
    public partial class InsertStudent : Form
    {
        private StudentService studentService = new StudentService();
        string connString = ConfigurationManager
            .ConnectionStrings["MySqlConnection"]
            .ConnectionString ?? string.Empty;

        public InsertStudent()
        {
            InitializeComponent();

            this.Load += InsertStudent_Load;
        }

        // Designer references button1_Click; provide wrapper to call the actual handler
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            string gender = "";

            // Check gender
            if (radioButtonM.Checked)
            {
                gender = "M";
            }
            else if (radioButtonF.Checked)
            {
                gender = "F";
            }
            else
            {
                MessageBox.Show("Please select gender.");
                return;
            }

            // Check required fields
            if (txtF.Text.Trim() == "" ||
                txtL.Text.Trim() == "" ||
                txtNIC.Text.Trim() == "" ||
                txtTel.Text.Trim() == "" ||
                txtADD.Text.Trim() == "" ||
                txt_Addn.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            try
            {
                // use studentService

                // Call INSERT method via BLL service
                bool result = studentService.Insert(
                    txt_Sid.Text,
                    txtF.Text,
                    txtL.Text,
                    gender,
                    DTPbod.Value.Date,
                    dtpAddm.Value.Date,
                    txtNIC.Text,
                    txtTel.Text,
                    txtADD.Text,
                    Convert.ToInt32(cmbLG.SelectedValue),
                    Convert.ToInt32(cmb_House.SelectedValue),
                    Convert.ToInt32(cmb_Family.SelectedValue),
                    cmb_Medium.Text,
                    txt_Addn.Text
                );

                // Check result
                if (result)
                {
                    MessageBox.Show(
                        "Student inserted successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    ClearFields();
                }
                else
                {
                    MessageBox.Show(
                        "Student was not inserted.",
                        "Insert Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting student: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // Designer wires button1_Click; provide method so designer event hookup compiles.
        private void button1_Click(object sender, EventArgs e)
        {
            // Forward the click to the main insert handler
            btn_Insert_Click(sender, e);
        }

        private void InsertStudent_Load(object sender, EventArgs e)
        {
            LoadGrades();
            LoadHouses();
            LoadFamilies();
        }

        // Load Grade



        private void LoadGrades()
        {
            try
            {
                DataTable dt = studentService.GetGrades();

                cmbLG.DataSource = dt;
                cmbLG.DisplayMember = "grade_name";
                cmbLG.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading grades: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }





        // Load House
        private void LoadHouses()
        {
            try
            {
                DataTable dt = studentService.GetHouses();
                cmb_House.DataSource = dt;
                cmb_House.DisplayMember = "house_name";
                cmb_House.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading houses: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Load Family
        private void LoadFamilies()
        {
            try
            {
                DataTable dt = studentService.GetFamilies();
                cmb_Family.DataSource = dt;
                cmb_Family.DisplayMember = "family_name";
                cmb_Family.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading families: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // INSERT BUTTON
        

        // Clear form after insert
        private void ClearFields()
        {
            txtF.Clear();
            txtL.Clear();
            txtNIC.Clear();
            txtTel.Clear();
            txtADD.Clear();
            txt_Addn.Clear();

            radioButtonM.Checked = false;
            radioButtonF.Checked = false;

            DTPbod.Value = DateTime.Today;
            dtpAddm.Value = DateTime.Today;

            if (cmbLG.Items.Count > 0)
                cmbLG.SelectedIndex = 0;

            if (cmb_House.Items.Count > 0)
                cmb_House.SelectedIndex = 0;

            if (cmb_Family.Items.Count > 0)
                cmb_Family.SelectedIndex = 0;

            if (cmb_Medium.Items.Count > 0)
                cmb_Medium.SelectedIndex = 0;
        }

        private void dtpAddm_ValueChanged(object sender, EventArgs e)
        {

        }

        private void InsertStudent_Load_1(object sender, EventArgs e)
        {

        }

        private void txt_Addn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Sid_TextChanged(object sender, EventArgs e)
        {
            // Handle Student ID text changes if needed (keeps designer event hookup valid)
        }
    }
}  







