using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaConclusaoItensForm : Form
    {
        private RepositorioTarefa repositorioTarefa;

        public List<Itens> itensConcluidos = new List<Itens>();
        public TelaConclusaoItensForm(RepositorioTarefa repositorioTarefa)
        {
            InitializeComponent();
            this.repositorioTarefa = repositorioTarefa;
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

        internal void AdicionarItem(Itens item)
        {
            lbListaitens.Items.Add(item.descricao);
        }

        internal void LimparTela()
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
                foreach (Itens item in tarefaSelecionada.listaItens)
                {
                    if (item.descricao == descricaoItem)
                    {
                        tarefaSelecionada.listaItensProntos.Add(item);
                        itensARemover.Add(item);
                    }
                }
            }

            foreach (Itens itemRemover in itensARemover)
            {
                tarefaSelecionada.listaItens.Remove(itemRemover);
            }
        }
    }
}
