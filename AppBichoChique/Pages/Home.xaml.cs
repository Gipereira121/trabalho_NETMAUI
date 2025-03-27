namespace AppBichoChique.Pages;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}

    private async void btnVerPerfilClicked(object sender, EventArgs e)
    {

            DisplayAlert("ATENÇÃO", "Esta pagina esta em construção, embreve será disponiblizada para você", "Ok");
            return;
        

        await Navigation.PushAsync(new Pages.Home());
    }
}