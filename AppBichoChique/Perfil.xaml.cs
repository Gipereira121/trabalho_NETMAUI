namespace AppBichoChique;

public partial class Perfil : ContentPage
{
	public Perfil()
	{
		InitializeComponent();
	}
	private async void btnPetsClickled(object sender, EventArgs e) 
	{ 
            await Navigation.PushAsync(new MeusPets());
            return;
	}

    private async void btnEditarClickled(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Home());
        return;
    }


    
}