namespace E_Agenda.WinApp.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase
    {

        CultureInfo cultureInfo = new CultureInfo("pt-BR");
        IRepositorioCompromisso repositorioCompromisso;
        ListagemCompromissoControl listagemCompromisso;

        public ControladorCompromisso(IRepositorioCompromisso repositorio)
        {
            this.repositorioCompromisso = repositorio;
           
            ObterListagem();
            CarregarCompromisso();

        }
        public override string ToolTipInserir { get { return "Inserir Novo Compromisso"; } }

        public override string ToolTipoEditar { get { return "Editar Compromisso"; } }

        public override string ToolTipExcluir { get { return "Excluir Compromisso"; } }

        public override string ToolTipFiltrar { get { return "Filtrar itens"; } }

        public override string ToolTipAdicionaritens { get { return "Ver itens"; } }

        public override bool FiltrarHabilitado => true;

        public override void Editar()
        {

            Compromisso compromisso = ObterCompromissoSelecionado();

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
                repositorioCompromisso.Editar(id, telaCompromisso.Compromisso);

                CarregarCompromisso();
            }
        }

        private Compromisso ObterCompromissoSelecionado()
        {
            int id = listagemCompromisso.ObterIdSelecionado();

            return repositorioCompromisso.SelecionarPorId(id);
        }

        public override void Excluir()
        {
            Compromisso compromisso = ObterCompromissoSelecionado();

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


            if (telaFiltro.ShowDialog() == DialogResult.OK)
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
            DateTime data = compromisso.data;

            DateTime horaInicio = compromisso.horaInicio;
            DateTime horaFinal = compromisso.horaFinal;

            foreach (Compromisso item in listaVerificacao)
            {
                DateTime dataItem = item.data;
                DateTime horaComecoItem = item.horaInicio;
                DateTime horaFinalItem = item.horaFinal;

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

        public override void AdicionarItens()
        {
            throw new NotImplementedException();
        }

        public override void ConcluirItens()
        {
            throw new NotImplementedException();
        }

        
    }
}
