namespace E_Agenda.WinApp.ModuloContato
{
    public class ControladorContato : ControladorBase
    {
        private IRepositorioBase<Contato> repositorioContato;

        private ListaContatoControl listagemContato;

        public override string ToolTipInserir { get { return "Inserir Novo Contato"; } }

        public override string ToolTipoEditar { get { return "Editar Contato"; } }

        public override string ToolTipExcluir { get { return "Excluir Contato"; } }

        public override string ToolTipFiltrar { get { return "Filtrar itens"; } }

        public override string ToolTipAdicionaritens { get { return "Ver itens"; } }



        public ControladorContato(IRepositorioBase<Contato> repositorioContato)
        {
            this.repositorioContato = repositorioContato;
        }

        public override void Inserir()
        {
            TelaContatoForm telaContato = new TelaContatoForm();

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Contato contato = telaContato.Contato;
                repositorioContato.Inserir(contato);
                CarregarContatos();
            }

            else
                return;
        }

        private Contato ObterContatoSelecionado()
        {
            int id = listagemContato.ObterIdSelecionado();

            return repositorioContato.SelecionarPorId(id);
        }

        private void RechamarVerificacao(ref TelaContatoForm telaContato, ref DialogResult opcaoEscolhida, ref Contato contato)
        {
            telaContato = new TelaContatoForm();

            opcaoEscolhida = telaContato.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                contato = telaContato.Contato;
               
                repositorioContato.Inserir(contato);

                CarregarContatos();
            }

            else
                return;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Contatos";
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            listagemContato.AtualizarRegistros(contatos);
        }
        public override UserControl ObterListagem()
        {
            if (listagemContato == null)
                listagemContato = new ListaContatoControl();

            CarregarContatos();

            return listagemContato;
        }


        public override void Editar()
        {
            Contato contato = ObterContatoSelecionado();

            if (contato == null)
            {
                MessageBox.Show($"Selecione um contato primeiro!",
                    "Edição de Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            int id = 0;
            TelaContatoForm telaContato = new TelaContatoForm();
            telaContato.Contato = contato;
            id = contato.id;

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                    telaContato.Contato.id = id;
                    repositorioContato.Editar(id, telaContato.Contato);

                    CarregarContatos();
            }
            else
            {
                MessageBox.Show("Cancelado!");
                return;
            }
        }

        public override void Excluir()
        {
            Contato contato = ObterContatoSelecionado();

            if (contato == null)
            {
                MessageBox.Show($"Selecione um contato primeiro!",
                    "Exclusão de Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o contato {contato.nome}?", "Exclusão de Contatos",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioContato.Excluir(contato);

                CarregarContatos();
            }
        }

        public override void Filtro()
        {
            TelaFiltro telaFiltro = new TelaFiltro();

            if(telaFiltro.ShowDialog() == DialogResult.OK)
            {

            }
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
