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

namespace Spin_Bottle
{
    public partial class Start : PhoneApplicationPage
    {
        public Start()
        {
            InitializeComponent();
            AskTextBox.Text = "- Enter Your Question -";
            AnswerTextBox.Text = "- Enter Your Answer -";
            HideAllWindows_Comp = true;
            ShowAtBegin.Begin();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Random r = new Random();
            string current_id = NavigationContext.QueryString["paramter"];
            if (DataContext == null)
            {
                int index = int.Parse(current_id);
                DataContext = App.ViewModel.Items[index];
                switch (index)
                {
                    case 0:
                        var TwoPlayers_Rolls = Enumerable.Range(1, 2)
                            .OrderBy(x => r.Next()) // randomize the order
                            .ToList(); // turn the sequence into an array.
                        Roll_Number.Add(TwoPlayers_Rolls[0]);
                        Roll_Number.Add(TwoPlayers_Rolls[1]);
                        PlayerImage_7.Source = LoadImage1("image1.jpg");
                        PlayerImage_3.Source = LoadImage2("image2.jpg");
                        Player_Image1_Points.Source = LoadImage1("image1.jpg");
                        Player_Image2_Points.Source = LoadImage2("image2.jpg");
                        Player_3.Children.Clear();
                        Player_4.Children.Clear();
                        Player_5.Children.Clear();
                        Player_6.Children.Clear();
                        Player_7.Children.Clear();
                        Player_8.Children.Clear();
                        break;
                    case 1:
                        var FourPlayers_Rolls = Enumerable.Range(1, 4)
                            .OrderBy(x => r.Next()) // randomize the order
                            .ToList(); // turn the sequence into an array.
                        Roll_Number.Add(FourPlayers_Rolls[0]);
                        Roll_Number.Add(FourPlayers_Rolls[1]);
                        Roll_Number.Add(FourPlayers_Rolls[2]);
                        Roll_Number.Add(FourPlayers_Rolls[3]);
                        PlayerImage_1.Source = LoadImage1("image1.jpg");
                        PlayerImage_3.Source = LoadImage2("image2.jpg");
                        PlayerImage_5.Source = LoadImage3("image3.jpg");
                        PlayerImage_7.Source = LoadImage4("image4.jpg");
                        Player_Image1_Points.Source = LoadImage1("image1.jpg");
                        Player_Image2_Points.Source = LoadImage2("image2.jpg");
                        Player_Image3_Points.Source = LoadImage3("image3.jpg");
                        Player_Image4_Points.Source = LoadImage4("image4.jpg");
                        Player_5.Children.Clear();
                        Player_6.Children.Clear();
                        Player_7.Children.Clear();
                        Player_8.Children.Clear();
                        break;
                    case 2:
                        var SixPlayers_Rolls = Enumerable.Range(1, 6)
                            .OrderBy(x => r.Next()) // randomize the order
                            .ToList(); // turn the sequence into an array.
                        Roll_Number.Add(SixPlayers_Rolls[0]);
                        Roll_Number.Add(SixPlayers_Rolls[1]);
                        Roll_Number.Add(SixPlayers_Rolls[2]);
                        Roll_Number.Add(SixPlayers_Rolls[3]);
                        Roll_Number.Add(SixPlayers_Rolls[4]);
                        Roll_Number.Add(SixPlayers_Rolls[5]);
                        PlayerImage_1.Source = LoadImage1("image1.jpg");
                        PlayerImage_2.Source = LoadImage2("image2.jpg");
                        PlayerImage_4.Source = LoadImage3("image3.jpg");
                        PlayerImage_5.Source = LoadImage4("image4.jpg");
                        PlayerImage_6.Source = LoadImage5("image5.jpg");
                        PlayerImage_8.Source = LoadImage6("image6.jpg");
                        PlayerImage_3.Height = 40;
                        PlayerImage_7.Height = 40;
                        Player_Image1_Points.Source = LoadImage1("image1.jpg");
                        Player_Image2_Points.Source = LoadImage2("image2.jpg");
                        Player_Image3_Points.Source = LoadImage3("image4.jpg");
                        Player_Image4_Points.Source = LoadImage4("image3.jpg");
                        Player_Image5_Points.Source = LoadImage5("image4.jpg");
                        Player_Image6_Points.Source = LoadImage6("image6.jpg");
                        Player_7.Children.Clear();
                        Player_8.Children.Clear();
                        break;
                    default:
                        var EightPlayers_Rolls = Enumerable.Range(1, 8)
                             .OrderBy(x => r.Next()) // randomize the order
                             .ToList(); // turn the sequence into an array.
                        Roll_Number.Add(EightPlayers_Rolls[0]);
                        Roll_Number.Add(EightPlayers_Rolls[1]);
                        Roll_Number.Add(EightPlayers_Rolls[2]);
                        Roll_Number.Add(EightPlayers_Rolls[3]);
                        Roll_Number.Add(EightPlayers_Rolls[4]);
                        Roll_Number.Add(EightPlayers_Rolls[5]);
                        Roll_Number.Add(EightPlayers_Rolls[6]);
                        Roll_Number.Add(EightPlayers_Rolls[7]);
                        PlayerImage_1.Source = LoadImage1("image1.jpg");
                        PlayerImage_2.Source = LoadImage2("image2.jpg");
                        PlayerImage_3.Source = LoadImage3("image3.jpg");
                        PlayerImage_4.Source = LoadImage4("image4.jpg");
                        PlayerImage_5.Source = LoadImage5("image5.jpg");
                        PlayerImage_6.Source = LoadImage6("image6.jpg");
                        PlayerImage_7.Source = LoadImage7("image7.jpg");
                        PlayerImage_8.Source = LoadImage8("image8.jpg");
                        Player_Image1_Points.Source = LoadImage1("image1.jpg");
                        Player_Image2_Points.Source = LoadImage2("image2.jpg");
                        Player_Image3_Points.Source = LoadImage3("image3.jpg");
                        Player_Image4_Points.Source = LoadImage4("image4.jpg");
                        Player_Image5_Points.Source = LoadImage5("image5.jpg");
                        Player_Image6_Points.Source = LoadImage6("image6.jpg");
                        Player_Image7_Points.Source = LoadImage7("image7.jpg");
                        Player_Image8_Points.Source = LoadImage8("image8.jpg");
                        break;
                }
            }

        }
        public static BitmapImage LoadImage1(string fileName1)
        {
            BitmapImage retreivedImage1 = new BitmapImage();
            using (var isoStore = IsolatedStorageFile.GetUserStoreForApplication())
            {

                using (var isoFileStream = isoStore.OpenFile(fileName1, System.IO.FileMode.Open))
                    retreivedImage1.SetSource(isoFileStream);

                return retreivedImage1;
            }
        }
        public static BitmapImage LoadImage2(string fileName2)
        {
            BitmapImage retreivedImage2 = new BitmapImage();
            using (var isoStore = IsolatedStorageFile.GetUserStoreForApplication())
            {

                using (var isoFileStream = isoStore.OpenFile(fileName2, System.IO.FileMode.Open))
                    retreivedImage2.SetSource(isoFileStream);

                return retreivedImage2;
            }
        }
        public static BitmapImage LoadImage3(string fileName3)
        {
            BitmapImage retreivedImage3 = new BitmapImage();
            using (var isoStore = IsolatedStorageFile.GetUserStoreForApplication())
            {

                using (var isoFileStream = isoStore.OpenFile(fileName3, System.IO.FileMode.Open))
                    retreivedImage3.SetSource(isoFileStream);

                return retreivedImage3;
            }
        }
        public static BitmapImage LoadImage4(string fileName4)
        {
            BitmapImage retreivedImage4 = new BitmapImage();
            using (var isoStore = IsolatedStorageFile.GetUserStoreForApplication())
            {

                using (var isoFileStream = isoStore.OpenFile(fileName4, System.IO.FileMode.Open))
                    retreivedImage4.SetSource(isoFileStream);

                return retreivedImage4;
            }
        }
        public static BitmapImage LoadImage5(string fileName5)
        {
            BitmapImage retreivedImage5 = new BitmapImage();
            using (var isoStore = IsolatedStorageFile.GetUserStoreForApplication())
            {

                using (var isoFileStream = isoStore.OpenFile(fileName5, System.IO.FileMode.Open))
                    retreivedImage5.SetSource(isoFileStream);

                return retreivedImage5;
            }
        }
        public static BitmapImage LoadImage6(string fileName6)
        {
            BitmapImage retreivedImage6 = new BitmapImage();
            using (var isoStore = IsolatedStorageFile.GetUserStoreForApplication())
            {

                using (var isoFileStream = isoStore.OpenFile(fileName6, System.IO.FileMode.Open))
                    retreivedImage6.SetSource(isoFileStream);

                return retreivedImage6;
            }
        }
        public static BitmapImage LoadImage7(string fileName7)
        {
            BitmapImage retreivedImage7 = new BitmapImage();
            using (var isoStore = IsolatedStorageFile.GetUserStoreForApplication())
            {

                using (var isoFileStream = isoStore.OpenFile(fileName7, System.IO.FileMode.Open))
                    retreivedImage7.SetSource(isoFileStream);

                return retreivedImage7;
            }
        }
        public static BitmapImage LoadImage8(string fileName8)
        {
            BitmapImage retreivedImage8 = new BitmapImage();
            using (var isoStore = IsolatedStorageFile.GetUserStoreForApplication())
            {

                using (var isoFileStream = isoStore.OpenFile(fileName8, System.IO.FileMode.Open))
                    retreivedImage8.SetSource(isoFileStream);

                return retreivedImage8;
            }
        }

        private Clicks N_Cliks = Clicks.FristClick;

        public List<int> Roll_Number = new List<int>();

        private Clicks Roll_To_Points = Clicks.FristClick;

