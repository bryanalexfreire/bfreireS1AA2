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
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }
        private void btnCalcularAnio_Clicked_1(object sender, EventArgs e)
        {
            int edad = Convert.ToInt32(txtDatoEdad.Text);
            int anionacimiento = Convert.ToInt32(DateTime.Now.Year) - edad;
            DisplayAlert("Año de nacimiento", Convert.ToString(anionacimiento), "Cancel"); 
        }

        private void btnsaludo_Clicked(object sender, EventArgs e)
        {
            string nombre = txtDatoNombre.Text;
            string apellido = txtDatoApellido.Text;
            int edad = Convert.ToInt32(txtDatoEdad.Text);


            DisplayAlert("Saludo", "Hola " + nombre + " " + apellido + "." + "Tienes " + edad + " " + "años de edad", "Cancel");
        }
    }
}