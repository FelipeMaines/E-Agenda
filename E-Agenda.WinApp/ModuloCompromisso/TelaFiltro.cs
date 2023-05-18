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
    public partial class TelaFiltro : Form
    {
        public TelaFiltro()
        {
            InitializeComponent();
        }

        public enum statusCompromissoEnum
        {
            passado,
            futuro,
            todos
        }

        public statusCompromissoEnum StatusSelecionado
        {
            get
            {
                if (radioFuturo.Checked)
                    return statusCompromissoEnum.futuro;

                else if (radioPassado.Checked)
                    return statusCompromissoEnum.passado;

                else
                    return statusCompromissoEnum.todos;
            }
        }

        public DateTime PegarDataInicial()
        {
            string DataIncialtxt = tbDataInicial.Text;
            return DateTime.Parse(DataIncialtxt);
        }

        public DateTime PegarDataFinal()
        {
            string DataFinaltxt = tbDataFinal.Text;
            return DateTime.Parse(DataFinaltxt);
        }


    }
}
