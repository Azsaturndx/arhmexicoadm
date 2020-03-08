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
	public partial class Administracion_Gasto_SociedadesBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// This method will execute in any view before an action
        /// with a command name that matches "Custom" and argument that matches "EXECCS02".
        /// </summary>
        [Rule("r110")]
        public void r110Implementation(Administracion_Gasto_SociedadesModel instance)
        {
            // This is the placeholder for method implementation.
        }
    }
}
