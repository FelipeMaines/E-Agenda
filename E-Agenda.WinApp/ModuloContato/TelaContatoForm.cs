using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda.WinApp.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        public TelaContatoForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = tbNomeContato.Text;

            string email = tbEmailContato.Text;

            string telefone = tbTelefoneContato.Text;

            string cargo = tbCargoContato.Text;

            string empresa = tbEmpresaContato.Text;

            Contato contato = new Contato(nome, email, telefone, empresa, cargo);

            
        }
    }
}
