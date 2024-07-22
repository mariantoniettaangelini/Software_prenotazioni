using Software_prenotazioni.Models;

namespace Software_prenotazioni.Services
{
    public class PrenotazioneService : SqlServerServiceBase, IPrenotazioneService
    {
        public PrenotazioneService(IConfiguration configuration) : base(configuration)
        {
        }

        public IEnumerable<Prenotazione> GetPrenotazioneByCliente(string CodiceFiscale)
        {
            throw new NotImplementedException();
        }

        public Prenotazione GetPrenotazioneById(int id)
        {
            throw new NotImplementedException();
        }

        public void GetPrenotazioneByPensione(string TipoPrenotazione)
        {
            throw new NotImplementedException();
        }
    }
}
