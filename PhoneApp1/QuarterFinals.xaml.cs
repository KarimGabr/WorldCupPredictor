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
    public partial class QuarterFinals : PhoneApplicationPage
    {
        public QuarterFinals()
        {
            InitializeComponent();
            Image81.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match49Winner + ".jpg", UriKind.Relative));
            Image82.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match50Winner + ".jpg", UriKind.Relative));
            Image83.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match53Winner + ".jpg", UriKind.Relative));
            Image84.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match54Winner + ".jpg", UriKind.Relative));
            Image85.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match51Winner + ".jpg", UriKind.Relative));
            Image86.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match52Winner + ".jpg", UriKind.Relative));
            Image87.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match55Winner + ".jpg", UriKind.Relative));
            Image88.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match56Winner + ".jpg", UriKind.Relative));

            Name81.Text = PhoneApp1.MainPage.winners.Match49Winner;
            Name82.Text = PhoneApp1.MainPage.winners.Match50Winner;
            Name83.Text = PhoneApp1.MainPage.winners.Match53Winner;
            Name84.Text = PhoneApp1.MainPage.winners.Match54Winner;
            Name85.Text = PhoneApp1.MainPage.winners.Match51Winner;
            Name86.Text = PhoneApp1.MainPage.winners.Match52Winner;
            Name87.Text = PhoneApp1.MainPage.winners.Match55Winner;
            Name88.Text = PhoneApp1.MainPage.winners.Match56Winner;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SemiFinals.xaml", UriKind.Relative));
        }

        private void Grid81_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox81.IsChecked == false)
            {
                Flag81.Visibility = Visibility.Visible;
                Flag82.Visibility = Visibility.Collapsed;
                CheckBox81.IsChecked = true;
                CheckBox82.IsChecked = false;
                PhoneApp1.MainPage.winners.Match57Winner = Name81.Text;
            }
            else if (CheckBox81.IsChecked == true)
            {
                Flag81.Visibility = Visibility.Collapsed;
                CheckBox81.IsChecked = false;
                PhoneApp1.MainPage.winners.Match57Winner = null;
            }
        }

        private void Grid82_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox82.IsChecked == false)
            {
                Flag82.Visibility = Visibility.Visible;
                Flag81.Visibility = Visibility.Collapsed;
                CheckBox82.IsChecked = true;
                CheckBox81.IsChecked = false;
                PhoneApp1.MainPage.winners.Match57Winner = Name82.Text;
            }
            else if (CheckBox82.IsChecked == true)
            {
                Flag82.Visibility = Visibility.Collapsed;
                CheckBox82.IsChecked = false;
                PhoneApp1.MainPage.winners.Match57Winner = null;
            }
        }

        private void Grid83_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox83.IsChecked == false)
            {
                Flag83.Visibility = Visibility.Visible;
                Flag84.Visibility = Visibility.Collapsed;
                CheckBox83.IsChecked = true;
                CheckBox84.IsChecked = false;
                PhoneApp1.MainPage.winners.Match58Winner = Name83.Text;
            }
            else if (CheckBox83.IsChecked == true)
            {
                Flag83.Visibility = Visibility.Collapsed;
                CheckBox83.IsChecked = false;
                PhoneApp1.MainPage.winners.Match58Winner = null;
            }
        }

        private void Grid84_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox84.IsChecked == false)
            {
                Flag84.Visibility = Visibility.Visible;
                Flag83.Visibility = Visibility.Collapsed;
                CheckBox84.IsChecked = true;
                CheckBox83.IsChecked = false;
                PhoneApp1.MainPage.winners.Match58Winner = Name84.Text;
            }
            else if (CheckBox84.IsChecked == true)
            {
                Flag84.Visibility = Visibility.Collapsed;
                CheckBox84.IsChecked = false;
                PhoneApp1.MainPage.winners.Match58Winner = null;
            }
        }

        private void Grid85_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox85.IsChecked == false)
            {
                Flag85.Visibility = Visibility.Visible;
                Flag86.Visibility = Visibility.Collapsed;
                CheckBox85.IsChecked = true;
                CheckBox86.IsChecked = false;
                PhoneApp1.MainPage.winners.Match59Winner = Name85.Text;
            }
            else if (CheckBox85.IsChecked == true)
            {
                Flag85.Visibility = Visibility.Collapsed;
                CheckBox85.IsChecked = false;
                PhoneApp1.MainPage.winners.Match59Winner = null;
            }
        }

        private void Grid86_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox86.IsChecked == false)
            {
                Flag86.Visibility = Visibility.Visible;
                Flag85.Visibility = Visibility.Collapsed;
                CheckBox86.IsChecked = true;
                CheckBox85.IsChecked = false;
                PhoneApp1.MainPage.winners.Match59Winner = Name86.Text;
            }
            else if (CheckBox86.IsChecked == true)
            {
                Flag86.Visibility = Visibility.Collapsed;
                CheckBox86.IsChecked = false;
                PhoneApp1.MainPage.winners.Match59Winner = null;
            }
        }

        private void Grid87_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox87.IsChecked == false)
            {
                Flag87.Visibility = Visibility.Visible;
                Flag88.Visibility = Visibility.Collapsed;
                CheckBox87.IsChecked = true;
                CheckBox88.IsChecked = false;
                PhoneApp1.MainPage.winners.Match60Winner = Name87.Text;
            }
            else if (CheckBox87.IsChecked == true)
            {
                Flag87.Visibility = Visibility.Collapsed;
                CheckBox87.IsChecked = false;
                PhoneApp1.MainPage.winners.Match60Winner = null;
            }
        }

        private void Grid88_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox88.IsChecked == false)
            {
                Flag88.Visibility = Visibility.Visible;
                Flag87.Visibility = Visibility.Collapsed;
                CheckBox88.IsChecked = true;
                CheckBox87.IsChecked = false;
                PhoneApp1.MainPage.winners.Match60Winner = Name88.Text;
            }
            else if (CheckBox88.IsChecked == true)
            {
                Flag88.Visibility = Visibility.Collapsed;
                CheckBox88.IsChecked = false;
                PhoneApp1.MainPage.winners.Match60Winner = null;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TeamInformation.xaml", UriKind.Relative));
        }
    }
}