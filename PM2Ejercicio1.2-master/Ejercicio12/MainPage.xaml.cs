using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio12
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnEnviar_Clicked(object sender, EventArgs e)
        {
            /*var name = nom.Text;
            var ape = nom.Text;
            var edad = nom.Text;
            var mail = nom.Text;*/

            var datos = new Datos
            { Nombres = nom.Text, Apellidos = ape.Text, Edad = edad.Text, Email = mail.Text };

            await Navigation.PushAsync(new Page2(datos));
        }
    }
}
