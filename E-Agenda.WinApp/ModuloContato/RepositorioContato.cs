using E_Agenda.WinApp.Compartilhado;

namespace E_Agenda.WinApp.ModuloContato
{
    public class RepositorioContato
    {
        List<Contato> contatos = new List<Contato>();
        private static int contador = 1;

        public List<Contato> SelecionarTodos()
        {
            return contatos;
        }

        public void Inserir(Contato contato)
        {
            contato.id = contador;
            contatos.Add(contato);
            contador++;
        }

        public void Editar(Contato contato)
        {
            Contato contatoSelecionado = SelecionarPorId(contato.id);

            contatoSelecionado.nome = contato.nome;
            contatoSelecionado.telefone = contato.telefone;
            contatoSelecionado.email = contato.email;
            contatoSelecionado.cargo = contato.cargo;
            contatoSelecionado.empresa = contato.empresa;
        }

        public Contato SelecionarPorId(int id)
        {
            return contatos.FirstOrDefault(x => x.id == id);
        }

        internal void Excluir(Contato contato)
        {
            contatos.Remove(contato);
        }

        
    }
}
