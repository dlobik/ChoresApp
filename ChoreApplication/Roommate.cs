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
        private string name;
        private char gender; //either M or F --- this doesn't really matter, just want to test having more than one field for furture builds
        List<Roommate> roommateList = new List<Roommate>();
        private int numOfRoommates = 0;
        private List<int> assignedChores = new List<int>();

        public Roommate()
        {

        }

        public Roommate(string name_, char gender_)
        {
            name = name_;
            gender = gender_;
        }

        /* 
         * Initializes RoommateList for the program
         */
        public List<Roommate> Initialize(int numOfRoommates)
        {
            //loop until less than(not equal to, we dont want it to go +1 times), numofRoommates, add to roommateList list, starting at index 0
            for (int i = 0; i < numOfRoommates; i++)
            {
                Console.WriteLine("Please enter the name of a roommate.");
                Console.WriteLine("");
                string name = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Please enter " + name + "'s gender.");
                Console.WriteLine("");
                char gender = Console.ReadKey().KeyChar;
                Console.WriteLine("");
                Roommate roommate = new Roommate(name, gender);
                roommateList.Add(roommate);
                Console.WriteLine("Thank you! I have added " + name + " " + gender + " to the list of current roommates.");
                Console.WriteLine("");
            }
            return roommateList;
        }

        public int GetNumberOfRoommates()
        {
            Console.WriteLine("Please enter the number of roommates in your household");
            Console.WriteLine("");
            numOfRoommates = Convert.ToInt32(Console.ReadLine()); //getting user input for number chores
            Console.WriteLine("Thank you for your input, I see you have " + numOfRoommates + " roommates in your house.");
            Console.WriteLine("");

            return numOfRoommates;
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        /*
         * Prints a list of all objects in the RoommateList list
         */
        public void List(List<Roommate> roommateList_)
        {
            Console.WriteLine("All of the roommates I have added are listed below");
            Console.WriteLine();
            for (int i = 0; i < roommateList_.Count; i++)
            {
                Console.WriteLine(roommateList_[i].ToString());
                Console.WriteLine();
            }
        }

        public void Verify()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return name + " " + gender.ToString();
        }

        public string GetName(Roommate roommate)
        {
            return roommate.name;
        }

        public void AssignChore(Roommate roommate, int choreIndex)
        {
            roommate.assignedChores.Add(choreIndex);
        }
    }
}
