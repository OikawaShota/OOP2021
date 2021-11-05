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

namespace SampleGridApp
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            checkBoxTextBolock.Text = "チェック済み";
        }

        private void redRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            colorTextBox.Text = "赤";
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            checkBoxTextBolock.Text = "未チェック";
        }

        private void yellowRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            colorTextBox.Text = "黄色";
        }

        private void greenRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            colorTextBox.Text = "緑";
        }

        private void seasonComboBo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            seasonTextBlock.Text = (string)((ComboBoxItem)seasonComboBox.SelectedItem).Content;
        }
    }
}
