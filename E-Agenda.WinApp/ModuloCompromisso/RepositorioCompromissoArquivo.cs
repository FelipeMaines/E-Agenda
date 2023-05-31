using E_Agenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromissoArquivo : IRepositorioCompromisso
    {
        public RepositorioCompromissoArquivo()
        {
            if (File.Exists(NOME_ARQUIVO_COMPROMISSO))
                CarregarArquivo();
        }

        private List<Compromisso> compromissos = new List<Compromisso>();
        private static int contador;
        private const string NOME_ARQUIVO_COMPROMISSO = "C:\\temp\\compromissos\\dados-compromissos.bin";

        public void Inserir(Compromisso compromisso)
        {
            contador++;
            compromisso.id = contador;
            compromissos.Add(compromisso);

            AtualizarArquivo();
        }

        public void Editar(int id, Compromisso compromissoAtualizado)
        {
            Compromisso compromissoSelecionado = SelecionarPorId(id);

            compromissoSelecionado.AtualizarInformacoes(compromissoAtualizado);

            AtualizarArquivo();
        }

        public void Excluir(Compromisso compromissoSelecionado)
        {
            compromissos.Remove(compromissoSelecionado); 

            AtualizarArquivo();
        }

        public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicial, DateTime dataFinal)
        {
            return compromissos.Where(t => t.data > dataInicial && t.data < dataFinal).ToList();
        }

        public List<Compromisso> SelecionarCompromissosPassados(DateTime now)
        {
            return compromissos.Where(t => t.data < DateTime.Now).ToList();
        }

        public Compromisso SelecionarPorId(int id)
        {
            return compromissos.FirstOrDefault(x => x.id == id);
        }

        public List<Compromisso> SelecionarTodos()
        {
            return compromissos;
        }

        private void AtualizarArquivo()
        {
            string srtJson = JsonConvert.SerializeObject(compromissos);

            File.WriteAllText(NOME_ARQUIVO_COMPROMISSO, srtJson);
        }

        private void CarregarArquivo()
        {
            string strJson = File.ReadAllText(NOME_ARQUIVO_COMPROMISSO);

            compromissos = JsonConvert.DeserializeObject<List<Compromisso>>(strJson);

            AtualizarContador();
        }

        private void AtualizarContador()
        {
            contador = compromissos.Max(x => x.id);
        }
    }
}
