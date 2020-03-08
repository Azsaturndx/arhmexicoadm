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
	public partial class Candidato_AdminBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Candidato_Admin", RowKind.New)]
        public void BuildNewCandidato_Admin()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
