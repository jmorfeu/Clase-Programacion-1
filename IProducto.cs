public interface IProducto
{
    void Guardar( Producto producto);
    void Eliminar();
    void Actualizar();
    Producto Consultar();

}

public class Cereales:IProducto
{
    public void Guardar(Producto producto)
    {
        Console.WriteLine($"Guardando producto: {producto.Nombre}, {producto.Precio}");
    }

    public void Eliminar()
    {
        Console.WriteLine("Eliminando producto...");
    }

    public void Actualizar()
    {
        Console.WriteLine("Actualizando producto...");
    }

    public Producto Consultar()
    {
        Console.WriteLine("Consultando producto...");
        return new Producto();
    }