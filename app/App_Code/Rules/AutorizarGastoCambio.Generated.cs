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
	public partial class AutorizarGastoCambioBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("AutorizarGastoCambio", RowKind.New)]
        public void BuildNewAutorizarGastoCambio()
        {
            UpdateFieldValue("Fecha_Gasto", SelectFieldValue("Context_Fecha_Gasto"));
            UpdateFieldValue("Monto_Solicitado", SelectFieldValue("Context_Monto_Gasto"));
        }
    }
}
