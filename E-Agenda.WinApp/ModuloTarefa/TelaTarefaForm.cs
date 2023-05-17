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

namespace E_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaForm : Form
    {
        Tarefa tarefa;
        public TelaTarefaForm()
        {
            InitializeComponent();
        }

        public Tarefa Tarefa
        {
            set
            {
                tbIdTarefa.Text = value.id.ToString();
                tbNomeTarefa.Text = value.nome;
                tbPrioridadeTarefa.Text = value.prioridade;
            }
            get
            {
                return tarefa;
            }
        }
        private void id_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviarTarefa_Click(object sender, EventArgs e)
        {
            string nome = tbNomeTarefa.Text;
            string prioridade = tbPrioridadeTarefa.Text;
            string id = tbIdTarefa.Text;

            tarefa = new Tarefa(nome, prioridade);
        }
    }
}
