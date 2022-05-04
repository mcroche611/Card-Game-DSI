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

    public sealed partial class MyDeck : Page
    {

        public ObservableCollection<Card> allCards { get; } = new ObservableCollection<Card>();
        public ObservableCollection<Card> myDeck { get; } = new ObservableCollection<Card>();

        public string cardDescription { get; set; }
        public string cardDescription2 { get; set; }

        public MyDeck()
        {
            this.InitializeComponent();
            cardDescription = "Carta perteneciente a tu mazo";
            cardDescription2 = "Pulsa en las cartas para añadirlas y quitarlas del mazo";


        }
        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            // First, check that it's safe to ask the Frame to go backward.
            if (Frame.CanGoBack)
            {
                // If there's a page in the "backstack," we can call GoBack().
                Frame.GoBack();
            }
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Cosntruye las listas de ModelView a partir de la lista Modelo 
            if (allCards != null)
                foreach (Card card in CardCollection.GetCards())
                {
                    allCards.Add(card);
                }
            base.OnNavigatedTo(e);

            this.Loaded += delegate { this.Focus(FocusState.Programmatic); };
        }

        private void BasicGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            //myDeck.Add(e.ClickedItem as Card);

        }

        private void BasicGridView2_ItemClick(object sender, ItemClickEventArgs e)
        {
            //myDeck.Remove(e.ClickedItem as Card);

        }

        private void BasicGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for(int i = 0; i < e.AddedItems.Count; i++)
            {
                myDeck.Add(e.AddedItems[i] as Card);

            }
            for (int i = 0; i < e.RemovedItems.Count; i++)
            {
                myDeck.Remove(e.RemovedItems[i] as Card);

            }
            //if(e.RemovedItems.Count >= 0)
            //myDeck.Remove(e.RemovedItems[0] as Card);

        }
    }
}