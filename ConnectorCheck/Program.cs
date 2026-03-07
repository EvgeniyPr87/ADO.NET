using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConnectorCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string connection_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"Movies_SPU 411\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            Connector. Connector connection = new Connector.Connector (connection_string);

            connection.Select("SELECT * FROM Directors");

            //connection.Insert("\"Directors\", \"6, N'T', N'Quen'");
        }
    }
}
