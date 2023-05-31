using E_Agenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.ModuloDespesas
{
    public interface IRepositorioDespesas
    {
        void Inserir(Despesa tarefa);
        void Editar(int id, Despesa tarefa);
        void Excluir(Despesa tarefaSelecionada);
        Despesa SelecionarPorId(int id);

        List<Despesa> SelecionarTodos();
    }
}
