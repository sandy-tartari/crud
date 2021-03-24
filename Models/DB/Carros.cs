namespace crud.Models.DB
{
    public class Carros
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoLancamento { get; set; }
        public int AnoMontagem { get; set; }
        public string Chassis { get; set; }
    }
}