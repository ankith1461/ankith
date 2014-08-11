using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation;
            string[] names = { "Burke", "Connor", "Frank", "Everett", 
                   "Albert", "George", "Harris", "David" };

            Console.Write("---Enter the operation---\n");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "o":
                    Console.Write("---Ordering in LINQ---\n");
                    // sort by length
                    var s3 = names.OrderBy(s => s.Length);
                    var s4 = names.OrderByDescending(s => s.Length);

                    
                     
                             foreach (var s in s3)
                             {
                                 Console.WriteLine(s);
                             }
                     Console.Write("---Ordering by DESC in LINQ---\n");
                     
                             foreach (var s in s4)
                             {
                                 Console.WriteLine(s);
                             }

                    break;

                case "g":
                    Console.Write("---Grouping in LINQ---\n");
                         var groups = names.GroupBy(s => s.Length);
                        foreach (IGrouping<int, string> group in groups) 
                        {
                            Console.WriteLine ("Strings of length {0}", group.Key);
                            foreach (string value in group)
                            Console.WriteLine("  {0}", value);
                        } 

                    break;


                case "a":
                    Console.Write("---Aggregation in LINQ---\n");

                    int count = names.Aggregate(0, (c, s) => c + s.Length);
                    Console.WriteLine("Total characters in array : {0}\n",count);

                    int total2 = names.Sum(s => s.Length);
                    Console.WriteLine("Sum of length of the words : {0}\n", total2);


                    break;


                case "s":
                    Console.Write("---SELECT in LINQ---\n");

                    var tokens = names.Select(s => s.Split(' '));

                    Console.Write("---SELECT operation---\n");

                            foreach (string[] line in tokens)
                                foreach (string token in line)
                                    Console.Write("{0}\n", token);

                            Console.Write("---SELECT Many in LINQ---\n");

                        var token1 = names.SelectMany(s => s.Split(' '));

                        foreach (string t1 in token1)
                            Console.Write("{0}\n", t1);


                    break;


            }
            
            

           
            Console.ReadKey();

        }
    }
}
