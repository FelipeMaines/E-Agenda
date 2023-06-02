using E_Agenda.Dominio.ModuloDespesas;
using E_Agenda.Infra.Compartilhado;

namespace E_Agenda.Infra.Dados.Arquivo.ModuloDespesa
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
