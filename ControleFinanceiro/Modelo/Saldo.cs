namespace ControleFinanceiro.Modelo
{
    public class Saldo
    {
        public double? SaldoTotal { get; set; }

        // Adiciona receita em AdicaoDeReceitas, ControleCartao e ControleInvestimento //
        public double? Adicionar { get; set; }

        // Remove receita em AdicaoDeReceitas, ControleCartao e ControleInvestimento //
        public double? Remover { get; set; }

        public double Gastos { get; set; }

        // Para registro de datas em quase todas subclasses //
        public DateOnly? Data { get; set; }

        // Para categorias pré-definidas //
        public string Categoria { get; private set; }

        public Saldo()
        {
        }

        public Saldo(double? saldoTotal, double? adicionar, double? remover, DateOnly? data, string categoria)
        {
            SaldoTotal = saldoTotal;
            Adicionar = adicionar;
            Remover = remover;
            Data = data;
            Categoria = categoria;
        }

        public Saldo(double? saldoTotal, double? adicionar, double? remover, DateOnly? data)
        {
            SaldoTotal = saldoTotal;
            Adicionar = adicionar;
            Remover = remover;
            Data = data;
        }

        public Saldo(double? saldoTotal, double? adicionar, double? remover, double gastos, DateOnly? data, string categoria)
        {
            SaldoTotal = saldoTotal;
            Adicionar = adicionar;
            Remover = remover;
            Gastos = gastos;
            Data = data;
            Categoria = categoria;
        }
    }
}
