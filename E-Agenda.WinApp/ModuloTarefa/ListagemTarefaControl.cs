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
    public partial class ListagemTarefaControl : UserControl
    {
        List<Tarefa> tarefas = new List<Tarefa>();


        public ListagemTarefaControl()
        {
            InitializeComponent();

            tarefas.Add(new Tarefa(1, "Fazer Pizza", "Nivel: 9999"));
            tarefas.Add(new Tarefa(1, "e-Agenda", "Nivel: 1"));

            foreach (Tarefa tarefa in tarefas)
            {
                listTarefas.Items.Add(tarefa);
            }
        }

        private void ListagemTarefaControl_Load(object sender, EventArgs e)
        {

        }

        private void listTarefas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }

}
