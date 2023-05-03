using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Windows;
using System.Configuration;
using System.Data;
 using System.Windows.Forms;

namespace ventasjarrones
{
	public partial class Actualizar : System.Web.UI.Page
	{
		class Conexion
		{
			public static SqlConnection Conectar()
			{
				SqlConnection conn = new SqlConnection("Data Source=SISTEMAS86;Initial Catalog=conexionsqlserver;Integrated Security=True");
				conn.Open();
				return conn;
			}
		}
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void BtnActu_Click(object sender, EventArgs e)
		{
			
			if (tbcla.Text==tbcla2.Text)
			{
				Conexion.Conectar();
				SqlCommand cmd = new SqlCommand("actualizar_clave", Conexion.Conectar())
				{
					CommandType = CommandType.StoredProcedure
				};

				cmd.Parameters.AddWithValue("@Usuario", tbemail.Text);
				cmd.Parameters.AddWithValue("@Contraseña", tbcla.Text);
				SqlDataReader dr = cmd.ExecuteReader();
				string script = @"<script type='text/javascript'> alert('Se actualizo la contraseña');
                            window.location.href='index.aspx#Vinc'</script>";
				ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
				Response.Redirect("WebForm1.aspx");
			}
			else
			{
				string script = @"<script type='text/javascript'> alert('Las contraseñas no coisiden');
                            window.location.href='Actualizar.aspx#Vinc'</script>";
				ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
			}
		}
	}
}