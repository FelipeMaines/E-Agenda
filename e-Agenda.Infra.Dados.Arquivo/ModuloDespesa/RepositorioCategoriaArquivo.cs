using E_Agenda.Dominio.ModuloDespesas;
using E_Agenda.Infra.Compartilhado;
using System.Collections.Generic;

namespace E_Agenda.Infra.Dados.Arquivo.ModuloDespesa
{
    public class RepositorioCategoriaArquivo : RepositorioArquivoBase<Categorias>, IRepositorioCategorias
    {
        public RepositorioCategoriaArquivo(ContextoDados contextoDados) : base(contextoDados)
        {
        }

        protected override List<Categorias> ObterRegistros()
        {
            return contextoDados.categorias;
        }
    }
}
