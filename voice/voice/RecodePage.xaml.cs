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
    public sealed partial class RecodePage : Page
    {
        MainList _pageParameters;
        private string test;
        public static Frame F_Recode;

        public RecodePage()
        {
            this.InitializeComponent();
            F_Recode = Frame_RecodePage;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _pageParameters = e.Parameter as MainList;
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

            Initilize_RecodePage();
        }

        private void Initilize_RecodePage()
        {
            int i = LocalDatabase.Write_MainTitle.Count - 1;
            TBox_Title.Text = LocalDatabase.Write_MainTitle[i].ToString();
            Img_Gender_Pic.SetBinding(Image.SourceProperty, SetProperty("Assets/donator_optionbox_format/gener_male_icon.png"));
            TBox_Gender.Text = "Male";
            //if (LocalDatabase.Write_Gender[i].ToString() == "Male")
            //{
            //    Img_Gender_Pic.SetBinding(Image.SourceProperty,SetProperty("Assets/maidonator_main/main_male_icon.png"));
            //    TBox_Gender.Text = "Male";
            //}
            //else
            //{
            //    Img_Gender_Pic.SetBinding(Image.SourceProperty, SetProperty("Assets/maidonator_main/main_female_icon.png"));
            //    TBox_Gender.Text = "Female";
            //}
            TBox_Age.Text = LocalDatabase.Write_AgeTo[i].ToString() + " ~ " + LocalDatabase.Write_AgeFrom[i].ToString();
            TBox_Audience.Text = LocalDatabase.Write_Audience[i].ToString();
            TBox_Purpose.Text = LocalDatabase.Write_Purpose[i].ToString();
            TBox_Additional.Text = LocalDatabase.Write_Additional[i].ToString();

            Frame_RecodePage.Navigate(typeof(RecodePage_Sub1));
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
