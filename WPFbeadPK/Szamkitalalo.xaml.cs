using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Threading;

namespace WPFbeadPK
{
    /// <summary>
    /// Interaction logic for Szamkitalalo.xaml
    /// </summary>
    public partial class Szamkitalalo : Window
    {
        public Random rnd = new Random();
        static int Generaltszam = 0;
        public Szamkitalalo()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            KisebbX.Content = "Smaller than " + SzambevivoText.Text;
            NagyobbX.Content = "Greater than " + SzambevivoText.Text;
            EgyenloX.Content = "Equal to " + SzambevivoText.Text;
        }
        public int RandomGeneraloAltaliSzam()
        {
            Generaltszam = rnd.Next(int.Parse(Hataralso.Text), int.Parse(Hatarfelso.Text));
            return Generaltszam;
        }

        private void KisebbX_Click(object sender, RoutedEventArgs e)
        {
            if (SzambevivoText.Text == "") SegitoText.Text = "Give tips first!";
            else
            {
                
                if (int.Parse(SzambevivoText.Text) < int.Parse(Hataralso.Text) || int.Parse(SzambevivoText.Text) > int.Parse(Hatarfelso.Text))
                    SegitoText.Text = "Not correct";
                else
                {
                    if (Generaltszam > int.Parse(SzambevivoText.Text))
                    {
                        SegitoText.Text = "Not smaller, bigger than " + SzambevivoText.Text;
                        ElozmenyBox.Text += "Greater than " + SzambevivoText.Text + "\n";
                    }
                    if (Generaltszam < int.Parse(SzambevivoText.Text))
                    {
                        SegitoText.Text = "That's right, smaller than " + SzambevivoText.Text;
                        ElozmenyBox.Text += "Smaller than " + SzambevivoText.Text + "\n";
                    }
                    if (Generaltszam == int.Parse(SzambevivoText.Text))
                    {
                        SegitoText.Text = "It's not less, it's equal with " + SzambevivoText.Text;
                        ElozmenyBox.Text += "Equal to " + SzambevivoText.Text + "\n";
                    }
                }
            }
        }

        private void NagyobbX_Click(object sender, RoutedEventArgs e)
        {
            if (SzambevivoText.Text == "") SegitoText.Text = "Give tips first!";
            else
            {
                
                if (int.Parse(SzambevivoText.Text) < int.Parse(Hataralso.Text) || int.Parse(SzambevivoText.Text) > int.Parse(Hatarfelso.Text))
                    SegitoText.Text = "Not correct";
                else
                {
                    if (Generaltszam > int.Parse(SzambevivoText.Text))
                    {
                        SegitoText.Text = "That's right, greater than " + SzambevivoText.Text;
                        ElozmenyBox.Text += "Greater than " + SzambevivoText.Text + "\n";
                    }
                    if (Generaltszam < int.Parse(SzambevivoText.Text))
                    {
                        SegitoText.Text = "Not greater than, less than " + SzambevivoText.Text;
                        ElozmenyBox.Text += "Smaller than " + SzambevivoText.Text + "\n";
                    }
                    if (Generaltszam == int.Parse(SzambevivoText.Text))
                    {
                        SegitoText.Text = "Not greater, equal to " + SzambevivoText.Text;
                        ElozmenyBox.Text += "Equal to " + SzambevivoText.Text + "\n";
                    }
                }
            }
        }

        private void EgyenloX_Click(object sender, RoutedEventArgs e)
        {

            if (SzambevivoText.Text == "") SegitoText.Text = "Give tips first!";
            else
            {
                
                if (int.Parse(SzambevivoText.Text) < int.Parse(Hataralso.Text) || int.Parse(SzambevivoText.Text) > int.Parse(Hatarfelso.Text))
                    SegitoText.Text = "Not correct";
                else
                {
                    if (Generaltszam > int.Parse(SzambevivoText.Text))
                    {
                        SegitoText.Text = "Not equal to, greater than " + SzambevivoText.Text;
                        ElozmenyBox.Text += "Greater than " + SzambevivoText.Text + "\n";
                    }
                    if (Generaltszam < int.Parse(SzambevivoText.Text))
                    {
                        SegitoText.Text = "Not equal to, smaller than " + SzambevivoText.Text;
                        ElozmenyBox.Text += "Smaller than " + SzambevivoText.Text + "\n";
                    }
                    if (Generaltszam == int.Parse(SzambevivoText.Text))
                    {
                        SegitoText.Text = "Equal to " + SzambevivoText.Text;
                        ElozmenyBox.Text += "Equal to " + SzambevivoText.Text + "\n";
                    }
                }
            }
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            if (SzambevivoText.Text == "") SegitoText.Text = "Give tips first!";
            else
            {
                HelpText.Visibility = Visibility.Visible;
                if (Hataralso.Text == "" || Hatarfelso.Text == "") HelpText.Text = "Set boundaries first!";
                if (int.Parse(Hatarfelso.Text) - int.Parse(Hataralso.Text) <= 100)
                    HelpText.Text = $"The number is between {Generaltszam - 10} and {Generaltszam + 10}";
                else if (int.Parse(Hatarfelso.Text) - int.Parse(Hataralso.Text) <= 150 &&
                    int.Parse(Hatarfelso.Text) - int.Parse(Hataralso.Text) > 100)
                    HelpText.Text = $"The number is between {Generaltszam - 20} and {Generaltszam + 20}";
                else
                    HelpText.Text = $"The number is between {Generaltszam - 30} and {Generaltszam + 30}";
            }
        }

        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            if (Hatarfelso.Text == "" || Hataralso.Text == "") SegitoText.Text = "Please give limits!";
            else if (int.Parse(Hataralso.Text) > int.Parse(Hatarfelso.Text)) SegitoText.Text = "Please enter the limits in reverse!!";
            else
            {
                SegitoText.Text = "Generated a number";
                RandomGeneraloAltaliSzam();
            }
        }

        private void buttonMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Mainw = new MainWindow();
            this.Close();
            Mainw.Show();
        }
    }
}
