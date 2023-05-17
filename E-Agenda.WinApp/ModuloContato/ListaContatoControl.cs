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
    public partial class ListaContatoControl : UserControl
    {
        List<Contato> contatos = new List<Contato>();   

        public ListaContatoControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Contato> contatos)
        {
            listContato.Items.Clear();

            foreach (Contato item in contatos)
            {
                listContato.Items.Add(item);
            }
        }

        internal Contato ObterContatoSelecionado()
        {
            return (Contato)listContato.SelectedItem;
        }
    }

}
