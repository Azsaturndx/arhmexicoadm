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
	public partial class Tipo_ProveedorBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Tipo_Proveedor", RowKind.New)]
        public void BuildNewTipo_Proveedor()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Contratante_Id", 0);
            UpdateFieldValue("Cliente_Id", 0);
        }
    }
}
