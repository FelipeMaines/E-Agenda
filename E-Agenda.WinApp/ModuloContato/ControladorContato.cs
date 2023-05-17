using E_Agenda.WinApp.Compartilhado;

namespace E_Agenda.WinApp.ModuloContato
{
    public class ControladorContato : ControladorBase
    {
        private RepositorioContato repositorioContato;

        private ListaContatoControl listagemContato;

        public override string ToolTipInserir { get { return "Inserir Novo Contato"; } }

        public override string ToolTipoEditar { get { return "Editar Contato"; } }

        public override string ToolTipExcluir { get { return "Excluir Contato"; } }

        public ControladorContato(RepositorioContato repositorioContato)
        {
            this.repositorioContato = repositorioContato;
        }

        public override void Inserir()
        {
            TelaContatoForm telaContato = new TelaContatoForm();

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

        }

        public override UserControl ObterListagem()
        {
            return new ListaContatoControl();
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Contatos";
        }
    }
    
}
