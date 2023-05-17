using E_Agenda.WinApp.Compartilhado;
using E_Agenda.WinApp.ModuloContato;
using E_Agenda.WinApp.ModuloTarefa;

namespace E_Agenda.WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private RepositorioContato repositorioContato = new RepositorioContato();
        private ControladorBase controlador;

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            labelTipoCadastro.Text = "cadastro De Contatos";

            controlador = new ControladorContato(repositorioContato);

            ConfigurarTelaPrincipal(controlador);

        }

        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            labelTipoCadastro.Text = "cadastro De Tarefas";

            controlador = new ControladorTarefa();

            ConfigurarTelaPrincipal(controlador);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            ConfirgurarToolTips(controlador);

            ConfigurarListagem(controlador);
        }

       
        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void ConfirgurarToolTips(ControladorBase controlador)
        {
            btnInserir.Text = controlador.ToolTipInserir;
            btnEditar.Text = controlador.ToolTipoEditar;
            btnExcluir.Text = controlador.ToolTipExcluir;

        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(listagem);
        }
    }
}