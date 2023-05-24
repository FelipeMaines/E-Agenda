namespace E_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaForm : Form
    {
        Tarefa tarefa;
        public TelaTarefaForm()
        {
            InitializeComponent();
            CarregarTarefas();
        }

        public Tarefa Tarefa
        {
            set
            {
                tbIdTarefa.Text = value.id.ToString();
                tbNomeTarefa.Text = value.nome;
            }
            get
            {
                return tarefa;
            }
        }
        private void id_Click(object sender, EventArgs e)
        {

        }

        public enum PrioridadeTarefaEnum
        {
            Baixa, Normal, Alta
        }

        private void CarregarTarefas()
        {
            PrioridadeTarefaEnum[] prioridades = Enum.GetValues<PrioridadeTarefaEnum>();

            foreach (PrioridadeTarefaEnum prioridade in prioridades)
            {
                cbPrioridade.Items.Add(prioridade);
            }
        }

        private void btnEnviarTarefa_Click(object sender, EventArgs e)
        {
            string nome = tbNomeTarefa.Text;

            //string prioridade = tbPrioridadeTarefa.Text;
            string id = tbIdTarefa.Text;

            PrioridadeTarefaEnum prioridade = (PrioridadeTarefaEnum)cbPrioridade.SelectedItem;

            tarefa = new Tarefa(nome, prioridade);

            string[] erros = tarefa.Validar();

            if (erros.Length > 0)
            {
                Form1.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }


    }
}
