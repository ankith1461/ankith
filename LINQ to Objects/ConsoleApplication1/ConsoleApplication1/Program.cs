using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{

    public class MusicalArtist
    {
        public string Name { get; set; }

        public string Genre { get; set; }

        public string LatestHit { get; set; }

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
                   
                },
                new MusicalArtist 
                { 
                    Name = "Maroon 5", 
                    Genre = "Adult Alternative", 
                    LatestHit = "Moves Like Jaggar",
                    
                },
                new MusicalArtist 
                { 
                    Name = "Lady Gaga", 
                    Genre = "Pop", 
                    LatestHit = "You And I",
                    
                }
            };
        }

       
        static void Main(string[] args)
        {
           
            List<MusicalArtist> artistsDataSource = GetMusicalArtists();

            IEnumerable<MusicalArtist> artistsResult = from artist in artistsDataSource
                                                       select artist;

            Console.WriteLine("\nQuerying Custom Types");
            Console.WriteLine("---------------------\n");

            foreach (MusicalArtist artist in artistsResult)
            {
                Console.WriteLine(
                    "Name: {0}\nGenre: {1}\nLatest Hit: {2}\n",
                    artist.Name,
                    artist.Genre,
                    artist.LatestHit);

                
            }
        
            Console.ReadKey();

        }
    }
}
