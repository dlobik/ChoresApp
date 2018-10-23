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

        public Roommate()
        {

        }

        public Roommate(string name_, char gender_)
        {
            name = name_;
            gender = gender_;
        }

        public void Add()
        {
            throw new NotImplementedException();
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
    }
}
