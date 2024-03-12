namespace aula02;
public class Data
{
    private int dia;
    private int mes;
    private int ano;
    private int hora;
    private int minuto;
    private int segundo;

    public static readonly int FORMATO_12H = 12;
    public static readonly int FORMATO_24H = 24;

    public Data(int dia, int mes, int ano)
    {
        this.dia = dia;
        this.mes = mes;
        this.ano = ano;
    }

    public Data(int dia, int mes, int ano, int hora, int minuto, int segundo) : this(dia, mes, ano)
    {
        this.hora = hora;
        this.minuto = minuto;
        this.segundo = segundo;
    }

    public int Dia
    {
        get { return dia; }
    }

    public int Mes
    {
        get { return mes; }
    }

    public int Ano
    {
        get { return ano; }
    }

    public int Hora
    {
        get { return hora; }
    }

    public int Minuto
    {
        get { return minuto; }
    }

    public int Segundo
    {
        get { return segundo; }
    }

    public void Imprimir(int formatoHora)
    {
        string data = $"{dia}/{mes}/{ano}";
        string horario = "";

        if (hora != 0 || minuto != 0 || segundo != 0)
        {
            if (formatoHora == FORMATO_12H)
            {
                string periodo = hora < 12 ? "AM" : "PM";
                horario = $"{hora % 12}:{minuto}:{segundo} {periodo}";
            }
            else
            {
                horario = $"{hora}:{minuto}:{segundo}";
            }
        }

        Console.WriteLine($"{data} {horario}");
    }
}
