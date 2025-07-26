internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║     BIENVENIDO AL MENÚ PRINCIPAL DE LOS MEJORES TORNEOS    ║");
            Console.WriteLine("╠════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║ POR FAVOR SELECCIONE UNA OPCIÓN:                           ║");
            Console.WriteLine("║                                                            ║");
            Console.WriteLine("║  1. 🏆 Administrar Torneos                                 ║");
            Console.WriteLine("║  2. 🛡️ Administrar Equipos                                  ║");
            Console.WriteLine("║  3. 👥 Administrar Jugadores                               ║");
            Console.WriteLine("║  4. 🔄 Administrar Transferencias                          ║");
            Console.WriteLine("║  5. 📊 Estadísticas                                        ║");
            Console.WriteLine("║  6. ❌ Salir                                               ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
            Console.Write("👉 Opción: ");
            int opcion;
            string? seleccion = Console.ReadLine();
            if (int.TryParse(seleccion, out opcion))
            {
                Console.Clear();
                switch (opcion)
                { //Aqui empieza la ejecucion de la opciones del menú
                    case 1:
                        Console.WriteLine("administrando torneos");
                        Console.ReadKey();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opcion invalida...");
                Console.ReadKey();
                Console.Clear();
            }
        }
            
    }
}