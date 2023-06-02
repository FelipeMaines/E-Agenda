using E_Agenda.Dominio.ModuloCompromisso;

namespace E_Agenda.Infra.Dados.Arquivo.ModuloCompromisso
{
    public class RepositorioCompromissoArquivo : RepositorioArquivoBase<Compromisso> , IRepositorioCompromisso 
    {
        public RepositorioCompromissoArquivo(ContextoDados contextoDados) : base(contextoDados)
        {
        }

        public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicial, DateTime dataFinal)
        {
            return ObterRegistros().Where(t => t.data > dataInicial && t.data < dataFinal).ToList();
        }

        public List<Compromisso> SelecionarCompromissosPassados(DateTime now)
        {
            return ObterRegistros().Where(t => t.data < DateTime.Now).ToList();
        }

        protected override List<Compromisso> ObterRegistros()
        {
            return contextoDados.compromissos;
        }
    }
}
