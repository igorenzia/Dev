using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;



namespace Mysql_console_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Page_load();
            Console.WriteLine(" вы точно хотите выйти Y/N");
            if (Console.ReadLine() == "y") { return; }
            else
            {
                Page_load();
            }

        }

        static void Page_load()
        {
            Console.WriteLine("Добро пожаловать вас приветствует монитор SQL");
            Console.WriteLine("----------для выхода нааберите  exit---------");
            Console.WriteLine("---------------Libcode-----------------------");
            Console.WriteLine("введите сервер");
            string server = Console.ReadLine();
            Console.WriteLine("введите базу");
            string basa = Console.ReadLine();
            Console.WriteLine("введите логин");
            string login = Console.ReadLine();
            Console.WriteLine("введите пароль");
            string pass = Console.ReadLine();
            while (true)
            {
                try
                {

                    // yoda.beget.ru
                    string conn = "SERVER="+server+";" + "DATABASE="+basa+";" + "UID="+login+";" + "PASSWORD="+pass+";";
                    MySqlConnection con = new MySqlConnection(conn);
                    MySqlCommand cmd = con.CreateCommand();
                    MySqlDataReader reader;
                    Console.Write("mysql>>");
                    //Console.WriteLine("show tables");
                    cmd.CommandText = Console.ReadLine();
                    switch (cmd.CommandText)
                    {
                        case "help":
                            {
                                Console.WriteLine("Select * from TableName");
                            }
                            break;

                        
                    }
                    if (cmd.CommandText == "exit") return;
                    con.Open();
                    Console.WriteLine("выполняю запрос.......");
                    reader = cmd.ExecuteReader();
                    string row = "";
                    // string field = "";

                    while (reader.Read())
                    {
                        row = "";
                        //field = "";
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            //field += reader.GetName(i).ToString() + "|";
                            row += reader.GetString(i).ToString() + " | ";

                        }
                        // Console.WriteLine(field);
                        Console.WriteLine(row);

                    }
                    con.Close();

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }

    }

}
