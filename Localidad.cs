

public class Localidades
{
	private String? nombre;
    private int habitantes;
    private String? clasificacion;
    private double porcIncDec;
	
    public String Nombre{
        get {return nombre != null ? nombre: "";}
        set { nombre = value;}
    }

    public int Habitantes{
        get {return habitantes;}
        set { habitantes = value;}
    }

    public String Clasificacion{
        get {return clasificacion != null ? clasificacion: "";}
        set { clasificacion = value;}
    }

    public double PorcIncDec{
        get {return porcIncDec;}
        set { porcIncDec = value;}
    }

    public Localidades(String nombre, int habitantes, String clasificacion, double porc){
        Nombre = nombre;
        Habitantes = habitantes;
        Clasificacion = clasificacion;
        PorcIncDec = porc;
    }

	public String ObtenerPoblacion2020(String nombrePoblacion)
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