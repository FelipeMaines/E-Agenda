using E_Agenda.Dominio.ModuloDespesas;

namespace E_Agenda.WinApp.ModuloDespesas
{
    public class RepositorioDespesaArquivo : RepositorioArquivoBase<Despesa>, IRepositorioDespesa
    {
        public RepositorioDespesaArquivo(ContextoDados contextoDados) : base(contextoDados)
        {
        }

        protected override List<Despesa> ObterRegistros()
        {
            return contextoDados.despesas;
        }
    }
}
