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
            Exercise1_1(file);
            Console.WriteLine("--------");

            Exercise1_2(file);
            Console.WriteLine("--------");

            Exercise1_3(file);
            Console.WriteLine("--------");

            Exercise1_4(file);
            Console.WriteLine("--------");

            Exercise2("11_2.xml");
            Console.WriteLine("--------");
        }

        

        private static void Exercise1_1(string file)
        {
            var xdoc = XDocument.Load(file);
            foreach (var ballsport in xdoc.Root.Elements())
            {
                XElement name = ballsport.Element("name");
                XElement member = ballsport.Element("teammembers");
                Console.WriteLine("種目{0} {1}人", name.Value, member.Value);
            }
        }

        private static void Exercise1_2(string file)
        {
            var xdoc = XDocument.Load(file);
            var xsports = xdoc.Root.Elements().OrderBy(x => (string)x.Element("firstplayed"));
            foreach (var ballsport in xsports)
            {
                XElement first = ballsport.Element("firstplayed");
                XAttribute name = ballsport.Element("name").Attribute("kanji");
                Console.WriteLine("{0} {1}", first.Value, name.Value);
            }
        }

        private static void Exercise1_3(string file)
        {
            var xdoc = XDocument.Load(file);
            var xsports = xdoc.Root.Elements()
                                    .Select(x => new
                                    {
                                        Name = x.Element("name").Value,
                                        Teammembers = x.Element("teammembers").Value
                                    })
                                     .OrderByDescending(x => int.Parse(x.Teammembers)).First();
            Console.WriteLine("{0}", xsports.Name);

        }

        private static void Exercise1_4(string file)
        {
            //P290リスト11.15を参考にする
            //var newfile = "sports.xml";//出力する新しいファイル
            var xdoc = XDocument.Load(file);
            var elm = new XElement("ballsport",
                                    new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                                    new XElement("teammembers", "11"),
                                    new XElement("firstplayed", "1863")
                                    );
            xdoc.Root.Add(elm);
            xdoc.Save("sports.xml");
            foreach (var ball in xdoc.Root.Elements())
            {
                XElement name = ball.Element("name");
                XElement member = ball.Element("teammembers");
                Console.WriteLine("種目{0} {1}人", name.Value, member.Value);
            }
                
        }

        private static void Exercise2(string file)
        {
            var xdoc = XDocument.Load(file);
            var newfile = "11_2変換後.xml";
            var elm = xdoc.Root.Elements();
            elm.Remove();
            var element = new XElement("difficultkanji",
                                    new XElement("word", new XAttribute("kanji", "鬼灯")
                                                        , new XAttribute("yomi", "ほおずき")),
                                    new XElement("word", new XAttribute("kanji", "暖簾")
                                                        , new XAttribute("yomi", "のれん")),
                                    new XElement("word", new XAttribute("kanji", "杜撰")
                                                        , new XAttribute("yomi", "ずさん")),
                                    new XElement("word", new XAttribute("kanji", "坩堝")
                                                        , new XAttribute("yomi", "るつぼ"))
                                    );
            xdoc.Add(element);
            xdoc.Save(newfile);
        }

    }
}
