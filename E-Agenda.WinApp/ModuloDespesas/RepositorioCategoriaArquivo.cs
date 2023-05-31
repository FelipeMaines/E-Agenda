
namespace E_Agenda.WinApp.ModuloDespesas
{
    public class RepositorioCategoriaArquivo : IRepositorioCategorias
    {
        List<Categorias> categorias = new List<Categorias>();
        private static int contador;
        private const string NOME_ARQUIVO_CATEGORIAS = "C:\\temp\\categorias\\dados-categorias.bin";
        public RepositorioCategoriaArquivo()
        {
            if (File.Exists(NOME_ARQUIVO_CATEGORIAS))
                CarregarArquivod();
        }
        public void Inserir(Categorias categoria)
        {
            contador++;
            categoria.id = contador;
            categorias.Add(categoria);

            AtualizarArquivo();
        }

        public List<Categorias> SelecionarTodos()
        {
            return categorias;
        }

        private void AtualizarArquivo()
        {
            string strJson = JsonConvert.SerializeObject(categorias);

            File.WriteAllText(NOME_ARQUIVO_CATEGORIAS, strJson);
        }

        private void CarregarArquivod()
        {
            string strjson = File.ReadAllText(NOME_ARQUIVO_CATEGORIAS);

            categorias = JsonConvert.DeserializeObject<List<Categorias>>(strjson);

            AtualizarContador();
        }

        private void AtualizarContador()
        {
            if (categorias.Count > 0)
                contador = categorias.Max(x => x.id);
            else
                contador = 0;

        }
    }

}
