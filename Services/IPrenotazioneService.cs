using Software_prenotazioni.Models;

namespace Software_prenotazioni.Services
{
    public interface IPrenotazioneService
    {
        Prenotazione GetPrenotazioneById(int id);
        IEnumerable<Prenotazione> GetPrenotazioneByCliente(string CodiceFiscale);
        void GetPrenotazioneByPensione(string TipoPrenotazione);

    }
}