        private void RollButton_Click(object sender, EventArgs e)
        {

            if (HideAllWindows_Comp == true && TheEnd.Opacity == 0)
            {
                /////////////////////////////////- Two Players (Start) -///////////////////////////////////
                if (DataContext == App.ViewModel.Items[0])
                {
                    if (N_Cliks == Clicks.FristClick)
                    {
                        HideAtBegin.Begin();
                        if (Roll_Number[0] == 1)
                        {
                            BottleSound.Play();
                            RollBottle2.Begin();
                            PlayerAsker.Text = Player2.Text;
                            PlayerAsked.Text = Player1.Text;
                            Player_Asker.Text = Player2.Text;
                            Player_asked.Text = Player1.Text;
                            PlayerAnswer.Text = Player1.Text;
                            PlayerAnswered.Text = Player2.Text;
                        }
                        else if (Roll_Number[0] == 2)
                        {
                            BottleSound.Play();
                            RollBottle6.Begin();
                            PlayerAsker.Text = Player1.Text;
                            PlayerAsked.Text = Player2.Text;
                            Player_Asker.Text = Player1.Text;
                            Player_asked.Text = Player2.Text;
                            PlayerAnswer.Text = Player2.Text;
                            PlayerAnswered.Text = Player1.Text;
                        }
                        N_Cliks = Clicks.SecondClick;

                    }

                    else if (N_Cliks == Clicks.SecondClick)
                    {
                        if (Roll_Number[1] == 1)
                        {
                            BottleSound.Play();
                            RollBottle2.Begin();
                            PlayerAsker.Text = Player2.Text;
                            PlayerAsked.Text = Player1.Text;
                            Player_Asker.Text = Player2.Text;
                            Player_asked.Text = Player1.Text;
                            PlayerAnswer.Text = Player1.Text;
                            PlayerAnswered.Text = Player2.Text;
                        }
                        else if (Roll_Number[1] == 2)
                        {
                            BottleSound.Play();
                            RollBottle6.Begin();
                            PlayerAsker.Text = Player1.Text;
                            PlayerAsked.Text = Player2.Text;
                            Player_Asker.Text = Player1.Text;
                            Player_asked.Text = Player2.Text;
                            PlayerAnswer.Text = Player2.Text;
                            PlayerAnswered.Text = Player1.Text;
                        }
                        N_Cliks = Clicks.ThirdClick;
                    }
                }
                /////////////////////////////////- Two Players (End) -///////////////////////////////////

                    /////////////////////////////////- Four Players (Start) -///////////////////////////////////
                else if (DataContext == App.ViewModel.Items[1])
                {
                    if (N_Cliks == Clicks.FristClick)
                    {
                        HideAtBegin.Begin();
                        if (Roll_Number[0] == 1)
                        {
                            BottleSound.Play();
                            RollBottle2.Begin();
                            PlayerAsker.Text = Player2.Text;
                            PlayerAsked.Text = Player4.Text;
                            Player_Asker.Text = Player2.Text;
                            Player_asked.Text = Player4.Text;
                            PlayerAnswer.Text = Player4.Text;
                            PlayerAnswered.Text = Player2.Text;
                        }
                        else if (Roll_Number[0] == 2)
                        {
                            BottleSound.Play();
                            RollBottle6.Begin();
                            PlayerAsker.Text = Player4.Text;
                            PlayerAsked.Text = Player2.Text;
                            Player_Asker.Text = Player4.Text;
                            Player_asked.Text = Player2.Text;
                            PlayerAnswer.Text = Player2.Text;
                            PlayerAnswered.Text = Player4.Text;
                        }
                        else if (Roll_Number[0] == 3)
                        {
                            BottleSound.Play();
                            RollBottle8.Begin();
                            PlayerAsker.Text = Player1.Text;
                            PlayerAsked.Text = Player3.Text;
                            Player_Asker.Text = Player1.Text;
                            Player_asked.Text = Player3.Text;
                            PlayerAnswer.Text = Player3.Text;
                            PlayerAnswered.Text = Player1.Text;
                        }
                        else if (Roll_Number[0] == 4)
                        {
                            BottleSound.Play();
                            RollBottle4.Begin();
                            PlayerAsker.Text = Player3.Text;
                            PlayerAsked.Text = Player1.Text;
                            Player_Asker.Text = Player3.Text;
                            Player_asked.Text = Player1.Text;
                            PlayerAnswer.Text = Player1.Text;
                            PlayerAnswered.Text = Player3.Text;
                        }
                        N_Cliks = Clicks.SecondClick;
                    }

                    else if (N_Cliks == Clicks.SecondClick)
                    {
                        if (Roll_Number[1] == 1)
                        {
                            BottleSound.Play();
                            RollBottle2.Begin();
                            PlayerAsker.Text = Player2.Text;
                            PlayerAsked.Text = Player4.Text;
                            Player_Asker.Text = Player2.Text;
                            Player_asked.Text = Player4.Text;
                            PlayerAnswer.Text = Player4.Text;
                            PlayerAnswered.Text = Player2.Text;
                        }
                        else if (Roll_Number[1] == 2)
                        {
                            BottleSound.Play();
                            RollBottle6.Begin();
                            PlayerAsker.Text = Player4.Text;
                            PlayerAsked.Text = Player2.Text;
                            Player_Asker.Text = Player4.Text;
                            Player_asked.Text = Player2.Text;
                            PlayerAnswer.Text = Player2.Text;
                            PlayerAnswered.Text = Player4.Text;
                        }
                        else if (Roll_Number[1] == 3)
                        {
                            BottleSound.Play();
                            RollBottle8.Begin();
                            PlayerAsker.Text = Player1.Text;
                            PlayerAsked.Text = Player3.Text;
                            Player_Asker.Text = Player1.Text;
                            Player_asked.Text = Player3.Text;
                            PlayerAnswer.Text = Player3.Text;
                            PlayerAnswered.Text = Player1.Text;
                        }
                        else if (Roll_Number[1] == 4)
                        {
                            BottleSound.Play();
                            RollBottle4.Begin();
                            PlayerAsker.Text = Player3.Text;
                            PlayerAsked.Text = Player1.Text;
                            Player_Asker.Text = Player3.Text;
                            Player_asked.Text = Player1.Text;
                            PlayerAnswer.Text = Player1.Text;
                            PlayerAnswered.Text = Player3.Text;
                        }

                        N_Cliks = Clicks.ThirdClick;
                    }
                    else if (N_Cliks == Clicks.ThirdClick)
                    {
                        if (Roll_Number[2] == 1)
                        {
                            BottleSound.Play();
                            RollBottle2.Begin();
                            PlayerAsker.Text = Player2.Text;
                            PlayerAsked.Text = Player4.Text;
                            Player_Asker.Text = Player2.Text;
                            Player_asked.Text = Player4.Text;
                            PlayerAnswer.Text = Player4.Text;
                            PlayerAnswered.Text = Player2.Text;
                        }
                        else if (Roll_Number[2] == 2)
                        {
                            BottleSound.Play();
                            RollBottle6.Begin();
                            PlayerAsker.Text = Player4.Text;
                            PlayerAsked.Text = Player2.Text;
                            Player_Asker.Text = Player4.Text;
                            Player_asked.Text = Player2.Text;
                            PlayerAnswer.Text = Player2.Text;
                            PlayerAnswered.Text = Player4.Text;
                        }
                        else if (Roll_Number[2] == 3)
                        {
                            BottleSound.Play();
                            RollBottle8.Begin();
                            PlayerAsker.Text = Player1.Text;
                            PlayerAsked.Text = Player3.Text;
                            Player_Asker.Text = Player1.Text;
                            Player_asked.Text = Player3.Text;
                            PlayerAnswer.Text = Player3.Text;
                            PlayerAnswered.Text = Player1.Text;
                        }
                        else if (Roll_Number[2] == 4)
                        {
                            BottleSound.Play();
                            RollBottle4.Begin();
                            PlayerAsker.Text = Player3.Text;
                            PlayerAsked.Text = Player1.Text;
                            Player_Asker.Text = Player3.Text;
                            Player_asked.Text = Player1.Text;
                            PlayerAnswer.Text = Player1.Text;
                            PlayerAnswered.Text = Player3.Text;
                        }

                        N_Cliks = Clicks.FourthClick;
                    }

                    else if (N_Cliks == Clicks.FourthClick)
                    {
                        if (Roll_Number[3] == 1)
                        {
                            BottleSound.Play();
                            RollBottle2.Begin();
                            PlayerAsker.Text = Player2.Text;
                            PlayerAsked.Text = Player4.Text;
                            Player_Asker.Text = Player2.Text;
                            Player_asked.Text = Player4.Text;
                            PlayerAnswer.Text = Player4.Text;
                            PlayerAnswered.Text = Player2.Text;
                        }
                        else if (Roll_Number[3] == 2)
                        {
                            BottleSound.Play();
                            RollBottle6.Begin();
                            PlayerAsker.Text = Player4.Text;
                            PlayerAsked.Text = Player2.Text;
                            Player_Asker.Text = Player4.Text;
                            Player_asked.Text = Player2.Text;
                            PlayerAnswer.Text = Player2.Text;
                            PlayerAnswered.Text = Player4.Text;
                        }
                        else if (Roll_Number[3] == 3)
                        {
                            BottleSound.Play();
                            RollBottle8.Begin();
                            PlayerAsker.Text = Player1.Text;
                            PlayerAsked.Text = Player3.Text;
                            Player_Asker.Text = Player1.Text;
                            Player_asked.Text = Player3.Text;
                            PlayerAnswer.Text = Player3.Text;
                            PlayerAnswered.Text = Player1.Text;
                        }
                        else if (Roll_Number[3] == 4)
                        {
                            BottleSound.Play();
                            RollBottle4.Begin();
                            PlayerAsker.Text = Player3.Text;
                            PlayerAsked.Text = Player1.Text;
                            Player_Asker.Text = Player3.Text;
                            Player_asked.Text = Player1.Text;
                            PlayerAnswer.Text = Player1.Text;
                            PlayerAnswered.Text = Player3.Text;
                        }

                        N_Cliks = Clicks.FifthClick;
                    }

                }

             /////////////////////////////////- Four Players (End) -///////////////////////////////////
                /////////////////////////////////- Six Players (Start) -///////////////////////////////////        
                else if (DataContext == App.ViewModel.Items[2])
                {
                    if (N_Cliks == Clicks.FristClick)
                    {
                        HideAtBegin.Begin();
                        if (Roll_Number[0] == 1)
                        {
                            BottleSound.Play();
                            RollBottle1.Begin();
                            PlayerAsker.Text = Player2.Text;
                            PlayerAsked.Text = Player6.Text;
                            Player_Asker.Text = Player2.Text;
                            Player_asked.Text = Player6.Text;
                            PlayerAnswer.Text = Player6.Text;
                            PlayerAnswered.Text = Player2.Text;
                        }
                        else if (Roll_Number[0] == 2)
                        {
                            BottleSound.Play();
                            RollBottle2.Begin();
                            PlayerAsker.Text = Player6.Text;
                            PlayerAsked.Text = Player3.Text;
                            Player_Asker.Text = Player6.Text;
                            Player_asked.Text = Player3.Text;
                            PlayerAnswer.Text = Player3.Text;
                            PlayerAnswered.Text = Player6.Text;
                        }
                        else if (Roll_Number[0] == 3)
                        {
                            BottleSound.Play();
                            RollBottle3.Begin();
                            PlayerAsker.Text = Player1.Text;
                            PlayerAsked.Text = Player4.Text;
                            Player_Asker.Text = Player1.Text;
                            Player_asked.Text = Player4.Text;
                            PlayerAnswer.Text = Player4.Text;
                            PlayerAnswered.Text = Player1.Text;
                        }
                        else if (Roll_Number[0] == 4)
                        {
                            BottleSound.Play();
                            RollBottle4.Begin();
                            PlayerAsker.Text = Player4.Text;
                            PlayerAsked.Text = Player1.Text;
                            Player_Asker.Text = Player4.Text;
                            Player_asked.Text = Player1.Text;
                            PlayerAnswer.Text = Player1.Text;
                            PlayerAnswered.Text = Player4.Text;
                        }
                        else if (Roll_Number[0] == 5)
                        {
                            BottleSound.Play();
                            RollBottle5.Begin();
                            PlayerAsker.Text = Player5.Text;
                            PlayerAsked.Text = Player2.Text;
                            Player_Asker.Text = Player5.Text;
                            Player_asked.Text = Player2.Text;
                            PlayerAnswer.Text = Player2.Text;
                            PlayerAnswered.Text = Player5.Text;
                        }
                        else if (Roll_Number[0] == 6)
                        {
                            BottleSound.Play();
                            RollBottle5.Begin();
                            PlayerAsker.Text = Player2.Text;
                            PlayerAsked.Text = Player5.Text;
                            Player_Asker.Text = Player2.Text;
                            Player_asked.Text = Player5.Text;
                            PlayerAnswer.Text = Player5.Text;
                            PlayerAnswered.Text = Player2.Text;
                        }

                        N_Cliks = Clicks.SecondClick;
                    }
                    else if (N_Cliks == Clicks.SecondClick)
                    {
                        if (Roll_Number[1] == 1)
                        {
                            BottleSound.Play();
                            RollBottle3.Begin();
                            PlayerAsker.Text = Player3.Text;
                            PlayerAsked.Text = Player6.Text;
                            Player_Asker.Text = Player3.Text;
                            Player_asked.Text = Player6.Text;
                            PlayerAnswer.Text = Player6.Text;
                            PlayerAnswered.Text = Player3.Text;
                        }
                        else if (Roll_Number[1] == 2)
                        {
                            BottleSound.Play();
                            RollBottle7.Begin();
                            PlayerAsker.Text = Player6.Text;
                            PlayerAsked.Text = Player3.Text;
                            Player_Asker.Text = Player6.Text;
                            Player_asked.Text = Player3.Text;
                            PlayerAnswer.Text = Player3.Text;
                            PlayerAnswered.Text = Player6.Text;
                        }
                        else if (Roll_Number[1] == 3)
                        {
                            BottleSound.Play();
                            RollBottle8.Begin();
                            PlayerAsker.Text = Player1.Text;
                            PlayerAsked.Text = Player4.Text;
                            Player_Asker.Text = Player1.Text;
                            Player_asked.Text = Player4.Text;
                            PlayerAnswer.Text = Player4.Text;
                            PlayerAnswered.Text = Player1.Text;
                        }
                        else if (Roll_Number[1] == 4)
                        {
                            BottleSound.Play();
                            RollBottle4.Begin();
                            PlayerAsker.Text = Player4.Text;
                            PlayerAsked.Text = Player1.Text;
                            Player_Asker.Text = Player4.Text;
                            Player_asked.Text = Player1.Text;
                            PlayerAnswer.Text = Player1.Text;
                            PlayerAnswered.Text = Player4.Text;
                        }
                        else if (Roll_Number[1] == 5)
                        {
                            BottleSound.Play();
                            RollBottle1.Begin();
                            PlayerAsker.Text = Player5.Text;
                            PlayerAsked.Text = Player2.Text;
                            Player_Asker.Text = Player5.Text;
                            Player_asked.Text = Player2.Text;
                            PlayerAnswer.Text = Player2.Text;
                            PlayerAnswered.Text = Player5.Text;
                        }
                        else if (Roll_Number[1] == 6)
                        {
                            BottleSound.Play();
                            RollBottle5.Begin();
                            PlayerAsker.Text = Player2.Text;
                            PlayerAsked.Text = Player5.Text;
                            Player_Asker.Text = Player2.Text;
                            Player_asked.Text = Player5.Text;
                            PlayerAnswer.Text = Player5.Text;
                            PlayerAnswered.Text = Player2.Text;
                        }
                        N_Cliks = Clicks.ThirdClick;
                    }

                    else if (N_Cliks == Clicks.ThirdClick)
                    {
                        if (Roll_Number[2] == 1)
                        {
                            BottleSound.Play();
                            RollBottle3.Begin();
                            PlayerAsker.Text = Player3.Text;
                            PlayerAsked.Text = Player6.Text;
                            Player_Asker.Text = Player3.Text;
                            Player_asked.Text = Player6.Text;
                            PlayerAnswer.Text = Player6.Text;
                            PlayerAnswered.Text = Player3.Text;
                        }
                        else if (Roll_Number[2] == 2)
                        {
                            BottleSound.Play();
                            RollBottle7.Begin();
                            PlayerAsker.Text = Player6.Text;
                            PlayerAsked.Text = Player3.Text;
                            Player_Asker.Text = Player6.Text;
                            Player_asked.Text = Player3.Text;
                            PlayerAnswer.Text = Player3.Text;
                            PlayerAnswered.Text = Player6.Text;
                        }
                        else if (Roll_Number[2] == 3)
                        {
                            BottleSound.Play();
                            RollBottle8.Begin();
                            PlayerAsker.Text = Player1.Text;
                            PlayerAsked.Text = Player4.Text;
                            Player_Asker.Text = Player1.Text;
                            Player_asked.Text = Player4.Text;
                            PlayerAnswer.Text = Player4.Text;
                            PlayerAnswered.Text = Player1.Text;
                        }
                        else if (Roll_Number[2] == 4)
                        {
                            BottleSound.Play();
                            RollBottle4.Begin();
                            PlayerAsker.Text = Player4.Text;
                            PlayerAsked.Text = Player1.Text;
                            Player_Asker.Text = Player4.Text;
                            Player_asked.Text = Player1.Text;
                            PlayerAnswer.Text = Player1.Text;
                            PlayerAnswered.Text = Player4.Text;
                        }
                        else if (Roll_Number[2] == 5)
                        {
                            BottleSound.Play();
                            RollBottle1.Begin();
                            PlayerAsker.Text = Player5.Text;
                            PlayerAsked.Text = Player2.Text;
                            Player_Asker.Text = Player5.Text;
                            Player_asked.Text = Player2.Text;
                            PlayerAnswer.Text = Player2.Text;
                            PlayerAnswered.Text = Player5.Text;
                        }
                        else if (Roll_Number[2] == 6)
                        {
                            BottleSound.Play();
                            RollBottle5.Begin();
                            PlayerAsker.Text = Player2.Text;
                            PlayerAsked.Text = Player5.Text;
                            Player_Asker.Text = Player2.Text;
                            Player_asked.Text = Player5.Text;
                            PlayerAnswer.Text = Player5.Text;
                            PlayerAnswered.Text = Player2.Text;
                        }
                        N_Cliks = Clicks.FourthClick;
                    }
                    else if (N_Cliks == Clicks.FourthClick)
                    {
                        if (Roll_Number[3] == 1)
                        {
                            BottleSound.Play();
                            RollBottle3.Begin();
                            PlayerAsker.Text = Player3.Text;
                            PlayerAsked.Text = Player6.Text;
                            Player_Asker.Text = Player3.Text;
                            Player_asked.Text = Player6.Text;
                            PlayerAnswer.Text = Player6.Text;
                            PlayerAnswered.Text = Player3.Text;
                        }
                        else if (Roll_Number[3] == 2)
                        {
                            BottleSound.Play();
                            RollBottle7.Begin();
                            PlayerAsker.Text = Player6.Text;
                            PlayerAsked.Text = Player3.Text;
                            Player_Asker.Text = Player6.Text;
                            Player_asked.Text = Player3.Text;
                            PlayerAnswer.Text = Player3.Text;
                            PlayerAnswered.Text = Player6.Text;
                        }
                        else if (Roll_Number[3] == 3)
                        {
                            BottleSound.Play();
                            RollBottle8.Begin();
                            PlayerAsker.Text = Player1.Text;
                            PlayerAsked.Text = Player4.Text;
                            Player_Asker.Text = Player1.Text;
                            Player_asked.Text = Player4.Text;
                            PlayerAnswer.Text = Player4.Text;
                            PlayerAnswered.Text = Player1.Text;
                        }
                        else if (Roll_Number[3] == 4)
                        {
                            BottleSound.Play();
                            RollBottle4.Begin();
                            PlayerAsker.Text = Player4.Text;
                            PlayerAsked.Text = Player1.Text;
                            Player_Asker.Text = Player4.Text;
                            Player_asked.Text = Player1.Text;
                            PlayerAnswer.Text = Player1.Text;
                            PlayerAnswered.Text = Player4.Text;
                        }
                        else if (Roll_Number[3] == 5)
                        {
                            BottleSound.Play();
                            RollBottle1.Begin();
                            PlayerAsker.Text = Player5.Text;
                            PlayerAsked.Text = Player2.Text;
                            Player_Asker.Text = Player5.Text;
                            Player_asked.Text = Player2.Text;
                            PlayerAnswer.Text = Player2.Text;
                            PlayerAnswered.Text = Player5.Text;
                        }
                        else if (Roll_Number[3] == 6)
                        {
                            BottleSound.Play();
                            RollBottle5.Begin();
                            PlayerAsker.Text = Player2.Text;
                            PlayerAsked.Text = Player5.Text;
                            Player_Asker.Text = Player2.Text;
                            Player_asked.Text = Player5.Text;
                            PlayerAnswer.Text = Player5.Text;
                            PlayerAnswered.Text = Player2.Text;
                        }
                        N_Cliks = Clicks.FifthClick;
                    }
                    else if (N_Cliks == Clicks.FifthClick)
                    {
                        if (Roll_Number[4] == 1)
                        {
                            BottleSound.Play();
                            RollBottle3.Begin();
                            PlayerAsker.Text = Player3.Text;
                            PlayerAsked.Text = Player6.Text;
                            Player_Asker.Text = Player3.Text;
                            Player_asked.Text = Player6.Text;
                            PlayerAnswer.Text = Player6.Text;
                            PlayerAnswered.Text = Player3.Text;
                        }
                        else if (Roll_Number[4] == 2)
                        {
                            BottleSound.Play();
                            RollBottle7.Begin();
                            PlayerAsker.Text = Player6.Text;
                            PlayerAsked.Text = Player3.Text;
                            Player_Asker.Text = Player6.Text;
                            Player_asked.Text = Player3.Text;
                            PlayerAnswer.Text = Player3.Text;
                            PlayerAnswered.Text = Player6.Text;
                        }
                        else if (Roll_Number[4] == 3)
                        {
                            BottleSound.Play();
                            RollBottle8.Begin();
                            PlayerAsker.Text = Player1.Text;
                            PlayerAsked.Text = Player4.Text;
                            Player_Asker.Text = Player1.Text;
                            Player_asked.Text = Player4.Text;
                            PlayerAnswer.Text = Player4.Text;
                            PlayerAnswered.Text = Player1.Text;
                        }
                        else if (Roll_Number[4] == 4)
                        {
                            BottleSound.Play();
                            RollBottle4.Begin();
                            PlayerAsker.Text = Player4.Text;
                            PlayerAsked.Text = Player1.Text;
                            Player_Asker.Text = Player4.Text;
                            Player_asked.Text = Player1.Text;
                            PlayerAnswer.Text = Player1.Text;
                            PlayerAnswered.Text = Player4.Text;
                        }
                        else if (Roll_Number[4] == 5)
                        {
                            BottleSound.Play();
                            RollBottle1.Begin();
                            PlayerAsker.Text = Player5.Text;
                            PlayerAsked.Text = Player2.Text;
                            Player_Asker.Text = Player5.Text;
                            Player_asked.Text = Player2.Text;
                            PlayerAnswer.Text = Player2.Text;
                            PlayerAnswered.Text = Player5.Text;
                        }
                        else if (Roll_Number[4] == 6)
                        {
                            BottleSound.Play();
                            RollBottle5.Begin();
                            PlayerAsker.Text = Player2.Text;
                            PlayerAsked.Text = Player5.Text;
                            Player_Asker.Text = Player2.Text;
                            Player_asked.Text = Player5.Text;
                            PlayerAnswer.Text = Player5.Text;
                            PlayerAnswered.Text = Player2.Text;
                        }
                        N_Cliks = Clicks.SixthClick;
                    }
                    else if (N_Cliks == Clicks.SixthClick)
                    {
                        if (Roll_Number[5] == 1)
                        {
                            BottleSound.Play();
                            RollBottle3.Begin();
                            PlayerAsker.Text = Player3.Text;
                            PlayerAsked.Text = Player6.Text;
                            Player_Asker.Text = Player3.Text;
                            Player_asked.Text = Player6.Text;
                            PlayerAnswer.Text = Player6.Text;
                            PlayerAnswered.Text = Player3.Text;
                        }
                        else if (Roll_Number[5] == 2)
                        {
                            BottleSound.Play();
                            RollBottle7.Begin();
                            PlayerAsker.Text = Player6.Text;
                            PlayerAsked.Text = Player3.Text;
                            Player_Asker.Text = Player6.Text;
                            Player_asked.Text = Player3.Text;
                            PlayerAnswer.Text = Player3.Text;
                            PlayerAnswered.Text = Player6.Text;
                        }
                        else if (Roll_Number[5] == 3)
                        {
                            BottleSound.Play();
                            RollBottle8.Begin();
                            PlayerAsker.Text = Player1.Text;
                            PlayerAsked.Text = Player4.Text;
                            Player_Asker.Text = Player1.Text;
                            Player_asked.Text = Player4.Text;
                            PlayerAnswer.Text = Player4.Text;
                            PlayerAnswered.Text = Player1.Text;
                        }
                        else if (Roll_Number[5] == 4)
                        {
                            BottleSound.Play();
                            RollBottle4.Begin();
                            PlayerAsker.Text = Player4.Text;
                            PlayerAsked.Text = Player1.Text;
                            Player_Asker.Text = Player4.Text;
                            Player_asked.Text = Player1.Text;
                            PlayerAnswer.Text = Player1.Text;
                            PlayerAnswered.Text = Player4.Text;
                        }
                        else if (Roll_Number[5] == 5)
                        {
                            BottleSound.Play();
                            RollBottle1.Begin();
                            PlayerAsker.Text = Player5.Text;
                            PlayerAsked.Text = Player2.Text;
                            Player_Asker.Text = Player5.Text;
                            Player_asked.Text = Player2.Text;
                            PlayerAnswer.Text = Player2.Text;
                            PlayerAnswered.Text = Player5.Text;
                        }
                        else if (Roll_Number[5] == 6)
                        {
                            BottleSound.Play();
                            RollBottle5.Begin();
                            PlayerAsker.Text = Player2.Text;
                            PlayerAsked.Text = Player5.Text;
                            Player_Asker.Text = Player2.Text;
                            Player_asked.Text = Player5.Text;
                            PlayerAnswer.Text = Player5.Text;
                            PlayerAnswered.Text = Player2.Text;
                        }
                        N_Cliks = Clicks.SeventhClick;
                    }
                }
                /////////////////////////////////- Six Players (End) -///////////////////////////////////
                /////////////////////////////////- Eight Players (Start) -///////////////////////////////////
                else
                {
                    if (N_Cliks == Clicks.FristClick)
                    {
                        HideAtBegin.Begin();
                        if (Roll_Number[0] == 1)
                        {
                            BottleSound.Play();
                            RollBottle1.Begin();
                            PlayerAsker.Text = Player6.Text;
                            PlayerAsked.Text = Player2.Text;
                            Player_Asker.Text = Player6.Text;
                            Player_asked.Text = Player2.Text;
                            PlayerAnswer.Text = Player2.Text;
                            PlayerAnswered.Text = Player6.Text;
                        }
                        else if (Roll_Number[0] == 2)
                        {
                            BottleSound.Play();
                            RollBottle2.Begin();
                            PlayerAsker.Text = Player3.Text;
                            PlayerAsked.Text = Player7.Text;
                            Player_Asker.Text = Player3.Text;
                            Player_asked.Text = Player7.Text;
                            PlayerAnswer.Text = Player7.Text;
                            PlayerAnswered.Text = Player3.Text;
                        }
                        else if (Roll_Number[0] == 3)
                        {
                            BottleSound.Play();
                            RollBottle3.Begin();
                            PlayerAsker.Text = Player4.Text;
                            PlayerAsked.Text = Player8.Text;
                            Player_Asker.Text = Player4.Text;
                            Player_asked.Text = Player8.Text;
                            PlayerAnswer.Text = Player8.Text;
                            PlayerAnswered.Text = Player4.Text;
                        }
                        else if (Roll_Number[0] == 4)
                        {
                            BottleSound.Play();
                            RollBottle4.Begin();
                            PlayerAsker.Text = Player5.Text;
                            PlayerAsked.Text = Player1.Text;
                            Player_Asker.Text = Player5.Text;
                            Player_asked.Text = Player1.Text;
                            PlayerAnswer.Text = Player1.Text;
                            PlayerAnswered.Text = Player5.Text;
                        }
                        else if (Roll_Number[0] == 5)
                        {
                            BottleSound.Play();
                            RollBottle5.Begin();
                            PlayerAsker.Text = Player2.Text;
                            PlayerAsked.Text = Player6.Text;
                            Player_Asker.Text = Player2.Text;
                            Player_asked.Text = Player6.Text;
                            PlayerAnswer.Text = Player6.Text;
                            PlayerAnswered.Text = Player2.Text;
                        }
                        else if (Roll_Number[0] == 6)
                        {
                            BottleSound.Play();
                            RollBottle6.Begin();
                            PlayerAsker.Text = Player7.Text;
                            PlayerAsked.Text = Player3.Text;
                            Player_Asker.Text = Player7.Text;
                            Player_asked.Text = Player3.Text;
                            PlayerAnswer.Text = Player3.Text;
                            PlayerAnswered.Text = Player7.Text;
                        }
                        else if (Roll_Number[0] == 7)
                        {
                            BottleSound.Play();
                            RollBottle7.Begin();
                            PlayerAsker.Text = Player8.Text;
                            PlayerAsked.Text = Player4.Text;
                            Player_Asker.Text = Player8.Text;
                            Player_asked.Text = Player4.Text;
                            PlayerAnswer.Text = Player4.Text;
                            PlayerAnswered.Text = Player8.Text;
                        }
                        else if (Roll_Number[0] == 8)
                        {
                            BottleSound.Play();
                            RollBottle8.Begin();
                            PlayerAsker.Text = Player1.Text;
                            PlayerAsked.Text = Player5.Text;
                            Player_Asker.Text = Player1.Text;
                            Player_asked.Text = Player5.Text;
                            PlayerAnswer.Text = Player5.Text;
                            PlayerAnswered.Text = Player1.Text;
                        }

                        N_Cliks = Clicks.SecondClick;
                    }

                    else if (N_Cliks == Clicks.SecondClick)
                    {
                        if (Roll_Number[1] == 1)
                        {
                            BottleSound.Play();
                            RollBottle1.Begin();
                            PlayerAsker.Text = Player6.Text;
                            PlayerAsked.Text = Player2.Text;
                            Player_Asker.Text = Player6.Text;
                            Player_asked.Text = Player2.Text;
                            PlayerAnswer.Text = Player2.Text;
                            PlayerAnswered.Text = Player6.Text;
                        }
                        else if (Roll_Number[1] == 2)
                        {
                            BottleSound.Play();
                            RollBottle2.Begin();
                            PlayerAsker.Text = Player3.Text;
                            PlayerAsked.Text = Player7.Text;
                            Player_Asker.Text = Player3.Text;
                            Player_asked.Text = Player7.Text;
                            PlayerAnswer.Text = Player7.Text;
                            PlayerAnswered.Text = Player3.Text;
                        }
                        else if (Roll_Number[1] == 3)
                        {
                            BottleSound.Play();
                            RollBottle3.Begin();
                            PlayerAsker.Text = Player4.Text;
                            PlayerAsked.Text = Player8.Text;
                            Player_Asker.Text = Player4.Text;
                            Player_asked.Text = Player8.Text;
                            PlayerAnswer.Text = Player8.Text;
                            PlayerAnswered.Text = Player4.Text;
                        }
                        else if (Roll_Number[1] == 4)
                        {
                            BottleSound.Play();
                            RollBottle4.Begin();
                            PlayerAsker.Text = Player5.Text;
                            PlayerAsked.Text = Player1.Text;
                            Player_Asker.Text = Player5.Text;
                            Player_asked.Text = Player1.Text;
                            PlayerAnswer.Text = Player1.Text;
                            PlayerAnswered.Text = Player5.Text;
                        }
                        else if (Roll_Number[1] == 5)
                        {
                            BottleSound.Play();
                            RollBottle5.Begin();
                            PlayerAsker.Text = Player2.Text;
                            PlayerAsked.Text = Player6.Text;
                            Player_Asker.Text = Player2.Text;
                            Player_asked.Text = Player6.Text;
                            PlayerAnswer.Text = Player6.Text;
                            PlayerAnswered.Text = Player2.Text;
                        }
                        else if (Roll_Number[1] == 6)
                        {
                            BottleSound.Play();
                            RollBottle6.Begin();
                            PlayerAsker.Text = Player7.Text;
                            PlayerAsked.Text = Player3.Text;
                            Player_Asker.Text = Player7.Text;
                            Player_asked.Text = Player3.Text;
                            PlayerAnswer.Text = Player3.Text;
                            PlayerAnswered.Text = Player7.Text;
                        }
                        else if (Roll_Number[1] == 7)
                        {
                            BottleSound.Play();
                            RollBottle7.Begin();
                            PlayerAsker.Text = Player8.Text;
                            PlayerAsked.Text = Player4.Text;
                            Player_Asker.Text = Player8.Text;
                            Player_asked.Text = Player4.Text;
                            PlayerAnswer.Text = Player4.Text;
                            PlayerAnswered.Text = Player8.Text;
                        }
                        else if (Roll_Number[1] == 8)
                        {
                            BottleSound.Play();
                            RollBottle8.Begin();
                            PlayerAsker.Text = Player1.Text;
                            PlayerAsked.Text = Player5.Text;
                            Player_Asker.Text = Player1.Text;
                            Player_asked.Text = Player5.Text;
                            PlayerAnswer.Text = Player5.Text;
                            PlayerAnswered.Text = Player1.Text;
                        }

                        N_Cliks = Clicks.ThirdClick;
                    }
                    else if (N_Cliks == Clicks.ThirdClick)
                    {
                        if (Roll_Number[2] == 1)
                        {
                            BottleSound.Play();
                            RollBottle2.Begin();
                            PlayerAsker.Text = Player2.Text;
                            PlayerAsked.Text = Player4.Text;
                            Player_Asker.Text = Player2.Text;
                            Player_asked.Text = Player4.Text;
                            PlayerAnswer.Text = Player4.Text;
                            PlayerAnswered.Text = Player2.Text;
                        }
                        else if (Roll_Number[2] == 2)
                        {
                            BottleSound.Play();
                            RollBottle6.Begin();
                            PlayerAsker.Text = Player4.Text;
                            PlayerAsked.Text = Player2.Text;
                            Player_Asker.Text = Player4.Text;
                            Player_asked.Text = Player2.Text;
                            PlayerAnswer.Text = Player2.Text;
                            PlayerAnswered.Text = Player4.Text;
                        }
                        else if (Roll_Number[2] == 3)
                        {
                            BottleSound.Play();
                            RollBottle8.Begin();
                            PlayerAsker.Text = Player1.Text;
                            PlayerAsked.Text = Player3.Text;
                            Player_Asker.Text = Player1.Text;
                            Player_asked.Text = Player3.Text;
                            PlayerAnswer.Text = Player3.Text;
                            PlayerAnswered.Text = Player1.Text;
                        }
                        else if (Roll_Number[2] == 4)
                        {
                            BottleSound.Play();
                            RollBottle4.Begin();
                            PlayerAsker.Text = Player3.Text;
                            PlayerAsked.Text = Player1.Text;
                            Player_Asker.Text = Player3.Text;
                            Player_asked.Text = Player1.Text;
                            PlayerAnswer.Text = Player1.Text;
                            PlayerAnswered.Text = Player3.Text;
                        }
                        else if (Roll_Number[2] == 5)
                        {
                            BottleSound.Play();
                            RollBottle1.Begin();
                            PlayerAsker.Text = Player6.Text;
                            PlayerAsked.Text = Player2.Text;
                            Player_Asker.Text = Player6.Text;
                            Player_asked.Text = Player2.Text;
                            PlayerAnswer.Text = Player2.Text;
                            PlayerAnswered.Text = Player6.Text;
                        }
                        else if (Roll_Number[2] == 6)
                        {
                            BottleSound.Play();
                            RollBottle5.Begin();
                            PlayerAsker.Text = Player2.Text;
                            PlayerAsked.Text = Player6.Text;
                            Player_Asker.Text = Player2.Text;
                            Player_asked.Text = Player6.Text;
                            PlayerAnswer.Text = Player6.Text;
                            PlayerAnswered.Text = Player2.Text;
                        }
                        else if (Roll_Number[2] == 7)
                        {
                            BottleSound.Play();
                            RollBottle3.Begin();
                            PlayerAsker.Text = Player4.Text;
                            PlayerAsked.Text = Player8.Text;
                            Player_Asker.Text = Player4.Text;
                            Player_asked.Text = Player8.Text;
                            PlayerAnswer.Text = Player8.Text;
                            PlayerAnswered.Text = Player4.Text;
                        }
                        else if (Roll_Number[2] == 8)
                        {
                            BottleSound.Play();
                            RollBottle7.Begin();
                            PlayerAsker.Text = Player8.Text;
                            PlayerAsked.Text = Player4.Text;
                            Player_Asker.Text = Player8.Text;
                            Player_asked.Text = Player4.Text;
                            PlayerAnswer.Text = Player4.Text;
                            PlayerAnswered.Text = Player8.Text;
                        }

                        N_Cliks = Clicks.FourthClick;
                    }

                    else if (N_Cliks == Clicks.FourthClick)
                    {
                        if (Roll_Number[3] == 1)
                        {
                            BottleSound.Play();
                            RollBottle1.Begin();
                            PlayerAsker.Text = Player6.Text;
                            PlayerAsked.Text = Player2.Text;
                            Player_Asker.Text = Player6.Text;
                            Player_asked.Text = Player2.Text;
                            PlayerAnswer.Text = Player2.Text;
                            PlayerAnswered.Text = Player6.Text;
                        }
                        else if (Roll_Number[3] == 2)
                        {
                            BottleSound.Play();
                            RollBottle2.Begin();
                            PlayerAsker.Text = Player3.Text;
                            PlayerAsked.Text = Player7.Text;
                            Player_Asker.Text = Player3.Text;
                            Player_asked.Text = Player7.Text;
                            PlayerAnswer.Text = Player7.Text;
                            PlayerAnswered.Text = Player3.Text;
                        }
                        else if (Roll_Number[3] == 3)
                        {
                            BottleSound.Play();
                            RollBottle3.Begin();
                            PlayerAsker.Text = Player4.Text;
                            PlayerAsked.Text = Player8.Text;
                            Player_Asker.Text = Player4.Text;
                            Player_asked.Text = Player8.Text;
                            PlayerAnswer.Text = Player8.Text;
                            PlayerAnswered.Text = Player4.Text;
                        }
                        else if (Roll_Number[3] == 4)
                        {
                            BottleSound.Play();
                            RollBottle4.Begin();
                            PlayerAsker.Text = Player5.Text;
                            PlayerAsked.Text = Player1.Text;
                            Player_Asker.Text = Player5.Text;
                            Player_asked.Text = Player1.Text;
                            PlayerAnswer.Text = Player1.Text;
                            PlayerAnswered.Text = Player5.Text;
                        }
                        else if (Roll_Number[3] == 5)
                        {
                            BottleSound.Play();
                            RollBottle5.Begin();
                            PlayerAsker.Text = Player2.Text;
                            PlayerAsked.Text = Player6.Text;
                            Player_Asker.Text = Player2.Text;
                            Player_asked.Text = Player6.Text;
                            PlayerAnswer.Text = Player6.Text;
                            PlayerAnswered.Text = Player2.Text;
                        }
                        else if (Roll_Number[3] == 6)
                        {
                            BottleSound.Play();
                            RollBottle6.Begin();
                            PlayerAsker.Text = Player7.Text;
                            PlayerAsked.Text = Player3.Text;
                            Player_Asker.Text = Player7.Text;
                            Player_asked.Text = Player3.Text;
                            PlayerAnswer.Text = Player3.Text;
                            PlayerAnswered.Text = Player7.Text;
                        }
                        else if (Roll_Number[3] == 7)
                        {
                            BottleSound.Play();
                            RollBottle7.Begin();
                            PlayerAsker.Text = Player8.Text;
                            PlayerAsked.Text = Player4.Text;
                            Player_Asker.Text = Player8.Text;
                            Player_asked.Text = Player4.Text;
                            PlayerAnswer.Text = Player4.Text;
                            PlayerAnswered.Text = Player8.Text;
                        }
                        else if (Roll_Number[3] == 8)
                        {
                            BottleSound.Play();
                            RollBottle8.Begin();
                            PlayerAsker.Text = Player1.Text;
                            PlayerAsked.Text = Player5.Text;
                            Player_Asker.Text = Player1.Text;
                            Player_asked.Text = Player5.Text;
                            PlayerAnswer.Text = Player5.Text;
                            PlayerAnswered.Text = Player1.Text;
                        }

                        N_Cliks = Clicks.FifthClick;
                    }
                    else if (N_Cliks == Clicks.FifthClick)
                    {
                        if (Roll_Number[4] == 1)
                        {
                            BottleSound.Play();
                            RollBottle1.Begin();
                            PlayerAsker.Text = Player6.Text;
                            PlayerAsked.Text = Player2.Text;
                            Player_Asker.Text = Player6.Text;
                            Player_asked.Text = Player2.Text;
                            PlayerAnswer.Text = Player2.Text;
                            PlayerAnswered.Text = Player6.Text;
                        }
                        else if (Roll_Number[4] == 2)
                        {
                            BottleSound.Play();
                            RollBottle2.Begin();
                            PlayerAsker.Text = Player3.Text;
                            PlayerAsked.Text = Player7.Text;
                            Player_Asker.Text = Player3.Text;
                            Player_asked.Text = Player7.Text;
                            PlayerAnswer.Text = Player7.Text;
                            PlayerAnswered.Text = Player3.Text;
                        }
                        else if (Roll_Number[4] == 3)
                        {
                            BottleSound.Play();
                            RollBottle3.Begin();
                            PlayerAsker.Text = Player4.Text;
                            PlayerAsked.Text = Player8.Text;
                            Player_Asker.Text = Player4.Text;
                            Player_asked.Text = Player8.Text;
                            PlayerAnswer.Text = Player8.Text;
                            PlayerAnswered.Text = Player4.Text;
                        }
                        else if (Roll_Number[4] == 4)
                        {
                            BottleSound.Play();
                            RollBottle4.Begin();
                            PlayerAsker.Text = Player5.Text;
                            PlayerAsked.Text = Player1.Text;
                            Player_Asker.Text = Player5.Text;
                            Player_asked.Text = Player1.Text;
                            PlayerAnswer.Text = Player1.Text;
                            PlayerAnswered.Text = Player5.Text;
                        }
                        else if (Roll_Number[4] == 5)
                        {
                            BottleSound.Play();
                            RollBottle5.Begin();
                            PlayerAsker.Text = Player2.Text;
                            PlayerAsked.Text = Player6.Text;
                            Player_Asker.Text = Player2.Text;
                            Player_asked.Text = Player6.Text;
                            PlayerAnswer.Text = Player6.Text;
                            PlayerAnswered.Text = Player2.Text;
                        }
                        else if (Roll_Number[4] == 6)
                        {
                            BottleSound.Play();
                            RollBottle6.Begin();
                            PlayerAsker.Text = Player7.Text;
                            PlayerAsked.Text = Player3.Text;
                            Player_Asker.Text = Player7.Text;
                            Player_asked.Text = Player3.Text;
                            PlayerAnswer.Text = Player3.Text;
                            PlayerAnswered.Text = Player7.Text;
                        }
                        else if (Roll_Number[4] == 7)
                        {
                            BottleSound.Play();
                            RollBottle7.Begin();
                            PlayerAsker.Text = Player8.Text;
                            PlayerAsked.Text = Player4.Text;
                            Player_Asker.Text = Player8.Text;
                            Player_asked.Text = Player4.Text;
                            PlayerAnswer.Text = Player4.Text;
                            PlayerAnswered.Text = Player8.Text;
                        }
                        else if (Roll_Number[4] == 8)
                        {
                            BottleSound.Play();
                            RollBottle8.Begin();
                            PlayerAsker.Text = Player1.Text;
                            PlayerAsked.Text = Player5.Text;
                            Player_Asker.Text = Player1.Text;
                            Player_asked.Text = Player5.Text;
                            PlayerAnswer.Text = Player5.Text;
                            PlayerAnswered.Text = Player1.Text;
                        }

                        N_Cliks = Clicks.SixthClick;
                    }
                    else if (N_Cliks == Clicks.SixthClick)
                    {
                        if (Roll_Number[5] == 1)
                        {
                            BottleSound.Play();
                            RollBottle1.Begin();
                            PlayerAsker.Text = Player6.Text;
                            PlayerAsked.Text = Player2.Text;
                            Player_Asker.Text = Player6.Text;
                            Player_asked.Text = Player2.Text;
                            PlayerAnswer.Text = Player2.Text;
                            PlayerAnswered.Text = Player6.Text;
                        }
                        else if (Roll_Number[5] == 2)
                        {
                            BottleSound.Play();
                            RollBottle2.Begin();
                            PlayerAsker.Text = Player3.Text;
                            PlayerAsked.Text = Player7.Text;
                            Player_Asker.Text = Player3.Text;
                            Player_asked.Text = Player7.Text;
                            PlayerAnswer.Text = Player7.Text;
                            PlayerAnswered.Text = Player3.Text;
                        }
                        else if (Roll_Number[5] == 3)
                        {
                            BottleSound.Play();
                            RollBottle3.Begin();
                            PlayerAsker.Text = Player4.Text;
                            PlayerAsked.Text = Player8.Text;
                            Player_Asker.Text = Player4.Text;
                            Player_asked.Text = Player8.Text;
                            PlayerAnswer.Text = Player8.Text;
                            PlayerAnswered.Text = Player4.Text;
                        }
                        else if (Roll_Number[5] == 4)
                        {
                            BottleSound.Play();
                            RollBottle4.Begin();
                            PlayerAsker.Text = Player5.Text;
                            PlayerAsked.Text = Player1.Text;
                            Player_Asker.Text = Player5.Text;
                            Player_asked.Text = Player1.Text;
                            PlayerAnswer.Text = Player1.Text;
                            PlayerAnswered.Text = Player5.Text;
                        }
                        else if (Roll_Number[5] == 5)
                        {
                            BottleSound.Play();
                            RollBottle5.Begin();
                            PlayerAsker.Text = Player2.Text;
                            PlayerAsked.Text = Player6.Text;
                            Player_Asker.Text = Player2.Text;
                            Player_asked.Text = Player6.Text;
                            PlayerAnswer.Text = Player6.Text;
                            PlayerAnswered.Text = Player2.Text;
                        }
                        else if (Roll_Number[5] == 6)
                        {
                            BottleSound.Play();
                            RollBottle6.Begin();
                            PlayerAsker.Text = Player7.Text;
                            PlayerAsked.Text = Player3.Text;
                            Player_Asker.Text = Player7.Text;
                            Player_asked.Text = Player3.Text;
                            PlayerAnswer.Text = Player3.Text;
                            PlayerAnswered.Text = Player7.Text;
                        }
                        else if (Roll_Number[5] == 7)
                        {
                            BottleSound.Play();
                            RollBottle7.Begin();
                            PlayerAsker.Text = Player8.Text;
                            PlayerAsked.Text = Player4.Text;
                            Player_Asker.Text = Player8.Text;
                            Player_asked.Text = Player4.Text;
                            PlayerAnswer.Text = Player4.Text;
                            PlayerAnswered.Text = Player8.Text;
                        }
                        else if (Roll_Number[5] == 8)
                        {
                            BottleSound.Play();
                            RollBottle8.Begin();
                            PlayerAsker.Text = Player1.Text;
                            PlayerAsked.Text = Player5.Text;
                            Player_Asker.Text = Player1.Text;
                            Player_asked.Text = Player5.Text;
                            PlayerAnswer.Text = Player5.Text;
                            PlayerAnswered.Text = Player1.Text;
                        }

                        N_Cliks = Clicks.SeventhClick;
                    }
                    else if (N_Cliks == Clicks.SeventhClick)
                    {
                        if (Roll_Number[6] == 1)
                        {
                            BottleSound.Play();
                            RollBottle1.Begin();
                            PlayerAsker.Text = Player6.Text;
                            PlayerAsked.Text = Player2.Text;
                            Player_Asker.Text = Player6.Text;
                            Player_asked.Text = Player2.Text;
                            PlayerAnswer.Text = Player2.Text;
                            PlayerAnswered.Text = Player6.Text;
                        }
                        else if (Roll_Number[6] == 2)
                        {
                            BottleSound.Play();
                            RollBottle2.Begin();
                            PlayerAsker.Text = Player3.Text;
                            PlayerAsked.Text = Player7.Text;
                            Player_Asker.Text = Player3.Text;
                            Player_asked.Text = Player7.Text;
                            PlayerAnswer.Text = Player7.Text;
                            PlayerAnswered.Text = Player3.Text;
                        }
                        else if (Roll_Number[6] == 3)
                        {
                            BottleSound.Play();
                            RollBottle3.Begin();
                            PlayerAsker.Text = Player4.Text;
                            PlayerAsked.Text = Player8.Text;
                            Player_Asker.Text = Player4.Text;
                            Player_asked.Text = Player8.Text;
                            PlayerAnswer.Text = Player8.Text;
                            PlayerAnswered.Text = Player4.Text;
                        }
                        else if (Roll_Number[6] == 4)
                        {
                            BottleSound.Play();
                            RollBottle4.Begin();
                            PlayerAsker.Text = Player5.Text;
                            PlayerAsked.Text = Player1.Text;
                            Player_Asker.Text = Player5.Text;
                            Player_asked.Text = Player1.Text;
                            PlayerAnswer.Text = Player1.Text;
                            PlayerAnswered.Text = Player5.Text;
                        }
                        else if (Roll_Number[6] == 5)
                        {
                            BottleSound.Play();
                            RollBottle5.Begin();
                            PlayerAsker.Text = Player2.Text;
                            PlayerAsked.Text = Player6.Text;
                            Player_Asker.Text = Player2.Text;
                            Player_asked.Text = Player6.Text;
                            PlayerAnswer.Text = Player6.Text;
                            PlayerAnswered.Text = Player2.Text;
                        }
                        else if (Roll_Number[6] == 6)
                        {
                            BottleSound.Play();
                            RollBottle6.Begin();
                            PlayerAsker.Text = Player7.Text;
                            PlayerAsked.Text = Player3.Text;
                            Player_Asker.Text = Player7.Text;
                            Player_asked.Text = Player3.Text;
                            PlayerAnswer.Text = Player3.Text;
                            PlayerAnswered.Text = Player7.Text;
                        }
                        else if (Roll_Number[6] == 7)
                        {
                            BottleSound.Play();
                            RollBottle7.Begin();
                            PlayerAsker.Text = Player8.Text;
                            PlayerAsked.Text = Player4.Text;
                            Player_Asker.Text = Player8.Text;
                            Player_asked.Text = Player4.Text;
                            PlayerAnswer.Text = Player4.Text;
                            PlayerAnswered.Text = Player8.Text;
                        }
                        else if (Roll_Number[6] == 8)
                        {
                            BottleSound.Play();
                            RollBottle8.Begin();
                            PlayerAsker.Text = Player1.Text;
                            PlayerAsked.Text = Player5.Text;
                            Player_Asker.Text = Player1.Text;
                            Player_asked.Text = Player5.Text;
                            PlayerAnswer.Text = Player5.Text;
                            PlayerAnswered.Text = Player1.Text;
                        }

                        N_Cliks = Clicks.EighthClick;
                    }
                    else if (N_Cliks == Clicks.EighthClick)
                    {
                        if (Roll_Number[7] == 1)
                        {
                            BottleSound.Play();
                            RollBottle1.Begin();
                            PlayerAsker.Text = Player6.Text;
                            PlayerAsked.Text = Player2.Text;
                            Player_Asker.Text = Player6.Text;
                            Player_asked.Text = Player2.Text;
                            PlayerAnswer.Text = Player2.Text;
                            PlayerAnswered.Text = Player6.Text;
                        }
                        else if (Roll_Number[7] == 2)
                        {
                            BottleSound.Play();
                            RollBottle2.Begin();
                            PlayerAsker.Text = Player3.Text;
                            PlayerAsked.Text = Player7.Text;
                            Player_Asker.Text = Player3.Text;
                            Player_asked.Text = Player7.Text;
                            PlayerAnswer.Text = Player7.Text;
                            PlayerAnswered.Text = Player3.Text;
                        }
                        else if (Roll_Number[7] == 3)
                        {
                            BottleSound.Play();
                            RollBottle3.Begin();
                            PlayerAsker.Text = Player4.Text;
                            PlayerAsked.Text = Player8.Text;
                            Player_Asker.Text = Player4.Text;
                            Player_asked.Text = Player8.Text;
                            PlayerAnswer.Text = Player8.Text;
                            PlayerAnswered.Text = Player4.Text;
                        }
                        else if (Roll_Number[7] == 4)
                        {
                            BottleSound.Play();
                            RollBottle4.Begin();
                            PlayerAsker.Text = Player5.Text;
                            PlayerAsked.Text = Player1.Text;
                            Player_Asker.Text = Player5.Text;
                            Player_asked.Text = Player1.Text;
                            PlayerAnswer.Text = Player1.Text;
                            PlayerAnswered.Text = Player5.Text;
                        }
                        else if (Roll_Number[7] == 5)
                        {
                            BottleSound.Play();
                            RollBottle5.Begin();
                            PlayerAsker.Text = Player2.Text;
                            PlayerAsked.Text = Player6.Text;
                            Player_Asker.Text = Player2.Text;
                            Player_asked.Text = Player6.Text;
                            PlayerAnswer.Text = Player6.Text;
                            PlayerAnswered.Text = Player2.Text;
                        }
                        else if (Roll_Number[7] == 6)
                        {
                            BottleSound.Play();
                            RollBottle6.Begin();
                            PlayerAsker.Text = Player7.Text;
                            PlayerAsked.Text = Player3.Text;
                            Player_Asker.Text = Player7.Text;
                            Player_asked.Text = Player3.Text;
                            PlayerAnswer.Text = Player3.Text;
                            PlayerAnswered.Text = Player7.Text;
                        }
                        else if (Roll_Number[7] == 7)
                        {
                            BottleSound.Play();
                            RollBottle7.Begin();
                            PlayerAsker.Text = Player8.Text;
                            PlayerAsked.Text = Player4.Text;
                            Player_Asker.Text = Player8.Text;
                            Player_asked.Text = Player4.Text;
                            PlayerAnswer.Text = Player4.Text;
                            PlayerAnswered.Text = Player8.Text;
                        }
                        else if (Roll_Number[7] == 8)
                        {
                            BottleSound.Play();
                            RollBottle8.Begin();
                            PlayerAsker.Text = Player1.Text;
                            PlayerAsked.Text = Player5.Text;
                            Player_Asker.Text = Player1.Text;
                            Player_asked.Text = Player5.Text;
                            PlayerAnswer.Text = Player5.Text;
                            PlayerAnswered.Text = Player1.Text;
                        }

                        N_Cliks = Clicks.NinthClick;
                    }
                }
                /////////////////////////////////- Eight Players (End) -///////////////////////////////////
                HideAllWindows_Comp = false;
            }
        }
        private void RollBottle1_Completed(object sender, object e)
        {
            ShowToAskWindow.Begin();
            ToAskWindow_Comp = true;
        }
        private void RollBottle2_Completed(object sender, object e)
        {
            ShowToAskWindow.Begin();
            ToAskWindow_Comp = true;
        }
        private void RollBottle3_Completed(object sender, object e)
        {
            ShowToAskWindow.Begin();
            ToAskWindow_Comp = true;
        }
        private void RollBottle4_Completed(object sender, object e)
        {
            ToAskWindow_Comp = true;
            ShowToAskWindow.Begin();
        }
        private void RollBottle5_Completed(object sender, object e)
        {
            ToAskWindow_Comp = true;
            ShowToAskWindow.Begin();
        }
        private void RollBottle6_Completed(object sender, object e)
        {
            ToAskWindow_Comp = true;
            ShowToAskWindow.Begin();
        }
        private void RollBottle7_Completed(object sender, object e)
        {
            ToAskWindow_Comp = true;
            ShowToAskWindow.Begin();
        }
        private void RollBottle8_Completed(object sender, object e)
        {
            ToAskWindow_Comp = true;
            ShowToAskWindow.Begin();
        }

