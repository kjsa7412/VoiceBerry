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
    public sealed partial class MyPage_Sub1 : Page
    {
        private ObservableCollection<MainList> MPList;
        public string temp = null;
        VoiceListPage_List _pageParameters;

        private Frame FS_MyPage;

        public MyPage_Sub1()
        {
            this.InitializeComponent();
            FS_MyPage = MainPage2.MainPage2Frame;
            MPList = new ObservableCollection<MainList>();
            //GView_MainList.ItemClick += GView_MyPageList_ItemClick;
        }

        private void GView_MyPageList_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainPage2.MainPage2Frame.Navigate(typeof(ReadPage));
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Initialize_MyPage_Sub1();
        }

        private void Initialize_MyPage_Sub1()
        {
            string Gender_Pic;
            //for (int i = LocalDatabase.Write_MainTitle.Count - 1; i >= 0; i--)
            //{
            int i = LocalDatabase.Write_MainTitle.Count - 1;
                if (LocalDatabase.Write_Gender[i].ToString() == "Male")
                {
                    Gender_Pic = "Assets/maidonator_main/main_male_icon.png";
                }
                else
                {
                    Gender_Pic = "Assets/maidonator_main/main_female_icon.png";
                }
                MPList.Add(GenerateItem("Assets/profile/profile_pic.png", "ENGENE", LocalDatabase.Write_Date[i].ToString(), LocalDatabase.Write_Time[i].ToString(), LocalDatabase.Write_MainTitle[i].ToString(), LocalDatabase.Write_Audience[i].ToString(), LocalDatabase.Write_Purpose[i].ToString(), LocalDatabase.Write_Gender[i].ToString(), LocalDatabase.Write_AgeTo[i].ToString() + " ~ " + LocalDatabase.Write_AgeFrom[i].ToString(), Gender_Pic, "0"));
            //}

            GView_MainList.ItemsSource = MPList;
        }

        private MainList GenerateItem(string img_pic, string tBox_Name, string tBox_Date, string tBox_Time, string tBox_MainTitle, string tBox_Audience, string tBox_Purpose, string tBox_Gender, string tBox_Age, string img_Gender_Pic, string tBox_Count)
        {
            return new MainList { Img_Pic = img_pic, TBox_Name = tBox_Name, TBox_Date = tBox_Date, TBox_Time = tBox_Time, TBox_MainTitle = tBox_MainTitle, TBox_Audience = tBox_Audience, TBox_Purpose = tBox_Purpose, TBox_Gender = tBox_Gender, TBox_Age = tBox_Age, Img_Gender_Pic = img_Gender_Pic, TBox_Count = tBox_Count };
        }



        private void GView_MainList_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            FS_MyPage.Navigate(typeof(RecodePage), LocalDatabase.Write_MainTitle[LocalDatabase.Write_MainTitle.Count - 1].ToString());
        }



        //private void GView_MyPageList_ItemClick_1(object sender, ItemClickEventArgs e)
        //{
        //    this.Frame.Navigate(typeof(ReadPage));
        //}
    }
}
