using E_Agenda.WinApp.Compartilhado;
using E_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase
    {

        CultureInfo cultureInfo = new CultureInfo("pt-BR");
        RepositorioCompromisso repositorioCompromisso;
        ListagemCompromissoControl listagemCompromisso;

        public ControladorCompromisso(RepositorioCompromisso repositorio)
        {
            this.repositorioCompromisso = repositorio;

            Compromisso compromisso = new Compromisso("pesca", "lago", "12/5/2022", "13:20:00", "19:00:00", "precensical");
            Compromisso compromisso2 = new Compromisso("Play", "Casa", "21/5/2022", "13:20:00", "19:00:00", "online");
            Compromisso compromisso3 = new Compromisso("Jogar", "Casa", "22/5/2022", "13:20:00", "19:00:00", "online");
            Compromisso compromisso4 = new Compromisso("Cartear", "Casa Fallen", "23/5/2022", "19:20:00", "23:50:00", "presencial");

            repositorioCompromisso.Inserir(compromisso);
            repositorioCompromisso.Inserir(compromisso2);
            repositorioCompromisso.Inserir(compromisso3);
            repositorioCompromisso.Inserir(compromisso4);

            ObterListagem();
            CarregarCompromisso();

        }
        public override string ToolTipInserir { get { return "Inserir Novo Compromisso"; } }

        public override string ToolTipoEditar { get { return "Editar Compromisso"; } }

        public override string ToolTipExcluir { get { return "Excluir Compromisso"; } }

        public override string ToolTipFiltrar { get { return "Filtrar itens"; } }

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

                if(!verificarOcupacao(compromisso))
                    return;

                repositorioCompromisso.Inserir(compromisso);

                CarregarCompromisso();
            }
        }

        public override void Filtro()
        {
            TelaFiltro telaFiltro = new TelaFiltro();

            if(telaFiltro.ShowDialog() == DialogResult.OK)
            {
                var statusSelecionado = telaFiltro.StatusSelecionado;
                DateTime dataInicial = telaFiltro.PegarDataInicial();
                DateTime dataFinal = telaFiltro.PegarDataFinal();

                CarregarCompromissoComFiltro(statusSelecionado, dataInicial, dataFinal);
            }
        }

        private void CarregarCompromissoComFiltro(TelaFiltro.statusCompromissoEnum statusSelecionado, DateTime dataInicial, DateTime dataFinal)
        {
            string tipoCompromisso;
            List<Compromisso> compromissos = new List<Compromisso>();

            switch (statusSelecionado)
            {
                case TelaFiltro.statusCompromissoEnum.passado:
                    compromissos = repositorioCompromisso.SelecionarCompromissosPassados(DateTime.Now);
                    break;

                case TelaFiltro.statusCompromissoEnum.futuro:
                    compromissos = repositorioCompromisso.SelecionarCompromissosFuturos(dataInicial, dataFinal);
                    break;

                case TelaFiltro.statusCompromissoEnum.todos:
                    compromissos = repositorioCompromisso.SelecionarTodos();
                    tipoCompromisso = string.Empty;
                    break;
            }

            listagemCompromisso.AtualizarRegistros(compromissos);

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

        private bool verificarOcupacao(Compromisso compromisso)
        {
            List<Compromisso> listaVerificacao = repositorioCompromisso.SelecionarTodos();
            DateTime data = DateTime.Parse(compromisso.data, cultureInfo);

            DateTime horaInicio = DateTime.Parse(compromisso.horaInicio, cultureInfo);
            DateTime horaFinal = DateTime.Parse(compromisso.horaFinal, cultureInfo);

            foreach (Compromisso item in listaVerificacao)
            {
                DateTime dataItem = DateTime.Parse(item.data, cultureInfo);
                DateTime horaComecoItem = DateTime.Parse(item.horaInicio, cultureInfo);
                DateTime horaFinalItem = DateTime.Parse(item.horaFinal, cultureInfo);

                if (data == dataItem)
                {
                    if(horaComecoItem <= horaInicio && horaComecoItem >= horaFinal)
                    {
                        MessageBox.Show("Horario ja ocupado!");
                        return false;
                    }
                    
                }
            }
            return true;
        }


    }
}
