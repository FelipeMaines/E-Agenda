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
    public partial class TelaFiltroForm : Form
    {
        public TelaFiltroForm()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        public enum statusCompromissoEnumTarefa
        {
            todos,
            aberto,
            finalizado
        }

        public statusCompromissoEnumTarefa StatusSelecionado
        {
            get
            {
                if (radioAberto.Checked)
                    return statusCompromissoEnumTarefa.aberto;

                else if (radioConcluido.Checked)
                    return statusCompromissoEnumTarefa.finalizado;

                else
                    return statusCompromissoEnumTarefa.todos;
            }
        }

       
    }
}
