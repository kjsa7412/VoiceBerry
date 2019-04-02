using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Collections.ObjectModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace voice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MyPage : Page
    {
        public string temp;

        public static Frame F_MyPage;

        public MyPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            F_MyPage = Frame_MyPage;

            if (e.Parameter != null)
            {
                temp = e.Parameter.ToString();
            }
            Frame_MyPage.Navigate(typeof(MyPage_Sub1), temp);
            Initialize_MyPage();
        }

        private void Initialize_MyPage()
        {
            Image_Mypage_Profile.SetBinding(Image.SourceProperty, SetProperty("Assets/profile/profile_jason.png"));
            //Image_Mypage2_Back.SetBinding(Image.SourceProperty, SetProperty("Assets/icon_middle/file_click.png"));

            TBox_Count.SetBinding(TextBlock.TextProperty, SetProperty("1"));
            TBox_Follower.SetBinding(TextBlock.TextProperty, SetProperty("1"));
            TBox_Following.SetBinding(TextBlock.TextProperty, SetProperty("1"));

            TBox_TCount.SetBinding(TextBlock.TextProperty, SetProperty("REQUESTES"));
            TBox_TFollower.SetBinding(TextBlock.TextProperty, SetProperty("FOLLOWERS"));
            TBox_TFollowing.SetBinding(TextBlock.TextProperty, SetProperty("FOLLOWING"));


            TBox_Content.SetBinding(TextBlock.TextProperty, SetProperty("I have a deep voice"));
            TBox_Option.SetBinding(TextBlock.TextProperty, SetProperty("Kyungjin"));
        }

        //private void Image_Follower_PointerPressed(object sender, PointerRoutedEventArgs e)
        //{
        //    Image_Follower.SetBinding(Image.SourceProperty, SetProperty("Assets/gray.jpg"));
        //}

        //private void Image_Follower_PointerReleased(object sender, PointerRoutedEventArgs e)
        //{
        //    Image_Follower.SetBinding(Image.SourceProperty, SetProperty("Assets/brown.jpg"));
        //    //this.Frame.Navigate(typeof(FollowerListPage));
        //}

        //private void Image_Follower_PointerExited(object sender, PointerRoutedEventArgs e)
        //{
        //    Image_Follower.SetBinding(Image.SourceProperty, SetProperty("Assets/brown.jpg"));
        //}

        //private void Image_Following_PointerPressed(object sender, PointerRoutedEventArgs e)
        //{
        //    Image_Following.SetBinding(Image.SourceProperty, SetProperty("Assets/gray.jpg"));
        //}

        //private void Image_Following_PointerReleased(object sender, PointerRoutedEventArgs e)
        //{
        //    Image_Following.SetBinding(Image.SourceProperty, SetProperty("Assets/brown.jpg"));
        //    //this.Frame.Navigate(typeof(FollowingListPage));
        //}

        //private void Image_Following_PointerExited(object sender, PointerRoutedEventArgs e)
        //{
        //    Image_Following.SetBinding(Image.SourceProperty, SetProperty("Assets/brown.jpg"));
        //}
        private void Image_Mypage_btn1_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            //Image_Mypage2_btn1.SetBinding(Image.SourceProperty, SetProperty("Assets/my_tapmenu/my_menu_file.png"));
        }

        private void Image_Mypage_btn1_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            Image_Mypage_btn1.SetBinding(Image.SourceProperty, SetProperty("Assets/MY_middleicon/docu_on.png"));
            Image_Mypage_btn2.SetBinding(Image.SourceProperty, SetProperty("Assets/MY_middleicon/message_off.png"));
            Frame_MyPage.Navigate(typeof(MyPage_Sub1));
        }

        private void Image_Mypage_btn1_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            //Image_Mypage2_btn1.SetBinding(Image.SourceProperty, SetProperty("Assets/brown.jpg"));
        }

        private void Image_Mypage_btn2_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            //Grid_MyPage2_Menu.SetBinding(Image.SourceProperty, SetProperty("Assets/icon_middle/docu_click.png"));
        }

        private void Image_Mypage_btn2_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            Image_Mypage_btn1.SetBinding(Image.SourceProperty, SetProperty("Assets/MY_middleicon/docu_off.png"));
            Image_Mypage_btn2.SetBinding(Image.SourceProperty, SetProperty("Assets/MY_middleicon/message_on.png"));
            //Frame_MyPage2.Navigate(typeof(MyPage_Another_SubPage1));
        }

        private void Image_Mypage_btn2_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            //Image_Mypage2_btn2.SetBinding(Image.SourceProperty, SetProperty("Assets/brown.jpg"));
        }

        //private void Image_Mypage_btn3_PointerExited(object sender, PointerRoutedEventArgs e)
        //{
        //    //Image_Mypage_btn3.SetBinding(Image.SourceProperty, SetProperty("Assets/brown.jpg"));
        //}

        //private void Image_Count_PointerExited(object sender, PointerRoutedEventArgs e)
        //{
        //    Image_Count.SetBinding(Image.SourceProperty, SetProperty("Assets/brown.jpg"));
        //}

        //private void Image_Count_PointerPressed(object sender, PointerRoutedEventArgs e)
        //{
        //    Image_Count.SetBinding(Image.SourceProperty, SetProperty("Assets/gray.jpg"));
        //}

        //private void Image_Count_PointerReleased(object sender, PointerRoutedEventArgs e)
        //{
        //    Image_Count.SetBinding(Image.SourceProperty, SetProperty("Assets/brown.jpg"));
        //}

        //private void Image_Sample_PointerExited(object sender, PointerRoutedEventArgs e)
        //{
        //    Image_Sample.SetBinding(Image.SourceProperty, SetProperty("Assets/my_listen/my_listen.png"));
        //}

        //private void Image_Sample_PointerPressed(object sender, PointerRoutedEventArgs e)
        //{
        //    Image_Sample.SetBinding(Image.SourceProperty, SetProperty("Assets/my_listen/my_listen.png"));
        //}

        //private void Image_Sample_PointerReleased(object sender, PointerRoutedEventArgs e)
        //{
        //    Image_Sample.SetBinding(Image.SourceProperty, SetProperty("Assets/my_listen/my_listen_fill.png"));
        //}

        private Binding SetProperty(string image)
        {
            Binding b = new Binding();
            b.Mode = BindingMode.OneTime;
            b.Source = image;
            return b;
        }
    }
}
