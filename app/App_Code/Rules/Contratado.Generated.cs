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
	public partial class ContratadoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Contratado", RowKind.New)]
        public void BuildNewContratado()
        {
            UpdateFieldValue("Candidato_Id", 0);
        }
    }
}
