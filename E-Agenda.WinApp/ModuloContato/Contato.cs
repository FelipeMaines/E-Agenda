namespace E_Agenda.WinApp.ModuloContato
{
    [Serializable]
    public class Contato : BaseEntidade<Contato>
    {
        public string nome;
        public string email;
        public string empresa;
        public string telefone;
        public string cargo;

        public Contato()
        {
            
        }
        public Contato(string nome,string email,string telefone, string empresa, string cargo)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.empresa =empresa;
            this.email = email;
            this.cargo = cargo;
        }


        public override void AtualizarInformacoes(Contato registroAtualizado)
        {

            this.nome = registroAtualizado.nome;
            this.telefone = registroAtualizado.telefone;
            this.email = registroAtualizado.email;
            this.cargo = registroAtualizado.cargo;
            this.empresa = registroAtualizado.empresa;
        }

        public override string ToString()
        {
            return "id: " + id + "\t nome: " + nome + "\t empresa: " + empresa + "\t cargo: " + cargo + "\t telefone: " + telefone + "\t email: " + email;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome) || nome.Length < 3)
                erros.Add("Campo nome esta errado!");

            else if (string.IsNullOrEmpty(email))
                erros.Add("Campo email esta errado!");

            else if (string.IsNullOrEmpty(telefone))
                erros.Add("Campo telefone esta errado!");

            else if (string.IsNullOrEmpty(empresa))
                erros.Add("Campo empresa esta errado!");

            else if (!IsValidEmail(email))
                erros.Add("O campo de email esta invalido!");

            else if (!isValidNumber(telefone))
                erros.Add("O campo telefone esta incorreto!");

            return erros.ToArray();
        }

        public bool IsValidEmail(string email)
        {
            string pattern = @"^[\w\.-]+@[\w\.-]+\.\w+$";

            Match match = Regex.Match(email, pattern, RegexOptions.IgnoreCase);

            return match.Success;
        }

        private bool isValidNumber(string numero)
        {
            if (numero.Length != 11)
                return false;

            return true;
        }

    }
}
