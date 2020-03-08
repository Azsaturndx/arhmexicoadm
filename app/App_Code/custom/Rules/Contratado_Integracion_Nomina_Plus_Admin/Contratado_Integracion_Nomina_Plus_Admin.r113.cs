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
	public partial class Contratado_Integracion_Nomina_Plus_AdminBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        /// <summary>This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS05".
        /// </summary>
        [Rule("r113")]
        public void r113Implementation(Contratado_Integracion_Nomina_Plus_AdminModel instance)
        {
            // This is the placeholder for method implementation.
        }
    }
}
