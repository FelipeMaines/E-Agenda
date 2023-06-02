using E_Agenda.Dominio.ModuloTarefa;

namespace E_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaConclusaoItensForm : Form
    {
        public List<Itens> itensConcluidos = new List<Itens>();
        public TelaConclusaoItensForm()
        {
            InitializeComponent();
        }

        public Itens itens
        {
            set
            {
                //txtDescricao.Text = value.descricao;
            }
            get
            {
                return itens;
            }
        }

        public void AdicionarItem(Itens item, ref int i)
        {
            lbListaitens.Items.Add(item.descricao);

            if (item.estado)
                lbListaitens.SetItemChecked(i, true);

            i++;
        }

        public void LimparTela()
        {
            lbListaitens.Items.Clear();
        }

        private void btnConclusao_Click(object sender, EventArgs e)
        {
            btnConclusao.DialogResult = DialogResult.OK;
        }

        public void ConcluirItem(Tarefa tarefaSelecionada)
        {
            List<Itens> itensARemover = new List<Itens>();

            foreach (string descricaoItem in lbListaitens.CheckedItems)
            {
                foreach (Itens item in tarefaSelecionada.listaItens.FindAll(i => i.descricao == descricaoItem))
                {
                    if (item.descricao == descricaoItem)
                    {
                        tarefaSelecionada.listaItensProntos.Add(item);
                        item.estado = true;
                        item.concluida = "Concluida";
                    }
                    else
                    {
                        item.concluida = "Em andamento!";
                        item.estado = false;
                    }
                }
            }
        }
    }
}
