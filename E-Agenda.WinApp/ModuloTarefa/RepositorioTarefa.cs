namespace E_Agenda.WinApp.ModuloTarefa
{
    public class RepositorioTarefa : RepositorioMemoriaBase<Tarefa>, IRepositorioTarefa
    {
        public RepositorioTarefa(List<Tarefa> tarefas)
        {
            this.listaRegistros = tarefas;
        }

     
        public List<Tarefa> SelecionarItensEmAberto()
        {
            return listaRegistros.Where(x => x.conclusao < 100).ToList();
        }

        public List<Tarefa> SelecionarItensFinalizadas()
        {
            return listaRegistros.Where(x => x.conclusao == 100).ToList();
        }

        public List<Tarefa> SelecionarTodosItens()
        {
            return listaRegistros;
        }
    }
}
