namespace E_Agenda.WinApp.Compartilhado
{
    [Serializable]
    public abstract class BaseEntidade<TEntidade>
    {
        public int id;

        public abstract string[] Validar();

        public abstract void AtualizarInformacoes(TEntidade registroAtualizado);
    }
}
