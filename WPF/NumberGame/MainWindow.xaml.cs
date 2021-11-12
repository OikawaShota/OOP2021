using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGame
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        Random ans = new Random();
        public MainWindow()
        {
            InitializeComponent();
            int a=int.Parse(ans.Next(1, 25).ToString());
        }

        public void Anser(int number)
        {
            if (number==a)
            {
                tbAns.Text = ("正解!");
            }
            else
            {
                if(number.Equals(ans))
                {
                    tbAns.Text = ("この数値より少ないです。");
                }
                else
                {
                    tbAns.Text = ("この数値より大きいです。");
                }
            }
        }

        private void bt_Click(object sender, RoutedEventArgs e)
        {
            Anser(int.Parse(((Button) sender).Content.ToString()));
        }

    }
}
