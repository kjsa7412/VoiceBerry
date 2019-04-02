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
    public sealed partial class SpeechPage_Sub1 : Page
    {
        private ObservableCollection<SpeechPage_Sub1_List> SSL;
        private int m_Height = 70, t_Height = 15;
        private int ms_Height, ts_Height;
        private string m_content;
        private string test;
        VoiceListPage_List _pageParameters;

        public SpeechPage_Sub1()
        {
            this.InitializeComponent();
            SSL = new ObservableCollection<SpeechPage_Sub1_List>();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _pageParameters = e.Parameter as VoiceListPage_List;
            if (_pageParameters != null)
            {
                if (_pageParameters.Message == "")
                {
                    test = "";
                }
                else
                {
                    test = _pageParameters.Message;
                }
            }

            Initialize_SpeechPage_Sub1();
        }

        private SpeechPage_Sub1_List GenerateItem(string title, string content, string move_Height, string text_Height)
        {
            return new SpeechPage_Sub1_List { Title = title, Content = content, Move_Height = move_Height, Text_Height = text_Height };
        }

        private void Initialize_SpeechPage_Sub1()
        {
            if (LocalDatabase.Pad_Title[0].ToString() == test)
            {
                for (int i = 0; i < 3; i++)
                {
                    m_content = LocalDatabase.Pad_Sub_Content[i].ToString();
                    int temp = m_content.Length / 41;
                    int temp2 = 15 * temp;

                    ms_Height = m_Height + temp2;
                    ts_Height = t_Height + temp2;

                    SSL.Add(GenerateItem(LocalDatabase.Pad_Sub_Title[i].ToString(), LocalDatabase.Pad_Sub_Content[i].ToString(), ms_Height.ToString(), ts_Height.ToString()));
                }
                //SSL.Add(GenerateItem("Intro(pag1-3)", "abcdefghigklmnopqrstuvwxyzabcdefghigklmnopqrstuvwxyzabcdefghigklmnopqrstuvwxyz", "125", "70"));
                GView_SpeechPage_Sub1.ItemsSource = SSL;
            }
            else if (LocalDatabase.Pad_Title[1].ToString() == test)
            {
                for (int i = 3; i < 6; i++)
                {
                    m_content = LocalDatabase.Pad_Sub_Content[i].ToString();
                    int temp = m_content.Length / 41;
                    int temp2 = 15 * temp;

                    ms_Height = m_Height + temp2;
                    ts_Height = t_Height + temp2;

                    SSL.Add(GenerateItem(LocalDatabase.Pad_Sub_Title[i].ToString(), LocalDatabase.Pad_Sub_Content[i].ToString(), ms_Height.ToString(), ts_Height.ToString()));
                }
                //SSL.Add(GenerateItem("Intro(pag1-3)", "abcdefghigklmnopqrstuvwxyzabcdefghigklmnopqrstuvwxyzabcdefghigklmnopqrstuvwxyz", "125", "70"));
                GView_SpeechPage_Sub1.ItemsSource = SSL;
            }
            else if (LocalDatabase.Pad_Title[2].ToString() == test)
            {
                for (int i = 6; i < 9; i++)
                {
                    m_content = LocalDatabase.Pad_Sub_Content[i].ToString();
                    int temp = m_content.Length / 41;
                    int temp2 = 15 * temp;

                    ms_Height = m_Height + temp2;
                    ts_Height = t_Height + temp2;

                    SSL.Add(GenerateItem(LocalDatabase.Pad_Sub_Title[i].ToString(), LocalDatabase.Pad_Sub_Content[i].ToString(), ms_Height.ToString(), ts_Height.ToString()));
                }
                //SSL.Add(GenerateItem("Intro(pag1-3)", "abcdefghigklmnopqrstuvwxyzabcdefghigklmnopqrstuvwxyzabcdefghigklmnopqrstuvwxyz", "125", "70"));
                GView_SpeechPage_Sub1.ItemsSource = SSL;
            }
            else if (test == null)
            {

            }
            else
            {

            }


        }
    }
}
