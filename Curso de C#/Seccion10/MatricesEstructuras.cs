using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion10
{
    internal class MatricesEstructuras
    {
        public void Init()
        {
            #region "Primera forma"
            Producto[] televisiones = new Producto[3];

            televisiones[0] = new Producto
            {
                Nombre = "Producto uno",
                Precio = 345,
                Descripcion = "Esta es una descripcion"
            };

            televisiones[1] = new Producto
            {
                Nombre = "Producto dos",
                Precio = 345,
                Descripcion = "Esta es una descripcion"
            };

            televisiones[2] = new Producto
            {
                Nombre = "Producto tres",
                Precio = 345,
                Descripcion = "Esta es una descripcion"
            };

            #endregion


            #region "Segunda forma"

            Producto[] licuadoras = new Producto[2]
            {
                new Producto
                {
                    Nombre = "Licuadoras uno",
                    Precio = 345,
                    Descripcion = "Esta es una descripcion"
                },
                new Producto
                {
                    Nombre = "Licuadoras dos",
                    Precio = 345,
                    Descripcion = "Esta es una descripcion"
                }
            };

            #endregion



            #region "Tercera forma"

            List<Producto> laptops = new List<Producto>()
            {
                new Producto
                {
                    Nombre = "laptops uno",
                    Precio = 345,
                    Descripcion = "Esta es una descripcion"
                },
                new Producto
                {
                    Nombre = "laptops dos",
                    Precio = 345,
                    Descripcion = "Esta es una descripcion"
                }
            };

            foreach (var item in laptops)
            {
                Console.WriteLine($"Ejemplo tres: {item}");
            }

            #endregion
        }
    }

    struct Producto
    {
        string nombre;
        double precio;
        string descripcion;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public override string ToString()
        {
            return $"\nnombre: {Nombre}\nprecio: {Precio}\ndescripcion: {Descripcion}";
        }
    }
}
