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

        public void VerififcarBotao()
        {
            if (radioFuturo.Checked)
            {
                gbDatasFuturo.Enabled = true;
            }

            else
                gbDatasFuturo.Enabled = false;
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
        
        private void radioTodos_CheckedChanged(object sender, EventArgs e)
        {
            VerififcarBotao();
        }

        private void radioPassado_CheckedChanged(object sender, EventArgs e)
        {
            VerififcarBotao();
        }

        private void radioFuturo_CheckedChanged(object sender, EventArgs e)
        {
            VerififcarBotao();
        }
    }
}
