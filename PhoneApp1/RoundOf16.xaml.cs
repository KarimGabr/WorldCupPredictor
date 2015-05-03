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
    public partial class RoundOf16 : PhoneApplicationPage
    {
        public RoundOf16()
        {
            InitializeComponent();
            
            Image65.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.AFirstPlace + ".jpg", UriKind.Relative));
            Image66.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.BSecondPlace + ".jpg", UriKind.Relative));

            Image67.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.CFirstPlace + ".jpg", UriKind.Relative));
            Image68.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.DSecondPlace + ".jpg", UriKind.Relative));

            Image69.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.ASecondPlace + ".jpg", UriKind.Relative));
            Image70.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.BFirstPlace + ".jpg", UriKind.Relative));

            Image71.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.CSecondPlace + ".jpg", UriKind.Relative));
            Image72.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.DFirstPlace + ".jpg", UriKind.Relative));

            Image73.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.EFirstPlace + ".jpg", UriKind.Relative));
            Image74.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.FSecondPlace + ".jpg", UriKind.Relative));

            Image75.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.GFirstPlace + ".jpg", UriKind.Relative));
            Image76.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.HSecondPlace + ".jpg", UriKind.Relative));

            Image77.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.ESecondPlace + ".jpg", UriKind.Relative));
            Image78.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.FFirstPlace + ".jpg", UriKind.Relative));

            Image79.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.GSecondPlace + ".jpg", UriKind.Relative));
            Image80.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.HFirstPlace + ".jpg", UriKind.Relative));
            
            Name65.Text = PhoneApp1.MainPage.winners.AFirstPlace;
            Name66.Text = PhoneApp1.MainPage.winners.BSecondPlace;

            Name67.Text = PhoneApp1.MainPage.winners.CFirstPlace;
            Name68.Text = PhoneApp1.MainPage.winners.DSecondPlace;

            Name69.Text = PhoneApp1.MainPage.winners.ASecondPlace;
            Name70.Text = PhoneApp1.MainPage.winners.BFirstPlace;

            Name71.Text = PhoneApp1.MainPage.winners.CSecondPlace;
            Name72.Text = PhoneApp1.MainPage.winners.DFirstPlace;

            Name73.Text = PhoneApp1.MainPage.winners.EFirstPlace;
            Name74.Text = PhoneApp1.MainPage.winners.FSecondPlace;

            Name75.Text = PhoneApp1.MainPage.winners.GFirstPlace;
            Name76.Text = PhoneApp1.MainPage.winners.HSecondPlace;

            Name77.Text = PhoneApp1.MainPage.winners.ESecondPlace;
            Name78.Text = PhoneApp1.MainPage.winners.FFirstPlace;

            Name79.Text = PhoneApp1.MainPage.winners.GSecondPlace;
            Name80.Text = PhoneApp1.MainPage.winners.HFirstPlace;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/QuarterFinals.xaml", UriKind.Relative));
        }

        private void Grid65_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox65.IsChecked == false)
            {
                Flag65.Visibility = Visibility.Visible;
                Flag66.Visibility = Visibility.Collapsed;
                CheckBox65.IsChecked = true;
                CheckBox66.IsChecked = false;
                PhoneApp1.MainPage.winners.Match49Winner = Name65.Text;
            }
            else if (CheckBox65.IsChecked == true)
            {
                Flag65.Visibility = Visibility.Collapsed;
                CheckBox65.IsChecked = false;
                PhoneApp1.MainPage.winners.Match49Winner = null;
            }
        }

        private void Grid66_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox66.IsChecked == false)
            {
                Flag66.Visibility = Visibility.Visible;
                Flag65.Visibility = Visibility.Collapsed;
                CheckBox66.IsChecked = true;
                CheckBox65.IsChecked = false;
                PhoneApp1.MainPage.winners.Match49Winner = Name66.Text;
            }
            else if (CheckBox66.IsChecked == true)
            {
                Flag66.Visibility = Visibility.Collapsed;
                CheckBox66.IsChecked = false;
                PhoneApp1.MainPage.winners.Match49Winner = null;
            }
        }

        private void Grid67_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox67.IsChecked == false)
            {
                Flag67.Visibility = Visibility.Visible;
                Flag68.Visibility = Visibility.Collapsed;
                CheckBox67.IsChecked = true;
                CheckBox68.IsChecked = false;
                PhoneApp1.MainPage.winners.Match50Winner = Name67.Text;
            }
            else if (CheckBox67.IsChecked == true)
            {
                Flag67.Visibility = Visibility.Collapsed;
                CheckBox67.IsChecked = false;
                PhoneApp1.MainPage.winners.Match50Winner = null;
            }
        }

        private void Grid68_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox68.IsChecked == false)
            {
                Flag68.Visibility = Visibility.Visible;
                Flag67.Visibility = Visibility.Collapsed;
                CheckBox68.IsChecked = true;
                CheckBox67.IsChecked = false;
                PhoneApp1.MainPage.winners.Match50Winner = Name68.Text;
            }
            else if (CheckBox68.IsChecked == true)
            {
                Flag68.Visibility = Visibility.Collapsed;
                CheckBox68.IsChecked = false;
                PhoneApp1.MainPage.winners.Match50Winner = null;
            }
        }

        private void Grid69_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox69.IsChecked == false)
            {
                Flag69.Visibility = Visibility.Visible;
                Flag70.Visibility = Visibility.Collapsed;
                CheckBox69.IsChecked = true;
                CheckBox70.IsChecked = false;
                PhoneApp1.MainPage.winners.Match51Winner = Name69.Text;
            }
            else if (CheckBox69.IsChecked == true)
            {
                Flag69.Visibility = Visibility.Collapsed;
                CheckBox69.IsChecked = false;
                PhoneApp1.MainPage.winners.Match51Winner = null;
            }
        }

        private void Grid70_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox70.IsChecked == false)
            {
                Flag70.Visibility = Visibility.Visible;
                Flag69.Visibility = Visibility.Collapsed;
                CheckBox70.IsChecked = true;
                CheckBox69.IsChecked = false;
                PhoneApp1.MainPage.winners.Match51Winner = Name70.Text;
            }
            else if (CheckBox70.IsChecked == true)
            {
                Flag70.Visibility = Visibility.Collapsed;
                CheckBox70.IsChecked = false;
                PhoneApp1.MainPage.winners.Match51Winner = null;
            }
        }

        private void Grid71_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox71.IsChecked == false)
            {
                Flag71.Visibility = Visibility.Visible;
                Flag72.Visibility = Visibility.Collapsed;
                CheckBox71.IsChecked = true;
                CheckBox72.IsChecked = false;
                PhoneApp1.MainPage.winners.Match52Winner = Name71.Text;
            }
            else if (CheckBox71.IsChecked == true)
            {
                Flag71.Visibility = Visibility.Collapsed;
                CheckBox71.IsChecked = false;
                PhoneApp1.MainPage.winners.Match52Winner = null;
            }
        }

        private void Grid72_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox72.IsChecked == false)
            {
                Flag72.Visibility = Visibility.Visible;
                Flag71.Visibility = Visibility.Collapsed;
                CheckBox72.IsChecked = true;
                CheckBox71.IsChecked = false;
                PhoneApp1.MainPage.winners.Match52Winner = Name72.Text;
            }
            else if (CheckBox72.IsChecked == true)
            {
                Flag72.Visibility = Visibility.Collapsed;
                CheckBox72.IsChecked = false;
                PhoneApp1.MainPage.winners.Match52Winner = null;
            }
        }

        private void Grid73_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox73.IsChecked == false)
            {
                Flag73.Visibility = Visibility.Visible;
                Flag74.Visibility = Visibility.Collapsed;
                CheckBox73.IsChecked = true;
                CheckBox74.IsChecked = false;
                PhoneApp1.MainPage.winners.Match53Winner = Name73.Text;
            }
            else if (CheckBox73.IsChecked == true)
            {
                Flag73.Visibility = Visibility.Collapsed;
                CheckBox73.IsChecked = false;
                PhoneApp1.MainPage.winners.Match53Winner = null;
            }
        }

        private void Grid74_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox74.IsChecked == false)
            {
                Flag74.Visibility = Visibility.Visible;
                Flag73.Visibility = Visibility.Collapsed;
                CheckBox74.IsChecked = true;
                CheckBox73.IsChecked = false;
                PhoneApp1.MainPage.winners.Match53Winner = Name74.Text;
            }
            else if (CheckBox74.IsChecked == true)
            {
                Flag74.Visibility = Visibility.Collapsed;
                CheckBox74.IsChecked = false;
                PhoneApp1.MainPage.winners.Match53Winner = null;
            }
        }

        private void Grid75_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox75.IsChecked == false)
            {
                Flag75.Visibility = Visibility.Visible;
                Flag76.Visibility = Visibility.Collapsed;
                CheckBox75.IsChecked = true;
                CheckBox76.IsChecked = false;
                PhoneApp1.MainPage.winners.Match54Winner = Name75.Text;
            }
            else if (CheckBox75.IsChecked == true)
            {
                Flag75.Visibility = Visibility.Collapsed;
                CheckBox75.IsChecked = false;
                PhoneApp1.MainPage.winners.Match54Winner = null;
            }
        }

        private void Grid76_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox76.IsChecked == false)
            {
                Flag76.Visibility = Visibility.Visible;
                Flag75.Visibility = Visibility.Collapsed;
                CheckBox76.IsChecked = true;
                CheckBox75.IsChecked = false;
                PhoneApp1.MainPage.winners.Match54Winner = Name76.Text;
            }
            else if (CheckBox76.IsChecked == true)
            {
                Flag76.Visibility = Visibility.Collapsed;
                CheckBox76.IsChecked = false;
                PhoneApp1.MainPage.winners.Match54Winner = null;
            }
        }

        private void Grid77_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox77.IsChecked == false)
            {
                Flag77.Visibility = Visibility.Visible;
                Flag78.Visibility = Visibility.Collapsed;
                CheckBox77.IsChecked = true;
                CheckBox78.IsChecked = false;
                PhoneApp1.MainPage.winners.Match55Winner = Name77.Text;
            }
            else if (CheckBox77.IsChecked == true)
            {
                Flag77.Visibility = Visibility.Collapsed;
                CheckBox77.IsChecked = false;
                PhoneApp1.MainPage.winners.Match55Winner = null;
            }
        }

        private void Grid78_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox78.IsChecked == false)
            {
                Flag78.Visibility = Visibility.Visible;
                Flag77.Visibility = Visibility.Collapsed;
                CheckBox78.IsChecked = true;
                CheckBox77.IsChecked = false;
                PhoneApp1.MainPage.winners.Match55Winner = Name78.Text;
            }
            else if (CheckBox78.IsChecked == true)
            {
                Flag78.Visibility = Visibility.Collapsed;
                CheckBox78.IsChecked = false;
                PhoneApp1.MainPage.winners.Match55Winner = null;
            }
        }

        private void Grid79_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox79.IsChecked == false)
            {
                Flag79.Visibility = Visibility.Visible;
                Flag80.Visibility = Visibility.Collapsed;
                CheckBox79.IsChecked = true;
                CheckBox80.IsChecked = false;
                PhoneApp1.MainPage.winners.Match56Winner = Name79.Text;
            }
            else if (CheckBox79.IsChecked == true)
            {
                Flag79.Visibility = Visibility.Collapsed;
                CheckBox79.IsChecked = false;
                PhoneApp1.MainPage.winners.Match56Winner = null;
            }
        }

        private void Grid80_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox80.IsChecked == false)
            {
                Flag80.Visibility = Visibility.Visible;
                Flag79.Visibility = Visibility.Collapsed;
                CheckBox80.IsChecked = true;
                CheckBox79.IsChecked = false;
                PhoneApp1.MainPage.winners.Match56Winner = Name80.Text;
            }
            else if (CheckBox80.IsChecked == true)
            {
                Flag80.Visibility = Visibility.Collapsed;
                CheckBox80.IsChecked = false;
                PhoneApp1.MainPage.winners.Match56Winner = null;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TeamInformation.xaml", UriKind.Relative));

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TeamInformation.xaml", UriKind.Relative));

        }

    }
}