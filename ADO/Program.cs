using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient; 

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

            Connector connector = new Connector(connection_string);
            connector.Select(cmd);

        } 
    }
}
