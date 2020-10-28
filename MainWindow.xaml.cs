using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnVirgule_Click(object sender, RoutedEventArgs e)
        {
            txtMain.Text += ".";
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            lblHistorique.Content = Convert.ToDouble(txtMain.Text);
            lblAction.Content = "+";
            txtMain.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string opperator = Convert.ToString(lblAction.Content);
            if (opperator == "+")
            {
                double result = Convert.ToDouble(txtMain.Text) + Convert.ToDouble(lblHistorique.Content);
                txtMain.Text = Convert.ToString(result);
            }
            if (opperator == "-")
            {
                double result = Convert.ToDouble(lblHistorique.Content) - Convert.ToDouble(txtMain.Text);
                txtMain.Text = Convert.ToString(result);

            }
            if (opperator == "/")
            {
                double result = Convert.ToDouble(lblHistorique.Content) / Convert.ToDouble(txtMain.Text);
                txtMain.Text = Convert.ToString(result);
            }
            if (opperator == "*")
            {
                double result = Convert.ToDouble(txtMain.Text) * Convert.ToDouble(lblHistorique.Content);
                txtMain.Text = Convert.ToString(result);
            }
        }

        private void btnMoins_Click(object sender, RoutedEventArgs e)
        {
            lblHistorique.Content = Convert.ToDouble(txtMain.Text);
            lblAction.Content = "-";
            txtMain.Clear();
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            txtMain.Clear();
            lblHistorique.Content = "";
            lblAction.Content = "";
        }

        private void btnFois_Click(object sender, RoutedEventArgs e)
        {
            lblHistorique.Content = Convert.ToDouble(txtMain.Text);
            lblAction.Content = "*";
            txtMain.Clear();
        }

        private void btnDiviser_Click(object sender, RoutedEventArgs e)
        {
            lblHistorique.Content = Convert.ToDouble(txtMain.Text);
            lblAction.Content = "/";
            txtMain.Clear();
        }

        private void btnRND_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 100);
            txtMain.Text = Convert.ToString(random);
        }

        private void SIN_Click(object sender, RoutedEventArgs e)
        {
            double main = Convert.ToDouble(txtMain.Text);
            double a = Math.Sin(main);
            txtMain.Text = Convert.ToString(a);
        }

        private void btnSQRT_Click(object sender, RoutedEventArgs e)
        {
            double main = Convert.ToDouble(txtMain.Text);
            double a = Math.Sqrt(main);
            txtMain.Text = Convert.ToString(a);
        }

        private void btnSQR_Click(object sender, RoutedEventArgs e)
        {
            double main = Convert.ToDouble(txtMain.Text);
            double a = Math.Pow(main, 2);
            txtMain.Text = Convert.ToString(a);
        }

        public void btn1_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            txtMain.Text = txtMain.Text + $"{btn.Content}";
        }
    }
}
