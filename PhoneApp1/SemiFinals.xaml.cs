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
    public partial class SemiFinals : PhoneApplicationPage
    {
        public SemiFinals()
        {
            InitializeComponent();
            Image89.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match57Winner + ".jpg", UriKind.Relative));
            Image90.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match58Winner + ".jpg", UriKind.Relative));
            Image91.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match59Winner + ".jpg", UriKind.Relative));
            Image92.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match60Winner + ".jpg", UriKind.Relative));

            Name89.Text = PhoneApp1.MainPage.winners.Match57Winner;
            Name90.Text = PhoneApp1.MainPage.winners.Match58Winner;
            Name91.Text = PhoneApp1.MainPage.winners.Match59Winner;
            Name92.Text = PhoneApp1.MainPage.winners.Match60Winner; 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Finals.xaml", UriKind.Relative));
        }

        private void Grid89_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox89.IsChecked == false)
            {
                Flag89.Visibility = Visibility.Visible;
                Flag90.Visibility = Visibility.Collapsed;
                CheckBox89.IsChecked = true;
                CheckBox90.IsChecked = false;
                PhoneApp1.MainPage.winners.Match61Winner = Name89.Text;
                PhoneApp1.MainPage.winners.Match61Loser = Name90.Text;
            }
            else if (CheckBox89.IsChecked == true)
            {
                Flag89.Visibility = Visibility.Collapsed;
                CheckBox89.IsChecked = false;
                PhoneApp1.MainPage.winners.Match61Winner = null;
                PhoneApp1.MainPage.winners.Match61Loser = null;
            }
        }

        private void Grid90_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox90.IsChecked == false)
            {
                Flag90.Visibility = Visibility.Visible;
                Flag89.Visibility = Visibility.Collapsed;
                CheckBox90.IsChecked = true;
                CheckBox89.IsChecked = false;
                PhoneApp1.MainPage.winners.Match61Winner = Name90.Text;
                PhoneApp1.MainPage.winners.Match61Loser = Name89.Text;
            }
            else if (CheckBox90.IsChecked == true)
            {
                Flag90.Visibility = Visibility.Collapsed;
                CheckBox90.IsChecked = false;
                PhoneApp1.MainPage.winners.Match61Winner = null;
                PhoneApp1.MainPage.winners.Match61Loser = null;
            }
        }

        private void Grid91_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox91.IsChecked == false)
            {
                Flag91.Visibility = Visibility.Visible;
                Flag92.Visibility = Visibility.Collapsed;
                CheckBox91.IsChecked = true;
                CheckBox92.IsChecked = false;
                PhoneApp1.MainPage.winners.Match62Winner = Name91.Text;
                PhoneApp1.MainPage.winners.Match62Loser = Name92.Text;
            }
            else if (CheckBox91.IsChecked == true)
            {
                Flag91.Visibility = Visibility.Collapsed;
                CheckBox91.IsChecked = false;
                PhoneApp1.MainPage.winners.Match62Winner = null;
                PhoneApp1.MainPage.winners.Match62Loser = null;
            }
        }

        private void Grid92_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox92.IsChecked == false)
            {
                Flag92.Visibility = Visibility.Visible;
                Flag91.Visibility = Visibility.Collapsed;
                CheckBox92.IsChecked = true;
                CheckBox91.IsChecked = false;
                PhoneApp1.MainPage.winners.Match62Winner = Name92.Text;
                PhoneApp1.MainPage.winners.Match62Loser = Name91.Text;
            }
            else if (CheckBox92.IsChecked == true)
            {
                Flag92.Visibility = Visibility.Collapsed;
                CheckBox92.IsChecked = false;
                PhoneApp1.MainPage.winners.Match62Winner = null;
                PhoneApp1.MainPage.winners.Match62Loser = null;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TeamInformation.xaml", UriKind.Relative));

        }
    }
}