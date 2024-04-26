namespace dvillavicencioExamen.Vistas;

public partial class Login : ContentPage
{

    string[] users = { "estudiante2024", "examen1", "Diego" };
    string[] passwords = { "uisrael2024", "parcial1", "2024" };

    public Login()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contraseña = txtContraseña.Text;

        bool autenticado = false;
        for (int i = 0; i < users.Length; i++)
        {
            if (usuario == users[i] && contraseña == passwords[i])
            {
                autenticado = true;
                break;
            }
        }

        // Mostrar resultado de la autenticación
        if (autenticado)
        {
            Navigation.PushAsync(new Registro(usuario));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario o contraseña incorrectos", "Aceptar");
        }

    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AcercaD());
    }
}