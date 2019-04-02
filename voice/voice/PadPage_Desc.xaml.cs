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
    public sealed partial class PadPage_Desc : Page
    {
        public PadPage_Desc()
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
        }

        private void Image_Col2_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            Image_Col1.SetBinding(Image.SourceProperty, SetProperty("Assets/pad_rowpad/pad_rowpad_empty.jpg"));
            Image_Col2.SetBinding(Image.SourceProperty, SetProperty("Assets/pad_rowpad/pad_rowpad.jpg"));
            TBlock_Desc.Text = "1. Hey! how are you? \r\n \r\n2. My birthday is on January 5th! \r\n \r\n3. You don't have to talk loud I can hear \r\n    you well. ";
            PadPage.Image_chg.SetBinding(Image.SourceProperty, SetProperty("Assets/pad_change.jpg"));
            
            //PadPage_Sub1.PPList[0].Image1 = "Assets/pad_rowpad/pad_rowpad_empty.jpg";
            //PadPage_Sub1.PPList[1].Image1 = "Assets/pad_rowpad/pad_rowpad_empty.jpg";
            //PadPage_Sub1.PPList[2].Image1 = "Assets/pad_rowpad/pad_rowpad_empty.jpg";
            //PadPage_Sub1.PPList[3].Image1 = "Assets/pad_rowpad/pad_rowpad_empty.jpg";
            //PadPage_Sub1.PPList[4].Image1 = "Assets/pad_rowpad/pad_rowpad_empty.jpg";
            //PadPage_Sub1.PPList[5].Image1 = "Assets/pad_rowpad/pad_rowpad_empty.jpg";
            //PadPage_Sub1.PPList[6].Image1 = "Assets/pad_rowpad/pad_rowpad.jpg";
            //PadPage_Sub1.PPList[7].Image1 = "Assets/pad_rowpad/pad_rowpad.jpg";
            //PadPage_Sub1.PPList[8].Image1 = "Assets/pad_rowpad/pad_rowpad.jpg";
            //PadPage_Sub1.PPList[9].Image1 = "Assets/pad_rowpad/pad_rowpad.jpg";
            //PadPage_Sub1.PPList[10].Image1 = "Assets/pad_rowpad/pad_rowpad.jpg";
            //PadPage_Sub1.PPList[11].Image1 = "Assets/pad_rowpad/pad_rowpad.jpg";
        }
        private Binding SetProperty(string imagesource)
        {
            Binding b = new Binding();
            b.Mode = BindingMode.OneTime;
            b.Source = imagesource;
            return b;
        }
    }
}
