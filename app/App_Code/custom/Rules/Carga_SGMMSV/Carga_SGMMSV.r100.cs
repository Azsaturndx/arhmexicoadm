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
	public partial class Carga_SGMMSVBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// This method will execute in any view after an action
        /// with a command name that matches "ExecCS01" and argument that matches "Custom".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(Carga_SGMMSVModel instance)
        {
            // This is the placeholder for method implementation.
            bool resultado;
            string mensajeSistema;
            int mensajeSistemaId;

            SharedBusinessRules sr = new SharedBusinessRules();

            resultado = sr.CargarSGMMYSV(out mensajeSistemaId, out mensajeSistema);

            if(resultado)
            {
                Result.ShowAlert(mensajeSistema);
            }//if(resultado)
            else
            {
                Result.ShowAlert("Ocurrió un error al tratar de procesar los datos.");
            }//else if(resultado)

        }
    }
}
