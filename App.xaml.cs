using MauiEventos.Models;

namespace MauiEventos;

public partial class App : Application
{	
	public List<Local> lista_eventos = new List<Local>
	{
		new Local()
		{
			Descricao = "Casamento",
			ValorParticipante = 50,
		},
		new Local()
		{
			Descricao = "Aniversário",
			ValorParticipante = 40.0,
		},
		new Local()
		{
			Descricao = "Chá de Bebê",
			ValorParticipante = 25.0,
		},
		new Local()
		{
			Descricao = "Reunião",
			ValorParticipante = 70.0,
		},
		new Local()
		{
			Descricao = "Avulso",
			ValorParticipante = 30.0,
		},

	};

	public List<Local> lista_locais = new List<Local>
	{
		new Local()
		{
			Locais = "Salão Premium",
			ValorLocais = 60,
			
		},
		new Local()
		{
			Locais = "Salão Glamour",
			ValorLocais = 55,
		},
		new Local()
		{
			Locais = "Salão de Luxuoso",
			ValorLocais = 50,
		},
		
	};

	public App()
	{
		InitializeComponent();
		MainPage = new NavigationPage(new Views.Contratacao());
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		var window = base.CreateWindow(activationState);
		window.Width = 400;
		window.Height = 600;

		return window;
	}
}