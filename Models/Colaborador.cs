using Microsoft.AspNetCore.Mvc;
using site_motiro.Repositories.Interfaces;

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

        public string FraseDeParticipação([FromServices] IGeralRepository repository)
        {
            var frase = String.Empty;
            var edicoesRealizadas = repository.GetEditions();
            List<string> participadas = new List<string>();
            List<string> naoParticipadas = new List<string>();

            foreach (var edicao in EdicoesParticipadas)
            {
                if (edicoesRealizadas.Contains(edicao))
                {
                    participadas.Add(edicao);
                }
                else
                {
                    naoParticipadas.Add(edicao);
                }
            }

            if (!naoParticipadas.Any())
                return $"{Nome} participou da organização de todas as edições do Motirô.";
            else
            {
                frase = $"{Nome} não participou da organização de todas as edições do Motirô, participou apenas das edições: ";
                var ultima = participadas.Last();
                foreach(var edicao in participadas)
                {
                    if (edicao.Equals(ultima))
                    {
                        frase += edicao + ".";
                        continue;
                    }
                    frase += edicao + ", ";
                }
            }

            return frase;
        }
    }
}
