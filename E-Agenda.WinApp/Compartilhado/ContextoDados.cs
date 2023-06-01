using E_Agenda.WinApp.ModuloContato;
using E_Agenda.WinApp.ModuloDespesas;
using E_Agenda.WinApp.ModuloTarefa;
using System.Text.Json.Serialization;
using System.Text.Json;


namespace E_Agenda.WinApp.Compartilhado
{
    public class ContextoDados
    {
        private const string NOME_ARQUIVO = "Compartilhado\\e-Agenda.json";

        public List<Contato> contatos;
        public List<Compromisso> compromissos;
        public List<Tarefa> tarefas;
        public List<Categorias> categorias;
        public List<Despesa> despesas;

        public ContextoDados()
        {
            contatos = new List<Contato>();
            compromissos = new List<Compromisso>();
            tarefas = new List<Tarefa>();
            categorias = new List<Categorias>();
            despesas = new List<Despesa>();
        }

        public ContextoDados(bool carregarDados) : this()
        {
           if(File.Exists(NOME_ARQUIVO) == false)
            {
                //NOME_ARQUIVO = File.Create(NOME_ARQUIVO).ToString();
            }

            CarregarArquivo();
        }

        public void GravarTarefasEmArquivo()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            string strJason = JsonSerializer.Serialize(this, config);

            File.WriteAllText(NOME_ARQUIVO, strJason);
        }

        public void CarregarArquivo()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            if(File.Exists(NOME_ARQUIVO))
            {
                string strJson = File.ReadAllText(NOME_ARQUIVO);

                if(strJson.Length > 0)
                {
                    ContextoDados ctx = JsonSerializer.Deserialize<ContextoDados>(strJson, config);

                    this.contatos = ctx.contatos;
                    this.tarefas = ctx.tarefas;
                    this.categorias = ctx.categorias;
                    this.compromissos = ctx.compromissos;
                    this.despesas = ctx.despesas;
                }
            }
        }

        private static JsonSerializerOptions ObterConfiguracoes()
        {
            JsonSerializerOptions opcoes = new JsonSerializerOptions();
            opcoes.IncludeFields = true;
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            return opcoes;
        }
    }
}
