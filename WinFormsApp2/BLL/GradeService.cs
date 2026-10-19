using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using WinFormsApp2.DAL;

namespace WinFormsApp2.BLL
{
    /// <summary>
    /// Grade service that wraps GradeDAL and provides insert/update/delete operations used by the forms.
    /// </summary>
    public class GradeService
    {
        private readonly GradeDAL _dal = new GradeDAL();
        private readonly string _connString = ConfigurationManager.ConnectionStrings["MySqlConnection"]?.ConnectionString ?? "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";

        public DataTable GetAll() => _dal.GetAll();

        public DataTable GetById(string id)
        {
            var dt = new DataTable();
            string query = "SELECT * FROM grades WHERE id = @id";
            using (var conn = new MySqlConnection(_connString))
            using (var cmd = new MySqlCommand(query, conn))
            using (var da = new MySqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                da.Fill(dt);
            }
            return dt;
        }

        public bool Insert(string gradeName, string gradeGroup, string gradeOrder, string colour)
        {
            const string query = @"INSERT INTO grades (grade_name, grade_group, grade_order, colour) VALUES (@name, @group, @order, @colour)";
            using (var conn = new MySqlConnection(_connString))
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", gradeName ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@group", gradeGroup ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@order", gradeOrder ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@colour", colour ?? (object)DBNull.Value);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        public bool Delete(string gradeId)
        {
            const string query = "DELETE FROM grades WHERE id = @id";
            using (var conn = new MySqlConnection(_connString))
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", gradeId);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

n        public bool Update(string id, string gradeName, string gradeGroup, string gradeOrder, string colour)
        {
            const string query = @"
                UPDATE grades
                SET grade_name = @grade_name,
                    grade_group = @grade_group,
                    grade_order = @grade_order,
                    colour = @colour
                WHERE id = @id";

n            using (var conn = new MySqlConnection(_connString))
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@grade_name", gradeName ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@grade_group", gradeGroup ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@grade_order", gradeOrder ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@colour", colour ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@id", id);

n                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }
    }
}
