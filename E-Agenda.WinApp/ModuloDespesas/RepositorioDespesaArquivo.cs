namespace E_Agenda.WinApp.ModuloDespesas
{
    public class RepositorioDespesaArquivo : RepositorioArquivoBase<Despesa>, IRepositorioDespesa
    {
        private const string NOME_ARQUIVO_DESPESAS = "C:\\temp\\despesas\\dados-despesas.bin";

        public RepositorioDespesaArquivo() : base(NOME_ARQUIVO_DESPESAS)
        {

        }
    }
}
