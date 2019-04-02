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
    public sealed partial class Intro : Page
    {
        int cnt = 0;
        DispatcherTimer timer = new DispatcherTimer();
        public Intro()
        {
            this.InitializeComponent(); 
        }

        private void OnTimerTick(object sender, object e)
        {
            if (cnt < 2) cnt++;
            else if (cnt == 2)
            {
                this.Frame.Navigate(typeof(LoginPage));
                cnt = 0;
                timer.Stop();
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += OnTimerTick;

            timer.Start();
        }
    }
}
