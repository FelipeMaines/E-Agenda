﻿

namespace E_Agenda.Dominio.ModuloCompromisso
{
    public interface IRepositorioCompromisso : IRepositorioBase<Compromisso>
    {
        List<Compromisso> SelecionarCompromissosPassados(DateTime now);
        List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicial, DateTime dataFinal);
    }
}
