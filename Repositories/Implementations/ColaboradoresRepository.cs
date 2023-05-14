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
                    Descricao = "",
                    ImagePatch = "https://scontent.fldb1-1.fna.fbcdn.net/v/t39.30808-6/238540928_4158075150980824_7944457469742579023_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeH8-xPdVaJD9ebux7mxw-nCG6BSTrPkqp0boFJOs-SqnUFAi91_qiTNQjfx73hTfTw0ls9d9vMu5IDuG0yQ7fCs&_nc_ohc=nnsU-4dPDfQAX99_KdM&_nc_ht=scontent.fldb1-1.fna&oh=00_AfDPI6v3mnwoiq4PtMPa3M8lWCuUeTobDG0SptZ84rsRaw&oe=6465E0D9"
                },
                new Colaborador()
                {
                    Id = 3,
                    Nome = "Leticia",
                    Sobrenome = "Bubna",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = "",
                    ImagePatch = "https://scontent.fldb1-1.fna.fbcdn.net/v/t39.30808-6/322077028_1190723171551622_9055802601417962_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGKylMPq_YcVN-pVF_kUurisfqcX3gUX6qx-pxfeBRfqqNwz2gXBitAi8aA09aaSitu9azzxoWOdt8S099ZsjTT&_nc_ohc=Aguv1XjgiWgAX90H-hl&_nc_ht=scontent.fldb1-1.fna&oh=00_AfA6wO_UYa6pS0tR_lzdW_DzHKWKVE4LW3ULJxwDNabFeQ&oe=6465F53B"
                },
                new Colaborador()
                {
                    Id = 4,
                    Nome = "Janaine",
                    Sobrenome = "Ribas",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = "",
                    ImagePatch = "https://scontent.fldb1-1.fna.fbcdn.net/v/t39.30808-6/318420119_5657972564322111_5986322617300966914_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeFn6uEGitDFLJcFoGqGMDovQdDU7Whvyb5B0NTtaG_JvgdUbCnfySvPNl3emXqP5CDmhViuGHs9qlD4K2l50vyS&_nc_ohc=qrTCPQ8HvSwAX8XOowj&_nc_ht=scontent.fldb1-1.fna&oh=00_AfCm2uKX6fm14GEofszpbyME5tamxfrp0IgoAlnDLIvadw&oe=64663F60"
                },
                new Colaborador()
                {
                    Id = 5,
                    Nome = "Maikon",
                    Sobrenome = "Douglas",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = "",
                    ImagePatch = "https://scontent.fldb1-1.fna.fbcdn.net/v/t39.30808-6/285568719_987472015302665_6570854453816147707_n.jpg?_nc_cat=101&ccb=1-7&_nc_sid=174925&_nc_eui2=AeGNkp5F6BrQ_wVcDUTJlI7B-gI61UcLXfr6AjrVRwtd-oY42LLX1cuiuiG0v6BldoAZgJUDqFaNYvNaFWYhDMbg&_nc_ohc=OEZwsPLviJgAX-2URLf&_nc_ht=scontent.fldb1-1.fna&oh=00_AfBcTI-I4Pli_9v8IhwVRXghwFEC9_LPLgHzuSOQH5wjBQ&oe=6465AF8B"
                },
                new Colaborador()
                {
                    Id = 6,
                    Nome = "Laurene",
                    Sobrenome = "Camargo",
                    EdicoesParticipadas= new[] {"2023"},
                    Descricao = "",
                    ImagePatch = "https://scontent.fldb1-1.fna.fbcdn.net/v/t1.6435-9/135937722_2740662572821223_8652135783776193487_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeE_E4IcXzpZvVlbvRaa6MtmlAoz6wxUioqUCjPrDFSKim8FonYeAcmIPciVjo4vRx-gZ7V3hvPb-Dbc68EKnOke&_nc_ohc=2eKoXSAAQMYAX8I4PEk&_nc_ht=scontent.fldb1-1.fna&oh=00_AfBHv-e7SRi91dddCQ5AAIHUOHAacmmbWy-lLEqo8OPpNQ&oe=64889C09"
                },
                new Colaborador()
                {
                    Id = 7,
                    Nome = "Natan",
                    Sobrenome = "Wesley",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = "",
                    ImagePatch = "https://scontent.fldb1-1.fna.fbcdn.net/v/t39.30808-6/277584100_2849809215165863_3381792307360634923_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeEbITSxfQhOK67CZZ7ns6vXFIkuId-HnNIUiS4h34ec0r2zqNlEH1PK3SG02NdC_QiLM2_Gbc-EUY1NXec-Xb1h&_nc_ohc=1x3eH8F1TbIAX-etiVN&_nc_ht=scontent.fldb1-1.fna&oh=00_AfD8I-ys3H7uH1hnO2kmbon17nM4KumYfXRpJ-B9yy6llg&oe=64665A87"
                },
                new Colaborador()
                {
                    Id = 8,
                    Nome = "Henrique",
                    Sobrenome = "Proença",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = "",
                    ImagePatch = "https://scontent.fldb1-1.fna.fbcdn.net/v/t1.6435-9/120932877_3084901844947632_211336403463247655_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=174925&_nc_eui2=AeFp_7C74UpL0lO6GMEvPv-TbzH0qqgzzpdvMfSqqDPOl7bzcgpMmgtlhWlMcrJwB-FfcYrET7PiYgxJl0uicTKv&_nc_ohc=eDnjRpIHg9sAX9wwAnw&_nc_ht=scontent.fldb1-1.fna&oh=00_AfAB9PK1RBtOw-xQd-KJtRuSFllBqakeMqjzZellfhUJ2Q&oe=6488AEDE"
                },
                new Colaborador()
                {
                    Id = 9,
                    Nome = "Paloma",
                    Sobrenome = "Freitas",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = "",
                    ImagePatch = "https://instagram.fldb1-1.fna.fbcdn.net/v/t51.2885-15/146000181_263134038578564_3638900278375483876_n.jpg?stp=dst-jpg_e15&_nc_ht=instagram.fldb1-1.fna.fbcdn.net&_nc_cat=108&_nc_ohc=xn6IYgJgTr8AX9OxNH5&edm=ACWDqb8BAAAA&ccb=7-5&ig_cache_key=MjUwMjgyNzA3MTQ5MTgxNDQ3Nw%3D%3D.2-ccb7-5&oh=00_AfBuoB8dZk2Ckpn45cct84REJOw4-xUkl40xmGRj0NhaiA&oe=6466D97D&_nc_sid=1527a3"
                },
                new Colaborador()
                {
                    Id = 10,
                    Nome = "Julio",
                    Sobrenome = "Cesar Dos Reis Vidal",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = "",
                    ImagePatch = "https://scontent.fldb1-1.fna.fbcdn.net/v/t39.30808-6/290731712_3101278810134749_661609092139185394_n.jpg?_nc_cat=110&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeECJGNdwS3nF47F249KpTfpKoaLnL_IvJ4qhoucv8i8nnVxN4VGoGWL-m8Pu6VHuyJ-96sPO1UdCWMUi6Zl92HY&_nc_ohc=8m_MBamzR_MAX_cogJP&_nc_ht=scontent.fldb1-1.fna&oh=00_AfAjY7XrvU9ibiSmAk65nflDnJQxt9jPzXeTFpVYV9JPGA&oe=6465E5CD"
                },
                new Colaborador()
                {
                    Id = 11,
                    Nome = "Andressa",
                    Sobrenome = "Sanchez",
                    EdicoesParticipadas= new[] {"2022", "2023"},
                    Descricao = "",
                    ImagePatch = "https://instagram.fldb1-1.fna.fbcdn.net/v/t51.2885-15/180686907_514237023068280_538713624995557377_n.jpg?stp=dst-jpg_e35&_nc_ht=instagram.fldb1-1.fna.fbcdn.net&_nc_cat=100&_nc_ohc=mnqO4uITPt8AX9e-3wd&edm=ABmJApABAAAA&ccb=7-5&ig_cache_key=MjU2NDE5Njg1OTQ4ODg1ODE4Ng%3D%3D.2-ccb7-5&oh=00_AfDbW4hN7vS1et6W0YJkkC2BrT01ZtLgDXlkQxxHIXJneA&oe=6465D902&_nc_sid=6136e7"
                },
                new Colaborador()
                {
                    Id = 12,
                    Nome = "Gustavo",
                    Sobrenome = "Adrian Melo De Siqueira",
                    EdicoesParticipadas= new[] {"2022"},
                    Descricao = "",
                    ImagePatch = "https://scontent.fldb1-1.fna.fbcdn.net/v/t39.30808-6/339407264_1228599951362195_6301906614412052869_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeFqb6HfaPiQwekOffrpvAiqO02oJMKRW-s7TagkwpFb6yHs92VuICfKDx4_82R7stiyKrecmJQ0jovDyxq7aKtQ&_nc_ohc=TCfW5BGAJB8AX_BUXC5&_nc_ht=scontent.fldb1-1.fna&oh=00_AfBtqyH1UyWu_MCWoC96d4dBWvJvO0Z-hgNe-9ycICVySg&oe=64659081"
                },
            };
            return colaboradores;
        }
    }
}
