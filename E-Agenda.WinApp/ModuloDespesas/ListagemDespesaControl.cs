using E_Agenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda.WinApp.ModuloDespesas
{
    public partial class ListagemDespesaControl : UserControl
    {
        public ListagemDespesaControl()
        {
            InitializeComponent();
            popularGrid();
            ConfiguracaoGrid.ConfigurarGridSomenteLeitura(grid);
            ConfiguracaoGrid.ConfigurarGridZebrado(grid);
        }

        public void AtualizarRegistros(List<Despesa> despesas)
        {
            grid.Rows.Clear();

            foreach (Despesa despesa in despesas)
            {
                grid.Rows.Add(despesa.id, despesa.descricao, despesa.valor, despesa.data, despesa.pgto);
            }
        }

        internal int ObterIdSelecionado()
        {
            return Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);
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
                    Name = "descricao",
                    HeaderText = "Descricao"
                },
                  new DataGridViewTextBoxColumn()
                {
                    Name = "valor",
                    HeaderText = "Valor"
                },

                  new DataGridViewTextBoxColumn()
                {
                    Name = "data",
                    HeaderText = "Data"
                },

                  new DataGridViewTextBoxColumn()
                {
                    Name = "modoPagamento",
                    HeaderText = "Forma Pgto"
                }
            };

            grid.Columns.AddRange(colunas);
        }
    }
}
