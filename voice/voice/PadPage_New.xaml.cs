using System;
using System.Collections.Generic;
using System.IO;
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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace voice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PadPage_New : Page
    {
        public static MainPage3 MP;
        public static Frame MP3_Frame;
        VoiceListPage_List _pageParameters;
        private string test;

        public PadPage_New()
        {
            this.InitializeComponent();
            MP = MainPage3.MPage3;
            MP3_Frame = MainPage3.MPage3_Frame;
            
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _pageParameters = e.Parameter as VoiceListPage_List;
            if (_pageParameters != null)
            {
                if (_pageParameters.Message == "")
                {
                    test = "";
                }
                else
                {
                    test = _pageParameters.Message;
                }
            }
            Initilize_PadPage_New();
        }

        private void Initilize_PadPage_New()
        {
            if(LocalDatabase.Pad_Title[0].ToString() == test)
            {
                    Img_back1.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    Img_back2.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    Img_back3.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    Img_back4.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    Img_back4.SetBinding(Image.SourceProperty, SetProperty("Assets/pad/pad_add.png"));

                    Num1_Bar1.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    Num1_Bar2.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    Num1_Bar3.Visibility = Windows.UI.Xaml.Visibility.Visible;                

                    Img_Object1.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    Img_Object2.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    Img_Object3.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    
                    TBox_Num1.Visibility =  Windows.UI.Xaml.Visibility.Visible;
                    TBox_Num2.Visibility =  Windows.UI.Xaml.Visibility.Visible;
                    TBox_Num3.Visibility =  Windows.UI.Xaml.Visibility.Visible;
                    TBox_Num1.Text = "1";
                    TBox_Num2.Text = "2";
                    TBox_Num3.Text = "3";

                    TBox_Time1.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    TBox_Time2.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    TBox_Time3.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    TBox_Time1.Text = LocalDatabase.Pad_Sub_Time[0].ToString();
                    TBox_Time2.Text = LocalDatabase.Pad_Sub_Time[1].ToString();
                    TBox_Time3.Text = LocalDatabase.Pad_Sub_Time[2].ToString();

                    TBox_Voice1.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    TBox_Voice2.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    TBox_Voice3.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    TBox_Voice1.Text = LocalDatabase.Pad_Sub_Title[0].ToString();
                    TBox_Voice2.Text = LocalDatabase.Pad_Sub_Title[1].ToString();
                    TBox_Voice3.Text = LocalDatabase.Pad_Sub_Title[2].ToString();
            }
            else if(LocalDatabase.Pad_Title[1].ToString() == test)
            {
                Img_back1.Visibility = Windows.UI.Xaml.Visibility.Visible;
                Img_back2.Visibility = Windows.UI.Xaml.Visibility.Visible;
                Img_back3.Visibility = Windows.UI.Xaml.Visibility.Visible;
                Img_back4.Visibility = Windows.UI.Xaml.Visibility.Visible;
                Img_back4.SetBinding(Image.SourceProperty, SetProperty("Assets/pad/pad_add.png"));

                TBox_Num1.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TBox_Num2.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TBox_Num3.Visibility = Windows.UI.Xaml.Visibility.Visible;
                Num1_Bar1.Visibility = Windows.UI.Xaml.Visibility.Visible;
                Num1_Bar2.Visibility = Windows.UI.Xaml.Visibility.Visible;
                Num1_Bar3.Visibility = Windows.UI.Xaml.Visibility.Visible;

                Img_Object1.Visibility = Windows.UI.Xaml.Visibility.Visible;
                Img_Object2.Visibility = Windows.UI.Xaml.Visibility.Visible;
                Img_Object3.Visibility = Windows.UI.Xaml.Visibility.Visible;

                TBox_Num1.Text = "1";
                TBox_Num2.Text = "2";
                TBox_Num3.Text = "3";

                TBox_Time1.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TBox_Time2.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TBox_Time3.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TBox_Time1.Text = LocalDatabase.Pad_Sub_Time[3].ToString();
                TBox_Time2.Text = LocalDatabase.Pad_Sub_Time[4].ToString();
                TBox_Time3.Text = LocalDatabase.Pad_Sub_Time[5].ToString();

                TBox_Voice1.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TBox_Voice2.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TBox_Voice3.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TBox_Voice1.Text = LocalDatabase.Pad_Sub_Title[3].ToString();
                TBox_Voice2.Text = LocalDatabase.Pad_Sub_Title[4].ToString();
                TBox_Voice3.Text = LocalDatabase.Pad_Sub_Title[5].ToString();
            }
            else if(test == null)
            {
                Img_back1.Visibility = Windows.UI.Xaml.Visibility.Visible;
                Img_back1.SetBinding(Image.SourceProperty, SetProperty("Assets/pad/pad_add.png"));
            }
            else
            {

            }
            Frame_PadPage.Navigate(typeof(SpeechPage_Sub1), _pageParameters);
        }

        private void Image_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            DoubleAnimation anima = new DoubleAnimation
            {
                EnableDependentAnimation = true,
                From = 1,
                To = 27,
                Duration = new Duration(TimeSpan.FromSeconds(10)),
                //AutoReverse = true
            };
            Storyboard.SetTarget(anima, Scale);
            Storyboard.SetTargetProperty(anima, "ScaleX");

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(anima);
            storyboard.Begin();
        }

        private void Image_PointerReleased_1(object sender, PointerRoutedEventArgs e)
        {
            DoubleAnimation anima = new DoubleAnimation
            {
                EnableDependentAnimation = true,
                From = 1,
                To = 27,
                Duration = new Duration(TimeSpan.FromSeconds(10)),
                //AutoReverse = true
            };
            Storyboard.SetTarget(anima, Scale1);
            Storyboard.SetTargetProperty(anima, "ScaleX");

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(anima);
            storyboard.Begin();
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            if (Grid_Menu1.IsRightTapEnabled == true)
            {
                DoubleAnimation anima = new DoubleAnimation
                {
                    EnableDependentAnimation = true,
                    To = 0,
                    Duration = new Duration(TimeSpan.FromSeconds(0.2)),
                };

                DoubleAnimation anima2 = new DoubleAnimation
                {
                    EnableDependentAnimation = true,
                    From = 0.0,
                    To = 1.0,
                    Duration = new Duration(TimeSpan.FromSeconds(0.2)),
                };

                Storyboard.SetTarget(anima, Grid_Menu1);
                Storyboard.SetTargetProperty(anima, "(Canvas.Left)");

                Storyboard.SetTarget(anima2, Grid_Menu1);
                Storyboard.SetTargetProperty(anima2, "Opacity");

                Storyboard storyboard = new Storyboard();
                storyboard.Children.Add(anima);
                storyboard.Children.Add(anima2);
                storyboard.Begin();

                Grid_Menu1.IsRightTapEnabled = false;

            }
            else
            {
                DoubleAnimation anima = new DoubleAnimation
                {
                    EnableDependentAnimation = true,
                    To = 400,
                    Duration = new Duration(TimeSpan.FromSeconds(0.2)),
                };

                DoubleAnimation anima2 = new DoubleAnimation
                {
                    EnableDependentAnimation = true,
                    From = 1.0,
                    To = 0.0,
                    Duration = new Duration(TimeSpan.FromSeconds(0.2)),
                };

                Storyboard.SetTarget(anima, Grid_Menu1);
                Storyboard.SetTargetProperty(anima, "(Canvas.Left)");

                Storyboard.SetTarget(anima2, Grid_Menu1);
                Storyboard.SetTargetProperty(anima2, "Opacity");

                Storyboard storyboard = new Storyboard();
                storyboard.Children.Add(anima);
                storyboard.Children.Add(anima2);
                storyboard.Begin();

                Grid_Menu1.IsRightTapEnabled = true;
            }
        }

        private void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (Grid_Menu2.IsRightTapEnabled == true)
            {
                DoubleAnimation anima = new DoubleAnimation
                {
                    EnableDependentAnimation = true,
                    To = 0,
                    Duration = new Duration(TimeSpan.FromSeconds(0.2)),
                };

                DoubleAnimation anima2 = new DoubleAnimation
                {
                    EnableDependentAnimation = true,
                    From = 0.0,
                    To = 1.0,
                    Duration = new Duration(TimeSpan.FromSeconds(0.2)),
                };

                Storyboard.SetTarget(anima, Grid_Menu2);
                Storyboard.SetTargetProperty(anima, "(Canvas.Left)");

                Storyboard.SetTarget(anima2, Grid_Menu2);
                Storyboard.SetTargetProperty(anima2, "Opacity");

                Storyboard storyboard = new Storyboard();
                storyboard.Children.Add(anima);
                storyboard.Children.Add(anima2);
                storyboard.Begin();

                Grid_Menu2.IsRightTapEnabled = false;

            }
            else
            {
                DoubleAnimation anima = new DoubleAnimation
                {
                    EnableDependentAnimation = true,
                    To = 400,
                    Duration = new Duration(TimeSpan.FromSeconds(0.2)),
                };

                DoubleAnimation anima2 = new DoubleAnimation
                {
                    EnableDependentAnimation = true,
                    From = 1.0,
                    To = 0.0,
                    Duration = new Duration(TimeSpan.FromSeconds(0.2)),
                };

                Storyboard.SetTarget(anima, Grid_Menu2);
                Storyboard.SetTargetProperty(anima, "(Canvas.Left)");

                Storyboard.SetTarget(anima2, Grid_Menu2);
                Storyboard.SetTargetProperty(anima2, "Opacity");

                Storyboard storyboard = new Storyboard();
                storyboard.Children.Add(anima);
                storyboard.Children.Add(anima2);
                storyboard.Begin();

                Grid_Menu2.IsRightTapEnabled = true;
            }
        }

        private void AppBarButton_Click_2(object sender, RoutedEventArgs e)
        {
            MP3_Frame.Navigate(typeof(VoiceListPage));
        }

        private Binding SetProperty(string imagesource)
        {
            Binding b = new Binding();
            b.Mode = BindingMode.OneTime;
            b.Source = imagesource;
            return b;
        }

        private void Img_back3_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            DoubleAnimation anima = new DoubleAnimation
            {
                EnableDependentAnimation = true,
                From = 1,
                To = 27,
                Duration = new Duration(TimeSpan.FromSeconds(10)),
                //AutoReverse = true
            };
            Storyboard.SetTarget(anima, Scale2);
            Storyboard.SetTargetProperty(anima, "ScaleX");

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(anima);
            storyboard.Begin();
        }

        private void Img_back4_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            DoubleAnimation anima = new DoubleAnimation
            {
                EnableDependentAnimation = true,
                From = 1,
                To = 27,
                Duration = new Duration(TimeSpan.FromMinutes(2)),
                //AutoReverse = true
            };
            Storyboard.SetTarget(anima, Scale3);
            Storyboard.SetTargetProperty(anima, "ScaleX");

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(anima);
            storyboard.Begin();
        }

        private void Img_back5_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            DoubleAnimation anima = new DoubleAnimation
            {
                EnableDependentAnimation = true,
                From = 1,
                To = 27,
                Duration = new Duration(TimeSpan.FromMinutes(7)),
                //AutoReverse = true
            };
            Storyboard.SetTarget(anima, Scale4);
            Storyboard.SetTargetProperty(anima, "ScaleX");

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(anima);
            storyboard.Begin();
        }

        private void Img_back6_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            DoubleAnimation anima = new DoubleAnimation
            {
                EnableDependentAnimation = true,
                From = 1,
                To = 27,
                Duration = new Duration(TimeSpan.FromSeconds(10)),
                //AutoReverse = true
            };
            Storyboard.SetTarget(anima, Scale5);
            Storyboard.SetTargetProperty(anima, "ScaleX");

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(anima);
            storyboard.Begin();
        }

        private void Img_back7_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            DoubleAnimation anima = new DoubleAnimation
            {
                EnableDependentAnimation = true,
                From = 1,
                To = 27,
                Duration = new Duration(TimeSpan.FromSeconds(10)),
                //AutoReverse = true
            };
            Storyboard.SetTarget(anima, Scale6);
            Storyboard.SetTargetProperty(anima, "ScaleX");

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(anima);
            storyboard.Begin();
        }

        private void Img_Object3_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            DoubleAnimation anima = new DoubleAnimation
            {
                EnableDependentAnimation = true,
                From = 1,
                To = 27,
                Duration = new Duration(TimeSpan.FromSeconds(10)),
                //AutoReverse = true
            };
            Storyboard.SetTarget(anima, Scale2);
            Storyboard.SetTargetProperty(anima, "ScaleX");

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(anima);
            storyboard.Begin();
        }

        private void Img_Object4_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            DoubleAnimation anima = new DoubleAnimation
            {
                EnableDependentAnimation = true,
                From = 1,
                To = 27,
                Duration = new Duration(TimeSpan.FromSeconds(10)),
                //AutoReverse = true
            };
            Storyboard.SetTarget(anima, Scale3);
            Storyboard.SetTargetProperty(anima, "ScaleX");

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(anima);
            storyboard.Begin();
        }

        private void Img_Object5_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            DoubleAnimation anima = new DoubleAnimation
            {
                EnableDependentAnimation = true,
                From = 1,
                To = 27,
                Duration = new Duration(TimeSpan.FromSeconds(10)),
                //AutoReverse = true
            };
            Storyboard.SetTarget(anima, Scale4);
            Storyboard.SetTargetProperty(anima, "ScaleX");

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(anima);
            storyboard.Begin();
        }

        private void Img_Object6_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            DoubleAnimation anima = new DoubleAnimation
            {
                EnableDependentAnimation = true,
                From = 1,
                To = 27,
                Duration = new Duration(TimeSpan.FromSeconds(10)),
                //AutoReverse = true
            };
            Storyboard.SetTarget(anima, Scale5);
            Storyboard.SetTargetProperty(anima, "ScaleX");

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(anima);
            storyboard.Begin();
        }

        private void Img_Object7_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            DoubleAnimation anima = new DoubleAnimation
            {
                EnableDependentAnimation = true,
                From = 1,
                To = 27,
                Duration = new Duration(TimeSpan.FromSeconds(10)),
                //AutoReverse = true
            };
            Storyboard.SetTarget(anima, Scale6);
            Storyboard.SetTargetProperty(anima, "ScaleX");

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(anima);
            storyboard.Begin();
        }

        private void Img_Object8_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            DoubleAnimation anima = new DoubleAnimation
            {
                EnableDependentAnimation = true,
                From = 1,
                To = 27,
                Duration = new Duration(TimeSpan.FromSeconds(10)),
                //AutoReverse = true
            };
            Storyboard.SetTarget(anima, Scale7);
            Storyboard.SetTargetProperty(anima, "ScaleX");

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(anima);
            storyboard.Begin();
        }

        private void Img_Object9_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            DoubleAnimation anima = new DoubleAnimation
            {
                EnableDependentAnimation = true,
                From = 1,
                To = 27,
                Duration = new Duration(TimeSpan.FromSeconds(10)),
                //AutoReverse = true
            };
            Storyboard.SetTarget(anima, Scale8);
            Storyboard.SetTargetProperty(anima, "ScaleX");

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(anima);
            storyboard.Begin();
        }

        private void Img_Object10_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            DoubleAnimation anima = new DoubleAnimation
            {
                EnableDependentAnimation = true,
                From = 1,
                To = 27,
                Duration = new Duration(TimeSpan.FromSeconds(10)),
                //AutoReverse = true
            };
            Storyboard.SetTarget(anima, Scale9);
            Storyboard.SetTargetProperty(anima, "ScaleX");

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(anima);
            storyboard.Begin();
        }

        private void Img_Object11_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            DoubleAnimation anima = new DoubleAnimation
            {
                EnableDependentAnimation = true,
                From = 1,
                To = 27,
                Duration = new Duration(TimeSpan.FromSeconds(10)),
                //AutoReverse = true
            };
            Storyboard.SetTarget(anima, Scale10);
            Storyboard.SetTargetProperty(anima, "ScaleX");

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(anima);
            storyboard.Begin();
        }

        private void Img_Object12_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            DoubleAnimation anima = new DoubleAnimation
            {
                EnableDependentAnimation = true,
                From = 1,
                To = 27,
                Duration = new Duration(TimeSpan.FromSeconds(10)),
                //AutoReverse = true
            };
            Storyboard.SetTarget(anima, Scale11);
            Storyboard.SetTargetProperty(anima, "ScaleX");

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(anima);
            storyboard.Begin();
        }

    }
}
