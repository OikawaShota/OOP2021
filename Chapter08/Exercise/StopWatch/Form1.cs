using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch {
    public partial class Form1 : Form {
        Stopwatch sw = new Stopwatch();
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            lbTimer.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        private void btReset_Click(object sender, EventArgs e) {
            lbTimer.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        private void btStart_Click(object sender, EventArgs e) {

        }
    }
}
