using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using arhmexico.Data;

namespace arhmexico.Rules
{
	public partial class Proveedor_DomicilioBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Proveedor_Domicilio", RowKind.New)]
        public void BuildNewProveedor_Domicilio()
        {
            UpdateFieldValue("Proveedor_Id", 0);
            UpdateFieldValue("Domicilio_Id", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
