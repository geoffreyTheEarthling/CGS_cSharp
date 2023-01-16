using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CGS_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            //TYPE-CASTING
            //int a = 7;
            //int b = 4;
            //Console.WriteLine("(double)(a/b) returns an integer: " + (double)(a/b));
            //Console.WriteLine("(double)a/b returns a double: " + (double)a/b);
            

            Gallery gallery = new Gallery();

            while (true)
            {               
                Console.WriteLine("1. Add Curator");
                Console.WriteLine("2. Add Artist");
                Console.WriteLine("3. Add Artpiece");
                Console.WriteLine("4. Sell Artpiece");
                Console.WriteLine("5. Curators List");
                Console.WriteLine("6. Artists List");
                Console.WriteLine("7. Artpieces List");
                Console.WriteLine("8. Exit");
                Console.WriteLine("Please choose option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        gallery.addCurator();
                        Console.WriteLine("=============================================");
                        break;
                    case 2:
                        gallery.addArtist();
                        Console.WriteLine("=============================================");
                        break;
                    case 3:
                        gallery.addArtPiece();
                        Console.WriteLine("=============================================");
                        break;
                    case 4:
                        gallery.sellPiece();
                        Console.WriteLine("=============================================");
                        break;
                    case 5:
                        gallery.seeListOfCurators();
                        Console.WriteLine("=============================================");
                        break;
                    case 6:
                        gallery.seeListOfArtists();
                        Console.WriteLine("=============================================");
                        break;
                    case 7:
                        gallery.seeListOfArtpieces();
                        Console.WriteLine("=============================================");
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Error! Please enter an option between 1 and 8");
                        Console.WriteLine("=============================================");
                        break;
                }
            }//end of while(true)
        }//end of main
    }
}
