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
	public partial class Medio_PagoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Medio_Pago", RowKind.New)]
        public void BuildNewMedio_Pago()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
