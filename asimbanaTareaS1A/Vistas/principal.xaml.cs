namespace asimbanaTareaS1A.Vistas;

public partial class principal : ContentPage
{
	public principal()
	{
		InitializeComponent();
	}

    private async void btnCalcular_Clicked(object sender, EventArgs e)
    {
        if (txt_nombre.Text == "" || txt_apellido.Text == "" || txt_fecha_nacimiento.Text == "" || txt_aporte.Text == "")
        {
            await DisplayAlert("Error", "Por favor llena todos los campos", "OK");
        }
        else
        {
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            int fecha_nacimiento =Convert.ToInt32( txt_fecha_nacimiento.Text);
            var fecha_actual =Convert.ToInt32( DateTime.Today.ToString("yyyy"));
            int edad = fecha_actual - fecha_nacimiento;
            double.TryParse(txt_aporte.Text, out double sueldo);
            double resultado = afiliacion(sueldo);

            vaciar();
            await DisplayAlert("Aporte", $"Bievenido : {nombre} {apellido}\nTienes {edad} años \nTu aporte mensual es de ${resultado} ", "OK");
        }

    }
    private double afiliacion(double sueldo)
    {

        double result = (sueldo * 0.0945);

        return result;
    }

    private void vaciar()
    {


        txt_nombre.Focus();
        txt_nombre.Text = "";
        txt_apellido.Text = "";
        txt_fecha_nacimiento.Text = "";
        txt_aporte.Text = "";

    }
}
