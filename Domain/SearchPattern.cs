using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SearchPattern
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string regularExpression;

        public string RegularExpression
        {
            get { return regularExpression; }
            set { regularExpression = value; }
        }
        string action;

        public string Action
        {
            get { return action; }
            set { action = value; }
        }
        string compareWith;

        public string CompareWith
        {
            get { return compareWith; }
            set { compareWith = value; }
        }

        public override string ToString()
        {
            return RegularExpression + " " + CompareWith + " " + Action;
        }

    }
}
