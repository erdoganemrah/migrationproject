using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Sakarya1
{
    class PG_Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string GroupName { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
    class PostgreSQLDb
    {
        private static string Host = "192.168.0.29";
        private static string User = "sakarya";
        private static string DBname = "adventureworks2019";
        private static string Password = "Password1";
        private static string Port = "5432";

        string BuildConnection()
        {
            string connString =
               String.Format(
                   "Server={0};Username={1};Database={2};Port={3};Password={4}",
                   Host,
                   User,
                   DBname,
                   Port,
                   Password);
            return connString;
        }

        public DataTable GetDepartments()
        {
            string connString = BuildConnection();

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var command = new NpgsqlCommand("SELECT * FROM humanresources.department ORDER BY modifieddate DESC", conn))
                {                    
                    var dr = command.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
            }
        }

        public PG_Department GetDepartment(int departmentId)
        {
            string connString = BuildConnection();

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var command = new NpgsqlCommand("SELECT * FROM humanresources.department WHERE departmentid = @v1", conn))
                {
                    command.Parameters.AddWithValue("v1", departmentId);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        return new PG_Department
                        {
                            DepartmentId = reader.GetInt16(0),
                            Name = reader.GetString(1),
                            GroupName = reader.GetString(2),
                            ModifiedDate = reader.GetDateTime(3)
                        };
                    }
                    reader.Close();
                    return null;
                }
            }
        }
        public int AddDepartment(string name, string groupName)
        {
            string connString = BuildConnection();

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var command = new NpgsqlCommand("INSERT INTO humanresources.department (name, groupname, modifieddate) VALUES (@v1, @v2, @v3) RETURNING departmentid;", conn))
                {
                    command.Parameters.AddWithValue("v1", name);
                    command.Parameters.AddWithValue("v2", groupName);
                    command.Parameters.AddWithValue("v3", DateTime.Now);

                    int departmentId = Convert.ToInt32(command.ExecuteScalar());
                    return departmentId;
                }
            }
        }

        public void DelDepartment(int departmentId)
        {
            string connString = BuildConnection();

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var command = new NpgsqlCommand("DELETE FROM humanresources.department WHERE departmentId = @v1", conn))
                {
                    command.Parameters.AddWithValue("v1", departmentId);                    

                    int nRows = command.ExecuteNonQuery();
                }
            }
        }

        public void UpdDepartment(int departmentId, string name, string groupName)
        {
            string connString = BuildConnection();

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var command = new NpgsqlCommand("UPDATE humanresources.department SET name = @v1, groupName = @v2, modifieddate = @v3 WHERE departmentId = @v4", conn))
                {
                    command.Parameters.AddWithValue("v1", name);
                    command.Parameters.AddWithValue("v2", groupName);
                    command.Parameters.AddWithValue("v3", DateTime.Now);
                    command.Parameters.AddWithValue("v4", departmentId);

                    int nRows = command.ExecuteNonQuery();
                }
            }
        }
    }
}
