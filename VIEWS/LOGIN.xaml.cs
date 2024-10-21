

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
        string contrase�a = TxtContrasena.Text;

        if (string.IsNullOrWhiteSpace(usuario))
        {
            DisplayAlert("Error", "Por favor ingrese un usuario.", "Cerrar");
            return; 
        }

        if (string.IsNullOrWhiteSpace(contrase�a))
        {
            DisplayAlert("Error", "Por favor ingrese una contrase�a.", "Cerrar");
            return; 
        }
        
        if (usuarios.TryGetValue(usuario,out string password) && contrase�a == password)
        {
            Navigation.PushAsync(new VIEWS.HOME(usuario));
        }
        else
        {

            DisplayAlert("Error", "Usuario/Contrase�a Incorrecto", "Cerrar");
        }
    }
}