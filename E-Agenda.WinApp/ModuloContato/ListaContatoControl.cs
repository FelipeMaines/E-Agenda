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

            contatos.Add(new Contato( "Felipe Maines", "uniplac", "a", "b", "d"));
            contatos.Add(new Contato("Alisson Scopel", "Academia programador", "a", "b", "d"));

            foreach (Contato contato in contatos)
            {
                listContato.Items.Add(contato);
            }
        }

    }

}
