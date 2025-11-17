using Microsoft.Data.SqlClient;
using PetCareManagementSystemV2.Config;
using PetCareManagementSystemV2.Models;

namespace PetCareManagementSystemV2.Repositories
{
    public class VaccinationRecordRepository
    {
        public List<VaccinationRecord> GetAll()
        {
            var list = new List<VaccinationRecord>();
            using var conn = new SqlConnection(DbConfig.ConnectionString);
            conn.Open();

            string sql = "SELECT * FROM VaccinationRecord ORDER BY GivenDate DESC";
            using var cmd = new SqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new VaccinationRecord
                {
                    VaccinationId = reader.GetInt32(0),
                    PetId = reader.GetInt32(1),
                    VaccineName = reader.GetString(2),
                    GivenDate = reader.GetDateTime(3),
                    NextDueDate = reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                    Notes = reader.IsDBNull(5) ? "" : reader.GetString(5)
                });
            }
            return list;
        }

        public VaccinationRecord? GetById(int id)
        {
            using var conn = new SqlConnection(DbConfig.ConnectionString);
            conn.Open();

            string sql = "SELECT * FROM VaccinationRecord WHERE VaccinationId=@id";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new VaccinationRecord
                {
                    VaccinationId = reader.GetInt32(0),
                    PetId = reader.GetInt32(1),
                    VaccineName = reader.GetString(2),
                    GivenDate = reader.GetDateTime(3),
                    NextDueDate = reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                    Notes = reader.IsDBNull(5) ? "" : reader.GetString(5)
                };
            }
            return null;
        }

        public void Insert(VaccinationRecord v)
        {
            using var conn = new SqlConnection(DbConfig.ConnectionString);
            conn.Open();

            string sql = @"INSERT INTO VaccinationRecord(PetId, VaccineName, GivenDate, NextDueDate, Notes)
                           VALUES(@PetId, @VaccineName, @GivenDate, @NextDueDate, @Notes)";
            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@PetId", v.PetId);
            cmd.Parameters.AddWithValue("@VaccineName", v.VaccineName);
            cmd.Parameters.AddWithValue("@GivenDate", v.GivenDate);
            cmd.Parameters.AddWithValue("@NextDueDate", (object?)v.NextDueDate ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Notes", (object?)v.Notes ?? DBNull.Value);

            cmd.ExecuteNonQuery();
        }

        public void Update(VaccinationRecord v)
        {
            using var conn = new SqlConnection(DbConfig.ConnectionString);
            conn.Open();

            string sql = @"UPDATE VaccinationRecord SET
                           PetId=@PetId, VaccineName=@VaccineName, GivenDate=@GivenDate,
                           NextDueDate=@NextDueDate, Notes=@Notes
                           WHERE VaccinationId=@id";

            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", v.VaccinationId);
            cmd.Parameters.AddWithValue("@PetId", v.PetId);
            cmd.Parameters.AddWithValue("@VaccineName", v.VaccineName);
            cmd.Parameters.AddWithValue("@GivenDate", v.GivenDate);
            cmd.Parameters.AddWithValue("@NextDueDate", (object?)v.NextDueDate ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Notes", (object?)v.Notes ?? DBNull.Value);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = new SqlConnection(DbConfig.ConnectionString);
            conn.Open();

            string sql = "DELETE FROM VaccinationRecord WHERE VaccinationId=@id";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }
    }
}

