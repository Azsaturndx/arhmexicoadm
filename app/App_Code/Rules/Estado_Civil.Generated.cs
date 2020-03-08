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
	public partial class Estado_CivilBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Estado_Civil", RowKind.New)]
        public void BuildNewEstado_Civil()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
