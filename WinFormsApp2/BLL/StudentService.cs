using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using WinFormsApp2.DAL;

namespace WinFormsApp2.BLL
{
    /// <summary>
    /// BLL wrapper around Student_DAL and small lookup helpers used by Forms.
    /// </summary>
    public class StudentService
    {
        private readonly Student_DAL _dal = new Student_DAL();
        private readonly string _connString = ConfigurationManager.ConnectionStrings["MySqlConnection"]?.ConnectionString ?? "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";

        public DataTable GetAll() => _dal.GetAll();

        public DataTable GetGrades() => _dal.GetGrades();

        public DataTable GetHouses()
        {
            var dt = new DataTable();
            using (var conn = new MySqlConnection(_connString))
            using (var cmd = new MySqlCommand("SELECT * FROM houses", conn))
            using (var da = new MySqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable GetFamilies()
        {
            var dt = new DataTable();
            using (var conn = new MySqlConnection(_connString))
            using (var cmd = new MySqlCommand("SELECT * FROM families", conn))
            using (var da = new MySqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(dt);
            }
            return dt;
        }

n        public DataTable GetStudentById(string id)
        {
            var dt = new DataTable();
            using (var conn = new MySqlConnection(_connString))
            using (var cmd = new MySqlCommand("SELECT * FROM students WHERE id = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                using (var da = new MySqlDataAdapter(cmd))
                {
                    conn.Open();
                    da.Fill(dt);
                }
            }
            return dt;
        }

n        public DataTable GetStudentDetailsById(string id)
        {
            var dt = new DataTable();
            string query = @"
                SELECT
                    students.*,
                    grades.grade_name,
                    houses.house_name,
                    families.id AS family_id
                FROM students
                LEFT JOIN grades ON students.grade_id = grades.id
                LEFT JOIN houses ON students.house_id = houses.id
                LEFT JOIN families ON students.family_id = families.id
                WHERE students.id = @id";

n            using (var conn = new MySqlConnection(_connString))
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                using (var da = new MySqlDataAdapter(cmd))
                {
                    conn.Open();
                    da.Fill(dt);
                }
            }

n            return dt;
        }

        public bool Insert(
            string id,
            string firstName,
            string lastName,
            string gender,
            DateTime dateOfBirth,
            DateTime dateOfAdmission,
            string nic,
            string telephone,
            string address,
            int gradeId,
            int houseId,
            int familyId,
            string medium,
            string admissionNumber)
        {
            // basic validation preserved (forms perform required checks as well)
            return _dal.Insert(id, firstName, lastName, gender, dateOfBirth, dateOfAdmission, nic, telephone, address, gradeId, houseId, familyId, medium, admissionNumber);
        }

n        public bool Delete(string studentId) => _dal.Delete(studentId);

        public bool Update(
            string id,
            string firstName,
            string lastName,
            string gender,
            DateTime dateOfBirth,
            DateTime dateOfAdmission,
            string nic,
            string telephone,
            string address,
            int? gradeId,
            int? houseId,
            int? familyId,
            string medium,
            string admissionNumber)
        {
            // Delegate to DAL (which already implements Update with null handling)
            return _dal.Update(id, firstName, lastName, gender, dateOfBirth, dateOfAdmission, nic, telephone, address, gradeId, houseId, familyId, medium, admissionNumber);
        }
    }
}
