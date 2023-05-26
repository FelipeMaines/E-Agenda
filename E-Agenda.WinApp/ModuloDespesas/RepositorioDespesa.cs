using E_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.ModuloDespesas
{
    public class RepositorioDespesa
    {
        List<Despesa> despesas = new List<Despesa>();
        private static int contador = 1;

        public List<Despesa> SelecionarTodos()
        {
            return despesas;
        }

        public void Inserir(Despesa despesa)
        {
            despesa.id = contador;
            despesas.Add(despesa);
            contador++;
        }

        public void Editar(Despesa despesa)
        {
            Despesa despesaSelecionada = SelecionarPorId(despesa.id);

            despesaSelecionada.descricao = despesa.descricao;
            despesaSelecionada.pgto = despesa.pgto;
            despesaSelecionada.data = despesa.data;
            despesaSelecionada.valor = despesa.valor;
        }

        public Despesa SelecionarPorId(int id)
        {
            return despesas.FirstOrDefault(x => x.id == id);
        }

        internal void Excluir(Despesa despesa)
        {
            despesas.Remove(despesa);
        }

    }
}
