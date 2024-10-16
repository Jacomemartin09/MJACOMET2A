

namespace Calificacion_Uisrael.VIEWS;

public partial class HOME : ContentPage
{
    public HOME()
    {
        InitializeComponent();
    }

    private void BtnEjecutar_Clicked(object sender, EventArgs e)
    {
        double Seguimiento1 = Convert.ToDouble(TxtSeguimiento1.Text);
        double Examen1 = Convert.ToDouble(TxtExamen1.Text);
        double Seguimiento2 = Convert.ToDouble(TxtSeguimiento2.Text);
        double Examen2 = Convert.ToDouble(TxtExamen2.Text);
        string FechaFinal = Fecha.Date.ToString("dd/MM/yyyy");
        double NotaSeguimiento1 = (Seguimiento1 * 0.3);
        double NotaExamen1 = (Examen1 * 0.2);
        double NotaParcial1 = (NotaSeguimiento1 + NotaExamen1);
        double NotaSeguimiento2 = (Seguimiento2 * 0.3);
        double NotaExamen2 = (Examen2 * 0.2);
        double NotaParcial2 = (NotaSeguimiento2 + NotaExamen2);
        double NotaFinal = (NotaParcial1 + NotaParcial2);
        string Estado;


        if (
            Seguimiento1 > 10 || Seguimiento1 <= 0||
            Examen1 > 10 || Examen1 <= 0|| 
            Examen2 > 10 || Examen2 <= 0||
            Seguimiento2 > 10 ||Seguimiento2 <= 0
            )
        {
            DisplayAlert("Datos Erroneos", "Ingresar un valor entre '0' y '10' en las notas", "cerrar");
        }
        else
        {
            if (NotaFinal >= 7)
            {
                Estado = "Aprobado";
            }
            else
            {
                if (NotaFinal <= 6.99 && NotaFinal >= 5)
                {
                    Estado = "Complementario";

                }
                else
                {
                    Estado = "Reprobado";
                }

            }

            if (pkEstudiantes.SelectedItem != null)
            {

                string Nombre = pkEstudiantes.SelectedItem.ToString();

                DisplayAlert("Calificaciones", "\nNOTAS FINALES \n " +
                         "\n\n Nombre: " + Nombre + "" +
                         "\n\n Fecha: " + FechaFinal + "" +
                         "\n\n Nota Parcial 1: " + NotaParcial1 + "" +
                         "\n\n Nota Parcial 2: " + NotaParcial2 + "" +
                         "\n\n Nota Final: " + NotaFinal + "" +
                         "\n\n Estado: " + Estado, " Cerrar");

            }
            else
            {
                DisplayAlert("Alerta", "Seleccione un estudiante.", "cerrar");
            }

        }
    }
}

