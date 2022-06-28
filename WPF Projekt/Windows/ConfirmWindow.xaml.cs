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
using System.Windows.Shapes;

namespace WPF_Projekt.Windows
{
    /// <summary>
    /// Interaction logic for ConfrimWindow.xaml
    /// </summary>
    public partial class ConfirmWindow : Window
    {
        private static bool choice;
        public ConfirmWindow()
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                choice = false;
                this.Close();
            }
            else if (e.Key == Key.Enter)
            {
                choice = true;
                this.Close();
            }
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            choice = true;
            this.Close();
        }

        private void Cancle_Click(object sender, RoutedEventArgs e)
        {
            choice = false;
            this.Close();
        }

        public static bool Choice()
        {
            return choice;
        }
    }
}
