using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data.SqlClient;
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
        return "Nombre: " + Nombre + "   Codigo: " + Codigo + "\n" + "\n     DNI:    " + DNI + "\n       Especialidad: " + Especialidad + "\n      Email: " + Email + "\n      Telefono: " + Telefono;// +ptr;
    }
}
public partial class pagina1 : System.Web.UI.Page
{

    string connectionString = "workstation id=colegio-fer.mssql.somee.com;packet size=4096;user id=ferjesus_SQLLogin_1;pwd=val7f5xp4s;data source=colegio-fer.mssql.somee.com;persist security info=False;initial catalog=colegio-fer";

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

        /*Docente doc = new Docente(TextBox1.Text.ToString(), TextBox5.Text.ToString(),
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
         * */
        if (!this.IsValid) return;
        string insertSQL = "INSERT INTO docentes VALUES(" +
     txtCodigo.Text + ", '" + txtNombres.Text + "', '" +
         txtDireccion.Text + "', '" + txtTelefono.Text + "', '" +
         txtMail.Text + "', " + txtEdad.Text + ")";
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(insertSQL, con);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            lblResult.Text = "DOCENTE REGISTRADO CON EXITO";
            con.Close();
            txtCodigo.Text = "";
            txtNombres.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtMail.Text = "";
            txtEdad.Text = "";
        }
        catch (Exception err)
        {
            lblResult.Text = "ERROR AL REGISTRAR docente";
            lblResult.Text += err.Message;
        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        txtCodigo.Text = "";
        txtNombres.Text = "";
        txtDireccion.Text = "";
        txtTelefono.Text = "";
        txtMail.Text = "";
        txtEdad.Text = "";
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        lblResult.Text = "";
        string selectSQL = "SELECT * FROM docentes where codigo=" + txtCodigo.Text;
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(selectSQL, con);
        SqlDataReader dr;
        try
        {
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                txtNombres.Text = dr[1].ToString();
                txtDireccion.Text = dr["direccion"].ToString();
                txtTelefono.Text = dr[3].ToString();
                txtMail.Text = dr[4].ToString();
                txtEdad.Text = dr[5].ToString();
            }
            con.Close();
            dr.Close();
        }
        catch (Exception err)
        {
            lblResult.Text = "ERRRO AL REGIUSTRAR EL CLIENTE";
            lblResult.Text += err.Message;
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        string selectSQL = "SELECT * FROM docentes";
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(selectSQL, con);
        SqlDataReader dr;
        try
        {
            con.Open();
            dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            con.Close();
        }
        catch (Exception err)
        {
            lblResult.Text = "ERROR AL REGISTRAR CLIENTE";
            lblResult.Text += err.Message;
        }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        /* string selectSQL = "DELETF FROM docentes  where codigo=" + txtCodigo.Text; ;
         SqlConnection con = new SqlConnection(connectionString);
         SqlCommand cmd = new SqlCommand(selectSQL, con);
         SqlDataReader dr;
         try
         {
             con.Open();
             dr = cmd.ExecuteReader();
             GridView1.DataSource = dr;
             GridView1.DataBind();
             con.Close();
        
         }
         catch (Exception err)
         {
             lblResult.Text = "ERROR AL REGISTRAR CLIENTE";
             lblResult.Text += err.Message;
         }*/
    }
}