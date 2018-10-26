using ChoreApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projChorez
{
    public class Chore : IChores
    {

        public string choreName;
        public int choreDifficulty;
        public static List<Chore> choreList = new List<Chore>(); //a list of roommate objects


        public Chore()
        {
           
        }

        public Chore(string _cName, int _cDiff)
        {
            choreName = _cName;
            choreDifficulty = _cDiff;
        }


        /* Initializes choreList of the program
         */
        public void Initialize()
        {
            Console.WriteLine("Please enter the number of Chores for your household");
            Console.WriteLine("");
            int numOfChores = Convert.ToInt32(Console.ReadLine()); //getting user input for number chores          
            Console.WriteLine("Thank you for your input, I see you have " + numOfChores + " chores to complete in your house.");
            Console.WriteLine("");
            //need to create logic here to create an array based off of how many chores are entered
            //ex numOfChores = 5, array would be initialized to [4] with index[0] starting at 1 and index[4] ending at numOfChores
            //when a user sets a chore difficulty, remove that element from the array, and only let them assign from the remaining numbers
            //ex: User selects difficulty level 5 for chore "dishes", for next chore "garbage" options would not list 5 as an option
            //choreDifficulties[numOfChores] 
            //^^ populate with loop starting at 1 going to numOfChores
            //{1,2,3,4,5}
            //if (5 selected)
            //{remove 5 from list, maybe even shrink the array for memory issues?....}
            //enter next chore name
            //list options, {1,2,3,4}
            //user selects 2
            //remove 2, new list is {1,2,3,4}
            //not sure how to slowly shrink list, might just use a different method to assign difficulty, wanted to get this down on paper while it was fresh in my mind

            //loop until less than(not equal to, we dont want it to go +1 times), numofRoommates, add to roommateList list, starting at index 0
            for (int i = 0; i < numOfChores; i++)
            {
                Console.WriteLine("Please enter a chore name.");
                Console.WriteLine("");
                string cName = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Please enter the difficulty level for completing" + cName + " .");
                Console.WriteLine();
                int cDiff = Convert.ToInt32(Console.ReadLine());
                /*
                 * is using a constructor a viable option for a (Create method?...)
                 * feel like it should be, creating the object... unsure for now, going to leave it just using constructor
                 * Leaving it this way, may change later, more and more I think about it, can't find a reason why I would make a separate method to do exactly what a constructor is going to do
                */
                Chore chore = new Chore(cName, cDiff);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Thank you! I have added the chore " + cName + " which has a difficulty level of " + cDiff + " to the list of current chores.");
                Console.WriteLine("");
                Console.ResetColor();
            }
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        /*
         * Prints a list of all objects in the ChoreList list
         */
        public void List()
        {
            Console.WriteLine("All of the chores I have added are listed below");
            Console.WriteLine();
            for (int i = 0; i < choreList.Count; i++)
            {
                Console.WriteLine(choreList[i].ToString());
                Console.WriteLine();
            }

        }

        public override string ToString()
        {
            return  choreName + " " + choreDifficulty.ToString();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Verify()
        {
            throw new NotImplementedException();
        }
    }
}
