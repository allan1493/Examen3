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
    public partial class Login : System.Web.UI.Page
    {
        public SqlConnection conexion;
        public string constr = ConfigurationManager.ConnectionStrings["VehiculoConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection(constr);
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                SqlCommand cmd = new SqlCommand("selectLogin", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", TextBox1.Text);
                cmd.Parameters.AddWithValue("@clave", TextBox2.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Response.Redirect("Inicio.aspx");

                }


            }

            catch (System.Data.SqlClient.SqlException ex)
            {
                Label1.Text = ex.Message;
            }

            finally
            {
                conexion.Close();
            }

        }
    }
}