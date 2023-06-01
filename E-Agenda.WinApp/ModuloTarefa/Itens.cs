namespace E_Agenda.WinApp.ModuloTarefa
{
    [Serializable]
    public class Itens : BaseEntidade<Itens>
    {
        public string descricao;
        public string concluida;
        public bool estado;

        public Itens()
        {
            
        }

        public Itens(string descricao, string concluida)
        {
            this.descricao = descricao;
            this.concluida = concluida;
            estado = false;
        }

        public override void AtualizarInformacoes(Itens registroAtualizado)
        {
            MessageBox.Show("Test");
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

