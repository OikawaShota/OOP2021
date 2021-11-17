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
        static Random ans = new Random();
        private int a = ans.Next(Rows * Columns) + 1;
        private const int Rows = 5;
        private const int Columns = 5;

        private SolidColorBrush selectedButtonColor = new SolidColorBrush(Colors.Yellow);
        private SolidColorBrush hit = new SolidColorBrush(Colors.Red);
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Loded(object sender, RoutedEventArgs e)
        {
            List<Button> buttons = new List<Button>();

            for (int i = 0; i < Rows; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }

            for (int j = 0; j < Columns; j++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            int v = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++) {
                    var bt = new Button();
                    bt.Width = MainWind.Width / Columns;
                    bt.Height = MainWind.Height/Rows;
                    bt.Content = v + 1;
                    bt.FontSize = 30;
                    bt.Click += bt_Click;
                    Grid.SetRow(bt, i);
                    Grid.SetColumn(bt, j);
                    buttons.Add(bt);
                    v++;
                }
            }
            buttons.ForEach(bt => grid.Children.Add(bt));
            MainWind.Height += tbAns.Height + 50;

        }


        public void Anser(int number)
        {
            if (number == a)
            {
                tbAns.Text = ("正解!");
            }
            else
            {
                if (number > a)
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
            Button selecttedButton = (Button)sender;
            Anser((int)selecttedButton.Content);
        }
    }

}
