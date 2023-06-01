
namespace E_Agenda.WinApp.ModuloCompromisso
{
    public class Compromisso : BaseEntidade<Compromisso>
    {
        public string assunto;
        public string local;
        public DateTime data;
        public DateTime horaInicio;
        public DateTime horaFinal;
        public string online;

        public Compromisso()
        {
            
        }
        public Compromisso(string assunto, string local, DateTime data, DateTime horaInicio, DateTime horaFinal, string online)
        {
            this.assunto = assunto;
            this.local = local;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaFinal = horaFinal;
            this.online = online;
        }

        public override void AtualizarInformacoes(Compromisso registroAtualizado)
        {
            this.assunto = registroAtualizado.assunto;
            this.local = registroAtualizado.local;
            this.data = registroAtualizado.data;
            this.horaInicio = registroAtualizado.horaInicio;
            this.horaFinal = registroAtualizado.horaFinal;
            this.online = registroAtualizado.online;
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

            return erros.ToArray();
        }
    }
}
