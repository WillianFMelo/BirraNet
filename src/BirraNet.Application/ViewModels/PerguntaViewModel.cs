namespace BirraNet.Application.ViewModels
{
    public class PerguntaViewModel
    {
        public PerguntaViewModel() { }
        public PerguntaViewModel(int id, string mensagem, int ordem, int? idPerguntaPai, string respostaPai, bool ehSugestao)
        {
            Id = id;
            Mensagem = mensagem;
            Ordem = ordem;
            IdPerguntaPai = idPerguntaPai;
            RespostaPai = respostaPai;
            IdChat = 1;
            EhSugestao = ehSugestao;
        }

        public int Id { get; set; }
        public string Mensagem { get; set; }
        public int Ordem { get; set; }
        public int? IdPerguntaPai { get; set; }
        public string RespostaPai { get; set; }
        public int IdChat { get; set; }
        public bool EhPergunta { get { return true; } }
        public bool EhSugestao { get; set; }
    }
}
