using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dvillavicencioExamen.Vistas;

public partial class Resumen : ContentPage
{

    public Resumen(string nombre, string apellido, string edad, string dato1, string dato, string fecha, string montoi, string pagom, string pagot)
    {
        InitializeComponent();
        txtNombre.Text = nombre;
        txtApellido.Text = apellido;
        txtEdad.Text = edad;
        txtCiudad.Text= dato1;
        txtPais.Text = dato;
        txtFecha.Text = fecha;
        txtMinicial.Text = montoi;
        txtPmensual.Text = pagom;
        txtPtotal.Text = pagot;
        

    }


    private void Llenado()
    {
       
    }


    private void btnCsesion_Clicked(object sender, EventArgs e)
    {

    }
}