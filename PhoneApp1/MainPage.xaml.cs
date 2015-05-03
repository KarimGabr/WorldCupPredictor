using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp1.Resources;

namespace PhoneApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NextGroupA(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/GroupsRound.xaml", UriKind.Relative));
        }

        public static class winners
        {
            public static string AFirstPlace = null;
            public static string ASecondPlace = null;
            public static string BFirstPlace = null;
            public static string BSecondPlace = null;
            public static string CFirstPlace = null;
            public static string CSecondPlace = null;
            public static string DFirstPlace = null;
            public static string DSecondPlace = null;
            public static string EFirstPlace = null;
            public static string ESecondPlace = null;
            public static string FFirstPlace = null;
            public static string FSecondPlace = null;
            public static string GFirstPlace = null;
            public static string GSecondPlace = null;
            public static string HFirstPlace = null;
            public static string HSecondPlace = null;
            public static string Match49Winner = null;
            public static string Match50Winner = null;
            public static string Match51Winner = null;
            public static string Match52Winner = null;
            public static string Match53Winner = null;
            public static string Match54Winner = null;
            public static string Match55Winner = null;
            public static string Match56Winner = null;
            public static string Match57Winner = null;
            public static string Match58Winner = null;
            public static string Match59Winner = null;
            public static string Match60Winner = null;
            public static string Match61Winner = null;
            public static string Match62Winner = null;
            public static string Match61Loser = null;
            public static string Match62Loser = null;
            public static string Match63Winner = null;
            public static string Match64Winner = null;
            public static string Match64Loser = null;
            public static bool IsPredictionsAreFinished = false;
            public static string TeamInformationName = null;

            public static string GroupAFirstPlace { get; set; }
        }
    }
}