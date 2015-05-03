using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;


namespace PhoneApp1
{
    public partial class GroupsRound : PhoneApplicationPage
    {
        public GroupsRound()
        {
            InitializeComponent();
        }
        
        public static class counters
        {
            public static int cF1 = 0;
            public static int cF2 = 0;
            public static int cF3 = 0;
            public static int cF4 = 0;
            public static int cF5 = 0;
            public static int cF6 = 0;
            public static int cF7 = 0;
            public static int cF8 = 0;
            public static int cF9 = 0;
            public static int cF10 = 0;
            public static int cF11 = 0;
            public static int cF12 = 0;
            public static int cF13 = 0;
            public static int cF14 = 0;
            public static int cF15 = 0;
            public static int cF16 = 0;
            public static int cF17 = 0;
            public static int cF18 = 0;
            public static int cF19 = 0;
            public static int cF20 = 0;
            public static int cF21 = 0;
            public static int cF22 = 0;
            public static int cF23 = 0;
            public static int cF24 = 0;
            public static int cF25 = 0;
            public static int cF26 = 0;
            public static int cF27 = 0;
            public static int cF28 = 0;
            public static int cF29 = 0;
            public static int cF30 = 0;
            public static int cF31 = 0;
            public static int cF32 = 0;
            public static int cS1 = 0;
            public static int cS2 = 0;
            public static int cS3 = 0;
            public static int cS4 = 0;
            public static int cS5 = 0;
            public static int cS6 = 0;
            public static int cS7 = 0;
            public static int cS8 = 0;
            public static int cS9 = 0;
            public static int cS10 = 0;
            public static int cS11 = 0;
            public static int cS12 = 0;
            public static int cS13 = 0;
            public static int cS14 = 0;
            public static int cS15 = 0;
            public static int cS16 = 0;
            public static int cS17 = 0;
            public static int cS18 = 0;
            public static int cS19 = 0;
            public static int cS20 = 0;
            public static int cS21 = 0;
            public static int cS22 = 0;
            public static int cS23 = 0;
            public static int cS24 = 0;
            public static int cS25 = 0;
            public static int cS26 = 0;
            public static int cS27 = 0;
            public static int cS28 = 0;
            public static int cS29 = 0;
            public static int cS30 = 0;
            public static int cS31 = 0;
            public static int cS32 = 0;
        }
        
        private void Grid1_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox1.IsChecked == false)
            {
                if (cS1 == 0)
                {
                    cF1 = 1;
                    cF2 = 0;
                    cF3 = 0;
                    cF4 = 0;
                    Flag1.Visibility = Visibility.Visible;
                    Flag2.Visibility = Visibility.Collapsed;
                    Flag3.Visibility = Visibility.Collapsed;
                    Flag4.Visibility = Visibility.Collapsed;
                    CheckBox1.IsChecked = true;
                    CheckBox2.IsChecked = false;
                    CheckBox3.IsChecked = false;
                    CheckBox4.IsChecked = false;
                    PhoneApp1.MainPage.winners.AFirstPlace = "Brazil";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox1.IsChecked == true)
            {
                cF1 = 0;
                Flag1.Visibility = Visibility.Collapsed;
                CheckBox1.IsChecked = false;
                PhoneApp1.MainPage.winners.AFirstPlace = null;
            }
        }

