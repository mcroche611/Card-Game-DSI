using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace card_game_DSI
{
    public class Email : INotifyPropertyChanged
    {
        public string sender { get; set; }
        public string subject { get; set; }
        public Symbol symbol;

        public event PropertyChangedEventHandler PropertyChanged;

        public Email(string from, string body)
        {
            sender = "from " + from;
            subject = body;
            symbol = Symbol.Mail;
        }

        public void Open()
        {
            symbol = Symbol.Read;
            RaisePropertyChanged(nameof(symbol));
        }

        protected void RaisePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
