using E_Agenda.WinApp.Compartilhado;
using E_Agenda.WinApp.ModuloContato;

namespace E_Agenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase
    {
        ListagemTarefaControl listagemTarefa;
        RepositorioTarefa repositorioTarefa;
        public override string ToolTipInserir { get { return "Inserir Nova Tarefa"; } }

        public override string ToolTipoEditar { get { return "Editar Tarefa"; } }

        public override string ToolTipExcluir { get { return "Excluir Tarefa"; } }

        public override string ToolTipFiltrar { get { return "Filtrar itens"; } }

        public override string ToolTipAdicionaritens { get { return "Ver itens"; } }

        public ControladorTarefa(RepositorioTarefa repositorioTarefa)
        {
            this.repositorioTarefa = repositorioTarefa;
        }
        public override void Inserir()
        {
           
                TelaTarefaForm telaTarefa = new TelaTarefaForm();

                telaTarefa.ShowDialog();

                Tarefa tarefa = telaTarefa.Tarefa;

                repositorioTarefa.Inserir(tarefa);

                CarregarTarefas();
            
        }

        private void InserirItem(Tarefa tarefaSelecionada)
        {
            
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
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();

            listagemTarefa.AtualizarRegistros(tarefas);
        }

        public override void Editar()
        {
            Tarefa tarefa = listagemTarefa.ObterTarefaSelecionada();

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
                repositorioTarefa.Editar(telaTarefa.Tarefa);

                CarregarTarefas();
            }
        }

        public override void Excluir()
        {
            Tarefa tarefa = listagemTarefa.ObterTarefaSelecionada();

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
            throw new NotImplementedException();
        }

        public override void AdicionarItens()
        {
            TelaItensForm telaItem = new TelaItensForm();

            Tarefa tarefaSelecionada = listagemTarefa.ObterTarefaSelecionada();

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
            TelaConclusaoItensForm telaConclusao = new TelaConclusaoItensForm(repositorioTarefa);

            Tarefa tarefaSelecionada = listagemTarefa.ObterTarefaSelecionada();

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
        }
    }
}
