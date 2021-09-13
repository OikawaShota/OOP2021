using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader
{

    public partial class Form1 : Form
    {
        List<string> link = new List<string>();
        List<string> des = new List<string>();
        List<DateTime> day = new List<DateTime>();
        public Form1()
        {
            InitializeComponent();

        }

        private void btRead_Click(object sender, EventArgs e)
        {
            setRssTitle(tbUrl.Text);
        }

        private void setRssTitle(string url)
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var urll = new Uri(url);
                var stream = wc.OpenRead(urll);
                XDocument xdoc = XDocument.Load(stream);
                var titles = xdoc.Root.Descendants("title");
                var links = xdoc.Root.Descendants("link");
                var desc = xdoc.Root.Descendants("description");
                var days = xdoc.Root.Descendants("pubDate");
                
                foreach (var node in titles)
                {
                    lbTitles.Items.Add(node.Value);
                }
                foreach(var lin in links)
                {
                    link.Add(lin.Value);
                }
                foreach (var de in desc)
                {
                    des.Add(de.Value);
                }
                foreach(var da in days)
                {
                    day.Add(DateTime.Parse((string)da));
                }
                
            }
        }

        private void lbTitles_Click(object sender, EventArgs e)
        {
            lb2.Text = des[lbTitles.SelectedIndex];
            tbDate.Text = day[lbTitles.SelectedIndex].ToString();
        }

        private void btWebShow_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(link[lbTitles.SelectedIndex]);
            

            f2.Show();
        }
    }
}
