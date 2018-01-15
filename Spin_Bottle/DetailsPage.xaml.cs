using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Spin_Bottle.Resources;
using System.IO.IsolatedStorage;
using System.Windows.Media.Imaging;
using Microsoft.Phone.Tasks;

namespace Spin_Bottle
{
    public partial class DetailsPage : PhoneApplicationPage
    {
        // Constructor

        CameraCaptureTask _cameraTask1;
        CameraCaptureTask _cameraTask2;
        CameraCaptureTask _cameraTask3;
        CameraCaptureTask _cameraTask4;
        CameraCaptureTask _cameraTask5;
        CameraCaptureTask _cameraTask6;
        CameraCaptureTask _cameraTask7;
        CameraCaptureTask _cameraTask8;
        PhotoChooserTask _PhotoTask1;
        PhotoChooserTask _PhotoTask2;
        PhotoChooserTask _PhotoTask3;
        PhotoChooserTask _PhotoTask4;
        PhotoChooserTask _PhotoTask5;
        PhotoChooserTask _PhotoTask6;
        PhotoChooserTask _PhotoTask7;
        PhotoChooserTask _PhotoTask8;
        BitmapImage _image1;
        BitmapImage _image2;
        BitmapImage _image3;
        BitmapImage _image4;
        BitmapImage _image5;
        BitmapImage _image6;
        BitmapImage _image7;
        BitmapImage _image8;

        // Constructor            
        public DetailsPage()
        {
            InitializeComponent();
            _cameraTask1 = new CameraCaptureTask();
            _cameraTask1.Completed += _cameraTask1_Completed;

            _cameraTask2 = new CameraCaptureTask();
            _cameraTask2.Completed += _cameraTask2_Completed;

            _cameraTask3 = new CameraCaptureTask();
            _cameraTask3.Completed += _cameraTask3_Completed;

            _cameraTask4 = new CameraCaptureTask();
            _cameraTask4.Completed += _cameraTask4_Completed;

            _cameraTask5 = new CameraCaptureTask();
            _cameraTask5.Completed += _cameraTask5_Completed;

            _cameraTask6 = new CameraCaptureTask();
            _cameraTask6.Completed += _cameraTask6_Completed;

            _cameraTask7 = new CameraCaptureTask();
            _cameraTask7.Completed += _cameraTask7_Completed;

            _cameraTask8 = new CameraCaptureTask();
            _cameraTask8.Completed += _cameraTask8_Completed;

            _PhotoTask1 = new PhotoChooserTask();
            _PhotoTask1.Completed += _cameraTask1_Completed;

            _PhotoTask2 = new PhotoChooserTask();
            _PhotoTask2.Completed += _cameraTask2_Completed;

            _PhotoTask3 = new PhotoChooserTask();
            _PhotoTask3.Completed += _cameraTask3_Completed;

            _PhotoTask4 = new PhotoChooserTask();
            _PhotoTask4.Completed += _cameraTask4_Completed;

            _PhotoTask5 = new PhotoChooserTask();
            _PhotoTask5.Completed += _cameraTask5_Completed;

            _PhotoTask6 = new PhotoChooserTask();
            _PhotoTask6.Completed += _cameraTask6_Completed;

            _PhotoTask7 = new PhotoChooserTask();
            _PhotoTask7.Completed += _cameraTask7_Completed;

            _PhotoTask8 = new PhotoChooserTask();
            _PhotoTask8.Completed += _cameraTask8_Completed;

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();

            //_photo = new PhotoChooserTask();
            //_photo.Completed += _photo_Completed;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (DataContext == null)
            {
                string selectedIndex = "";
                if (NavigationContext.QueryString.TryGetValue("selectedItem", out selectedIndex))
                {
                    int index = int.Parse(selectedIndex);
                    switch (index)
                    {
                        case 0:
                            StackPanel_3.Children.Clear();
                            StackPanel_4.Children.Clear();
                            StackPanel_5.Children.Clear();
                            StackPanel_6.Children.Clear();
                            StackPanel_7.Children.Clear();
                            StackPanel_8.Children.Clear();
                            break;
                        case 1:
                            StackPanel_5.Children.Clear();
                            StackPanel_6.Children.Clear();
                            StackPanel_7.Children.Clear();
                            StackPanel_8.Children.Clear();
                            break;
                        case 2:
                            StackPanel_7.Children.Clear();
                            StackPanel_8.Children.Clear();
                            break;
                    }
                    DataContext = App.ViewModel.Items[index];
                }
            }
        }
        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            base.OnBackKeyPress(e);
            T1.Text = "- Player one -";
            T2.Text = "- Player two -";
            T3.Text = "- Player three -";
            T4.Text = "- Player four -";
            T5.Text = "- Player five -";
            T6.Text = "- Player six -";
            T7.Text = "- Player seven -";
            T8.Text = "- Player eight -";
        }
        private void CameraBtn1_Click(object sender, RoutedEventArgs e)
        {
            _cameraTask1.Show();
        }
        private void CameraBtn2_Click(object sender, RoutedEventArgs e)
        {
            //_photo.Show();
            _cameraTask2.Show();

        }
        private void CameraBtn3_Click(object sender, RoutedEventArgs e)
        {
            //_photo.Show();
            _cameraTask3.Show();

        }
        private void CameraBtn4_Click(object sender, RoutedEventArgs e)
        {
            //_photo.Show();
            _cameraTask4.Show();

        }
        private void CameraBtn5_Click(object sender, RoutedEventArgs e)
        {
            //_photo.Show();
            _cameraTask5.Show();

        }
        private void CameraBtn6_Click(object sender, RoutedEventArgs e)
        {
            //_photo.Show();
            _cameraTask6.Show();

        }
        private void CameraBtn7_Click(object sender, RoutedEventArgs e)
        {
            //_photo.Show();
            _cameraTask7.Show();

        }
        private void CameraBtn8_Click(object sender, RoutedEventArgs e)
        {
            //_photo.Show();
            _cameraTask8.Show();

        }

