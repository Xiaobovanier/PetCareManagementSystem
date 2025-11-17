using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.SqlClient;
using PetCareManagementSystemV2.Config;
using PetCareManagementSystemV2.Models;

namespace PetCareManagementSystemV2.Repositories
{
    public class OwnerRepository
    {
        public List<Owner> GetAll()
        {
            var list = new List<Owner>();
            using var conn = new SqlConnection(DbConfig.ConnectionString);
            conn.Open();

            string sql = "SELECT * FROM Owner ORDER BY OwnerId";
            using var cmd = new SqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Owner
                {
                    OwnerId = reader.GetInt32(0),
                    FullName = reader.GetString(1),
                    Phone = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    Email = reader.IsDBNull(3) ? "" : reader.GetString(3),
                    Address = reader.IsDBNull(4) ? "" : reader.GetString(4),
                    CreatedAt = reader.GetDateTime(5),
                    CreatedBy = reader.IsDBNull(6) ? null : reader.GetInt32(6)
                });
            }
            return list;
        }

        public Owner? GetById(int id)
        {
            using var conn = new SqlConnection(DbConfig.ConnectionString);
            conn.Open();

            string sql = "SELECT * FROM Owner WHERE OwnerId=@id";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Owner
                {
                    OwnerId = reader.GetInt32(0),
                    FullName = reader.GetString(1),
                    Phone = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    Email = reader.IsDBNull(3) ? "" : reader.GetString(3),
                    Address = reader.IsDBNull(4) ? "" : reader.GetString(4),
                    CreatedAt = reader.GetDateTime(5),
                    CreatedBy = reader.IsDBNull(6) ? null : reader.GetInt32(6)
                };
            }
            return null;
        }

        public void Insert(Owner o)
        {
            using var conn = new SqlConnection(DbConfig.ConnectionString);
            conn.Open();

            string sql = @"INSERT INTO Owner(FullName, Phone, Email, Address, CreatedBy)
                           VALUES(@FullName, @Phone, @Email, @Address, @CreatedBy)";
            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@FullName", o.FullName);
            cmd.Parameters.AddWithValue("@Phone", string.IsNullOrEmpty(o.Phone) ? DBNull.Value : o.Phone);
            cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(o.Email) ? DBNull.Value : o.Email);
            cmd.Parameters.AddWithValue("@Address", string.IsNullOrEmpty(o.Address) ? DBNull.Value : o.Address);
            cmd.Parameters.AddWithValue("@CreatedBy", (object?)o.CreatedBy ?? DBNull.Value);

            cmd.ExecuteNonQuery();
        }

        public void Update(Owner o)
        {
            using var conn = new SqlConnection(DbConfig.ConnectionString);
            conn.Open();

            string sql = @"UPDATE Owner SET 
                           FullName=@FullName, Phone=@Phone, Email=@Email, Address=@Address
                           WHERE OwnerId=@id";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", o.OwnerId);
            cmd.Parameters.AddWithValue("@FullName", o.FullName);
            cmd.Parameters.AddWithValue("@Phone", string.IsNullOrEmpty(o.Phone) ? DBNull.Value : o.Phone);
            cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(o.Email) ? DBNull.Value : o.Email);
            cmd.Parameters.AddWithValue("@Address", string.IsNullOrEmpty(o.Address) ? DBNull.Value : o.Address);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = new SqlConnection(DbConfig.ConnectionString);
            conn.Open();

            string sql = "DELETE FROM Owner WHERE OwnerId=@id";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}

