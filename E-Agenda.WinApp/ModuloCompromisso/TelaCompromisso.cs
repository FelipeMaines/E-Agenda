namespace E_Agenda.WinApp.ModuloCompromisso
{
    public partial class TelaCompromisso : Form
    {
        private Compromisso compromisso;
        public TelaCompromisso()
        {
            InitializeComponent();
        }

        public Compromisso Compromisso
        {
            set
            {
                tbIdCompromisso.Text = value.id.ToString();
                tbAssuntoCompromisso.Text = value.assunto;
                tbLocalCompromisso.Text = value.local;
                tbDateTime.Text = value.data.ToString();
                tbHoraInicioCompromisso.Text = value.horaInicio.ToString();
                tbHoraFinalCompromisso.Text = value.horaFinal.ToString();
            }
            get
            {
                return compromisso;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string assunto = tbAssuntoCompromisso.Text;
            string local = tbLocalCompromisso.Text;
            DateTime data = tbDateTime.Value;
            DateTime horaInicio = tbHoraInicioCompromisso.Value;
            DateTime horaFinal = tbHoraFinalCompromisso.Value;
            string online = caixaRadios.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;

            compromisso = new Compromisso(assunto, local, data, horaInicio, horaFinal, online);

            string[] erros = compromisso.Validar();

            if(erros.Length > 0)
            {
                Form1.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonPresencial_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
