internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("BIENVENIDO AL MENU PRINCIPAL DE LOS MEJORES TORNEOS");
            Console.WriteLine("POR FAVOR SELECCIONE UNA OPCION:\n1.Administrar Torneos\n2.Administrar equipos\n3.Administrar jugadores\n4.Administrar transferencias\n5.Estadisticas\nSalir");
            int opcion;
            string? seleccion = Console.ReadLine();
            if (int.TryParse(seleccion, out opcion))
            {
                continue;
            }
            else
            {
                Console.WriteLine("Opcion invalida...");
            }
        }
            
    }
}