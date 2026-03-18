
using System.Globalization;

namespace POO_Pilares
{
public interface IVehiculo
{
    void Acelerar();
    void Frenar();
    void Girar(string direccion);
}   


public class Carro : IVehiculo
{
    public void Acelerar()
    {
        Console.WriteLine("El carro está acelerando");
        // Implementación de la aceleración del carro
    }

    public void Frenar()
    {
        // Implementación del frenado del carro
    }

    public void Girar(string direccion)
    {
        // Implementación del giro del carro
    }

    public void Frenar(string direccion, string direcion)
    {
        Console.WriteLine("El carro está tocando la bocina");
    }
}

public class Moto : IVehiculo
{
    public void Acelerar()
    {
       Console.WriteLine("La moto está acelerando");
    }

    public void Frenar()
    {
        Console.WriteLine("La moto está frenando");
    }

    public void Girar(string direccion)
    {
        // Implementación del giro de la moto
    }
}



public interface PersonaRepository
{
    
   
    void Guardar( Persona usuario);
    void Eliminar();
    void Actualizar();
    Persona Consultar();
}

public class Persona{
    public string Nombre { get; set; }
    public string Email { get; set; }
    public string Contrasena { get; set; }
}
public class Usuario: PersonaRepository
{
  
    public void Guardar()
    {

        Console.WriteLine("Guardando usuario...");
    }

    public void Eliminar()
    {
        Console.WriteLine("Eliminando usuario...");
    }

    public void Actualizar()
    {
        Console.WriteLine("Actualizando usuario...");
    }

    public Usuario Consultar()
    {
        Console.WriteLine("Consultando usuario...");
        return new Usuario();
    }

        public void Guardar(Persona usuario)
        {
            Console.WriteLine($"Guardando usuario: {usuario.Nombre}, {usuario.Email}");
          
        }

        Persona PersonaRepository.Consultar()
        {
            throw new NotImplementedException();
        }
    }
        public class Cliente : PersonaRepository
    {
        public void Guardar()
        {
            Console.WriteLine("Guardando cliente...");
        }

        public void Eliminar()
        {
            Console.WriteLine("Eliminando cliente...");
        }

        public void Actualizar()
        {
            Console.WriteLine("Actualizando cliente...");
        }

        public Persona Consultar()
        {
            Console.WriteLine("Consultando cliente...");
            return new Persona();
        }

            public void Guardar(Persona usuario)
            {
                Console.WriteLine($"Guardando cliente: {usuario.Nombre}, {usuario.Email}");
            }
        }   

}
