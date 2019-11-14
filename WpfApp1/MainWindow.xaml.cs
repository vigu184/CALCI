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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double ln, res;
        public MainWindow()
        {
            InitializeComponent();
            ResultOf.Content = "0";
        }
        private void DecimalButton_Click(object sender, RoutedEventArgs e)
        {           
                if (ResultOf.Content.ToString() == "0")
                {
                    ResultOf.Content = "0.";
                }
                else
                {
                    ResultOf.Content = $"{ResultOf.Content}.";
                }
        }

        private void EqualToButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            int rvalue=0;

            if(sender==NineButton)
                rvalue = 9;
            if (sender == EightButton)
                rvalue = 8;
            if (sender == SevenButton)
                rvalue = 7;
            if (sender == SixButton)
                rvalue = 6;
            if (sender == FiveButton)
                rvalue = 5;
            if (sender == FourButton)
                rvalue = 4;
            if (sender == ThreeButton)
                rvalue = 3;
            if (sender == TwoButton)
                rvalue = 2;
            if (sender == OneButton)
                rvalue = 1;
            if (sender == ZeroButton)
                rvalue = 0;

            if(ResultOf.Content.ToString()=="0")
            {
                ResultOf.Content = $"{rvalue}";
            }
            else
            {
                ResultOf.Content = $"{ResultOf.Content}{rvalue}";
            }
        }
        private void AllClearButton_Click(object sender, RoutedEventArgs e)
        {
            ResultOf.Content = "0";
        }

        private void ClearEntryButton_Click(object sender, RoutedEventArgs e)
        {
            ResultOf.Content = ResultOf.Content.ToString().Remove(ResultOf.Content.ToString().Length - 1, 1);
            if(ResultOf.Content.ToString().Length==0)
            {
                ResultOf.Content = "0";
            }
        }

    }
}
