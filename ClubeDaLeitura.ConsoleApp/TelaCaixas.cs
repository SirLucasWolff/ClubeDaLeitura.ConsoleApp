using ReadClub.ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public static class TelaCaixas
    {
        public static void Mostrar(List<Caixa> caixa)
        {
            Console.WriteLine("----- Lista de caixas -----");
            foreach (var item in caixa)
            {
                Console.WriteLine($"Id: {item.id}");
                Console.WriteLine($"Cor da caixa: {item.cor}");
                Console.WriteLine($"Etiqueta da caixa: {item.etiqueta}");
                Console.WriteLine($"Número da caixa: {item.numeroCaixa}");
                Console.WriteLine($"---Revistas---");

                foreach (var revista in item.Revistas)
                {
                    Console.WriteLine($"Numero: {revista.numero}");
                    Console.WriteLine($"Numero da Caixa: {revista.numeroCaixa}");
                    Console.WriteLine($"Coleção: {revista.colecao}");
                    Console.WriteLine($"Ano: {revista.Ano}");
                }
            }
            Console.WriteLine("---------------------------------");
        }
    }
}
