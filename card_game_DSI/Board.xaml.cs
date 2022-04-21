using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using System.Collections.ObjectModel;
using Windows.ApplicationModel.DataTransfer;
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
    public sealed partial class Board : Page
    {
        public ObservableCollection<Card> boardCards { get; } = new ObservableCollection<Card>();
        public ObservableCollection<Card> card1 { get; } = new ObservableCollection<Card>();
        public ObservableCollection<Card> card2 { get; } = new ObservableCollection<Card>();
        public ObservableCollection<Card> card3 { get; } = new ObservableCollection<Card>();
        public ObservableCollection<Card> card4 { get; } = new ObservableCollection<Card>();
        public ObservableCollection<Card> handCards { get; } = new ObservableCollection<Card>();

        int Num = -1;
        Card PickedCard;
        public Board()
        {
            this.InitializeComponent();
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
            if (boardCards != null)
                foreach (Card card in BoardCards.GetBoardCards())
                {
                    boardCards.Add(card);
                }

            if (handCards != null)
                foreach (Card card in BoardCards.GetHandCards())
                {
                    handCards.Add(card);
                }

            base.OnNavigatedTo(e);

            this.Loaded += delegate { this.Focus(FocusState.Programmatic); };
        }

        private void BasicGridView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void Card_DragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.Copy;
        }

        private void Card1_Drop(object sender, DragEventArgs e)
        {
            if (card1.Count < 1 && PickedCard != null)
            {
                card1.Add(PickedCard);
                handCards.Remove(PickedCard);
                PickedCard = null;
            }
        }

        private void Card2_Drop(object sender, DragEventArgs e)
        {
            if (card2.Count < 1 && PickedCard != null)
            {
                card2.Add(PickedCard);
                handCards.Remove(PickedCard);
                PickedCard = null;
            }
        }

        private void Card3_Drop(object sender, DragEventArgs e)
        {
            if (card3.Count < 1 && PickedCard != null)
            {
                card3.Add(PickedCard);
                handCards.Remove(PickedCard);
                PickedCard = null;
            }
        }

        private void Card4_Drop(object sender, DragEventArgs e)
        {
            if (card4.Count < 1 && PickedCard != null)
            {
                card4.Add(PickedCard);
                handCards.Remove(PickedCard);
                PickedCard = null;
            }
        }

        private void HandGridView_DragItemsStarting(object sender, DragItemsStartingEventArgs e)
        {
            Card Item = e.Items[0] as Card;
            PickedCard = Item;
        }
    }
}
