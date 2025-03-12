using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.POO
{
    class IntroduccionPOO
    {
        /**
         * 
         * CONCEPTOS DE POO
         * 
         * 
         * Clases -> Plantilla para crear objetos, continen atributos y metodos.
         * 
         * Objeto -> Instancia de una clase que almacena datos y atributos.
         * 
         * Encapsulamiento -> Restriccion de acceso a los datos y metodos de una clase para protegerlos.
         * 
         * Herencia -> Permite que una clase derive de otra, reutilizando sus propiedades y metodos.
         * 
         * Polimorfismo -> Habilidad de un metodo de tomar multiples formas segun la clase que lo implemente
         * 
         * Abstraccion -> Oculta detalles complejos y muestra solo lo escencial de un objeto.
         * 
         * Interfaces -> Definen un contrato sin implementacion, permitiendo multiples herencias
         * 
         * Propiedades -> Metodos especiales (get y set) que controlan el acceso a los atributos
         * 
         * Metodos -> Funciones de una clase que definen el comportamiento de los objetos.
         * 
         * Constructores -> Metodos especiales que inicializan los objetos de una clase.
         * 
         * Destructores -> Metodos que liberan recursos antes de que un objeto sea eliminado.
         * 
         * Modificadores de acceso -> Controlan la visibilidad de los atributos y metodo (public, private, protected, etc).
         * 
         * Sobre carga de metodos -> Definir multiples versiones de un metodo con diferentes parametros.
         * 
         * Sobre carga de operadores -> Permite definir operadores como +, - para objetos persomalizados.
         * 
         * Clases estaticas -> No pueden ser instanciadas y solo contienen miembros estaticos.
         * 
         * Clases parciales -> Permiten dividir la implementacion de una clase en varios archivos.
         * 
         * Clases selladas (sealed) Evitan que otras clases hereden de ellas.
         * 
         * Clases abstractas -> No pueden ser instanciadas y deben ser heredadas para su uso.
         * 
         * Delegados -> Referencias a metodos que pueden ser asignadas y ejecutadas dinamicamente.
         * 
         * Eventos -> Mecanismo para suscribirse a cambios o acciones especificas en un objeto.
         * 
         * Genericos -> Permiten definir clases o metodos con tipos de datos variables.
         * 
         * Indexadores -> Permiten acceder a objetos como si fueran arreglos.
         * 
         * Metodos viertuales-> Metodos en clase base que pueden ser sobrescritos en clases derivadas.
         * 
         * 
         */

        public void Init() { 
            
            Hospital hospital = new Hospital();
            hospital.Notificar += mensaje 
                => Console.WriteLine($"[Notificación] {mensaje}");


            Paciente paciente1 = new Paciente("Juan Pérez", 30, "H1234");
            Doctor doctor1 = new Doctor("Dra. Martínez", 45, "Cardiología");

            hospital.AgregarPersona(paciente1);
            hospital.AgregarPersona(doctor1);

            hospital.AgendarCita(paciente1, doctor1, DateTime.Now.AddDays(2));
            paciente1.AgregarDiagnostico("Hipertensión leve");
            

            hospital.MostrarPersonas();
            paciente1.MostrarDiagnosticos();
            hospital.MostrarCitas();

        }
    }
}
