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
	public partial class Contratante_PuestoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Contratante_Puesto", RowKind.New)]
        public void BuildNewContratante_Puesto()
        {
            UpdateFieldValue("Contratante_Id", SelectFieldValue("Context_Contratante_Id"));
        }
    }
}
