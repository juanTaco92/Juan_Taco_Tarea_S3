using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Juan_Taco_Tarea_S2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text;
                string password = txtPassword.Text;
                if (txtUsuario.Text == "estudiante2021" && txtPassword.Text== "uisrael2021") {
                    DisplayAlert("Bienvenido", txtUsuario.Text, "Cerrar");
                    await Navigation.PushAsync(new Tarea_S2(usuario, password));
                }
                else
                {
                    DisplayAlert("ALERTA", "Usuario o Password Incorrectos" , "Cerrar");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "Cerrar");
            }
        }
    }
}
