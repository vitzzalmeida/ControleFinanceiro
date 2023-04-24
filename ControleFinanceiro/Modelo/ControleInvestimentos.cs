namespace ControleFinanceiro.Modelo
{
    public class ControleInvestimentos : Saldo
    {
        public string TipoInvestimento { get; set; }

        public double RetornoEsperado { get; set; }

        public double AtualRendimento { get; set; }

        public double Projecoes { get; set; }

        public ControleInvestimentos()
        {
        }

        public ControleInvestimentos(string tipoInvestimento, double retornoEsperado, double atualRendimento, double projecoes, double? saldoTotal, double? adicionar, double? remover, DateOnly? data)
            : base ( saldoTotal, adicionar, remover, data)
        {
            TipoInvestimento = tipoInvestimento;
            RetornoEsperado = retornoEsperado;
            AtualRendimento = atualRendimento;
            Projecoes = projecoes;
        }
    }
}
