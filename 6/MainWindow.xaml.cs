using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace _6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = textBox.Text;
            int tovarsCount = 0;

            CultureInfo culture = CultureInfo.CurrentCulture;

            if (text.IndexOf("Ручка шариковая") != -1)
            {
                foreach (string s in text.Split())
                {
                    if (s == "Р" || s == "шариковая")
                    {
                        tovarsCount++;
                    }
                }
            }

            tovarCountText.Text = tovarsCount.ToString(culture);
        }
    }
}
