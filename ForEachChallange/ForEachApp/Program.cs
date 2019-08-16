using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleLibrary;

namespace ForEachApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PeopleList peopleList = PeopleList.Instance;
            foreach (var item in peopleList.PeoplesList)
            {
                Console.WriteLine($"Hello {item}");
            }
            Console.WriteLine("* * * Bonus ForEach Challange * * *");
            // Bonus foreach challange
            People people = People.Instance;
            people.PopulatePeopleList();
            foreach (var person in people.Peoples)
            {
                Console.WriteLine($"Hello {person.FirstName} {person.LastName}");
            }
            // Allow the user to close the console
            Console.ReadKey();
        }
    }
}
