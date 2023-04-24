namespace ControleFinanceiro.Modelo
{
    public class ControleCartao : Saldo
    {
        public double Limite { get; set; }

        public double Fatura { get; set; }

        public DateTime? DataVencimento { get; set; }

        public DateTime Notificacao { get; set; }

        public ControleCartao()
        {
        }

        public ControleCartao(double limite, double fatura, DateTime? dataVencimento, DateTime notificacao, double? saldoTotal, double? adicionar, double? remover, DateOnly? data, string categoria)
            : base ( saldoTotal, adicionar, remover, data, categoria)
        {
            Limite = limite;
            Fatura = fatura;
            DataVencimento = dataVencimento;
            Notificacao = notificacao;
        }
    }
}
