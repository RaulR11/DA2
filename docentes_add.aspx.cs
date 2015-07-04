using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class docentes_add : System.Web.UI.Page
{
    string connectionString = "workstation id=colegio-fer.mssql.somee.com;packet size=4096;user id=ferjesus_SQLLogin_1;pwd=val7f5xp4s;data source=colegio-fer.mssql.somee.com;persist security info=False;initial catalog=colegio-fer";

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    
    protected void Button1_Click(object sender, EventArgs e)
    {
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
}