using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }

        public abstract string ToolTipoEditar { get; }

        public abstract string ToolTipExcluir { get; }

        public abstract void Inserir();

        public abstract UserControl ObterListagem();

        public abstract string ObterTipoCadastro();

        public abstract void Editar();

        public abstract void Excluir();
        
    }
}
