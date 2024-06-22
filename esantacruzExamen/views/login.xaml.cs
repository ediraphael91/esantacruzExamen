namespace esantacruzExamen.views;

public partial class login : ContentPage
{
    public login()
    {
        InitializeComponent();
    }

    string user;
    string password;

    public login(string usuario, string contrasena)
    {
        InitializeComponent();
        user = usuario;
        password = contrasena;
    }

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        if (user == txtUsuario.Text && password == txtContraseña.Text)
        {
            Navigation.PushAsync(new resumen(user));
        }
        else
        {
            DisplayAlert("alerta", "USUARIO O CONTRASEÑA INCORRECTOS", "OK");
        }

    }


    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new registro());
    }


}