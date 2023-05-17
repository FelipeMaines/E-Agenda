using E_Agenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase
    {
        public override string ToolTipInserir { get { return "Inserir Nova Tarefa"; } }

        public override string ToolTipoEditar { get { return "Editar Tarefa"; } }

        public override string ToolTipExcluir { get { return "Excluir Tarefa"; } }

        public override void Inserir()
        {
            TelaTarefaForm telaTarefa = new TelaTarefaForm();

            telaTarefa.ShowDialog();
        }

        public override UserControl ObterListagem()
        {
            return new ListagemTarefaControl();
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tarefas";

        }
    }
}
