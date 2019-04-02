using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Collections.Generic;
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
    public sealed partial class PadPage_Sub1 : Page
    {
        public static ObservableCollection<PaddPageList> PPList;
        public static GridView GView_Template;
        public PadPage_Sub1()
        {
            this.InitializeComponent();
            GView_PadPage_Sub1.ItemClick += GView_PadPage_Sub1_ItemClick;
            PPList = new ObservableCollection<PaddPageList>();
            GView_Template = GView_PadPage_Sub1;
        }

        private void GView_PadPage_Sub1_ItemClick(object sender, ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            int j = 0;
            string[] name = new string[6] { "A", "B", "C", "D", "E", "F" };
            string[] image = new string[6] {
                "Assets/Pad_pad/pad_pad_bigsize_pressed.jpg",
                "Assets/Pad_pad/pad_pad_bigsize_pressed.jpg",
                "Assets/Pad_pad/pad_pad_bigsize_pressed.jpg",
                "Assets/Pad_pad/pad_pad_bigsize_pressed.jpg",
                "Assets/Pad_pad/pad_pad_bigsize_pressed.jpg",
                "Assets/Pad_pad/pad_pad_bigsize_pressed.jpg"
            };

            string[] image2 = new string[6] {
                "Assets/Pad_pad/pad_pad_bigsize.jpg",
                "Assets/Pad_pad/pad_pad_bigsize.jpg",
                "Assets/Pad_pad/pad_pad_bigsize.jpg",
                "Assets/Pad_pad/pad_pad_bigsize.jpg",
                "Assets/Pad_pad/pad_pad_bigsize.jpg",
                "Assets/Pad_pad/pad_pad_bigsize.jpg"
            };

            for (int i = 1; i < 25; i++)
            {
                string name1 = "";
                string image1;
                if(i < 7)
                {
                    image1 = image[j];
                }
                else
                {
                    image1 = image2[j];
                }

                PPList.Add(GenerateItem(
                name1,
                image1
                ));
                
                if(j == 5)
                {
                    j = 0;
                }
                else
                {
                    j += 1;
                }
            }
            
            GView_PadPage_Sub1.ItemsSource = PPList;
        }

        private PaddPageList GenerateItem(string name1, string image1)
        {
            return new PaddPageList {Name1 = name1, Image1 = image1};
        }
    }
}
