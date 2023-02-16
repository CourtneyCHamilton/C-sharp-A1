using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Pet
    {
        private string name; //name of the pet
        private int age; //age of pet as integer
        private bool isFemale; //true if female, false otherwise

        public void getPetName() 
        {
            Console.WriteLine("What's your pet's name? ");
            name = Console.ReadLine();
            Console.WriteLine("That's a cool name!");
        }

        public void getPetAge()
        {
            Console.WriteLine("How many years old is " + name + "? ");
            age = int.Parse(Console.ReadLine());
        }

        public void getPetGender()
        {
            Console.WriteLine("Okay. Is " + name + " female? (y/n)");
            string strGender = Console.ReadLine();
            char response = strGender[0];

            if ((response == 'y') || (response == 'Y'))
            {
                isFemale = true;
                Console.WriteLine("Okay. " + name + " is female.");
            }
            else
            { 
                isFemale = false;
                Console.WriteLine("Okay. " + name + " is not female.");
            }
        }

        public void getPetData()
        {
            getPetName();
            getPetAge();
            getPetGender();
        }

        public void DisplayPetData()
        {
            Console.WriteLine("Your pet's name is: " + name + ". " + name + " is " + age + " years old!");
        }

        public void Start()
        {
            Console.WriteLine("Tell me about your pet! :) ");
            getPetData();
            DisplayPetData();
        }
    }
}
