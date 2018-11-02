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
        public int numOfChores = 0;
        public int totalChoreDifficulty = 0;
        List<Chore> choreList = new List<Chore>(); //dont need this - yes wait i do


        //I need to get the ideal choreDifficulty score eventually, not sure when or where I should calculate that
        //..... should do it after I get the "numOfChores" , total cDifficulty would be the summation of numOfChores

        public Chore()
        {
           
        }

        public Chore(string _cName, int _cDiff)
        {
            choreName = _cName;
            choreDifficulty = _cDiff;
        }

        public void Assign()
        {
            
            for (int i = 0; i < choreList.Count; i++)
            {
                Random random = new Random();  //chore that is going to be assigned to roommate
            }

            /*
             *   
             *   if (individual roommates cDiff is greater than the tolerance we set)
                 {
                    restart, no good, reassign
                    so say we have 3 roommates, first roommate assigns, within the tolerance
                    second roommate assigns, no good, too high of a chore score, reassign him until he's within the tolerance
                    ***What is the calculation to find the tolerance? Some equation based off of #ofRoommates and totalChoreDifficulty....
                 }
             */



        }

        /* Initializes choreList of the program
         */
        public List<Chore> Initialize(int numOfChores)
        {

            int[] choreDifficulty = new int[numOfChores]; // giving the user options for choosing chore difficulty
            for (int i = 0; i < choreDifficulty.Length; i++)
            {
                choreDifficulty[i] = i + 1; //i + 1 because i will start at 0 like array index does, so start at array[0] but with value of 1
            }

            for (int i = 0; i <= numOfChores; i++) //getting our total chore difficulty so we can divide by the "numOfRoommates" to get our fair cDiff number
            {
                totalChoreDifficulty += i;
            }
            //read notepad++ documentation on chore assignment algorithm
            Console.WriteLine("Please enter a chore name, followed by a difficulty for the entered chore."); //instructing user on how to enter chores in
            Console.WriteLine("The chore difficulty will range from " + choreDifficulty[0] + " to " + choreDifficulty.Max()); //telling the user what the range to assign chores is

            //loop until less than(not equal to, we dont want it to go +1 times), numOfChores, add to choreList, starting at index 0
            for (int i = 0; i < numOfChores; i++)
            {
                Console.WriteLine("Please enter a chore name.");
                Console.WriteLine("");
                string cName = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Please enter the difficulty level for completing " + cName + " .");
                // whatever value the user picks, take value -1 and remove that index from the array (ex: user picks 5, remove index 4 from array... would be 5)
                Console.WriteLine();
                int cDiff = Convert.ToInt32(Console.ReadLine());
                Chore chore = new Chore(cName, cDiff); //creating a new chore object based off of user input
                choreList.Add(chore);
                Console.ForegroundColor = ConsoleColor.Red; //messing around with something I found on reddit
                Console.WriteLine("Thank you! I have added the chore " + cName + " which has a difficulty level of " + cDiff + " to the list of current chores.");
                Console.WriteLine("");
                Console.ResetColor();
            }

            return choreList;
        }

        public int GetTotalDifficulty(List<Chore> choreList)
        {
            int totalDifficulty = 0;
            for (int i = 0; i < choreList.Count; i++)
            {
                totalDifficulty += choreList[i].choreDifficulty;
            }

            return totalDifficulty;
        }

        public int GetNumberOfChores()
        {
            Console.WriteLine("Please enter the number of Chores for your household");
            Console.WriteLine("");
            numOfChores = Convert.ToInt32(Console.ReadLine()); //getting user input for number chores
            Console.WriteLine("Thank you for your input, I see you have " + numOfChores + " chores to complete in your house.");
            Console.WriteLine("");         

            return numOfChores;

        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        /*
         * Prints a list of all objects in the ChoreList list
         */
        public void List(List<Chore> choreList_)
        {
            Console.WriteLine("All of the chores I have added are listed below");
            Console.WriteLine();
            for (int i = 0; i < choreList_.Count; i++)
            {
                Console.WriteLine(choreList_[i].ToString());
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
