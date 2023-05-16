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
                    ImagePatch = "/images/integrantes/peterson.jpg"
                },
                new Colaborador()
                {
                    Id = 2,
                    Nome = "Mayara",
                    Sobrenome = "Bubna",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = "",
                    ImagePatch = "/images/integrantes/mayara.jpg"
                },
                new Colaborador()
                {
                    Id = 3,
                    Nome = "Leticia",
                    Sobrenome = "Bubna",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = "",
                    ImagePatch = "/images/integrantes/leticia.jpg"
                },
                new Colaborador()
                {
                    Id = 4,
                    Nome = "Janaine",
                    Sobrenome = "Ribas",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = "",
                    ImagePatch = "/images/integrantes/jana.jpg"
                },
                new Colaborador()
                {
                    Id = 5,
                    Nome = "Maikon",
                    Sobrenome = "Douglas",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = "",
                    ImagePatch = "/images/integrantes/maikon.jpg"
                },
                new Colaborador()
                {
                    Id = 6,
                    Nome = "Laurene",
                    Sobrenome = "Camargo",
                    EdicoesParticipadas= new[] {"2023"},
                    Descricao = "",
                    ImagePatch = "/images/integrantes/laurene.jpg"
                },
                new Colaborador()
                {
                    Id = 7,
                    Nome = "Natan",
                    Sobrenome = "Wesley",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = "",
                    ImagePatch = "/images/integrantes/natan.jpg"
                },
                new Colaborador()
                {
                    Id = 8,
                    Nome = "Henrique",
                    Sobrenome = "Proença",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = "",
                    ImagePatch = "/images/integrantes/soriso.jpg"
                },
                new Colaborador()
                {
                    Id = 9,
                    Nome = "Paloma",
                    Sobrenome = "Freitas",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = "",
                    ImagePatch = "/images/integrantes/paloma.jpg"
                },
                new Colaborador()
                {
                    Id = 10,
                    Nome = "Julio",
                    Sobrenome = "Cesar Dos Reis Vidal",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = "",
                    ImagePatch = "/images/integrantes/julio.jpg"
                },
                new Colaborador()
                {
                    Id = 11,
                    Nome = "Andressa",
                    Sobrenome = "Sanchez",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = "",
                    ImagePatch = "/images/integrantes/andressa.jpg"
                },
                new Colaborador()
                {
                    Id = 12,
                    Nome = "Gustavo",
                    Sobrenome = "Adrian Melo De Siqueira",
                    EdicoesParticipadas= new[] {"2022"},
                    Descricao = "",
                    ImagePatch = "/images/integrantes/gustavo.jpg"
                }
            };
            return colaboradores;
        }
    }
}
