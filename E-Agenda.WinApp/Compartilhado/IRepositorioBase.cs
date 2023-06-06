using E_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.Compartilhado
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
