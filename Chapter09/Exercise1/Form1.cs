using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if(ofdOpenFile.ShowDialog() == DialogResult.OK) {

                using(var reader = new StreamReader(ofdOpenFile.FileName, Encoding.UTF8)) {
                    int i = 0;
                    while(!reader.EndOfStream) {
                        var line = reader.ReadLine(); //1行読み込み
                        if(line.Contains(tbKey.Text)) {
                            i++;
                        }
                        tbOutput.Text += line + "\r\n";
                    }
                    tbKey.Text += i.ToString();
                }
            }

        }

        private void btReadAll_Click(object sender, EventArgs e) {
            if(ofdOpenFile.ShowDialog() == DialogResult.OK) {
                var lines = File.ReadAllLines(ofdOpenFile.FileName, Encoding.UTF8);
                int a=0;
                foreach(var i in lines) {
                    if(i.Contains(tbKey.Text)) {
                        a++;
                    }
                }
                tbKey.Text += a.ToString();
            }
        }

        private void btReadLines_Click(object sender, EventArgs e) {
            if(ofdOpenFile.ShowDialog() == DialogResult.OK) {
                var count = File.ReadLines(ofdOpenFile.FileName, Encoding.UTF8).Count(s => s.Contains(tbKey.Text));
                tbKey.Text += count.ToString();
            }
        }
    }
}
