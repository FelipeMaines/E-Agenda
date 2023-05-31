namespace E_Agenda.WinApp.ModuloTarefa
{
    public class RepositorioTarefaArquivo :RepositorioArquivoBase<Tarefa> ,IRepositorioTarefa
    {
        private const string NOME_ARQUIVO_TAREFAS = "C:\\temp\\tarefas\\dados-tarefas.bin";

        public RepositorioTarefaArquivo() : base(NOME_ARQUIVO_TAREFAS)
        {
            
        }
       
        public List<Tarefa> SelecionarItensEmAberto()
        {
            return base.listaRegistros.Where(x => x.conclusao < 100).ToList();
        }

        public List<Tarefa> SelecionarItensFinalizadas()
        {
            return base.listaRegistros.Where(x => x.conclusao == 100).ToList();
        }

        public override List<Tarefa> SelecionarTodosItens()
        {
            return base.listaRegistros.OrderBy(x => x.prioridade).ToList();
        }

        public void InserirItem(Tarefa tarefaSelecionada, Itens item)
        {
            tarefaSelecionada.listaItens.Add(item);
            base.GravarTarefasEmArquivo();
        }

        public void ConcluirItem(Tarefa tarefaSelecionada)
        {
            tarefaSelecionada.dataFinalizda = DateTime.Now;
            tarefaSelecionada.estaFinalizada = true;
            base.GravarTarefasEmArquivo();
        }
    }
}
