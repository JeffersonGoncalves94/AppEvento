using MauiEventos.Models;
using MauiEventos.Views;

namespace MauiEventos.Models;

public class Registro
{
    public Local LocalSelecionado {get; set;} 
    public Local Salao {get; set;} 
    public int QntParticipantes {get; set;}
    public int QntLocais {get; set;}
    public DateTime DataInicio {get; set;}
    public DateTime DataTermino {get; set;}

    public double Dias
    {
        get => DataTermino.Subtract(DataInicio).Days;
    }
    public double ValorTotal
    {
        get
        {                    
            double valor_participantes = QntParticipantes * LocalSelecionado.ValorParticipante;             
   

            double total = (valor_participantes + Salao.ValorLocais ) * Dias;

            return total;
        }
    }
}