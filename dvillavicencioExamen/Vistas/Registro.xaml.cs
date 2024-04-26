namespace dvillavicencioExamen.Vistas;

public partial class Registro : ContentPage
{
	public Registro(string usuario)
	{
		InitializeComponent();
        DisplayAlert("Alerta", "Bienvenido " + usuario, "Cerrar");
        lblUsuario.Text = "Usuario conectado " + usuario;

       
    }

    private void Calcular()
    {
        if (double.TryParse(txtMontoI.Text, out double valor1))
        {
            if (valor1 >= 0 && valor1 <= 1500)
            {
                double calculo = ((1500 - valor1) / 4 + 60);
                double calculo1 = (4 * calculo) + valor1;
                txtPagoM.Text = calculo.ToString();
                txtPagoT.Text = calculo1.ToString();
            }
            else
            {
                txtPagoM.Text = "Ingrese un valor entre 0 y 1500";
            }
        }
        else
        {
            txtPagoM.Text = "Ingrese valores numéricos válidos";
        }
    }

    

    private void btnCalculo_Clicked(object sender, EventArgs e)
    {
        Calcular();
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        
       
        if (pkPais.SelectedIndex == -1)
        {
            DisplayAlert("Alerta", "No existe dato", "Cerrar");
        }
        if (pkCiudad.SelectedIndex == -1)
        {
            DisplayAlert("Alerta", "No existe dato", "Cerrar");
        }
        else
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string edad = txtEdad.Text;
            string dato = pkPais.Items[pkPais.SelectedIndex].ToString();
            string dato1 = pkCiudad.Items[pkCiudad.SelectedIndex].ToString();
            string fecha = dpFecha.Date.ToString("MM/dd/yyyy");
            string montoi = txtMontoI.Text;
            string pagom = txtPagoM.Text;
            string pagot = txtPagoT.Text;

            Navigation.PushAsync(new Resumen(nombre, apellido, edad, dato, dato1,fecha,montoi,pagom,pagot));
            
        }

    }
}