using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WinFormsApp2.BLL;

namespace WinFormsApp2
{
    public partial class ShowStudent1 : Form
    {
        string id;
        string fname;
        string lname;
        string gender;
        string DOB;
        string DOA;
        string nic;
        string tel;
        string address;
        string house;
        string family;
        string grade;
        string admission;
        string medium;

n        public ShowStudent1(string id, string fname, string lname, string gender, string DOB, string DOA, string nic, string tel, string address, string house, string family, string grade, string admission, string medium)
        {
            InitializeComponent();
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.gender = gender;
            this.DOB = DOB;
            this.DOA = DOA;
            this.nic = nic;
            this.tel = tel;
            this.address = address;
            this.house = house;
            this.family = family;
            this.grade = grade;
            this.admission = admission;
            this.medium = medium;
        }

        private void lblName_Click(object sender, EventArgs e)
        {
        }

        private void ShowStudent1_Load(object sender, EventArgs e)
        {
            txt_Sid.Text = id;
            txtF.Text = fname;
            txtL.Text = lname;
            if (gender == "Male")
            {
                radioButtonM.Checked = true;
            }
            else
            {
                radioButtonF.Checked = true;
            }

n            if (!string.IsNullOrEmpty(DOB))
                DTPbod.Value = DateTime.Parse(DOB);

            if (!string.IsNullOrEmpty(DOA))
                dtpAddm.Value = DateTime.Parse(DOA);

            txtNIC.Text = nic;
            txtTel.Text = tel;
            txtADD.Text = address;
            txt_Addn.Text = admission;

            // Bind lookups via StudentService
            try
            {
                StudentService studentService = new StudentService();

                DataTable grades = studentService.GetGrades();
                cmbLG.DataSource = grades;
                cmbLG.DisplayMember = "grade_name";
                cmbLG.ValueMember = "id";
                if (!string.IsNullOrEmpty(grade)) cmbLG.SelectedValue = Convert.ToInt32(grade);

                DataTable houses = studentService.GetHouses();
                cmb_House.DataSource = houses;
                cmb_House.DisplayMember = "house_name";
                cmb_House.ValueMember = "id";
                if (!string.IsNullOrEmpty(house)) cmb_House.SelectedValue = Convert.ToInt32(house);

                DataTable families = studentService.GetFamilies();
                cmb_Family.DataSource = families;
                cmb_Family.DisplayMember = "family_name";
                cmb_Family.ValueMember = "id";
                if (!string.IsNullOrEmpty(family)) cmb_Family.SelectedValue = Convert.ToInt32(family);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            cmbLG.Text = grade;
            cmb_House.Text = house;
            cmb_Family.Text = family;
            cmb_Medium.Text = medium;
        }

        private void txt_Sid_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
        }
    }
}
