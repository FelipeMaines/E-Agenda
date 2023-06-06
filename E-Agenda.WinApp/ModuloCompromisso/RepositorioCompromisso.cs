using E_Agenda.Dominio.ModuloCompromisso;

namespace E_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioMemoriaBase<Compromisso>, IRepositorioCompromisso
    {
        private static int contador = 1;

        public RepositorioCompromisso(List<Compromisso> compromissos)
        {
            this.listaRegistros = compromissos;
        }
       
        public List<Compromisso> SelecionarCompromissosPassados(DateTime now)
        {
            List<Compromisso> compromissosPassados = new List<Compromisso>();

            foreach (Compromisso item in listaRegistros)
            {
                if(item.data < now)
                {
                    compromissosPassados.Add(item);
                }
            }
            return compromissosPassados;
        }

        public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicial, DateTime dataFinal)
        {
            List<Compromisso> compromissosFuturos = new List<Compromisso>();

            foreach (Compromisso item in listaRegistros)
            {
                if (item.data > dataInicial && item.data < dataFinal)
                {
                    compromissosFuturos.Add(item);
                }
            }
            return compromissosFuturos;
        }
    }
}
