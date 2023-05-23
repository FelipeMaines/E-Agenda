namespace E_Agenda.WinApp.ModuloTarefa
{
    public class Tarefa
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string prioridade { get; set; }
        public List<Itens> listaItens;

        public List<Itens> listaItensProntos;
        public DateTime dataAbertura { get; set; }

        public Tarefa(string nome, string prioridade)
        {
            this.nome = nome;
            this.prioridade = prioridade; // a
            listaItens = new List<Itens>(); //assdsdada
            listaItensProntos = new List<Itens>();
            dataAbertura = DateTime.Now.Date;
        }

        public override string ToString()
        {
            return "id: " + id + "\t nome: " + nome + "\t Prioridade: " + prioridade + "\t Data de Abertura: " + dataAbertura;
        }
    }

}
