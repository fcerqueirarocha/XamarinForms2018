using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using App1_NossoChat.Model;
using App1_NossoChat.Service;
using Xamarin.Forms;
using System.Linq;
using App1_NossoChat.Util;

namespace App1_NossoChat.ViewModel
{
    public class MensagensViewModel : INotifyPropertyChanged
    {
        private StackLayout SL;
        private Chat chat;

        private List<Mensagem> _mensagem;
        public List<Mensagem> Mensagem
        {
            get
            {
                return _mensagem;
            }
            set
            {
                _mensagem = value;
                onPropertyChanged("Mensagem");
                if (value != null)
                {
                    ShowOnScreen();
                }
            }
        }

        private string _txtMensagem;
        public string TxtMensagem
        {
            get
            {
                return _txtMensagem;
            }
            set
            {
                _txtMensagem = value;
                onPropertyChanged("TxtMensagem");
                if (value != null)
                {
                    ShowOnScreen();
                }
            }
        }

        public Command BtnEnviarCommand { get; set; }
        public Command AtualizarCommand { get; set; }

        public MensagensViewModel(Chat chat, StackLayout SLMensagemContaner)
        {
            SL = SLMensagemContaner;
            this.chat = chat;

            Atualizar();
            BtnEnviarCommand = new Command(BtnEnviar);
            AtualizarCommand = new Command(Atualizar);

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                Atualizar();
                return true;
            });
        }

        private void Atualizar()
        {
            Mensagem = ServiceWS.GetMensagems(chat);
        }
        private void BtnEnviar()
        {
            var msg = new Mensagem()
            {
                id_usuario = UsuarioUtil.GetUsuarioLogado().id,
                mensagem = TxtMensagem,
                id_chat = this.chat.id
            };
            ServiceWS.InsertMensagem(msg);
            Atualizar();
            TxtMensagem = string.Empty;
        }
        private void ShowOnScreen()
        {
            var usuario = UsuarioUtil.GetUsuarioLogado();
            SL.Children.Clear();
            foreach(var msg in Mensagem)
            {
                if(msg.usuario.id == usuario.id)
                {
                    SL.Children.Add(CriarMensagemPropria(msg));
                }
                else
                {
                    SL.Children.Add(CriarMensagemOutrosUsuarios(msg));
                }
            }
        }

        private Xamarin.Forms.View CriarMensagemPropria(Mensagem mensagem)
        {
            var layout = new StackLayout() { Padding = 5, BackgroundColor = Color.FromHex("#5ED055"), HorizontalOptions = LayoutOptions.End };
            var label = new Label() { Text = mensagem.mensagem ,TextColor = Color.White };

            layout.Children.Add(label);
            return layout;
        }


        private Xamarin.Forms.View CriarMensagemOutrosUsuarios(Mensagem mensagem)
        {
            var labelNome = new Label() { Text = mensagem.usuario.nome, FontSize = 10, TextColor = Color.FromHex("#5ED055") };
            var labelMensagem = new Label() { Text = mensagem.mensagem, TextColor = Color.FromHex("#5ED055") };

            var StLay = new StackLayout();
            StLay.Children.Add(labelNome);
            StLay.Children.Add(labelMensagem);

            var frame = new Frame() { BorderColor = Color.FromHex("#5ED055"), CornerRadius = 0, HorizontalOptions = LayoutOptions.Start };
            frame.Content = StLay;

            return frame;
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
