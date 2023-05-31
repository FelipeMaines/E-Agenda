namespace E_Agenda.WinApp.ModuloDespesas
{
    public class RepositorioCategoriaArquivo : RepositorioArquivoBase<Categorias>, IRepositorioCategorias
    {
        private const string NOME_ARQUIVO_CATEGORIAS = "C:\\temp\\categorias\\dados-categorias.bin";
        public RepositorioCategoriaArquivo() : base(NOME_ARQUIVO_CATEGORIAS)
        {
            
        }
    }
}
