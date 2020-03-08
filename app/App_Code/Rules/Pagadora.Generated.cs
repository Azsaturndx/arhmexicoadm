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
	public partial class PagadoraBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Pagadora", RowKind.New)]
        public void BuildNewPagadora()
        {
            UpdateFieldValue("Cliente_Id", 0);
            UpdateFieldValue("Contratante_Id", 0);
            UpdateFieldValue("Estatus_Pagadora_Id", 1);
        }
    }
}
