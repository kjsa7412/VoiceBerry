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
    public sealed partial class NoticePage_Another : Page
    {

        private ObservableCollection<NoticePage_Another_List> NAL;

        public NoticePage_Another()
        {
            this.InitializeComponent();
            NAL = new ObservableCollection<NoticePage_Another_List>();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Initialize_NoticePage_Another_List();
        }

        private void Initialize_NoticePage_Another_List()
        {
            if(LocalDatabase.chk1 == "2")
            {
                NAL.Add(GenerateItem("Assets/profile/profile_Sam.png", "Hyunmin", "finished recording", "15. 01. 2015"));
                NAL.Add(GenerateItem("Assets/profile/profile_jason.png", "Kyungjin", "finished recording", "15. 01. 2015"));
                NAL.Add(GenerateItem("Assets/profile/profile_Sam.png", "Hyunmin", "sent you a message", "15. 01. 2015"));
                NAL.Add(GenerateItem("Assets/profile/profile_jason.png", "Kyungjin", "sent you a message", "15. 01. 2015"));
                NAL.Add(GenerateItem("Assets/profile/profile_Sam.png", "Hyunmin", "started following you", "15. 01. 2015"));
                NAL.Add(GenerateItem("Assets/profile/profile_jason.png", "Kyungjin", "started following you", "15. 01. 2015"));
            }
            else
            {
                NAL.Add(GenerateItem("Assets/profile/profile_gil.png", "Seungmoo", "sent you a request", "15. 01. 2015"));
            }
            GView_NoticePage_Another.ItemsSource = NAL;
        }

        private NoticePage_Another_List GenerateItem(string img_Source, string name, string notice, string time)
        {
            return new NoticePage_Another_List { Img_Source = img_Source, Name = name, Notice = notice, Time = time };
        }

    }
}