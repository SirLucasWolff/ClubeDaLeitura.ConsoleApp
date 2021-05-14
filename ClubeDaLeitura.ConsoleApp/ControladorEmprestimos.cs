using ReadClub.ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public class ControladorEmprestimos
    {
        public static Emprestimo Registrar(List<Amiguinhos> amiguinhos)
        {
            Emprestimo emprestimo = new Emprestimo();

            Console.WriteLine("Digite o nome do Amiguinho:");
            emprestimo.nome = Console.ReadLine();

            Console.WriteLine("Digite o tipo de coleção da revista:");
            emprestimo.Colecao = Console.ReadLine();

            Console.WriteLine("Digite a data do emprestimo:");
            emprestimo.dataEmprestimo = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Digite a data de devolução:");
            emprestimo.dataDevolucao = Convert.ToDateTime(Console.ReadLine());

            Random rnd = new Random();
            emprestimo.id = rnd.Next();

            return emprestimo;
        }
    }
}
