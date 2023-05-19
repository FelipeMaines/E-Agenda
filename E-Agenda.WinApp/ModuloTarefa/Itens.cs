using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.ModuloTarefa
{
    public class Itens
    {
        public string descricao;
        public string concluida;

        public Itens(string descricao, string concluida)
        {
            this.descricao = descricao;
            this.concluida = concluida;
        }
    }
}
