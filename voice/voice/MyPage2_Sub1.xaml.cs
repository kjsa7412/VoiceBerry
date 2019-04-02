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
    public sealed partial class MyPage2_Sub1 : Page
    {
        private ObservableCollection<MyPage2List> MP2Sub1;
        private ObservableCollection<MyPage2List2> MP2Sub2;
        public MyPage2_Sub1()
        {
            this.InitializeComponent();
            MP2Sub1 = new ObservableCollection<MyPage2List>();
            MP2Sub2 = new ObservableCollection<MyPage2List2>();
            GView_MyPage2_Sub1.ItemClick += GView_MyPage2_Sub1_ItemClick;
        }

        private void GView_MyPage2_Sub1_ItemClick(object sender, ItemClickEventArgs e)
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
            //MP2Sub1.Add(GenerateItem2("man / 37-39 / tone5", "And maybe I'm not ready", "Assets/Logo.scale-240.png"));
            //MP2Sub1.Add(GenerateItem2("man / 37-39 / tone5", "And maybe I'm not ready", "Assets/Logo.scale-240.png"));
            //MP2Sub1.Add(GenerateItem2("man / 37-39 / tone5", "And maybe I'm not ready", "Assets/Logo.scale-240.png"));
            //MP2Sub1.Add(GenerateItem2("man / 37-39 / tone5", "And maybe I'm not ready", "Assets/Logo.scale-240.png"));
            //MP2Sub1.Add(GenerateItem2("man / 37-39 / tone5", "And maybe I'm not ready", "Assets/Logo.scale-240.png"));

            MP2Sub1.Add(GenerateItem("Assets/My_sentence/my_sentence.png", "woman"  ,"23-25",   "Joyful", "Oh my god!"));
            MP2Sub1.Add(GenerateItem("Assets/My_sentence/my_sentence.png", "man"    ,"20-30",   "Formal", "I'm so hungry. Do you want to eat lunch with me?"));
            MP2Sub1.Add(GenerateItem("Assets/My_sentence/my_sentence.png", "man"    ,"20-22",   "Joyful", "I use this device to speak."));
            MP2Sub1.Add(GenerateItem("Assets/My_sentence/my_sentence.png", "man"    ,"40-43",   "Scared", "I would like my coffee with one sugar and no milk or cream, and would you give me a stirring spoon with it?"));
            MP2Sub1.Add(GenerateItem("Assets/My_sentence/my_sentence.png", "woman"  ,"37-39",   "Formal", "I'm not mad."));
            MP2Sub1.Add(GenerateItem("Assets/My_sentence/my_sentence.png", "man"    ,"20-30",   "Scared", "Have you seen my glasses? I can't find them again!"));
            MP2Sub1.Add(GenerateItem("Assets/My_sentence/my_sentence.jpg", "man"    ,"20-22",   "Casual", "I will be back in a few minutes."));
            MP2Sub1.Add(GenerateItem("Assets/My_sentence/my_sentence.jpg", "man"    ,"40-43",   "Joyful", "Let's go home. What a long day."));
            MP2Sub1.Add(GenerateItem("Assets/My_sentence/my_sentence.jpg", "woman"  ,"37-39",   "Casual", "I study Business at Pusan National University"));
            MP2Sub1.Add(GenerateItem("Assets/My_sentence/my_sentence.jpg", "man"    ,"30-35",   "Joyful", "This is my boyfriend."));
            MP2Sub1.Add(GenerateItem("Assets/My_sentence/my_sentence.jpg", "woman"  ,"25-27",   "Casual", "Hello is this pizza 72?"));
            MP2Sub1.Add(GenerateItem("Assets/My_sentence/my_sentence.jpg", "man"    ,"21-25",   "Formal", "My address is Wayne Gretzky Drive 107 Avenue and I would like a large cheese pizza."));

            //GView_MyPage2_Sub1.ItemsSource = MP2Sub2;
            GView_MyPage2_Sub1.ItemsSource = MP2Sub1;
        }

        private MyPage2List GenerateItem(string image2, string option, string option2, string option3, string content)
        {
            return new MyPage2List { Option = option, Option2 = option2, Option3 = option3, Content = content, Image2 = image2 };
        }

        private MyPage2List GenerateItem2(string option2, string content2, string image2)
        {
            return new MyPage2List { Option2 = option2, Content2 = content2, Image2 = image2 };
        }
    }
}
