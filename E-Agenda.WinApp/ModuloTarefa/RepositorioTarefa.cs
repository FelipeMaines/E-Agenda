
namespace E_Agenda.WinApp.ModuloTarefa
{
    public class RepositorioTarefa
    {
        public List<Tarefa> tarefas = new List<Tarefa>();

        private static int contador;

        public List<Tarefa> SelecionarTodos()
        {
            return tarefas;
        }

        public void Inserir(Tarefa tarefa)
        {
            contador++;
            tarefa.id = contador;
            tarefas.Add(tarefa);
        }

        public void Editar(Tarefa contato)
        {
            Tarefa tarefaSelecionada = SelecionarPorId(contato.id);

            tarefaSelecionada.nome = contato.nome;
            tarefaSelecionada.prioridade = contato.prioridade;
            
        }

        public Tarefa SelecionarPorId(int id)
        {
            return tarefas.FirstOrDefault(i => i.id == id);
        }

        public void Excluir(Tarefa tarefa)
        {
            tarefas.Remove(tarefa);
        }

        public List<Itens> SelecionarItensEmAberto(Tarefa tarefaSelecionada)
        {
            List<Itens> itens = new List<Itens>();

            foreach(Tarefa ta in tarefas) 
            {
                foreach (Itens item in ta.listaItens)
                {
                    if (item.estado == false)
                        itens.Add(item);
                }
            }

            return itens;
        }

        public List<Itens> SelecionarItensFinalizadas(Tarefa tarefaSelecionada)
        {
            List<Itens> itens = new List<Itens>();

            foreach (Tarefa ta in tarefas)
            {
                foreach (Itens item in ta.listaItens)
                {
                    if (item.estado == true)
                        itens.Add(item);
                }
            }

            return itens;
        }

        public List<Itens> SelecionarTodosItens(Tarefa tarefaSelecionada)
        {
            List<Itens> itens = new List<Itens>();

            foreach (Tarefa ta in tarefas)
            {
                foreach (Itens item in ta.listaItens)
                    itens.Add(item);
            }

            return itens;
        }
    }
}
