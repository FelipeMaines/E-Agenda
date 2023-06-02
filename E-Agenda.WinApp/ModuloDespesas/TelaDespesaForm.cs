using E_Agenda.WinApp.ModuloContato;
using E_Agenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static E_Agenda.WinApp.ModuloTarefa.TelaTarefaForm;

namespace E_Agenda.WinApp.ModuloDespesas
{
    public partial class TelaDespesaForm : Form
    {
        public TelaDespesaForm()
        {
            InitializeComponent();
            PopularCaixa();
        }

        private Despesa despesa;

        public Despesa Despesa
        {
            set
            {
                tbDescricao.Text = value.descricao;
                tbValor.Text = value.valor.ToString();
                tbData.Text = value.data.ToString();
            }
            get
            {
                return despesa;
            }
        }

        public void AtualizarListBox(List<Categorias> listaCategorias)
        {
            lbCategorias.Items.Clear();

            foreach (Categorias categorias in listaCategorias)
            {
                lbCategorias.Items.Add(categorias.nome);
            }
        }

        private void PopularCaixa()
        {
            EnumModoPagamento[] pagamentos = Enum.GetValues<EnumModoPagamento>();

            foreach (EnumModoPagamento pagamento in pagamentos)
            {
                cbPgto.Items.Add(pagamento);
            }
        }
    
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            string descricao = tbDescricao.Text;

            int valor = Convert.ToInt32(tbValor.Text);

            DateTime data = tbData.Value;

            EnumModoPagamento pgto = (EnumModoPagamento)cbPgto.SelectedItem;

            despesa = new Despesa(descricao, valor, data, pgto);

            string[] erros = despesa.Validar();

            if (erros.Length > 0)
            {
                Form1.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
