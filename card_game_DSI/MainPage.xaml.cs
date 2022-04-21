using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace card_game_DSI
{
    public sealed partial class MainPage : Page
    {
        public string username { get; set; }
        public string status { get; set; }

        public MainPage()
        {
            this.InitializeComponent();

            username = "Kaycee21";
            status = "Hello card gamers!";
        }

        private void Classification_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Classification));
        }

        private void Friends_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Friends));
        }

        private void Campaign_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Campaign));
        }

        private void OnlineMatch_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Board));
        }

        private void Collection_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Collection));
        }

        private void MyDeck_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MyDeck));
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Profile));
        }

        private void Store_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Store));
        }

        private void Mail_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Mail));
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Settings));
        }
    }
}
