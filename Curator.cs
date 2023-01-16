using System;
using System.Collections.Generic;
using System.Text;

namespace CGS_Part1
{
    class Curator: Person
    {
        string curatorID;
        double commission;
        const double COMMRATE = 0.10;

        public Curator(string curatorID, double commission, string firstname, 
            string lastname):base(firstname, lastname)
        {
            this.curatorID = curatorID;
            this.commission = commission;
        }

        public string CuratorID {
            get { return curatorID; } 
            set { curatorID = value; } 
        }
        public double Commission { 
            get { return commission; }
            set { commission = value; }
        }

        //public string commRate { get; set; }  
        //NO NEED of get and set for CommRate since it is a CONSTANT 

        public override string toString()
        {
            return CuratorID + " " + Commission + " " + base.toString(); 
        }
        public string GetID()
        {
            return CuratorID;
        }

        public void ClearCommmand()
        {
            Console.Clear();
        }

        public void SetComm(double comm)
        {
            Commission += comm;
        }

    }
}
