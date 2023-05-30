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

            foreach (Itens item in tarefaSelecionada.listaItens)
            {
                telaItem.AdicionarItem(item);
            }

            if (telaItem.ShowDialog() == DialogResult.OK)
            {
                Itens item = telaItem.item;

                tarefaSelecionada.listaItens.Add(item);
            }
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

            foreach (Itens item in tarefaSelecionada.listaItens)
            {
                telaConclusao.AdicionarItem(item);
            }

            if (telaConclusao.ShowDialog() == DialogResult.OK)
            {
                telaConclusao.ConcluirItem(tarefaSelecionada);

                CarregarTarefas();
            }

            if (verificarConclusao(tarefaSelecionada))
            {
                tarefaSelecionada.dataFinalizda = DateTime.Now;
                tarefaSelecionada.estaFinalizada = true;
            }
        }

        public bool verificarConclusao(Tarefa tarefaSelecionada)
        {
            int contadorDeItens = tarefaSelecionada.listaItens.Count;
            int contadorDeConclusao = 0;

            contadorDeConclusao = tarefaSelecionada.listaItens.Count(item => item.estado == true);

            if (contadorDeItens == 0)
                return false; 

            tarefaSelecionada.conclusao = (contadorDeConclusao / contadorDeItens) * 100;

            if (tarefaSelecionada.conclusao == 100)
            {
                return true;
            }

            return false;
        }
    }
}
