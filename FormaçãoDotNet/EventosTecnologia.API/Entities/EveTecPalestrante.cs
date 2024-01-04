namespace EventosTecnologia.API.Entities
{
    public class EveTecPalestrante
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string TituloDaPalestra { get; set; }
        public string  DescricaoPalestra { get; set; }
        public  string PerfilLinkedIn { get; set; }
    }
}
