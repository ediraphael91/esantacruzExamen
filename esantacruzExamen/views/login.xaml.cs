namespace esantacruzExamen.views;

public partial class login : ContentPage
{
    // Definir la matriz de usuarios y contraseñas
    private readonly string[,] usuariosContraseñas = new string[2, 2]
    {
            { "estudiante", "moviles" },
            { "uisrael", "2024" }
    };

    public login()
    {
        InitializeComponent();
    }

    private void OnLoginClicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrasena = txtContraseña.Text;
        bool isAuthenticated = false;

        // Verificar las credenciales
        for (int i = 0; i < 2; i++)
        {
            if (usuariosContraseñas[i, 0] == usuario && usuariosContraseñas[i, 1] == contrasena)
            {
                isAuthenticated = true;
                break;
            }
        }

        if (isAuthenticated)
        {
            Navigation.PushAsync(new registro(usuario));
        }
        else
        {
            DisplayAlert("Error", "Datos incorrectos", "OK");
        }
    }
}
