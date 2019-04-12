using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using App1_NossoChat.Service;
using App1_NossoChat.Model;
using System.ComponentModel;

namespace App1_NossoChat.ViewModel
{
    public class CadastrarChatViewModel : INotifyPropertyChanged
    {

        private string _mensagem { get; set; }
        public string Mensagem {
            get { return _mensagem; }
            set { _mensagem = value; onPropertyChanged("Mensagem"); }
        }
        public string Nome { get; set; }
        public Command CadastrarCommand { get; set; }

        public CadastrarChatViewModel()
        {
            CadastrarCommand = new Command(Cadastrar);
        }

        

        private void Cadastrar()
        {
            var chat = new Chat() { nome = Nome };
            bool ok = ServiceWS.InsertChat(chat);

            if (ok == true)
            {
                ((NavigationPage)App.Current.MainPage).Navigation.PopAsync();

                //chamar propriedade de uma pagina no retorno
                var Nav = (NavigationPage)App.Current.MainPage;
                var Chats = (View.Chats)Nav.RootPage;
                var ViewModel = (ChatsViewModel)Chats.BindingContext;
                if (ViewModel.AtualizarCommand.CanExecute(null))
                {
                    ViewModel.AtualizarCommand.Execute(null);
                }
                //Fim
            }
            else
            {
                Mensagem = "Ocorreu um erro no cadastro";
            }
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
