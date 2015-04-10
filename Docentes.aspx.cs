using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
public class Docente
{
    private string Nombre;
    private string Codigo;
    private string DNI;
    private string Especialidad;
    private string Email;
    private string Telefono;

    public Docente()
    {
    }

    public Docente(string nom, string cod, string dn, string esp, string email, string tel)
    {
        Nombre = nom;
        Codigo = cod;
        DNI = dn;
        Especialidad = esp;
        Email = email;
        Telefono = tel;
    }

    public override string ToString()
    {
        return "Nombre: " + Nombre + "   Codigo: " + Codigo + "\n" + "\n     DNI:    " + DNI + "\n       Especialidad: " + Especialidad + "\n      Email: "  + Email + "\n      Telefono: " + Telefono;// +ptr;
    }
}
public partial class pagina1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    private Hashtable table = new Hashtable();
    public Hashtable tt = new Hashtable();

    protected void Button1_Click(object sender, EventArgs e)
    {

        Docente doc = new Docente(TextBox1.Text.ToString(), TextBox5.Text.ToString(),
            TextBox2.Text.ToString(), DropDownList1.Text.ToString(), TextBox3.Text.ToString(), TextBox4.Text.ToString());
        try
        {
            table.Add(TextBox5.Text, doc);
            TextBox6.Text = doc.ToString();
            tt.Add(TextBox5.Text.ToString(), doc.ToString());
        }
        catch (ArgumentException argumentException)
        {
            TextBox5.Text = argumentException.ToString();
        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox5.Text = "";
        TextBox2.Text = "";

        TextBox3.Text = "";
        TextBox4.Text = "";
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
       if(tt.ContainsKey(TextBox5.Text.ToString()))
       {TextBox6.Text = "DOCENTE ENCONTRADO";
           tt.ToString();
       }
        else
           TextBox6.Text = "DOCENTE no ENCONTRADO , ingrese otra ves";
        // TextBox6.Text = "La clave se encuentra?: " +
          //      table.ContainsKey(TextBox5.Text);
    }
}