
using static E_Agenda.WinApp.ModuloDespesas.TelaDespesaForm;

namespace E_Agenda.WinApp.ModuloDespesas
{
    public class Despesa : Entidade
    {
        public string descricao {  get; set; }
        public int valor { get; set; }
        public DateTime data { get; set; }
        public EnumModoPagamento pgto { get; set; }

        public Despesa(string descricao, int valor, DateTime data, EnumModoPagamento pgto)
        {
            this.descricao = descricao;
            this.valor = valor;
            this.data = data;
            this.pgto = pgto;
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
