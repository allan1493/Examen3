using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Examen3
{
    public partial class Reporte : System.Web.UI.Page
    {
        public SqlConnection conexion;
        public string constr = ConfigurationManager.ConnectionStrings["VehiculoConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                DDLPlaca.DataSource = getData("selectPlaca", null);
                DDLPlaca.DataBind();
                ListItem liProvincia = new ListItem("Seleccionar Placa", "-1");
                DDLPlaca.Items.Insert(0, liProvincia);

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

        protected void Button1_Click(object sender, EventArgs e)
        {
            conexion = new SqlConnection(constr);
            conexion.Open();

            SqlCommand cmd = new SqlCommand("reporte", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@numPlaca", DDLPlaca.SelectedValue);
            SqlDataReader lector3 = cmd.ExecuteReader();
            GridView1.DataSource = lector3;
            GridView1.DataBind();
            conexion.Close();
        }
    }
}