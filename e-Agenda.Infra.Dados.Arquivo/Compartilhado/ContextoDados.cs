﻿using E_Agenda.Dominio.ModuloContato;
using E_Agenda.Dominio.ModuloDespesas;
using System.Text.Json.Serialization;
using System.Text.Json;
using E_Agenda.Dominio.ModuloCompromisso;
using System.Collections.Generic;
using E_Agenda.Dominio.ModuloTarefa;
using System.IO;

namespace E_Agenda.Infra.Compartilhado
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
