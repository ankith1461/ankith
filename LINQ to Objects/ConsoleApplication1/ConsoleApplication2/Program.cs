using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{

    public class MusicalArtist
    {
        public string Name { get; set; }

        public string Genre { get; set; }

        public string LatestHit { get; set; }

        public string Year { get; set; }

        public string Album1 { get; set; }

        public string Album2 { get; set; }

        public string Album3 { get; set; }

     
              
    }
    

    class Program
    {
        static List<MusicalArtist> GetMusicalArtists()
        {
            return new List<MusicalArtist>
            {
                new MusicalArtist 
                { 
                    Name = "Adele", 
                    Genre = "Pop", 
                    LatestHit = "Someone Like You",
                    Year="2008",
                    Album1="21 street"
                        
                },
                new MusicalArtist 
                { 
                    Name = "Maroon 5", 
                    Genre = "Adult Alternative", 
                    LatestHit = "Moves Like Jaggar",
                    Year="2008",
                     Album1= "Misery", 
                     Album2= "It Won't Be Soon Before Long",
                     Album3= "Wake Up Call"
                    
                },
                new MusicalArtist 
                { 
                    Name = "Lady Gaga", 
                    Genre = "Pop", 
                    LatestHit = "You And I",
                    Year="2009",
                    Album1 = "The Fame",
                    Album2 = "The Fame Monster",
                    Album3 = "Born This Way"
                    
                }
            };
        }


        static void Main(string[] args)
        {
            

            List<MusicalArtist> artistsDataSource = GetMusicalArtists();

            IEnumerable<MusicalArtist> artistsResult = from artist in artistsDataSource
                                                       where artist.Year=="2008"
                                                       select new MusicalArtist
                                                       {
                                                           Name=artist.Name,
                                                           Genre=artist.Genre,
                                                           LatestHit=artist.LatestHit,
                                                           Album1=artist.Album1
                                                       };
                                                              

            Console.WriteLine("\nCustom projections");
            Console.WriteLine("---------------------\n");

            foreach (MusicalArtist artist in artistsResult)
            {
                Console.WriteLine(
                    "Name: {0}\nGenre: {1}\nLatest Hit: {2}\nAlbum1 :{3}\n",
                    artist.Name,
                    artist.Genre,
                    artist.LatestHit,
                    artist.Album1);


            }

            Console.WriteLine("\nEnter the action\n");
            string action = Console.ReadLine();

            switch (action)
            {
                case "take":
                
            Console.WriteLine("\nTake operation");
            Console.WriteLine("---------------------\n");

            foreach (MusicalArtist artist in artistsResult.Take(1))
            {
                Console.WriteLine(
                    "Name: {0}\nGenre: {1}\nLatest Hit: {2}\nAlbum1 :{3}\n",
                    artist.Name,
                    artist.Genre,
                    artist.LatestHit,
                    artist.Album1);


            }
                    break;

                case "skip":

            Console.WriteLine("\nSkip operation");
            Console.WriteLine("---------------------\n");

            foreach (MusicalArtist artist in artistsResult.Skip(1))
            {
                Console.WriteLine(
                    "Name: {0}\nGenre: {1}\nLatest Hit: {2}\nAlbum1 :{3}\n",
                    artist.Name,
                    artist.Genre,
                    artist.LatestHit,
                    artist.Album1);


            }
                    break;
            };

            Console.ReadKey();

        }
    }
}
