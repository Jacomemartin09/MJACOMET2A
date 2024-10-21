using Calificacion_Uisrael.VIEWS;

namespace Calificacion_Uisrael
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LOGIN());
        }
    }
}
