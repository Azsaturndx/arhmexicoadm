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
	public partial class GridSolicitudGastoVBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "EXECCS01".
        /// </summary>
        [Rule("r103")]
        public void r103Implementation(GridSolicitudGastoVModel instance)
        {
            // This is the placeholder for method implementation.
        }
    }
}
