using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2.DAL
{
    public class Student_DAL
    {
        private readonly string connString =
            ConfigurationManager.ConnectionStrings["MySqlConnection"]
                ?.ConnectionString
            ?? "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=";

        // --- GetAll ---
        public DataTable GetAll()
        {
            return GetAllAsync().GetAwaiter().GetResult();
        }

        public async Task<DataTable> GetAllAsync()
        {
            var dt = new DataTable();

            using (var conn = new MySqlConnection(connString))
            using (var cmd = new MySqlCommand("SELECT * FROM students", conn))
            {
                try
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                    {
                        dt.Load(reader);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("An error occurred while accessing the database: " + ex.Message,
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dt;
        }

        // --- GetGrades ---
        public DataTable GetGrades()
        {
            return GetGradesAsync().GetAwaiter().GetResult();
        }

        public async Task<DataTable> GetGradesAsync()
        {
            var dt = new DataTable();

            using (var conn = new MySqlConnection(connString))
            using (var cmd = new MySqlCommand("SELECT * FROM grades", conn))
            {
                try
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                    {
                        dt.Load(reader);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("An error occurred while accessing the database: " + ex.Message,
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dt;
        }

        // --- Insert ---
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
            return InsertAsync(
                id, firstName, lastName, gender, dateOfBirth, dateOfAdmission,
                nic, telephone, address, gradeId, houseId, familyId, medium, admissionNumber
            ).GetAwaiter().GetResult();
        }

        public async Task<bool> InsertAsync(
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
            const string query = @"
                INSERT INTO students
                (
                    id, first_name, last_name, gender, date_of_birth, date_of_admission,
                    nic_number, tele_number, per_address, grade_id, house_id, family_id,
                    medium, admission_number
                )
                VALUES
                (
                    @id, @first_name, @last_name, @gender, @date_of_birth, @date_of_admission,
                    @nic_number, @tele_number, @per_address, @grade_id, @house_id, @family_id,
                    @medium, @admission_number
                )";

            using (var conn = new MySqlConnection(connString))
            using (var cmd = new MySqlCommand(query, conn))
            {
                await conn.OpenAsync().ConfigureAwait(false);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@first_name", firstName);
                cmd.Parameters.AddWithValue("@last_name", lastName);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@date_of_birth", dateOfBirth);
                cmd.Parameters.AddWithValue("@date_of_admission", dateOfAdmission);
                cmd.Parameters.AddWithValue("@nic_number", nic ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@tele_number", telephone ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@per_address", address ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@grade_id", gradeId);
                cmd.Parameters.AddWithValue("@house_id", houseId);
                cmd.Parameters.AddWithValue("@family_id", familyId);
                cmd.Parameters.AddWithValue("@medium", medium ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@admission_number", admissionNumber ?? (object)DBNull.Value);

                int rows = await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
                return rows > 0;
            }
        }

        // --- Delete ---
        public bool Delete(string studentId)
        {
            return DeleteAsync(studentId).GetAwaiter().GetResult();
        }

        public async Task<bool> DeleteAsync(string studentId)
        {
            const string query = "DELETE FROM students WHERE id = @id";

            using (var conn = new MySqlConnection(connString))
            using (var cmd = new MySqlCommand(query, conn))
            {
                await conn.OpenAsync().ConfigureAwait(false);
                cmd.Parameters.AddWithValue("@id", studentId);
                int rows = await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
                return rows > 0;
            }
        }

        // --- Update ---
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
            return UpdateAsync(
                id, firstName, lastName, gender, dateOfBirth, dateOfAdmission,
                nic, telephone, address, gradeId, houseId, familyId, medium, admissionNumber
            ).GetAwaiter().GetResult();
        }

        public async Task<bool> UpdateAsync(
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
            const string query = @"
                UPDATE students SET
                    first_name = @first_name,
                    last_name = @last_name,
                    gender = @gender,
                    date_of_birth = @date_of_birth,
                    date_of_admission = @date_of_admission,
                    nic_number = @nic_number,
                    tele_number = @tele_number,
                    per_address = @per_address,
                    grade_id = @grade_id,
                    house_id = @house_id,
                    family_id = @family_id,
                    medium = @medium,
                    admission_number = @admission_number
                WHERE id = @id";

            using (var conn = new MySqlConnection(connString))
            using (var cmd = new MySqlCommand(query, conn))
            {
                await conn.OpenAsync().ConfigureAwait(false);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@first_name", firstName ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@last_name", lastName ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@gender", gender ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@date_of_birth", dateOfBirth);
                cmd.Parameters.AddWithValue("@date_of_admission", dateOfAdmission);
                cmd.Parameters.AddWithValue("@nic_number", nic ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@tele_number", telephone ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@per_address", address ?? (object)DBNull.Value);

                cmd.Parameters.AddWithValue("@grade_id", gradeId.HasValue ? (object)gradeId.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@house_id", houseId.HasValue ? (object)houseId.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@family_id", familyId.HasValue ? (object)familyId.Value : DBNull.Value);

                cmd.Parameters.AddWithValue("@medium", medium ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@admission_number", admissionNumber ?? (object)DBNull.Value);

                int rows = await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
                return rows > 0;
            }
        }
    }
}
