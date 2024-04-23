using JMacasT2.Vistas;

namespace JMacasT2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new AppShell();
            //MainPage = new Vistas.Vinicio();
           // MainPage = new Vistas.Login();
           MainPage = new NavigationPage(new Vistas.Login());

        }
    }
}
