using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace liga.Torneos;

public class Torneo
{
    public int? Id { get; set; }
    public string? Name { get; set; }
    public DateTime Creacion = DateTime.Now;
    public int? Prize { get; set; }

    public Torneo(int? id, string? name, DateTime creacion, int? prize)
    {
        Id = id;
        Name = name;
        Creacion = creacion;
        Prize = prize;
    }
    

    public Torneo() { }

    public static class Registrotorneo
    {
        public static List<Torneo> torneosregistrados = new List<Torneo>();
    }
}