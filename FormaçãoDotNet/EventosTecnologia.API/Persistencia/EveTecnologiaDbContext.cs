using EventosTecnologia.API.Entities;

namespace EventosTecnologia.API.Persistencia
{
    public class EveTecnologiaDbContext
    {
        public List<EveTecnologia> EveTecnologia { get; set; }
        public EveTecnologiaDbContext()
        {
            EveTecnologia = new List<EveTecnologia>();
        }
    }
}
