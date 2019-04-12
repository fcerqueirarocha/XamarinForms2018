using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using App1_NossoChat.Model;
using App1_NossoChat.Service;
using Xamarin.Forms;
using System.Linq;

namespace App1_NossoChat.ViewModel
{
    public class ChatsViewModel : INotifyPropertyChanged
    {
        private List<Chat> _chat;
        public List<Chat> Chats { get { return _chat; } set { _chat = value; onPropertyChanged("Chats"); } }

        private Chat _SelectedItemChatt;
        public Chat SelectedItemChat {
            get
            {
                return _SelectedItemChatt;
            }
            set
            {
                _SelectedItemChatt = value;
                onPropertyChanged("SelectedItemChat");
                GoPaginaMensagem(value);
            }
        }

        public Command AdicionarCommand { get; set; }
        public Command OrdenarCommand { get; set; }
        public Command AtualizarCommand { get; set; }


        //construtor
        public ChatsViewModel()
        {
            Chats = ServiceWS.GetChats();

            AdicionarCommand = new Command(Adicionar);
            OrdenarCommand = new Command(Ordenar);
            AtualizarCommand = new Command(Atualizar);
        }

        private void GoPaginaMensagem(Chat chat)
        {
            if (chat != null)
            {
                ((NavigationPage)App.Current.MainPage).Navigation.PushAsync(new View.Mensagens(chat));
            }
        }
        private void Adicionar()
        {
            ((NavigationPage)App.Current.MainPage).Navigation.PushAsync(new View.CadastrarChat());
            SelectedItemChat = null;
        }
        private void Ordenar()
        {
            Chats = Chats.OrderBy(a => a.nome).ToList();
        }
        private void Atualizar()
        {
            Chats = ServiceWS.GetChats();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void onPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
