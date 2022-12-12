namespace Zumarraga_EvProgreso2;

public partial class MainPage : ContentPage
{
    int opcion = 0;

    public MainPage()
	{
		InitializeComponent();
    }

    private async void Recargar(object sender, EventArgs e)
    {

        RadioButton radioButton = sender as RadioButton;
        
        await this.DisplayAlert("Confirmacion", "Desea recargar ", "No", "Si" + this.DisplayAlert("Finalizado", "Recarga exitosa", "Si"));
        
    }

}

