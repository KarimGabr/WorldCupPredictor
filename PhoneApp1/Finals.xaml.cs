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
    public partial class Medals : PhoneApplicationPage
    {
        public Medals()
        {
            InitializeComponent();
            Image93.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match61Loser + ".jpg", UriKind.Relative));
            Image94.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match62Loser + ".jpg", UriKind.Relative));
            Image95.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match61Winner + ".jpg", UriKind.Relative));
            Image96.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match62Winner + ".jpg", UriKind.Relative));

            Name93.Text = PhoneApp1.MainPage.winners.Match61Loser;
            Name94.Text = PhoneApp1.MainPage.winners.Match62Loser;
            Name95.Text = PhoneApp1.MainPage.winners.Match61Winner;
            Name96.Text = PhoneApp1.MainPage.winners.Match62Winner; 
        }

        private void Grid93_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox93.IsChecked == false)
            {
                Flag93.Visibility = Visibility.Visible;
                Flag94.Visibility = Visibility.Collapsed;
                CheckBox93.IsChecked = true;
                CheckBox94.IsChecked = false;
                PhoneApp1.MainPage.winners.Match63Winner = Name93.Text;
            }
            else if (CheckBox93.IsChecked == true)
            {
                Flag93.Visibility = Visibility.Collapsed;
                CheckBox93.IsChecked = false;
                PhoneApp1.MainPage.winners.Match63Winner = null;
            }
        }

        private void Grid94_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox94.IsChecked == false)
            {
                Flag94.Visibility = Visibility.Visible;
                Flag93.Visibility = Visibility.Collapsed;
                CheckBox94.IsChecked = true;
                CheckBox93.IsChecked = false;
                PhoneApp1.MainPage.winners.Match63Winner = Name94.Text;
            }
            else if (CheckBox94.IsChecked == true)
            {
                Flag94.Visibility = Visibility.Collapsed;
                CheckBox94.IsChecked = false;
                PhoneApp1.MainPage.winners.Match63Winner = null;
            }
        }

        private void Grid95_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox95.IsChecked == false)
            {
                Flag95.Visibility = Visibility.Visible;
                Flag96.Visibility = Visibility.Collapsed;
                CheckBox95.IsChecked = true;
                CheckBox96.IsChecked = false;
                PhoneApp1.MainPage.winners.Match64Winner = Name95.Text;
                PhoneApp1.MainPage.winners.Match64Loser = Name96.Text;
            }
            else if (CheckBox95.IsChecked == true)
            {
                Flag95.Visibility = Visibility.Collapsed;
                CheckBox95.IsChecked = false;
                PhoneApp1.MainPage.winners.Match64Winner = null;
                PhoneApp1.MainPage.winners.Match64Loser = null;
            }
        }

        private void Grid96_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox96.IsChecked == false)
            {
                Flag96.Visibility = Visibility.Visible;
                Flag95.Visibility = Visibility.Collapsed;
                CheckBox96.IsChecked = true;
                CheckBox95.IsChecked = false;
                PhoneApp1.MainPage.winners.Match64Winner = Name96.Text;
                PhoneApp1.MainPage.winners.Match64Loser = Name95.Text;
            }
            else if (CheckBox96.IsChecked == true)
            {
                Flag96.Visibility = Visibility.Collapsed;
                CheckBox96.IsChecked = false;
                PhoneApp1.MainPage.winners.Match64Winner = null;
                PhoneApp1.MainPage.winners.Match64Loser = null;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Prizes.xaml", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TeamInformation.xaml", UriKind.Relative));
        }
   

    }
}