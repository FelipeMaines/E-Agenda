namespace E_Agenda.WinApp.ModuloDespesas
{
    public class RepositorioCategoriaArquivo : RepositorioArquivoBase<Categorias>, IRepositorioCategorias
    {
        public RepositorioCategoriaArquivo(ContextoDados contextoDados) : base(contextoDados)
        {
        }

        protected override List<Categorias> ObterRegistros()
        {
            return contextoDados.categorias;
        }
    }
}
