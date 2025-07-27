using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using liga.Torneos;
using static liga.Torneos.Torneo;
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
                    torneo.Id = Convert.ToInt32(Console.ReadLine());//poner validacion
                    Console.Write("Ingrese el nombre del torneo: ");
                    torneo.Name = Console.ReadLine();
                    torneo.Creacion = DateTime.Now;//se agrega automaticamente pues esa es la gracia
                    Console.Write("Ingrese el dinero del premio mayor del torneo: ");
                    torneo.Prize = Convert.ToInt32(Console.ReadLine());//poner validacion
                    Console.WriteLine($"Torneo {torneo.Name}, con ID {torneo.Id}, creado Exitosamente!");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Registrotorneo.torneosregistrados.Add(torneo);
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Ingrese el ID del torneo que desea buscar: ");
                    string? idinput = Console.ReadLine();
                    if (int.TryParse(idinput, out int id) && id > 0)
                    {
                        Torneo? torneobuscado = Registrotorneo.torneosregistrados.FirstOrDefault(t => t.Id == id);
                        if (torneobuscado != null)
                        {
                            Console.WriteLine($"Torneo encontrado!\nID: {torneobuscado.Id}\nNombre: {torneobuscado.Name}\nFecha de creacion: {torneobuscado.Creacion}\nPremio: ${torneobuscado.Prize}");
                            Console.WriteLine("\nPresione cualquier tecla para continuar...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Torneo no encontrado...");
                            Console.WriteLine("\nPresione cualquier tecla para continuar...");
                            Console.ReadKey();
                        }
                    }
                    break;
                case 3:
                    Console.Clear();
                    Console.Write("Ingrese el ID del torneo a eliminar: ");
                    idinput = Console.ReadLine();
                    if (int.TryParse(idinput, out id) && id > 0)
                    {
                        Torneo? deletedtorneo = Registrotorneo.torneosregistrados.FirstOrDefault(t => t.Id == id);
                        if (deletedtorneo != null)
                        {
                            Console.WriteLine($"Eliminando torneo con ID {deletedtorneo.Id}");
                            Registrotorneo.torneosregistrados.Remove(deletedtorneo);
                            Console.WriteLine("\nTorneo eliminado con exito!");
                            Console.WriteLine("\nPresione cualquier tecla para continuar...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Torneo no encontrado...");
                            Console.WriteLine("\nPresione cualquie tecla para continuar...");
                            Console.ReadKey();
                        }
                    }

                    break;
                case 4:
                    Console.Clear();
                    Console.Write("Ingrese el ID del torneo a editar: ");
                    idinput = Console.ReadLine();
                    int opcion;
                    if (int.TryParse(idinput, out id) && id > 0)
                    {
                        Torneo? editartorneo = Registrotorneo.torneosregistrados.FirstOrDefault(t => t.Id == id);
                        if (editartorneo != null)
                        {
                            Console.WriteLine($"\nTorneo encontrado!\nID: {editartorneo.Id}\nNombre: {editartorneo.Name}\nFecha de creacion: {editartorneo.Creacion}\nPremio: ${editartorneo.Prize}\n(Si no desea editar un valor vuelvalo a escribir exactamente igual)");
                            Console.Write("\nIngrese que desea editar: \n1.ID\n2.Nombre\n3.Premio\n👉 Opción: ");
                            string? opcioninput = Console.ReadLine();
                            if (int.TryParse(opcioninput, out opcion))
                            {
                                switch (opcion)
                                {
                                    case 1:
                                        Console.Write("\nIngrese el nuevo ID: ");
                                        editartorneo.Id = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("ID actualizado exitosamente!");
                                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                                        Console.ReadKey();
                                        break;
                                    case 2:
                                        Console.Write("\nIngrese el nuevo nombre: ");
                                        editartorneo.Name = Console.ReadLine();
                                        Console.WriteLine("Nombre actualizado exitosamente!");
                                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                                        Console.ReadKey();
                                        break;
                                    case 3:
                                        Console.Write("\nIngrese el nuevo valor del premio: ");
                                        editartorneo.Prize = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Premio actualizado exitosamente!");
                                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                                        Console.ReadKey();
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Opcion no valida...");
                                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Torneo no encontrado...");
                            Console.WriteLine("\nPresione cualquie tecla para continuar...");
                            Console.ReadKey();
                        }
                    }
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("Regresando...");
                    return;
            }
        }
    }
}