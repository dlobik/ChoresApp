﻿using System;
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

        public static void Main(string[] args)
        {
            Roommate _roommate = new Roommate();
            Chore _chore = new Chore();

            List<Chore> choreList = new List<Chore>(); //a list of roommate objects
            List<Roommate> roommateList = new List<Roommate>();
            int numOfRoommates = 0;
            int numOfChores = 0;
            int totalChoreDifficulty = 0;

            /* 
             * Welcoming user to the program
             */
            Console.WriteLine("Welcome to RJ's Chore Program!");
            Console.WriteLine("");
            Console.WriteLine("Please press any key to continue and start this program!");
            Console.WriteLine("");
            Console.ReadKey();
            /* 
            * Adding roommates to the roommate list
            */

            numOfRoommates = _roommate.GetNumberOfRoommates();
            roommateList = _roommate.Initialize(numOfRoommates);

            /* 
            * Printing out what is stored in the roommateList list
            */

            _roommate.List(roommateList);


            /* 
             * Transition period from roommate adding to chore adding
             */
            Console.WriteLine("Thank you! All of the roommates have now been added, please press any key to continue this program.");
            Console.WriteLine("");
            Console.ReadKey();
            Console.WriteLine("");

            /* 
             * Adding chores to the chore List
             */
            numOfChores =_chore.GetNumberOfChores();
            choreList = _chore.Initialize(numOfChores);
            totalChoreDifficulty = _chore.GetTotalDifficulty(choreList);
            Console.WriteLine("The total difficulty of all chores is " + totalChoreDifficulty);

            /* 
             * Printing out what is stored in the chores array
             */
            _chore.List(choreList);
            Console.ReadKey();
            /* 
             * Assign chores to individual roommates (randomly)
             * number of chores / number of roommates (change this to chore difficulty later)
             * if CD / roommates - that's CP that would be if everyone was evenly split
             * assign randomly
             * check to make sure it's within a certain tolerance of average CP (lets say 5 CPs)
             * if someone has too many CP's, adjust
             */
            Console.WriteLine("Now for the fun part! We need to assign chores!");
            Console.WriteLine();


            //assign roommates random #'s in an array
            //loop through each roommates array and compare that number

            //roommate[i].name has to complete the following chores
            //loop roommate.assignedChores[]


            //testing / determining how I want assignment method to work
            //this will eventually be moved to chore class
            for (int i = 0; i < roommateList.Count; i++)
            {
                List<Chore> _choreList = new List<Chore>();
                string rName = _roommate.GetName(roommateList[i]); //get the first roommate in the roommate list
                Random random = new Random();
                int randomNumber = random.Next(0, numOfRoommates);
                string cName = _chore.GetName(_choreList[randomNumber]);
                int diff = _chore.GetDiff(_choreList[randomNumber]);

                //I need the roommate at index I to have the chore index added to his List<int>
                Roommate _roommate2 = roommateList[i];
                _roommate2.AssignChore(_roommate2, randomNumber);
                
            }
           



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