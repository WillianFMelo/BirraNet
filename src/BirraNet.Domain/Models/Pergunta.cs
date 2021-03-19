namespace BirraNet.Domain.Models
{
    public class Pergunta : Mensagem
    {
        public Mensagem MensagemPai { get; set; }
        public string RespostaPai { get; set; }
        public int Ordem { get; set; }
    }
}
