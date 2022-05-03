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
        public ObservableCollection<Card> allCards { get; } = new ObservableCollection<Card>();
        public ObservableCollection<Card> card1 { get; } = new ObservableCollection<Card>();
        public ObservableCollection<Card> card2 { get; } = new ObservableCollection<Card>();
        public ObservableCollection<Card> card3 { get; } = new ObservableCollection<Card>();
        public ObservableCollection<Card> card4 { get; } = new ObservableCollection<Card>();
        public ObservableCollection<Card> handCards { get; } = new ObservableCollection<Card>();
        public ObservableCollection<Card> cardBack { get; } = new ObservableCollection<Card>();
        public ObservableCollection<Card> squirrelCard { get; } = new ObservableCollection<Card>();

        Card PickedCard;
        bool CardInPlay = false;
        int CardInPlaySlot = -1;

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
            // Construye las listas de ModelView a partir de la lista Modelo 
            if (boardCards != null)
                foreach (Card card in BoardCards.GetBoardCards())
                {
                    boardCards.Add(card);
                }

            if (allCards != null)
                foreach (Card card in BoardCards.GetAllCards())
                {
                    allCards.Add(card);
                }

            if (handCards != null)
                foreach (Card card in BoardCards.GetHandCards())
                {
                    handCards.Add(card);
                }

            if (cardBack != null)
                foreach (Card card in BoardCards.GetCardBack())
                {
                    cardBack.Add(card);
                }

            if (squirrelCard != null)
                foreach (Card card in BoardCards.GetSquirrelCard())
                {
                    squirrelCard.Add(card);
                }

            base.OnNavigatedTo(e);

            this.Loaded += delegate { this.Focus(FocusState.Programmatic); };
        }

        private void Card_DragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.Copy;
        }

        private void Card1_Drop(object sender, DragEventArgs e)
        {
            if (card1.Count < 1 && PickedCard != null && PickedCard.cardPicture != "Assets\\Cards\\common.jpg")
            {
                card1.Add(PickedCard);
                handCards.Remove(PickedCard);
                PickedCard = null;
            }
        }

        private void Card2_Drop(object sender, DragEventArgs e)
        {
            if (card2.Count < 1 && PickedCard != null && PickedCard.cardPicture != "Assets\\Cards\\common.jpg")
            {
                card2.Add(PickedCard);
                handCards.Remove(PickedCard);
                PickedCard = null;
            }
        }

        private void Card3_Drop(object sender, DragEventArgs e)
        {
            if (card3.Count < 1 && PickedCard != null && PickedCard.cardPicture != "Assets\\Cards\\common.jpg")
            {
                card3.Add(PickedCard);
                handCards.Remove(PickedCard);
                PickedCard = null;
            }
        }

        private void Card4_Drop(object sender, DragEventArgs e)
        {
            if (card4.Count < 1 && PickedCard != null && PickedCard.cardPicture != "Assets\\Cards\\common.jpg")
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
            CardInPlay = false;
            CardInPlaySlot = -1;
        }

        private void Squirrel_DragItemsStarting(object sender, DragItemsStartingEventArgs e)
        {
            Card Item = e.Items[0] as Card;
            PickedCard = Item;
            CardInPlay = false;
            CardInPlaySlot = -1;
        }

        private void Back_DragItemsStarting(object sender, DragItemsStartingEventArgs e)
        {
            Card Item = e.Items[0] as Card;
            PickedCard = Item;
            CardInPlay = false;
            CardInPlaySlot = -1;
        }

        private void HandGridView_Drop(object sender, DragEventArgs e)
        {
            if (handCards.Count < 4 && PickedCard != null && PickedCard.cardPicture == "Assets\\Cards\\common.jpg")
            {
                Random rnd = new Random();
                handCards.Add(BoardCards.GetAllCardById(rnd.Next(allCards.Count)));
                PickedCard = null;
            }
        }

        private void Sacrifice_Drop(object sender, DragEventArgs e)
        {
            if (PickedCard != null && PickedCard.cardPicture != "Assets\\Cards\\common.jpg" && CardInPlay)
            {
                if (CardInPlaySlot == 1)
                    card1.Remove(PickedCard);
                else if (CardInPlaySlot == 2)
                    card2.Remove(PickedCard);
                else if (CardInPlaySlot == 3)
                    card3.Remove(PickedCard);
                else if (CardInPlaySlot == 4)
                    card4.Remove(PickedCard);
                PickedCard = null;
                CardInPlay = false;
                CardInPlaySlot = -1;
            }
        }

        private void MiCarta4_DragItemsStarting(object sender, DragItemsStartingEventArgs e)
        {
            Card Item = e.Items[0] as Card;
            PickedCard = Item;
            CardInPlay = true;
            CardInPlaySlot = 4;
        }

        private void MiCarta3_DragItemsStarting(object sender, DragItemsStartingEventArgs e)
        {
            Card Item = e.Items[0] as Card;
            PickedCard = Item;
            CardInPlay = true;
            CardInPlaySlot = 3;
        }

        private void MiCarta2_DragItemsStarting(object sender, DragItemsStartingEventArgs e)
        {
            Card Item = e.Items[0] as Card;
            PickedCard = Item;
            CardInPlay = true;
            CardInPlaySlot = 2;
        }

        private void MiCarta1_DragItemsStarting(object sender, DragItemsStartingEventArgs e)
        {
            Card Item = e.Items[0] as Card;
            PickedCard = Item;
            CardInPlay = true;
            CardInPlaySlot = 1;
        }
    }
}
