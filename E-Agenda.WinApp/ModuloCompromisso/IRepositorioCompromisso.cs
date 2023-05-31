using E_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.ModuloCompromisso
{
    public interface IRepositorioCompromisso
    {
        void Inserir(Compromisso tarefa);
        void Editar(int id, Compromisso tarefa);
        void Excluir(Compromisso tarefaSelecionada);
        Compromisso SelecionarPorId(int id);
        List<Compromisso> SelecionarTodos();
        List<Compromisso> SelecionarCompromissosPassados(DateTime now);
        List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicial, DateTime dataFinal);
    }
}
