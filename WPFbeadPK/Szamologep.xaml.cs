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

namespace WPFbeadPK
{
    /// <summary>
    /// Interaction logic for Szamologep.xaml
    /// </summary>
    public partial class Szamologep : Window
    {
        public Szamologep()
        {
            InitializeComponent();
        }
        public string[] egyenlet = new string[2];

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            EgyenletBox.Text = EgyenletBox.Text + 1;
        }
        private void button2_Click_1( object sender, RoutedEventArgs e)
        {
            EgyenletBox.Text = EgyenletBox.Text + 2;

        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            EgyenletBox.Text = EgyenletBox.Text + 3;

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            EgyenletBox.Text = EgyenletBox.Text + 4;

        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            EgyenletBox.Text = EgyenletBox.Text + 5;

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            EgyenletBox.Text = EgyenletBox.Text + 6;

        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            EgyenletBox.Text = EgyenletBox.Text + 7;

        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            EgyenletBox.Text = EgyenletBox.Text + 8;

        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            EgyenletBox.Text = EgyenletBox.Text + 9;

        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            EgyenletBox.Text = EgyenletBox.Text + 0;

        }

        private void buttonplusz_Click(object sender, RoutedEventArgs e)
        {
            EgyenletBox.Text = EgyenletBox.Text + "+";
        }

        private void buttonminusz_Click(object sender, RoutedEventArgs e)
        {
            EgyenletBox.Text = EgyenletBox.Text + "-";
        }

        private void buttonszorzo_Click(object sender, RoutedEventArgs e)
        {
            EgyenletBox.Text = EgyenletBox.Text + "*";
        }

        private void buttonoszto_Click(object sender, RoutedEventArgs e)
        {
            EgyenletBox.Text = EgyenletBox.Text + "/";
        }

        private void buttonegyenlo_Click(object sender, RoutedEventArgs e)
        {
            if (EgyenletBox.Text.Contains("+"))
            {
                egyenlet = EgyenletBox.Text.Split('+');

                EgyenletBox.Text += "=";
                EgyenletBox.Text += double.Parse(egyenlet[0]) + double.Parse(egyenlet[1]);
            }
            if (EgyenletBox.Text.Contains("-"))
            {
                egyenlet = EgyenletBox.Text.Split('-');

                EgyenletBox.Text += "=";
                EgyenletBox.Text += double.Parse(egyenlet[0]) - double.Parse(egyenlet[1]);
            }
            if (EgyenletBox.Text.Contains("*"))
            {
                egyenlet = EgyenletBox.Text.Split('*');

                EgyenletBox.Text += "=";
                EgyenletBox.Text += double.Parse(egyenlet[0]) * double.Parse(egyenlet[1]);
            }
            if (EgyenletBox.Text.Contains("/"))
            {
                egyenlet = EgyenletBox.Text.Split('/');
                if (egyenlet[1] == "0")
                {
                    EgyenletBox.Text = "We don't divide by zero!";
                }
                else
                {
                    EgyenletBox.Text += "=";
                    EgyenletBox.Text += double.Parse(egyenlet[0]) / double.Parse(egyenlet[1]);
                }
            }
            EgyenletLista.Text += EgyenletBox.Text + "\n";
            EgyenletBox.Text = null;
        }

        private void buttonlistdelete_Click(object sender, RoutedEventArgs e)
        {
            EgyenletLista.Text = null;
        }

        private void buttonMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Mainw = new MainWindow();
            this.Close();
            Mainw.Show();
        }

        private void buttonvesszo_Click(object sender, RoutedEventArgs e)
        {
            EgyenletBox.Text = EgyenletBox.Text + ",";

        }
    }
}
