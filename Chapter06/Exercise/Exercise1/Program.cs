using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var number = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };
            Exercise1_1(number);
            Console.WriteLine("-----");

            Exercise1_2(number);
            Console.WriteLine("-----");

            Exercise1_3(number);
            Console.WriteLine("-----");

            Exercise1_4(number);
            Console.WriteLine("-----");

            Exercise1_5(number);
            Console.WriteLine("-----");

        }

        private static void Exercise1_1(int[] numbers) {
            var max = numbers.Max();
            Console.WriteLine(max);
        }

        private static void Exercise1_2(int[] numbers) {
            var skip = numbers.Length - 2;
            foreach(var n in numbers.Skip(skip))
                Console.WriteLine(n);
        }

        private static void Exercise1_3(int[] numbers) {
            var s = numbers.Select(n => n.ToString());
            foreach(var ui in s)
                Console.WriteLine(ui);
        }

        private static void Exercise1_4(int[] numbers) {
            foreach(var d in numbers.OrderBy(c => c).Take(3))
                Console.WriteLine(d);
        }

        private static void Exercise1_5(int[] numbers) {
            var re = numbers.Distinct().Count(v => v > 10);
            Console.WriteLine(re); //次回カウントする
        }
    }
}