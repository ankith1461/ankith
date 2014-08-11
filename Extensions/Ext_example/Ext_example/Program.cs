using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ext_example
{
    class Program
    {
        static void Main(string[] args)
        {
            //String s=StringExtension.ConvertToTitleCase("i am the king");

            var x = "i am the king";
            String s = x.ConvertToTitleCase();

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
