using MauiEventos.Models;

namespace MauiEventos.Views;

public partial class Contratacao : ContentPage
{
	App PropriedadesApp;
	public Contratacao()
	{
		InitializeComponent();
		PropriedadesApp = (App)Application.Current;
		pck_evento.ItemsSource = PropriedadesApp.lista_eventos;
		pck_locais.ItemsSource = PropriedadesApp.lista_locais;
		dtpck_inicio.MinimumDate = DateTime.Now;
		dtpck_inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

		dtpck_termino.MinimumDate = dtpck_inicio.Date.AddDays(1);
		dtpck_termino.MaximumDate = dtpck_inicio.Date.AddMonths(2);
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		try
		{
			Registro x = new Registro
			{
				LocalSelecionado = (Local)pck_evento.SelectedItem,
				Salao = (Local)pck_locais.SelectedItem,
				QntLocais = Convert.ToInt32(stp_participantes.Value),
				QntParticipantes = Convert.ToInt32(stp_participantes.Value),												
				DataInicio = dtpck_inicio.Date,
				DataTermino = dtpck_termino.Date,

			};
			await Navigation.PushAsync(new Total()
			{
				BindingContext = x
			});
		}
		catch (Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "OK");
		}
	}

	private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
	{
		DatePicker elemento = sender as DatePicker;
		DateTime data_selecionada_inicio = elemento.Date;
		dtpck_termino.MinimumDate = data_selecionada_inicio.AddDays(1);
		dtpck_termino.MaximumDate = data_selecionada_inicio.AddMonths(2);
	}

}