using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreApplication
{
    public interface IChores
    {
        //void Initialize(); //add a roommate/ chore to the list 
        void Delete(); //self explanatory, not sure wether to go by list index, or to search list for name / chore? unsure at this moment
        void Update(); //may not use, vision is to be able to update a roommate, might be better when this isn't a console application

        //void List(); //Lists all current objects in the LIST
        string ToString(); //standard ToString method to print out the objects in console
        void Verify(); //allows user to start over if they don't like what they have entered, clears both arrays, starts fresh with Add();
    }
}
