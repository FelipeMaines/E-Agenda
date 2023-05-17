using System;
using System.Collections.Generic;
using System.Linq;
namespace E_Agenda.WinApp.ModuloCompromisso
{
    public class Compromisso
    {
        public string assunto;
        public string local;
        public string data;
        public string horaInicio;
        public string horaFinal;
        public int id;

        public Compromisso(string assunto, string local, string data, string horaInicio, string horaFinal)
        {
            this.assunto = assunto;
            this.local = local;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaFinal = horaFinal;
        }

        public override string ToString()
        {
            return "id: " + id + "\t assunto: " + assunto + "\t local: " + local + "\t data: " + data + "\t horaInicio: " + horaInicio + "\t horaFinal: " + horaFinal;
        }
    }
}
