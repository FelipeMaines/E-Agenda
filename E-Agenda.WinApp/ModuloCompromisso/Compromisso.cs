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
        public string online;

        public Compromisso(string assunto, string local, string data, string horaInicio, string horaFinal, string online)
        {
            this.assunto = assunto;
            this.local = local;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaFinal = horaFinal;
            this.online = online;
        }

        public override string ToString()
        {
            return "id: " + id + "\tassunto: " + assunto + "\tlocal: " + local + "\tdata: " + data + "\thoraInicio: " + horaInicio + "\thoraFinal: " + horaFinal + "\n   Comrpromisso: " + online;
        }

        
    }
}
