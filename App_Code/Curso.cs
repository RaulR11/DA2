using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Cuso
/// </summary>
public class Curso
{
    public string nombre_c, nivel_c;
    public Curso(string n,string ni)
    {
        nombre_c = n;
        nivel_c = ni;
    }
    public Curso() { }
    public string getNombres()
    {
        return nombre_c;
    }
    public override string ToString()
    {
        return nombre_c + "  " + nivel_c;
    }

}