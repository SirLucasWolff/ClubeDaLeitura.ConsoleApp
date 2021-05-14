using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadClub.ConsoleApp
{
    public class Emprestimo
    {
        public string Colecao;
        public int id;
        public IEnumerable<object> revistas;
        public string nome;
        public DateTime dataEmprestimo;
        public DateTime dataDevolucao;
        public List<Amiguinhos> Amiguinhos = new List<Amiguinhos>();
    }
}
