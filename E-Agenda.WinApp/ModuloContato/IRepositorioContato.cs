namespace E_Agenda.WinApp.ModuloContato
{
    public interface IRepositorioContato
    {
        void Inserir(Contato tarefa);
        void Editar(int id, Contato tarefa);
        void Excluir(Contato tarefaSelecionada);
        Contato SelecionarPorId(int id);
        List<Contato> SelecionarTodos();
    }
}
