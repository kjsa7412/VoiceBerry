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
using Microsoft.WindowsAzure.MobileServices;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace voice
{
    public sealed partial class LoginPage : Page
    {
        //private bool chk = true;

        IMobileServiceTable<TodoItem> todoTable = App.MobileService.GetTable<TodoItem>();
        
        IMobileServiceTable<User1> user1_table = App.MobileService.GetTable<User1>();

        IMobileServiceTable<test> testTable = App.MobileService.GetTable<test>();
        public LoginPage()
        {
            this.InitializeComponent();

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //Image_Login.SetBinding(Image.SourceProperty, SetProperty("Assets/login/login_login.jpg"));
            //Image_Signup.SetBinding(Image.SourceProperty, SetProperty("Assets/login/login_signup.jpg"));
            //var testTable = App.MobileService.GetTable<test>();
           // var ch = await
                //await MobileService
            //Make_Database();
        }

        private async void Make_Database(string u_name, string u_pass)
        {
            List<User1> items1 = await user1_table
            .Where(user1 => user1.u_name == u_name)
            .Where(user1 => user1.u_pass == u_pass)
            .ToListAsync();

            //string test = items[0].ToString();
        }

        private void Image_Login_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            //Image_Login.SetBinding(Image.SourceProperty, SetProperty("Assets/login/login_login.jpg"));
        }

        private void Image_Login_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            //Image_Login.SetBinding(Image.SourceProperty, SetProperty("Assets/login/login_login.jpg"));

           // Make_Database(Tbox_Id.Text, Pbox_Pass.Password);

            if (Tbox_Id.Text == "Kyungjin")
            {
                LocalDatabase.chk1 = "1";
                this.Frame.Navigate(typeof(MainPage2));
            }
            else
            {
                LocalDatabase.chk1 = "2";
                this.Frame.Navigate(typeof(MainPage3));
            }
        }

        private void Image_Signup_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            //Image_Signup.SetBinding(Image.SourceProperty, SetProperty("Assets/login/login_signup.jpg"));
        }

        private void Image_Signup_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            //Image_Signup.SetBinding(Image.SourceProperty, SetProperty("Assets/login/login_signup.jpg"));
            //this.Frame.Navigate(typeof(MainPage3));

        }
        private void Image_Login_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            //Image_Login.SetBinding(Image.SourceProperty, SetProperty("Assets/blue.jpg"));
        }

        private void Image_Signup_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            //Image_Signup.SetBinding(Image.SourceProperty, SetProperty("Assets/blue.jpg"));
        }

        private Binding SetProperty(string image)
        {
            Binding b = new Binding();
            b.Mode = BindingMode.OneTime;
            b.Source = image;
            return b;
        }

        private  void btn_test_Click(object sender, RoutedEventArgs e)
        {
            var todoItem = new TodoItem { Text = "aa" };
            InsertTodoItem(todoItem);


           
            var testItem = new test { a = "a", b = "b" };
            InsertTest(testItem);
            //var user1 = new User1 { u_name = "EUGENE", u_pass = "1234" };
            ////var user2 = new User1 { u_name = "EUGENE", u_pass = "1234" };
            //InsertUser1(user1);

        }

        private async void InsertTodoItem(TodoItem todoItem)
        {
            //TodoItem item = new TodoItem { Text = "Awesome item", Complete = false };
            //await App.MobileService.GetTable<TodoItem>().InsertAsync(item);

            await todoTable.InsertAsync(todoItem); 
        }

        private async void InsertUser1(User1 user1)
        {
            await user1_table.InsertAsync(user1);
        }

        private async void InsertTest(test test1)
        {
            await testTable.InsertAsync(test1);
        }

    }
}
