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
	public partial class ListaBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Lista", RowKind.New)]
        public void BuildNewLista()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
