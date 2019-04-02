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
    public sealed partial class ActivityPage : Page
    {
        private int page = 1;
        private int check = 1;

        public ActivityPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Img_Up_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            if(page == 1)
            {
                DoubleAnimation anima = new DoubleAnimation
                {
                    EnableDependentAnimation = true,
                    To = 0,
                    Duration = new Duration(TimeSpan.FromSeconds(1)),
                    //AutoReverse = true
                };

                DoubleAnimation anima2 = new DoubleAnimation
                {
                    EnableDependentAnimation = true,
                    From = 0.0,
                    To = 1.0,
                    Duration = new Duration(TimeSpan.FromSeconds(1)),
                };


                Storyboard.SetTarget(anima, Grid_Page2);
                Storyboard.SetTargetProperty(anima, "(Canvas.Top)");

                Storyboard.SetTarget(anima2, Grid_Page2);
                Storyboard.SetTargetProperty(anima2, "Opacity");

                Storyboard storyboard = new Storyboard();
                storyboard.Children.Add(anima);
                storyboard.Children.Add(anima2);
                storyboard.Begin();
                Move_Airplane(true, check);
                check = 2;
                page = 2;
            }
            else if(page == 2)
            {
                DoubleAnimation anima = new DoubleAnimation
                {
                    EnableDependentAnimation = true,
                    To = 0,
                    Duration = new Duration(TimeSpan.FromSeconds(1)),
                    //AutoReverse = true
                };

                DoubleAnimation anima2 = new DoubleAnimation
                {
                    EnableDependentAnimation = true,
                    From = 0.0,
                    To = 1.0,
                    Duration = new Duration(TimeSpan.FromSeconds(1)),
                };


                Storyboard.SetTarget(anima, Grid_Page3);
                Storyboard.SetTargetProperty(anima, "(Canvas.Top)");

                Storyboard.SetTarget(anima2, Grid_Page3);
                Storyboard.SetTargetProperty(anima2, "Opacity");

                Storyboard storyboard = new Storyboard();
                storyboard.Children.Add(anima);
                storyboard.Children.Add(anima2);
                storyboard.Begin();

                Move_Airplane(false, check);

                page = 3;
            }
            else
            {

            }
           
        }

        private void Img_Down_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            if (page == 3)
            {
                DoubleAnimation anima = new DoubleAnimation
                {
                    EnableDependentAnimation = true,
                    To = 580,
                    Duration = new Duration(TimeSpan.FromSeconds(1)),
                    //AutoReverse = true
                };

                DoubleAnimation anima2 = new DoubleAnimation
                {
                    EnableDependentAnimation = true,
                    From = 1.0,
                    To = 0.0,
                    Duration = new Duration(TimeSpan.FromSeconds(1)),
                };


                Storyboard.SetTarget(anima, Grid_Page3);
                Storyboard.SetTargetProperty(anima, "(Canvas.Top)");

                Storyboard.SetTarget(anima2, Grid_Page3);
                Storyboard.SetTargetProperty(anima2, "Opacity");

                Storyboard storyboard = new Storyboard();
                storyboard.Children.Add(anima);
                storyboard.Children.Add(anima2);
                storyboard.Begin();

                Move_Airplane(true, check);

                page = 2;
            }
            else if (page == 2)
            {
                DoubleAnimation anima = new DoubleAnimation
                {
                    EnableDependentAnimation = true,
                    To = 580,
                    Duration = new Duration(TimeSpan.FromSeconds(1)),
                    //AutoReverse = true
                };

                DoubleAnimation anima2 = new DoubleAnimation
                {
                    EnableDependentAnimation = true,
                    From = 1.0,
                    To = 0.0,
                    Duration = new Duration(TimeSpan.FromSeconds(1)),
                };


                Storyboard.SetTarget(anima, Grid_Page2);
                Storyboard.SetTargetProperty(anima, "(Canvas.Top)");

                Storyboard.SetTarget(anima2, Grid_Page2);
                Storyboard.SetTargetProperty(anima2, "Opacity");

                Storyboard storyboard = new Storyboard();
                storyboard.Children.Add(anima);
                storyboard.Children.Add(anima2);
                storyboard.Begin();
                Move_Airplane(false, check);

                page = 1;
            }
            else
            {

            }
        }
        private void Move_Airplane(bool con, int chk)
        {
            if(con == true)
            {
                if (chk == 1)
                {
                    Move_Left.Begin();
                }
                else
                {
                    Move_Left.Resume();
                }
            }
            else
            {
                Move_Left.Pause();
            }
            //Move_Left.Begin();
            //int left_from = -260;
            //int left_to = 440;

            //int top_from = 19;
            //int top_to = 100;

            //int Scale_from = 1;
            //int Scale_to = -1;

            ////for(int i = 1; i < 6; i++)
            ////{

            //    //if(i == 2)
            //    //{
            //    //    left_from = 400;
            //    //    left_to = -260;

            //    //    top_from = 19;
            //    //    top_to = 100;

            //    //    Scale_from = -1;
            //    //    Scale_to = 1;
            //    //}
            //    //else if(i == 3)
            //    //{
            //    //    left_from = 260;
            //    //    left_to = -440;

            //    //    top_from = 100;
            //    //    top_to = 200;

            //    //    Scale_from = 1;
            //    //    Scale_to = -1;
            //    //}
            //    //else if(i == 4)
            //    //{
            //    //    left_from = -260;
            //    //    left_to = 440;

            //    //    top_from = 200;
            //    //    top_to = 300;

            //    //    Scale_from = -1;
            //    //    Scale_to = 1;
            //    //}
            //    //else if(i == 5)
            //    //{
            //    //    left_from = -260;
            //    //    left_to = 440;

            //    //    top_from = 300;
            //    //    top_to = 400;

            //    //    Scale_from = 1;
            //    //    Scale_to = -1;
            //    //}
            //    DoubleAnimationUsingKeyFrames keyAnima1 = new DoubleAnimationUsingKeyFrames
            //    {
            //        EnableDependentAnimation = true,
            //        KeyFrames = new DoubleKeyFrame(KeyTime(TimeSpan.FromSeconds(7))),

            //    }
            //    DoubleAnimation anima = new DoubleAnimation
            //    {
            //        EnableDependentAnimation = true,
            //        From = -260,
            //        To = 440,
            //        Duration = new Duration((TimeSpan.FromSeconds(7))
         
            //    };
            //    DoubleAnimation anima2 = new DoubleAnimation
            //    {
            //        EnableDependentAnimation = true,
                    
            //        From = 19,
            //        To = 100,
            //        Duration = new Duration(TimeSpan.FromSeconds(0.5)),
            //        BeginTime = TimeSpan.FromSeconds(7)
            //    };

            //    Storyboard.SetTarget(anima, Img_Airplane);
            //    Storyboard.SetTargetProperty(anima, "(Canvas.Left)");

            //    Storyboard.SetTarget(anima2, Img_Airplane);
            //    Storyboard.SetTargetProperty(anima2, "(Canvas.Top)");

            //    Storyboard storyboard = new Storyboard();
            //    storyboard.Children.Add(anima);
            //    storyboard.Children.Add(anima2);
            //    storyboard.Begin();

                //DoubleAnimation anima3 = new DoubleAnimation
                //{
                //    EnableDependentAnimation = true,
                //    From = 440,
                //    To = -260,
                //    Duration = new Duration(TimeSpan.FromSeconds(7)),
                //    BeginTime = TimeSpan.FromSeconds(7.5)
                //};
                //DoubleAnimation anima4 = new DoubleAnimation
                //{
                //    EnableDependentAnimation = true,
                //    From = 100,
                //    To = 200,
                //    Duration = new Duration(TimeSpan.FromSeconds(0.5)),
                //    BeginTime = TimeSpan.FromSeconds(8)
                //};

                //Storyboard.SetTarget(anima3, Img_Airplane);
                //Storyboard.SetTargetProperty(anima3, "(Canvas.Left)");

                //Storyboard.SetTarget(anima4, Img_Airplane);
                //Storyboard.SetTargetProperty(anima4, "(Canvas.Top)");

                //Storyboard storyboard2 = new Storyboard();
                //storyboard.Children.Add(anima3);
                //storyboard.Children.Add(anima4);
                //storyboard2.BeginTime = TimeSpan.FromSeconds(7.5);
                //storyboard2.Begin();



            //}
        }
    }
}
