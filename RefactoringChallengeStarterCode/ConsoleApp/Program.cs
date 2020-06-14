using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string actionToTake = "";
            
            MainDisplay(actionToTake);
        }
        static void MainDisplay(string actionToTake)
        {
            do
            {
                Console.Write("What action do you want to take (Display, Add, or Quit): ");
                actionToTake = Console.ReadLine();

                switch (actionToTake.ToLower())
                {
                    case "display":

                        var records = ConnectionFactory.GetConnection()
                            .Query<UserModel>("spSystemUser_Get", commandType: CommandType.StoredProcedure).ToList();

                        Console.WriteLine();
                        records.ForEach(x => Console.WriteLine($"{ x.FirstName } { x.LastName }"));

                        Console.WriteLine();
                        break;
                    case "add":
                        Console.Write("What is the first name: ");
                        string firstName = Console.ReadLine();

                        Console.Write("What is the last name: ");
                        string lastName = Console.ReadLine();

                        var p = new
                        {
                            FirstName = firstName,
                            LastName = lastName
                        };

                        ConnectionFactory.GetConnection().Execute("dbo.spSystemUser_Create", p, commandType: CommandType.StoredProcedure);

                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
            } while (actionToTake.ToLower() != "quit");
            // Close the connection to the database
            ConnectionFactory.CloseDbConnection();
        }
    }
}
