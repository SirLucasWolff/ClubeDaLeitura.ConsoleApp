using ReadClub.ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public static class TelaRevistascs
    {
        public static void BoxAction(List<Caixa> caixas, Revista revista)
        {
            Console.WriteLine("Digite o número da caixa:");
            Console.WriteLine("Caixas disponiveis:");
            foreach (var item in caixas)
            {
                Console.WriteLine(item.numeroCaixa);
            }
            revista.numeroCaixa = Console.ReadLine();
        }
    }
}
