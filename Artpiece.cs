using System;
using System.Collections.Generic;
using System.Text;

namespace CGS_Part1
{
    class Artpiece
    {
        string artpieceId, curatorId, artistId, title;
        int year;
        double value, estimate;
        char status;

        public Artpiece(string artpieceId, string curatorId, string artistID, 
            string title, int year, 
            double value) {
            this.artpieceId = artpieceId;
            this.curatorId = curatorId;
            this.artistId = artistID;
            this.title = title;
            this.year = year;   
            this.value = value;
            this.estimate = 0.0; //as per pdf instructions
            this.status = 'D'; //as per pdf instructions
        }

        // NO NEED of properties for curatorID and artistID because
        // they come from other classes
        public string ArtpieceId {
            get { return this.artpieceId; }
            set { this.artpieceId = value; }
        }

        public string Curatorid
        {
            get { return this.curatorId; }  
            set { this.curatorId= value; }
        }

        public string ArtistId
        {
            get { return this.artistId; }
            set { this.artistId = value; }
        }

        public string Title {
            get { return this.title; }
            set { this.title = value; }
        }

        public int Year {
            get { return this.year; }
            set { this.year = value; }
        }

        public double Value {
            get { return this.value; }
            set { this.value = value; }
        }

        public double Estimate {
            get { return this.estimate; }
            set { this.estimate = value; } 
        }

        public char Status {
            get { return this.status; }
            set { this.status = value; }
        }

        public string toString() { 
            return ArtpieceId + " " + this.curatorId + " " +
                this.artistId + " " + Title + " " + Year + " " + 
                Value + " " + Estimate + " " + Status;
        }

        public string getID() {
            return ArtpieceId;
        }

        public void changeStatus(char status) { 
            Status = status;  
        }

        public double calculateCommission(double price) {
            return (price - Value) * 0.25;
        }
    }
}
