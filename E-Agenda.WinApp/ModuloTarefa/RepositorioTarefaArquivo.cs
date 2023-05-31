namespace E_Agenda.WinApp.ModuloTarefa
{
    public class RepositorioTarefaArquivo : IRepositorioTarefa
    {
        private static int contador;

        private List<Tarefa> tarefas = new List<Tarefa>();

        private const string NOME_ARQUIVO_TAREFAS = "C:\\temp\\tarefas\\dados-tarefas.bin";

        public RepositorioTarefaArquivo()
        {
            if (File.Exists(NOME_ARQUIVO_TAREFAS))
                CarregarTarefasDoArquivo();
        }
       
        public void Inserir(Tarefa tarefa)
        {
            contador++;
            tarefa.id = contador;
            tarefas.Add(tarefa);

            GravarTarefasEmArquivo();
        }
       
        public void Editar(int id, Tarefa tarefaAtualizada)
        {
            Tarefa tarefaSelecionada = SelecionarPorId(id);

            tarefaSelecionada.AtualizarInformacoes(tarefaAtualizada);

            GravarTarefasEmArquivo();
        }

        public void Excluir(Tarefa tarefaSelecionada)
        {
            tarefas.Remove(tarefaSelecionada);

            GravarTarefasEmArquivo();
        }

        public List<Tarefa> SelecionarItensEmAberto()
        {
            return tarefas.Where(x => x.conclusao < 100).ToList();
        }

        public List<Tarefa> SelecionarItensFinalizadas()
        {
            return tarefas.Where(x => x.conclusao == 100).ToList();
        }

        public List<Tarefa> SelecionarTodosItens()
        {
            return tarefas.OrderBy(x => x.prioridade).ToList();
        }

        public Tarefa SelecionarPorId(int id)
        {
            return tarefas.FirstOrDefault(x => x.id == id);
        }

        private void AtualizarContador()
        {
            contador = tarefas.Max(x => x.id);
        }

        private void GravarTarefasEmArquivo()
        {
            BinaryFormatter serializer = new BinaryFormatter();

            MemoryStream tarefaStream = new MemoryStream();

            serializer.Serialize(tarefaStream, tarefas);

            byte[] bytes = tarefaStream.ToArray();

            File.WriteAllBytes(NOME_ARQUIVO_TAREFAS, bytes);
        }

        private void CarregarTarefasDoArquivo()
        {
            BinaryFormatter serializer = new BinaryFormatter();

            byte[] tarefaEmBytes = File.ReadAllBytes(NOME_ARQUIVO_TAREFAS);

            MemoryStream tarefasStream = new MemoryStream(tarefaEmBytes);

            tarefas = (List<Tarefa>)serializer.Deserialize(tarefasStream);

            AtualizarContador();
        }

    }
}