        private void ShowToAskWindow_Completed(object sender, object e)
        {
            if (Player1.Text == PlayerAsked.Text)
            {
                Player1_status.Text = "Answering";
            }
            else if (Player2.Text == PlayerAsked.Text)
            {
                Player2_status.Text = "Answering";
            }
            else if (Player3.Text == PlayerAsked.Text)
            {
                Player3_status.Text = "Answering";
            }
            else if (Player4.Text == PlayerAsked.Text)
            {
                Player4_status.Text = "Answering";
            }
            else if (Player5.Text == PlayerAsked.Text)
            {
                Player5_status.Text = "Answering";
            }
            else if (Player6.Text == PlayerAsked.Text)
            {
                Player6_status.Text = "Answering";
            }
            else if (Player7.Text == PlayerAsked.Text)
            {
                Player7_status.Text = "Answering";
            }
            else if (Player8.Text == PlayerAsked.Text)
            {
                Player8_status.Text = "Answering";
            }
            ShowAskBar.Begin();
            AskTextBox.IsEnabled = true;
            AskButton.IsEnabled = true;
            if (Player1.Text == PlayerAsker.Text)
            {
                Player1_status.Text = "Asking";
            }
            else if (Player2.Text == PlayerAsker.Text)
            {
                Player2_status.Text = "Asking";
            }
            else if (Player3.Text == PlayerAsker.Text)
            {
                Player3_status.Text = "Asking";
            }
            else if (Player4.Text == PlayerAsker.Text)
            {
                Player4_status.Text = "Asking";
            }
            else if (Player5.Text == PlayerAsker.Text)
            {
                Player5_status.Text = "Asking";
            }
            else if (Player6.Text == PlayerAsker.Text)
            {
                Player6_status.Text = "Asking";
            }
            else if (Player7.Text == PlayerAsker.Text)
            {
                Player7_status.Text = "Asking";
            }
            else if (Player8.Text == PlayerAsker.Text)
            {
                Player8_status.Text = "Asking";
            }

        }
        private void AskButton_Click(object sender, RoutedEventArgs e)
        {
            if (!(AskTextBox.Text == "" || AskTextBox.Text == "- Enter Your Question -"))
            {
                AskTextBlock.Text = AskTextBox.Text;
                if (ToAskWindow_Comp == true)
                {
                    HideToAskWindow.Begin();
                    ToAskWindow_Comp = false;
                }
            }
        }
        private void HideToAskWindow_Completed(object sender, object e)
        {
            ShowAskWindow.Begin();
            AskWindow_Comp = true;
        }
        private void ShowAskWindow_Completed(object sender, object e)
        {
            ShowAnswerBar.Begin();
            AnswerTextBox.IsEnabled = true;
            AnswerButton.IsEnabled = true;
        }
        private void AnswerButton_Click(object sender, RoutedEventArgs e)
        {
            if (!(AnswerTextBox.Text == "" || AnswerTextBox.Text == "- Enter Your Answer -"))
            {
                AnswerTextBlock.Text = AnswerTextBox.Text;

                AskTextBlock.Text = AskTextBox.Text;
                if (AskWindow_Comp == true)
                {
                    HideAskWindow.Begin();
                    AskWindow_Comp = false;
                }

            }
        }
        private void HideAskWindow_Completed(object sender, object e)
        {
            ShowAskToPointsWindow.Begin();
        }
        private void ShowAskToPointsWindow_Completed(object sender, object e)
        {
            ShowAsktoPointsBar.Begin();
            DoneButton.IsEnabled = true;
            YesCheckBox.IsEnabled = true;
            NoCheckBox.IsEnabled = true;
        }
        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            if (!(YesCheckBox.IsChecked == NoCheckBox.IsChecked))
            {
                if (YesCheckBox.IsChecked == true)
                {
                    if (Player1.Text == PlayerAsked.Text)
                    {
                        point_1 = true;
                    }
                    else if (Player2.Text == PlayerAsked.Text)
                    {
                        point_2 = true;
                    }
                    else if (Player3.Text == PlayerAsked.Text)
                    {
                        point_3 = true;
                    }
                    else if (Player4.Text == PlayerAsked.Text)
                    {
                        point_4 = true;
                    }
                    else if (Player5.Text == PlayerAsked.Text)
                    {
                        point_5 = true;
                    }
                    else if (Player6.Text == PlayerAsked.Text)
                    {
                        point_6 = true;
                    }
                    else if (Player7.Text == PlayerAsked.Text)
                    {
                        point_7 = true;
                    }
                    else if (Player8.Text == PlayerAsked.Text)
                    {
                        point_8 = true;
                    }
                }
                else if (NoCheckBox.IsChecked == true)
                {
                    if (Player1.Text == PlayerAsked.Text)
                    {
                        point_1 = false;
                    }
                    else if (Player2.Text == PlayerAsked.Text)
                    {
                        point_2 = false;
                    }
                    else if (Player3.Text == PlayerAsked.Text)
                    {
                        point_3 = false;
                    }
                    else if (Player4.Text == PlayerAsked.Text)
                    {
                        point_4 = false;
                    }
                    else if (Player5.Text == PlayerAsked.Text)
                    {
                        point_5 = false;
                    }
                    else if (Player6.Text == PlayerAsked.Text)
                    {
                        point_6 = false;
                    }
                    else if (Player7.Text == PlayerAsked.Text)
                    {
                        point_7 = false;
                    }
                    else if (Player8.Text == PlayerAsked.Text)
                    {
                        point_8 = false;
                    }
                }
                HideAllWindows_Comp = true;
                ToAskWindow_Comp = false;
                HideBottle.Begin();
                HideAskToPointsWindow.Begin();
                HideAskBar.Begin();
                HideAnswerBar.Begin();
                HideAsktoPointsBar.Begin();
                Player1_status.Text = "";
                Player2_status.Text = "";
                Player3_status.Text = "";
                Player4_status.Text = "";
                Player5_status.Text = "";
                Player6_status.Text = "";
                Player7_status.Text = "";
                Player8_status.Text = "";
                if ((DataContext == App.ViewModel.Items[0]) && (N_Cliks == Clicks.ThirdClick))
                {
                    ShowTheEnd.Begin();
                }
                else if ((DataContext == App.ViewModel.Items[1]) && (N_Cliks == Clicks.FifthClick))
                {
                    ShowTheEnd.Begin();
                }
                else if ((DataContext == App.ViewModel.Items[2]) && (N_Cliks == Clicks.SeventhClick))
                {
                    ShowTheEnd.Begin();
                }
                else if ((DataContext == App.ViewModel.Items[3]) && (N_Cliks == Clicks.NinthClick))
                {
                    ShowTheEnd.Begin();
                }

            }


        }
        private void HideAskBar_Completed(object sender, object e)
        {
            AskTextBox.Text = "- Enter Your Question -";
            AnswerTextBox.Text = "- Enter Your Answer -";
            AskTextBox.IsEnabled = false;
            AnswerTextBox.IsEnabled = false;
            AskButton.IsEnabled = false;
            AnswerButton.IsEnabled = false;
            DoneButton.IsEnabled = false;
            YesCheckBox.IsEnabled = false;
            NoCheckBox.IsEnabled = false;
            YesCheckBox.IsChecked = false;
            NoCheckBox.IsChecked = false;
        }

