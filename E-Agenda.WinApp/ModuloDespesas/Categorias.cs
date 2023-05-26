namespace E_Agenda.WinApp.ModuloDespesas
{
    public class Categorias : Entidade
    {
        public Categorias(string nome, string numero, string rua)
        {
            this.nome = nome;
            this.numero = numero;
            this.rua = rua;
        }

        public string nome { get; set; }
        public string numero { get; set; }
        public string rua { get; set; }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome))
                erros.Add("Erro no campo nome");

            return erros.ToArray();
        }
    }
}