using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
                @"Data Source=DESKTOP-MPTGS57\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlConnection connection = sqlConnection;
            connection.Open();


            CRUD cRUD = new CRUD();
            cRUD.Read(connection);
            Console.WriteLine("-------------------------");
            // cRUD.Create(13, "slask", connection);
            //   cRUD.Update(13, "slask_2", connection);
            //   cRUD.Delete(13, connection);
            connection.Close();
        }
    }
}