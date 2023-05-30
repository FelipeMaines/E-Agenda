namespace E_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioMemoriaBase<Compromisso>
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
                if(DateTime.Parse(item.data) < now)
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
                if (DateTime.Parse(item.data) > dataInicial && DateTime.Parse(item.data) < dataFinal)
                {
                    compromissosFuturos.Add(item);
                }
            }
            return compromissosFuturos;
        }
    }
}
