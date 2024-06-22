

namespace esantacruzExamen.views;

public partial class resumen : ContentPage
{
    public resumen(string nombre, string apellido, string edad, string fecha, string pais, string ciudad, string montoInicial, string pagoMensual, string pagoTotal)
    {
        InitializeComponent();

        // Asignar los valores a los controles de la interfaz
        txtNombre.Text = nombre;
        txtApellido.Text = apellido;
        txtEdad.Text = edad;
        txtFecha.Text = fecha;
        txtPais.Text = pais;
        txtCiudad.Text = ciudad;
        txtMontoInicial.Text = montoInicial;
        txtPagoMensual.Text = pagoMensual;
        txtPagoTotal.Text = pagoTotal;
    }
}
