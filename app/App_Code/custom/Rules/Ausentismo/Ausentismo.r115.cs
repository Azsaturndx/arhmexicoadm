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
        
        /// <summary>Rule "Cancelar_Solicitud_Vacaciones" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS08".
        /// </summary>
        [Rule("r115")]
        public void r115Implementation(AusentismoModel instance)
        {
            // This is the placeholder for method implementation.
            int mensajeSistemaId = 0;
            string mensajeSistema = "";
            int contratadoParametro = (int)instance.Contratado_Id;
            DateTime fechaSolicitudParametro = (DateTime)instance.Fecha_Solicitud_Ausentismo;
            int diasSolicitadosParametro = (int)instance.Dias_Ausentismo_Solicitados;
            DateTime fechaInicioVacaciones = (DateTime)instance.Fecha_Inicio_Ausentismo;
            DateTime fechaFinVacaciones = (DateTime)instance.Fecha_Fin_Ausentismo;
            int tipoOperacionId = 7;//Cancelación
            int contratadoSolicitudVacacionesId = (int)instance.Contratado_Solicitud_Vacaciones_Id;
            string solicitudVacacionesKey = instance.Solicitud_Vacaciones_Key.ToString();
            int estatusSolicitudId = 5;//Cancelación
            DateTime fechaAutorizacionRechazo = DateTime.Today;  //Para insertar a la solicitud se pone el día de hoy ya que el sp no los tomara en cuenta 
            string autorizadoRechazadoPorId = UserId.ToString();
            string notasAutorizacionRechazo = "";
            int diasAutorizados = (int)instance.Dias_Autorizados;// (int)instance.Dias_Solicitados; ;
            DateTime fechaInicioVacacionesAutorizado = DateTime.Today;//Para insertar a la solicitud se pone el día de hoy ya que el sp no los tomara en cuenta 
            DateTime fechaFinVacacionesAutorizado = DateTime.Today;//Para insertar a la solicitud se pone el día de hoy ya que el sp no los tomara en cuenta 
            string html = "";

            SharedBusinessRules sb = new SharedBusinessRules();

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
                mensajeSistemaId = 677;
                mensajeSistema = "Solicitud Cancelada exitosamente";
                Result.ShowAlert(mensajeSistema);
            }
            else// if (!resultadoGuardarSolicitudVacaciones)
            {
                mensajeSistemaId = 678;
                mensajeSistema = "Ha ocurrido un Errorl al Cancelar la Solicitud";
                Result.ShowAlert(mensajeSistema);
            }//else// if (!resultadoGuardarSolicitudVacaciones)
        }//public void r115Implementation(AusentismoModel instance)
    }//public partial class AusentismoBusinessRules : arhmexico.Rules.SharedBusinessRules
}//namespace arhmexico.Rules
