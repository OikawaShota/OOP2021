using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var Session = new Dictionary<string, object>();
            Session["MyProduct"] = new Product();
            var product = Session["MyProduct"] as Product;
            if(product.Name == "") {
                Console.WriteLine("productが取得できなかった");
            } else {
                Console.WriteLine("productが取得できた");
            }
        }
        private static Product GetProductA() {
            Sale sale = new Sale();
            return sale?.Product;
        }

    }
    class Sale {
        public string ShopNmae { get; set; } = "abcde";
        public int Amount { get; set; } = 12340;
        public Product Product { get; set; }
    }
}
