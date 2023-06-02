
namespace E_Agenda.Dominio.Compartilhado
{
    public interface IRepositorioBase<T> where T : BaseEntidade<T>
    {
        void Inserir(T tarefa);
        void Editar(int id, T tarefa);
        void Excluir(T tarefaSelecionada);
        T SelecionarPorId(int id);
        List<T> SelecionarTodos();
    }
}
