namespace StockApp.Business.Abstrata
{
    public abstract class EntidadeCadastro : EntidadeBase
    {
        public string Nome { get; set; }
        public bool Status { get; set; }
    }
}
