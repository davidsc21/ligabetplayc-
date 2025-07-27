using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using liga.Torneos;
public static class Menutorneo
{
    public static void mostrar()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════════════╗");
            Console.WriteLine("║                🏆 MENÚ DE TORNEOS                  ║");
            Console.WriteLine("╠════════════════════════════════════════════════════╣");
            Console.WriteLine("║ 1. ➕ Añadir Torneo                                ║");
            Console.WriteLine("║ 2. 🔍 Buscar Torneo                                ║");
            Console.WriteLine("║ 3. ❌ Eliminar Torneo                              ║");
            Console.WriteLine("║ 4. ✏️  Actualizar Torneo                            ║");
            Console.WriteLine("║ 5. 🔙 Regresar al Menú Principal                   ║");
            Console.WriteLine("╚════════════════════════════════════════════════════╝");
            Console.Write("👉 Opción: ");
            int? selecciontorneo = Convert.ToInt32(Console.ReadLine());
            switch (selecciontorneo)
            {
                case 1:
                    Console.Clear();
                    Torneo torneo = new Torneo();
                    Console.Write("Ingrese el ID deseado para el torneo: ");
                    torneo.Id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese el nombre del torneo: ");
                    torneo.Name = Console.ReadLine();
                    torneo.Creacion = DateTime.Now;//se agrega automaticamente pues esa es la gracia
                    Console.Write("Ingrese el dinero del premio mayor del torneo: ");
                    torneo.Prize = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Torneo {torneo.Name}, con ID {torneo.Id}, creado Exitosamente!");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("hola2");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("hola3");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("hola4");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("Regresando...");
                    return;
            }
        }
    }
}