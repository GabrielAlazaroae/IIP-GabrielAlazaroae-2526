using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfFietswinkel
{
    public partial class MainWindow : Window
    {
        private double prijsModel1 = 1399;
        private double prijsModel2 = 1699;
        private double prijsModel3 = 2299;

        private double prijsFietstas = 25;
        private double prijsPompe = 10;
        private double prijsBatterijlamp = 108;

        private int huidigModel = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnModel1_Click(object sender, RoutedEventArgs e)
        {
            huidigModel = 1;
            imgFiets.Source = new System.Windows.Media.Imaging.BitmapImage(
                new Uri("/Images/fiets1.jpg", UriKind.Relative));

            btnModel1.IsEnabled = false;
            btnModel2.IsEnabled = true;
            btnModel3.IsEnabled = true;
        }

        private void btnModel2_Click(object sender, RoutedEventArgs e)
        {
            huidigModel = 2;
            imgFiets.Source = new System.Windows.Media.Imaging.BitmapImage(
                new Uri("/Images/fiets2.jpg", UriKind.Relative));

            btnModel1.IsEnabled = true;
            btnModel2.IsEnabled = false;
            btnModel3.IsEnabled = true;
        }

        private void btnModel3_Click(object sender, RoutedEventArgs e)
        {
            huidigModel = 3;
            imgFiets.Source = new System.Windows.Media.Imaging.BitmapImage(
                new Uri("/Images/fiets3.jpg", UriKind.Relative));

            btnModel1.IsEnabled = true;
            btnModel2.IsEnabled = true;
            btnModel3.IsEnabled = false;
        }

        private void lstAccessoires_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int aantal = lstAccessoires.SelectedItems.Count;
            txtAantalAccessoires.Text = $"{aantal} accessoires geselecteerd";
        }

        private void btnHerbereken_Click(object sender, RoutedEventArgs e)
        {
            double totaal = 0;

            if (huidigModel == 1)
                totaal = prijsModel1;
            else if (huidigModel == 2)
                totaal = prijsModel2;
            else if (huidigModel == 3)
                totaal = prijsModel3;

            foreach (ListBoxItem item in lstAccessoires.SelectedItems)
            {
                string tekst = item.Content.ToString();

                if (tekst.Contains("Fietstas"))
                    totaal += prijsFietstas;
                else if (tekst.Contains("Pompe"))
                    totaal += prijsPompe;
                else if (tekst.Contains("Batterijlamp"))
                    totaal += prijsBatterijlamp;
            }

            txtTotalePrijs.Text = $"€ {totaal:F0}";
        }
    }
}