        private void Grid2_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox2.IsChecked == false)
            {
                if (cS2 == 0)
                {
                    cF2 = 1;
                    cF1 = 0;
                    cF3 = 0;
                    cF4 = 0;
                    Flag2.Visibility = Visibility.Visible;
                    Flag1.Visibility = Visibility.Collapsed;
                    Flag3.Visibility = Visibility.Collapsed;
                    Flag4.Visibility = Visibility.Collapsed;
                    CheckBox2.IsChecked = true;
                    CheckBox1.IsChecked = false;
                    CheckBox3.IsChecked = false;
                    CheckBox4.IsChecked = false;
                    PhoneApp1.MainPage.winners.AFirstPlace = "Croatia";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox2.IsChecked == true)
            {
                cF2 = 0;
                Flag2.Visibility = Visibility.Collapsed;
                CheckBox2.IsChecked = false;
                PhoneApp1.MainPage.winners.AFirstPlace = null;
            }
        }

        private void Grid3_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox3.IsChecked == false)
            {
                if (cS3 == 0)
                {
                    cF3 = 1;
                    cF1 = 0;
                    cF2 = 0;
                    cF4 = 0;
                    Flag3.Visibility = Visibility.Visible;
                    Flag1.Visibility = Visibility.Collapsed;
                    Flag2.Visibility = Visibility.Collapsed;
                    Flag4.Visibility = Visibility.Collapsed;
                    CheckBox3.IsChecked = true;
                    CheckBox1.IsChecked = false;
                    CheckBox2.IsChecked = false;
                    CheckBox4.IsChecked = false;
                    PhoneApp1.MainPage.winners.AFirstPlace = "Cameroon";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox3.IsChecked == true)
            {
                cF3 = 0;
                Flag3.Visibility = Visibility.Collapsed;
                CheckBox3.IsChecked = false;
                PhoneApp1.MainPage.winners.AFirstPlace = null;
            }
        }

        private void Grid4_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox4.IsChecked == false)
            {
                if (cS4 == 0)
                {
                    cF4 = 1;
                    cF1 = 0;
                    cF2 = 0;
                    cF3 = 0;
                    Flag4.Visibility = Visibility.Visible;
                    Flag1.Visibility = Visibility.Collapsed;
                    Flag2.Visibility = Visibility.Collapsed;
                    Flag3.Visibility = Visibility.Collapsed;
                    CheckBox4.IsChecked = true;
                    CheckBox1.IsChecked = false;
                    CheckBox2.IsChecked = false;
                    CheckBox3.IsChecked = false;
                    PhoneApp1.MainPage.winners.AFirstPlace = "Mexico";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox4.IsChecked == true)
            {
                cF4 = 0;
                Flag4.Visibility = Visibility.Collapsed;
                CheckBox4.IsChecked = false;
                PhoneApp1.MainPage.winners.AFirstPlace = null;
            }
        }

        private void Grid5_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox5.IsChecked == false)
            {
                if (cF1 == 0)
                {
                    cS1 = 1;
                    cS2 = 0;
                    cS3 = 0;
                    cS4 = 0;
                    Flag5.Visibility = Visibility.Visible;
                    Flag6.Visibility = Visibility.Collapsed;
                    Flag7.Visibility = Visibility.Collapsed;
                    Flag8.Visibility = Visibility.Collapsed;
                    CheckBox5.IsChecked = true;
                    CheckBox6.IsChecked = false;
                    CheckBox7.IsChecked = false;
                    CheckBox8.IsChecked = false;
                    PhoneApp1.MainPage.winners.ASecondPlace = "Brazil";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox5.IsChecked == true)
            {
                cS1 = 0;
                Flag5.Visibility = Visibility.Collapsed;
                CheckBox5.IsChecked = false;
                PhoneApp1.MainPage.winners.ASecondPlace = null;
            }
        }

        private void Grid6_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox6.IsChecked == false)
            {
                if (cF2 == 0)
                {
                    cS2 = 1;
                    cS1 = 0;
                    cS3 = 0;
                    cS4 = 0;
                    Flag6.Visibility = Visibility.Visible;
                    Flag5.Visibility = Visibility.Collapsed;
                    Flag7.Visibility = Visibility.Collapsed;
                    Flag8.Visibility = Visibility.Collapsed;
                    CheckBox6.IsChecked = true;
                    CheckBox5.IsChecked = false;
                    CheckBox7.IsChecked = false;
                    CheckBox8.IsChecked = false;
                    PhoneApp1.MainPage.winners.ASecondPlace = "Croatia";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox6.IsChecked == true)
            {
                cS2 = 0;
                Flag6.Visibility = Visibility.Collapsed;
                CheckBox6.IsChecked = false;
                PhoneApp1.MainPage.winners.ASecondPlace = null;
            }
        }

        private void Grid7_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox7.IsChecked == false)
            {
                if (cF3 == 0)
                {
                    cS3 = 1;
                    cS1 = 0;
                    cS2 = 0;
                    cS4 = 0;
                    Flag7.Visibility = Visibility.Visible;
                    Flag5.Visibility = Visibility.Collapsed;
                    Flag6.Visibility = Visibility.Collapsed;
                    Flag8.Visibility = Visibility.Collapsed;
                    CheckBox7.IsChecked = true;
                    CheckBox5.IsChecked = false;
                    CheckBox6.IsChecked = false;
                    CheckBox8.IsChecked = false;
                    PhoneApp1.MainPage.winners.ASecondPlace = "Cameroon";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox7.IsChecked == true)
            {
                cS3 = 0;
                Flag7.Visibility = Visibility.Collapsed;
                CheckBox7.IsChecked = false;
                PhoneApp1.MainPage.winners.ASecondPlace = null;
            }
        }

        private void Grid8_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox8.IsChecked == false)
            {
                if (cF4 == 0)
                {
                    cS4 = 1;
                    cS1 = 0;
                    cS2 = 0;
                    cS3 = 0;
                    Flag8.Visibility = Visibility.Visible;
                    Flag5.Visibility = Visibility.Collapsed;
                    Flag6.Visibility = Visibility.Collapsed;
                    Flag7.Visibility = Visibility.Collapsed;
                    CheckBox8.IsChecked = true;
                    CheckBox5.IsChecked = false;
                    CheckBox6.IsChecked = false;
                    CheckBox7.IsChecked = false;
                    PhoneApp1.MainPage.winners.ASecondPlace = "Mexico";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox8.IsChecked == true)
            {
                cS4 = 0;
                Flag8.Visibility = Visibility.Collapsed;
                CheckBox8.IsChecked = false;
                PhoneApp1.MainPage.winners.ASecondPlace = null;
            }
        }

        private void Grid9_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox9.IsChecked == false)
            {
                if (cS5 == 0)
                {
                    cF5 = 1;
                    cF6 = 0;
                    cF7 = 0;
                    cF8 = 0;
                    Flag9.Visibility = Visibility.Visible;
                    Flag10.Visibility = Visibility.Collapsed;
                    Flag11.Visibility = Visibility.Collapsed;
                    Flag12.Visibility = Visibility.Collapsed;
                    CheckBox9.IsChecked = true;
                    CheckBox10.IsChecked = false;
                    CheckBox11.IsChecked = false;
                    CheckBox12.IsChecked = false;
                    PhoneApp1.MainPage.winners.BFirstPlace = "Australia";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox9.IsChecked == true)
            {
                cF5 = 0;
                Flag9.Visibility = Visibility.Collapsed;
                CheckBox9.IsChecked = false;
                PhoneApp1.MainPage.winners.BFirstPlace = null;
            }
        }

        private void Grid10_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox10.IsChecked == false)
            {
                if (cS6 == 0)
                {
                    cF6 = 1;
                    cF5 = 0;
                    cF7 = 0;
                    cF8 = 0;
                    Flag10.Visibility = Visibility.Visible;
                    Flag9.Visibility = Visibility.Collapsed;
                    Flag11.Visibility = Visibility.Collapsed;
                    Flag12.Visibility = Visibility.Collapsed;
                    CheckBox10.IsChecked = true;
                    CheckBox9.IsChecked = false;
                    CheckBox11.IsChecked = false;
                    CheckBox12.IsChecked = false;
                    PhoneApp1.MainPage.winners.BFirstPlace = "Chile";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox10.IsChecked == true)
            {
                cF6 = 0;
                Flag10.Visibility = Visibility.Collapsed;
                CheckBox10.IsChecked = false;
                PhoneApp1.MainPage.winners.BFirstPlace = null;
            }
        }

        private void Grid11_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox11.IsChecked == false)
            {
                if (cS7 == 0)
                {
                    cF7 = 1;
                    cF5 = 0;
                    cF6 = 0;
                    cF8 = 0;
                    Flag11.Visibility = Visibility.Visible;
                    Flag9.Visibility = Visibility.Collapsed;
                    Flag10.Visibility = Visibility.Collapsed;
                    Flag12.Visibility = Visibility.Collapsed;
                    CheckBox11.IsChecked = true;
                    CheckBox9.IsChecked = false;
                    CheckBox10.IsChecked = false;
                    CheckBox12.IsChecked = false;
                    PhoneApp1.MainPage.winners.BFirstPlace = "Espana";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox11.IsChecked == true)
            {
                cS7 = 0;
                Flag11.Visibility = Visibility.Collapsed;
                CheckBox11.IsChecked = false;
                PhoneApp1.MainPage.winners.BFirstPlace = null;
            }
        }

        private void Grid12_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox12.IsChecked == false)
            {
                if (cS8 == 0)
                {
                    cF8 = 1;
                    cF5 = 0;
                    cF6 = 0;
                    cF7 = 0;
                    Flag12.Visibility = Visibility.Visible;
                    Flag9.Visibility = Visibility.Collapsed;
                    Flag10.Visibility = Visibility.Collapsed;
                    Flag11.Visibility = Visibility.Collapsed;
                    CheckBox12.IsChecked = true;
                    CheckBox9.IsChecked = false;
                    CheckBox10.IsChecked = false;
                    CheckBox11.IsChecked = false;
                    PhoneApp1.MainPage.winners.BFirstPlace = "Netherlands";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox12.IsChecked == true)
            {
                cF8 = 0;
                Flag12.Visibility = Visibility.Collapsed;
                CheckBox12.IsChecked = false;
                PhoneApp1.MainPage.winners.BFirstPlace = null;
            }
        }

        private void Grid13_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox13.IsChecked == false)
            {
                if (cF5 == 0)
                {
                    cS5 = 1;
                    cS6 = 0;
                    cS7 = 0;
                    cS8 = 0;
                    Flag13.Visibility = Visibility.Visible;
                    Flag14.Visibility = Visibility.Collapsed;
                    Flag15.Visibility = Visibility.Collapsed;
                    Flag16.Visibility = Visibility.Collapsed;
                    CheckBox13.IsChecked = true;
                    CheckBox14.IsChecked = false;
                    CheckBox15.IsChecked = false;
                    CheckBox16.IsChecked = false;
                    PhoneApp1.MainPage.winners.BSecondPlace = "Australia";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox13.IsChecked == true)
            {
                cS5 = 0;
                Flag13.Visibility = Visibility.Collapsed;
                CheckBox13.IsChecked = false;
                PhoneApp1.MainPage.winners.BSecondPlace = null;
            }
        }

        private void Grid14_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox14.IsChecked == false)
            {
                if (cF6 == 0)
                {
                    cS6 = 1;
                    cS5 = 0;
                    cS7 = 0;
                    cS8 = 0;
                    Flag14.Visibility = Visibility.Visible;
                    Flag13.Visibility = Visibility.Collapsed;
                    Flag15.Visibility = Visibility.Collapsed;
                    Flag16.Visibility = Visibility.Collapsed;
                    CheckBox14.IsChecked = true;
                    CheckBox13.IsChecked = false;
                    CheckBox15.IsChecked = false;
                    CheckBox16.IsChecked = false;
                    PhoneApp1.MainPage.winners.BSecondPlace = "Chile";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox14.IsChecked == true)
            {
                cS6 = 0;
                Flag14.Visibility = Visibility.Collapsed;
                CheckBox14.IsChecked = false;
                PhoneApp1.MainPage.winners.BSecondPlace = null;
            }
        }

        private void Grid15_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox15.IsChecked == false)
            {
                if (cF7 == 0)
                {
                    cS7 = 1;
                    cS5 = 0;
                    cS6 = 0;
                    cS8 = 0;
                    Flag15.Visibility = Visibility.Visible;
                    Flag13.Visibility = Visibility.Collapsed;
                    Flag14.Visibility = Visibility.Collapsed;
                    Flag16.Visibility = Visibility.Collapsed;
                    CheckBox15.IsChecked = true;
                    CheckBox13.IsChecked = false;
                    CheckBox14.IsChecked = false;
                    CheckBox16.IsChecked = false;
                    PhoneApp1.MainPage.winners.BSecondPlace = "Espana";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox15.IsChecked == true)
            {
                cS7 = 0;
                Flag15.Visibility = Visibility.Collapsed;
                CheckBox15.IsChecked = false;
                PhoneApp1.MainPage.winners.BSecondPlace = null;
            }
        }

        private void Grid16_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox16.IsChecked == false)
            {
                if (cF8 == 0)
                {
                    cS8 = 1;
                    cS5 = 0;
                    cS6 = 0;
                    cS7 = 0;
                    Flag16.Visibility = Visibility.Visible;
                    Flag13.Visibility = Visibility.Collapsed;
                    Flag14.Visibility = Visibility.Collapsed;
                    Flag15.Visibility = Visibility.Collapsed;
                    CheckBox16.IsChecked = true;
                    CheckBox13.IsChecked = false;
                    CheckBox14.IsChecked = false;
                    CheckBox15.IsChecked = false;
                    PhoneApp1.MainPage.winners.BSecondPlace = "Netherlands";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox16.IsChecked == true)
            {
                cS8 = 0;
                Flag16.Visibility = Visibility.Collapsed;
                CheckBox16.IsChecked = false;
                PhoneApp1.MainPage.winners.BSecondPlace = null;
            }
        }

        private void Grid17_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox17.IsChecked == false)
            {
                if (cS9 == 0)
                {
                    cF9 = 1;
                    cF10 = 0;
                    cF11 = 0;
                    cF12 = 0;
                    Flag17.Visibility = Visibility.Visible;
                    Flag18.Visibility = Visibility.Collapsed;
                    Flag19.Visibility = Visibility.Collapsed;
                    Flag20.Visibility = Visibility.Collapsed;
                    CheckBox17.IsChecked = true;
                    CheckBox18.IsChecked = false;
                    CheckBox19.IsChecked = false;
                    CheckBox20.IsChecked = false;
                    PhoneApp1.MainPage.winners.CFirstPlace = "Colombia";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox17.IsChecked == true)
            {
                cF9 = 0;
                Flag17.Visibility = Visibility.Collapsed;
                CheckBox17.IsChecked = false;
                PhoneApp1.MainPage.winners.CFirstPlace = null;
            }
        }

        private void Grid18_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox18.IsChecked == false)
            {
                if (cS10 == 0)
                {
                    cF10 = 1;
                    cF9 = 0;
                    cF11 = 0;
                    cF12 = 0;
                    Flag18.Visibility = Visibility.Visible;
                    Flag17.Visibility = Visibility.Collapsed;
                    Flag19.Visibility = Visibility.Collapsed;
                    Flag20.Visibility = Visibility.Collapsed;
                    CheckBox18.IsChecked = true;
                    CheckBox17.IsChecked = false;
                    CheckBox19.IsChecked = false;
                    CheckBox20.IsChecked = false;
                    PhoneApp1.MainPage.winners.CFirstPlace = "Cote d'Ivoire";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox18.IsChecked == true)
            {
                cF10 = 0;
                Flag18.Visibility = Visibility.Collapsed;
                CheckBox18.IsChecked = false;
                PhoneApp1.MainPage.winners.CFirstPlace = null;
            }
        }

        private void Grid19_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox19.IsChecked == false)
            {
                if (cS11 == 0)
                {
                    cF11 = 1;
                    cF9 = 0;
                    cF10 = 0;
                    cF12 = 0;
                    Flag19.Visibility = Visibility.Visible;
                    Flag17.Visibility = Visibility.Collapsed;
                    Flag18.Visibility = Visibility.Collapsed;
                    Flag20.Visibility = Visibility.Collapsed;
                    CheckBox19.IsChecked = true;
                    CheckBox17.IsChecked = false;
                    CheckBox18.IsChecked = false;
                    CheckBox20.IsChecked = false;
                    PhoneApp1.MainPage.winners.CFirstPlace = "Greece";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox19.IsChecked == true)
            {
                cF11 = 0;
                Flag19.Visibility = Visibility.Collapsed;
                CheckBox19.IsChecked = false;
                PhoneApp1.MainPage.winners.CFirstPlace = null;
            }
        }

        private void Grid20_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox20.IsChecked == false)
            {
                if (cS12 == 0)
                {
                    cF12 = 1;
                    cF9 = 0;
                    cF10 = 0;
                    cF11 = 0;
                    Flag20.Visibility = Visibility.Visible;
                    Flag17.Visibility = Visibility.Collapsed;
                    Flag18.Visibility = Visibility.Collapsed;
                    Flag19.Visibility = Visibility.Collapsed;
                    CheckBox20.IsChecked = true;
                    CheckBox17.IsChecked = false;
                    CheckBox18.IsChecked = false;
                    CheckBox19.IsChecked = false;
                    PhoneApp1.MainPage.winners.CFirstPlace = "Japan";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox20.IsChecked == true)
            {
                cF12 = 0;
                Flag20.Visibility = Visibility.Collapsed;
                CheckBox20.IsChecked = false;
                PhoneApp1.MainPage.winners.CFirstPlace = null;
            }
        }

        private void Grid21_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox21.IsChecked == false)
            {
                if (cF9 == 0)
                {
                    cS9 = 1;
                    cS10 = 0;
                    cS11 = 0;
                    cS12 = 0;
                    Flag21.Visibility = Visibility.Visible;
                    Flag22.Visibility = Visibility.Collapsed;
                    Flag23.Visibility = Visibility.Collapsed;
                    Flag24.Visibility = Visibility.Collapsed;
                    CheckBox21.IsChecked = true;
                    CheckBox22.IsChecked = false;
                    CheckBox23.IsChecked = false;
                    CheckBox24.IsChecked = false;
                    PhoneApp1.MainPage.winners.CSecondPlace = "Colombia";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox21.IsChecked == true)
            {
                cS9 = 0;
                Flag21.Visibility = Visibility.Collapsed;
                CheckBox21.IsChecked = false;
                PhoneApp1.MainPage.winners.CSecondPlace = null;
            }
        }

        private void Grid22_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox22.IsChecked == false)
            {
                if (cF10 == 0)
                {
                    cS10 = 1;
                    cS9 = 0;
                    cS11 = 0;
                    cS12 = 0;
                    Flag22.Visibility = Visibility.Visible;
                    Flag21.Visibility = Visibility.Collapsed;
                    Flag23.Visibility = Visibility.Collapsed;
                    Flag24.Visibility = Visibility.Collapsed;
                    CheckBox22.IsChecked = true;
                    CheckBox21.IsChecked = false;
                    CheckBox23.IsChecked = false;
                    CheckBox24.IsChecked = false;
                    PhoneApp1.MainPage.winners.CSecondPlace = "Cote d'Ivoire";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox22.IsChecked == true)
            {
                cS10 = 0;
                Flag22.Visibility = Visibility.Collapsed;
                CheckBox22.IsChecked = false;
                PhoneApp1.MainPage.winners.CSecondPlace = null;
            }
        }

        private void Grid23_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox23.IsChecked == false)
            {
                if (cF11 == 0)
                {
                    cS11 = 1;
                    cS9 = 0;
                    cS10 = 0;
                    cS12 = 0;
                    Flag23.Visibility = Visibility.Visible;
                    Flag21.Visibility = Visibility.Collapsed;
                    Flag22.Visibility = Visibility.Collapsed;
                    Flag24.Visibility = Visibility.Collapsed;
                    CheckBox23.IsChecked = true;
                    CheckBox21.IsChecked = false;
                    CheckBox22.IsChecked = false;
                    CheckBox24.IsChecked = false;
                    PhoneApp1.MainPage.winners.CSecondPlace = "Greece";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox23.IsChecked == true)
            {
                cS11 = 0;
                Flag23.Visibility = Visibility.Collapsed;
                CheckBox23.IsChecked = false;
                PhoneApp1.MainPage.winners.CSecondPlace = null;
            }
        }

        private void Grid24_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox24.IsChecked == false)
            {
                if (cF12 == 0)
                {
                    cS12 = 1;
                    cS9 = 0;
                    cS10 = 0;
                    cS11 = 0;
                    Flag24.Visibility = Visibility.Visible;
                    Flag21.Visibility = Visibility.Collapsed;
                    Flag22.Visibility = Visibility.Collapsed;
                    Flag23.Visibility = Visibility.Collapsed;
                    CheckBox24.IsChecked = true;
                    CheckBox21.IsChecked = false;
                    CheckBox22.IsChecked = false;
                    CheckBox23.IsChecked = false;
                    PhoneApp1.MainPage.winners.CSecondPlace = "Japan";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox24.IsChecked == true)
            {
                cS12 = 0;
                Flag24.Visibility = Visibility.Collapsed;
                CheckBox24.IsChecked = false;
                PhoneApp1.MainPage.winners.CSecondPlace = null;
            }
        }

        private void Grid25_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox25.IsChecked == false)
            {
                if (cS13 == 0)
                {
                    cF13 = 1;
                    cF14 = 0;
                    cF15 = 0;
                    cF16 = 0;
                    Flag25.Visibility = Visibility.Visible;
                    Flag26.Visibility = Visibility.Collapsed;
                    Flag27.Visibility = Visibility.Collapsed;
                    Flag28.Visibility = Visibility.Collapsed;
                    CheckBox25.IsChecked = true;
                    CheckBox26.IsChecked = false;
                    CheckBox27.IsChecked = false;
                    CheckBox28.IsChecked = false;
                    PhoneApp1.MainPage.winners.DFirstPlace = "Costa Rica";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox25.IsChecked == true)
            {
                cF13 = 0;
                Flag25.Visibility = Visibility.Collapsed;
                CheckBox25.IsChecked = false;
                PhoneApp1.MainPage.winners.DFirstPlace = null;
            }
        }

        private void Grid26_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox26.IsChecked == false)
            {
                if (cS14 == 0)
                {
                    cF14 = 1;
                    cF13 = 0;
                    cF15 = 0;
                    cF16 = 0;
                    Flag26.Visibility = Visibility.Visible;
                    Flag25.Visibility = Visibility.Collapsed;
                    Flag27.Visibility = Visibility.Collapsed;
                    Flag28.Visibility = Visibility.Collapsed;
                    CheckBox26.IsChecked = true;
                    CheckBox25.IsChecked = false;
                    CheckBox27.IsChecked = false;
                    CheckBox28.IsChecked = false;
                    PhoneApp1.MainPage.winners.DFirstPlace = "England";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox26.IsChecked == true)
            {
                cF14 = 0;
                Flag26.Visibility = Visibility.Collapsed;
                CheckBox26.IsChecked = false;
                PhoneApp1.MainPage.winners.DFirstPlace = null;
            }
        }

        private void Grid27_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox27.IsChecked == false)
            {
                if (cS15 == 0)
                {
                    cF15 = 1;
                    cF13 = 0;
                    cF14 = 0;
                    cF16 = 0;
                    Flag27.Visibility = Visibility.Visible;
                    Flag25.Visibility = Visibility.Collapsed;
                    Flag26.Visibility = Visibility.Collapsed;
                    Flag28.Visibility = Visibility.Collapsed;
                    CheckBox27.IsChecked = true;
                    CheckBox25.IsChecked = false;
                    CheckBox26.IsChecked = false;
                    CheckBox28.IsChecked = false;
                    PhoneApp1.MainPage.winners.DFirstPlace = "Italy";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox27.IsChecked == true)
            {
                cF15 = 0;
                Flag27.Visibility = Visibility.Collapsed;
                CheckBox27.IsChecked = false;
                PhoneApp1.MainPage.winners.DFirstPlace = null;
            }
        }

        private void Grid28_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox28.IsChecked == false)
            {
                if (cS16 == 0)
                {
                    cF16 = 1;
                    cF13 = 0;
                    cF14 = 0;
                    cF15 = 0;
                    Flag28.Visibility = Visibility.Visible;
                    Flag25.Visibility = Visibility.Collapsed;
                    Flag26.Visibility = Visibility.Collapsed;
                    Flag27.Visibility = Visibility.Collapsed;
                    CheckBox28.IsChecked = true;
                    CheckBox25.IsChecked = false;
                    CheckBox26.IsChecked = false;
                    CheckBox27.IsChecked = false;
                    PhoneApp1.MainPage.winners.DFirstPlace = "Uruguay";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox28.IsChecked == true)
            {
                cF16 = 0;
                Flag28.Visibility = Visibility.Collapsed;
                CheckBox28.IsChecked = false;
                PhoneApp1.MainPage.winners.DFirstPlace = null;
            }
        }

        private void Grid29_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox29.IsChecked == false)
            {
                if (cF13 == 0)
                {
                    cS13 = 1;
                    cS14 = 0;
                    cS15 = 0;
                    cS16 = 0;
                    Flag29.Visibility = Visibility.Visible;
                    Flag30.Visibility = Visibility.Collapsed;
                    Flag31.Visibility = Visibility.Collapsed;
                    Flag32.Visibility = Visibility.Collapsed;
                    CheckBox29.IsChecked = true;
                    CheckBox30.IsChecked = false;
                    CheckBox31.IsChecked = false;
                    CheckBox32.IsChecked = false;
                    PhoneApp1.MainPage.winners.DSecondPlace = "Costa Rica";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox29.IsChecked == true)
            {
                cS13 = 0;
                Flag29.Visibility = Visibility.Collapsed;
                CheckBox29.IsChecked = false;
                PhoneApp1.MainPage.winners.DSecondPlace = null;
            }
        }

        private void Grid30_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox30.IsChecked == false)
            {
                if (cF14 == 0)
                {
                    cS14 = 1;
                    cS13 = 0;
                    cS15 = 0;
                    cS16 = 0;
                    Flag30.Visibility = Visibility.Visible;
                    Flag29.Visibility = Visibility.Collapsed;
                    Flag31.Visibility = Visibility.Collapsed;
                    Flag32.Visibility = Visibility.Collapsed;
                    CheckBox30.IsChecked = true;
                    CheckBox29.IsChecked = false;
                    CheckBox31.IsChecked = false;
                    CheckBox32.IsChecked = false;
                    PhoneApp1.MainPage.winners.DSecondPlace = "England";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox30.IsChecked == true)
            {
                cS14 = 0;
                Flag30.Visibility = Visibility.Collapsed;
                CheckBox30.IsChecked = false;
                PhoneApp1.MainPage.winners.DSecondPlace = null;
            }
        }

        private void Grid31_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox31.IsChecked == false)
            {
                if (cF15 == 0)
                {
                    cS15 = 1;
                    cS13 = 0;
                    cS14 = 0;
                    cS16 = 0;
                    Flag31.Visibility = Visibility.Visible;
                    Flag29.Visibility = Visibility.Collapsed;
                    Flag30.Visibility = Visibility.Collapsed;
                    Flag32.Visibility = Visibility.Collapsed;
                    CheckBox31.IsChecked = true;
                    CheckBox29.IsChecked = false;
                    CheckBox30.IsChecked = false;
                    CheckBox32.IsChecked = false;
                    PhoneApp1.MainPage.winners.DSecondPlace = "Italy";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox31.IsChecked == true)
            {
                cS15 = 0;
                Flag31.Visibility = Visibility.Collapsed;
                CheckBox31.IsChecked = false;
                PhoneApp1.MainPage.winners.DSecondPlace = null;
            }
        }

        private void Grid32_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox32.IsChecked == false)
            {
                if (cF16 == 0)
                {
                    cS16 = 1;
                    cS13 = 0;
                    cS14 = 0;
                    cS15 = 0;
                    Flag32.Visibility = Visibility.Visible;
                    Flag29.Visibility = Visibility.Collapsed;
                    Flag30.Visibility = Visibility.Collapsed;
                    Flag31.Visibility = Visibility.Collapsed;
                    CheckBox32.IsChecked = true;
                    CheckBox29.IsChecked = false;
                    CheckBox30.IsChecked = false;
                    CheckBox31.IsChecked = false;
                    PhoneApp1.MainPage.winners.DSecondPlace = "Uruguay";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox32.IsChecked == true)
            {
                cS16 = 0;
                Flag32.Visibility = Visibility.Collapsed;
                CheckBox32.IsChecked = false;
                PhoneApp1.MainPage.winners.DSecondPlace = null;
            }
        }

        private void Grid33_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox33.IsChecked == false)
            {
                if (cS17 == 0)
                {
                    cF17 = 1;
                    cF18 = 0;
                    cF19 = 0;
                    cF20 = 0;
                    Flag33.Visibility = Visibility.Visible;
                    Flag34.Visibility = Visibility.Collapsed;
                    Flag35.Visibility = Visibility.Collapsed;
                    Flag36.Visibility = Visibility.Collapsed;
                    CheckBox33.IsChecked = true;
                    CheckBox34.IsChecked = false;
                    CheckBox35.IsChecked = false;
                    CheckBox36.IsChecked = false;
                    PhoneApp1.MainPage.winners.EFirstPlace = "Ecuador";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox33.IsChecked == true)
            {
                cF17 = 0;
                Flag33.Visibility = Visibility.Collapsed;
                CheckBox33.IsChecked = false;
                PhoneApp1.MainPage.winners.EFirstPlace = null;
            }
        }

        private void Grid34_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox34.IsChecked == false)
            {
                if (cS18 == 0)
                {
                    cF18 = 1;
                    cF17 = 0;
                    cF19 = 0;
                    cF20 = 0;
                    Flag34.Visibility = Visibility.Visible;
                    Flag33.Visibility = Visibility.Collapsed;
                    Flag35.Visibility = Visibility.Collapsed;
                    Flag36.Visibility = Visibility.Collapsed;
                    CheckBox34.IsChecked = true;
                    CheckBox33.IsChecked = false;
                    CheckBox35.IsChecked = false;
                    CheckBox36.IsChecked = false;
                    PhoneApp1.MainPage.winners.EFirstPlace = "France";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox34.IsChecked == true)
            {
                cF18 = 0;
                Flag34.Visibility = Visibility.Collapsed;
                CheckBox34.IsChecked = false;
                PhoneApp1.MainPage.winners.EFirstPlace = null;
            }
        }

        private void Grid35_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox35.IsChecked == false)
            {
                if (cS19 == 0)
                {
                    cF19 = 1;
                    cF17 = 0;
                    cF18 = 0;
                    cF20 = 0;
                    Flag35.Visibility = Visibility.Visible;
                    Flag33.Visibility = Visibility.Collapsed;
                    Flag34.Visibility = Visibility.Collapsed;
                    Flag36.Visibility = Visibility.Collapsed;
                    CheckBox35.IsChecked = true;
                    CheckBox33.IsChecked = false;
                    CheckBox34.IsChecked = false;
                    CheckBox36.IsChecked = false;
                    PhoneApp1.MainPage.winners.EFirstPlace = "Honduras";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox35.IsChecked == true)
            {
                cF19 = 0;
                Flag35.Visibility = Visibility.Collapsed;
                CheckBox35.IsChecked = false;
                PhoneApp1.MainPage.winners.EFirstPlace = null;
            }
        }

        private void Grid36_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox36.IsChecked == false)
            {
                if (cS20 == 0)
                {
                    cF20 = 1;
                    cF17 = 0;
                    cF18 = 0;
                    cF19 = 0;
                    Flag36.Visibility = Visibility.Visible;
                    Flag33.Visibility = Visibility.Collapsed;
                    Flag34.Visibility = Visibility.Collapsed;
                    Flag35.Visibility = Visibility.Collapsed;
                    CheckBox36.IsChecked = true;
                    CheckBox33.IsChecked = false;
                    CheckBox34.IsChecked = false;
                    CheckBox35.IsChecked = false;
                    PhoneApp1.MainPage.winners.EFirstPlace = "Switzerland";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox36.IsChecked == true)
            {
                cF20 = 0;
                Flag36.Visibility = Visibility.Collapsed;
                CheckBox36.IsChecked = false;
                PhoneApp1.MainPage.winners.EFirstPlace = null;
            }
        }

        private void Grid37_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox37.IsChecked == false)
            {
                if (cF17 == 0)
                {
                    cS17 = 1;
                    cS18 = 0;
                    cS19 = 0;
                    cS20 = 0;
                    Flag37.Visibility = Visibility.Visible;
                    Flag38.Visibility = Visibility.Collapsed;
                    Flag39.Visibility = Visibility.Collapsed;
                    Flag40.Visibility = Visibility.Collapsed;
                    CheckBox37.IsChecked = true;
                    CheckBox38.IsChecked = false;
                    CheckBox39.IsChecked = false;
                    CheckBox40.IsChecked = false;
                    PhoneApp1.MainPage.winners.ESecondPlace = "Ecuador";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox37.IsChecked == true)
            {
                cS20 = 0;
                Flag37.Visibility = Visibility.Collapsed;
                CheckBox37.IsChecked = false;
                PhoneApp1.MainPage.winners.ESecondPlace = null;
            }
        }

        private void Grid38_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox38.IsChecked == false)
            {
                if (cF18 == 0)
                {
                    cS18 = 1;
                    cS17 = 0;
                    cS19 = 0;
                    cS20 = 0;
                    Flag38.Visibility = Visibility.Visible;
                    Flag37.Visibility = Visibility.Collapsed;
                    Flag39.Visibility = Visibility.Collapsed;
                    Flag40.Visibility = Visibility.Collapsed;
                    CheckBox38.IsChecked = true;
                    CheckBox37.IsChecked = false;
                    CheckBox39.IsChecked = false;
                    CheckBox40.IsChecked = false;
                    PhoneApp1.MainPage.winners.ESecondPlace = "France";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox38.IsChecked == true)
            {
                cS18 = 0;
                Flag38.Visibility = Visibility.Collapsed;
                CheckBox38.IsChecked = false;
                PhoneApp1.MainPage.winners.ESecondPlace = null;
            }
        }

        private void Grid39_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox39.IsChecked == false)
            {
                if (cF19 == 0)
                {
                    cS19 = 1;
                    cS17 = 0;
                    cS18 = 0;
                    cS20 = 0;
                    Flag39.Visibility = Visibility.Visible;
                    Flag37.Visibility = Visibility.Collapsed;
                    Flag38.Visibility = Visibility.Collapsed;
                    Flag40.Visibility = Visibility.Collapsed;
                    CheckBox39.IsChecked = true;
                    CheckBox37.IsChecked = false;
                    CheckBox38.IsChecked = false;
                    CheckBox40.IsChecked = false;
                    PhoneApp1.MainPage.winners.ESecondPlace = "Honduras";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox39.IsChecked == true)
            {
                cS19 = 0;
                Flag39.Visibility = Visibility.Collapsed;
                CheckBox39.IsChecked = false;
                PhoneApp1.MainPage.winners.ESecondPlace = null;
            }
        }

        private void Grid40_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox40.IsChecked == false)
            {
                if (cF20 == 0)
                {
                    cS20 = 1;
                    cS17 = 0;
                    cS18 = 0;
                    cS19 = 0;
                    Flag40.Visibility = Visibility.Visible;
                    Flag37.Visibility = Visibility.Collapsed;
                    Flag38.Visibility = Visibility.Collapsed;
                    Flag39.Visibility = Visibility.Collapsed;
                    CheckBox40.IsChecked = true;
                    CheckBox37.IsChecked = false;
                    CheckBox38.IsChecked = false;
                    CheckBox39.IsChecked = false;
                    PhoneApp1.MainPage.winners.ESecondPlace = "Switzerland";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox40.IsChecked == true)
            {
                cS20 = 0;
                Flag40.Visibility = Visibility.Collapsed;
                CheckBox40.IsChecked = false;
                PhoneApp1.MainPage.winners.ESecondPlace = null;
            }
        }

        private void Grid41_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox41.IsChecked == false)
            {
                if (cS21 == 0)
                {
                    cF21 = 1;
                    cF22 = 0;
                    cF23 = 0;
                    cF24 = 0;
                    Flag41.Visibility = Visibility.Visible;
                    Flag42.Visibility = Visibility.Collapsed;
                    Flag43.Visibility = Visibility.Collapsed;
                    Flag44.Visibility = Visibility.Collapsed;
                    CheckBox41.IsChecked = true;
                    CheckBox42.IsChecked = false;
                    CheckBox43.IsChecked = false;
                    CheckBox44.IsChecked = false;
                    PhoneApp1.MainPage.winners.FFirstPlace = "Argentina";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox41.IsChecked == true)
            {
                cF21 = 0;
                Flag41.Visibility = Visibility.Collapsed;
                CheckBox41.IsChecked = false;
                PhoneApp1.MainPage.winners.FFirstPlace = null;
            }
        }

        private void Grid42_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox42.IsChecked == false)
            {
                if (cS22 == 0)
                {
                    cF22 = 1;
                    cF21 = 0;
                    cF23 = 0;
                    cF24 = 0;
                    Flag42.Visibility = Visibility.Visible;
                    Flag41.Visibility = Visibility.Collapsed;
                    Flag43.Visibility = Visibility.Collapsed;
                    Flag44.Visibility = Visibility.Collapsed;
                    CheckBox42.IsChecked = true;
                    CheckBox41.IsChecked = false;
                    CheckBox43.IsChecked = false;
                    CheckBox44.IsChecked = false;
                    PhoneApp1.MainPage.winners.FFirstPlace = "Bosnia";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox42.IsChecked == true)
            {
                cF22 = 0;
                Flag42.Visibility = Visibility.Collapsed;
                CheckBox42.IsChecked = false;
                PhoneApp1.MainPage.winners.FFirstPlace = null;
            }
        }

        private void Grid43_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox43.IsChecked == false)
            {
                if (cS23 == 0)
                {
                    cF23 = 1;
                    cF21 = 0;
                    cF22 = 0;
                    cF24 = 0;
                    Flag43.Visibility = Visibility.Visible;
                    Flag41.Visibility = Visibility.Collapsed;
                    Flag42.Visibility = Visibility.Collapsed;
                    Flag44.Visibility = Visibility.Collapsed;
                    CheckBox43.IsChecked = true;
                    CheckBox41.IsChecked = false;
                    CheckBox42.IsChecked = false;
                    CheckBox44.IsChecked = false;
                    PhoneApp1.MainPage.winners.FFirstPlace = "Iran";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox43.IsChecked == true)
            {
                cF23 = 0;
                Flag43.Visibility = Visibility.Collapsed;
                CheckBox43.IsChecked = false;
                PhoneApp1.MainPage.winners.FFirstPlace = null;
            }
        }

        private void Grid44_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox44.IsChecked == false)
            {
                if (cS24 == 0)
                {
                    cF24 = 1;
                    cF21 = 0;
                    cF22 = 0;
                    cF23 = 0;
                    Flag44.Visibility = Visibility.Visible;
                    Flag41.Visibility = Visibility.Collapsed;
                    Flag42.Visibility = Visibility.Collapsed;
                    Flag43.Visibility = Visibility.Collapsed;
                    CheckBox44.IsChecked = true;
                    CheckBox41.IsChecked = false;
                    CheckBox42.IsChecked = false;
                    CheckBox43.IsChecked = false;
                    PhoneApp1.MainPage.winners.FFirstPlace = "Nigeria";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox44.IsChecked == true)
            {
                cF24 = 0;
                Flag44.Visibility = Visibility.Collapsed;
                CheckBox44.IsChecked = false;
                PhoneApp1.MainPage.winners.FFirstPlace = null;
            }
        }

        private void Grid45_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox45.IsChecked == false)
            {
                if (cF21 == 0)
                {
                    cS21 = 1;
                    cS22 = 0;
                    cS23 = 0;
                    cS24 = 0;
                    Flag45.Visibility = Visibility.Visible;
                    Flag46.Visibility = Visibility.Collapsed;
                    Flag47.Visibility = Visibility.Collapsed;
                    Flag48.Visibility = Visibility.Collapsed;
                    CheckBox45.IsChecked = true;
                    CheckBox46.IsChecked = false;
                    CheckBox47.IsChecked = false;
                    CheckBox48.IsChecked = false;
                    PhoneApp1.MainPage.winners.FSecondPlace = "Argentina";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox45.IsChecked == true)
            {
                cS21 = 0;
                Flag45.Visibility = Visibility.Collapsed;
                CheckBox45.IsChecked = false;
                PhoneApp1.MainPage.winners.FSecondPlace = null;
            }
        }

        private void Grid46_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox46.IsChecked == false)
            {
                if (cF22 == 0)
                {
                    cS22 = 1;
                    cS21 = 0;
                    cS23 = 0;
                    cS24 = 0;
                    Flag46.Visibility = Visibility.Visible;
                    Flag45.Visibility = Visibility.Collapsed;
                    Flag47.Visibility = Visibility.Collapsed;
                    Flag48.Visibility = Visibility.Collapsed;
                    CheckBox46.IsChecked = true;
                    CheckBox45.IsChecked = false;
                    CheckBox47.IsChecked = false;
                    CheckBox48.IsChecked = false;
                    PhoneApp1.MainPage.winners.FSecondPlace = "Bosnia";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox46.IsChecked == true)
            {
                cS22 = 0;
                Flag46.Visibility = Visibility.Collapsed;
                CheckBox46.IsChecked = false;
                PhoneApp1.MainPage.winners.FSecondPlace = null;
            }
        }

        private void Grid47_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox47.IsChecked == false)
            {
                 if (cF23 == 0)
                {
                    cS23 = 1;
                    cS21 = 0;
                    cS22 = 0;
                    cS24 = 0;
                    Flag47.Visibility = Visibility.Visible;
                    Flag45.Visibility = Visibility.Collapsed;
                    Flag46.Visibility = Visibility.Collapsed;
                    Flag48.Visibility = Visibility.Collapsed;
                    CheckBox47.IsChecked = true;
                    CheckBox45.IsChecked = false;
                    CheckBox46.IsChecked = false;
                    CheckBox48.IsChecked = false;
                    PhoneApp1.MainPage.winners.FSecondPlace = "Iran";
                 }
                 else
                 {
                     MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                 }
            }
            else if (CheckBox47.IsChecked == true)
            {
                cS23 = 0;
                Flag47.Visibility = Visibility.Collapsed;
                CheckBox47.IsChecked = false;
                PhoneApp1.MainPage.winners.FSecondPlace = null;
            }
        }

        private void Grid48_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox48.IsChecked == false)
            {
                if (cF24 == 0)
                {
                    cS24 = 1;
                    cS21 = 0;
                    cS22 = 0;
                    cS23 = 0;
                    Flag48.Visibility = Visibility.Visible;
                    Flag45.Visibility = Visibility.Collapsed;
                    Flag46.Visibility = Visibility.Collapsed;
                    Flag47.Visibility = Visibility.Collapsed;
                    CheckBox48.IsChecked = true;
                    CheckBox45.IsChecked = false;
                    CheckBox46.IsChecked = false;
                    CheckBox47.IsChecked = false;
                    PhoneApp1.MainPage.winners.FSecondPlace = "Nigeria";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox48.IsChecked == true)
            {
                cS24 = 0;
                Flag48.Visibility = Visibility.Collapsed;
                CheckBox48.IsChecked = false;
                PhoneApp1.MainPage.winners.FSecondPlace = null;
            }
        }

        private void Grid49_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox49.IsChecked == false)
            {
                if (cS25 == 0)
                {
                    cF25 = 1;
                    cF26 = 0;
                    cF27 = 0;
                    cF28 = 0;
                    Flag49.Visibility = Visibility.Visible;
                    Flag50.Visibility = Visibility.Collapsed;
                    Flag51.Visibility = Visibility.Collapsed;
                    Flag52.Visibility = Visibility.Collapsed;
                    CheckBox49.IsChecked = true;
                    CheckBox50.IsChecked = false;
                    CheckBox51.IsChecked = false;
                    CheckBox52.IsChecked = false;
                    PhoneApp1.MainPage.winners.GFirstPlace = "Germany";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox49.IsChecked == true)
            {
                cF25 = 0;
                Flag49.Visibility = Visibility.Collapsed;
                CheckBox49.IsChecked = false;
                PhoneApp1.MainPage.winners.GFirstPlace = null;
            }
        }

        private void Grid50_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox50.IsChecked == false)
            {
                if (cS26 == 0)
                {
                    cF26 = 1;
                    cF25 = 0;
                    cF27 = 0;
                    cF28 = 0;
                    Flag50.Visibility = Visibility.Visible;
                    Flag49.Visibility = Visibility.Collapsed;
                    Flag51.Visibility = Visibility.Collapsed;
                    Flag52.Visibility = Visibility.Collapsed;
                    CheckBox50.IsChecked = true;
                    CheckBox49.IsChecked = false;
                    CheckBox51.IsChecked = false;
                    CheckBox52.IsChecked = false;
                    PhoneApp1.MainPage.winners.GFirstPlace = "Ghana";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox50.IsChecked == true)
            {
                cF26 = 0;
                Flag50.Visibility = Visibility.Collapsed;
                CheckBox50.IsChecked = false;
                PhoneApp1.MainPage.winners.GFirstPlace = null;
            }
        }

        private void Grid51_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox51.IsChecked == false)
            {
                if (cS27 == 0)
                {
                    cF27 = 1;
                    cF25 = 0;
                    cF26 = 0;
                    cF28 = 0;
                    Flag51.Visibility = Visibility.Visible;
                    Flag49.Visibility = Visibility.Collapsed;
                    Flag50.Visibility = Visibility.Collapsed;
                    Flag52.Visibility = Visibility.Collapsed;
                    CheckBox51.IsChecked = true;
                    CheckBox49.IsChecked = false;
                    CheckBox50.IsChecked = false;
                    CheckBox52.IsChecked = false;
                    PhoneApp1.MainPage.winners.GFirstPlace = "Portugal";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox51.IsChecked == true)
            {
                cF27 = 0;
                Flag51.Visibility = Visibility.Collapsed;
                CheckBox51.IsChecked = false;
                PhoneApp1.MainPage.winners.GFirstPlace = null;
            }
        }

        private void Grid52_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox52.IsChecked == false)
            {
                if (cS28 == 0)
                {
                    cF25 = 1;
                    cF26 = 0;
                    cF27 = 0;
                    cF28 = 0;
                    Flag52.Visibility = Visibility.Visible;
                    Flag49.Visibility = Visibility.Collapsed;
                    Flag50.Visibility = Visibility.Collapsed;
                    Flag51.Visibility = Visibility.Collapsed;
                    CheckBox52.IsChecked = true;
                    CheckBox49.IsChecked = false;
                    CheckBox50.IsChecked = false;
                    CheckBox51.IsChecked = false;
                    PhoneApp1.MainPage.winners.GFirstPlace = "USA";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox52.IsChecked == true)
            {
                cF28 = 0;
                Flag52.Visibility = Visibility.Collapsed;
                CheckBox52.IsChecked = false;
                PhoneApp1.MainPage.winners.GFirstPlace = null;
            }
        }

        private void Grid53_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox53.IsChecked == false)
            {
                if (cF25 == 0)
                {
                    cS25 = 1;
                    cS26 = 0;
                    cS27 = 0;
                    cS28 = 0;
                    Flag53.Visibility = Visibility.Visible;
                    Flag54.Visibility = Visibility.Collapsed;
                    Flag55.Visibility = Visibility.Collapsed;
                    Flag56.Visibility = Visibility.Collapsed;
                    CheckBox53.IsChecked = true;
                    CheckBox54.IsChecked = false;
                    CheckBox55.IsChecked = false;
                    CheckBox56.IsChecked = false;
                    PhoneApp1.MainPage.winners.GSecondPlace = "Germany";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox53.IsChecked == true)
            {
                cS25 = 0;
                Flag53.Visibility = Visibility.Collapsed;
                CheckBox53.IsChecked = false;
                PhoneApp1.MainPage.winners.GSecondPlace = null;
            }
        }

        private void Grid54_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox54.IsChecked == false)
            {
                if (cF26 == 0)
                {
                    cS26 = 1;
                    cS25 = 0;
                    cS27 = 0;
                    cS28 = 0;
                    Flag54.Visibility = Visibility.Visible;
                    Flag53.Visibility = Visibility.Collapsed;
                    Flag55.Visibility = Visibility.Collapsed;
                    Flag56.Visibility = Visibility.Collapsed;
                    CheckBox54.IsChecked = true;
                    CheckBox53.IsChecked = false;
                    CheckBox55.IsChecked = false;
                    CheckBox56.IsChecked = false;
                    PhoneApp1.MainPage.winners.GSecondPlace = "Ghana";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox54.IsChecked == true)
            {
                cS26 = 0;
                Flag54.Visibility = Visibility.Collapsed;
                CheckBox54.IsChecked = false;
                PhoneApp1.MainPage.winners.GSecondPlace = null;
            }
        }

        private void Grid55_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox55.IsChecked == false)
            {
                if (cF27 == 0)
                {
                    cS27 = 1;
                    cS25 = 0;
                    cS26 = 0;
                    cS28 = 0;
                    Flag55.Visibility = Visibility.Visible;
                    Flag53.Visibility = Visibility.Collapsed;
                    Flag54.Visibility = Visibility.Collapsed;
                    Flag56.Visibility = Visibility.Collapsed;
                    CheckBox55.IsChecked = true;
                    CheckBox53.IsChecked = false;
                    CheckBox54.IsChecked = false;
                    CheckBox56.IsChecked = false;
                    PhoneApp1.MainPage.winners.GSecondPlace = "Portugal";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox55.IsChecked == true)
            {
                cS27 = 0;
                Flag55.Visibility = Visibility.Collapsed;
                CheckBox55.IsChecked = false;
                PhoneApp1.MainPage.winners.GSecondPlace = null;
            }
        }

        private void Grid56_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox56.IsChecked == false)
            {
                if (cF28 == 0)
                {
                    cS28 = 1;
                    cS25 = 0;
                    cS26 = 0;
                    cS27 = 0;
                    Flag56.Visibility = Visibility.Visible;
                    Flag53.Visibility = Visibility.Collapsed;
                    Flag54.Visibility = Visibility.Collapsed;
                    Flag55.Visibility = Visibility.Collapsed;
                    CheckBox56.IsChecked = true;
                    CheckBox53.IsChecked = false;
                    CheckBox54.IsChecked = false;
                    CheckBox55.IsChecked = false;
                    PhoneApp1.MainPage.winners.GSecondPlace = "USA";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox56.IsChecked == true)
            {
                cS28 = 0;
                Flag56.Visibility = Visibility.Collapsed;
                CheckBox56.IsChecked = false;
                PhoneApp1.MainPage.winners.GSecondPlace = null;
            }
        }

        private void Grid57_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox57.IsChecked == false)
            {
                if (cS29 == 0)
                {
                    cF29 = 1;
                    cF30 = 0;
                    cF31 = 0;
                    cF32 = 0;
                    Flag57.Visibility = Visibility.Visible;
                    Flag58.Visibility = Visibility.Collapsed;
                    Flag59.Visibility = Visibility.Collapsed;
                    Flag60.Visibility = Visibility.Collapsed;
                    CheckBox57.IsChecked = true;
                    CheckBox58.IsChecked = false;
                    CheckBox59.IsChecked = false;
                    CheckBox60.IsChecked = false;
                    PhoneApp1.MainPage.winners.HFirstPlace = "Algeria";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox57.IsChecked == true)
            {
                cF29 = 0;
                Flag57.Visibility = Visibility.Collapsed;
                CheckBox57.IsChecked = false;
                PhoneApp1.MainPage.winners.HFirstPlace = null;
            }
        }

        private void Grid58_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox58.IsChecked == false)
            {
                if (cS30 == 0)
                {
                    cF30 = 1;
                    cF29 = 0;
                    cF31 = 0;
                    cF32 = 0;
                    Flag58.Visibility = Visibility.Visible;
                    Flag57.Visibility = Visibility.Collapsed;
                    Flag59.Visibility = Visibility.Collapsed;
                    Flag60.Visibility = Visibility.Collapsed;
                    CheckBox58.IsChecked = true;
                    CheckBox57.IsChecked = false;
                    CheckBox59.IsChecked = false;
                    CheckBox60.IsChecked = false;
                    PhoneApp1.MainPage.winners.HFirstPlace = "Belgium";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox58.IsChecked == true)
            {
                cF30 = 0;
                Flag58.Visibility = Visibility.Collapsed;
                CheckBox58.IsChecked = false;
                PhoneApp1.MainPage.winners.HFirstPlace = null;
            }
        }

        private void Grid59_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox59.IsChecked == false)
            {
                if (cS31 == 0)
                {
                    cF31 = 1;
                    cF29 = 0;
                    cF30 = 0;
                    cF32 = 0;
                    Flag59.Visibility = Visibility.Visible;
                    Flag57.Visibility = Visibility.Collapsed;
                    Flag58.Visibility = Visibility.Collapsed;
                    Flag60.Visibility = Visibility.Collapsed;
                    CheckBox59.IsChecked = true;
                    CheckBox57.IsChecked = false;
                    CheckBox58.IsChecked = false;
                    CheckBox60.IsChecked = false;
                    PhoneApp1.MainPage.winners.HFirstPlace = "Russia";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox59.IsChecked == true)
            {
                cF31 = 0;
                Flag59.Visibility = Visibility.Collapsed;
                CheckBox59.IsChecked = false;
                PhoneApp1.MainPage.winners.HFirstPlace = null;
            }
        }

        private void Grid60_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox60.IsChecked == false)
            {
                if (cS32 == 0)
                {
                    cF32 = 1;
                    cF29 = 0;
                    cF30 = 0;
                    cF31 = 0;
                    Flag60.Visibility = Visibility.Visible;
                    Flag57.Visibility = Visibility.Collapsed;
                    Flag58.Visibility = Visibility.Collapsed;
                    Flag59.Visibility = Visibility.Collapsed;
                    CheckBox60.IsChecked = true;
                    CheckBox57.IsChecked = false;
                    CheckBox58.IsChecked = false;
                    CheckBox59.IsChecked = false;
                    PhoneApp1.MainPage.winners.HFirstPlace = "South Korea";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as second place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox60.IsChecked == true)
            {
                cF32 = 0;
                Flag60.Visibility = Visibility.Collapsed;
                CheckBox60.IsChecked = false;
                PhoneApp1.MainPage.winners.HFirstPlace = null;
            }
        }

        private void Grid61_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox61.IsChecked == false)
            {
                if (cF29 == 0)
                {
                    cS29 = 1;
                    cS30 = 0;
                    cS31 = 0;
                    cS32 = 0;
                    Flag61.Visibility = Visibility.Visible;
                    Flag62.Visibility = Visibility.Collapsed;
                    Flag63.Visibility = Visibility.Collapsed;
                    Flag64.Visibility = Visibility.Collapsed;
                    CheckBox61.IsChecked = true;
                    CheckBox62.IsChecked = false;
                    CheckBox63.IsChecked = false;
                    CheckBox64.IsChecked = false;
                    PhoneApp1.MainPage.winners.HSecondPlace = "Algeria";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox61.IsChecked == true)
            {
                cS29 = 0;
                Flag61.Visibility = Visibility.Collapsed;
                CheckBox61.IsChecked = false;
                PhoneApp1.MainPage.winners.HSecondPlace = null;
            }
        }

        private void Grid62_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox62.IsChecked == false)
            {
                if (cF30 == 0)
                {
                    cS30 = 1;
                    cS29 = 0;
                    cS31 = 0;
                    cS32 = 0;
                    Flag62.Visibility = Visibility.Visible;
                    Flag61.Visibility = Visibility.Collapsed;
                    Flag63.Visibility = Visibility.Collapsed;
                    Flag64.Visibility = Visibility.Collapsed;
                    CheckBox62.IsChecked = true;
                    CheckBox61.IsChecked = false;
                    CheckBox63.IsChecked = false;
                    CheckBox64.IsChecked = false;
                    PhoneApp1.MainPage.winners.HSecondPlace = "Belgium";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox62.IsChecked == true)
            {
                cS30 = 0;
                Flag62.Visibility = Visibility.Collapsed;
                CheckBox62.IsChecked = false;
                PhoneApp1.MainPage.winners.HSecondPlace = null;
            }
        }

        private void Grid63_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox63.IsChecked == false)
            {
                if (cF31 == 0)
                {
                    cS31 = 1;
                    cS29 = 0;
                    cS30 = 0;
                    cS32 = 0;
                    Flag63.Visibility = Visibility.Visible;
                    Flag61.Visibility = Visibility.Collapsed;
                    Flag62.Visibility = Visibility.Collapsed;
                    Flag64.Visibility = Visibility.Collapsed;
                    CheckBox63.IsChecked = true;
                    CheckBox61.IsChecked = false;
                    CheckBox62.IsChecked = false;
                    CheckBox64.IsChecked = false;
                    PhoneApp1.MainPage.winners.HSecondPlace = "Russia";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox63.IsChecked == true)
            {
                cS31 = 0;
                Flag63.Visibility = Visibility.Collapsed;
                CheckBox63.IsChecked = false;
                PhoneApp1.MainPage.winners.HSecondPlace = null;
            }
        }

        private void Grid64_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CheckBox64.IsChecked == false)
            {
                if (cF32 == 0)
                {
                    cS32 = 1;
                    cS29 = 0;
                    cS30 = 0;
                    cS31 = 0;
                    Flag64.Visibility = Visibility.Visible;
                    Flag61.Visibility = Visibility.Collapsed;
                    Flag62.Visibility = Visibility.Collapsed;
                    Flag63.Visibility = Visibility.Collapsed;
                    CheckBox64.IsChecked = true;
                    CheckBox61.IsChecked = false;
                    CheckBox62.IsChecked = false;
                    CheckBox63.IsChecked = false;
                    PhoneApp1.MainPage.winners.HSecondPlace = "South Korea";
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("The team has been already chosen as first place", "", MessageBoxButton.OK);
                }
            }
            else if (CheckBox64.IsChecked == true)
            {
                cS32 = 0;
                Flag64.Visibility = Visibility.Collapsed;
                CheckBox64.IsChecked = false;
                PhoneApp1.MainPage.winners.HSecondPlace = null;
            }
        }

        private void NavigateToRoundOf16(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/RoundOf16.xaml", UriKind.Relative));
        }


