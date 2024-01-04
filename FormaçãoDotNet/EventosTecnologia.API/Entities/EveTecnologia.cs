namespace EventosTecnologia.API.Entities
{
    public class EveTecnologia
    {
        public EveTecnologia()
        {
            Palestrante = new List<EveTecPalestrante>();
            EstaDeletado = false;
        }

        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public List<EveTecPalestrante> Palestrante { get; set; }
        public bool EstaDeletado { get; set; }

        public void Update(string titulo, string descricao, DateTime dataInicio, DateTime dataTermino)
        {
            Titulo = titulo;
            Descricao = descricao;
            DataInicio = dataInicio;
            DataInicio = dataTermino;
        }

        public void Delete()
        {
            EstaDeletado = true;
        }
    }
}
