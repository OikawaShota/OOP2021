using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var number = Enumerable.Range(1, 20).ToList();
            var books = Books.GetBooks();
            Console.WriteLine("本の平均価格は" + books.Average(x => x.Price).ToString("#,0")+ "円");
            Console.WriteLine("本の総ページ数は" + books.Sum(c => c.Pages) + "ページ");
            Console.WriteLine("一番高価な本は" + books.Max(a => a.Price) + "円");
            Console.WriteLine("一番安い本は" + books.Min(b => b.Price) + "円");
            Console.WriteLine("全部で500円以上の本が何冊あるか" + books.Count(c => c.Price >= 500) + "冊");
            Console.WriteLine("「物語」が何冊あるか" + books.Count(d => d.Title.Contains("物語")) + "冊");
            var bookData = books.Where(x => x.Title.Contains("物語")).Take(2);
            foreach(var book in bookData)
                Console.WriteLine(book.Title);
            Console.WriteLine("高額書籍ベスト3");
            var bookData2 =books.OrderByDescending(b=>b.Price).Take(3);
            foreach(var book in bookData2)
                Console.WriteLine(book.Title+" "+book.Price);
            Console.WriteLine("  ");
            var titles = books.Select(x => x.Title);
            foreach(var item in titles)
                Console.WriteLine(item);
        }
    }
}