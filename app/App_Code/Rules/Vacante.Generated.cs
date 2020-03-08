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
	public partial class VacanteBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Vacante", RowKind.New)]
        public void BuildNewVacante()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
