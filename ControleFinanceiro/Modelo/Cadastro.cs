namespace ControleFinanceiro.Modelo
{
    public class Cadastro
    {
        public string? Usuario { get; set; }

        public string? Email { get; set; }

        public string? Senha { get; set; }

        public Cadastro() { }

        public Cadastro(string? usuario, string? email, string? senha)
        {
            Usuario = usuario;
            Email = email;
            Senha = senha;
        }
    }
}
