using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EnlaceDeDatos
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void OnClicked(object sender, EventArgs e)
        {
            var datos1 = Resources["datos1"] as Datos;
            datos1.Discos.Add(new Disco() { Banda = "Nirvana", Titulo = "Nevermind" });


        }
    }
}
