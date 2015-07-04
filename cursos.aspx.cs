using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data.SqlClient;

public partial class cursos : System.Web.UI.Page
{
    string connectionString = "workstation id=colegio-fer.mssql.somee.com;packet size=4096;user id=ferjesus_SQLLogin_1;pwd=val7f5xp4s;data source=colegio-fer.mssql.somee.com;persist security info=False;initial catalog=colegio-fer";

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
  
        bool sw = false;

        lblResult.Text = "";
        string selectSQL = "SELECT * FROM alumnos where codigo=" + TextBox1.Text;
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(selectSQL, con);
        SqlDataReader dr;
        try
        {
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (TextBox1.Text == dr[0].ToString())
                    sw = true;
                else
                    sw = false;
             
            }
            con.Close();
            dr.Close();
        }
        catch (Exception err)
        {
            lblResult.Text = "No existe alumnos con ese codigo";
            lblResult.Text += err.Message;
            sw = false;
        }

        if (sw == true)
        {

            float pp = 0;
            institucionDataContext dc = new institucionDataContext();
            float promedio = Int32.Parse(TextBox3.Text) + Int32.Parse(TextBox4.Text) + Int32.Parse(TextBox5.Text);
            promedio = promedio / 3;
            int p = 0;
            p = Int32.Parse(TextBox3.Text) + Int32.Parse(TextBox4.Text) + Int32.Parse(TextBox5.Text);
            p = p / 3;
            pp = promedio - p;
            if (pp >= 0.5)
                p++;
            Label16.Text = p.ToString();
            float co = promedio + Int32.Parse(TextBox3.Text); 
            try
           {
                Curss c = new Curss
            {
                
                CodigoCurso = co.ToString(),
                NombreCurso = DropDownList1.Text.ToString(),
                cod_alumno = TextBox1.Text.ToString(),
                Nota1 = TextBox3.Text.ToString(),
                Nota2 = TextBox4.Text.ToString(),
                Nota3 = TextBox5.Text.ToString(),
                promedio = p.ToString()
             

                //CodigoCurso = "sdfsdf",
                //NombreCurso = "sdfsdf",
                //cod_alumno = "sdfsdf",
                //Nota1 = "sdfsdf",
                //Nota2 = "sdfsdf",
                //Nota3 = "sdfsdf",
                //promedio = "sdfsdf",
            };
               
                dc.Curss.InsertOnSubmit(c);
                dc.SubmitChanges();
            
            }
           catch (Exception err)
            {
                lblResult.Text = "ERROR   ";
                lblResult.Text += err.Message;

            }
        }
        else
            lblResult.Text = "No existe alumnos con ese CODIGO";
    }
}