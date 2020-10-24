using System;
using System.Windows;
using System.Windows.Media;

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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txtMain.Text += 1;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            txtMain.Text += 2;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            txtMain.Text += 3;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            txtMain.Text += 4;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            txtMain.Text += 5;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            txtMain.Text += 6;
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            txtMain.Text += 7;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            txtMain.Text += 8;
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            txtMain.Text += 9;
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            txtMain.Text += 0;
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
            string opperator = Convert.ToString (lblAction.Content);
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
            int random = rnd.Next(1,100);
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
            double a = Math.Pow(main,2);
            txtMain.Text = Convert.ToString(a);
        }
    }
}
