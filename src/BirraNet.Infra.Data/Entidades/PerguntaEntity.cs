namespace BirraNet.Infra.Data.Entidades
{
    public class PerguntaEntity : MensagemEntity
    {
        public PerguntaEntity PerguntaPai { get; set; }
        public string RespostaPai { get; set; }
        public int Ordem { get; set; }
        public bool EhSugestao { get; set; }
    }
}
