namespace jcajamarcaTS2.Vistas;

public partial class vLogin : ContentPage
{
	public vLogin()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        String usuario = "uisrael";
        string contraseña = "1234";
        if (usuario == txtUsuario.Text && contraseña == txtContraseña.Text)
        {
            Navigation.PushAsync(new vElementos());

        }
        else
        {
            DisplayAlert("Alerta", "usuario/contraseña incorrectos", "Cerrar");
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }
    }
}