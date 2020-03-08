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
	public partial class Estatus_GastoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Estatus_Gasto", RowKind.New)]
        public void BuildNewEstatus_Gasto()
        {
            UpdateFieldValue("Significa_Autorizado", 0);
            UpdateFieldValue("Significa_Rechazado", 0);
            UpdateFieldValue("Significa_En_Revision", 0);
            UpdateFieldValue("Significa_No_Aplica", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
