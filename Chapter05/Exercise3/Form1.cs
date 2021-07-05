using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        //フォームがロードされるタイミングで1回だけ実行される
        private void Form1_Load(object sender,EventArgs e) {
            inputStrText.Text = "Jackdaws love my big sphinx of quartz";
            inputStrDate.Text = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
        }

        private void button1_Click(object sender, EventArgs e) {
            var a =inputStrText.Text.Count(s => s==' ');
            ans1.Text = a.ToString();
        }

        private void button2_Click(object sender, EventArgs e) {
            ans2.Text=inputStrText.Text.Replace("big", "small");
        }

        private void button3_Click(object sender, EventArgs e) {
            ans3.Text = inputStrText.Text.Split(' ').Length.ToString();
        }

        private void button4_Click(object sender, EventArgs e) {
            var a = inputStrText.Text.Split(' ').Where(s => s.Length <= 4);
            foreach(var word in a) {
                ans4.Text += word+" ";
            }
        }

        private void button5_Click(object sender, EventArgs e) {
            var a = new StringBuilder();
            var i = inputStrText.Text.Split(' ');
            foreach(var u in i) {
                a.Append(u);
                a.Append(" ");
            }
            ans5.Text = a.ToString();
        }

        private void button6_Click(object sender, EventArgs e) {
            foreach(var pair in inputStrDate.Text.Split(';')){
                var array = pair.Split('=');
                outputStrDate.Text += ToJapanese(array[0]) + ";" + array[1] + "\r\n";

            }
        }
        private string ToJapanese(string key) {
            switch(key) {
                case "Novelist":
                    return "作家　";
                case "BestWork":
                    return "代表作　";
                case "Born":
                    return "誕生年　";
            }
            throw new ArgumentException("引数が正しくありません");
        }
    }
}