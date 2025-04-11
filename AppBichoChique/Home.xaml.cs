namespace AppBichoChique;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}

    private async void btnMeusPetsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MeusPets());
        return;
    }


    private async void btnVerPerfilClicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Perfil());
        return;
    }


    private async void btnVerClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SobreNosxaml());
    }

    private async void btnConversarClicked(object sender, EventArgs e)
    {

        DisplayAlert("ERRO", "Houve um problema e esta pagina não está disponível no momento, tente novamente mais tarde!", "Ok");
        return;


        await Navigation.PushAsync(new Home());
    }
}