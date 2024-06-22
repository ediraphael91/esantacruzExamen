namespace esantacruzExamen.views;

public partial class resumen : ContentPage
{
    public resumen(String nombre)
    {
        InitializeComponent();
        lblNombre.Text = "Usuario conectado: " + nombre;
    }
}