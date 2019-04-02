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
    public sealed partial class btn5 : Page
    {

        private ObservableCollection<MainList> MStory;

        public btn5()
        {
            this.InitializeComponent();
            MStory = new ObservableCollection<MainList>();
            GView_MainList.ItemClick += GView_MainList_ItemClick;
        }

        private void GView_MainList_ItemClick(object sender, ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Initilize_btn5();


        }

        private void Initilize_btn5()
        {
            string test11 = "0";
            string Gender_Pic;
            for (int i = LocalDatabase.Write_MainTitle.Count - 1; i >= 0; i-- )
            {
                
                if(LocalDatabase.Write_Gender[i].ToString() == "Male")
                {
                    Gender_Pic = "Assets/maidonator_main/main_male_icon.png";
                }
                else
                {
                    Gender_Pic = "Assets/maidonator_main/main_female_icon.png";
                }
                MStory.Add(GenerateItem("Assets/profile/profile_pic.png", "ENGENE", LocalDatabase.Write_Date[i].ToString(), LocalDatabase.Write_Time[i].ToString(), LocalDatabase.Write_MainTitle[i].ToString(), LocalDatabase.Write_Audience[i].ToString(), LocalDatabase.Write_Purpose[i].ToString(), LocalDatabase.Write_Gender[i].ToString(), LocalDatabase.Write_AgeTo[i].ToString() + " ~ " + LocalDatabase.Write_AgeFrom[i].ToString(), Gender_Pic, test11));
                test11 = "3";
            }

            GView_MainList.ItemsSource = MStory;
        }

        private MainList GenerateItem(string img_pic, string tBox_Name, string tBox_Date, string tBox_Time, string tBox_MainTitle, string tBox_Audience, string tBox_Purpose, string tBox_Gender, string tBox_Age, string img_Gender_Pic, string tBox_Count)
        {
            return new MainList {Img_Pic = img_pic, TBox_Name = tBox_Name, TBox_Date = tBox_Date, TBox_Time = tBox_Time, TBox_MainTitle = tBox_MainTitle, TBox_Audience = tBox_Audience, TBox_Purpose = tBox_Purpose, TBox_Gender = tBox_Gender, TBox_Age = tBox_Age, Img_Gender_Pic = img_Gender_Pic, TBox_Count = tBox_Count};
        }
    }
}
