using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda.WinApp.ModuloContato
{
    public partial class ListaContatoControl : UserControl
    {
        public ListaContatoControl()
        {
            InitializeComponent();
            popularGrid();
            ConfiguracaoGrid.ConfigurarGridZebrado(grid);
            ConfiguracaoGrid.ConfigurarGridSomenteLeitura(grid);
        }

        //public void ConfigurarGridZebrado()
        //{
        //    Font font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);

        //    DataGridViewCellStyle linhaEscura = new DataGridViewCellStyle
        //    {
        //        BackColor = Color.LightGray,
        //        Font = font,
        //        ForeColor = Color.Black,
        //        SelectionBackColor = Color.LightYellow,
        //        SelectionForeColor = Color.Black
        //    };

        //    grid.AlternatingRowsDefaultCellStyle = linhaEscura;

        //    DataGridViewCellStyle linhaClara = new DataGridViewCellStyle
        //    {
        //        BackColor = Color.White,
        //        Font = font,
        //        SelectionBackColor = Color.LightYellow,
        //        SelectionForeColor = Color.Black
        //    };

        //    grid.RowsDefaultCellStyle = linhaClara; 
        //}

        //public void ConfigurarGridSomenteLeitura()
        //{
        //    grid.AllowUserToAddRows = false;
        //    grid.AllowUserToDeleteRows = false;
        //    grid.AllowUserToResizeRows = false;

        //    grid.BorderStyle = BorderStyle.None;
        //    grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

        //    grid.MultiSelect = false;
        //    grid.ReadOnly = true;

        //    grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    grid.AutoGenerateColumns = false;
        //}

        public void AtualizarRegistros(List<Contato> contatos)
        {
            grid.Rows.Clear();

            foreach (Contato contato in contatos)
            {
                grid.Rows.Add(contato.id, contato.nome, contato.empresa, contato.email, contato.telefone);
            }
        }

       
        public int ObterIdSelecionado()
        {
            int id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);

            return id;
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    Name = "nome",
                    HeaderText = "Nome"
                },
                  new DataGridViewTextBoxColumn()
                {
                    Name = "empresa",
                    HeaderText = "Empresa"
                },
                   new DataGridViewTextBoxColumn()
                {
                    Name = "telefone",
                    HeaderText = "Telefone"
                }, new DataGridViewTextBoxColumn()
                {
                    Name = "cargo",
                    HeaderText = "Cargo"
                }
            };

            grid.Columns.AddRange(colunas);
        }
    }

}
