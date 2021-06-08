using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };
            var names = new List<string> {
                "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Canberra","Hong Kong" };

            // 3.1.1
            Exercise1_1(numbers);
            Console.WriteLine("-----");

            // 3.1.2
            Exercise1_2(numbers);
            Console.WriteLine("-----");

            // 3.1.3
            Exercise1_3(numbers);
            Console.WriteLine("-----");

            // 3.1.4
            Exercise1_4(numbers);

            // 3.2.1
            Exercise2_1(names);

            // 3.2.2
            Exercise2_2(names);

            // 3.2.3
            Exercise2_3(names);

            // 3.2.4
            Exercise2_4(names);

            // できた人
            Exercise2_5(names);
        }

        private static void Exercise2_5(List<string> names) {
            int count = 0;
            foreach(var name in names) {
                count+=name.Count(c => char.IsLower(c));
            }
            Console.WriteLine(count);
        }

        private static void Exercise2_1(List<string> names) {
            Console.Write("都市名を入力");
            var t=Console.ReadLine();
            int index = names.FindIndex(s => s == t);
            if(index == null)
                Console.WriteLine(-1);
             else
            Console.WriteLine(index);
        }

        private static void Exercise2_2(List<string> names) {
            var count = names.RemoveAll(s => s.Contains('o'));
            Console.WriteLine(count);
        }

        private static void Exercise2_3(List<string> names) {
            var select = names.Where(s => s.Contains('o')).ToArray();
            foreach(var name in select)
                Console.WriteLine(name);
        }

        private static void Exercise2_4(List<string> names) {
            var selected = names.Where(s => s.StartsWith("B")).Select(s=>s.Length);
            foreach(var length in selected) {
                Console.WriteLine(length);
            }
        }

        private static void Exercise1_1(List<int> numbers) {
            var exist = numbers.Exists(n => n % 8 == 0 || n % 9 == 0);
            if(exist)
                Console.WriteLine("存在します");
            else
                Console.WriteLine("存在します");
        }

        private static void Exercise1_2(List<int> numbers) {
            numbers.ForEach(n => Console.WriteLine(n / 2.0));
        }

        private static void Exercise1_3(List<int> numbers) {
            //var q = numbers.Where(s => s >= 50);
            //foreach(var a in q)
            //  Console.WriteLine(a);
            foreach(var n in numbers.Where(n => n >= 50))
                Console.WriteLine(n);
        }

        private static void Exercise1_4(List<int> numbers) {
            //var q = numbers.Select(n => n * 2);
            //foreach(var n in q)
            //  Console.WriteLine(n);
            List<int> list = numbers.Select(n => n * 2).ToList();
            foreach(var num in list) {
                Console.WriteLine(num);
            }
        }
    }
}
