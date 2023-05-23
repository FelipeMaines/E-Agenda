using E_Agenda.WinApp.ModuloCompromisso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaItensForm : Form
    {
        public Itens item;
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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            string concluida = CaixaRadiosStatus.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;

            item = new Itens(descricao, concluida);

        }

    }
}

