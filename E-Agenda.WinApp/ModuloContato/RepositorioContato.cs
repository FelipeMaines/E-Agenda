namespace E_Agenda.WinApp.ModuloContato
{
    public class RepositorioContato : RepositorioMemoriaBase<Contato>, IRepositorioContato
    {
        public RepositorioContato(List<Contato> contatos)
        {
            this.listaRegistros = contatos;
        }

    }
}
