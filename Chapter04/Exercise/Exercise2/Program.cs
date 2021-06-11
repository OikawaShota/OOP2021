using Exercise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
            //var ym = new YearMonth();
            var ymCollection = new YearMonth[] {
                new YearMonth(1980,1),
                new YearMonth(1990,4),
                new YearMonth(2000,7),
                new YearMonth(2010,9),
                new YearMonth(2020,12),
            };
            Exercise2_2(ymCollection);
            Console.WriteLine("---");

            Exercise2_4(ymCollection);
            Console.WriteLine("---");

            Exercise2_5(ymCollection);
            Console.WriteLine("---");
        }

        private static void Exercise2_2(YearMonth[] ymCollection) {
            foreach(var ym in ymCollection) {
                Console.WriteLine(ym);
            }
        }

        static YearMonth FindFirst21C(YearMonth[] ymCollection) {
            bool a;
            foreach(var b in ymCollection) {
                if(b.Is21Century) {
                    return b;
                }
            }
            return null;
        }

        private static void Exercise2_4(YearMonth[] ymCollection) {
            var yearmonth=FindFirst21C(ymCollection); 
            var s = yearmonth != null ? yearmonth.Year.ToString() : "21世紀のデータはありません";
            Console.WriteLine(s);
        }

        private static void Exercise2_5(YearMonth[] ymCollection) {
            var array =ymCollection.Select(ym => ym.AddOneMonth()).ToArray();
            foreach(var ym in array) {
                Console.WriteLine(ym);
            }
        }
    }
}
