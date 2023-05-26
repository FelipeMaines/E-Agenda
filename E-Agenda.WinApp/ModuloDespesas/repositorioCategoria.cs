using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.ModuloDespesas
{
    public class repositorioCategoria
    {
        List<Categorias> listaCategoria = new List<Categorias>();

        public void Inserir(Categorias categorias)
        {
            listaCategoria.Add(categorias);
        }

        public List<Categorias> SelecionarTodos()
        {
            return listaCategoria;
        }
    }
}
