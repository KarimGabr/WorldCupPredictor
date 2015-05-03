using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;

namespace PhoneApp1
{
    public partial class Prizes : PhoneApplicationPage
    {
        public Prizes()
        {
            InitializeComponent();
            Image97.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match63Winner + ".jpg", UriKind.Relative));
            Image98.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match64Loser + ".jpg", UriKind.Relative));
            Image99.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match64Winner + ".jpg", UriKind.Relative));

            Name97.Text = PhoneApp1.MainPage.winners.Match63Winner;
            Name98.Text = PhoneApp1.MainPage.winners.Match64Loser;
            Name99.Text = PhoneApp1.MainPage.winners.Match64Winner;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PhoneApp1.MainPage.winners.IsPredictionsAreFinished = true;
            NavigationService.Navigate(new Uri("/CompletePredictions.xaml", UriKind.Relative));
        }
    }
}