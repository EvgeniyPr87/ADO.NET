using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.IO;

namespace ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем соединение с БД Movies_SPU 411  connection_string берем из настрокек БД и записываем в переменную
            string connection_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"Movies_SPU 411\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connection_string);
            string cmd = "SELECT title, year, first_name, last_name FROM Movies JOIN Directors ON(director=director_id)";

            //string table = "Directors";
            string table = "Movies";
            Connector connector = new Connector(connection_string);
            connector.Select("title,year,first_name,last_name", "Movies,Directors","director=director_id");
            Console.WriteLine("\n -------------------------------------------\n");
            //Console.WriteLine(connector.Scalar("SELECT MAX(director_id) FROM Directors"));
            Console.WriteLine(connector.GetLastPrimaryKey(table));
            Console.WriteLine(connector.GetNextPrimaryKey(table));
            //Console.WriteLine(connector.GetPrimaryKeyColumn("Directors"));
            //connector.Insert("Directors", "6, N'Tarantino', N'Quentin'");
            connector.Insert("Directors",$"{ connector.GetNextPrimaryKey("Directors")},N 'Besson', N'Luc'");
            //connector.Update("Directors", "first_name", "Quentin", "last_name=N'Tarantino'");
            //connector.Select("*", "Directors");
            //connector.Select(cmd);


        } 
    }
}
