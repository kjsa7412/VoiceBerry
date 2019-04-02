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
using Windows.UI.Xaml.Media.Animation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace voice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SpeechPage : Page
    {
        private ObservableCollection<SpeechPage_List> SL;
        private string test;
        SpeechPage_List _pageParameters;

        public SpeechPage()
        {
            this.InitializeComponent();
            SL = new ObservableCollection<SpeechPage_List>();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _pageParameters = e.Parameter as SpeechPage_List;
            if (_pageParameters != null)
            {
                LocalDatabase.Temp = _pageParameters.Message;
            }
            Initilize_SpeechPage();
        }

        private SpeechPage_List GenerateItem(string img_Source2, string name, string date, string id, string img_Source)
        {
            return new SpeechPage_List {Img_Source2 = img_Source2, Name = name, Date = date, Id = id, Img_Source = img_Source };
        }

        private void Initilize_SpeechPage()
        {
            TBox_Title.Text = LocalDatabase.Temp;
            SL.Add(GenerateItem("Assets/asking_donatelist/berry_play.png", "00:00:00 / 00:10:00", "15. 01. 2015", "Hyenmin", "Assets/profile/profile_jason.png"));
            SL.Add(GenerateItem("Assets/asking_donatelist/berry_play.png", "00:00:00 / 00:10:00", "15. 01. 2015", "Kyungjin", "Assets/profile/profile_sam.png"));
            GView_SpeechPage.ItemsSource = SL;
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Move_Grid();
        }

        private void Move_Grid()
        {
            if (Grid_Menu.IsRightTapEnabled == true)
            {
                DoubleAnimation anima = new DoubleAnimation
                {
                    EnableDependentAnimation = true,
                    To = 129,
                    Duration = new Duration(TimeSpan.FromSeconds(0.2)),
                };

                DoubleAnimation anima2 = new DoubleAnimation
                {
                    EnableDependentAnimation = true,
                    From = 0.0,
                    To = 1.0,
                    Duration = new Duration(TimeSpan.FromSeconds(0.2)),
                };

                Storyboard.SetTarget(anima, Grid_Menu);
                Storyboard.SetTargetProperty(anima, "(Canvas.Left)");

                Storyboard.SetTarget(anima2, Grid_Menu);
                Storyboard.SetTargetProperty(anima2, "Opacity");

                Storyboard storyboard = new Storyboard();
                storyboard.Children.Add(anima);
                storyboard.Children.Add(anima2);
                storyboard.Begin();

                Grid_Menu.IsRightTapEnabled = false;

            }
            else
            {
                DoubleAnimation anima = new DoubleAnimation
                {
                    EnableDependentAnimation = true,
                    To = 400,
                    Duration = new Duration(TimeSpan.FromSeconds(0.2)),
                };

                DoubleAnimation anima2 = new DoubleAnimation
                {
                    EnableDependentAnimation = true,
                    From = 1.0,
                    To = 0.0,
                    Duration = new Duration(TimeSpan.FromSeconds(0.2)),
                };

                Storyboard.SetTarget(anima, Grid_Menu);
                Storyboard.SetTargetProperty(anima, "(Canvas.Left)");

                Storyboard.SetTarget(anima2, Grid_Menu);
                Storyboard.SetTargetProperty(anima2, "Opacity");

                Storyboard storyboard = new Storyboard();
                storyboard.Children.Add(anima);
                storyboard.Children.Add(anima2);
                storyboard.Begin();

                Grid_Menu.IsRightTapEnabled = true;
            }
        }

        private void GView_SpeechPage_ItemClick(object sender, ItemClickEventArgs e)
        {
            SpeechPage_List _item = e.ClickedItem as SpeechPage_List;

            VoiceListPage_List pageParameters = new VoiceListPage_List();

            pageParameters.Message = TBox_Title.Text;

            Frame_Speech.Navigate(typeof(SpeechPage_Sub1), pageParameters);

            if (Grid_Menu.IsRightTapEnabled == true)
            {
                Move_Grid();
            }
        }
    }
}
