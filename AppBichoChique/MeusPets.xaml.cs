namespace AppBichoChique;

public partial class MeusPets : ContentPage
{
	public MeusPets()
	{
		InitializeComponent();
	}

    private async void btnCadastroOnClicked(object sender, EventArgs e)
    {
        string Nome = etrNome.Text;
        string DtNasc =  lblDtNasc.Text;
        string Especie = etrEspecie.Text;
        string Genero = etrGenero.Text;
        string Peso =  etrPeso.Text;
        string Porte =  etrPorte.Text;
        string Raca = etrRaca.Text;

        DisplayAlert("CADASTRO REALIZADO", "Seus bichinho foi cadastrado com sucesso!", "Ok");
        await Navigation.PushAsync(new Home());
    }

    private async void btnVoltarOnClicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Home());
        etrNome.Text = "";
        lblDtNasc.Text = "";
        etrEspecie.Text = "";
        etrGenero.Text = "";
        etrPeso.Text = "";
        etrPorte.Text = "";
        etrRaca.Text = "";


        return;
    }
}