using Microsoft.Data.SqlClient;
using PetCareManagementSystemV2.Config;
using PetCareManagementSystemV2.Models;

namespace PetCareManagementSystemV2.Repositories
{
    public class PetRepository
    {
        public List<Pet> GetAll()
        {
            var list = new List<Pet>();
            using var conn = new SqlConnection(DbConfig.ConnectionString);
            conn.Open();

            string sql = "SELECT * FROM Pet ORDER BY PetId";
            using var cmd = new SqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Pet
                {
                    PetId = reader.GetInt32(0),
                    OwnerId = reader.GetInt32(1),
                    PetName = reader.GetString(2),
                    Species = reader.GetString(3),
                    Breed = reader.IsDBNull(4) ? "" : reader.GetString(4),
                    BirthDate = reader.IsDBNull(5) ? null : reader.GetDateTime(5),
                    Notes = reader.IsDBNull(6) ? "" : reader.GetString(6)
                });
            }
            return list;
        }

        public Pet? GetById(int id)
        {
            using var conn = new SqlConnection(DbConfig.ConnectionString);
            conn.Open();

            string sql = "SELECT * FROM Pet WHERE PetId=@id";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Pet
                {
                    PetId = reader.GetInt32(0),
                    OwnerId = reader.GetInt32(1),
                    PetName = reader.GetString(2),
                    Species = reader.GetString(3),
                    Breed = reader.IsDBNull(4) ? "" : reader.GetString(4),
                    BirthDate = reader.IsDBNull(5) ? null : reader.GetDateTime(5),
                    Notes = reader.IsDBNull(6) ? "" : reader.GetString(6)
                };
            }
            return null;
        }

        public void Insert(Pet p)
        {
            using var conn = new SqlConnection(DbConfig.ConnectionString);
            conn.Open();

            string sql = @"INSERT INTO Pet(OwnerId, PetName, Species, Breed, BirthDate, Notes)
                           VALUES(@OwnerId, @PetName, @Species, @Breed, @BirthDate, @Notes)";
            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@OwnerId", p.OwnerId);
            cmd.Parameters.AddWithValue("@PetName", p.PetName);
            cmd.Parameters.AddWithValue("@Species", p.Species);
            cmd.Parameters.AddWithValue("@Breed", string.IsNullOrEmpty(p.Breed) ? DBNull.Value : p.Breed);
            cmd.Parameters.AddWithValue("@BirthDate", (object?)p.BirthDate ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(p.Notes) ? DBNull.Value : p.Notes);

            cmd.ExecuteNonQuery();
        }

        public void Update(Pet p)
        {
            using var conn = new SqlConnection(DbConfig.ConnectionString);
            conn.Open();

            string sql = @"UPDATE Pet SET 
                           OwnerId=@OwnerId, PetName=@PetName, Species=@Species, Breed=@Breed, BirthDate=@BirthDate, Notes=@Notes
                           WHERE PetId=@id";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", p.PetId);
            cmd.Parameters.AddWithValue("@OwnerId", p.OwnerId);
            cmd.Parameters.AddWithValue("@PetName", p.PetName);
            cmd.Parameters.AddWithValue("@Species", p.Species);
            cmd.Parameters.AddWithValue("@Breed", string.IsNullOrEmpty(p.Breed) ? DBNull.Value : p.Breed);
            cmd.Parameters.AddWithValue("@BirthDate", (object?)p.BirthDate ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(p.Notes) ? DBNull.Value : p.Notes);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = new SqlConnection(DbConfig.ConnectionString);
            conn.Open();

            string sql = "DELETE FROM Pet WHERE PetId=@id";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}

