using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projChorez
{
    class Roommate
    {

        //how do I want to handle adding a roommate?
        //if I'm going to store **chores** in a list of type chore....
        //I might as well store **roommates** in a list of type roommates.


        private string name;
        private char gender; //either M or F --- this doesn't really matter, just want to test having more than one field for furture builds

        public static List<Roommate> roommateList = new List<Roommate>(); //roommates and their gender


        public Roommate(string name_, char gender_)
        {
            name = name_;
            gender = gender_;
        }
        private static void AddRoommate(string name_, string gender_)
        {

        }
        public static void AddRoommates()
        {


        }

        //create method 
        //VERIFY ROOMMATES
        //gives user option to clear out current roommates entered
    }
}
