namespace E_Agenda.WinApp.ModuloTarefa
{
    public class Itens : Entidade
    {
        public string descricao;
        public string concluida;
        public bool estado;

        public Itens(string descricao, string concluida)
        {
            this.descricao = descricao;
            this.concluida = concluida;
            estado = false;
        }

        public override string ToString()
        {
            return "Descricao: " + descricao + "\tEstado: " + concluida;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(descricao) || descricao.Length < 5)
                erros.Add("Campo descricao esta errado!");

            else if (string.IsNullOrEmpty(concluida))
                erros.Add("Campo concluida esta errado!");

            return erros.ToArray();
        }
    }
}

