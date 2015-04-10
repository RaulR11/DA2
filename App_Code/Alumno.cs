using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Alumno
/// </summary>
public class Alumno
{
    private string nombres, apellidos, direccion, fecnac, dni, grado, seccion, level;
    private string telefono, nota;
    private string nota1, nota2, nota3, promedio;

    public Alumno()
    { }
    public Alumno( string nombre1 ,string g,string sec)
    {
        nombres = nombre1;
        grado = g;
        seccion = sec;
    }
    public Alumno(string nombre1 = " ", string apellido1 = " ", string doc = " ", string direc = " ", string fec = " ", string telf = " ", string gra = " ", string sec = "", string lvl = "" )//string not = " ",)
    {
        dni = doc;
        nombres = nombre1;
        apellidos = apellido1;
        direccion = direc;
        fecnac = fec;
        telefono = telf;
        grado = gra;
        seccion = sec;
        level = lvl;
        //nota = not;
    }

    public void set_notas(string x, string y, string z)
    {
        nota1 = x;
        nota2 = y;
        nota3 = z;
    }
    public void set_promedio(string p) { promedio = p; }
    public override string ToString()
    {
        return nombres +"NOTAS-> "+nota1+""+nota2+" "+nota3+"  "+"PROMEDIO->"+promedio;
    }
    public string getDni()
    {
        return dni;
    }
    public string getNombres()
    {
        return nombres;
    }
    public string getApellidos()
    {
        return apellidos;
    }
    public string getDireccion() { return direccion; }
    public string getFecha() { return fecnac; }
    public string getTelefono() { return telefono; }
    public string getGrado() { return grado; }
    public void setNota(string n) { this.nota = n; }

    public bool search(string documento)
    {
        if (nombres == documento)
            return true;

        else
            return false;
    }
}