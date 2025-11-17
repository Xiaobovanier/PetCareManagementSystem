using Microsoft.Data.SqlClient;
using PetCareManagementSystemV2.Config;
using PetCareManagementSystemV2.Models;

namespace PetCareManagementSystemV2.Repositories
{
    public class AppointmentRepository
    {
        public List<Appointment> GetAll()
        {
            var list = new List<Appointment>();
            using var conn = new SqlConnection(DbConfig.ConnectionString);
            conn.Open();

            string sql = "SELECT * FROM Appointment ORDER BY ApptTime DESC";
            using var cmd = new SqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Appointment
                {
                    AppointmentId = reader.GetInt32(0),
                    PetId = reader.GetInt32(1),
                    ApptTime = reader.GetDateTime(2),
                    Reason = reader.IsDBNull(3) ? "" : reader.GetString(3),
                    Status = reader.GetString(4)
                });
            }
            return list;
        }

        public Appointment? GetById(int id)
        {
            using var conn = new SqlConnection(DbConfig.ConnectionString);
            conn.Open();

            string sql = "SELECT * FROM Appointment WHERE AppointmentId=@id";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Appointment
                {
                    AppointmentId = reader.GetInt32(0),
                    PetId = reader.GetInt32(1),
                    ApptTime = reader.GetDateTime(2),
                    Reason = reader.IsDBNull(3) ? "" : reader.GetString(3),
                    Status = reader.GetString(4)
                };
            }
            return null;
        }

        public void Insert(Appointment a)
        {
            using var conn = new SqlConnection(DbConfig.ConnectionString);
            conn.Open();

            string sql = @"INSERT INTO Appointment(PetId, ApptTime, Reason, Status)
                           VALUES(@PetId, @ApptTime, @Reason, @Status)";
            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@PetId", a.PetId);
            cmd.Parameters.AddWithValue("@ApptTime", a.ApptTime);
            cmd.Parameters.AddWithValue("@Reason", (object?)a.Reason ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Status", a.Status);

            cmd.ExecuteNonQuery();
        }

        public void Update(Appointment a)
        {
            using var conn = new SqlConnection(DbConfig.ConnectionString);
            conn.Open();

            string sql = @"UPDATE Appointment SET 
                           PetId=@PetId, ApptTime=@ApptTime, Reason=@Reason, Status=@Status
                           WHERE AppointmentId=@id";

            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", a.AppointmentId);
            cmd.Parameters.AddWithValue("@PetId", a.PetId);
            cmd.Parameters.AddWithValue("@ApptTime", a.ApptTime);
            cmd.Parameters.AddWithValue("@Reason", (object?)a.Reason ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Status", a.Status);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = new SqlConnection(DbConfig.ConnectionString);
            conn.Open();

            string sql = "DELETE FROM Appointment WHERE AppointmentId=@id";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }
    }
}

