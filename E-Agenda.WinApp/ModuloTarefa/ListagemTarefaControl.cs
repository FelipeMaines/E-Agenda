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

            tarefas.Add(new Tarefa("Fazer Pizza", "9999"));
            tarefas.Add(new Tarefa("e-Agenda", "1"));
        }

        public void AtualizarRegistros(List<Tarefa> tarefas)
        {
            listTarefas.Items.Clear();

            foreach (Tarefa tarefa in tarefas)
            {
                listTarefas.Items.Add(tarefa);
            }
        }

        public void AtualizarRegistros(List<Itens> item)
        {
            listTarefas.Items.Clear();

            foreach (Itens it in item)
            {
                listTarefas.Items.Add(it);
            }
        }

        internal Tarefa ObterTarefaSelecionada()
        {
            return (Tarefa)listTarefas.SelectedItem;
        }
    }

}
