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
using Spin_Bottle.ViewModels;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Spin_Bottle
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            // Set the data context of the LongListSelector control to the sample data
            DataContext = App.ViewModel;
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        // Handle selection changed on LongListSelector
        private void MainLongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // If selected item is null (no selection) do nothing
            if (MainLongListSelector.SelectedItem == null)
                return;

            // Navigate to the new page
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?selectedItem=" + (MainLongListSelector.SelectedItem as ItemViewModel).ID, UriKind.Relative));
            // Reset selected item to null (no selection)
            MainLongListSelector.SelectedItem = null;
        }

        private void HideSettings_Completed(object sender, EventArgs e)
        {
            MainLongListSelector.IsEnabled = true;
            BottleButton.IsEnabled = false;
        }

        private void HelpingButton_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

            if (Helping.Opacity == 0)
            {
                ShowHelping.Begin();
                MainLongListSelector.IsEnabled = false;
            }
            else if (Helping.Opacity == 1)
            {
                HideHelping.Begin();
                MainLongListSelector.IsEnabled = true;
            }

        }
        private void BottleButton_Checked(object sender, RoutedEventArgs e)
        {
            ImageBrush n = new ImageBrush();
            n.ImageSource = new BitmapImage(new Uri("/Assets/Muted.png", UriKind.Relative));
            BottleButton.Background = n;
        }

        private void BottleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            ImageBrush n = new ImageBrush();
            n.ImageSource = new BitmapImage(new Uri("/Assets/Sound.png", UriKind.Relative));
            BottleButton.Background = n;
            Music.Play();
        }

        private void Music_MediaEnded(object sender, RoutedEventArgs e)
        {
            Music.Play();
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