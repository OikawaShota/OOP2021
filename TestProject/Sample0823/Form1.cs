using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0823
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int val = int.Parse(Value.Text);
            int a = 1;
            int re = 0;
            for (int i = 0; i < (int.Parse(Jyou.Text)); i++)
            {
                a = a * val;
                re = re + a;//未完成
            }
            Result.Text = re.ToString();
        }
    }
}
