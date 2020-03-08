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
	public partial class Estatus_DemandaBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Estatus_Demanda", RowKind.New)]
        public void BuildNewEstatus_Demanda()
        {
            UpdateFieldValue("Es_Concluida", 0);
            UpdateFieldValue("Es_Activa", 0);
        }
    }
}
