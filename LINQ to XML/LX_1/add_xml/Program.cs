using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;

namespace add_xml
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter the action to perform");
            Console.WriteLine("---------------------\n");
            string action;
            action = Console.ReadLine();

            XDocument d = XDocument.Load("C:\\Users\\dell\\Desktop\\LINQ to XML\\LX_1\\People.xml");

            switch (action)
            {
                case "add": Console.WriteLine("Adding new Element to XML");
                            Console.WriteLine("---------------------\n");
                            d.Element("People").Add(
                            new XElement("Person", new XAttribute("id", 6),
                            new XElement("Name", "sam"),
                            new XElement("Age", 24),
                            new XElement("Job", "IT")));

                            break;

                case "remove": Console.WriteLine("Removing an XML Element");
                               Console.WriteLine("---------------------\n");
                                d.Root.Elements()
                               .Where(e => e.Attribute("id").Value.Equals("5"))
                               .Select(e => e).Single().Remove();                   
                                
                               break;

                case "update": Console.WriteLine("Updating an XML Element");
                               Console.WriteLine("---------------------\n");
                                d.Root.Elements("Person")
                               .Where(e => e.Element("Name").Value.Equals("Lisa"))
                               .Select(e => e.Attribute("id")).Single().SetValue("146");

                               break;

                case "change": Console.WriteLine("Event in XML ");
                               Console.WriteLine("---------------------\n");
                               d.Root.Elements("Person")
                               .Where(e => e.Element("Name").Value.Equals("Lisa"))
                               .Select(e => e.Attribute("id")).Single()
                               .Changed += (object sender, XObjectChangeEventArgs e) => Console.WriteLine("\nType of object changed: {0}, Change Type: {1}", sender.GetType().Name, e.ObjectChange);
                              
                               //update query to change Lisa's id
                               d.Root.Elements("Person")
                               .Where(e => e.Element("Name").Value.Equals("Lisa"))
                               .Select(e => e.Attribute("id")).Single().SetValue("20");
                               Console.WriteLine("---------------------\n");
                               break;
                case "query": Console.WriteLine("Querying an XML Element");
                               Console.WriteLine("---------------------\n");

                               break;

            }

            d.Save("C:\\Users\\dell\\Desktop\\LINQ to XML\\LX_1\\People.xml");

            IEnumerable<XElement> employees = d.Elements();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

            Console.ReadKey();

        }
    }
}
