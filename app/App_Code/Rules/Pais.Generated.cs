﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using arhmexico.Data;

namespace arhmexico.Rules
{
	public partial class PaisBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Pais", RowKind.New)]
        public void BuildNewPais()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
