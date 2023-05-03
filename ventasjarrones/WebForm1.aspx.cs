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



namespace ventasjarrones
{

	public partial class WebForm1 : System.Web.UI.Page
	{
		public System.Windows.Visibility Visibility { get; set; }
		class Conexion
		{
			public static SqlConnection Conectar()
			{
				SqlConnection conn = new SqlConnection("Data Source=SISTEMAS86;Initial Catalog=conexionsqlserver;Integrated Security=True");
				conn.Open();
				return conn;
			}
		}



		public void cargarData(string sql)
		{
			Conexion.Conectar();

			string cadena = sql;
			SqlCommand cmd = new SqlCommand(cadena, Conexion.Conectar());
			cmd.Parameters.AddWithValue("@Usuario", tbusuario.Text);
			cmd.Parameters.AddWithValue("@Contraseña", tbclave.Text);
			SqlDataReader dr = cmd.ExecuteReader();
			if (dr.Read())
			{
				tbusuario = dr["Usuario"].ToString();
			}
			tbusuario = dr["Contraseña"].ToString();
		}





		//protected void ingresar_Click(object sender, EventArgs e)
		//{
		//	string sql = "insert into persona (nombres,cedula,direccion) values (@nombre,@cedula,@direccion)";

		//	cargarData(sql);
		//}

		//protected void Buscar_Click(object sender, EventArgs e)
		//{
		//	Act.Visible = true;
		//	buscar.Visible = false;
		//	ingresar.Visible = false;
		//	eli.Visible = true;
		//	Lim.Visible = true;
		//	string queryString = "select * from persona  where cedula=@cedula";
		//	SqlCommand command = new SqlCommand(queryString, Conexion.Conectar()); 
		//	command.Parameters.AddWithValue("@cedula", cc.Text);
		//	command.Parameters.AddWithValue("@nombre", nom.Text);
		//	command.Parameters.AddWithValue("@direccion", dire.Text);
		//	SqlDataReader reader = command.ExecuteReader();

		//	if (reader.Read())
		//	{
		//		string cedula = (string)reader["cedula"]; 
		//		string nombre = (string)reader["nombres"]; 
		//		string direccion = (string)reader["direccion"]; 
		//		nom.Text = nombre; 
		//		cc.Text = cedula; 
		//		dire.Text = direccion;
		//	}
		//	else
		//	{
		//		System.Windows.Forms.MessageBox.Show("no esta registrado");
		//	}

		//	reader.Close(); 
		//	Conexion.Conectar();
		//}

		//protected void Actualizar_Click(object sender, EventArgs e)
		//{
		//	String sql = "update persona  set nombres=@nombre,direccion=@direccion where cedula=@cedula";
		//	cargarData(sql);

		//}

		//protected void Eliminar_Click(object sender, EventArgs e)
		//{

		//	String sql = "delete from persona where cedula=@cedula";
		//	cargarData(sql);
		//}


		//protected void Limpiar_Click(object sender, EventArgs e)
		//{
		//	buscar.Visible = true;
		//	ingresar.Visible = true;
		//	eli.Visible = false;
		//	Lim.Visible = false;
		//	Act.Visible = false;
		//	nom.Text = "";
		//	cc.Text = "";
		//	dire.Text = "";
		//}

		protected void Btningar_Click(object sender, EventArgs e)
		{
			Usuario usu = new Usuario();
			usu.
			Conexion.Conectar();
			SqlCommand cmd = new SqlCommand("sp_validaruser", Conexion.Conectar())
			{
				CommandType = CommandType.StoredProcedure
			};

			cmd.Parameters.AddWithValue("@Usuario", tbusuario.Text);
			cmd.Parameters.AddWithValue("@Contraseña", tbclave.Text);
			SqlDataReader dr = cmd.ExecuteReader();
			if (dr.Read())
			{

				Response.Redirect("index.aspx");
			}

		}
	}
}

	
