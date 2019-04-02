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
    public sealed partial class RecodePage_Sub1 : Page
    {
        private ObservableCollection<RecodePage_Sub1_List> RSL;

        private Frame FS_Recode;

        public RecodePage_Sub1()
        {
            this.InitializeComponent();
            RSL = new ObservableCollection<RecodePage_Sub1_List>();
            FS_Recode = RecodePage.F_Recode;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Initilize_RecodePage_Sub1();
        }

        private void Initilize_RecodePage_Sub1()
        {
            string aa = LocalDatabase.Imsi_Back[0].ToString();
            string bb = LocalDatabase.Imsi_Back[0];

            for (int i = 0; i < LocalDatabase.Imsi_Title.Count; i++ )
            {
                RSL.Add(GenerateItem(LocalDatabase.Imsi_Back[i].ToString(), LocalDatabase.Imsi_Title[i].ToString(),LocalDatabase.Imsi_Content[i].ToString(),""));
            }
          
            GView_RecodePage_Sub1.ItemsSource = RSL;
        }

        private RecodePage_Sub1_List GenerateItem(string img_Back, string tBox_SubTitle, string tBox_Content, string tBox_Time)
        {
            return new RecodePage_Sub1_List { Img_Back = img_Back, TBox_SubTitle = tBox_SubTitle, TBox_Content = tBox_Content, TBox_Time = tBox_Time };
        }

        private void GView_RecodePage_Sub1_ItemClick(object sender, ItemClickEventArgs e)
        {
            RecodePage_Sub1_List _item = e.ClickedItem as RecodePage_Sub1_List;

            RecodePage_Sub1_List pageParameters = new RecodePage_Sub1_List();

            pageParameters.Message = _item.TBox_SubTitle;
            FS_Recode.Navigate(typeof(RecodePage_Sub2), pageParameters);
        }
    }
}
