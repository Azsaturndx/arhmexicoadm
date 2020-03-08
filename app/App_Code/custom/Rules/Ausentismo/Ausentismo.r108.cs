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
	public partial class AusentismoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        /// <summary>Rule "Autorizar" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r108")]
        public void r108Implementation(AusentismoModel instance)
        {

            // This is the placeholder for method implementation.
            string mensajeSistema = "";
            int mensajeSistemaId = 0;
            int tipoOperacionId = 4;
            string html = "";
            /*
                    TIPO DE OPERACIÓN
                           0	Sin Tipo de Operación
                           1	Alta
                           2	Edición
                           3	Borrado
                           4	Autorización
                           5	Autorización con Cambios
                           6	Rechazo
                           7	Cancelación
            */


            using (SqlProcedure sp = new SqlProcedure("dbo.sp_Administrar_Ausentismo"))
            {
                try
                {
                    //SqlServerCommand.Command.CommandType = System.Data.CommandType.StoredProcedure;
                    //SqlServerCommand.Command.CommandType
                    sp.Command.CommandTimeout = 60 * 10;


                    //PARÁMETROS IDENTIFICACIÓN OBJETO
                    sp.AddParameter("@Tipo_Operacion_Id", tipoOperacionId);
                    sp.AddParameter("@Ausentismo_Id", instance.Ausentismo_Id);
                    sp.AddParameter("@Ausentismo_Key", instance.Ausentismo_Key);
                    sp.AddParameter("@Tipo_Ausentismo_Id", instance.Tipo_Ausentismo_Id);
                    sp.AddParameter("@Contratado_Id", instance.Contratado_Id);

                    sp.AddParameter("@Fecha_Solicitud_Ausentismo", instance.Fecha_Solicitud_Ausentismo);
                    sp.AddParameter("@Fecha_Inicio_Ausentismo", instance.Fecha_Inicio_Ausentismo);
                    sp.AddParameter("@Fecha_Fin_Ausentismo", instance.Fecha_Fin_Ausentismo);
                    sp.AddParameter("@Dias_Ausentismo_Solicitados", instance.Dias_Ausentismo_Solicitados);
                    sp.AddParameter("@Motivo_Ausentismo", instance.Motivo_Ausentismo);
                    sp.AddParameter("@Estatus_Ausentismo_Id", instance.Estatus_Ausentismo_Id);
                    sp.AddParameter("@Fecha_Autorizacion_Rechazo", instance.Fecha_Autorizacion_Rechazo);

                    sp.AddParameter("@Autorizado_Rechazado_Por_Id", DBNull.Value);
                    sp.AddParameter("@Notas_Autorizacion_Rechazo", instance.Notas_Autorizacion_Rechazo);
                    sp.AddParameter("@Dias_Autorizados", instance.Dias_Ausentismo_Solicitados);
                    sp.AddParameter("@Fecha_Inicio_Ausentismo_Autorizado", instance.Fecha_Inicio_Ausentismo);
                    sp.AddParameter("@Fecha_Fin_Ausentismo_Autorizado", instance.Fecha_Fin_Ausentismo);
                    sp.AddParameter("@HTML", html);

                    sp.AddParameter("@Mensaje_Sistema", mensajeSistema);

                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida 
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Mensaje_Sistema"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;
                    sp.Parameters["@HTML"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP 
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Mensaje_Sistema"].Size = 8000;
                    sp.Parameters["@Trace"].Size = 8000;
                    sp.Parameters["@HTML"].Size = 8000;

                    //EJECUCIÓN SP
                    sp.ExecuteNonQuery();
                    //ASIGNACIÓN DE PARÁMETRO DE SALIDA

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    mensajeSistema = Convert.ToString(sp.Parameters["@Mensaje_Sistema"].Value);
                    //objetoPersonaDomicilioId = Convert.ToInt32(sp.Parameters["@Persona_Domicilio_Id"].Value);



                }//try
                catch (Exception ex)
                {
                    mensajeSistemaId = 639;
                    mensajeSistema = ex.Message;

                    //return false;
                }//catch (Exception e)
            }//using (SqlProcedure sp = new SqlProcedure("dbo.sp_Administrar_Ausentismo"))

            Result.ShowAlert(mensajeSistema);

        }//public void r108Implementation(AusentismoModel instance)
    }//public partial class AusentismoBusinessRules : arhmexico.Rules.SharedBusinessRules
}//namespace arhmexico.Rules
