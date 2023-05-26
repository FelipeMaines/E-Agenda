using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace E_Agenda.WinApp.ModuloDespesas
{
    public partial class TelaCategoriasForm : Form
    {
        public TelaCategoriasForm()
        {
            InitializeComponent();
        }

        private Categorias categoria;

        public Categorias Categoria
        {
            set
            {
                tbNome.Text = value.nome;
                tbNumero.Text = value.numero;
                tbRua.Text = value.rua;
            }
            get
            {
                return categoria;
            }
        }

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = tbNome.Text;

            string numero = tbNumero.Text;

            string rua = tbRua.Text;

            categoria = new Categorias(nome, numero, rua);

            string[] erros = categoria.Validar();

            if (erros.Length > 0)
            {
                Form1.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
