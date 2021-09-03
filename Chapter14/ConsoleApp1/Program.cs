using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section04
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }

        //コンストラクタ
        public Program()
        {
            //DownloadString();
            //DownloadFileAsync();
            //OpenReadSample();
            int[] city = new int[4] { 4210, 4220, 4110, 4010 };
            Console.WriteLine("地域を選択\n" +
                              "1:前橋\n" +
                              "2:みなかみ\n" +
                              "3:宇都宮\n" +
                              "4:水戸\n" +
                              "9:その他");
            int i=int.Parse(Console.ReadLine());
            int code = 0;
            if (i == 9)
            {
                Console.WriteLine("コードを入力してください");
                code = int.Parse(Console.ReadLine());
            }
            else
            {
                code = city[i - 1];
            }
            var results = GetWeatherReportFromYahoo(code);
            foreach(var s in results)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }

        //リスト14.15
        public void DownloadString()
        {
            var wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            var html = wc.DownloadString("https://yahoo.co.jp/");
            Console.WriteLine(html);
        }

        private void DownloadFileAsync()
        {
            var wc = new WebClient();
            var url = new Uri(@"C:\Users\so32017\Downloads\2020-5-12_プログラム基礎第一回.zip");
            var filename = @"C:\temp\example.zip";
            wc.DownloadProgressChanged += wc_DownloadProgressChanged;
            wc.DownloadFileCompleted += wc_DownloadFileCompleted;
            wc.DownloadFileAsync(url, filename);//非同期でダウンロード
            Console.ReadLine();//アプリケーションが終了しないようにする
        }

        static void wc_DownloadProgressChanged(object sender,
                            DownloadProgressChangedEventArgs e)
        {
            Console.WriteLine("{0}% {1}/{2}", e.ProgressPercentage,
                              e.BytesReceived, e.TotalBytesToReceive);
        }

        static void wc_DownloadFileCompleted(object sender,
                            System.ComponentModel.AsyncCompletedEventArgs e)
        {
            Console.WriteLine("ダウンロード完了");
        }
        //リスト14.18(ストリームとしてダウンロード)
        public void OpenReadSample()
        {
            var wc = new WebClient();
            using (var stream=wc.OpenRead(@"https://yahoo.co.jp/"))
            using (var sr = new StreamReader(stream,Encoding.UTF8))
            {
                string html = sr.ReadToEnd();
                Console.WriteLine(html);
            }
        }
        private static IEnumerable<string> GetWeatherReportFromYahoo(int cityCode)
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uriString = string.Format(
                    @"http://rss.weather.yahoo.co.jp/rss/days/{0}.xml", cityCode);
                var url = new Uri(uriString);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                foreach (var node in nodes)
                {
                    string s = Regex.Replace(node.Value, "【|】| - Yahoo!天気・災害", "");
                    yield return s;
                }
            }
        }
    }
}
