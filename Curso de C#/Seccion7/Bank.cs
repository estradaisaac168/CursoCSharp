using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion7
{
    class Bank
    {
        string name, lastname, direction, rfc;
        double saldo = 0;

        public Bank(string name, string lastname, string direction, string rfc, double saldo)
        {
            this.name = name;
            this.lastname = lastname;
            this.direction = direction;
            this.rfc = rfc;
            this.saldo = saldo;
        }

        public double Depositar(double cantidad)
        {
            return this.saldo += cantidad;
        }

        public double Retirar(double cantidad)
        {
            if (cantidad > this.saldo)
            {
                Console.WriteLine("No tienes suficiente saldo");
                return this.saldo;
            }

            Console.WriteLine("Retirando " + cantidad);
            Console.WriteLine("Saldo actual: " + this.saldo);
            return this.saldo -= cantidad;

        }

        public double ConsultarSaldo()
        {
            return this.saldo;
        }

        public override string ToString()
        {
            return name + " " + lastname + " " + direction + " " + rfc + " " + saldo;
        }
    }
}
