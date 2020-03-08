﻿using System;
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
	public partial class Administracion_Gasto_ContratanteBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        /// <summary>This method will execute in any view before an action
        /// with a command name that matches "Insert" and argument that matches "EXECCS01".
        /// </summary>
        [Rule("r103")]
        public void r103Implementation(Administracion_Gasto_ContratanteModel instance)
        {
            // This is the placeholder for method implementation.
        }
    }
}