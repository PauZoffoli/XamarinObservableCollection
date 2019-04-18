using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EnlaceDeDatos
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClicked(object sender, EventArgs e)
        {
            var datos1 = Resources["datos1"] as Datos;
            datos1.Discos.Add(new Disco() { Banda = "Nirvana", Titulo = "Nevermind", Genero = "Jazz" });
        }

        private void OnClickedChange(object sender, EventArgs e)
        {
            var disco1 = Resources["disco1"] as Disco;
            disco1.Titulo = "ASD";
        }
    }
}
