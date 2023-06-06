using E_Agenda.Dominio.ModuloTarefa;


namespace E_Agenda.Infra.Dados.Arquivo.ModuloTarefa
{
    public class RepositorioTarefaArquivo :RepositorioArquivoBase<Tarefa> ,IRepositorioTarefa
    {
        public RepositorioTarefaArquivo(ContextoDados contextoDados) : base(contextoDados)
        {
        }

        public List<Tarefa> SelecionarItensEmAberto()
        {
            return ObterRegistros().Where(x => x.conclusao < 100).ToList();
        }

        public List<Tarefa> SelecionarItensFinalizadas()
        {
            return ObterRegistros().Where(x => x.conclusao == 100).ToList();
        }

        public override List<Tarefa> SelecionarTodosItens()
        {
            return ObterRegistros().OrderBy(x => x.prioridade).ToList();
        }

        public void InserirItem(Tarefa tarefaSelecionada, Itens item)
        {
            tarefaSelecionada.listaItens.Add(item);
            contextoDados.GravarTarefasEmArquivo();
        }

        public void ConcluirItem(Tarefa tarefaSelecionada)
        {
            tarefaSelecionada.dataFinalizda = DateTime.Now;
            tarefaSelecionada.estaFinalizada = true;
            contextoDados.GravarTarefasEmArquivo();
        }

        public bool VerificarConclusao(Tarefa tarefaSelecionada, double contadorDeItens, double contadorDeConclusao)
        {
                tarefaSelecionada.conclusao = (contadorDeConclusao / contadorDeItens) * (double)100.0;

                if (tarefaSelecionada.conclusao == 100)
                {
                    contextoDados.GravarTarefasEmArquivo();
                    return true;
                }

                contextoDados.GravarTarefasEmArquivo();
                return false;
        }

        protected override List<Tarefa> ObterRegistros()
        {
            return contextoDados.tarefas;
        }
    }
}
