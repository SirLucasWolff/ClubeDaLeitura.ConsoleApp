using ReadClub.ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public static class TelaEmprestimos
    {
        public static void Mostrar(List<Emprestimo> emprestimos)
        {
           Console.WriteLine("----- Lista de Emprestimos -----");
           foreach (var item in emprestimos)
           {

              Console.WriteLine($"Nome do Amiguinho: {item.nome}");
              Console.WriteLine($"Tipo de coleção emprestada: {item.Colecao}");
              Console.WriteLine($"Data de emprestimo: {item.dataEmprestimo}");
              Console.WriteLine($"Data de devolução: {item.dataDevolucao}");

           }
              Console.WriteLine("---------------------------------");
        }
        
    }
}
