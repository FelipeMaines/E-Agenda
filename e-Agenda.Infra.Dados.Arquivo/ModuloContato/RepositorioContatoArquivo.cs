using E_Agenda.Dominio.ModuloContato;
using E_Agenda.Infra.Compartilhado;
using System.Collections.Generic;

namespace E_Agenda.Infra.Dados.Arquivo.ModuloContato
{
    //public class RepositorioContatoArquivo : IRepositorioBase<Contato>
    public class RepositorioContatoArquivo : RepositorioArquivoBase<Contato>, IRepositorioContato
    {
        public RepositorioContatoArquivo(ContextoDados contextoDados) : base(contextoDados)
        {
        }

        protected override List<Contato> ObterRegistros()
        {
            return contextoDados.contatos;
        }
    }
}
