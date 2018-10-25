using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projChorez
{
    class Program
    {
        //essentially what we want to do, is create objects in the main program, that we are able to use to perform methods listed in individual classes
        //**not sure if I should be storing the lists for chores and roommates in the invidivual classes, or if I should be creating two lists
        //**in this main method of the program, and storing the data that way

        //side thought --- if I store the data in the main program, 

        //creating a new object in the main class --- with the constructor from the sub class --- THEN call the add method from the sub class, to take the newly created object, and insert it INTO 
        //the list that we have in local memory created in this main class

        public static List<Chore> choreList = new List<Chore>(); //a list of chore objects
        //public static List<Roommate> roommateList = new List<Roommate>(); //a list of roommate objects
       


        //**moved these up here becasue I want to create methods for all of the code in (MAIN) method**
        public static int numOfRoommates = 0; //number of roommates living in the house **** this can become List<Roomates>.Size()
        public static int numOfChores = 0; // **new thought - this can become List<Chores>.Size()


        public static void Main(string[] args)
        {
             Roommate _roommate = new Roommate();

        /* 
         * Welcoming user to the program
         */
            Console.WriteLine("Welcome to RJ's Chore Program!");
            Console.WriteLine("");
            Console.WriteLine("Please press any key to continue and start this program!");
            Console.WriteLine("");
            Console.ReadKey();
            _roommate.Initialize();

           
            /* 
             * Printing out what is stored in the roommateList list
             */
            Console.WriteLine("All of the roommates I have added are listed below");
            Console.WriteLine();
            for (int i = 0; i < roommates.Length; i++)
            {
                Console.WriteLine(roommateList[i].ToString());
                Console.WriteLine();
            }


            /* 
             * Transition period from roommate adding to chore adding
             */
            Console.WriteLine("Thank you! All of the roommates have now been added, please press any key to continue this program.");
            Console.WriteLine("");
            Console.ReadKey();
            Console.WriteLine("");

            /* 
             * Adding chores to the chore array
             */
            Console.WriteLine("Excellent. Lets move forward and add what chores we need to accomplish");
            Console.WriteLine("Please enter the number of chores to complete in your household.");
            Console.WriteLine("");
            int numOfChores = Convert.ToInt32(Console.ReadLine()); //getting user input for number of chores
            string[] chores = new string[numOfChores]; //creating array to store chores names based off the size of user input
            Console.WriteLine("Thank you for your input, I see you have " + numOfChores + " chores to be completed in your house.");
            Console.WriteLine("");
            for (int i = 0; i < numOfChores; i++) //loop until less than(not equal to, we dont want it to go +1 times), numOfChores, add to chores array, starting at index 0
            {
                Console.WriteLine("Please enter the name of a Chore.");
                Console.WriteLine("");
                string chore = Console.ReadLine();
                chores[i] = chore;
                Console.WriteLine("Thank you! I have added " + chore + " to the list of current roommates.");
                Console.WriteLine("");
            }

            /* 
             * Printing out what is stored in the chores array
             */
            Console.WriteLine("All of the chores I have added are listed below");
            Console.WriteLine();
            for (int i = 0; i < chores.Length; i++)
            {
                Console.WriteLine(chores[i]);
                Console.WriteLine();
            }

            /* 
             * Assign chores to individual roommates (randomly)
             * number of chores / number of roommates (change this to chore difficulty later)
             * if CD / roommates - that's CP that would be if everyone was evenly split
             * assign randomly
             * check to make sure it's within a certain tolerance of average CP (lets say 5 CPs)
             * if someone has too many CP's, adjust
             */
          

        }
    }
}






//AddRoommates();
//***TODO
//verify roommates
//Console.WriteLine("Is this correct? Please type (Y) if yes, or (N) if incorrect.");
//            ConsoleKeyInfo cki;
//cki = Console.ReadKey();
//            Console.WriteLine();

//            /* Check user input to know if they are happy with their entered roommates */
//            if (cki.Key == ConsoleKey.N)
//            {
//                Console.WriteLine("I am so sorry that you made an error. Press any key to exit program and restart."); //figure out a way to empty array and start loop again
//                Console.ReadKey();
//                Environment.Exit(0);
//            }


//            Console.WriteLine("Awesome! We have all of your roommates added, please press any key to continue.");
//            Console.WriteLine();
//            Console.ReadKey();
//            Console.WriteLine("Let's continue! Please enter the number of Chores...");
//            Console.WriteLine();
//            numOfChores = Convert.ToInt32(Console.ReadLine());
//            //loop through number of chores, or while loop, and just have the
//            //add chore method add the passed in values into the list
//            for (int i = 0; i<numOfChores; i++)
//            {
//                Console.WriteLine("Please enter the name of the chore ");
//                Console.WriteLine();
//                string name = Console.ReadLine();
//Console.WriteLine();
//                Console.WriteLine("Please enter the difficulty of the chore name " + name + ".");
//                Console.WriteLine();
//                int diff = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine();
//                //AddChore(name, diff);              
//            }
//            choreList.ForEach(Console.WriteLine); //this doesnt ToString() the chore name and difficulty, need to write tostring method in chore class to fix