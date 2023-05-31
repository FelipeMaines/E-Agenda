namespace E_Agenda.WinApp.ModuloTarefa
{
    public interface IRepositorioTarefa
    {
        void Inserir(Tarefa tarefa);
        void Editar(int id, Tarefa tarefa);
        void Excluir(Tarefa tarefaSelecionada);
        List<Tarefa> SelecionarItensEmAberto();
        List<Tarefa> SelecionarItensFinalizadas();
        List<Tarefa> SelecionarTodosItens();
        Tarefa SelecionarPorId(int id);
    }
}
