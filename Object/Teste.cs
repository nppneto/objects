using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    class Teste
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();

            f1.Nome = "Abondanzieri";
            f1.Salario = 2000;

            Funcionario f2 = new Funcionario();

            f2.Nome = "Claudio Nunes";
            f2.Salario = 15000;

            Console.WriteLine(f1 == f2);
            Console.WriteLine(f1.Equals(f2));

            Console.ReadKey();
        }
    }
}
