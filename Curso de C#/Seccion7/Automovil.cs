using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion7
{
    class Automovil
    {
        private string marca; //Atributo de la clase
        private string modelo; //Atributo de la clase
        private int anio; //Atributo de la clase


        //Constructor de la clase
        //Es un metodo especial que se llama igual que la clase
        //No tiene tipo de retorno
        //Se ejecuta automaticamente cuando se crea una instancia de la clase
        //Si no se define un constructor, la clase tiene un constructor por defecto
        //Constructor de la clase puede ser publico o privado
        public Automovil() //Puede ser vacio o inicializar los atributos
        {
            //Inicializar los atributos de la clase
            marca = "Toyota";
            modelo = "Corolla";
            anio = 2020;

        }

        //Sobrecarga de constructores
        //Es cuando se define mas de un constructor en una clase
        //Con diferentes parametros
        public Automovil(string marca, string modelo, int anio) //Constructor de la clase
        {
            this.marca = marca;
            this.modelo = modelo;
            this.anio = anio;
        }


        //Propiedades de la clase
        //Son metodos que permiten acceder a los atributos de la clase
        //Se definen con la palabra reservada
        //get para obtener el valor de un atributo
        //set para asignar un valor a un atributo
        //Se pueden definir propiedades automaticas
        public string Marca //Propiedad de la clase
        {
            get { return marca; } //Metodo get
            set { marca = value; } //Metodo set
        }

        public string Modelo //Propiedad de la clase
        {
            get { return modelo; } //Metodo get
            set { modelo = value; } //Metodo set
        }

        public int Anio //Propiedad de la clase otra forma de hacerlo
        {
            get => anio; //Metodo get
            set => anio = value; //Metodo set
        }

        public void Encender() //Metodo de la clase
        {
            Console.WriteLine("El auto {0} {1} esta encendido", marca, modelo);
        }


        //Invalidando el metodo ToString
        // Que es un metodo que se hereda de la clase object
        // Y se puede sobreescribir
        public override string ToString()
        {
            //Dependera de la logica de negocio como necesitemos mostrar la informacion
            return string.Format("Marca: {0}, Modelo: {1}, Anio: {2}", marca, modelo, anio);
        }

        //Sobre carga de metodos
        //Es cuando se define mas de un metodo con el mismo nombre
        //Pero con diferentes parametros
        //No se puede definir dos metodos con el mismo nombre y los mismos parametros
        //Solo se puede definir dos metodos con el mismo nombre y los mismos parametros si tienen diferentes tipos de retorno
        //El primero no puede tener parametros y el segundo si
        public void MetodoSobrecargado()
        {
            Console.WriteLine("Metodo sin parametros");
        }

        public void MetodoSobrecargado(int numero)
        {
            Console.WriteLine("Metodo con un parametro: {0}", numero);
        }
    }
}
