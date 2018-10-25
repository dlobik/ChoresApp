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

        public Chore()
        {
           
        }

        public Chore(string _cName, int _cDiff)
        {
            choreName = _cName;
            choreDifficulty = _cDiff;
        }


        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void List()
        {
            throw new NotImplementedException();
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
