using System.Text.RegularExpressions;

namespace AppBichoChique.Pages;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void btnLogarOnClicked(object sender, EventArgs e)
    {
        
        string senha = etrSenha.Text;


        if (string.IsNullOrWhiteSpace(senha))
        {
            DisplayAlert("ERRO", "Emial ou Senha Inválidos!", "Ok");
            return;
        }

        await Navigation.PushAsync(new Pages.Home());
    }

}