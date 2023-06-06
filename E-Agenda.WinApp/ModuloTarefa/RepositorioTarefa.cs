using E_Agenda.Dominio.ModuloTarefa;

namespace E_Agenda.WinApp.ModuloTarefa
{
    public class RepositorioTarefa : RepositorioMemoriaBase<Tarefa>, IRepositorioTarefa
    {
        public RepositorioTarefa(List<Tarefa> tarefas)
        {
            this.listaRegistros = tarefas;
        }

        public void ConcluirItem(Tarefa tarefaSelecionada)
        {
            throw new NotImplementedException();
        }

        public void InserirItem(Tarefa tarefaSelecionada, Itens item)
        {
            throw new NotImplementedException();
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

        public bool VerificarConclusao(Tarefa tarefaSelecionada, double contadorDeItens, double contadorDeConclusao)
        {
            throw new NotImplementedException();
        }
    }
}
