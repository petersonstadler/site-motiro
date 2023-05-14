using site_motiro.Models;
using site_motiro.Repositories.Interfaces;

namespace site_motiro.Repositories.Implementations
{
    public class ColaboradoresRepository : IColaboradoresRepository
    {
        public IEnumerable<Colaborador> GetAllColaboradores()
        {
            var colaboradores = new List<Colaborador>()
            {
                new Colaborador()
                {
                    Id = 1,
                    Nome = "Peterson",
                    Sobrenome = "Siqueira Stadler",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = "",
                    ImagePatch = "https://scontent.fldb1-1.fna.fbcdn.net/v/t39.30808-1/342426010_760132148877599_5240619343140552061_n.jpg?stp=dst-jpg_p200x200&_nc_cat=107&ccb=1-7&_nc_sid=7206a8&_nc_eui2=AeEtDHT2ZxoowRxeSfch_V7Te7b5oRCWez17tvmhEJZ7PXkSsAIzOx50oCFF25z8gf3efAEhhGg_E-m_qFzJTtcG&_nc_ohc=lSpm6yWwwdgAX9oGbuv&_nc_ht=scontent.fldb1-1.fna&oh=00_AfB4hdhHJtSzWrrUuAKmqmaX1lk1SvW9e9WPAqdNJGkS8w&oe=6463C22A"
                },
                new Colaborador()
                {
                    Id = 2,
                    Nome = "Mayara",
                    Sobrenome = "Bubna",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = ""
                },
                new Colaborador()
                {
                    Id = 3,
                    Nome = "Leticia",
                    Sobrenome = "Bubna",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = ""
                },
                new Colaborador()
                {
                    Id = 4,
                    Nome = "Janaine",
                    Sobrenome = "Ribas",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = ""
                },
                new Colaborador()
                {
                    Id = 5,
                    Nome = "Maikon",
                    Sobrenome = "Douglas",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = ""
                },
                new Colaborador()
                {
                    Id = 6,
                    Nome = "Laurene",
                    Sobrenome = "Camargo",
                    EdicoesParticipadas= new[] {"2023"},
                    Descricao = ""
                },
                new Colaborador()
                {
                    Id = 7,
                    Nome = "Natan",
                    Sobrenome = "Wesley",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = ""
                },
                new Colaborador()
                {
                    Id = 8,
                    Nome = "Henrique",
                    Sobrenome = "Proença",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = ""
                },
                new Colaborador()
                {
                    Id = 9,
                    Nome = "Paloma",
                    Sobrenome = "Freitas",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = ""
                },
                new Colaborador()
                {
                    Id = 10,
                    Nome = "Julio",
                    Sobrenome = "Cesar Dos Reis Vidal",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = ""
                },
                new Colaborador()
                {
                    Id = 11,
                    Nome = "Andressa",
                    Sobrenome = "Sanchez",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = ""
                },
                new Colaborador()
                {
                    Id = 12,
                    Nome = "Gustavo",
                    Sobrenome = "Adrian Melo De Siqueira",
                    EdicoesParticipadas= new[] {"2022"},
                    Descricao = ""
                },
            };
            return colaboradores;
        }
    }
}
