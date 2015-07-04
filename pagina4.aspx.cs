using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class pagina4 : System.Web.UI.Page
{
        string connectionString = "workstation id=colegio-fer.mssql.somee.com;packet size=4096;user id=ferjesus_SQLLogin_1;pwd=val7f5xp4s;data source=colegio-fer.mssql.somee.com;persist security info=False;initial catalog=colegio-fer";

    protected void Page_Load(object sender, EventArgs e)
    {


        if (this.IsPostBack == false)
        {
            DropDownList1.Items.Add("Primero");
            DropDownList1.Items.Add("Segundo");
            DropDownList1.Items.Add("Tercero");
            DropDownList1.Items.Add("Cuarto");
            DropDownList1.Items.Add("Quinto");
            DropDownList1.Items.Add("Sexto");

            DropDownList2.Items.Add("Primero");
            DropDownList2.Items.Add("Segundo");
            DropDownList2.Items.Add("Tercero");
            DropDownList2.Items.Add("Cuarto");
            DropDownList2.Items.Add("Quinto");

            DropDownList3.Items.Add("A");
            DropDownList3.Items.Add("B");

            DropDownList4.Items.Add("A");
            DropDownList4.Items.Add("B");
            DropDownList4.Items.Add("C");
        }
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = Int32.Parse(RadioButtonList1.SelectedValue);
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedValue == "0")
        {
            Label10.Text = "Apellidos: " + TextBoxApellido.Text + "\n\nNombres: " + TextBoxNonbre.Text + "\n\nDNI: " + TextBoxDNI.Text +
                "\n\nAño: " + DropDownList1.SelectedValue.ToString() + " de primaria  \n\nSección: " + DropDownList3.SelectedValue.ToString();

            if (!this.IsValid) return;
            string insertSQL = "INSERT INTO alumnos VALUES(" +
         Textcodigo.Text + ", '" + TextBoxNonbre.Text + "', '" +
             TextBoxApellido.Text + "', '" + TextBoxDNI.Text + "', '" +
             TextBoxDireccion.Text + "', '" + TextBoxFono.Text + "','" + DropDownList1.SelectedValue.ToString() + "', '" + DropDownList3.SelectedValue.ToString() + "', " + RadioButtonList1.SelectedValue.ToString() + ")";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(insertSQL, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                lblResult.Text = "DOCENTE REGISTRADO CON EXITO";
                con.Close();

            }
            catch (Exception err)
            {
                lblResult.Text = "ERROR AL REGISTRAR docente";
                lblResult.Text += err.Message;
            }
            // Alumno doc = new Alumno(TextBoxNonbre.Text.ToString(), TextBoxApellido.Text.ToString(), TextBoxDNI.Text.ToString(), TextBoxDireccion.Text.ToString(), TextBoxFecNac.Text.ToString(), TextBoxFono.Text.ToString(), DropDownList1.SelectedValue.ToString() /*año*/, DropDownList3.SelectedValue.ToString() /*seccion*/ , RadioButtonList1.SelectedValue.ToString()) /*primaria*/;
        }
        else
        {
            Label10.Text = "Apellidos: " + TextBoxApellido.Text + "\n\nNombres: " + TextBoxNonbre.Text + "\n\nDNI: " + TextBoxDNI.Text +
                "\n\nAño: " + DropDownList1.SelectedValue.ToString() + " de secundaria \n\nSección: " + DropDownList4.SelectedValue.ToString();

            if (RadioButtonList1.SelectedValue == "0")
            {
                Label10.Text = "Apellidos: " + TextBoxApellido.Text + "\n\nNombres: " + TextBoxNonbre.Text + "\n\nDNI: " + TextBoxDNI.Text +
                    "\n\nAño: " + DropDownList1.SelectedValue.ToString() + " de primaria  \n\nSección: " + DropDownList3.SelectedValue.ToString();

                if (!this.IsValid) return;
                string insertSQL = "INSERT INTO alumnos VALUES(" +
             Textcodigo.Text + "', '" + TextBoxNonbre.Text + "', '" +
                 TextBoxApellido.Text + "', '" + TextBoxDNI.Text + "', '" +
                 TextBoxDireccion.Text + "',' " + TextBoxFono.Text + "','" + DropDownList1.SelectedValue.ToString() + "', '" + DropDownList3.SelectedValue.ToString() + "', '" + RadioButtonList1.SelectedValue.ToString() + ")";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(insertSQL, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    lblResult.Text = "DOCENTE REGISTRADO CON EXITO";
                    con.Close();

                }
                catch (Exception err)
                {
                    lblResult.Text = "ERROR AL REGISTRAR docente";
                    lblResult.Text += err.Message;
                }
                //Alumno doc = new Alumno(TextBoxNonbre.Text.ToString(), TextBoxApellido.Text.ToString(), TextBoxDNI.Text.ToString(), TextBoxDireccion.Text.ToString(), TextBoxFecNac.Text.ToString(), TextBoxFono.Text.ToString(), DropDownList2.SelectedValue.ToString() /*año*/, DropDownList4.SelectedValue.ToString() /*seccion*/ , RadioButtonList1.SelectedValue.ToString()) /*secundaria*/;
            }
        }
    }

    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
    protected void ButtonCargar_Click(object sender, EventArgs e)
    {
       /* if (FileUploadFoto.HasFile)
        {
            FileUploadFoto.SaveAs( @"C:\Users\Toshiba\Desktop\PRIMERAFASE_DEAII_PROYECT_BNBNBNB\ddd\WebSite2\upload\" + FileUploadFoto.FileName);
            //FileUploadFoto.SaveAs(@"Mis Documentos\Visual Studio 2013\Websites\PaginasMaestras\upload\" + FileUploadFoto.FileName);
        }
        HyperLink1.Text = FileUploadFoto.FileName;
        HyperLink1.NavigateUrl = @"upload/" + FileUploadFoto.FileName;
        * */
    }
    protected void TextBoxDireccion_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBoxNonbre_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBoxApellido_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Textcodigo_TextChanged(object sender, EventArgs e)
    {

    }
protected void Button2_Click(object sender, EventArgs e)
{

     string selectSQL = "SELECT * FROM alumnos";
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
}