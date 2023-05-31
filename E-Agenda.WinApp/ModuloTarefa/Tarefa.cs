namespace E_Agenda.WinApp.ModuloTarefa
{
    [Serializable]
    public class Tarefa : BaseEntidade<Tarefa>
    {
        public string nome { get; set; }
        public PrioridadeTarefaEnum prioridade { get; set; }

        public List<Itens> listaItens;

        public List<Itens> listaItensProntos;

        public double conclusao;
        public DateTime dataAbertura { get; set; }
        public DateTime dataFinalizda { get; set; }
        public bool estaFinalizada { get; set; }

        public Tarefa(string nome, PrioridadeTarefaEnum prioridade)
        {
            this.nome = nome;
            this.prioridade = prioridade; // a
            listaItens = new List<Itens>(); //assdsdada
            listaItensProntos = new List<Itens>();
            dataAbertura = DateTime.Now.Date;
        }

        public override void AtualizarInformacoes(Tarefa registroAtualizado)
        {
            this.nome = registroAtualizado.nome;
            this.prioridade = registroAtualizado.prioridade;
        }

        public override string ToString()
        {
            string strDataFinalizada = "Nao concluida";

            if (estaFinalizada == true)
            {
                strDataFinalizada = dataFinalizda.ToString();
            }

            return "id: " + id + "\t nome: " + nome + "\t Prioridade: " + prioridade.ToString() + "\t Data de Abertura: " + dataAbertura + "\tData de Finalizacao: " + strDataFinalizada;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome) || nome.Length < 3)
                erros.Add("Campo nome esta errado!");

            else if (string.IsNullOrEmpty(prioridade.ToString()))
                erros.Add("Campo prioridade esta errado!");

            return erros.ToArray();
        }

       
    }

}
