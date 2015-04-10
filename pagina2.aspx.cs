using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class pagina2 : System.Web.UI.Page
{
    Alumno f = new Alumno("leon jose", "1 primaria", "A");
    Alumno f1 = new Alumno("mamani wilmer", "2 primaria", "B");
    Alumno f2 = new Alumno("gonzales toñito", "3 primaria", "A");
    Alumno f3 = new Alumno("vargaz juan", "4 primaria", "A");
    Alumno f4 = new Alumno("chavez juan", "5 primaria", "B");

    Curso C1 = new Curso("MATEMATICA", "primaria");
    Curso C2 = new Curso("COMUNICACION", "primaria");
    Curso C3 = new Curso("INGLES", "primaria");
    Curso C4 = new Curso("COMPUTO", "primaria");

    Hashtable alumnostable = new Hashtable();

    List<Alumno> alumnos = new List<Alumno>();
    LinkedList<Alumno> al = new LinkedList<Alumno>();

    LinkedList<Curso> curs = new LinkedList<Curso>();

    //  Alumno aa[]=new Alumno ();

    protected void Page_Load(object sender, EventArgs e)
    {
        al.AddFirst(f);
        al.AddFirst(f1);
        al.AddFirst(f2);
        al.AddFirst(f3);
        al.AddFirst(f4);

        
        curs.AddFirst(C1);
        curs.AddFirst(C2);
        curs.AddFirst(C3);
        curs.AddFirst(C4);

        alumnos.Add(f);
        alumnos.Add(f1);
        alumnos.Add(f2);
        alumnos.Add(f3);
        alumnos.Add(f4);
    }
    JJ jj = new JJ();
    protected void Button1_Click(object sender, EventArgs e)
    {
        Alumno alum = new Alumno(TextBox1.Text.ToString(), TextBox2.Text.ToString(), TextBox3.Text.ToString());
        Alumno alu = new Alumno();
        bool sw = true;
        bool s = true;
        //al.Equals(alum);
        sw = al.Contains(alum);
        
        if (TextBox1.Text.ToString() == f.getNombres() || TextBox1.Text.ToString() == f1.getNombres() || TextBox1.Text.ToString() == f2.getNombres() || TextBox1.Text.ToString() == f3.getNombres() || TextBox1.Text.ToString() == f4.getNombres())
        //if (TextBox1.Text.ToString() == alu.getApellidos())
        {
            Label_BA.Text = "ALUMNO ENCONTRADO";

        }
        else
            Label_BA.Text = "ALUMNO NO ENCONTRADO , INGRESE NUEVAMENTE";

        //NO TOMES ACUPTURA DE PANTALLA A TODO LO SIGUIENTE GG xD

       
        //asta aqui

    }
    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //MultiView1.ActiveViewIndex = Int32.Parse(RadioButtonList1);
    }
    protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        //MultiView1.ActiveViewIndex = Int32.Parse(RadioButtonList2.SelectedValue);
    }
    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox6_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (TextBox4.Text.ToString() == C1.getNombres() || TextBox4.Text.ToString() == C2.getNombres() || TextBox4.Text.ToString() == C3.getNombres() || TextBox4.Text.ToString() == C4.getNombres())
            Label_BA0.Text = "CURSO ENCONTRADO";
        else
            Label_BA0.Text = "CURSO NO ENCONTRADO , INGRESE NUEVAMENTE";
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        int n1 = 0, n2 = 0, n3 = 0;
        int pro = 0;
        n1 = Int32.Parse(TextBox7.Text.ToString());
        n2 = Int32.Parse(TextBox7.Text.ToString());
        n3 = Int32.Parse(TextBox7.Text.ToString());
        pro = (n1 + n2 + n3) / 3;
        Label_BA2.Text = pro.ToString();
    }
}