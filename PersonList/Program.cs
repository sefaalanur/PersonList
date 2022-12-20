using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace PersonList
{
    class Program
    {
        static void Main(string[] args)
        {
            testConnection();
            Console.ReadKey();
        }
        private static void testConnection()
        {
            using (NpgsqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        Console.WriteLine("Connected");
                    }

                }
                catch (NpgsqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5434;User Id=postgres;Password=sefa2024;Database=PhoneContact");
        }
    }
}
