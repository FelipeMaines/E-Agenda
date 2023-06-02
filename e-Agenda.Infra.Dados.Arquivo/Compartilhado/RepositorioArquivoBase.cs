using E_Agenda.Dominio.Compartilhado;
using System.Collections.Generic;
using System.Linq;


namespace E_Agenda.Infra.Compartilhado
{
    public abstract class RepositorioArquivoBase<T> where T : BaseEntidade<T>
    {
        protected int contador;
        protected ContextoDados contextoDados;

        public RepositorioArquivoBase(ContextoDados contextoDados)
        {

            this.contextoDados = contextoDados;

            AtualizarContador();
        }

        protected abstract List<T> ObterRegistros();

        public void Inserir(T item)
        {
            List<T> registros = ObterRegistros();

            contador++;
            item.id = contador;
            registros.Add(item);

           contextoDados.GravarTarefasEmArquivo();
        }

        public void Editar(int id, T itemAtualizado)
        {
            T itemSelecionado = SelecionarPorId(id);

            itemSelecionado.AtualizarInformacoes(itemAtualizado);

            contextoDados.GravarTarefasEmArquivo();
        }

        public void Excluir(T itemSelecionado)
        {

            List<T> registros = ObterRegistros();

            registros.Remove(itemSelecionado);

            contextoDados.GravarTarefasEmArquivo();
        }

        public virtual List<T> SelecionarTodosItens()
        {
            return ObterRegistros();
        }

        public T SelecionarPorId(int id)
        {
            List<T> registros = ObterRegistros();

            return registros.FirstOrDefault(x => x.id == id);
        }

        private void AtualizarContador()
        {
            if (ObterRegistros().Count > 0)
                contador = ObterRegistros().Max(x => x.id);
            else
                contador = 0;
        }

        public List<T> SelecionarTodos()
        {
            return ObterRegistros();
        }

       

       
    }
}
