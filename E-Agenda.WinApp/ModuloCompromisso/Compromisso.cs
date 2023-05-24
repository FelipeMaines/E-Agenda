using E_Agenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
namespace E_Agenda.WinApp.ModuloCompromisso
{
    public class Compromisso : Entidade
    {
        public string assunto;
        public string local;
        public string data;
        public string horaInicio;
        public string horaFinal;
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
            return "id: " + id + "\tassunto: " + assunto + "\tlocal: " + local + "\tdata: " + data + "\thoraInicio: " + horaInicio + "\thoraFinal: " + horaFinal + "  Comrpromisso: " + online;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(assunto) || assunto.Length < 3)
                erros.Add("Campo assunto esta invalido!");

            else if (string.IsNullOrEmpty(local))
                erros.Add("Campo local esta invalido!");

            else if (horaFinal == horaInicio)
                erros.Add("O compromisso nao pode comecar e terminar na mesmo hora!");

            else if (DateTime.Parse(horaFinal) < DateTime.Parse(horaInicio))
                erros.Add("O compromisso nao volta no tempo!");

            return erros.ToArray();
        }
    }
}
