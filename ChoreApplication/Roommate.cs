using ChoreApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projChorez
{
    class Roommate : IChores
    {

        //how do I want to handle adding a roommate?
        //if I'm going to store **chores** in a list of type chore....
        //I might as well store **roommates** in a list of type roommates.


        private string name;
        private char gender; //either M or F --- this doesn't really matter, just want to test having more than one field for furture builds
        public static List<Roommate> roommateList = new List<Roommate>(); //a list of roommate objects

        public Roommate()
        {

        }

        public Roommate(string name_, char gender_)
        {
            name = name_;
            gender = gender_;
        }

        public void Initialize(string rName_, char r_Gender)
        {
            Console.WriteLine("Please enter the number of roommates in your household.");
            Console.WriteLine("");
            int numOfRoommates = Convert.ToInt32(Console.ReadLine()); //getting user input for number of roommates
            //string[] roommates = new string[numOfRoommates]; //creating array to store roommate names based off the size of user input 10/25 - not used
            Console.WriteLine("Thank you for your input, I see you have " + numOfRoommates + " roommates in your house.");
            Console.WriteLine("");

            //loop until less than(not equal to, we dont want it to go +1 times), numofRoommates, add to roommateList list, starting at index 0
            for (int i = 0; i < numOfRoommates; i++) 
            {
                Console.WriteLine("Please enter the name of a roommate.");
                Console.WriteLine("");
                string name = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Please enter " + name + "'s name.");
                Console.WriteLine();
                char gender = Console.ReadKey().KeyChar;
                Roommate roommate = new Roommate(name, gender);  //is using a constructor a viable option for a (Create method?...) ... feel like it should be, creating the object... unsure for now, going to leave it just using constructor
                Console.WriteLine("Thank you! I have added " + name + " " + gender + " to the list of current roommates.");
                Console.WriteLine("");               
            }
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void List()
        {
            throw new NotImplementedException();
        }

        public void Verify()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return name + " " + gender.ToString();
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}
