using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Teoria_de_Sistemas
{
    public static class Datos
    {
        public static string cadenaConeccion = "Data Source=MARCUAN-PC\\SQL_SERVER;Initial Catalog=DBFerreteria;Integrated Security=True";

        public static DataTable dataGrid(string consulta)
        {
            try
            {
                SqlCommand Comando = new SqlCommand();
                SqlConnection Conexion = new SqlConnection();
                Conexion.ConnectionString = cadenaConeccion;

                Comando.CommandText = (consulta);
                Comando.Connection = Conexion;

                Conexion.Open();
                DataTable dt = new DataTable();
                dt.Load(Comando.ExecuteReader());
                Conexion.Close();
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }

        public static DataSet dcomboBox(ComboBox comboBox,string tabla, string campo)
        {
            try
            {
                SqlConnection conexion = new SqlConnection();
                conexion.ConnectionString = cadenaConeccion;
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select " + campo + " from " + tabla, conexion);
                da.Fill(ds, tabla);
                comboBox.DataSource = ds.Tables[0].DefaultView;
                comboBox.ValueMember = campo;
                return ds;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }
    }
}
