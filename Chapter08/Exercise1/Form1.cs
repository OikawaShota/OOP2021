using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btAction_Click(object sender, EventArgs e) {
            var today = new DateTime((int)nudYear.Value, (int)nudMonth.Value, (int)nudDay.Value);
            DayOfWeek dayOfWeek = today.DayOfWeek;
            string dow = " ";
            switch(dayOfWeek) {
                case DayOfWeek.Sunday:
                    dow = "日曜日";
                    break;
                case DayOfWeek.Monday:
                    dow = "月曜日";
                    break;
                case DayOfWeek.Tuesday:
                    dow = "火曜日";
                    break;
                case DayOfWeek.Wednesday:
                    dow = "水曜日";
                    break;
                case DayOfWeek.Thursday:
                    dow = "木曜日";
                    break;
                case DayOfWeek.Friday:
                    dow = "金曜日";
                    break;
                case DayOfWeek.Saturday:
                    dow = "土曜日";
                    break;
                default:
                    break;
            }
            tbOutput.Text = dow+"です";
            //閏年判定
            var isL = DateTime.IsLeapYear((int)nudYear.Value);
            if(isL) {
                tbLeepYear.Text = "閏年です";
            } else {
                tbLeepYear.Text = "閏年ではありません。";
            }
        }

        private void btAge_Click(object sender, EventArgs e) {
            var today = dTP.Value;
            var birthday = new DateTime(2002, 2, 19);
            var age = today.Year - birthday.Year;
            if(today < birthday.AddYears(age)) {
                age--;
            }
            tbAge.Text= age.ToString();
        }
    }
}