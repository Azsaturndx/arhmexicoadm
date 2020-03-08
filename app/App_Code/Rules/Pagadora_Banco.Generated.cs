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
	public partial class Pagadora_BancoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Pagadora_Banco", RowKind.New)]
        public void BuildNewPagadora_Banco()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
