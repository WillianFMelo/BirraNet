using BirraNet.Infra.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace BirraNet.Infra.Data.Contexto
{
    public class GeradorDados
    {
        public static void Inicializar(IServiceProvider serviceProvider)
        {
            using (var context = new DataContext(serviceProvider.GetRequiredService<DbContextOptions<DataContext>>()))
            {
                if (context.Perguntas.Any())
                {
                    return;
                }

                CriarDadosPergunta(context);
                CriarDadosCerveja(context);

                context.SaveChanges();
            }
        }

        private static void CriarDadosPergunta(DataContext context)
        {
            var perguntaIdade = new PerguntaEntity
            {
                Id = 1,
                IdChat = 1,
                Ordem = 1,
                Texto = "Você tem 18 anos?",
                PerguntaPai = null,
                RespostaPai = null,
            };

            var perguntaNaoTemPermissao = new PerguntaEntity
            {
                Id = 2,
                IdChat = 1,
                Ordem = 1,
                Texto = "Você não tem premissão para acessar o site.",
                PerguntaPai = perguntaIdade,
                RespostaPai = "Não",
                EhSugestao = true
            };

            var perguntaTipoCerveja = new PerguntaEntity
            {
                Id = 3,
                IdChat = 1,
                Ordem = 2,
                Texto = "Qual tipo de cerveja prefere?",
                PerguntaPai = perguntaIdade,
                RespostaPai = "Sim",
            };

            var perguntaClaraEscura = new PerguntaEntity
            {
                Id = 4,
                IdChat = 1,
                Ordem = 3,
                Texto = "Prefere cerveja clara ou escura?",
                PerguntaPai = perguntaTipoCerveja,
                RespostaPai = "Amarga",
            };

            var perguntaSaborMalte = new PerguntaEntity
            {
                Id = 5,
                IdChat = 1,
                Ordem = 3,
                Texto = "Como gosta do sabor do malte?",
                PerguntaPai = perguntaTipoCerveja,
                RespostaPai = "Leve",
            };

            var sugestaoIpa = new PerguntaEntity
            {
                Id = 6,
                IdChat = 1,
                Ordem = 4,
                Texto = "Sugestão: Cerveja IPA",
                PerguntaPai = perguntaClaraEscura,
                RespostaPai = "Clara",
                EhSugestao = true
            };

            var sugestaoStout = new PerguntaEntity
            {
                Id = 7,
                IdChat = 1,
                Ordem = 4,
                Texto = "Sugestão: Cerveja Stout",
                PerguntaPai = perguntaClaraEscura,
                RespostaPai = "Escura",
                EhSugestao = true
            };

            var sugestaoPilsen = new PerguntaEntity
            {
                Id = 8,
                IdChat = 1,
                Ordem = 4,
                Texto = "Sugestão: Cerveja Pilsen",
                PerguntaPai = perguntaSaborMalte,
                RespostaPai = "Suave",
                EhSugestao = true
            };

            var sugestaoPremiumLager = new PerguntaEntity
            {
                Id = 9,
                IdChat = 1,
                Ordem = 4,
                Texto = "Sugestão: Cerveja Premium Lager",
                PerguntaPai = perguntaSaborMalte,
                RespostaPai = "Marcante",
                EhSugestao = true
            };

            context.Perguntas.AddRange(
                perguntaIdade,
                perguntaNaoTemPermissao,
                perguntaTipoCerveja,
                perguntaClaraEscura,
                perguntaSaborMalte,
                sugestaoIpa,
                sugestaoStout,
                sugestaoPilsen,
                sugestaoPremiumLager
            );
        }

        private static void CriarDadosCerveja(DataContext context)
        {
            var cervejaIpa = new CervejaEntity
            {
                Id = "cerveja-ipa",
                Nome = "Cerveja IPA",
                Categoria = "Amarga",
                Coloracao = "Clara",
                CaminhoImagem = "assets/img/foods/cupcake.png",
                Descricao = "A cerveja IPA tem 40 anos de mercado. Fazemos a melhor cerveja do mundo. Compre e confira."
            };
            var cervejaStout = new CervejaEntity
            {
                Id = "cerveja-stout",
                Nome = "Cerveja Stout",
                Categoria = "Amarga",
                Coloracao = "Escura",
                CaminhoImagem = "assets/img/foods/cupcake.png",
                Descricao = "A cerveja Stout tem 40 anos de mercado. Fazemos a melhor cerveja do mundo. Compre e confira."
            };
            var cervejaPilsen = new CervejaEntity
            {
                Id = "cerveja-pilsen",
                Nome = "Cerveja Pilsen",
                Categoria = "Leve",
                Coloracao = "Suave",
                CaminhoImagem = "assets/img/foods/cupcake.png",
                Descricao = "A cerveja Pilsen tem 40 anos de mercado. Fazemos a melhor cerveja do mundo. Compre e confira."
            };
            var cervejaPremiumLager = new CervejaEntity
            {
                Id = "cerveja-premium-lager",
                Nome = "Cerveja Premium Lager",
                Categoria = "Leve",
                Coloracao = "Marcante",
                CaminhoImagem = "assets/img/foods/cupcake.png",
                Descricao = "A cerveja Premium Lager tem 40 anos de mercado. Fazemos a melhor cerveja do mundo. Compre e confira."
            };
            context.Cervejas.AddRange(cervejaIpa, cervejaStout, cervejaPilsen, cervejaPremiumLager);
        }
    }
}
