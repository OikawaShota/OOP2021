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

namespace Exercise3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e) {
                using(var reader = new StreamReader(tbPass2.Text, Encoding.UTF8)) {
                    using(var writer = new StreamWriter(tbPass1.Text,append:true)) {
                        while(!reader.EndOfStream) {
                            var line = reader.ReadLine(); //1行読み込み
                            writer.WriteLine(line);
                        }
                    }
                }
                tbEnd.Text = "owari";
        }
    }
}
