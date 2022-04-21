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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace card_game_DSI
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Profile : Page
    {
        public string username { get; set; }
        public string status { get; set; }
        public string coleccion { get; set; }
        public string partidas { get; set; }
        public string clasificacion { get; set; }
        public string victorias { get; set; }

        public Profile()
        {
            this.InitializeComponent();
            username = "Kaycee21";
            status = "Hello card gamers!";
            coleccion = "27";
            partidas = "16";
            clasificacion = "69420";
            victorias = "1";
        }


        private void Profile_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Aceptar_Click(object sender, RoutedEventArgs e)
        {
            // First, check that it's safe to ask the Frame to go backward.
            if (Frame.CanGoBack)
            {
                // If there's a page in the "backstack," we can call GoBack().
                Frame.GoBack();
            }
        }
    }
}
