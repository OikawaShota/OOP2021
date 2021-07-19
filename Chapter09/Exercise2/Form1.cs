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

namespace Exercise2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if(ofdOpenFile.ShowDialog() == DialogResult.OK) {
                using(var reader = new StreamReader(ofdOpenFile.FileName, Encoding.UTF8)){
                    var filePath = @"C:\Users\infosys\Desktop\tessst.txt";
                    if(File.Exists(filePath)) {
                        File.Delete(filePath);
                    }
                    var writer = new StreamWriter(filePath);
                    int i = 1;
                    while(!reader.EndOfStream) {
                        var line = reader.ReadLine(); //1行読み込み
                        writer.Write("{0}:", i);
                        writer.WriteLine(line);
                        i++;
                    }
                    tbEnd.Text="終わり";
                    writer.Dispose();
                }
            }
        }
    }
}