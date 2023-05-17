using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda.WinApp.ModuloCompromisso
{
    public partial class ListagemCompromissoControl : UserControl
    {
        public ListagemCompromissoControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Compromisso> compromissos)
        {
            listaCompromissos.Items.Clear();

            foreach (Compromisso item in compromissos)
            {
                listaCompromissos.Items.Add(item);
            }
        }

        public Compromisso ObterContatoSelecionado()
        {
            return (Compromisso)listaCompromissos.SelectedItem;
        }
    }
}
