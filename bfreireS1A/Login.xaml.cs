using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bfreireS1A
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "uisrael";
            string contrasena = "12345";
            if (txtUsuario.Text == usuario && txtContraseña.Text == contrasena)
            {
            Navigation.PushAsync(new Registro ());
            }
            else
            {
                DisplayAlert("Alerta", "Usuario o contraseña incorrectos", "Cerrar")
            }
        }
    }
}