namespace acentenoS3B.Views;

public partial class Registrar : ContentPage
{
	public Registrar()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
		string usuario=txtUsuarior.Text;

		string contrase�a=txtContrasenar.Text;

		Navigation.PushAsync(new Views.Login(usuario,contrase�a));
    }
}