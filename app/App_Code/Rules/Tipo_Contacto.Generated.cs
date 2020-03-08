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
	public partial class Tipo_ContactoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Tipo_Contacto", RowKind.New)]
        public void BuildNewTipo_Contacto()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
