
namespace E_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaItensForm : Form
    {
        public Itens item;
        public static int contador;
        public TelaItensForm()
        {
            InitializeComponent();
        }

        public Itens itens
        {
            set
            {
                txtDescricao.Text = value.descricao;
            }
            get
            {
                return item;
            }
        }

        public void AdicionarItem(Itens item, ref int i)
        {
              lbListaitens.Items.Add(item.descricao);

                if (item.estado)
                    lbListaitens.SetItemChecked(i, true);

                i++;
            
        }

        internal void LimparTela()
        {
            lbListaitens.Items.Clear();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            string concluida = "";
            concluida = CaixaRadiosStatus.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Tag.ToString();

            item = new Itens(descricao, concluida);
            item.id = contador;
            contador++;

            string[] erros = itens.Validar();

            if (erros.Length > 0)
            {
                Form1.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }

        }

    }
}

