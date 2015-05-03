using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO;
using System.Windows.Media.Imaging;
using Microsoft.Phone.Tasks;

namespace PhoneApp1
{
    public partial class TeamInformation2 : PhoneApplicationPage
    {
        public TeamInformation2()
        {
            InitializeComponent();
            var str = Application.GetResourceStream(new Uri("Text/" + PhoneApp1.MainPage.winners.TeamInformationName + ".txt", UriKind.RelativeOrAbsolute));
            StreamReader sReader = new StreamReader(str.Stream);
            TeamInformationText.Text = sReader.ReadToEnd();
            TeamName.Text = PhoneApp1.MainPage.winners.TeamInformationName;
            TeamFlag.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.TeamInformationName + ".jpg", UriKind.Relative));
        }

        
        private void Link_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            if (PhoneApp1.MainPage.winners.TeamInformationName == "Bosnia")
            {
                webBrowserTask.Uri = new Uri("http://en.wikipedia.org/wiki/Bosnia_and_Herzegovina_national_football_team", UriKind.Absolute); ;

            }
            else if (PhoneApp1.MainPage.winners.TeamInformationName == "Costa Rica")
            {
                webBrowserTask.Uri = new Uri("http://en.wikipedia.org/wiki/Costa_Rica_national_football_team", UriKind.Absolute); ;

            }
            else if (PhoneApp1.MainPage.winners.TeamInformationName == "Cote D'Ivoire")
            {
                webBrowserTask.Uri = new Uri("http://en.wikipedia.org/wiki/C%C3%B4te_d%27Ivoire_national_football_team", UriKind.Absolute); ;

            }
            else if (PhoneApp1.MainPage.winners.TeamInformationName == "Espana")
            {
                webBrowserTask.Uri = new Uri("http://en.wikipedia.org/wiki/Spain_national_football_team", UriKind.Absolute); ;

            }
            else if (PhoneApp1.MainPage.winners.TeamInformationName == "USA")
            {
                webBrowserTask.Uri = new Uri("http://en.wikipedia.org/wiki/United_States_men%27s_national_soccer_team", UriKind.Absolute); ;

            }
            else if (PhoneApp1.MainPage.winners.TeamInformationName == "South Korea")
            {
                webBrowserTask.Uri = new Uri("http://en.wikipedia.org/wiki/South_Korea_national_football_team", UriKind.Absolute); ;

            }
            else
            {
                webBrowserTask.Uri = new Uri("http://en.wikipedia.org/wiki/" + PhoneApp1.MainPage.winners.TeamInformationName + "_national_football_team", UriKind.Absolute); ;
            }
            webBrowserTask.Show();             
        }

        
    }
}