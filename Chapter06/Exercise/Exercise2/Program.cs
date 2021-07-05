using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Book {
        public string Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
    }
    class Program {
        static void Main(string[] args) {
            var books = new List<Book> {
               new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
               new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
               new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
               new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
               new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
               new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
               new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            Exercise2_1(books);
            Console.WriteLine("-----");

            Exercise2_2(books);

            Console.WriteLine("-----");

            Exercise2_3(books);
            Console.WriteLine("-----");

            Exercise2_4(books);
            Console.WriteLine("-----");

            Exercise2_5(books);
            Console.WriteLine("-----");

            Exercise2_6(books);

            Console.WriteLine("-----");

            Exercise2_7(books);
        }

        private static void Exercise2_1(List<Book> books) {
            var t = books.FirstOrDefault(b => b.Title == "ワンダフル・C#ライフ");
            if(t != null) {
                Console.WriteLine("{0} {1}",t.Price,t.Pages);
            }
            
        }

        private static void Exercise2_2(List<Book> books) {
            var t = books.Count(h => h.Title.Contains("C#"));
            Console.WriteLine(t);

        }

        private static void Exercise2_3(List<Book> books) {
            var avg = books.Where(b => b.Title.Contains("C#")).Average(b => b.Pages);
            Console.WriteLine(avg);
        }

        private static void Exercise2_4(List<Book> books) {
            var i = books.FirstOrDefault(b => b.Price >= 4000);
            if(i != null) {
                Console.WriteLine(i.Title);
            }
        }

        private static void Exercise2_5(List<Book> books) {
            var d = books.Where(g => g.Price < 4000).Max(b => b.Pages);
            Console.WriteLine(d);
        }

        private static void Exercise2_6(List<Book> books) {
            var k = books.Where(c => c.Pages > 400).OrderByDescending(c => c.Price);
            foreach(var z in k)
                Console.WriteLine("{0} {1}",z.Title,z.Price);
        }

        private static void Exercise2_7(List<Book> books) {
            var a = books.Where(b => b.Title.Contains("C#") && b.Pages < 500);
            foreach(var s in a)
                Console.WriteLine("{0}", s.Title);
        }
    }
}
