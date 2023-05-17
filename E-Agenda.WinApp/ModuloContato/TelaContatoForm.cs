using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace E_Agenda.WinApp.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        private Contato contato;
        public TelaContatoForm()
        {
            InitializeComponent();
        }

        public Contato Contato
        {
            set
            {
                tbIdContato.Text = value.id.ToString();
                tbNomeContato.Text = value.nome;
                tbTelefoneContato.Text = value.telefone;
                tbEmailContato.Text = value.email;
                tbCargoContato.Text = value.cargo;
                tbEmpresaContato.Text = value.empresa;
            }
            get
            {
                return contato;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = tbNomeContato.Text;

            string email = tbEmailContato.Text;

            string telefone = tbTelefoneContato.Text;

            string cargo = tbCargoContato.Text;

            string empresa = tbEmpresaContato.Text;

            contato = new Contato(nome, email, telefone, empresa, cargo);


        }

       
    }
}
