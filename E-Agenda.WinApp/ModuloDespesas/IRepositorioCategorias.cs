﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.ModuloDespesas
{
    public interface IRepositorioCategorias
    {
        void Inserir(Categorias tarefa);
        List<Categorias> SelecionarTodos();
    }
}
