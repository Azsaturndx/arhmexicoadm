using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using arhmexico.Data;
using arhmexico.Models;

namespace arhmexico.Rules
{
	public partial class Persona_DomicilioBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// This method will execute in any view after an action
        /// with a command name that matches "EXECCS02".
        /// </summary>
        [Rule("r102")]
        public void r102Implementation(Persona_DomicilioModel instance)
        {
            // This is the placeholder for method implementation.
            using (SqlProcedure sql = new SqlProcedure("dbo.sp_Creacion_Domicilio_Persona"))
            {
                sql.Command.CommandTimeout = 60 * 10;
                //Definición parametro especial para recibir el RETURN del SP
                sql.AddParameter("RetVal", 0);
                sql.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                //Definición de Parametros especificos del SP 
                // 
                //sql.AddParameter("@Producto_Nombre", instance.Producto_);

                sql.AddParameter("@Tipo_Operacion_Id", 2);// 2. UPDATE
                sql.AddParameter("@Persona_Id", instance.Persona_Id);
                sql.AddParameter("@Calle", instance.Custom_Domicilio_Calle);
                sql.AddParameter("@Numero_Interior", instance.Custom_Domicilio_Numero_Interior);
                sql.AddParameter("@Numero_Exterior", instance.Custom_Domicilio_Numero_Exterior);
                sql.AddParameter("@Colonia", instance.Custom_Domicilio_Colonia);
                sql.AddParameter("@Ciudad_Id", instance.Custom_Domicilio_Ciudad_Id);
                sql.AddParameter("@Codigo_Postal_Id", instance.Custom_Domicilio_Codigo_Postal_Id);
                sql.AddParameter("@Entre_Calles", instance.Custom_Domicilio_Entre_Calles);
                sql.AddParameter("@Latitud", instance.Custom_Domicilio_Latitud);
                sql.AddParameter("@Longitud", instance.Custom_Domicilio_Longitud);
                sql.AddParameter("@Tipo_Domicilio_Id", instance.Tipo_Domicilio_Id);
                sql.AddParameter("@Es_Domicilio_Principal", instance.Es_Domicilio_Principal);
                //-------------------------               
                //Definición de parámetros de Salida
                sql.AddParameter("@Persona_Domicilio_Id", instance.Persona_Domicilio_Id);
                sql.AddParameter("@Estatus_Registro_Id", instance.Estatus_Registro_Id);
                sql.AddParameter("@Domicilio_Id", instance.Domicilio_Id);

                //Definición de parametros de Sistema
                sql.AddParameter("@Creado_Por_Id", UserId);
                sql.AddParameter("@Transaccion_Id", DBNull.Value);
                sql.AddParameter("@Fijar_Bitacora", 1);
                sql.AddParameter("@Mostrar_Tablas_Sistema", 0);
                sql.AddParameter("@Mensaje_Sistema_Id", 0);
                sql.AddParameter("@Simular", 0);
                sql.AddParameter("@Trace", "");
                sql.AddParameter("@Debug", 0);

                //Definición de dirección para parametros de salida
                //sql.Parameters["@Persona_Domicilio_Id"].Direction = ParameterDirection.Output;
                sql.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                sql.Parameters["@Trace"].Direction = ParameterDirection.Output;

                //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                 
                sql.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                sql.Parameters["@Trace"].Size = 8000;

                sql.ExecuteNonQuery();

                if (sql.Parameters["RetVal"].Value.ToString() != "1")
                {
                    String ErrorMessage = SqlText.ExecuteScalar("SELECT Mensaje_Amigable_Usuario FROM dbo.Mensaje_Sistema WHERE Mensaje_Sistema_Id=" + sql.Parameters["@Mensaje_Sistema_Id"].Value.ToString()).ToString();
                    Result.ShowAlert(ErrorMessage);
                }
                else
                {
                    Result.Continue();
                }
            }// using (SqlProcedure sql = new SqlProcedure("dbo.sp_Creacion_Domicilio_Persona"))
        }
    }
}
