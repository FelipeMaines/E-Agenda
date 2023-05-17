using E_Agenda.WinApp.ModuloContato;
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
    public partial class TelaCompromisso : Form
    {
        private Compromisso compromisso;
        public TelaCompromisso()
        {
            InitializeComponent();
        }

        public Compromisso Compromisso
        {
            set
            {
                tbIdCompromisso.Text = value.id.ToString();
                tbAssuntoCompromisso.Text = value.assunto;
                tbLocalCompromisso.Text = value.local;
                tbDateTime.Text = value.data;
                tbHoraInicioCompromisso.Text = value.horaInicio;
                tbHoraFinalCompromisso.Text = value.horaFinal;
            }
            get
            {
                return compromisso;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string assunto = tbAssuntoCompromisso.Text;
            string local = tbLocalCompromisso.Text;
            string data = tbDateTime.Text;
            string horaInicio = tbHoraInicioCompromisso.Text;
            string horaFinal = tbHoraFinalCompromisso.Text;

            compromisso = new Compromisso(assunto, local, data, horaInicio, horaFinal);
        }
    }
}
