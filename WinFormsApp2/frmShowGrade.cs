using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp2
{
    public partial class frmShowGrade : Form
    {
        //string connString = ConfigurationManager.ConnectionStrings["schoolDB"].ConnectionString;

        private string grade_name;
        private string grade_group;
        private string grade_order;
        private string grade_color;
        private string grade_id;
        private string selectedColourHex = "#000000"; // holds the picked color's hex value
        public frmShowGrade(string grade_name, string grade_group, string grade_order, string grade_color, string grade_id)
        {
            InitializeComponent();

            this.grade_name = grade_name;
            this.grade_group = grade_group;
            this.grade_order = grade_order;
            this.grade_color = grade_color;
            this.grade_id = grade_id;

        

        }

        //private const string connString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Intentionally left blank - handled if needed later
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Ensure the panel displays the grade color if provided
            try
            {
                if (!string.IsNullOrEmpty(grade_color))
                {
                    panel1.BackColor = ColorTranslator.FromHtml(grade_color);
                }
            }
            catch
            {
                // ignore parse errors
            }
        }

        private void frmShowGrade_Load(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            // Populate controls with provided values
            txtGrID.Text = grade_id ?? string.Empty;
            txtGrName.Text = grade_name ?? string.Empty;
            txtGrGroup.Text = grade_group ?? string.Empty;
            txtGrOrder.Text = grade_order ?? string.Empty;

            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(grade_color))
                {
                    panel1.BackColor = ColorTranslator.FromHtml(grade_color);
                    selectedColourHex = grade_color;

                }
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM grades WHERE id = @id", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                //dgvGrade.DataSource = dt;



            }
            catch
            {
                // ignore invalid color
            }
        }

    }
}
