using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Pages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ( IsPostBack)
            {
                
            
            string nick = Request.Form["Nickname"];
            string clave = Request.Form["Contrasenna"];
                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
                {
                    conn.Open(); //abrimos conexión
                    String query = "select * from Usuarios where NICKNAME = @nick and CONTRASENNA = @clave";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nick", nick);
                    cmd.Parameters.AddWithValue("@clave", clave);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Console.WriteLine("Ingreso Exitoso!!!");
                    }
                    else
                    {
                        Console.WriteLine("Intento fallido!");
                    }

                }
            }
        }
    }
}