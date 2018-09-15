using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    public class Dog //Class that's meant to 'create' a 'dog'
    {
        public string name;
        public string owner;
        public int age;
        public gender person; //Not sure why this is used
        public enum gender { Male, Female };

        public Dog(string name, string owner, int age, gender sex)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.person = sex;
        }
        public string GetTag()
        {
            string phrase = null;
            string year = null;
            Dog.gender current = this.person;
            int i = (int)current; 
            string pronoun = null;
            string pronoun2 = null;

            if (age == 1)
                year = "year";
            else if (age > 1)
                year = "years"; //Owner, his/her, name, he/she, age, year/years

            if(i == 0)
            {
                pronoun = "His";
                pronoun2 = "he";
            }
            else
            {
                pronoun = "Her";
                pronoun2 = "she";
            }
            phrase = $"If lost, call {owner}. {pronoun} name is {name} and {pronoun2} is {age} {year} old.";
            return phrase;
        }
        public void Bark(int woofs) //Kind of works
        {
            int counter;
            for (counter = 1; counter <= woofs; counter++)
                Console.WriteLine("Woof!");
        }
    }
    public class Program
    {        
        static void Main(string[] args)
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, Dog.gender.Male);
            puppy.Bark(3);
            Console.WriteLine(puppy.GetTag());
            Console.WriteLine("\t");

            Dog bigDog = new Dog("Lileu", "Dale", 4, Dog.gender.Female);
            puppy.Bark(1);
            Console.WriteLine(bigDog.GetTag());
            Console.ReadLine();
        } 
    }
}
