using ReadClub.ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public class ControladorAmiguinhos
    {
        public static Amiguinhos registrar()
        {
            Amiguinhos amiguinhos = new Amiguinhos();

            Console.WriteLine("Digite o nome do amiguinho:");
            amiguinhos.nomeAmiguinho = Console.ReadLine();

            Console.WriteLine("Digite o nome do responsável:");
            amiguinhos.nomeResponsavel = Console.ReadLine();

            Console.WriteLine("Digite o telefone do amiguinho:");
            amiguinhos.telefone = Console.ReadLine();

            Console.WriteLine("Digite a cidade do amiguinho:");
            amiguinhos.cidade = Console.ReadLine();

            Random rnd = new Random();
            amiguinhos.id = rnd.Next().ToString();

            return amiguinhos;
        }
    }
}
