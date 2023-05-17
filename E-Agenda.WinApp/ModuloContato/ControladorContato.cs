using E_Agenda.WinApp.Compartilhado;
using System.Text.RegularExpressions;

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

            if(opcaoEscolhida == DialogResult.OK)
            {
                Contato contato = telaContato.Contato;

                if (Verificar(ref telaContato, ref opcaoEscolhida, ref contato))
                {
                repositorioContato.Inserir(contato);
                CarregarContatos();
                }
            }

            else
            {
                MessageBox.Show("Cancelado!");
                return;
            }
        }

        private void RechamarVerificacao(ref TelaContatoForm telaContato, ref DialogResult opcaoEscolhida, ref Contato contato)
        {
            telaContato = new TelaContatoForm();

            opcaoEscolhida = telaContato.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                contato = telaContato.Contato;

                if(Verificar(ref telaContato, ref opcaoEscolhida, ref contato))
                {
                    repositorioContato.Inserir(contato);

                    CarregarContatos();
                }

            }

            else
                return;
        }

                

        public bool IsValidEmail(string email)
        {
            string pattern = @"^[\w\.-]+@[\w\.-]+\.\w+$";

            Match match = Regex.Match(email, pattern, RegexOptions.IgnoreCase);

            return match.Success;
        }

        private bool isValidNumber(string numero)
        {
            if (numero.Length != 11)
                return false;

            return true;
        }

        private bool Verificar(ref TelaContatoForm telaContato, ref DialogResult opcaoEscolhida, ref Contato contato)
        {

            if(!IsValidEmail(contato.email))
            {
                MessageBox.Show("Email Invalido");
                RechamarVerificacao(ref telaContato, ref opcaoEscolhida, ref contato);
                return false;
            }

            if(!isValidNumber(contato.telefone))
            {
                MessageBox.Show("Numero de telefone deve ter 11 digitos");
                RechamarVerificacao(ref telaContato, ref opcaoEscolhida, ref contato);
                return false;
            }

            return true;
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
            Contato contato = listagemContato.ObterContatoSelecionado();

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
                repositorioContato.Editar(telaContato.Contato);

                CarregarContatos();
            }
        }

        public override void Excluir()
        {
            Contato contato = listagemContato.ObterContatoSelecionado();

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

      
    }
    
}
