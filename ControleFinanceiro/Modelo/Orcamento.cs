namespace ControleFinanceiro.Modelo
{
    public class Orcamento : Saldo
    {
        public double? Planejamento { get; set; }

        public double? LimiteGasto { get; set; }

        public double? comparacao()
        {
            return (double)(Planejamento - Gastos);
        }

        public Orcamento()
        {
        }

        public Orcamento(double? planejamento, double? limiteGasto, double? saldoTotal, double? adicionar, double? remover, double gastos, DateOnly? data, string categoria)
            : base ( saldoTotal, adicionar, remover, gastos, data, categoria)
        {
            Planejamento = planejamento;
            LimiteGasto = limiteGasto;
        }
    }
}
