/* Augusto Serrao
   Deepti Aggarwal
   Hartaj Dhillon
   Gagandeep Singh
   Shoaib Hassan
*/

using System;
using System.Windows;

namespace PokePunchLine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const String strJoke = "Why did the invisible man\nturn down the job offer?";
        private const String strPunchLine = "He couldn't see himself doing it.";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Setup_Click(object sender, RoutedEventArgs e)
        {
            button_setup.IsEnabled = false;
            button_punch_line.IsEnabled = true;
            label_display.Content = strJoke;
        }

        private void Button_PunchLine_Click(object sender, RoutedEventArgs e)
        {
            button_setup.IsEnabled = true;
            button_punch_line.IsEnabled = false;
            label_display.Content = strPunchLine;
        }
    }
}