public int cS1 { get; set; }

public int cS2 { get; set; }

public int cS3 { get; set; }

public int cS4 { get; set; }


public int cF1 { get; set; }

public int cF2 { get; set; }

public int cF3 { get; set; }

public int cF4 { get; set; }


public int cS5 { get; set; }

public int cS6 { get; set; }

public int cS7 { get; set; }

public int cS8 { get; set; }


public int cF5 { get; set; }

public int cF6 { get; set; }

public int cF7 { get; set; }

public int cF8 { get; set; }



public int cS11 { get; set; }

public int cS10 { get; set; }

public int cS9 { get; set; }

public int cS12 { get; set; }



public int cF11 { get; set; }

public int cF9 { get; set; }

public int cF10 { get; set; }

public int cF12 { get; set; }



public int cS13 { get; set; }

public int cS14 { get; set; }

public int cS15 { get; set; }

public int cS16 { get; set; }



public int cF13 { get; set; }

public int cF16 { get; set; }

public int cF15 { get; set; }

public int cF14 { get; set; }



public int cF17 { get; set; }

public int cF20 { get; set; }

public int cF18 { get; set; }

public int cF19 { get; set; }




public int cS17 { get; set; }

public int cS18 { get; set; }

public int cS19 { get; set; }

public int cS20 { get; set; }



public int cF21 { get; set; }

public int cF22 { get; set; }

public int cF23 { get; set; }

public int cF24 { get; set; }



public int cS21 { get; set; }

public int cS22 { get; set; }

public int cS23 { get; set; }

public int cS24 { get; set; }



public int cF25 { get; set; }

public int cF26 { get; set; }

public int cF27 { get; set; }

public int cF28 { get; set; }



public int cS25 { get; set; }

public int cS26 { get; set; }

public int cS27 { get; set; }

public int cS28 { get; set; }



public int cF29 { get; set; }

public int cF30 { get; set; }

public int cF31 { get; set; }

public int cF32 { get; set; }



public int cS29 { get; set; }

public int cS30 { get; set; }

public int cS31 { get; set; }

public int cS32 { get; set; }

    
        
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TeamInformation.xaml", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TeamInformation.xaml", UriKind.Relative));

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TeamInformation.xaml", UriKind.Relative));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TeamInformation.xaml", UriKind.Relative));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TeamInformation.xaml", UriKind.Relative));
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TeamInformation.xaml", UriKind.Relative));
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TeamInformation.xaml", UriKind.Relative));
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TeamInformation.xaml", UriKind.Relative));
        }
    }
        
}