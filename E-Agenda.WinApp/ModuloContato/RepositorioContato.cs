namespace E_Agenda.WinApp.ModuloContato
{
    public class RepositorioContato : RepositorioMemoriaBase<Contato>, IRepositorioBase<Contato>
    {
        public RepositorioContato(List<Contato> contatos)
        {
            this.listaRegistros = contatos;
        }

    }
}
