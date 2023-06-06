namespace E_Agenda.WinApp.ModuloContato
{
    //public class RepositorioContatoArquivo : IRepositorioBase<Contato>
    public class RepositorioContatoArquivo : RepositorioArquivoBase<Contato>, IRepositorioContato
    {
        public RepositorioContatoArquivo(ContextoDados contextoDados) : base(contextoDados)
        {
        }

        protected override List<Contato> ObterRegistros()
        {
            return contextoDados.contatos;
        }
    }
}
