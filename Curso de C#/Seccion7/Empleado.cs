using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion7
{
    class Empleado
    {
        string id, name, lastName, locker, bank, nip;

        Random random = new Random();

        //Constructor con parametros
        public Empleado(string name, string lastname)
        {
            this.name = name;
            this.lastName = lastname;

            id = GenerateID(); //Generar ID
            locker = GenerateLocker(); //Generar Locker
            bank = GenerateBank(); //Generar Banco
        }

        //Propiedades
        //Propiedad para settear el campo nip
        public string Nip { set => nip = value; }


        //Generate IDs
        private string GenerateID()
        {
            int i, number;
            string id = "";

            for (i = 0; i < 10; i++)
            {
                number = random.Next(10);

                id += number.ToString();
            }

            return id;

        }


        //Generate Lockers
        private string GenerateLocker()
        {
            int i, number;
            string locker = "";

            for (i = 0; i < 10; i++)
            {
                number = random.Next(10);

                locker += number.ToString();
            }

            return locker;

        }

        private string GenerateBank()
        {
            int asignarBanco;
            string bank = " ";

            asignarBanco = random.Next(1, 3);

            switch(asignarBanco)
            {
                case 1:
                    bank = "Bancomer";
                    break;
                case 2:
                    bank = "Banamex";
                    break;
            }

            return bank;
        }

        //Mestodo para mostrar los datos del empleado
        public override string ToString()
        {
            return "ID: " + id + "\nNombre: " + name + " " + lastName + "\nLocker: " + locker + "\nBanco: " + bank + "\nNIP: " + nip;
        }   
    }
}
