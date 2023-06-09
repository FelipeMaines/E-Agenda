﻿namespace E_Agenda.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }

        public abstract string ToolTipoEditar { get; }

        public abstract string ToolTipExcluir { get; }

        public abstract string ToolTipFiltrar { get; }

        public abstract string ToolTipAdicionaritens { get; }

        public abstract void Inserir();

        public abstract UserControl ObterListagem();

        public abstract string ObterTipoCadastro();

        public abstract void Editar();

        public abstract void Filtro();

        public abstract void Excluir();

        public abstract void AdicionarItens();

        public abstract void ConcluirItens();

        public virtual bool InserirHabilitado { get { return true; } }
        public virtual bool EditarHabilitado { get { return true; } }
        public virtual bool ExcluirHabilitado { get { return true; } }

        public virtual bool FiltrarHabilitado { get { return false; } }
        public virtual bool AdicionarItensHabilitado { get { return false; } }
        public virtual bool ConcluirItensHabilitado { get { return false; } }

    }
}
