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
	public partial class Contratado_Solicitud_DocumentoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        /// <summary>This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r105")]
        public void r105Implementation(Contratado_Solicitud_DocumentoModel instance)
        {
            // This is the placeholder for method implementation.
        }
    }
}
