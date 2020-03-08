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
	public partial class Lista_ElementoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Lista_Elemento", RowKind.New)]
        public void BuildNewLista_Elemento()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
