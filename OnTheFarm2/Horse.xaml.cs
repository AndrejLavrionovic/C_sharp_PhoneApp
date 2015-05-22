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

namespace OnTheFarm2 {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Horse : Page {
        public Horse() {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e) {
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(Cow));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(Pig));
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e) {
            HorseSound.Play();
        }

        private void Image_Tapped_1(object sender, TappedRoutedEventArgs e) {
            HorseStory.Play();
        }
    }
}
