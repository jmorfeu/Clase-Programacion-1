/*
 * ═══════════════════════════════════════════════════════════════════════════
 *                    PROGRAMACIÓN ORIENTADA A OBJETOS (POO)
 *                         LOS 4 PILARES FUNDAMENTALES
 * ═══════════════════════════════════════════════════════════════════════════
 * 
 * Este proyecto contiene ejemplos prácticos de los 4 pilares de la POO en C#:
 * 
 * 1. ENCAPSULAMIENTO
 *    - Ocultar detalles internos
 *    - Proteger datos con modificadores de acceso
 *    - Exponer funcionalidad mediante propiedades y métodos públicos
 * 
 * 2. HERENCIA
 *    - Reutilización de código
 *    - Relación "ES UN" entre clases
 *    - Clases base y clases derivadas
 * 
 * 3. POLIMORFISMO
 *    - "Muchas formas" - mismo método, diferente comportamiento
 *    - Sobrescritura (Override) - en tiempo de ejecución
 *    - Sobrecarga (Overload) - en tiempo de compilación
 * 
 * 4. ABSTRACCIÓN
 *    - Mostrar solo lo esencial
 *    - Clases abstractas
 *    - Interfaces
 * 
 * ═══════════════════════════════════════════════════════════════════════════
 */

namespace POO_Pilares
{
    class Program
    {
                static void Main(string[] args)
        {
            IVehiculo miVehiculo = null;

            Console.WriteLine("Hello World!");

            Console.WriteLine("Selecciona un tipo de vehículo: 1. Carro 2. Moto");
            string opcion = Console.ReadLine();
            
           
            if (opcion == "1")
            {
                miVehiculo = new Carro();
                miVehiculo.Acelerar();
            }
            else if (opcion == "2")
            {
                miVehiculo = new Moto();
                miVehiculo.Acelerar();
            }
            else
            {
                Console.WriteLine("Opción no válida");
                return;
            }


            PersonaRepository usuarioRepo;
            usuarioRepo=new Usuario();

            Persona nuevoUsuario = new Persona
            {
                Nombre = "Juan Pérez",
                Email = "aBb8e@example.com",
                Contrasena = "123456789"
            };


            usuarioRepo.Guardar(nuevoUsuario);



        }
    }
}

