
namespace E_Agenda.WinApp.ModuloContato
{
    public class RepositorioContato
    {
        List<Contato> contatos = new List<Contato>();
        private static int contador;

        public List<Contato> SelecionarTodos()
        {
            return contatos;
        }

        public void Inserir(Contato contato)
        {
            contador++;
            contato.id = contador;
            contatos.Add(contato);
        }
    }
}
