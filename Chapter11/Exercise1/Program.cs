using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = "Sample.xml";
            Exercese1_1(file);
            Console.WriteLine("--------");

            Exercese1_2(file);
            Console.WriteLine("--------");

            Exercese1_3(file);
            Console.WriteLine("--------");
        }

        private static void Exercese1_1(string file)
        {
            var xdoc = XDocument.Load(file);
            foreach(var ballsport in xdoc.Root.Elements())
            {
                XElement name = ballsport.Element("name");
                XElement member = ballsport.Element("teammembers");
                Console.WriteLine("種目{0} {1}人", name.Value, member.Value);
            }
        }

        private static void Exercese1_2(string file)
        {
            var xdoc = XDocument.Load(file);
            var xsports = xdoc.Root.Elements().OrderBy(x =>(string)x.Element("firstplayed"));
            foreach (var ballsport in xsports)
            {
                XElement first = ballsport.Element("firstplayed");
                XAttribute name = ballsport.Element("name").Attribute("kanji");
                Console.WriteLine("{0} {1}",first.Value, name.Value);
            }
        }

        private static void Exercese1_3(string file)
        {

        }
    }
}
