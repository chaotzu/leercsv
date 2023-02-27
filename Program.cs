using System;
					

public class Program
{
	public static void Main()
	{
		Console.WriteLine(GetPoblacion("Atil"));
        Console.WriteLine(GetPoblacion("Huépac"));
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