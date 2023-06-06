namespace E_Agenda.WinApp.ModuloDespesas
{
    public class Despesa : BaseEntidade<Despesa>
    {
        public string descricao {  get; set; }
        public int valor { get; set; }
        public DateTime data { get; set; }
        public TelaDespesaForm.EnumModoPagamento pgto { get; set; }

        public Despesa()
        {
            
        }

        public Despesa(string descricao, int valor, DateTime data, TelaDespesaForm.EnumModoPagamento pgto1)
        {
            this.descricao = descricao;
            this.valor = valor;
            this.data = data;
            this.pgto = pgto1;
        }

        public override void AtualizarInformacoes(Despesa registroAtualizado)
        {
            this.descricao = registroAtualizado.descricao;
            this.pgto = registroAtualizado.pgto;
            this.data = registroAtualizado.data;
            this.valor = registroAtualizado.valor;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(descricao))
                erros.Add("Campo Descricao Incorreto");

            else if (valor < 0)
                erros.Add("Campo Valor Incorreto");

            else if (pgto == null)
                erros.Add("Selecione um modo de pagamento!");

            return erros.ToArray();
        }

        
    }
}
