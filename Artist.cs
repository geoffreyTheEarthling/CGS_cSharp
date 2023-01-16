using System;
using System.Collections.Generic;
using System.Text;

namespace CGS_Part1
{
    class Artist: Person
    {
        string artistID;

        public Artist(string artistID, string firstname, string lastname) : base(firstname, lastname)
        {
            this.artistID = artistID;
        }

        public string ArtistID { 
            get { return artistID; }
            set { artistID = value; }
        }

        public override string toString()
        {
            return ArtistID + " " + base.toString();
        }

        public string getID()
        {
            return ArtistID;
        }


    }
}
