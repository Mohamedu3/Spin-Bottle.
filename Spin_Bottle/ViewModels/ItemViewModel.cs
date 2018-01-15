using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Spin_Bottle.ViewModels
{
    public class ItemViewModel : INotifyPropertyChanged
    {
        private string _id;
        /// <summary>
        /// Sample ViewModel property; this property is used to identify the object.
        /// </summary>
        /// <returns></returns>
        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    _id = value;
                    NotifyPropertyChanged("ID");
                }
            }
        }

        private string _Help;
        /// <summary>
        /// Sample ViewModel property; this property is used to identify the object.
        /// </summary>
        /// <returns></returns>
        public string Help
        {
            get
            {
                return _Help;
            }
            set
            {
                if (value != _Help)
                {
                    _Help = value;
                    NotifyPropertyChanged("Help");
                }
            }
        }

        private string _Background;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string Background
        {
            get
            {
                return _Background;
            }
            set
            {
                if (value != _Background)
                {
                    _Background = value;
                    NotifyPropertyChanged("Background");
                }
            }
        }

        private string _Button;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string Button
        {
            get
            {
                return _Button;
            }
            set
            {
                if (value != _Button)
                {
                    _Button = value;
                    NotifyPropertyChanged("Button");
                }
            }
        }

        private string _DarkColorBg;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string DarkColorBg
        {
            get
            {
                return _DarkColorBg;
            }
            set
            {
                if (value != _DarkColorBg)
                {
                    _DarkColorBg = value;
                    NotifyPropertyChanged("DarkColorBg");
                }
            }
        }

        private string _Music;
        public string Music
        {
            get
            {
                return _Music;
            }
            set
            {
                if (value != _Music)
                {
                    _Music = value;
                    NotifyPropertyChanged("Music");
                }
            }
        }

        private string _TextBox1;
        public string TextBox1
        {
            get
            {
                return _TextBox1;
            }
            set
            {

                if (value != _TextBox1)
                {
                    _TextBox1 = value;
                    NotifyPropertyChanged("TextBox1");
                }
            }
        }

        private string _TextBox2;
        public string TextBox2
        {
            get
            {
                return _TextBox2;
            }
            set
            {

                if (value != _TextBox2)
                {
                    _TextBox2 = value;
                    NotifyPropertyChanged("TextBox2");
                }
            }
        }

        private string _TextBox3;
        public string TextBox3
        {
            get
            {
                return _TextBox3;
            }
            set
            {

                if (value != _TextBox3)
                {
                    _TextBox3 = value;
                    NotifyPropertyChanged("TextBox3");
                }
            }
        }

        private string _TextBox4;
        public string TextBox4
        {
            get
            {
                return _TextBox4;
            }
            set
            {

                if (value != _TextBox4)
                {
                    _TextBox4 = value;
                    NotifyPropertyChanged("TextBox4");
                }
            }
        }

        private string _TextBox5;
        public string TextBox5
        {
            get
            {
                return _TextBox5;
            }
            set
            {

                if (value != _TextBox5)
                {
                    _TextBox5 = value;
                    NotifyPropertyChanged("TextBox5");
                }
            }
        }

        private string _TextBox6;
        public string TextBox6
        {
            get
            {
                return _TextBox6;
            }
            set
            {

                if (value != _TextBox6)
                {
                    _TextBox6 = value;
                    NotifyPropertyChanged("TextBox6");
                }
            }
        }

        private string _TextBox7;
        public string TextBox7
        {
            get
            {
                return _TextBox7;
            }
            set
            {

                if (value != _TextBox7)
                {
                    _TextBox7 = value;
                    NotifyPropertyChanged("TextBox7");
                }
            }
        }

        private string _TextBox8;
        public string TextBox8
        {
            get
            {
                return _TextBox8;
            }
            set
            {

                if (value != _TextBox8)
                {
                    _TextBox8 = value;
                    NotifyPropertyChanged("TextBox8");
                }
            }
        }

        private string _BrowseButton;
        public string BrowseButton
        {
            get
            {
                return _BrowseButton;
            }
            set
            {

                if (value != _BrowseButton)
                {
                    _BrowseButton = value;
                    NotifyPropertyChanged("BrowseButton");
                }
            }
        }

        private string _StartButton;
        public string StartButton
        {
            get
            {
                return _StartButton;
            }
            set
            {

                if (value != _StartButton)
                {
                    _StartButton = value;
                    NotifyPropertyChanged("StartButton");
                }
            }
        }

        public string _Bottle;
        public string Bottle
        {
            get
            {
                return _Bottle;
            }
            set
            {

                if (value != _Bottle)
                {
                    _Bottle = value;
                    NotifyPropertyChanged("Bottle");
                }
            }
        }

        public string _ColorBg;
        public string ColorBg
        {
            get
            {
                return _ColorBg;
            }
            set
            {

                if (value != _ColorBg)
                {
                    _ColorBg = value;
                    NotifyPropertyChanged("ColorBg");
                }
            }
        }

        public string _Helping_Header;
        public string Helping_Header
        {
            get
            {
                return _Helping_Header;
            }
            set
            {

                if (value != _Helping_Header)
                {
                    _Helping_Header = value;
                    NotifyPropertyChanged("Helping_Header");
                }
            }
        }

        public string _Helping_Content;
        public string Helping_Content
        {
            get
            {
                return _Helping_Content;
            }
            set
            {

                if (value != _Helping_Content)
                {
                    _Helping_Content = value;
                    NotifyPropertyChanged("Helping_Content");
                }
            }
        }

        public string _Liar;
        public string Liar
        {
            get
            {
                return _Liar;
            }
            set
            {

                if (value != _Liar)
                {
                    _Liar = value;
                    NotifyPropertyChanged("Liar");
                }
            }
        }

        public string _Angel;
        public string Angel
        {
            get
            {
                return _Angel;
            }
            set
            {

                if (value != _Angel)
                {
                    _Angel = value;
                    NotifyPropertyChanged("Angel");
                }
            }
        }


        public bool _MusicSound;
        public bool MusicSound
        {
            get
            {
                return _MusicSound;
            }
            set
            {

                if (value != _MusicSound)
                {
                    _MusicSound = value;
                    NotifyPropertyChanged("MusicSound");
                }
            }
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