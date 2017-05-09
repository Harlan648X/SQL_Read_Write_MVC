using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SQL_Read_Write_MVC.Models
{
    public class SqlDAL
    {
        //public string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = mvc_test;
        //    User ID = te_student; Password = sqlserver1";
        public string connectionString = @"Server=fe8f23d8-86b4-4f47-941b-a76e00ae83f8.sqlserver.sequelizer.com;Database=dbfe8f23d886b44f47941ba76e00ae83f8;User ID=zuekqyqosuhmvdnf;Password=XijFrPPEQFd7XAY5AeQZ6kmnSZUU2ksBDWdpvbnqhLSf4PSr8vcUyPqL66Vy33LD;";



        public void Write2DB(RecordInfo record)
        {
            string SQL_Write2DB = "INSERT INTO testdata VALUES(@input, @daytime);";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_Write2DB, conn);
                    cmd.Parameters.AddWithValue("@input", record.Input);
                    cmd.Parameters.AddWithValue("@daytime", record.DayTime);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
        }

        public List<RecordInfo> ReadDB()
        {
            List<RecordInfo> result = new List<RecordInfo>();
            string SQL_ReadDB = "SELECT * from testdata;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_ReadDB, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        RecordInfo temp = new RecordInfo();

                        temp.Input= reader["input"].ToString();
                        temp.DayTime = (DateTime)reader["daytime"];

                        result.Add(temp);
                    }

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }

            return result;
        }

    }
}