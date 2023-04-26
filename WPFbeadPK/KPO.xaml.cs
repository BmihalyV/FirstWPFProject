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
    /// Interaction logic for KPO.xaml
    /// </summary>
    public partial class KPO : Window
    {
        public KPO()
        {
            InitializeComponent();
            label3.Content = "Game rules:\n" +
                "-If a player wins, she/he wins a\n bet and the machine wins half of the bet\n" +
                "-If the machine wins, win the \n bet and win a bet from player's money";
        }
        static List<string> Lehetosegek = new List<string>() { "Stone", "Paper", "Scissors" };
        static Random rnd = new Random();
        static int index;
        static int nyertTet = 0;
        static MainWindow Mainw = new MainWindow();
        private string Gepvalsztasa()
        {
            index = rnd.Next(Lehetosegek.Count);
            return Lehetosegek[index];
        }
        private void ButtonJatekosKo_Click(object sender, RoutedEventArgs e)
        {
            if (TetRako.Text == "") Vegeredmeny.Content = "Please place a bet not equal to 0!";
            else
            {
                ValasztottJ.Text = "Stone";
                ValasztottG.Text = Gepvalsztasa();
                if (ValasztottG.Text == "Scissors")
                {
                    nyertTet = (int.Parse(BerakottTet.Text) / 1) + (int.Parse(BerakottTet.Text) / 2);
                    TetJ.Text = $"{int.Parse(TetJ.Text) + nyertTet}";
                    TetG.Text = $"{int.Parse(TetG.Text) - int.Parse(BerakottTet.Text) / 2}";
                }
                if (ValasztottG.Text == "Paper")
                {
                    nyertTet = (int.Parse(BerakottTet.Text) / 1) + (int.Parse(BerakottTet.Text) / 1);
                    TetG.Text = $"{int.Parse(TetG.Text) + nyertTet}";
                    TetJ.Text = $"{int.Parse(TetJ.Text) - int.Parse(BerakottTet.Text)}";
                }
                if (int.Parse(TetJ.Text) <= 0)
                {
                    Vegeredmeny.Content = "Machine won";
                    System.Threading.Thread.Sleep(3000);
                    this.Close();
                    Mainw.Show();
                }
                if (int.Parse(TetG.Text) <= 0)
                {
                    Vegeredmeny.Content = "Player won";
                    System.Threading.Thread.Sleep(3000);
                    this.Close();
                    Mainw.Show();
                }
            }
        }
        private void ButtonJatekosPapir_Click(object sender, RoutedEventArgs e)
        {
            if (TetRako.Text == "") Vegeredmeny.Content = "Please place a bet not equal to 0!";
            else
            {
                ValasztottJ.Text = "Paper";
                ValasztottG.Text = Gepvalsztasa();
                if (ValasztottG.Text == "Stone")
                {
                    nyertTet = (int.Parse(BerakottTet.Text) / 1) + (int.Parse(BerakottTet.Text) / 2);
                    TetJ.Text = $"{int.Parse(TetJ.Text) + nyertTet}";
                    TetG.Text = $"{int.Parse(TetG.Text) - int.Parse(BerakottTet.Text) / 2}";
                }
                if (ValasztottG.Text == "Scissors")
                {
                    nyertTet = (int.Parse(BerakottTet.Text) / 1) + (int.Parse(BerakottTet.Text) / 1);
                    TetG.Text = $"{int.Parse(TetG.Text) + nyertTet}";
                    TetJ.Text = $"{int.Parse(TetJ.Text) - int.Parse(BerakottTet.Text)}";
                }
                if (int.Parse(TetJ.Text) <= 0)
                {
                    Vegeredmeny.Content = "Machine won";
                    System.Threading.Thread.Sleep(3000);
                    this.Close();
                    Mainw.Show();
                }
                if (int.Parse(TetG.Text) <= 0)
                {
                    Vegeredmeny.Content = "Player won";
                    System.Threading.Thread.Sleep(3000);
                    this.Close();
                    Mainw.Show();
                }
            }
        }

        private void ButtomJatekosOllo_Click(object sender, RoutedEventArgs e)
        {
            if (TetRako.Text == "") Vegeredmeny.Content = "Please place a bet not equal to 0!";
            else
            {
                ValasztottJ.Text = "Scissors";
                ValasztottG.Text = Gepvalsztasa();
                if (ValasztottG.Text == "Paper")
                {
                    nyertTet = (int.Parse(BerakottTet.Text) / 1) + (int.Parse(BerakottTet.Text) / 2);
                    TetJ.Text = $"{int.Parse(TetJ.Text) + nyertTet}";
                    TetG.Text = $"{int.Parse(TetG.Text) - int.Parse(BerakottTet.Text) / 2}";
                }
                if (ValasztottG.Text == "Stone")
                {
                    nyertTet = (int.Parse(BerakottTet.Text) / 1) + (int.Parse(BerakottTet.Text) / 1);
                    TetG.Text = $"{int.Parse(TetG.Text) + nyertTet}";
                    TetJ.Text = $"{int.Parse(TetJ.Text) - int.Parse(BerakottTet.Text)}";
                }
                if (int.Parse(TetJ.Text) <= 0)
                {
                    Vegeredmeny.Content = "Machine won";
                    System.Threading.Thread.Sleep(3000);
                    this.Close();
                    Mainw.Show();
                }
                if (int.Parse(TetG.Text) <= 0)
                {
                    Vegeredmeny.Content = "Player won";
                    System.Threading.Thread.Sleep(3000);
                    this.Close();
                    Mainw.Show();
                }
            }
        }

        private void TetOsztott_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Tetrakogomb_Click(object sender, RoutedEventArgs e)
        {

            if (TetOsztott.Text.EndsWith("0") || TetOsztott.Text.EndsWith("2") || TetOsztott.Text.EndsWith("4")
                || TetOsztott.Text.EndsWith("6") || TetOsztott.Text.EndsWith("8"))
            {
                TetJ.Text =  TetG.Text = $"{int.Parse(TetOsztott.Text) / 2}";
            }
            else
            {
                Vegeredmeny.Content = "Kérem adjon meg 0-ra , 2-re, 4-re, 6-ra vagy 8-ra végződő tétet!";
                TetJ.Text = TetG.Text = "0";
            }

        }

        private void Mehet_Click(object sender, RoutedEventArgs e)
        {
            if (TetRako.Text == "") Vegeredmeny.Content = "Kérem rakjon meg nem 0-val egyenlő tétet!";
            BerakottTet.Text = TetRako.Text;
            if (int.Parse(TetJ.Text) >= int.Parse(TetRako.Text))
            {
                BerakottTet.Text = TetRako.Text;
            }
            else BerakottTet.Text = "Nincs ennyi pénze!";
        }

        private void buttonMain_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Mainw.Show();
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            TetJ.Text = TetG.Text = ValasztottJ.Text = ValasztottG.Text = TetOsztott.Text = TetRako.Text = BerakottTet.Text = ""; 
        }
    }
}
