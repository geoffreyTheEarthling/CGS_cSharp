using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Text;

namespace CGS_Part1
{
    public class Gallery
    {
        public Gallery() { }

        Curators myCurators = new Curators();
        Artists myArtists = new Artists();
        Artpieces myArtpieces = new Artpieces();

        public bool curatorIdVerifier(string cID)
        {
            bool flag = false;
            foreach (Curator cur in myCurators)
            {
                if (cur.GetID() == cID)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public bool curatorNameVerifier(string firstname, string lastname)
        {
            bool flag = false;
            if (firstname.Length + lastname.Length > 40)
            {
                flag = true;
            }
            return flag;
        }

        public bool artistIdVerifier(string aID)
        {
            bool flag = false;
            foreach (Artist art in myArtists)
            {
                if (art.getID() == aID)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public bool artistNameVerifier(string firstname, string lastname)
        {
            bool flag = false;
            if (firstname.Length + lastname.Length > 40)
            {
                flag = true;
            }
            return flag;
        }

        public bool pieceNameVerifier(string title)
        {
            bool flag = false;
            if (title.Length > 40)
            {
                flag = true;
            }
            return flag;
        }

        public bool pieceIdVerifier(string pID)
        {
            bool flag = false;
            foreach (Artpiece artp in myArtpieces)
            {
                if (artp.getID() == pID)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public bool statusVerifier(string pieceID)
        {
            bool flag = false;
            foreach (Artpiece artp in myArtpieces)
            {
                if(artp.getID() == pieceID)
                {
                    if (artp.Status == 'S') { 
                        flag = true;
                    }
                }
            }
            return flag;
        }

        public double getValueOfArtpiece(string pieceID)
        {
            double value = 0.0;
            foreach(Artpiece artp in myArtpieces)
            {
                if (artp.getID() == pieceID)
                {
                    value = artp.Value;
                }
            }
            return value;

        }

        public void addCurator()
        {          
            Console.WriteLine("Please enter the curator ID: ");
            string curatorID = Console.ReadLine();
            if (curatorID.Length != 5)
            {
                Console.WriteLine("Error. The curator ID should be 5 characters\n");
            }
            else
            {
                if (curatorIdVerifier(curatorID) == true)
                {
                    Console.WriteLine("Error! This ID already exists\n");
                }
                else
                {
                    Console.WriteLine("Please enter firstname: ");
                    string firstname = Console.ReadLine();
                    Console.WriteLine("Please enter lastname: ");
                    string lastname = Console.ReadLine();
                    if (curatorNameVerifier(firstname, lastname) == true)
                    {
                        Console.WriteLine("Error! Names should be 40 characters\n");
                    }
                    else
                    {
                        Curator curator = new Curator(curatorID, 0.0, firstname, lastname);
                        myCurators.add(curator);
                        Console.WriteLine("Success! The curator has been added to the list\n");
                    }
                }
            }          
        }

        public string addCurator(string curatorID, string curatorFName, string curatorLName)
        {
            string message = null;
            if (curatorID.Length != 5)
            {
                message = "Error! ID must be 5 characters.";
            }
            else
            {
                if (curatorIdVerifier(curatorID) == true)
                {
                    message = "Error! This ID already exists.";
                }
                else
                {
                    if (curatorFName.Length + curatorLName.Length > 40)
                    {
                        message = "Error! Firstname and Lastname must be 40 characters maximum.";
                    }
                    else
                    {
                        Curator curator = new Curator(curatorID, 0.0, curatorFName, curatorLName);
                        myCurators.add(curator);
                        message = "Succces! Curator has been added to the list.";
                    }
                }
            }
            return message;
        }

        public void addArtist()
        {
            Console.WriteLine("Please enter artist ID: ");
            string artistID = Console.ReadLine();
            if (artistID.Length != 5)
            {
                Console.WriteLine("Error! The artist ID should be 5 characters\n");
            }
            else
            {
                if (artistIdVerifier(artistID) == true)
                {
                    Console.WriteLine("Error! This ID already exists\n");
                }
                else
                {
                    Console.WriteLine("Please enter firstname: ");
                    string firstname = Console.ReadLine();
                    Console.WriteLine("Please enter lastname: ");
                    string lastname = Console.ReadLine();
                    if (artistNameVerifier(firstname, lastname) == true)
                    {
                        Console.WriteLine("Error! Names should be maximum 40 characters\n");
                    }
                    else
                    {
                        Artist artist = new Artist(artistID, firstname, lastname);
                        myArtists.add(artist);
                        Console.WriteLine("Success! The artist has been added to the list\n");
                    }
                }
            }
        }

        public void addArtPiece()
        {
            Console.WriteLine("Please enter artpiece ID: ");
            string pieceID = Console.ReadLine();
            if (pieceID.Length != 5)
            {
                Console.WriteLine("Error! The piece ID should be 5 characters\n");
            }
            else
            {
                if (pieceIdVerifier(pieceID) == true)
                {
                    Console.WriteLine("Error! This ID already exists");
                }
                else
                {
                    Console.WriteLine("Please enter curator ID: ");
                    string curatorID = Console.ReadLine();
                    Console.WriteLine("Please enter artist ID: ");
                    string artistID = Console.ReadLine();
                    if (curatorIdVerifier(curatorID) == false || artistIdVerifier(artistID) == false)
                    {
                        Console.WriteLine("Error! Either curator ID or artist ID is incorrect\n");
                    }
                    else {
                        Console.WriteLine("Please enter title: ");
                        string title = Console.ReadLine();
                        Console.WriteLine("Please enter year: ");
                        int year = Convert.ToInt32(Console.ReadLine());
                        if (year.ToString().Length != 4)
                        {
                            Console.WriteLine("Error! Year should be 4 digits\n");
                        }
                        else
                        {
                            Console.WriteLine("Please enter value: ");
                            double value = Convert.ToDouble(Console.ReadLine());

                            Artpiece artpiece = new Artpiece(pieceID, curatorID, artistID,
                                            title, year, value);
                            myArtpieces.add(artpiece);
                            Console.WriteLine("Success! The piece has been added to the list\n");
                        }
                    }
                }
            }
        }

        public void changeStatusToSold(string id)
        {
            foreach (Artpiece artp in myArtpieces)
            {
                if (artp.getID() == id)
                {
                    artp.changeStatus('S'); 
                }
            }
        }

        public string getCuratorIdFromArtpieceID(string artpID)
        {
            string curatorID = null;
            foreach (Artpiece artp in myArtpieces)
            {
                if(artp.getID() == artpID)
                {
                    curatorID = artp.Curatorid;   
                }
            }
            return curatorID;
        }

        public void setCommission(string curatorID, double value, double estimate)
        {
            double commission = 0.0;
            commission = (estimate - value) * 0.25;
            foreach (Curator cur in myCurators)
            {
                if(cur.GetID() == curatorID)
                {
                    cur.SetComm(commission);
                }
            }
        }

        public void setEstimate(string id, double estimate)
        {
            foreach(Artpiece artp in myArtpieces)
            {
                if (artp.getID() == id)
                {
                    artp.Estimate = estimate;
                }
            }
        }

        public void sellPiece()
        {
            Console.WriteLine("Please enter artpiece ID: ");
            string artPieceId = Console.ReadLine();
            if (pieceIdVerifier(artPieceId) == false)
            {
                Console.WriteLine("Error! Wrong artpiece ID\n");
            }
            else
            {
                if(statusVerifier(artPieceId) == true)
                {
                    Console.WriteLine("Error! This artpiece is already tagged as Sold\n");
                }
                else
                {
                    Console.WriteLine("Please enter price (estimate): ");
                    double estimate = Convert.ToDouble(Console.ReadLine());
                    double value = getValueOfArtpiece(artPieceId);
                    if (estimate < value)
                    {
                        Console.WriteLine("Error! The entered price (estimate) is below the value\n");
                    }
                    else
                    {
                        changeStatusToSold(artPieceId);
                        string curatorID = getCuratorIdFromArtpieceID(artPieceId);  
                        setCommission(curatorID, value, estimate);
                        setEstimate(artPieceId, estimate);
                        Console.WriteLine("Success! Artpiece " + artPieceId + " is now sold\n");
                    }
                }               
            }           
        }

        public void seeListOfArtpieces()
        {
            foreach (Artpiece artp in myArtpieces)
            {
                Console.WriteLine(artp.toString());
            }
        }

        public void seeListOfCurators()
        {
            foreach (Curator cur in myCurators)
            {
                Console.WriteLine(cur.toString());
            }
        }

        public void seeListOfArtists()
        {
            foreach (Artist art in myArtists)
            {
                Console.WriteLine(art.toString());
            }
        }
    }
}