        void _cameraTask1_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                if (e.ChosenPhoto.Length <= 1000000.00)
                {
                    _image1 = new System.Windows.Media.Imaging.BitmapImage();
                    _image1.SetSource(e.ChosenPhoto);
                    image1.Source = _image1;
                    Image1 = true;
                }
                else
                {

                    MessageBox.Show("This Image Is Too large ..");
                }
            }
        }
        void _cameraTask2_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                if (e.ChosenPhoto.Length <= 1000000.00)
                {
                    _image2 = new System.Windows.Media.Imaging.BitmapImage();

                    _image2.SetSource(e.ChosenPhoto);
                    image2.Source = _image2;
                    Image2 = true;
                }
                else
                {
                    MessageBox.Show("This Image Is Too large ..");
                }

            }
        }
        void _cameraTask3_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                if (e.ChosenPhoto.Length <= 1000000.00)
                {
                    _image3 = new System.Windows.Media.Imaging.BitmapImage();

                    _image3.SetSource(e.ChosenPhoto);
                    image3.Source = _image3;
                    Image3 = true;
                }
                else
                {
                    MessageBox.Show("This Image Is Too large ..");
                }
            }
        }
        void _cameraTask4_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                if (e.ChosenPhoto.Length <= 1000000.00)
                {
                    _image4 = new System.Windows.Media.Imaging.BitmapImage();

                    _image4.SetSource(e.ChosenPhoto);
                    image4.Source = _image4;
                    Image4 = true;
                }
                else
                {
                    MessageBox.Show("This Image Is Too large ..");
                }

            }
        }
        void _cameraTask5_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                if (e.ChosenPhoto.Length <= 1000000.00)
                {
                    _image5 = new System.Windows.Media.Imaging.BitmapImage();

                    _image5.SetSource(e.ChosenPhoto);
                    image5.Source = _image5;
                    Image5 = true;
                }
                else
                {
                    MessageBox.Show("This Image Is Too large ..");
                }

            }
        }
        void _cameraTask6_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                if (e.ChosenPhoto.Length <= 1000000.00)
                {
                    _image6 = new System.Windows.Media.Imaging.BitmapImage();

                    _image6.SetSource(e.ChosenPhoto);
                    image6.Source = _image6;
                    Image6 = true;
                }
                else
                {
                    MessageBox.Show("This Image Is Too large ..");
                }

            }
        }
        void _cameraTask7_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                if (e.ChosenPhoto.Length <= 1000000.00)
                {
                    _image7 = new System.Windows.Media.Imaging.BitmapImage();

                    _image7.SetSource(e.ChosenPhoto);
                    image7.Source = _image7;
                    Image7 = true;
                }
                else
                {
                    MessageBox.Show("This Image Is Too large ..");
                }
            }
        }
        void _cameraTask8_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {

                if (e.ChosenPhoto.Length <= 1000000.00)
                {
                    _image8 = new System.Windows.Media.Imaging.BitmapImage();

                    _image8.SetSource(e.ChosenPhoto);
                    image8.Source = _image8;
                    Image8 = true;
                }
                else
                {
                    MessageBox.Show("This Image Is Too large ..");
                }

            }
        }
        // When page is navigated to set data context to selected item in list

        public static void SaveImage1(BitmapImage imageToBeSaved1, string fileName1)
        {
            using (var isoStore1 = IsolatedStorageFile.GetUserStoreForApplication())
            {
                var wb1 = new WriteableBitmap(imageToBeSaved1);

                using (var isoFileStream1 = isoStore1.CreateFile(fileName1))
                    Extensions.SaveJpeg(wb1, isoFileStream1, wb1.PixelWidth, wb1.PixelHeight, 0, 100);
            }
        }
        public static void SaveImage2(BitmapImage imageToBeSaved2, string fileName2)
        {
            using (var isoStore2 = IsolatedStorageFile.GetUserStoreForApplication())
            {
                var wb2 = new WriteableBitmap(imageToBeSaved2);

                using (var isoFileStream2 = isoStore2.CreateFile(fileName2))
                    Extensions.SaveJpeg(wb2, isoFileStream2, wb2.PixelWidth, wb2.PixelHeight, 0, 100);
            }
        }
        public static void SaveImage3(BitmapImage imageToBeSaved3, string fileName3)
        {
            using (var isoStore3 = IsolatedStorageFile.GetUserStoreForApplication())
            {
                var wb3 = new WriteableBitmap(imageToBeSaved3);

                using (var isoFileStream3 = isoStore3.CreateFile(fileName3))
                    Extensions.SaveJpeg(wb3, isoFileStream3, wb3.PixelWidth, wb3.PixelHeight, 0, 100);
            }
        }
        public static void SaveImage4(BitmapImage imageToBeSaved4, string fileName4)
        {
            using (var isoStore4 = IsolatedStorageFile.GetUserStoreForApplication())
            {
                var wb4 = new WriteableBitmap(imageToBeSaved4);

                using (var isoFileStream4 = isoStore4.CreateFile(fileName4))
                    Extensions.SaveJpeg(wb4, isoFileStream4, wb4.PixelWidth, wb4.PixelHeight, 0, 100);
            }
        }
        public static void SaveImage5(BitmapImage imageToBeSaved5, string fileName5)
        {
            using (var isoStore5 = IsolatedStorageFile.GetUserStoreForApplication())
            {
                var wb5 = new WriteableBitmap(imageToBeSaved5);

                using (var isoFileStream5 = isoStore5.CreateFile(fileName5))
                    Extensions.SaveJpeg(wb5, isoFileStream5, wb5.PixelWidth, wb5.PixelHeight, 0, 100);
            }
        }
        public static void SaveImage6(BitmapImage imageToBeSaved6, string fileName6)
        {
            using (var isoStore6 = IsolatedStorageFile.GetUserStoreForApplication())
            {
                var wb6 = new WriteableBitmap(imageToBeSaved6);

                using (var isoFileStream6 = isoStore6.CreateFile(fileName6))
                    Extensions.SaveJpeg(wb6, isoFileStream6, wb6.PixelWidth, wb6.PixelHeight, 0, 100);
            }
        }
        public static void SaveImage7(BitmapImage imageToBeSaved7, string fileName7)
        {
            using (var isoStore7 = IsolatedStorageFile.GetUserStoreForApplication())
            {
                var wb7 = new WriteableBitmap(imageToBeSaved7);

                using (var isoFileStream7 = isoStore7.CreateFile(fileName7))
                    Extensions.SaveJpeg(wb7, isoFileStream7, wb7.PixelWidth, wb7.PixelHeight, 0, 100);
            }
        }
        public static void SaveImage8(BitmapImage imageToBeSaved8, string fileName8)
        {
            using (var isoStore8 = IsolatedStorageFile.GetUserStoreForApplication())
            {
                var wb8 = new WriteableBitmap(imageToBeSaved8);

                using (var isoFileStream8 = isoStore8.CreateFile(fileName8))
                    Extensions.SaveJpeg(wb8, isoFileStream8, wb8.PixelWidth, wb8.PixelHeight, 0, 100);
            }
        }
        private void T1_GotFocus(object sender, RoutedEventArgs e)
        {
            if (T1.Text == "- Player one -")
            {
                T1.Text = "";
            }
        }
        private void T1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (T1.Text == "")
            {
                T1.Text = "- Player one -";
            }
            else
            {
                Text1 = true;
            }
        }
        private void T2_GotFocus(object sender, RoutedEventArgs e)
        {
            if (T2.Text == "- Player two -")
            {
                T2.Text = "";
            }
        }
        private void T2_LostFocus(object sender, RoutedEventArgs e)
        {
            if (T2.Text == "")
            {
                T2.Text = "- Player two -";
            }
            else
            {
                Text2 = true;
            }
        }
        private void T3_GotFocus(object sender, RoutedEventArgs e)
        {
            if (T3.Text == "- Player three -")
            {
                T3.Text = "";
            }
        }
        private void T3_LostFocus(object sender, RoutedEventArgs e)
        {
            if (T3.Text == "")
            {
                T3.Text = "- Player three -";
            }
            else
            {
                Text3 = true;
            }
        }
        private void T4_GotFocus(object sender, RoutedEventArgs e)
        {
            if (T4.Text == "- Player four -")
            {
                T4.Text = "";
            }
        }
        private void T4_LostFocus(object sender, RoutedEventArgs e)
        {
            if (T4.Text == "")
            {
                T4.Text = "- Player four -";
            }
            else
            {
                Text4 = true;
            }
        }
        private void T5_GotFocus(object sender, RoutedEventArgs e)
        {
            if (T5.Text == "- Player five -")
            {
                T5.Text = "";
            }
        }
        private void T5_LostFocus(object sender, RoutedEventArgs e)
        {
            if (T5.Text == "")
            {
                T5.Text = "- Player five -";
            }
            else
            {
                Text5 = true;
            }
        }
        private void T6_GotFocus(object sender, RoutedEventArgs e)
        {
            if (T6.Text == "- Player six -")
            {
                T6.Text = "";
            }
        }
        private void T6_LostFocus(object sender, RoutedEventArgs e)
        {
            if (T6.Text == "")
            {
                T6.Text = "- Player six -";
            }
            else
            {
                Text6 = true;
            }
        }
        private void T7_GotFocus(object sender, RoutedEventArgs e)
        {
            if (T7.Text == "- Player seven -")
            {
                T7.Text = "";
            }
        }
        private void T7_LostFocus(object sender, RoutedEventArgs e)
        {
            if (T7.Text == "")
            {
                T7.Text = "- Player seven -";
            }
            else
            {
                Text7 = true;
            }
        }
        private void T8_GotFocus(object sender, RoutedEventArgs e)
        {
            if (T8.Text == "- Player eight -")
            {
                T8.Text = "";
            }
        }
        private void T8_LostFocus(object sender, RoutedEventArgs e)
        {
            if (T8.Text == "")
            {
                T8.Text = "- Player eight -";
            }
            else
            {
                Text8 = true;
            }
        }
        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext == App.ViewModel.Items[0])
            {
                if (Text1 == true && Image1 == true)
                {
                    SaveImage1(this._image1, "image1.jpg");
                    SaveImage2(this._image2, "image2.jpg");
                    Button b = (Button)sender;
                    int id = int.Parse(b.Tag.ToString());
                    NavigationService.Navigate(new Uri("/Start.xaml?paramter=" + id, UriKind.Relative));
                }
                else
                {
                    MessageBox.Show("Please check Your Inputs");
                }
            }
            else if (DataContext == App.ViewModel.Items[1])
            {
                if (Text1 == true && Text2 == true && Text3 == true && Text4 == true && Image1 == true && Image2 == true && Image3 == true && Image4 == true)
                {
                    SaveImage1(this._image1, "image1.jpg");
                    SaveImage2(this._image2, "image2.jpg");
                    SaveImage3(this._image3, "image3.jpg");
                    SaveImage4(this._image4, "image4.jpg");
                    Button b = (Button)sender;
                    int id = int.Parse(b.Tag.ToString());
                    NavigationService.Navigate(new Uri("/Start.xaml?paramter=" + id, UriKind.Relative));
                }
                else
                {
                    MessageBox.Show("Please check Your Inputs");
                }

            }
            else if (DataContext == App.ViewModel.Items[2])
            {
                if (Text1 == true && Text2 == true && Text3 == true && Text4 == true && Text5 == true && Text6 == true && Image1 == true && Image2 == true && Image3 == true && Image4 == true && Image5 == true && Image6 == true)
                {
                    SaveImage1(this._image1, "image1.jpg");
                    SaveImage2(this._image2, "image2.jpg");
                    SaveImage3(this._image3, "image3.jpg");
                    SaveImage4(this._image4, "image4.jpg");
                    SaveImage5(this._image5, "image5.jpg");
                    SaveImage6(this._image6, "image6.jpg");
                    Button b = (Button)sender;
                    int id = int.Parse(b.Tag.ToString());
                    NavigationService.Navigate(new Uri("/Start.xaml?paramter=" + id, UriKind.Relative));
                }
                else
                {
                    MessageBox.Show("Please check Your Inputs");
                }

            }
            else
            {
                if (Text1 == true && Text2 == true && Text3 == true && Text4 == true && Text5 == true && Text6 == true && Text7 == true && Text8 == true && Image1 == true && Image2 == true && Image3 == true && Image4 == true && Image5 == true && Image6 == true && Image7 == true && Image8 == true)
                {
                    SaveImage1(this._image1, "image1.jpg");
                    SaveImage2(this._image2, "image2.jpg");
                    SaveImage3(this._image3, "image3.jpg");
                    SaveImage4(this._image4, "image4.jpg");
                    SaveImage5(this._image5, "image5.jpg");
                    SaveImage6(this._image6, "image6.jpg");
                    SaveImage7(this._image7, "image7.jpg");
                    SaveImage8(this._image8, "image8.jpg");
                    Button b = (Button)sender;
                    int id = int.Parse(b.Tag.ToString());
                    NavigationService.Navigate(new Uri("/Start.xaml?paramter=" + id, UriKind.Relative));
                }
                else
                {
                    MessageBox.Show("Please check Your Inputs");
                }
            }
        }
        public bool Image1 { get; set; }
        public bool Image2 { get; set; }
        public bool Image3 { get; set; }
        public bool Image4 { get; set; }
        public bool Image5 { get; set; }
        public bool Image6 { get; set; }
        public bool Image7 { get; set; }
        public bool Image8 { get; set; }
        public bool Text1 { get; set; }
        public bool Text2 { get; set; }
        public bool Text3 { get; set; }
        public bool Text4 { get; set; }
        public bool Text5 { get; set; }
        public bool Text6 { get; set; }
        public bool Text7 { get; set; }
        public bool Text8 { get; set; }

        private void BrowseBtn1_Click(object sender, RoutedEventArgs e)
        {
            _PhotoTask1.Show();
        }

        private void BrowseBtn2_Click(object sender, RoutedEventArgs e)
        {
            _PhotoTask2.Show();
        }

        private void BrowseBtn3_Click(object sender, RoutedEventArgs e)
        {
            _PhotoTask3.Show();
        }

        private void BrowseBtn4_Click(object sender, RoutedEventArgs e)
        {
            _PhotoTask4.Show();
        }

        private void BrowseBtn5_Click(object sender, RoutedEventArgs e)
        {
            _PhotoTask5.Show();
        }

        private void BrowseBtn6_Click(object sender, RoutedEventArgs e)
        {
            _PhotoTask6.Show();
        }

        private void BrowseBtn7_Click(object sender, RoutedEventArgs e)
        {
            _PhotoTask7.Show();
        }

        private void BrowseBtn8_Click(object sender, RoutedEventArgs e)
        {
            _PhotoTask8.Show();
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }

}
