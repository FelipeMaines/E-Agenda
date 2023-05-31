namespace E_Agenda.WinApp.ModuloContato
{
    //public class RepositorioContatoArquivo : IRepositorioBase<Contato>
    public class RepositorioContatoArquivo : RepositorioArquivoBase<Contato>, IRepositorioContato
    {
        private const string NOME_ARQUIVO_CONTATO = "C:\\temp\\contatos\\dados-contatos.bin";

        public RepositorioContatoArquivo() : base(NOME_ARQUIVO_CONTATO)
        {
            
        }

       
    }
}
