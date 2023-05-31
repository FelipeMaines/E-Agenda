using E_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.ModuloDespesas
{
    public class RepositorioDespesa : RepositorioMemoriaBase<Despesa>, IRepositorioDespesas
    {
        public RepositorioDespesa(List<Despesa> despesas)
        {
            this.listaRegistros = despesas;
        }
    }
}
