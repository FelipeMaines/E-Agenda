namespace E_Agenda.WinApp.ModuloTarefa
{
    public interface IRepositorioTarefa : IRepositorioBase<Tarefa>
    {
        void ConcluirItem(Tarefa tarefaSelecionada);
        void InserirItem(Tarefa tarefaSelecionada, Itens item);
        List<Tarefa> SelecionarItensEmAberto();
        List<Tarefa> SelecionarItensFinalizadas();
        List<Tarefa> SelecionarTodosItens();
    }
}
