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
	public partial class Contratante_AdminBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "EXECCS01".
        /// </summary>
        [Rule("r104")]
        public void r104Implementation(Contratante_AdminModel instance)
        {
            // This is the placeholder for method implementation.
            int contratanteId = (int)instance.Contratante_Id;
            int mensajeSistemaId = 0;
            string mensajeSistema = "";

            bool resultadoCrearUsuarioContratante = CrearUsuariosContratante(
                                                                               contratanteId
                                                                               , out mensajeSistema
                                                                               , out mensajeSistemaId
                                                                            );
            if (resultadoCrearUsuarioContratante)
            {
                mensajeSistemaId = 1;
                // mensajeSistema = "Creada exitosamente";
                Result.ShowAlert(mensajeSistema);
            }//if(resultadoCrearUsuarioContratante)
            else
            {
                Result.ShowAlert(mensajeSistema);
            }//if(!resultadoCrearUsuarioContratante)
        }
    }
}
