
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace ConsoleApp1

{
    class CRUD
    {
        public void Create(int id, string regionDescription, SqlConnection connection)
        {
            string sql = "INSERT INTO Northwind.dbo.Region(RegionID,RegionDescription) VALUES (@id,@regionName)";
            var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@regionName", regionDescription);
            command.Parameters.AddWithValue("@id", id);

            int param = command.ExecuteNonQuery();
            if (param > 0)
            {
                Console.WriteLine("Dodano");
            }
        }
        public void Read(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand
            {
                CommandText = "SELECT * FROM Customers",
                Connection = connection
            };
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["CompanyName"]);
            }
        }
        public void Update(int id, string nowa_nazwa, SqlConnection connection)
        {
            string sql = "UPDATE Northwind.dbo.Region SET RegionDescription = @regionName WHERE RegionID=@id";
            var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@regionName", nowa_nazwa);
            command.Parameters.AddWithValue("@id", id);
            int param = command.ExecuteNonQuery();

            if (param > 0)
            {
                Console.WriteLine("Zmieniono");
            }
        }

        public void Delete(int id, SqlConnection connection)
        {
            string sql = "DELETE FROM Northwind.dbo.Region WHERE RegionID=@id";
            var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@id", id);
            int param = command.ExecuteNonQuery();

            if (param > 0)
            {
                Console.WriteLine("Usunieto");
            }
        }

    }
}