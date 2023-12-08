namespace StockApp.Business.Abstrata
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get;}
        public DateTime DataAlteracao { get;}
    }
}
