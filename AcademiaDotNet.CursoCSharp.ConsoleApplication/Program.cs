using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDotNet.CursoCSharp.ConsoleApplication
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "Fulano de Tal";
            pessoa1.CPF = "02585118809";
            pessoa1.NumeroContaCorrente = "010203";


            Console.Write("Digite um valor para depositar: ");
            var valorDoDeposito = Convert.ToDouble(Console.ReadLine());

            Console.Write("O saldo da conta é de: " + pessoa1.EfetuarDeposito(valorDoDeposito));

            Console.ReadKey();
        }
    }
}
