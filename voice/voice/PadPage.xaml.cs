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
    public sealed partial class PadPage : Page
    {
        public static Image Image_chg;
        public PadPage()
        {
            this.InitializeComponent();
            Image_chg = Image_Change;

        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!Frame_Pad1.Navigate(typeof(PadPage_Sub1)))
            {
                throw new Exception("Failed to create scenario list");
            }
            if (!Frame_Pad2.Navigate(typeof(PadPage_Desc)))
            {
                throw new Exception("Failed to create scenario list");
            }

        }



        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame_Pad2.Navigate(typeof(PadPage_Sub2));
        }

        private void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(writePage));
        }


    }
}
