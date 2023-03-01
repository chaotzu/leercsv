using System;
					

public class Program
{
	public static void Main()
	{
        List<Localidades> localidades = new List<Localidades>();
        localidades.Add(new Localidades("Atil", 200, "", 0.0));
        localidades.Add(new Localidades("Huépac", 100, "", 0.0));
        localidades.Add(new Localidades("Nuevo", 24200, "", 0.0));
		Console.WriteLine(GetPoblacion("Atil"));
        Console.WriteLine(GetPoblacion("Huépac"));
        foreach(Localidades loc in localidades){
            Console.WriteLine(loc.Habitantes);
            Console.WriteLine(loc.ObtenerPoblacion2020(loc.Nombre));
        }
	}
	
	static String GetPoblacion(String nombrePoblacion)
    {       
        var strLines=File.ReadLines("localidades.csv");
        foreach(var line in strLines)
        {
            if(line.Split(',')[1].Equals(nombrePoblacion))
                return line.Split(',')[2];
        }
        return "0";
    }
}