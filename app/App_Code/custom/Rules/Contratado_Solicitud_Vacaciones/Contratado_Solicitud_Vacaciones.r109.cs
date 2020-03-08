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
	public partial class Contratado_Solicitud_VacacionesBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        /// <summary>This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "EXECCS08".
        /// </summary>
        [Rule("r109")]
        public void r109Implementation(Contratado_Solicitud_VacacionesModel instance)
        {
            // This is the placeholder for method implementation.
            bool resultadoValidarVacaciones = false;
            int mensajeSistemaId = 0;
            string mensajeSistema = "";
            int contratadoParametro = (int)instance.Contratado_Id;
            DateTime fechaSolicitudParametro = (DateTime)instance.Fecha_Solicitud;
            int diasSolicitadosParametro = (int)instance.Dias_Solicitados;
            DateTime fechaInicioVacaciones = (DateTime)instance.Fecha_Inicio_Vacaciones;
            DateTime fechaFinVacaciones = (DateTime)instance.Fecha_Fin_Vacaciones;




            SharedBusinessRules sb = new SharedBusinessRules();
           
                int tipoOperacionId = 7;//Cancelación
                int contratadoSolicitudVacacionesId = (int)instance.Contratado_Solicitud_Vacaciones_Id;//(int)instance.Contratado_Solicitud_Vacaciones_Id;
                string solicitudVacacionesKey = instance.Solicitud_Vacaciones_Key.ToString();
                int estatusSolicitudId = (int)instance.Estatus_Solicitud_Id;//Creación
                DateTime fechaAutorizacionRechazo = DateTime.Today;  //Para insertar a la solicitud se pone el día de hoy ya que el sp no los tomara en cuenta 
                string autorizadoRechazadoPorId = UserId.ToString();
                string notasAutorizacionRechazo = "";
                int diasAutorizados = (int)instance.Dias_Solicitados; ;
                DateTime fechaInicioVacacionesAutorizado = DateTime.Today;//Para insertar a la solicitud se pone el día de hoy ya que el sp no los tomara en cuenta 
                DateTime fechaFinVacacionesAutorizado = DateTime.Today;//Para insertar a la solicitud se pone el día de hoy ya que el sp no los tomara en cuenta 
                string html = "";
                bool resultadoGuardarSolicitudVacaciones = sb.AdministrarSolicitudVacaciones(
                                                                                                   tipoOperacionId
                                                                                                   , contratadoSolicitudVacacionesId
                                                                                                   , solicitudVacacionesKey
                                                                                                   , contratadoParametro
                                                                                                   , fechaSolicitudParametro
                                                                                                   , diasSolicitadosParametro
                                                                                                   , fechaInicioVacaciones
                                                                                                   , fechaFinVacaciones
                                                                                                   , estatusSolicitudId
                                                                                                   , fechaAutorizacionRechazo//fechaAutorizacionRechazo
                                                                                                   , autorizadoRechazadoPorId
                                                                                                   , notasAutorizacionRechazo
                                                                                                   , diasAutorizados
                                                                                                   , fechaInicioVacacionesAutorizado
                                                                                                   , fechaFinVacacionesAutorizado
                                                                                                   , out html
                                                                                                   , out mensajeSistema
                                                                                                   , out mensajeSistemaId
                                                                                                );
                if (resultadoGuardarSolicitudVacaciones)
                {
                    //mensajeSistemaId = 87;
                    //mensajeSistema = "Solicitud se ha creado exitosamente";
                    //Result.ShowAlert(mensajeSistema);
                    Result.Continue();
                }
                else// if (!resultadoGuardarSolicitudVacaciones)
                {
                    mensajeSistemaId = 86;
                    //mensajeSistema = mensajeSistema;
                    Result.ShowAlert(mensajeSistema);
                }//else// if (!resultadoGuardarSolicitudVacaciones)


        }//public void r109Implementation(Contratado_Solicitud_VacacionesModel instance)
    }//public partial class Contratado_Solicitud_VacacionesBusinessRules : arhmexico.Rules.SharedBusinessRules
}//namespace arhmexico.Rules
