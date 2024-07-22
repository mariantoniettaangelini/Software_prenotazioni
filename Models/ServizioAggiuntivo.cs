namespace Software_prenotazioni.Models
{
    public class ServizioAggiuntivo
    {
        public int idServizio {  get; set; }
        public int idPrenotazione { get; set; }
        public int Quantita { get; set; }
        public decimal Prezzo { get; set; }
        public string DescrizioneServizio { get; set; }

    }
}
