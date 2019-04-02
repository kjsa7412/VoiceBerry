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
    public sealed partial class writePage : Page
    {
        WritePage_Pre_List _pageParameters;
        private string test;
        private int aa = 100;
        public writePage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _pageParameters = e.Parameter as WritePage_Pre_List;
            if (_pageParameters.Message == "")
            {
                test = "";
            }
            else
            {
                test = _pageParameters.Message;
            }
            Initialize_writePage();
        }

        private void Initialize_writePage()
        {
           // int bb = WritePage_Pre.Title[0].ToString().CompareTo("");
            int bb = WritePage_Pre.Title.Count;
            for (int i = 0; i < WritePage_Pre.Title.Count; i++ )
            {
                if(WritePage_Pre.Title[i].ToString().CompareTo(test) == 0)
                {
                    aa = i;
                }
            }
            if(aa == 100)
            {
                TBox_Title.Text = "";
                TBox_Content.Text = "";
            }
            else
            {
                TBox_Title.Text = WritePage_Pre.Title[aa];
                TBox_Content.Text = WritePage_Pre.Content[aa];
            }
        }


        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            if(aa == 100)
            {
                WritePage_Pre.Title.Add(TBox_Title.Text);
                WritePage_Pre.Content.Add(TBox_Content.Text);
            }
            else
            {
                WritePage_Pre.Title[aa] = TBox_Title.Text;
                WritePage_Pre.Content[aa] = TBox_Content.Text;
            }
            this.Frame.Navigate(typeof(WritePage_Pre));
        }
    }
}
