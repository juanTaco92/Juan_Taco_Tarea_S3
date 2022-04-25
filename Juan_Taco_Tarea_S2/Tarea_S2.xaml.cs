using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Juan_Taco_Tarea_S2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tarea_S2 : ContentPage
    {
        public Tarea_S2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double notaUno = Convert.ToDouble(txtNotaUno.Text);
                double notaExaUno = Convert.ToDouble(txtNotaExaUno.Text);
                double datoResultadoUno = (notaUno*0.3) + (notaExaUno*0.2);
                txtDatoResultadoUno.Text = datoResultadoUno.ToString();

                double notaDos = Convert.ToDouble(txtNotaDos.Text);
                double notaExaDos = Convert.ToDouble(txtNotaExaDos.Text);
                double datoResultadoDos = (notaDos * 0.3) + (notaExaDos * 0.2);
                txtDatoResultadoDos.Text = datoResultadoDos.ToString();

                double datoResultadoFinal = datoResultadoUno + datoResultadoDos;
                txtNotaFinal.Text = datoResultadoFinal.ToString();

                if (datoResultadoFinal >= 7)
                {

                    DisplayAlert("APROBADO", "Su nota final es: " + txtNotaFinal.Text, "Cerrar");
                }
                else if (datoResultadoFinal >= 5 && datoResultadoFinal <= 6.9)
                {
                    DisplayAlert("COMPLEMENTARIO", "Su nota final es: " + txtNotaFinal.Text, "Cerrar");
                }
                else
                {
                    DisplayAlert("REPROBADO", "Su nota final es: " + txtNotaFinal.Text, "Cerrar");
                }
                
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "Cerrar");
            }

        }
    }
}