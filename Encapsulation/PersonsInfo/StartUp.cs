using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp

    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Person person;
            List<Person> persons = new List<Person>();

            for (int i = 0; i < count; i++)
            {
                string[] personsInfo = Console.ReadLine().Split();
                string firstName = personsInfo[0];
                string secondName = personsInfo[1];
                int age = int.Parse(personsInfo[2]);
                decimal salary = decimal.Parse(personsInfo[3]);

                 person = new Person(firstName, secondName,age ,salary);
                persons.Add(person);
            }
            Team team = new Team("SoftUni");

            

            foreach (Person value in persons)
            {
               
                team.AddPlayer(value);
            }

            Console.WriteLine(String.Join(' ', team.FirstTeam));
            Console.WriteLine(String.Join(' ', team.ReserveTeam));


        }
    }
}
