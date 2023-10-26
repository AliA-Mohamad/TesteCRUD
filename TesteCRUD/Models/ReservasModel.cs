namespace TesteCRUD.Models; 
public class ReservasModel
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Quarto { get; set; }
    public DateTime DataEntrada { get; set; } = DateTime.Now;
    public DateTime? DataSaida { get; set; }
}
