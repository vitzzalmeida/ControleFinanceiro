namespace ControleFinanceiro.Modelo
{
    public class AdicaoDeReceitas : Saldo
    {
        public string? CategoriaPersonalizada { get; set; }

        public AdicaoDeReceitas() { }

        public AdicaoDeReceitas(string? categoriaPersonalizada, double? saldoTotal, double? adicionar, double? remover, DateOnly? data, string categoria)
            : base (saldoTotal, adicionar, remover, data, categoria)
        {
            CategoriaPersonalizada = categoriaPersonalizada;
        }
    }
}
