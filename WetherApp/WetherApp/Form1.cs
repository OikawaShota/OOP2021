using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WetherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            string[] city = new string[5] { "前橋", "みなかみ", "宇都宮", "水戸" ,"その他"};
            int[] citycode;
            int a = 0;
            if (cb1.Text.Equals("その他"))
            {
                citycode = new int[5] { 4210, 4220, 4110, 4010, int.Parse(tb2.Text) };
                a = 4;
            }
            else
            {
                citycode = new int[4] { 4210, 4220, 4110, 4010};
                int i = 0;
                for (i = 0; i < city.Length; i++)
                {
                    if (cb1.Text.Equals(city[i]))
                    {
                        a = i;
                        break;
                    }
                }
            }
            int code = citycode[a];
            var results = GetWeatherReportFromYahoo(code);
            foreach (var s in results)
            {
                tb1.Text += s.ToString();
                tb1.AppendText(Environment.NewLine);
            }
        }

        private IEnumerable<object> GetWeatherReportFromYahoo(int code)
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uriString = string.Format(
                    @"http://rss.weather.yahoo.co.jp/rss/days/{0}.xml", code);
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
