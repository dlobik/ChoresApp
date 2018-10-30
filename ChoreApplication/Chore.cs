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
        public int numOfChores = 0;
        public int totalChoreDifficulty = 0;


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
        }

        /* Initializes choreList of the program
         */
        public void Initialize()
        {
            Console.WriteLine("Please enter the number of Chores for your household");
            Console.WriteLine("");
            numOfChores = Convert.ToInt32(Console.ReadLine()); //getting user input for number chores
            int[] choreDifficulty = new int[numOfChores]; // giving the user options for choosing chore difficulty
            for (int i = 0; i < choreDifficulty.Length; i++)
            {
                choreDifficulty[i] = i + 1; //i + 1 because i will start at 0 like array index does, so start at array[0] but with value of 1
            }

            for (int i = 0; i <= numOfChores; i++) //getting our total chore difficulty so we can divide by the "numOfRoommates" to get our fair cDiff number
            {
                totalChoreDifficulty += i;
            }
            //Console.WriteLine(totalChoreDifficulty); //testing chore difficulty 
            Console.WriteLine("Thank you for your input, I see you have " + numOfChores + " chores to complete in your house.");
            Console.WriteLine("");
            Console.WriteLine("Please assign these chores a difficulty level, it may range from " + choreDifficulty[0] + " to " + choreDifficulty.Max()); //telling the user what the range to assign chores is
            

            //read notepad++ documentation on chore assignment algorithm

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
