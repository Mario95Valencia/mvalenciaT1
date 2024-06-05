namespace mvalenciaT1.View;

public partial class vHome : ContentPage
{
	public vHome()
	{
		InitializeComponent();
	}

    private void btnGenerar_Clicked(object sender, EventArgs e)
    {
        double salario = Convert.ToDouble(txtSalario.Text);
        double aporte = salario / 0.0945;
        DisplayAlert("Mensaje", "Bienvenido" + txtNombre.Text + " " + txtApellido.Text + "\n Tienes " + txtEdad.Text + " años \n Tu aporte mensual es: " + aporte, "Gracias");
    }
}