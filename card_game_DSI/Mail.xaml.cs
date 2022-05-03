﻿using System;
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
    public sealed partial class Mail : Page
    {
        public ObservableCollection<Email> inbox { get; } = new ObservableCollection<Email>();

        public Mail()
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
            if (inbox != null)
                foreach (Email email in Inbox.GetInbox())
                {
                    inbox.Add(email);
                }
            base.OnNavigatedTo(e);

            this.Loaded += delegate { this.Focus(FocusState.Programmatic); };
        }

        private void ImageGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            (e.ClickedItem as Email).Open();
        }
    }
}
