using ControleFinanceiro.Modelo;

namespace ControleFinanceiro.Modelo
{
    public class Relatorios : Saldo
    {
        public double? Relatorio { get; set; }

        ControleInvestimentos? investimentos = new ControleInvestimentos();
        Orcamento? orcamento = new Orcamento();

        public Relatorios()
        {
        }

        public Relatorios(double? relatorio, ControleInvestimentos? investimentos, Orcamento? orcamento,
        double? saldoTotal, double? adicionar, double? remover, double gastos, DateOnly? data, string categoria)
            : base (saldoTotal, adicionar, remover, gastos, data, categoria)
        {
            Relatorio = relatorio;
            this.investimentos = investimentos;
            this.orcamento = orcamento;
        }
    }
}
