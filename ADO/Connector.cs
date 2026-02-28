using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace ADO
{
    internal class Connector
    {
        string connection_string;
        SqlConnection connection;
        public Connector(string connection_string)
        {
            this.connection_string = connection_string;
            this.connection = new SqlConnection(connection_string);
        }
        public void Select(string fields, string tables, string condition = "")
        {
            string cmd = $"SELECT {fields} FROM {tables}";
            if (condition != "") cmd += $" WHERE {condition}";
            cmd += ";";
            Select(cmd);
            //connection.Open();       //Открываем соединение

            //SqlCommand command = new SqlCommand(cmd, connection);
            //SqlDataReader reader = command.ExecuteReader(); //создается ридер
            //while (reader.Read())
            //{
            //    //Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}");
            //    for (int i = 0; i < reader.FieldCount; i++)
            //    {
            //        Console.Write(reader[i].ToString().PadRight(28));
            //    }
            //    Console.WriteLine();
            //}
            //reader.Close();            // если был создан ридер !!!обязательно закрываем закрываем ридер
            //connection.Close();      //закрываем соединение
        }

        public void Insert(string table, string values)
        {
            string cmd = $"INSERT INTO {table} VALUES ({values})";
            Insert(cmd);
            //connection.Open();

            //SqlCommand command = new SqlCommand(cmd, connection);
            //command.ExecuteNonQuery();

            //connection.Close();
        }

        public void Update(string table, string field, string value, string condition = "")
        {
            string cmd = $"UPDATE {table} SET {field} = N'{value}'";
            if (condition != "") cmd += $" WHERE {condition}";
            cmd += ";";
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Insert(string cmd)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Select(string cmd)
        {
            connection.Open();       //Открываем соединение

            SqlCommand command = new SqlCommand(cmd, connection);
            SqlDataReader reader = command.ExecuteReader(); //создается ридер
            while (reader.Read())
            {
                //Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}");
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader[i].ToString().PadRight(28));
                }
                Console.WriteLine();
            }
            reader.Close();            // если был создан ридер !!!обязательно закрываем закрываем ридер
            connection.Close();      //закрываем соединение
        }


        public object Scalar(string cmd)
        {
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            object value = command.ExecuteScalar();
            //int value = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return value;
        }

        public string GetPrimaryKeyColumn(string table)
        {
            return (string)Scalar($"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE\r\nWHERE CONSTRAINT_NAME =(SELECT CONSTRAINT_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE TABLE_NAME=N'{table}' AND CONSTRAINT_TYPE=N'PRIMARY KEY');");
        }
        
        public int GetLastPrimaryKey(string table)
        {
            return Convert.ToInt32(Scalar($"SELECT MAX({GetPrimaryKeyColumn(table)}) FROM {table}"));
        }
        public int GetNextPrimaryKey(string table)
        {
            return GetLastPrimaryKey(table)+1;
        }


    }
}
