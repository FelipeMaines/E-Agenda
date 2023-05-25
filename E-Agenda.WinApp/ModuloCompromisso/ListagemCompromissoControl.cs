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
            popularGrid();
            ConfiguracaoGrid.ConfigurarGridSomenteLeitura(grid);
            ConfiguracaoGrid.ConfigurarGridSomenteLeitura(grid);

        }

        public void AtualizarRegistros(List<Compromisso> compromissos)
        {
            grid.Rows.Clear();

            foreach (Compromisso item in compromissos)
            {
                grid.Rows.Add(item.id, item.assunto, item.data, item.horaInicio, item.horaFinal, item.online, item.local);
            }
        }

        public int ObterIdSelecionado()
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
                    Name = "assunto",
                    HeaderText = "Assunto"
                },
                  new DataGridViewTextBoxColumn()
                {
                    Name = "data",
                    HeaderText = "Dia"
                },
                   new DataGridViewTextBoxColumn()
                {
                    Name = "horaInicial",
                    HeaderText = "Hora Inicial"
                }, new DataGridViewTextBoxColumn()
                {
                    Name = "horaFinal",
                    HeaderText = "Hora Final"
                },
                   new DataGridViewTextBoxColumn()
                {
                    Name = "online",
                    HeaderText = "Plataforma"
                },
                   new DataGridViewTextBoxColumn()
                {
                    Name = "local",
                    HeaderText = "Local"
                }
            };

            grid.Columns.AddRange(colunas);
        }
    }
}
