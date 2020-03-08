using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using System.Configuration;
using System.Data.SqlClient;
using arhmexico.Data;
using arhmexico.Models;

namespace arhmexico.Rules
{
	public partial class Publicacion_VacanteBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// This method will execute in any view before an action
        /// with a command name that matches "Custom" and argument that matches "EXECSQL02".
        /// </summary>
        [Rule("r105")]
        public void r105Implementation(Publicacion_VacanteModel instance)
        {
            // This is the placeholder for method implementation.

            // ESTA ES LA LLAMADA PARA ACTUALIZACION DE REGISTRO
            string conStr = ConfigurationManager.ConnectionStrings["arhmexico"].ToString();

            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Genera_Publicacion_Vacante", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandTimeout = 60 * 10;

                    cmd.Parameters.AddWithValue("@Tipo_Operacion_Id", 2); // TIPO ACTUALIZACION
                    cmd.Parameters.AddWithValue("@Vacante_Id", instance.VacanteId);
                    cmd.Parameters.AddWithValue("@Publicacion_Texto", instance.Publicacion_Texto);
                    cmd.Parameters.AddWithValue("@Canal_Publicacion_Id", instance.Canal_Publicacion_Id);
                    cmd.Parameters.AddWithValue("@Fecha_Publicacion", instance.Fecha_Publicacion);
                    cmd.Parameters.AddWithValue("@Publicacion_Vacante_Id", instance.Publicacion_Vacante_Id);

                    /*Parametros de sistema**/
                    cmd.Parameters.AddWithValue("@Creado_Por_Id", UserId);
                    cmd.Parameters.AddWithValue("@Transaccion_Id", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fijar_Bitacora", 1);
                    cmd.Parameters.AddWithValue("@Mostrar_Tablas_Sistema", 0);
                    cmd.Parameters.AddWithValue("@Mensaje_Sistema_Id", 1);
                    cmd.Parameters.AddWithValue("@Simular", 0);
                    cmd.Parameters.AddWithValue("@Trace", "");
                    cmd.Parameters.AddWithValue("@Debug", 0);

                    cmd.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    cmd.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    cmd.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    cmd.Parameters["@Trace"].Size = 8000;

                    con.Open();
                    cmd.ExecuteNonQuery();

                    con.Close();
                }// using (SqlCommand cmd = new SqlCommand("sp_Genera_Publicacion_Vacante", con))
            }// using (SqlConnection con = new SqlConnection(conStr))
        }
    }
}
