namespace E_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromissoArquivo : RepositorioArquivoBase<Compromisso> , IRepositorioCompromisso 
    {
     
        private const string NOME_ARQUIVO_COMPROMISSO = "C:\\temp\\compromissos\\dados-compromissos.bin";

        public RepositorioCompromissoArquivo() : base(NOME_ARQUIVO_COMPROMISSO)
        {
            
        }
       
        public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicial, DateTime dataFinal)
        {
            return base.listaRegistros.Where(t => t.data > dataInicial && t.data < dataFinal).ToList();
        }

        public List<Compromisso> SelecionarCompromissosPassados(DateTime now)
        {
            return base.listaRegistros.Where(t => t.data < DateTime.Now).ToList();
        }

    }
}
