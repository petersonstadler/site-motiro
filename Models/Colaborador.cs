namespace site_motiro.Models
{
    public class Colaborador
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Sobrenome { get; set; } = string.Empty;
        public string[] EdicoesParticipadas { get; set; } = Array.Empty<string>();
        public string Descricao { get; set; } = string.Empty;
        public string ImagePatch { get; set; } = string.Empty;
    }
}
