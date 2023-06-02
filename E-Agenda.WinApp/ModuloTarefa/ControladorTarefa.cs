using E_Agenda.Dominio.ModuloTarefa;

namespace E_Agenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase
    {
        ListagemTarefaControl listagemTarefa;
        IRepositorioTarefa repositorioTarefa;
        public override string ToolTipInserir { get { return "Inserir Nova Tarefa"; } }

        public override string ToolTipoEditar { get { return "Editar Tarefa"; } }

        public override string ToolTipExcluir { get { return "Excluir Tarefa"; } }

        public override string ToolTipFiltrar { get { return "Filtrar itens"; } }

        public override string ToolTipAdicionaritens { get { return "Adicionar itens"; } }

        public override bool AdicionarItensHabilitado => true;

        public override bool ConcluirItensHabilitado => true;

        public override bool FiltrarHabilitado => true;


        public ControladorTarefa(IRepositorioTarefa repositorioTarefa)
        {
            this.repositorioTarefa = repositorioTarefa;
        }
        public override void Inserir()
        {
           
          TelaTarefaForm telaTarefa = new TelaTarefaForm();

            if(telaTarefa.ShowDialog() == DialogResult.OK)
            {
                Tarefa tarefa = telaTarefa.Tarefa;

                repositorioTarefa.Inserir(tarefa);
            }

            CarregarTarefas();
        }
        
        public override UserControl ObterListagem()
        {
            if (listagemTarefa == null)
                listagemTarefa = new ListagemTarefaControl();

            CarregarTarefas();

            return listagemTarefa;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tarefas";

        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodosItens();

            listagemTarefa.AtualizarRegistros(tarefas);
        }

        public override void Editar()
        {
            Tarefa tarefa = ObterTarefaSelecionada();

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                    "Edição de tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
            int id = 0;
            TelaTarefaForm telaTarefa = new TelaTarefaForm();
            telaTarefa.Tarefa = tarefa;
            id = tarefa.id;

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                telaTarefa.Tarefa.id = id;
                repositorioTarefa.Editar(id, telaTarefa.Tarefa);

                CarregarTarefas();
            }
        }

        public Tarefa ObterTarefaSelecionada()
        {
            int id = listagemTarefa.ObterIdSelecionado();

            return repositorioTarefa.SelecionarPorId(id);
        }

        public override void Excluir()
        {
            Tarefa tarefa = ObterTarefaSelecionada();

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                    "Exclusão de tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o contato {tarefa.nome}?", "Exclusão de Contatos",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTarefa.Excluir(tarefa);

                CarregarTarefas();
            }
        }

        public override void Filtro()
        {
            TelaFiltroForm telaFiltroForm = new TelaFiltroForm();
            

            if(telaFiltroForm.ShowDialog() == DialogResult.OK)
            {
                TelaFiltroForm.statusCompromissoEnumTarefa opcao = telaFiltroForm.StatusSelecionado;

                CarregarCompromissoComFiltro(opcao);
            }
        }

        private void CarregarCompromissoComFiltro(TelaFiltroForm.statusCompromissoEnumTarefa statusSelecionado)
        {
            List<Tarefa> item = new List<Tarefa>();
            bool precisa = true;

            switch (statusSelecionado)
            {
                case TelaFiltroForm.statusCompromissoEnumTarefa.aberto:

                    item = repositorioTarefa.SelecionarItensEmAberto();
                    break;

                case TelaFiltroForm.statusCompromissoEnumTarefa.finalizado:

                    item = repositorioTarefa.SelecionarItensFinalizadas();
                    break;

                case TelaFiltroForm.statusCompromissoEnumTarefa.todos:

                    item = repositorioTarefa.SelecionarTodosItens();
                    break;

                case TelaFiltroForm.statusCompromissoEnumTarefa.tareafas:
                    precisa = false;
                    CarregarTarefas();
                    break;
            }
            if(precisa)
            CarregarTarefas(item);

        }

        private void CarregarTarefas(List<Tarefa> item)
        {

            listagemTarefa.AtualizarRegistros(item);
        }

        public override void AdicionarItens()
        {
            TelaItensForm telaItem = new TelaItensForm();

            Tarefa tarefaSelecionada = ObterTarefaSelecionada();

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Uma tarefa deve estar selecionada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            telaItem.LimparTela();
            int i = 0;

            foreach (Itens item in tarefaSelecionada.listaItens)
                telaItem.AdicionarItem(item, ref i);

           

            if (telaItem.ShowDialog() == DialogResult.OK)
            {
                Itens item = telaItem.item;

                repositorioTarefa.InserirItem(tarefaSelecionada, item);
            }

            verificarConclusao(tarefaSelecionada);
            CarregarTarefas();
        }

        public override void ConcluirItens()
        {
            TelaConclusaoItensForm telaConclusao = new TelaConclusaoItensForm();

            Tarefa tarefaSelecionada = ObterTarefaSelecionada();

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Uma tarefa deve estar selecionada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            telaConclusao.LimparTela();
            int i = 0;

            foreach (Itens item in tarefaSelecionada.listaItens)
                telaConclusao.AdicionarItem(item, ref i);

            if (telaConclusao.ShowDialog() == DialogResult.OK)
            {
                telaConclusao.ConcluirItem(tarefaSelecionada);

                CarregarTarefas();
            }

            if (verificarConclusao(tarefaSelecionada))
                repositorioTarefa.ConcluirItem(tarefaSelecionada);

            CarregarTarefas();
        }

        public bool verificarConclusao(Tarefa tarefaSelecionada)
        {
            double contadorDeItens = tarefaSelecionada.listaItens.Count;
            double contadorDeConclusao = 0;

            contadorDeConclusao = tarefaSelecionada.listaItens.Count(item => item.estado == true);

            if (contadorDeItens == 0)
                return false;

            return repositorioTarefa.VerificarConclusao(tarefaSelecionada, contadorDeItens, contadorDeConclusao);
        }

        
    }
}
