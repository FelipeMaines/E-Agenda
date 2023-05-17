using E_Agenda.WinApp.ModuloContato;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.ModuloCompromisso
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

        private Compromisso SelecionarPorId(int id)
        {
            return compromissos.FirstOrDefault(i => i.id == id);
        }

        internal void Excluir(Compromisso compromisso)
        {
            compromissos.Remove(compromisso);
        }
    }
}
