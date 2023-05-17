using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace E_Agenda.WinApp.ModuloContato
{
    public class Contato
    {
        public int id;
        public string nome;
        public string email;
        public string empresa;
        public string telefone;
        public string cargo;
        public Contato(string nome,string email,string telefone, string empresa, string cargo)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.empresa =empresa;
            this.email = email;
            this.cargo = cargo;
        }

        public override string ToString()
        {
            return "id: " + id + ", nome: " + nome + ", empresa: " + empresa;
        }
    }

}
