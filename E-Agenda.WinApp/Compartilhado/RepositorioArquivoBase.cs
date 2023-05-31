using E_Agenda.WinApp.ModuloContato;
using E_Agenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.Compartilhado
{
    public class RepositorioArquivoBase<T> where T : BaseEntidade<T>
    {
        protected List<T> listaRegistros = new List<T>();
        protected int contador;
        protected string nomeArquivo = "C:\\temp\\contatos\\dados-contatos.json";
        protected string NomeArquivo
        {
            get
            {
                return this.nomeArquivo;
            }

            set
            {
                this.nomeArquivo = value;
            }
        }
        public RepositorioArquivoBase(string caminho)
        {
            nomeArquivo = caminho;
            if (File.Exists(nomeArquivo))
                CarregarArquivo();
        }

        public void Inserir(T item)
        {
            contador++;
            item.id = contador;
            listaRegistros.Add(item);

            GravarTarefasEmArquivo();
        }

        public void Editar(int id, T itemAtualizado)
        {
            T itemSelecionado = SelecionarPorId(id);

            itemSelecionado.AtualizarInformacoes(itemAtualizado);

            GravarTarefasEmArquivo();
        }

        public void Excluir(T itemSelecionado)
        {
            listaRegistros.Remove(itemSelecionado);

            GravarTarefasEmArquivo();
        }

        public virtual List<T> SelecionarTodosItens()
        {
            return listaRegistros;
        }

        public T SelecionarPorId(int id)
        {
            return listaRegistros.FirstOrDefault(x => x.id == id);
        }

        private void AtualizarContador()
        {
            if (listaRegistros.Count > 0)
                contador = listaRegistros.Max(x => x.id);
            else
                contador = 0;
        }

        public List<T> SelecionarTodos()
        {
            return listaRegistros;
        }

        protected void GravarTarefasEmArquivo()
        {
            string strJason = JsonConvert.SerializeObject(listaRegistros);

            File.WriteAllText(NomeArquivo, strJason);
        }

        private void CarregarArquivo()
        {
            string strJson = File.ReadAllText(NomeArquivo);

            listaRegistros = JsonConvert.DeserializeObject<List<T>>(strJson);

            AtualizarContador();
        }

       
    }
}
