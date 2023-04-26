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

namespace WPFbeadPK
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

        private void SZButton_Click(object sender, RoutedEventArgs e)
        {
            Szamologep Szwin = new Szamologep();
            this.Close();
            Szwin.Show();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void KPOButton_Click(object sender, RoutedEventArgs e)
        {
            KPO Kpowin = new KPO();
            this.Close();
            Kpowin.Show();
        }

        private void SzKButton_Click(object sender, RoutedEventArgs e)
        {
            Szamkitalalo Szkwin = new Szamkitalalo();
            this.Close();
            Szkwin.Show();
        }
    }
}
