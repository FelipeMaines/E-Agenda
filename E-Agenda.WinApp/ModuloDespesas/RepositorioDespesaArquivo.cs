using E_Agenda.WinApp.ModuloContato;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.ModuloDespesas
{
    public class RepositorioDespesaArquivo : IRepositorioDespesas
    {
        public RepositorioDespesaArquivo()
        {
            if (File.Exists(NOME_ARQUIVO_DESPESAS))
                CarregarArquivos();
        }

        private List<Despesa> listaDespesa = new List<Despesa>();
        private static int contador;
        private const string NOME_ARQUIVO_DESPESAS = "C:\\temp\\despesas\\dados-despesas.bin";

        public void Inserir(Despesa despesa)
        {
            contador++;
            despesa.id = contador;
            listaDespesa.Add(despesa);

            AtualizarArquivos();
        }

        public void Editar(int id, Despesa despesa)
        {
            Despesa despesaSelecioanda = SelecionarPorId(id);

            despesaSelecioanda.AtualizarInformacoes(despesa);

            AtualizarArquivos();
        }

        public void Excluir(Despesa despesaSelecionada)
        {
            listaDespesa.Remove(despesaSelecionada);

            AtualizarArquivos();
        }

        public Despesa SelecionarPorId(int id)
        {
            return listaDespesa.FirstOrDefault(d => d.id == id);
        }

        public List<Despesa> SelecionarTodos()
        {
            return listaDespesa;
        }

        private void CarregarArquivos()
        {
            string strJson = File.ReadAllText(NOME_ARQUIVO_DESPESAS);

            listaDespesa = JsonConvert.DeserializeObject<List<Despesa>>(strJson);

            AtualizarContador();
        }

        private void AtualizarArquivos()
        {
            string strJason = JsonConvert.SerializeObject(listaDespesa);

            File.WriteAllText(NOME_ARQUIVO_DESPESAS, strJason);
        }

        private void AtualizarContador()
        {
            if (listaDespesa.Count > 0)
                contador = listaDespesa.Max(x => x.id);
            else
                contador = 0;

        }
    }
}
