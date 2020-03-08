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
	public partial class Temporal_Cargador_ContratadoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(Temporal_Cargador_ContratadoModel instance)
        {
            // This is the placeholder for method implementation.

            SharedBusinessRules sr = new SharedBusinessRules();

            bool resultado = false;
            int mensajeSistemaId = 0;
            string mensajeSistema = "";

            resultado = sr.ProcesarTemporalCargaContratado(out mensajeSistemaId, out mensajeSistema);

            if(resultado)
            {
                Result.ShowAlert("Registros procesados con éxito");

            }
            else
            {
                Result.ShowAlert("Ocurrió un error; " + mensajeSistema);
            }
        }
    }
}