        private void AnswerTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (AnswerTextBox.Text == "- Enter Your Answer -")
            {
                AnswerTextBox.Text = "";
            }
        }

        private void AnswerTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (AnswerTextBox.Text == "")
            {
                AnswerTextBox.Text = "- Enter Your Answer -";
            }
        }

        private void AskTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (AskTextBox.Text == "- Enter Your Question -")
            {
                AskTextBox.Text = "";
            }
        }

        private void AskTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (AskTextBox.Text == "")
            {
                AskTextBox.Text = "- Enter Your Question -";
            }
        }

        public bool ToAskWindow_Comp { get; set; }
        public bool AskWindow_Comp { get; set; }
        public bool HideAllWindows_Comp { get; set; }
        private void RollBottleReset_Completed(object sender, EventArgs e)
        {
            ShowBottle.Begin();
        }
        private void HideBottle_Completed(object sender, EventArgs e)
        {
            RollBottleReset.Begin();
        }
        private void Panorama_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (((Panorama)sender).SelectedIndex)
            {

                case 0: // defines the first PanoramaItem
                    ApplicationBar.IsVisible = true;
                    break;

                case 1: // second one
                    ApplicationBar.IsVisible = false;
                    break;
            }

        }
        private void ShowResult_Click(object sender, RoutedEventArgs e)
        {

            if (Roll_To_Points == Clicks.FristClick)
            {
                switch (point_1)
                {
                    case true:
                        Angel_Player1.Opacity = 1;
                        break;
                    case false:
                        Liar_Player1.Opacity = 1;
                        break;
                }
                switch (point_2)
                {
                    case true:
                        Angel_Player2.Opacity = 1;
                        break;
                    case false:
                        Liar_Player2.Opacity = 1;
                        break;
                }
                switch (point_3)
                {
                    case true:
                        Angel_Player3.Opacity = 1;
                        break;
                    case false:
                        Liar_Player3.Opacity = 1;
                        break;
                }
                switch (point_4)
                {
                    case true:
                        Angel_Player4.Opacity = 1;
                        break;
                    case false:
                        Liar_Player4.Opacity = 1;
                        break;
                }
                switch (point_5)
                {
                    case true:
                        Angel_Player5.Opacity = 1;
                        break;
                    case false:
                        Liar_Player5.Opacity = 1;
                        break;
                }
                switch (point_6)
                {
                    case true:
                        Angel_Player6.Opacity = 1;
                        break;
                    case false:
                        Liar_Player6.Opacity = 1;
                        break;
                }
                switch (point_7)
                {
                    case true:
                        Angel_Player7.Opacity = 1;
                        break;
                    case false:
                        Liar_Player7.Opacity = 1;
                        break;
                }
                switch (point_8)
                {
                    case true:
                        Angel_player8.Opacity = 1;
                        break;
                    case false:
                        Liar_Player8.Opacity = 1;
                        break;
                }
                ShowSlide.Begin();
            }
        }
        private bool point_1 { get; set; }
        public bool point_2 { get; set; }
        public bool point_3 { get; set; }
        public bool point_4 { get; set; }
        public bool point_5 { get; set; }
        public bool point_6 { get; set; }
        public bool point_7 { get; set; }
        public bool point_8 { get; set; }

    }
    public enum Clicks
    {
        FristClick,
        SecondClick,
        ThirdClick,
        FourthClick,
        FifthClick,
        SixthClick,
        SeventhClick,
        EighthClick,
        NinthClick
    }
}