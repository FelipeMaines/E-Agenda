namespace E_Agenda.WinApp.ModuloTarefa
{
    public class Tarefa
    {
        public int id;
        public string nome;
        public string prioridade;

        public Tarefa(string nome, string prioridade)
        {
            this.nome = nome;
            this.prioridade = prioridade;
        }

        public override string ToString()
        {
            return "id: " + id + "\t nome: " + nome + "\t Prioridade: " + prioridade;
        }
    }

}
