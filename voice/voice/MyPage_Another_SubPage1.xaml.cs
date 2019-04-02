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
    public sealed partial class MyPage_Another_SubPage1 : Page
    {
        private ObservableCollection<MyPage_Another_SubPage1_List> MAS1L;
        private MyPage2 MS_MyPage2;
        private Frame FS_MyPage2;
        private Frame FS_MainPage3;
        MyPage_Another_SubPage1_List _pageParameters;


        List<string> back_folder = new List<string>();
        List<string> img_folder = new List<string>();
        List<string> more_folder = new List<string>();
        List<string> plus_folder = new List<string>();
        List<string> name = new List<string>();
        List<string> height = new List<string>();
        List<string> margin = new List<string>();



        private string test = "a";
        private string test1 = "b";

        public MyPage_Another_SubPage1()
        {
            this.InitializeComponent();
            MAS1L = new ObservableCollection<MyPage_Another_SubPage1_List>();
            MS_MyPage2 = MyPage2.M_MyPage2;
            FS_MyPage2 = MyPage2.F_MyPage2;
            FS_MainPage3 = MainPage3.MPage3_Frame;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _pageParameters = e.Parameter as MyPage_Another_SubPage1_List;
            if (_pageParameters != null)
            {
                if (_pageParameters.Message == "")
                {
                    test = "Plus";
                }
                else
                {
                    test = _pageParameters.Message;
                }
                
            }
            Initialize_MyPage_Another_SubPage1();

        }

        private MyPage_Another_SubPage1_List GenerateItem(string back_Source, string img_Source, string img_Source2, string img_Source3, string name, string move_Height, string move_Margin)
        {
            return new MyPage_Another_SubPage1_List { Back_Source = back_Source, Img_Source = img_Source, Img_Source2 = img_Source2, Img_Source3 = img_Source3, Name = name, Move_Height = move_Height, Move_Margin = move_Margin };
        }
        
        private void Initialize_MyPage_Another_SubPage1()
        {
            Data_Making();

            for (int i = 0; i < back_folder.Count; i++ )
            {
                MAS1L.Add(GenerateItem(back_folder[i], img_folder[i], more_folder[i], plus_folder[i], name[i], height[i], margin[i]));
            }

            GView_MyPage_Another_SubPage1.ItemsSource = MAS1L;
        }

        private void Data_Making()
        {
            if(LocalDatabase.Save_MainTitle == null)
            {
                if (test == "Pusan Univ Class")
                {
                    FolderEmpty_Option("Pusan Univ Class_Sub");
                    Plus_Option();
                    Voice_Option("Pusan Univ Class - Page1");
                    Voice_Option("Pusan Univ Class - Page2");
                    Voice_Option("Pusan Univ Class - Page3");
                }
                else if (test == "Seoul Univ Class")
                {
                    Plus_Option();
                    Voice_Option("Seoul Univ Class - Page1");
                    Voice_Option("Seoul Univ Class - Page2");
                    Voice_Option("Seoul Univ Class - Page3");
                }
                else if (test == "Interview")
                {
                    Plus_Option();
                    Voice_Option("Interview - Page1");
                    Voice_Option("Interview - Page2");
                    Voice_Option("Interview - Page3");
                }
                else if (test == "Total")
                {
                    Plus_Option();
                }
                else if (test == "New Folder")
                {
                    Plus_Option();
                }
                else if (test == "Pusan Univ Class_Sub")
                {
                    Plus_Option();
                }
                else if (test == "Plus")
                {
                    Folder_Option("Pusan Univ Class");
                    Folder_Option("Seoul Univ Class");
                    Folder_Option("Interview");
                    FolderEmpty_Option("Total");
                    Folder_Option(LocalDatabase.Save_MainTitle);
                    FolderEmpty_Option("New Folder");
                    Plus_Option();
                    Voice_Option("Speech - Speech");
                    Voice_Option("Promotion - Page(1-4)");
                    Voice_Option("Biology - Biology");
                }
                else
                {
                    Folder_Option("Pusan Univ Class");
                    Folder_Option("Seoul Univ Class");
                    Folder_Option("Interview");
                    FolderEmpty_Option("Total");
                    Plus_Option();
                    Voice_Option("Speech - Speech");
                    Voice_Option("Promotion - Page(1-4)");
                    Voice_Option("Biology - Biology");
                }
            }
            else
            {
                Folder_Option("Pusan Univ Class");
                Folder_Option("Seoul Univ Class");
                Folder_Option("Interview");
                FolderEmpty_Option("Total");
                Folder_Option(LocalDatabase.Save_MainTitle);
                Plus_Option();
                Voice_Option("Speech - Speech");
                Voice_Option("Promotion - Page(1-4)");
                Voice_Option("Biology - Biology");
            }
        }

        private void GView_MyPage_Another_SubPage1_ItemClick(object sender, ItemClickEventArgs e)
        {
            MyPage_Another_SubPage1_List _item = e.ClickedItem as MyPage_Another_SubPage1_List;

            MyPage_Another_SubPage1_List pageParameters = new MyPage_Another_SubPage1_List();

            pageParameters.Message = _item.Name;

            test1 = _item.Name;

            if (test1 == "Pusan Univ Class")
            {
                FS_MyPage2.Navigate(typeof(MyPage_Another_SubPage1), pageParameters);
            }
            else if (test1 == "Seoul Univ Class")
            {
                FS_MyPage2.Navigate(typeof(MyPage_Another_SubPage1), pageParameters);
            }
            else if (test1 == "Favority Voice")
            {
                FS_MyPage2.Navigate(typeof(MyPage_Another_SubPage1), pageParameters);
            }
            else if (test1 == "Interview")
            {
                FS_MyPage2.Navigate(typeof(MyPage_Another_SubPage1), pageParameters);
            }
            else if (test1 == "Total")
            {
                FS_MyPage2.Navigate(typeof(MyPage_Another_SubPage1), pageParameters);
            }
            else if (test1 == "New Folder")
            {
                FS_MyPage2.Navigate(typeof(MyPage_Another_SubPage1), pageParameters);
            }
            else if (test1 == "Pusan Univ Class_Sub")
            {
                FS_MyPage2.Navigate(typeof(MyPage_Another_SubPage1), pageParameters);
            }
            else if (test1 == "")
            {
                FS_MyPage2.Navigate(typeof(MyPage_Another_SubPage1), pageParameters);
                test1 = "b";
            }
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            FS_MainPage3.Navigate(typeof(WritePage_Pre));
        }

        private void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {
            int BackStackDepth = FS_MyPage2.BackStackDepth;
            if (BackStackDepth > 0)
            {
                FS_MyPage2.GoBack();
            }
        }
        private void Folder_Option(string title)
        {
            back_folder.Add("Assets/filelist/file_line_400x39.png");
            img_folder.Add("Assets/filelist/file_white.png");
            more_folder.Add("Assets/filelist/file_more.png");
            plus_folder.Add("");
            name.Add(title);
            height.Add("40");
            margin.Add("69,11,0,0");
        }

        private void FolderEmpty_Option(string title)
        {
            back_folder.Add("Assets/filelist/file_line_400x39.png");
            img_folder.Add("Assets/filelist/file_line_w.png");
            more_folder.Add("Assets/filelist/file_more.png");
            plus_folder.Add("");
            name.Add(title);
            height.Add("40");
            margin.Add("69,11,0,0");
        }

        private void Voice_Option(string title)
        {
            back_folder.Add("Assets/filelist/voice_box_green.png");
            img_folder.Add("");
            more_folder.Add("");
            plus_folder.Add("");
            name.Add(title);
            height.Add("50");
            margin.Add("69,14,0,0");
        }

        private void Plus_Option()
        {
            back_folder.Add("");
            img_folder.Add("");
            more_folder.Add("");
            plus_folder.Add("Assets/filelist/file_plus.png");
            name.Add("");
            height.Add("50");
            margin.Add("69,14,0,0");
        }
    }
}
