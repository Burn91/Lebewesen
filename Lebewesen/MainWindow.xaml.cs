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

namespace Lebewesen
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public void ErstelleFisch(int alter, string farbe,int laenge, int maxTiefe, string name)
        {
            Fisch nFisch = new Fisch();
            nFisch.Alter = alter;
            nFisch.Farbe = farbe;
            nFisch.Laenge = laenge;
            nFisch.MaxTiefe = 30;
            nFisch.Name = name;

            LstBox.Items.Add(nFisch.Alter + " " +
                             nFisch.Farbe + " " +
                             nFisch.Laenge + " " +
                             nFisch.MaxTiefe + " " +
                             nFisch.Name);
        }

        public void ErstelleKatze(int alter, string farbe, int groeße, string name, string rasse)
        {
            Katze nKatze = new Katze();
            {
                nKatze.Alter = alter;
                nKatze.Farbe = farbe;
                nKatze.Groeße = groeße;
                nKatze.Name = name;
                nKatze.Rasse = rasse; 
            }

            LstBox.Items.Add(nKatze.Alter + " " +
                             nKatze.Farbe + " " +
                             nKatze.Groeße + " " +
                             nKatze.Name + " " +
                             nKatze.Rasse);
        }

        private void BtnErstelleFIsch_Click(object sender, RoutedEventArgs e)
        {
            ErstelleFisch(40, "grün", 30, 40, "Fischibert");
        }

        private void btnErstelleKatze_Click(object sender, RoutedEventArgs e)
        {
            ErstelleKatze(13, "braun", 20, "Schnurli", "BKH");
        }
    }
}
