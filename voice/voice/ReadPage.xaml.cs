using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;




// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace voice
{
    
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ReadPage : Page
    {
       // int cnt = 0;
        DispatcherTimer timer = new DispatcherTimer();
        string imageVal;
        int flag = 0;
        private Random random = null;
        int cnt = 1;

        public ReadPage()
        {
            this.InitializeComponent();
           
            
        }
        private void OnTimerTick(object sender, object e)
        {
            random = new Random();
            int type = 0;

            if (cnt < 10)
            {
                type = (int)Math.Floor((double)random.Next(1, 4));
                cnt++;
            }
            else if (cnt > 30)
            {
                type = (int)Math.Floor((double)random.Next(1, 4));
                cnt++;
            }
            else
            {
                type = (int)Math.Floor((double)random.Next(5, 23));
                cnt++;
            }


            if (flag == 1)
            {
               // cnt++;
                switch (type)
                {
                    case 1:
                        imageVal = "Assets/recordPage/1.png";
                        break;
                    case 2:
                        imageVal = "Assets/recordPage/2.png";
                        break;
                    case 3:
                        imageVal = "Assets/recordPage/3.png";
                        break;
                    case 4:
                        imageVal = "Assets/recordPage/4.png";
                        break;
                    case 5:
                        imageVal = "Assets/recordPage/5.png";
                        break;
                    case 6:
                        imageVal = "Assets/recordPage/6.png";
                        break;
                    case 7:
                        imageVal = "Assets/recordPage/7.png";
                        break;
                    case 8:
                        imageVal = "Assets/recordPage/8.png";
                        break;
                    case 9:
                        imageVal = "Assets/recordPage/9.png";
                        break;
                    case 10:
                        imageVal = "Assets/recordPage/10.png";
                        break;
                    case 11:
                        imageVal = "Assets/recordPage/11.png";
                        break;
                    case 12:
                        imageVal = "Assets/recordPage/12.png";
                        break;
                    case 13:
                        imageVal = "Assets/recordPage/13.png";
                        break;
                    case 14:
                        imageVal = "Assets/recordPage/14.png";
                        break;
                    case 15:
                        imageVal = "Assets/recordPage/15.png";
                        break;
                    case 16:
                        imageVal = "Assets/recordPage/16.png";
                        break;
                    case 17:
                        imageVal = "Assets/recordPage/17.png";
                        break;
                    case 18:
                        imageVal = "Assets/recordPage/18.png";
                        break;
                    case 19:
                        imageVal = "Assets/recordPage/19.png";
                        break;
                    case 20:
                        imageVal = "Assets/recordPage/20.png";
                        break;
                    case 21:
                        imageVal = "Assets/recordPage/21.png";
                        break;
                    case 22:
                        imageVal = "Assets/recordPage/22.png";
                        break;
                    case 23:
                        imageVal = "Assets/recordPage/23.png";
                        break;
                    case 24:
                        imageVal = "Assets/recordPage/24.png";
                        break;
                }
                VolumeImage.SetBinding(Image.SourceProperty, SetProperty(imageVal));
            }
            else
            {
               // this.Frame.Navigate(typeof(LoginPage));
               // cnt = 0;
                timer.Stop();
            }
        }
        private Binding SetProperty(string imagesource)
        {
            Binding b = new Binding();
            b.Mode = BindingMode.OneTime;
            b.Source = imagesource;
            return b;
        }
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            VolumeImage.SetBinding(Image.SourceProperty, SetProperty("Assets/recordPage/1.png"));
            timer.Interval = TimeSpan.FromSeconds(0.2);
           // timer.Tick += OnTimerTick;

            //timer.Start();
            
        }
        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
               // System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }


        private void RecordBtn(object sender, RoutedEventArgs e)
        {
             if ((string)recordBtn.Tag == "Record")
             {
                 recordBtn.Icon = new SymbolIcon(Symbol.Stop);             
                 recordBtn.Label = "Stop";
                 recordBtn.Tag = "Stop";
                 timer.Tick += OnTimerTick;

                 timer.Start();
                 flag = 1;               
             }

    
            else
             {
                 recordBtn.Icon = new SymbolIcon(Symbol.Target);
                 recordBtn.Label = "Record";
                 recordBtn.Tag = "Record";
               //  cnt = 0;
              //   timer.Stop();
                 VolumeImage.SetBinding(Image.SourceProperty, SetProperty(""));
                 flag = 0;
             }
            }
        
        
        private void playBtn_clicked(object sender, RoutedEventArgs e)
        {
            if ((string)playBtn.Tag == "Play")
            {
                playBtn.Icon = new SymbolIcon(Symbol.Pause);
                playBtn.Label = "Pause";
                playBtn.Tag = "Pause";
            }


            else
            {
                playBtn.Icon = new SymbolIcon(Symbol.Play);
                playBtn.Label = "Play";
                playBtn.Tag = "Play";
            }

        }

        private void completeBtn_clicked(object sender, RoutedEventArgs e)
        {
            int i = 100;
            //this.Frame.Navigate(typeof(MyPage));
            this.Frame.Navigate(typeof(MyPage),i);
        }
    }
}
