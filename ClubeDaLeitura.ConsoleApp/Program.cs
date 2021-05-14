using ClubeDaLeitura.ConsoleApp;
using ReadClub.ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadClub.ConsoleApp
{
    class Program
    {

        public static void Main(string[] args)
        {
            List<Emprestimo> emprestimos = new List<Emprestimo>();
            List<Amiguinhos> amiguinhos = new List<Amiguinhos>();
            List<Caixa> caixas = new List<Caixa>();

            Revista Revistas = new Revista();
            Emprestimo Emprestimo = new Emprestimo();
            
            Caixa Caixa = new Caixa();

            string TelaInicial;
            string menu;

            Console.WriteLine("Bem vindo ao clube da leitura");
            TelaInicial = Console.ReadLine();

            bool sair = true;
            do
            {
                menu = OpcaoMenu();

                if (menu == "1")
                {
                    if (caixas.Count == 0)
                        Console.WriteLine("é obrigatório cadastrar uma caixa antes da revista.");
                    else
                    {
                        var RevistaTemp = ControladorRevistas.Registrar(caixas);
                        foreach (var item in caixas)
                        {
                            if (item.numeroCaixa == RevistaTemp.numeroCaixa)
                            {
                                item.Revistas.Add(RevistaTemp);
                            }
                        }
                        continue;
                    }
                    
                    if (menu == "2")
                
                    if (amiguinhos.Count == 0)
                        Console.WriteLine("é obrigatório cadastrar um amiguinho antes do emprestimo.");
                    else
                    {
                        var EmprestimoTemp = ControladorEmprestimos.Registrar(amiguinhos);
                        foreach (var item in amiguinhos)
                        {
                            if (item.nome == EmprestimoTemp.nome)
                            {
                                item.Emprestimos.Add(EmprestimoTemp);
                            }
                        }
                    }

                    continue;
                }

                if (menu == "3")
                {
                    var AmiguinhosTemp = ControladorAmiguinhos.registrar();
                    amiguinhos.Add(AmiguinhosTemp);
                    continue;
                }
                if (menu == "4")
                {
                    var CaixaTemp = ControladorCaixas.registrar(caixas);
                    caixas.Add(CaixaTemp);
                    
                    continue;
                }

                if (menu == "5")
                {
                    TelaCaixas.Mostrar(caixas);
                    continue;
                }

                if (menu == "7")
                {
                    TelaEmprestimos.Mostrar(emprestimos);
                    continue;
                }

                if (menu.Equals("0"))
                {
                    sair = false;
                }

            } while (sair);

        }

        public static string OpcaoMenu()
        {
            string menu;

            Console.WriteLine("-------------------------");
            Console.WriteLine("Revistas: = 1");
            Console.WriteLine("Emprestimos:  = 2");
            Console.WriteLine("Amiguinhos = 3");
            Console.WriteLine("Caixas = 4");
            Console.WriteLine("Vizualizar as caixas = 5");
            Console.WriteLine("Vizualizar os emprestimos = 7");
            Console.WriteLine("Sair = 0");
            Console.WriteLine("-------------------------");

            menu = Console.ReadLine();
            return menu;
        }
    }
}
