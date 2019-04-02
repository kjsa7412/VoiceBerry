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
    public sealed partial class AskingListPage : Page
    {
        private Frame FS_MainPage3;
        private ObservableCollection<AskingListPage_List> AL;

        public AskingListPage()
        {
            this.InitializeComponent();
            FS_MainPage3 = MainPage3.MPage3_Frame;
            AL = new ObservableCollection<AskingListPage_List>();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Initialize_AskingListPage();
        }

        private AskingListPage_List GenerateItem(string name, string date, string count)
        {
            return new AskingListPage_List { Name = name, Date = date, Count = count };
        }

        private void Initialize_AskingListPage()
        {
            for (int i = LocalDatabase.Write_MainTitle.Count - 1; i >= 0; i--)
            {
                AL.Add(GenerateItem(LocalDatabase.Write_MainTitle[i].ToString(),"15. 1. 2015", "2"));
            }
            GView_AskingListPage.ItemsSource = AL;
        }

        private void GView_AskingListPage_ItemClick(object sender, ItemClickEventArgs e)
        {
            AskingListPage_List _item = e.ClickedItem as AskingListPage_List;

            SpeechPage_List pageParameters = new SpeechPage_List();

            pageParameters.Message = _item.Name;

            FS_MainPage3.Navigate(typeof(SpeechPage), pageParameters);
        }
    }
}
