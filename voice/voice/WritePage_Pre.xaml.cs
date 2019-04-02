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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace voice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class WritePage_Pre : Page
    {
        private ObservableCollection<WritePage_Pre_List> WPL;
        private int B_Height = 73, T_Height = 34;
        private int BS_Height, TS_Height;
        private string B_Img = "Assets/writePage/scriptbox_line.png";
        private string B_Img2 = "Assets/writePage/scriptbox_add.png";

        public static List<string> Title = new List<string>();
        public static List<string> Content = new List<string>();

        private Frame FS_MainPage3 = MainPage3.MPage3_Frame;

        public WritePage_Pre()
        {
            this.InitializeComponent();
            WPL = new ObservableCollection<WritePage_Pre_List>();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //Title.Add("a");
            //Title.Add("b");
            //Content.Add("c");
            //Content.Add("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz");
            if(LocalDatabase.MainTitle == null)
            {

            }
            else
            {
                TBox_MainTitle.Text = LocalDatabase.MainTitle;
            }
            Initialize_WritePage_Pre();
        }

        private WritePage_Pre_List GenerateItem(string img_Back, string height_Back, string visible_Content, string text_Title, string text_Content, string height_Content)
        {
            return new WritePage_Pre_List { Img_Back = img_Back, Height_Back = height_Back, Visible_Content = visible_Content, Text_Title = text_Title, Text_Content = text_Content, Height_Content = height_Content };
        }

        private void Initialize_WritePage_Pre()
        {
            for(int i = 0; i <= Title.Count; i++)
            {
                if(Title.Count == i)
                {
                    BS_Height = 62;
                    TS_Height = T_Height;
                    WPL.Add(GenerateItem(B_Img2, BS_Height.ToString(), "Collapsed", "", "", TS_Height.ToString()));
                    GView_WritePage_Pre.ItemsSource = WPL;
                }
                else
                {
                    int temp = Content[i].Length / 50;
                    int temp2 = 15 * temp;
                    BS_Height = 73;
                    TS_Height = T_Height + temp2;

                    WPL.Add(GenerateItem(B_Img, BS_Height.ToString(), "Visible", Title[i].ToString(), Content[i].ToString(), TS_Height.ToString()));
                }
            }
        }

        private void GView_WritePage_Pre_ItemClick(object sender, ItemClickEventArgs e)
        {
            WritePage_Pre_List _item = e.ClickedItem as WritePage_Pre_List;
            WritePage_Pre_List pageParameters = new WritePage_Pre_List();
            pageParameters.Message = _item.Text_Title;
            LocalDatabase.MainTitle = TBox_MainTitle.Text;
            FS_MainPage3.Navigate(typeof(writePage), pageParameters);
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            LocalDatabase.MainTitle = TBox_MainTitle.Text;
            this.Frame.Navigate(typeof(optionPage));
        }
    }
}
