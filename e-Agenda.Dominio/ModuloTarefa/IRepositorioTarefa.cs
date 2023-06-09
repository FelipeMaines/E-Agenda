﻿namespace E_Agenda.Dominio.ModuloTarefa
{
    public interface IRepositorioTarefa : IRepositorioBase<Tarefa>
    {
        void ConcluirItem(Tarefa tarefaSelecionada);
        void InserirItem(Tarefa tarefaSelecionada, Itens item);
        List<Tarefa> SelecionarItensEmAberto();
        List<Tarefa> SelecionarItensFinalizadas();
        List<Tarefa> SelecionarTodosItens();
        bool VerificarConclusao(Tarefa tarefaSelecionada, double contadorDeItens, double contadorDeConclusao);
    }
}
