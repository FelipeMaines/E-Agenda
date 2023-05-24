namespace E_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaFiltroForm : Form
    {
        public TelaFiltroForm()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        public enum statusCompromissoEnumTarefa
        {
            todos,
            aberto,
            finalizado,
            tareafas
        }

        public statusCompromissoEnumTarefa StatusSelecionado
        {
            get
            {
                if (radioAberto.Checked)
                    return statusCompromissoEnumTarefa.aberto;

                else if (radioConcluido.Checked)
                    return statusCompromissoEnumTarefa.finalizado;

                else if (radioTodos.Checked)
                    return statusCompromissoEnumTarefa.todos;

                else
                    return statusCompromissoEnumTarefa.tareafas;
            }
        }


    }
}
