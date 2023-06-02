using E_Agenda.Dominio.Compartilhado;
using E_Agenda.WinApp.Compartilhado;

namespace E_Agenda.WinApp.ModuloDespesas
{
    public class ControladorDespesa : ControladorBase
    {
        IRepositorioBase<Despesa> repositorioDespesa;
        IRepositorioCategorias repositorioCategorias;
        
        ListagemDespesaControl listagemDespesa;
        public override string ToolTipInserir => "";

        public override string ToolTipoEditar => "";

        public override string ToolTipExcluir => "";

        public override string ToolTipFiltrar => "";

        public override string ToolTipAdicionaritens => "";

        public override bool AdicionarItensHabilitado => true;
        public ControladorDespesa(IRepositorioBase<Despesa> repositorio, IRepositorioCategorias repositorioCategoria)
        {
            repositorioDespesa = repositorio;
            this.repositorioCategorias = repositorioCategoria;

        }
        public override void AdicionarItens()
        {
            TelaCategoriasForm telaCategoria = new TelaCategoriasForm();

            if(telaCategoria.ShowDialog() == DialogResult.OK)
            {
                Categorias categoria = telaCategoria.Categoria;

                repositorioCategorias.Inserir(categoria);
            }
        }

        private void CarregarDespesas()
        {
            List<Despesa> despesa = repositorioDespesa.SelecionarTodos();

            listagemDespesa.AtualizarRegistros(despesa);
        }
        public override void ConcluirItens()
        {
            throw new NotImplementedException();
        }

        public override void Editar()
        {
            Despesa despesa = ObterDespesaSelecionada();

            if (despesa == null)
            {
                MessageBox.Show($"Selecione um despesa primeiro!",
                    "Edição de Despesas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            int id = 0;
            TelaDespesaForm telaDespesa = new TelaDespesaForm();

            List<Categorias> listaCategorias = repositorioCategorias.SelecionarTodos();
            telaDespesa.AtualizarListBox(listaCategorias);
            telaDespesa.Despesa = despesa;
            id = despesa.id;

            DialogResult opcaoEscolhida = telaDespesa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                telaDespesa.Despesa.id = id;
                repositorioDespesa.Editar(id, telaDespesa.Despesa);

                CarregarDespesas();
            }
            else
            {
                MessageBox.Show("Cancelado!");
                return;
            }
        }

        public override void Excluir()
        {
            Despesa despesa = ObterDespesaSelecionada();

            if (despesa == null)
            {
                MessageBox.Show($"Selecione um despesa primeiro!",
                    "Exclusão de Despesa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a despesa: {despesa.descricao}?", "Exclusão de Despesa",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioDespesa.Excluir(despesa);

                CarregarDespesas();
            }
        }

        public override void Filtro()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            TelaDespesaForm telaDespesa = new TelaDespesaForm();

            List<Categorias> listaCategorias = repositorioCategorias.SelecionarTodos();
            telaDespesa.AtualizarListBox(listaCategorias);

            DialogResult opcaoEscolhida = telaDespesa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Despesa despesa = telaDespesa.Despesa;
                repositorioDespesa.Inserir(despesa);
                CarregarDespesas();
            }
        }

        private Despesa ObterDespesaSelecionada()
        {
            int id = listagemDespesa.ObterIdSelecionado();

            return repositorioDespesa.SelecionarTodos().FirstOrDefault(a => a.id == id);
        }

        public override UserControl ObterListagem()
        {
            if (listagemDespesa == null)
                listagemDespesa = new ListagemDespesaControl();

            CarregarDespesas();

            return listagemDespesa;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Despesa";
        }
    }
}
