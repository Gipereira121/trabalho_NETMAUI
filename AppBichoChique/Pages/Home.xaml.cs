namespace AppBichoChique.Pages;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}

    private async void btnVerPerfilClicked(object sender, EventArgs e)
    {

            DisplayAlert("ATEN��O", "Esta pagina esta em constru��o, embreve ser� disponiblizada para voc�", "Ok");
            return;
        

        await Navigation.PushAsync(new Pages.Home());
    }
}