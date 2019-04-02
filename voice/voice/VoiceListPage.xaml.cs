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
    public sealed partial class VoiceListPage : Page
    {
        private ObservableCollection<VoiceListPage_List> VL;
        private Frame m_Frame;
        public VoiceListPage()
        {
            this.InitializeComponent();
            VL = new ObservableCollection<VoiceListPage_List>();
            m_Frame = MainPage3.MPage3_Frame;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Initialize_VoiceListPage();
        }

        private VoiceListPage_List GenerateItem(string name, string time, string date)
        {
            return new VoiceListPage_List { Name = name, Time = time, Date = date };
        }

        private void Initialize_VoiceListPage()
        {
            for (int i = 0; i < LocalDatabase.Pad_Title.Count; i++ )
            {
                VL.Add(GenerateItem(LocalDatabase.Pad_Title[i].ToString(), LocalDatabase.Pad_Time[i].ToString(), LocalDatabase.Pad_Date[i].ToString()));
            }
            GView_VoiceListPage.ItemsSource = VL;
        }

        private void GView_VoiceListPage_ItemClick(object sender, ItemClickEventArgs e)
        {
            VoiceListPage_List _item = e.ClickedItem as VoiceListPage_List;

            VoiceListPage_List pageParameters = new VoiceListPage_List();

            pageParameters.Message = _item.Name;

            m_Frame.Navigate(typeof(PadPage_New), pageParameters);
        }
    }
}
