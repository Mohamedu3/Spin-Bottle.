using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Spin_Bottle.Resources;

namespace Spin_Bottle.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<ItemViewModel> Items { get; private set; }

        private string _sampleProperty = "Sample Runtime Property Value";
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        /// <summary>
        /// Sample property that returns a localized string
        /// </summary>
        public string LocalizedSampleProperty
        {
            get
            {
                return AppResources.SampleProperty;
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }
        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            // Sample data; replace with real data
            this.Items.Add(new ItemViewModel() { ID = "0", MusicSound = false, Angel = "/Assets/Angel.Png", Liar = "/Assets/Liar.Png",
                ColorBg = "#3498db", Help = "/Assets/Help.png", Music = "/Assets/Sound.png", Background = "/Assets/bg.jpg",
                Button = "Two Players", DarkColorBg = "#2980B9", BrowseButton = "/Assets/Defulte.png", TextBox1 = "- Player one -", TextBox2 = "- Player two -", TextBox3 = "- Player three -", TextBox4 = "- Player four -", TextBox5 = "- Player five -", TextBox6 = "- Player six -", TextBox7 = "- Player seven -", TextBox8 = "- Player eight -",
                StartButton = "Start", Bottle = "/Assets/icon_23130.png", Helping_Header = "How to Play ?",
                Helping_Content = "Choose number of players , Then write their names and choose photos (Recommendation : use the front cam) , When the game start press  ' spin ' button to spin the bottle and repeat this to spin again , At the end of the game if you want to show the result press 'show result' , If you want play again press back button.(Recommendation : Image size less than 1 mb)"
            });
            this.Items.Add(new ItemViewModel() { ID = "1", MusicSound = false, Angel = "/Assets/Angel.Png", Liar = "/Assets/Liar.Png", ColorBg = "#3498db", Background = "/Assets/bg.jpg", Button = "Four Players", DarkColorBg = "#2980B9", BrowseButton = "/Assets/Defulte.png", TextBox1 = "- Player one -", TextBox2 = "- Player two -", TextBox3 = "- Player three -", TextBox4 = "- Player four -", TextBox5 = "- Player five -", TextBox6 = "- Player six -", TextBox7 = "- Player seven -", TextBox8 = "- Player eight -", StartButton = "Start", Bottle = "/Assets/icon_23130.png" });
            this.Items.Add(new ItemViewModel() { ID = "2", MusicSound = false, Angel = "/Assets/Angel.Png", Liar = "/Assets/Liar.Png", ColorBg = "#3498db", Background = "/Assets/bg.jpg", Button = "Six Players", DarkColorBg = "#2980B9", BrowseButton = "/Assets/Defulte.png", TextBox1 = "- Player one -", TextBox2 = "- Player two -", TextBox3 = "- Player three -", TextBox4 = "- Player four -", TextBox5 = "- Player five -", TextBox6 = "- Player six -", TextBox7 = "- Player seven -", TextBox8 = "- Player eight -", StartButton = "Start", Bottle = "/Assets/icon_23130.png" });
            this.Items.Add(new ItemViewModel() { ID = "3", MusicSound = false, Angel = "/Assets/Angel.Png", Liar = "/Assets/Liar.Png", ColorBg = "#3498db", Background = "/Assets/bg.jpg", Button = "Eight Players", DarkColorBg = "#2980B9", BrowseButton = "/Assets/Defulte.png", TextBox1 = "- Player one -", TextBox2 = "- Player two -", TextBox3 = "- Player three -", TextBox4 = "- Player four -", TextBox5 = "- Player five -", TextBox6 = "- Player six -", TextBox7 = "- Player seven -", TextBox8 = "- Player eight -", StartButton = "Start", Bottle = "/Assets/icon_23130.png" });

            this.IsDataLoaded = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}