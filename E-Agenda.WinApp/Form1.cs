using E_Agenda.Infra.Compartilhado;
using E_Agenda.Infra.Dados.Arquivo.ModuloCompromisso;
using E_Agenda.Infra.Dados.Arquivo.ModuloContato;
using E_Agenda.Infra.Dados.Arquivo.ModuloDespesa;
using E_Agenda.Infra.Dados.Arquivo.ModuloTarefa;
using E_Agenda.WinApp.Compartilhado;
using E_Agenda.WinApp.ModuloCompromisso;
using E_Agenda.WinApp.ModuloContato;
using E_Agenda.WinApp.ModuloDespesas;
using E_Agenda.WinApp.ModuloTarefa;

namespace E_Agenda.WinApp
{
    public partial class Form1 : Form
    {

        static ContextoDados contextoDados = new ContextoDados(carregarDados: true);

        private IRepositorioContato repositorioContato = new RepositorioContatoArquivo(contextoDados);
        private IRepositorioCompromisso repositorioCompromisso = new RepositorioCompromissoArquivo(contextoDados);
        private IRepositorioCategorias repositorioCategoria = new RepositorioCategoriaArquivo(contextoDados);
        private IRepositorioDespesa repositorioDespesa = new RepositorioDespesaArquivo(contextoDados);
        private IRepositorioTarefa repositorioTarefa = new RepositorioTarefaArquivo(contextoDados);
        private ControladorBase controlador;
        private static Form1 telaPrincipal;

        public Form1()
        {
            InitializeComponent();
            telaPrincipal = this;
        }



        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            labelTipoCadastro.Text = "cadastro De Contatos";

            controlador = new ControladorContato(repositorioContato);

            ConfigurarTelaPrincipal(controlador);

        }

        private void ConfirgurarEstados()
        {
            btnInserir.Enabled = controlador.InserirHabilitado;
            btnEditar.Enabled = controlador.EditarHabilitado;
            btnExcluir.Enabled = controlador.ExcluirHabilitado;
            btnFiltro.Enabled = controlador.FiltrarHabilitado;
            btnAdiconarItem.Enabled = controlador.AdicionarItensHabilitado;
            btnConcluirItens.Enabled = controlador.ConcluirItensHabilitado;
        }

        public static Form1 Instancia
        {
            get
            {
                if (telaPrincipal == null)
                    telaPrincipal = new Form1();

                return telaPrincipal;
            }
        }

        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            labelTipoCadastro.Text = "cadastro De Tarefas";

            controlador = new ControladorTarefa(repositorioTarefa);

            ConfigurarTelaPrincipal(controlador);
        }

        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            labelTipoCadastro.Text = "cadastro De Compromissos";

            controlador = new ControladorCompromisso(repositorioCompromisso);

            ConfigurarTelaPrincipal(controlador);
        }

        private void despesasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            labelTipoCadastro.Text = "Cadastro de Financas";

            controlador = new ControladorDespesa(repositorioDespesa, repositorioCategoria);

            ConfigurarTelaPrincipal(controlador);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            ConfirgurarToolTips(controlador);

            ConfirgurarEstados();

            ConfigurarListagem(controlador);
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (!VerificarNullControlador())
                return;

            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!VerificarNullControlador())
                return;

            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!VerificarNullControlador())
                return;

            controlador.Excluir();
        }
        private void btnAdicionaItens_Click_1(object sender, EventArgs e)
        {

            if (!VerificarNullControlador())
                return;

            controlador.AdicionarItens();

        }

        private void btnConcluirItens_Click(object sender, EventArgs e)
        {
            if (!VerificarNullControlador())
                return;

            controlador.ConcluirItens();


        }

        private bool VerificarNullControlador()
        {
            if (controlador == null)
            {
                MessageBox.Show("Selecione uma area primeiro!", "Selecione uma area", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ConfirgurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipoEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
            btnFiltro.ToolTipText = controlador.ToolTipFiltrar;
            btnAdiconarItem.ToolTipText = controlador.ToolTipAdicionaritens;

        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(listagem);
        }

        private void toolStripbtnFiltro_Click(object sender, EventArgs e)
        {
            controlador.Filtro();
        }

        public void AtualizarRodape(string erros)
        {
            rodaPe.Text = erros;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}