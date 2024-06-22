

namespace esantacruzExamen.views;


    public partial class registro : ContentPage
{
    private const double CostoCurso = 1500;
    private const double InteresCuotas = 0.04; // 4% de interés por cuota

    public registro(string nombreUsuario)
    {
        InitializeComponent();
        lblUsuarioConectado.Text = $"Usuario conectado: {nombreUsuario}";
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        double montoInicial;
        if (!double.TryParse(txtMonto.Text, out montoInicial) || montoInicial <= 0)
        {
            DisplayAlert("Error", "Ingrese un monto válido para la inscripción.", "OK");
            return;
        }

        double saldoRestante = CostoCurso - montoInicial;
        double cuota = saldoRestante / 4;
        double cuotaConInteres = cuota * (1 + InteresCuotas);

        txtCalculo.Text = $"{cuotaConInteres:C2} por cada una de las 4 cuotas";
        

    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        var nombre = txtNombre.Text;
        var apellido = txtApellido.Text;
        var edad = txtEdad.Text;
        var fecha = dpFecha.Date.ToString("MM/dd/yyyy");
        var pais = pkPaises.SelectedItem?.ToString();
        var ciudad = pkCiudades.SelectedItem?.ToString();
        var montoInicialStr = txtMonto.Text;

        // Validación y conversión del monto inicial
        if (!double.TryParse(montoInicialStr, out double montoInicial) || montoInicial <= 0)
        {
            DisplayAlert("Error", "Ingrese un monto válido para la inscripción.", "OK");
            return;
        }

        // Cálculo del pago mensual con intereses
        double saldoRestante = CostoCurso - montoInicial;
        double cuota = saldoRestante / 4;
        double cuotaConInteres = cuota * (1 + InteresCuotas);

        // Cálculo del pago total
        double pagoTotal = montoInicial + (cuotaConInteres * 4);

        string resumen = $"Nombre: {nombre}\nApellido: {apellido}\nEdad: {edad}" +
                         $"\nFecha: {fecha}\nPaís: {pais}\nCiudad: {ciudad}" +
                         $"\nMonto Inicial: {montoInicial:C2}" +
                         $"\nPago Mensual: {cuotaConInteres:C2} (4 cuotas)" +
                         $"\nPago Total: {pagoTotal:C2}";

        DisplayAlert("Resumen del Estudiante", resumen, "OK" );
    }
}