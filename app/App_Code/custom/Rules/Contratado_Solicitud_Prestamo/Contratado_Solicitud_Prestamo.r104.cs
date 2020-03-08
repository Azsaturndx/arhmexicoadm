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
	public partial class Contratado_Solicitud_PrestamoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        /// <summary>This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r104")]
        public void r104Implementation(Contratado_Solicitud_PrestamoModel instance)
        {
            // This is the placeholder for method implementation.
            int contratadoId = Convert.ToInt32(instance.Contratado_Id);
            int tipoOperacionId = 8; //Solicitud
            bool resultado;
            int mensajeSistemaId;
            string mensajeSistema;
            string notasSolicitud = "";
            string notasAutorizacionRechazo = "";
            string solicitudPrestamoKey = "";
            decimal montoSolicitado = 0;
            int contratadoSolicitudPrestamoId = Convert.ToInt32(instance.Contratado_Solicitud_Prestamo_Id);


            SharedBusinessRules sr = new SharedBusinessRules();

            resultado = sr.AdministrarSolicitudPrestamo(tipoOperacionId, contratadoId, contratadoSolicitudPrestamoId, 0, notasSolicitud, notasAutorizacionRechazo, solicitudPrestamoKey, montoSolicitado, out mensajeSistema, out mensajeSistemaId);

            if (resultado)
            {
                Result.ShowAlert("Solicitud Creada Exitosamente.");
            }//if(resultado)
            else
            {
                Result.ShowAlert(mensajeSistema);
            }//else if(resultado)
        }
    }
}
