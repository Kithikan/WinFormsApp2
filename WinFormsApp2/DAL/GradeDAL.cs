using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsApp2.DAL
{
    public class GradeDAL
    {
        private readonly string connString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
        public DataTable GetAll()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
             
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM grades", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                
                adapter.Fill(dt);
                return dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while loading grades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dt;
            }
        }

    }
}
