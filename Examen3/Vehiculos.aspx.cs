using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen3
{
    public partial class Vehiculos : System.Web.UI.Page
    {
        public SqlConnection conexion;
        public string constr = ConfigurationManager.ConnectionStrings["VehiculoConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
           // conexion = new SqlConnection(constr);
            if (!IsPostBack)
            {

                DDLUser.DataSource = getData("selectUsuarios", null);
                DDLUser.DataBind();
                ListItem liProvincia = new ListItem("Seleccionar Usuario", "-1");
                DDLUser.Items.Insert(0, liProvincia);
                
            }
        }

        private DataSet getData(string sPname, SqlParameter spParameter)
        {
            conexion = new SqlConnection(constr);
            SqlDataAdapter da = new SqlDataAdapter(sPname, conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            if (spParameter != null)
            {
                da.SelectCommand.Parameters.Add(spParameter);
            }
            DataSet DS = new DataSet();
            da.Fill(DS);
            return DS;
        }

        protected void agregar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion = new SqlConnection(constr);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("agregarPlaca", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@placa", TextPlaca.Text);
                cmd.Parameters.AddWithValue("@usuario", DDLUser.SelectedValue);
                cmd.Parameters.AddWithValue("@monto", TextMonto.Text);
                
                SqlDataReader reader = cmd.ExecuteReader();

                Label4.Text = "Placa agregada";
                //TextNuevo.Enabled = true;

            }

            catch (System.Data.SqlClient.SqlException ex)
            {
                Label4.Text = ex.Message;
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
                conexion = new SqlConnection(constr);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("borrarPlaca", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numPlaca", TextPlaca.Text);
                

                SqlDataReader reader = cmd.ExecuteReader();

                Label4.Text = "Placa eliminada";


            }

            catch (System.Data.SqlClient.SqlException ex)
            {
                Label4.Text = ex.Message;
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
                conexion = new SqlConnection(constr);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("actualizarPlaca", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numPlaca", TextPlaca.Text);
                cmd.Parameters.AddWithValue("@nuevo", TextNuevo.Text);
                cmd.Parameters.AddWithValue("@usuario", DDLUser.SelectedValue);
                cmd.Parameters.AddWithValue("@monto", TextMonto.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                Label4.Text = "Placa actualizada";


            }

            catch (System.Data.SqlClient.SqlException ex)
            {
                Label4.Text = ex.Message;
            }

            finally
            {
                conexion.Close();
            }
        }
    }
}