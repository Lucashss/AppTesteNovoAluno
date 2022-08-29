using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTesteNovoAluno
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;


        }

        void OnEntryCompleted(object sender, EventArgs e)
        {

        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            if (id.Text.Equals("admin") && pass.Text.Equals("senha@dmin"))
            {
                await DisplayAlert("Parabéns", "Login realizado com sucesso", "OK");
            }
            else
            {
                await DisplayAlert("Alerta", "Login não autorizado", "OK");
            }
        }

        void Button_Clicked_1(object sender, EventArgs e)
        {
            id.Text = "";
            pass.Text = "";
            id.Focus();
        }

        async void Button_Clicked_2(object sender, EventArgs e)
        {
            await DisplayAlert("Autores", "Lucas Henrique \nNikolas Caldeira", "OK");
        }
    }
}
