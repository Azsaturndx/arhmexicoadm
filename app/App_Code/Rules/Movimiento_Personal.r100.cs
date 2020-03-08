using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using arhmexico.Data;
using arhmexico.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace arhmexico.Rules
{
    public partial class Movimiento_PersonalBusinessRules : arhmexico.Rules.SharedBusinessRules
    {

        /// <summary>
        /// This method will execute in any view before an action
        /// with a command name that matches "Custom" and argument that matches "EXECCS02".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(Movimiento_PersonalModel instance)
        {
            // This is the placeholder for method implementation.
            string conStr = ConfigurationManager.ConnectionStrings["arhmexico"].ToString();

            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Genera_Finiquito_Por_Movimiento_De_Personal", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandTimeout = 60 * 10;

                    cmd.Parameters.AddWithValue("@Tipo_Operacion_Id", 1);// ES CREACIÓN NUEVO REGISTRO

                    //------- PARAMETROS COMPARTIDOS PARA MOVIMIENTO PERSONAL Y FINIQUITO                    
                    cmd.Parameters.AddWithValue("@Contratado_Id", instance.Contratado_Id);// ES CREACIÓN NUEVO REGISTRO
                    cmd.Parameters.AddWithValue("@Pagadora_Id", instance.Pagadora_Id);
                    cmd.Parameters.AddWithValue("@Contratante_Id", instance.Contratante_Id);
                    cmd.Parameters.AddWithValue("@Cliente_Id", instance.Cliente_Id);

                    //------- PARAMETROS PROPIOS DE MOVIMIENTO PERSONAL
                    cmd.Parameters.AddWithValue("@Tipo_Movimiento_Personal_Id", instance.Tipo_Movimiento_Personal_Id);
                    cmd.Parameters.AddWithValue("@Fecha_Movimiento_Personal", instance.Fecha_Movimiento_Personal);
                    cmd.Parameters.AddWithValue("@Motivo_Movimiento_Personal_Id", instance.Motivo_Movimiento_Personal_Id);
                    cmd.Parameters.AddWithValue("@Contratante_Puesto_Id", instance.Contratante_Puesto_Id);

                    //------- PARAMETROS PROPIOS DE FINIQUITO
                    /*
                    cmd.Parameters.AddWithValue("@Puesto_Contratado_Finiquitar_Id", 1);// ES CREACIÓN NUEVO REGISTRO
                    cmd.Parameters.AddWithValue("@Tipo_Finiquito_Id", 1);// ES CREACIÓN NUEVO REGISTRO
                    cmd.Parameters.AddWithValue("@Fecha_Ingreso_Pagadora", 1);// ES CREACIÓN NUEVO REGISTRO
                    cmd.Parameters.AddWithValue("@Fecha_Salida_Pagadora", 1);// ES CREACIÓN NUEVO REGISTRO
                    cmd.Parameters.AddWithValue("@Domicilio_Contratado_Finiquitar_Id", 1);// ES CREACIÓN NUEVO REGISTRO
                    cmd.Parameters.AddWithValue("@Contacto_Contratado_Finiquitar_Id", 1);// ES CREACIÓN NUEVO REGISTRO
                    cmd.Parameters.AddWithValue("@Estatus_Finiquito_Id", 1);// ES CREACIÓN NUEVO REGISTRO
                    */

                    /*Parametros de sistema**/
                    cmd.Parameters.AddWithValue("@Creado_Por_Id", UserId);
                    cmd.Parameters.AddWithValue("@Transaccion_Id", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fijar_Bitacora", 1);
                    cmd.Parameters.AddWithValue("@Mostrar_Tablas_Sistema", 0);
                    //cmd.Parameters.Add("@Mensaje_Sistema_Id", 1);//.Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@Mensaje_Sistema_Id", 1);
                    cmd.Parameters.AddWithValue("@Simular", 0);
                    cmd.Parameters.AddWithValue("@Trace", "");//.Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@Debug", 0);

                    cmd.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    cmd.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    cmd.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    cmd.Parameters["@Trace"].Size = 8000;

                    con.Open();
                    cmd.ExecuteNonQuery();

                    con.Close();


                    if (cmd.Parameters["@Mensaje_Sistema_Id"].Value.ToString() != "1")
                    {
                        Result.ShowAlert("Ha ocurrido un error");
                    }//if (spSql.Parameters["RetVal"].Value.ToString() != "1")
                    else
                    {
                        //Result.ShowAlert("Creación Exitosa");
                        Result.Refresh();
                        Result.RefreshChildren();
                        Result.Continue();
                    }//else if (spSql.Parameters["RetVal"].Value.ToString() != "1")

                }// using (SqlCommand cmd = new SqlCommand("sp_Revision_De_Solicitud", con))
            }// using (SqlConnection con = new SqlConnection(conStr))
        }
    }
}
