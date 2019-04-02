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
    public sealed partial class MainPage3 : Page
    {
        public static MainPage3 MPage3;
        public static Frame MPage3_Frame;

        public MainPage3()
        {
            this.InitializeComponent();
            MPage3 = this;
            MPage3_Frame = Frame_Main3;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!Frame_Main3.Navigate(typeof(PadPage_New)))
            {
                throw new Exception("Failed to create scenario list");
            }
            Image_btn1.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_main_green.png"));
            Image_btn2.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_my_w.png"));
            Image_btn3.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_voicelist_w.png"));
            Image_btn4.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_notice_w.png"));
        }

        private void Image_btn1_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Image_btn1.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_main_gray.png"));
        }

        private void Image_btn1_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            Image_btn1.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_main_green.png"));
            Image_btn2.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_my_w.png"));
            Image_btn3.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_voicelist_w.png"));
            Image_btn4.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_notice_w.png"));
            Frame_Main3.Navigate(typeof(PadPage_New));
        }

        private void Image_btn1_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            //Image_btn1.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_main_w.png"));
        }

        private void Image_btn2_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Image_btn2.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_my_gray.png"));
        }

        private void Image_btn2_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            Image_btn1.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_main_w.png"));
            Image_btn2.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_my_green.png"));
            Image_btn3.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_voicelist_w.png"));
            Image_btn4.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_notice_w.png"));
            Frame_Main3.Navigate(typeof(MyPage2));
            //Frame_Main3.Navigate(typeof(MyPage2_New));
        }

        private void Image_btn2_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            //Image_btn2.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_my_w.png"));
        }

        private void Image_btn3_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Image_btn3.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_voicelist_gray.png"));
        }

        private void Image_btn3_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            Image_btn1.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_main_w.png"));
            Image_btn2.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_my_w.png"));
            Image_btn3.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_voicelist_green.png"));
            Image_btn4.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_notice_w.png"));
            Frame_Main3.Navigate(typeof(AskingListPage));
        }

        private void Image_btn3_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            //Image_btn3.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_voicelist_w.png"));
        }

        private Binding SetProperty(string imagesource)
        {
            Binding b = new Binding();
            b.Mode = BindingMode.OneTime;
            b.Source = imagesource;
            return b;
        }

        private void Image_btn4_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Image_btn4.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_notice_gray.png"));
        }

        private void Image_btn4_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            Image_btn1.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_main_w.png"));
            Image_btn2.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_my_w.png"));
            Image_btn3.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_voicelist_w.png"));
            Image_btn4.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_notice_green.png"));
            Frame_Main3.Navigate(typeof(NoticePage_Another));
        }

        private void Image_btn4_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            //Image_btn4.SetBinding(Image.SourceProperty, SetProperty("Assets/top_icon_37x37/dis_notice_w.png"));
        }
    }
}
