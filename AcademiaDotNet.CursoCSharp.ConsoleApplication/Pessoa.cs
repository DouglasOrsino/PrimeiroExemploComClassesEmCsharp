﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDotNet.CursoCSharp.ConsoleApplication
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string NumeroContaCorrente { get; set; }

        public double EfetuarDeposito(double valorDeposito)
        {
            double saldo = 100.0;
            return saldo = saldo + valorDeposito;
        }
    }
}
