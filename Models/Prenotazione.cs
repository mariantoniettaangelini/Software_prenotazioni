namespace Software_prenotazioni.Models
{
    public class Prenotazione
    {
        public int idPrenotazione { get; set; }
        public int idCliente { get; set; }
        public int idCamera { get; set; }
        public DateTime DataPrenotazione { get; set; }
        public DateTime InizioSoggiorno { get; set; }
        public DateTime FineSoggiorno { get; set; }
        public decimal Caparra {  get; set; }
        public decimal Tariffa { get; set; }
        public string TipoPensione { get; set; }
    }
}
