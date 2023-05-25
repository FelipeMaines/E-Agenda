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

            popularGrid();
            ConfiguracaoGrid.ConfigurarGridSomenteLeitura(grid);
            ConfiguracaoGrid.ConfigurarGridZebrado(grid);

            tarefas.Add(new Tarefa("Fazer Pizza", TelaTarefaForm.PrioridadeTarefaEnum.Baixa));
            tarefas.Add(new Tarefa("e-Agenda", TelaTarefaForm.PrioridadeTarefaEnum.Alta));
        }

        public void AtualizarRegistros(List<Tarefa> tarefas)
        {
            grid.Rows.Clear();

            foreach (Tarefa tarefa in tarefas)
            {
                grid.Rows.Add(tarefa.id, tarefa.prioridade, tarefa.conclusao, tarefa.dataAbertura, tarefa.dataFinalizda);
            }
        }

        public void AtualizarRegistros(List<Itens> item)
        {
            grid.Rows.Clear();

            foreach (Itens it in item)
            {
                grid.Rows.Add(it.id, it.descricao, it.concluida);
            }
        }

        private void popularGrid()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                 new DataGridViewTextBoxColumn()
                {
                    Name = "prioridade",
                    HeaderText = "Prioridade"
                },
                  new DataGridViewTextBoxColumn()
                {
                    Name = "conclusao",
                    HeaderText = "% Conclusao"
                },
                   new DataGridViewTextBoxColumn()
                {
                    Name = "dataAbertura",
                    HeaderText = "Data de Abertura"
                }, new DataGridViewTextBoxColumn()
                {
                    Name = "dataFinalizada",
                    HeaderText = "Data de Finalizacao"
                }
            };

            grid.Columns.AddRange(colunas);
        }

        public int ObterIdSelecionado()
        {
            return Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);
        }
    }

}
