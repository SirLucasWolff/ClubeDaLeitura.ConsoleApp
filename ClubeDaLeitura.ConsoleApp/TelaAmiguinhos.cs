using ReadClub.ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public static class TelaAmiguinhos
    {
        public static void BoxAction(List<Emprestimo> emprestimos, Amiguinhos amiguinhos)
        {
            Console.WriteLine("Digite o nome do amiguinho:");
            Console.WriteLine("Amiguinhos disponiveis:");
            foreach (var item in emprestimos)
            {
                Console.WriteLine(item.nome);
            }
            amiguinhos.nomeAmiguinho = Console.ReadLine();
        }
    }
}
