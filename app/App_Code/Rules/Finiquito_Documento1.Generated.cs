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
	public partial class Finiquito_Documento1BusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Finiquito_Documento1", RowKind.New)]
        public void BuildNewFiniquito_Documento1()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Finiquito_Id", 0);
        }
    }
}
