using E_Agenda.WinApp.Compartilhado;
using E_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase
    {
        RepositorioCompromisso repositorioCompromisso;
        ListagemCompromissoControl listagemCompromisso;

        public ControladorCompromisso(RepositorioCompromisso repositorio)
        {
            this.repositorioCompromisso = repositorio;
        }
        public override string ToolTipInserir { get { return "Inserir Novo Compromisso"; } }

        public override string ToolTipoEditar { get { return "Editar Compromisso"; } }

        public override string ToolTipExcluir { get { return "Excluir Compromisso"; } }

        public override void Editar()
        {

            Compromisso compromisso = listagemCompromisso.ObterContatoSelecionado();

            if (compromisso == null)
            {
                MessageBox.Show($"Selecione um contato primeiro!",
                    "Edição de Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
            int id = 0;
            TelaCompromisso telaCompromisso = new TelaCompromisso();
            telaCompromisso.Compromisso = compromisso;
            id = compromisso.id;

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                telaCompromisso.Compromisso.id = id;
                repositorioCompromisso.Editar(telaCompromisso.Compromisso);

                CarregarCompromisso();
            }
        }

        public override void Excluir()
        {
            Compromisso compromisso = listagemCompromisso.ObterContatoSelecionado();

            if (compromisso == null)
            {
                MessageBox.Show($"Selecione um compromisso primeiro!",
                    "Exclusão de compromissos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o contato {compromisso.assunto}?", "Exclusão de compromissos",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCompromisso.Excluir(compromisso);

                CarregarCompromisso();
            }
        }

        public override void Inserir()
        {
            TelaCompromisso telaCompromisso = new TelaCompromisso();

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Compromisso compromisso = telaCompromisso.Compromisso;

                repositorioCompromisso.Inserir(compromisso);

                CarregarCompromisso();
            }
        }

        public override UserControl ObterListagem()
        {

            if (listagemCompromisso == null)
                listagemCompromisso = new ListagemCompromissoControl();

            CarregarCompromisso();

            return listagemCompromisso;
        }

        private void CarregarCompromisso()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            listagemCompromisso.AtualizarRegistros(compromissos);
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Compromisso";
        }
    }
}
