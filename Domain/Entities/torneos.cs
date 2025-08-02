using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace liga.Torneos;

public class Torneo
{
    public int? Id { get; set; }
    public string? Name { get; set; }

    public string? Tipo { get; set; }

    public string? Pais { get; set; }
    public DateTime Creacion = DateTime.Now;
    public int? Prize { get; set; }

    public Torneo(int? id, string? name, string? tipo, string? pais, DateTime creacion, int? prize)
    {
        Id = id;
        Name = name;
        Tipo = tipo;
        Pais = pais;
        Creacion = creacion;
        Prize = prize;
    }
    

    public Torneo() { }

    public static class Registrotorneo
    {
        public static List<Torneo> torneosregistrados = new List<Torneo>();
    }
}