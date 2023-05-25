﻿namespace E_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromisso
    {
        List<Compromisso> compromissos = new List<Compromisso>();

        private static int contador = 1;
        public List<Compromisso> SelecionarTodos()
        {
            return compromissos;
        }

        public void Inserir(Compromisso compromisso)
        {
            compromisso.id = contador;
            compromissos.Add(compromisso);
            contador++;
        }

        public void Editar(Compromisso compromisso)
        {

            Compromisso compromissoSelecionado = SelecionarPorId(compromisso.id);

            compromissoSelecionado.assunto = compromisso.assunto;
            compromissoSelecionado.local = compromisso.local;
            compromissoSelecionado.data = compromisso.data;
            compromissoSelecionado.horaInicio = compromisso.horaInicio;
            compromissoSelecionado.horaFinal = compromisso.horaFinal;
        }

        public Compromisso SelecionarPorId(int id)
        {
            return compromissos.FirstOrDefault(i => i.id == id);
        }

        public void Excluir(Compromisso compromisso)
        {
            compromissos.Remove(compromisso);
        }

        public List<Compromisso> SelecionarCompromissosPassados(DateTime now)
        {
            List<Compromisso> compromissosPassados = new List<Compromisso>();

            foreach (Compromisso item in compromissos)
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

            foreach (Compromisso item in compromissos)
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
