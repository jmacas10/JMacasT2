namespace JMacasT2.Vistas;

public partial class Login : ContentPage
{

    // Vectores que almacenan nombres de los usuarios y contrase�as
    string[] usuarios = { "Carlos", "Ana", "Jose" };
    string[] contrasenas = { "carlos123", "ana123", "jose123" };
    public Login()
	{
		InitializeComponent();
	}

 
    private void InicioSesion_Clicked_1(object sender, EventArgs e)
    {
		string users = txtUsuario.Text;
		string passwords = txtContrase�a.Text;

        bool usuarioValido = false;
        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuarios[i] == users && contrasenas[i] == passwords)
            {
                usuarioValido = true;
                break;
            }
        }

        if (usuarioValido)
		{
			Navigation.PushAsync(new Vinicio(users));
		}
		else {
			DisplayAlert("Alerta","Usuario/contrase�a incorrecto","Cerrar");
            //txtUsuario.Text = "";
            //txtContrase�a.Text = "";
		}

    }
}