using System;
using System.Collections.Generic;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Alice", "Johnson", new DateTime(1990, 2, 6), Gender.Female);
            Console.WriteLine(person.ToString());
            //
            Console.WriteLine("And now she is " + person.Age + (person.Age == 1 ? " year" : " years") + " old");
            //
            person.AdoptPet("Baron");
            person.AdoptPet("Murchik");
            Console.WriteLine(person.ToString() + " Does she have pets : " + (person.HasPets ? "Yes" : "No"));
            Console.WriteLine(person.GetPetsName());

            //
            var GreatGrandParent = new Person("Pericles Aalders")
            {
                Child = new List<Person>()
            {
                new Person("Nou Wendel"),
                new Person("Draga Gagnier")
                {
                    Child = new List<Person>()
                    {
                        new Person ("Pol Roma")
                    }
                },
                new Person("Jean - Michel Reich")
                {
                    Child = new List<Person>()
                    {
                        new Person ("Paramonos Kron"),
                        new Person("Taavi Metaxas")
                        {
                            Child = new List<Person>()
                            {
                                new Person ("Philippos Dirks"),
                                new Person ("Prudentius Hagen"),
                                new Person ("Jordan Fowler")
                            }
                        }
                    }
                },
                new Person("Vilma Hutson")
                {
                    Child = new List<Person>()
                    {
                        new Person ("Benita Ganza"),
                    }
                },

            }
            };

            FamilyTree.ShowFamily(GreatGrandParent);
            //

        }

    }
}
