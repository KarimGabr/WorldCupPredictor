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
using System.IO.IsolatedStorage;
using System.IO;
using Microsoft.Xna.Framework.Media;
using Microsoft.Phone.Tasks;

namespace PhoneApp1
{
    public partial class CompletePredictions : PhoneApplicationPage
    {
        //PhotoChooserTask photoChooserTask = new PhotoChooserTask();
        public static string fileName = null;
        public CompletePredictions()
        {
            InitializeComponent();

            //photoChooserTask.Completed += photoChooserTask_Completed;


            if (PhoneApp1.MainPage.winners.IsPredictionsAreFinished == true)
            {
                Complete1.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.AFirstPlace + ".jpg", UriKind.Relative));
                Complete2.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.BSecondPlace + ".jpg", UriKind.Relative));

                Complete3.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.CFirstPlace + ".jpg", UriKind.Relative));
                Complete4.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.DSecondPlace + ".jpg", UriKind.Relative));

                Complete5.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.ASecondPlace + ".jpg", UriKind.Relative));
                Complete6.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.BFirstPlace + ".jpg", UriKind.Relative));

                Complete7.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.CSecondPlace + ".jpg", UriKind.Relative));
                Complete8.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.DFirstPlace + ".jpg", UriKind.Relative));

                Complete9.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.EFirstPlace + ".jpg", UriKind.Relative));
                Complete10.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.FSecondPlace + ".jpg", UriKind.Relative));

                Complete11.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.GFirstPlace + ".jpg", UriKind.Relative));
                Complete12.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.HSecondPlace + ".jpg", UriKind.Relative));

                Complete13.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.ESecondPlace + ".jpg", UriKind.Relative));
                Complete14.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.FFirstPlace + ".jpg", UriKind.Relative));

                Complete15.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.GSecondPlace + ".jpg", UriKind.Relative));
                Complete16.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.HFirstPlace + ".jpg", UriKind.Relative));

                Complete17.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match49Winner + ".jpg", UriKind.Relative));
                Complete18.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match50Winner + ".jpg", UriKind.Relative));

                Complete19.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match53Winner + ".jpg", UriKind.Relative));
                Complete20.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match54Winner + ".jpg", UriKind.Relative));

                Complete21.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match51Winner + ".jpg", UriKind.Relative));
                Complete22.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match52Winner + ".jpg", UriKind.Relative));

                Complete23.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match55Winner + ".jpg", UriKind.Relative));
                Complete24.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match56Winner + ".jpg", UriKind.Relative));

                Complete25.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match57Winner + ".jpg", UriKind.Relative));
                Complete26.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match58Winner + ".jpg", UriKind.Relative));

                Complete27.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match59Winner + ".jpg", UriKind.Relative));
                Complete28.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match60Winner + ".jpg", UriKind.Relative));

                Complete29.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match61Loser + ".jpg", UriKind.Relative));
                Complete30.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match62Loser + ".jpg", UriKind.Relative));

                Complete31.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match61Winner + ".jpg", UriKind.Relative));
                Complete32.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match62Winner + ".jpg", UriKind.Relative));

                Complete33.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match63Winner + ".jpg", UriKind.Relative));

                Complete34.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match64Loser + ".jpg", UriKind.Relative));

                Complete35.Source = new BitmapImage(new Uri("/Images/" + PhoneApp1.MainPage.winners.Match64Winner + ".jpg", UriKind.Relative));
            }
          
        }

        /*void photoChooserTask_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                ShowShareMediaTask(e.OriginalFileName);
            }
        }

        void ShowShareMediaTask(string path)
        {
            ShareMediaTask shareMediaTask = new ShareMediaTask();
            shareMediaTask.FilePath = fileName;
            shareMediaTask.Show();
        }*/

        private void FacebookButton_Click(object sender, RoutedEventArgs e)
        {
            WriteableBitmap screenshot = new WriteableBitmap((int)CompleteTable.ActualWidth, (int)CompleteTable.ActualHeight);
            screenshot.Render(CompleteTable, null);
            screenshot.Invalidate();
            fileName = "FIFA_World_Cup_2014_Predictor" + DateTime.Now.Ticks + ".jpg";
            var myStore = IsolatedStorageFile.GetUserStoreForApplication();
            IsolatedStorageFileStream myFileStream = myStore.CreateFile(fileName);
            screenshot.SaveJpeg(myFileStream, 1024, 1080, 0, 100);
            myFileStream.Close();
            myFileStream = myStore.OpenFile(fileName, FileMode.Open, FileAccess.Read);
            MediaLibrary library = new MediaLibrary();
            library.SavePicture(fileName, myFileStream);
            //photoChooserTask.Show();
            ShareMediaTask shareMediaTask = new ShareMediaTask();
            shareMediaTask.FilePath = fileName;
            shareMediaTask.Show();
        }

        private void TwitterButton_Click(object sender, RoutedEventArgs e)
        {
            WriteableBitmap screenshot = new WriteableBitmap((int)CompleteTable.ActualWidth, (int)CompleteTable.ActualHeight);
            screenshot.Render(CompleteTable, null);
            screenshot.Invalidate();
            fileName = "FIFA_World_Cup_2014_Predictor" + DateTime.Now.Ticks + ".jpg";
            var myStore = IsolatedStorageFile.GetUserStoreForApplication();
            IsolatedStorageFileStream myFileStream = myStore.CreateFile(fileName);
            screenshot.SaveJpeg(myFileStream, 1024, 1080, 0, 100);
            myFileStream.Close();
            myFileStream = myStore.OpenFile(fileName, FileMode.Open, FileAccess.Read);
            MediaLibrary library = new MediaLibrary();
            library.SavePicture(fileName, myFileStream);
            //photoChooserTask.Show();
            ShareMediaTask shareMediaTask = new ShareMediaTask();
            shareMediaTask.FilePath = fileName;
            shareMediaTask.Show();
        }
    }
}