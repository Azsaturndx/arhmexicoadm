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
        
        /// <summary>Rule "Solicitar_Vacaciones" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS05".
        /// </summary>
        [Rule("r112")]
        public void r112Implementation(AusentismoModel instance)
        {
            // This is the placeholder for method implementation.
            bool resultadoValidarVacaciones = false;
            int mensajeSistemaId = 0;
            string mensajeSistema = "";
            int contratadoParametro = (int)instance.Contratado_Id;
            DateTime fechaSolicitudParametro = (DateTime)instance.Fecha_Solicitud_Ausentismo;
            int diasSolicitadosParametro = (int)instance.Dias_Ausentismo_Solicitados;
            DateTime fechaInicioVacaciones = (DateTime)instance.Fecha_Inicio_Ausentismo;
            DateTime fechaFinVacaciones = (DateTime)instance.Fecha_Fin_Ausentismo;




            SharedBusinessRules sb = new SharedBusinessRules();
            resultadoValidarVacaciones = sb.ValidarSolicitudVacaciones(
                                                                                        contratadoParametro
                                                                                        , fechaSolicitudParametro
                                                                                        , diasSolicitadosParametro
                                                                                        , fechaInicioVacaciones
                                                                                        , fechaFinVacaciones
                                                                                        , out mensajeSistema
                                                                                        , out mensajeSistemaId
                                                                        );
            if (resultadoValidarVacaciones)
            {
                int tipoOperacionId = 1;//Alta
                int contratadoSolicitudVacacionesId = 0;
                string solicitudVacacionesKey = "";
                int estatusSolicitudId = 1;//Pendiente de autorizar
                DateTime fechaAutorizacionRechazo = DateTime.Today;  //Para insertar a la solicitud se pone el día de hoy ya que el sp no los tomara en cuenta 
                string autorizadoRechazadoPorId = "";
                string notasAutorizacionRechazo = "";
                int diasAutorizados = 0;
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
                    mensajeSistemaId = 668;
                    mensajeSistema = "Solicitud Creada exitosamente";
                    Result.ShowAlert(mensajeSistema);
                }
                else// if (!resultadoGuardarSolicitudVacaciones)
                {
                    mensajeSistemaId = 669;
                    //mensajeSistema = "Ha ocurrido un Errorl al Crear la Solicitud";
                    Result.ShowAlert(mensajeSistema);
                }//else// if (!resultadoGuardarSolicitudVacaciones)
            }// if (resultadoValidarVacaciones)
            else//if (!resultadoValidarVacaciones)
            {
                Result.ShowAlert(mensajeSistema);
            }//if (!resultadoValidarVacaciones)
        }//public void r112Implementation(AusentismoModel instance)
    }//public partial class AusentismoBusinessRules : arhmexico.Rules.SharedBusinessRules
}//namespace arhmexico.Rules
