namespace AppBichoChique.Pages;

public partial class Cadastro : ContentPage
{
	public Cadastro()
	{
		InitializeComponent();
	}

    private async void btnCadastOnClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pages.Home());

    }

       
    

}