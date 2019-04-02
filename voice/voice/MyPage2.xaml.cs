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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace voice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MyPage2 : Page
    {
        public static MyPage2 M_MyPage2;
        public static Frame F_MyPage2;
        //private string test = "13";
        public MyPage2()
        {
            this.InitializeComponent();
            M_MyPage2 = this;
            F_MyPage2 = Frame_MyPage2;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Frame_MyPage2.Navigate(typeof(MyPage_Another_SubPage1));
            Initialize_MyPage2();
        }

        private void Image_Mypage_btn1_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            //Image_Mypage2_btn1.SetBinding(Image.SourceProperty, SetProperty("Assets/my_tapmenu/my_menu_file.png"));
        }

        private void Image_Mypage_btn1_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            Image_Mypage2_btn1.SetBinding(Image.SourceProperty, SetProperty("Assets/MY_middleicon/file_on.png"));
            Image_Mypage2_btn2.SetBinding(Image.SourceProperty, SetProperty("Assets/MY_middleicon/message_off.png"));
            Frame_MyPage2.Navigate(typeof(MyPage_Another_SubPage1));
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
            Image_Mypage2_btn1.SetBinding(Image.SourceProperty, SetProperty("Assets/MY_middleicon/file_off.png"));
            Image_Mypage2_btn2.SetBinding(Image.SourceProperty, SetProperty("Assets/MY_middleicon/message_on.png"));
            //Frame_MyPage2.Navigate(typeof(MyPage_Another_SubPage1));
        }

        private void Image_Mypage_btn2_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            //Image_Mypage2_btn2.SetBinding(Image.SourceProperty, SetProperty("Assets/brown.jpg"));
        }

        private void Image_Mypage_btn3_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            //Image_Mypage2_btn3.SetBinding(Image.SourceProperty, SetProperty("Assets/my_tapmenu/my_menu_message.png"));
        }

        private void Image_Mypage_btn3_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            //Image_Mypage2_Back.SetBinding(Image.SourceProperty, SetProperty("Assets/icon_middle/ms_click.png"));

        }

        private void Image_Mypage_btn3_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            //Image_Mypage2_btn3.SetBinding(Image.SourceProperty, SetProperty("Assets/brown.jpg"));
        }



        private Binding SetProperty(string image)
        {
            Binding b = new Binding();
            b.Mode = BindingMode.OneTime;
            b.Source = image;
            return b;
        }

        private void Initialize_MyPage2()
        {

            Image_Mypage2_Profile.SetBinding(Image.SourceProperty, SetProperty("Assets/profile/profile_gil.png"));
            //Image_Mypage2_Back.SetBinding(Image.SourceProperty, SetProperty("Assets/icon_middle/file_click.png"));

            TBox_Count.SetBinding(TextBlock.TextProperty, SetProperty("2"));
            TBox_Follower.SetBinding(TextBlock.TextProperty, SetProperty("2"));
            TBox_Following.SetBinding(TextBlock.TextProperty, SetProperty("2"));

            TBox_TCount.SetBinding(TextBlock.TextProperty, SetProperty("REQUESTES"));
            TBox_TFollower.SetBinding(TextBlock.TextProperty, SetProperty("FOLLOWERS"));
            TBox_TFollowing.SetBinding(TextBlock.TextProperty, SetProperty("FOLLOWING"));


            TBox_Content.SetBinding(TextBlock.TextProperty, SetProperty("Looking for an attractive voice!! :)"));
            TBox_Option.SetBinding(TextBlock.TextProperty, SetProperty("Seungmoo"));
        }
    }
}
