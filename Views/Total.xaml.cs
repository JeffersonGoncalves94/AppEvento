namespace MauiEventos.Views;

public partial class Total : ContentPage
{
	public Total()
	{
		InitializeComponent();

	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PopAsync();
		} catch(Exception ex)
		{
			DisplayAlert("Ops",ex.Message,"OK");
		}
    }
}