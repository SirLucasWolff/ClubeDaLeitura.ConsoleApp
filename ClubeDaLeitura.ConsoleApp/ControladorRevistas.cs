using ReadClub.ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public static class ControladorRevistas
    {
        public static Revista Registrar(List<Caixa> caixas)
        {
            Revista revista = new Revista();

            Console.WriteLine("Digite o tipo da coleção:");
            revista.colecao = Console.ReadLine();

            Console.WriteLine("Digite o Número da edição");
            revista.numero = Console.ReadLine();

            Console.WriteLine("Digite o ano da revista");
            revista.Ano = Console.ReadLine();

            BoxAction(caixas, revista);

            Random rnd = new Random();
            revista.id = rnd.Next();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Revista registrada na caixa com sucesso!");
            Console.ResetColor();

            return revista;
        }

        private static void BoxAction(List<Caixa> caixas, Revista revista)
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
