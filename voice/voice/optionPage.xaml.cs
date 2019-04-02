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
    public sealed partial class optionPage : Page
    {
        private ObservableCollection<FollowList> Friend;

        public optionPage()
        {
            this.InitializeComponent();
            Friend = new ObservableCollection<FollowList>();
            GView_FollowList.ItemClick += GView_FollowList_ItemClick;
        }

        private void GView_FollowList_ItemClick(object sender, ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }
     
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //searchBtn.SetBinding(Image.SourceProperty, SetProperty("Assets/blue.jpg"));
            //RBtn_Gender2.IsChecked = true;
            //RBtn_Security.IsChecked = true;
            for (int i = 0; i < LocalDatabase.User_Name.Count; i++)
            {
                Friend.Add(GenerateItem(LocalDatabase.User_Name[i].ToString(),LocalDatabase.User_Pic[i].ToString()));
            }

            GView_FollowList.ItemsSource = Friend;
        }
        //버튼 클릭
        //private void searchBtn_PointerPressed(object sender, PointerRoutedEventArgs e)
        //{
        //    searchBtn.SetBinding(Image.SourceProperty, SetProperty("Assets/gray.jpg"));
        //}

        //private void searchBtn_PointerReleased(object sender, PointerRoutedEventArgs e)
        //{
        //    searchBtn.SetBinding(Image.SourceProperty, SetProperty("Assets/blue.jpg"));
        //   // Frame_Main2.Navigate(typeof(btn5));
        //}

        //private void searchBtn_PointerExited(object sender, PointerRoutedEventArgs e)
        //{
        //    searchBtn.SetBinding(Image.SourceProperty, SetProperty("Assets/blue.jpg"));
        //}

        //이미지 바인딩
        private Binding SetProperty(string imagesource)
        {
            Binding b = new Binding();
            b.Mode = BindingMode.OneTime;
            b.Source = imagesource;
            return b;
        }
        //리스트
        private FollowList GenerateItem(string name, string image)
        {
            return new FollowList {Name = name, Image = image};
        }

        //앱바
        private void CompleteBtn(object sender, RoutedEventArgs e)
        {
            LocalDatabase.Write_MainTitle.Add(LocalDatabase.MainTitle);
 
            for(int i = 0; i < WritePage_Pre.Title.Count; i++)
            {
                LocalDatabase.Write_SubTitle.Add(WritePage_Pre.Title[i].ToString());
                LocalDatabase.Write_SubContent.Add(WritePage_Pre.Content[i].ToString());
            }

            if(Img_Male.IsRightTapEnabled == true)
            {
                LocalDatabase.Write_Gender.Add("Female");
            }
            else
            {
                LocalDatabase.Write_Gender.Add("Male");
            }

            LocalDatabase.Write_AgeTo.Add(TBox_Age_To.Text);
            LocalDatabase.Write_AgeFrom.Add(TBox_Age_From.Text);
            LocalDatabase.Write_Audience.Add(TBox_Audience.Text);
            LocalDatabase.Write_Purpose.Add(TBox_Purpose.Text);
            LocalDatabase.Write_Additional.Add(TBox_Additional.Text);

            if(Img_Public.IsRightTapEnabled == true)
            {
                LocalDatabase.Write_Public.Add("Public");
            }
            else
            {
                LocalDatabase.Write_Public.Add("Private");
            }

            if(Img_AllFriends.IsRightTapEnabled == true)
            {
                LocalDatabase.Write_AllFriends.Add("All");
            }
            else
            {
                LocalDatabase.Write_AllFriends.Add("NotAll");
            }
            LocalDatabase.Write_Date.Add("thursday, March, 12 2015");
            LocalDatabase.Write_Time.Add("01:42 PM");

            LocalDatabase.MainTitle = "";

            for(int i = 0; i < WritePage_Pre.Title.Count; i++)
            {
                LocalDatabase.Imsi_Title.Add(WritePage_Pre.Title[i].ToString());
                LocalDatabase.Imsi_Content.Add(WritePage_Pre.Content[i].ToString());
                LocalDatabase.Imsi_Back.Add("Assets/scriptbox/scriptbox_gray.png");
            }
            WritePage_Pre.Title.Clear();
            WritePage_Pre.Content.Clear();

            this.Frame.Navigate(typeof(MyPage2));
        }

        private void searchBtn_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
			
        }

        private void Img_Male_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            if (Img_Male.IsRightTapEnabled == true)
            {
                Img_Male.SetBinding(Image.SourceProperty, SetProperty("Assets/writePage/circle_green.png"));
                Img_Female.SetBinding(Image.SourceProperty, SetProperty("Assets/writePage/circle_w.png"));
                Img_Male.IsRightTapEnabled = false;
                Img_Female.IsRightTapEnabled = true;
            }
            else
            {
                Img_Male.SetBinding(Image.SourceProperty, SetProperty("Assets/writePage/circle_w.png"));
                Img_Female.SetBinding(Image.SourceProperty, SetProperty("Assets/writePage/circle_green.png"));
                Img_Male.IsRightTapEnabled = true;
                Img_Female.IsRightTapEnabled = false;
            }
        }
           

        private void Img_Public_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            if (Img_Public.IsRightTapEnabled == true)
            {
                Img_Public.SetBinding(Image.SourceProperty, SetProperty("Assets/writePage/circle_green.png"));
                Img_Public.IsRightTapEnabled = false;
            }
            else
            {
                Img_Public.SetBinding(Image.SourceProperty, SetProperty("Assets/writePage/circle_w.png"));
                Img_Public.IsRightTapEnabled = true;
            }
        }

        private void Img_AllFriends_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            if (Img_AllFriends.IsRightTapEnabled == true)
            {
                Img_AllFriends.SetBinding(Image.SourceProperty, SetProperty("Assets/writePage/circle_green.png"));
                Img_AllFriends.IsRightTapEnabled = false;
            }
            else
            {
                Img_AllFriends.SetBinding(Image.SourceProperty, SetProperty("Assets/writePage/circle_w.png"));
                Img_AllFriends.IsRightTapEnabled = true;
            }
        }

        private void Img_Chk_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            if (Img_Chk.IsRightTapEnabled == true)
            {
                Img_Chk.SetBinding(Image.SourceProperty, SetProperty("Assets/writePage/circle_green.png"));
                Img_Chk.IsRightTapEnabled = false;
            }
            else
            {
                Img_Chk.SetBinding(Image.SourceProperty, SetProperty("Assets/writePage/circle_w.png"));
                Img_Chk.IsRightTapEnabled = true;
            }
        }

        private void Img_Chk1_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            if (Img_Chk1.IsRightTapEnabled == true)
            {
                Img_Chk1.SetBinding(Image.SourceProperty, SetProperty("Assets/writePage/circle_green.png"));
                Img_Chk1.IsRightTapEnabled = false;
            }
            else
            {
                Img_Chk1.SetBinding(Image.SourceProperty, SetProperty("Assets/writePage/circle_w.png"));
                Img_Chk1.IsRightTapEnabled = true;
            }
        }
    }
}
