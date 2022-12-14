using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen3
{
    public partial class Usuarios : System.Web.UI.Page
    {
        public SqlConnection conexion;
        public string constr = ConfigurationManager.ConnectionStrings["VehiculoConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection(constr);
        }

        protected void agregar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                SqlCommand cmd = new SqlCommand("agregarUsuarios", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", TextUsuario.Text);
                cmd.Parameters.AddWithValue("@clave", TextClave.Text);
                cmd.Parameters.AddWithValue("@nombre", TextNombre.Text);
                cmd.Parameters.AddWithValue("@apellido", TextApellido.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                Label5.Text = "Usuario agregado";


            }

            catch (System.Data.SqlClient.SqlException ex)
            {
                Label5.Text = ex.Message;
            }

            finally
            {
                conexion.Close();
            }
        }

        protected void borrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                SqlCommand cmd = new SqlCommand("borrarUsuarios", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", TextUsuario.Text);
                

                SqlDataReader reader = cmd.ExecuteReader();

                Label5.Text = "Usuario eliminado";


            }

            catch (System.Data.SqlClient.SqlException ex)
            {
                Label5.Text = ex.Message;
            }

            finally
            {
                conexion.Close();
            }
        }

        protected void actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                SqlCommand cmd = new SqlCommand("actualizarUsuarios", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", TextUsuario.Text);
                cmd.Parameters.AddWithValue("@clave", TextClave.Text);
                cmd.Parameters.AddWithValue("@nombre", TextNombre.Text);
                cmd.Parameters.AddWithValue("@apellido", TextApellido.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                Label5.Text = "Usuario actualizado";


            }

            catch (System.Data.SqlClient.SqlException ex)
            {
                Label5.Text = ex.Message;
            }

            finally
            {
                conexion.Close();
            }
        }
    }
}