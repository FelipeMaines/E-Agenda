using E_Agenda.Dominio.ModuloDespesas;

namespace E_Agenda.WinApp.ModuloDespesas
{
    public class RepositorioDespesa : RepositorioMemoriaBase<Despesa>, IRepositorioDespesa
    {
        public RepositorioDespesa(List<Despesa> despesas)
        {
            this.listaRegistros = despesas;
        }
    }
}
