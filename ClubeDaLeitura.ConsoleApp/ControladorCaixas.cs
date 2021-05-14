using ReadClub.ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public class ControladorCaixas
    {
        public static Caixa registrar(List<Caixa> caixas)
        {
            Caixa caixa = new Caixa();

            DefinirCor(caixa);

            Console.WriteLine("Digite a etiqueta da caixa:");
            caixa.etiqueta = Console.ReadLine();

            Console.WriteLine("Digite o número da caixa:");
            caixa.numeroCaixa = Console.ReadLine();

            Random rnd = new Random();
            caixa.id = rnd.Next().ToString();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Caixa registrada com suscesso!");
            Console.ResetColor();

            return caixa;
        }

        public static void DefinirCor(Caixa caixa)
        {
            Console.WriteLine("Digite a cor da caixa: \n1 - azul\n2 - vermelha\n3 - preta\n4 - branca\n5 - rosa");
            var op = Console.ReadLine();


            switch (op)
            {
                case "1":
                    caixa.cor = CorCaixa.azul;
                    break;
                case "2":
                    caixa.cor = CorCaixa.vermelha;
                    break;
                case "3":
                    caixa.cor = CorCaixa.preta;
                    break;
                case "4":
                    caixa.cor = CorCaixa.branca;
                    break;
                case "5":
                    caixa.cor = CorCaixa.branca;
                    break;
                default:
                    Console.WriteLine("Cor inexistente. Tente novamente.");
                    DefinirCor(caixa);
                    break;
            }
        }
    }
}
