using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Ex08
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private async void btn_Click(object sender, RoutedEventArgs e)
        {
            int inicio = 0;
            int fim = 0;

            await Task.Delay(1000);
            lblMsg.Visibility = Visibility.Visible;
            int.TryParse(txtBoxN1.Text, out inicio);
            int.TryParse(txtBoxN2.Text, out fim);
            Random rand = new Random();
            int sorteio = rand.Next(inicio, fim);
            lblMsg.Content = $"Sorteando de {inicio} a {fim}...";
            await Task.Delay(2000);
            lblMsg.Content = $"Sorteei o valor {sorteio}";
        }
    }
}
