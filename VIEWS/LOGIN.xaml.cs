

namespace Calificacion_Uisrael.VIEWS;

public partial class LOGIN : ContentPage
{
    private Dictionary<string, string> usuarios;

    public LOGIN()
    {
		InitializeComponent();

        
        usuarios = new Dictionary<string, string>

        {
            { "Carlos","carlos123"},
            { "Ana","ana123"},
            { "Jose","jose123"}

        };




    }

    private void BtnIniciar_Clicked(object sender, EventArgs e)
    {
        string usuario = TxtUsuario.Text;
        string contraseņa = TxtContrasena.Text;

        if (string.IsNullOrWhiteSpace(usuario))
        {
            DisplayAlert("Error", "Por favor ingrese un usuario.", "Cerrar");
            return; 
        }

        if (string.IsNullOrWhiteSpace(contraseņa))
        {
            DisplayAlert("Error", "Por favor ingrese una contraseņa.", "Cerrar");
            return; 
        }
        
        if (usuarios.TryGetValue(usuario,out string password) && contraseņa == password)
        {
            Navigation.PushAsync(new VIEWS.HOME(usuario));
        }
        else
        {

            DisplayAlert("Error", "Usuario/Contraseņa Incorrecto", "Cerrar");
        }
    }
}