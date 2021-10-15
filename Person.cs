using System;
using System.Collections.Generic;
using System.Text;

namespace KlasserObjekt
{
    class Person
    {
        public string name;
        public int age;
        public int weight;
        public int birthYear;
        public int aBirthYear;

        public Person(string aName, int aAge, int aWeight, int birthYear)
        {
            age = aAge;
            name = aName;
            weight = aWeight;
            birthYear = aBirthYear;

            Console.WriteLine($"Namnet är {aName}, Åldern är {aAge}, Vikten är {aWeight}, och födselåret är {aBirthYear}\n");
            Console.WriteLine("_________________________________________________________________________________________\n");
        }
    }

}
