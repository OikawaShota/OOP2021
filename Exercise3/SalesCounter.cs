using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3 {
    //売上集計クラス
    class SalesCounter {
        private IEnumerable<Sale> _sales;

        //コンストラクタ
        public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);
        }



        //List 2-17
        //店舗別売上を求める
        public IDictionary<string, int> GetPerStoreSales() {
            var dict = new Dictionary<string, int>();
            foreach(var sale in _sales) {
                if(dict.ContainsKey(sale.ShopName))
                    //すでにコレクションに店舗が設定されている。
                    dict[sale.ShopName] += sale.Amount;
                else
                    //コレクションへ店舗を登録
                    dict[sale.ShopName] = sale.Amount;
            }
            return dict;
        }


        //List 2-15
        //売上データを読み込み、Saleオブジェクトのリストを返す
        public static IEnumerable<Sale> ReadSales(string filepath) {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filepath);
            foreach(string line in lines) {
                string[] items = line.Split(',');
                Sale sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;

        }
        //商品カテゴリ別に売り上げを求める
        public IDictionary<string, int> GetPerCategorySales() {
            var dict = new Dictionary<string, int>();
            foreach(var sale in _sales) {
                if(dict.ContainsKey(sale.ProductCategory))
                    //すでにコレクションに店舗が設定されている。
                    dict[sale.ProductCategory] += sale.Amount;
                else
                    //コレクションへ店舗を登録
                    dict[sale.ProductCategory] = sale.Amount;
            }
            return dict;
        }
    }
}