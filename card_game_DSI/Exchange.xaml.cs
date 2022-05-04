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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace card_game_DSI
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Exchange : Page
    {
        public ObservableCollection<Add> addList { get; } = new ObservableCollection<Add>();
        Button selected;

        public Exchange()
        {
            this.InitializeComponent();

            if (addList != null)
                foreach (Add add in ExchangeList.GetAddList())
                {
                    addList.Add(add);
                }

            this.Loaded += delegate { this.Focus(FocusState.Programmatic); };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            addList.Remove((sender as Button).DataContext as Add);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (selected.Flyout is Flyout f)
            {
                f.Hide();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            selected = sender as Button;
        }
    }
}
