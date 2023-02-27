

using Empleados.Infrastructure.Data.context;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Empezando!!!");
        EmpleadoContext db = new EmpleadoContext();
        db.Database.EnsureCreated();
        Console.WriteLine("Listo!!!");
        Console.ReadKey();
    }
}