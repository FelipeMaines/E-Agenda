namespace E_Agenda.WinApp.ModuloContato
{
    public class RepositorioContatoArquivo : IRepositorioContato
    {
        List<Contato> contatos = new List<Contato>();
        private static int contador;
        private const string NOME_ARQUIVO_CONTATO = "C:\\temp\\contatos\\dados-contatos.bin";

        public RepositorioContatoArquivo()
        {
            if (File.Exists(NOME_ARQUIVO_CONTATO))
                CarregarContatosDoArquivo();
        }

        public void Inserir(Contato contato)
        {
            contador++;
            contato.id = contador;
            contatos.Add(contato);

            GravarTarefasEmArquivo();
        }

        public void Editar(int id, Contato contatoAtualizado)
        {
            Contato contatoSelecionado = SelecionarPorId(id);

            contatoSelecionado.AtualizarInformacoes(contatoAtualizado);

            GravarTarefasEmArquivo();
        }

        public Contato SelecionarPorId(int id)
        {
            return contatos.FirstOrDefault(x => x.id == id);
        }

        public void Excluir(Contato tarefaSelecionada)
        {
            contatos.Remove(tarefaSelecionada);

            GravarTarefasEmArquivo();
        }

        private void AtualizarContador()
        {   if (contatos.Count > 0)
                contador = contatos.Max(x => x.id);
            else
                contador = 0;
            
        }

        private void GravarTarefasEmArquivo()
        {
            //BinaryFormatter serializer = new BinaryFormatter();

            //MemoryStream tarefaStream = new MemoryStream();

            //serializer.Serialize(tarefaStream, contatos);

            //byte[] bytes = tarefaStream.ToArray();
           
            string jsonString = JsonConvert.SerializeObject(contatos);

            File.WriteAllText(NOME_ARQUIVO_CONTATO, jsonString);
        }

        private void CarregarContatosDoArquivo()
        {
        //    BinaryFormatter serializer = new BinaryFormatter();

        //    byte[] tarefaEmBytes = File.ReadAllBytes(NOME_ARQUIVO_CONTATO);

        //    MemoryStream tarefasStream = new MemoryStream(tarefaEmBytes);

        //    contatos = (List<Contato>)serializer.Deserialize(tarefasStream);

            string jsonStr = File.ReadAllText(NOME_ARQUIVO_CONTATO);

            contatos = JsonConvert.DeserializeObject<List<Contato>>(jsonStr);

            AtualizarContador();
        }

        public List<Contato> SelecionarTodos()
        {
            return contatos;
        }
    }
}
