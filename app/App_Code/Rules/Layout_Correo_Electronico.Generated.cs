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
	public partial class Layout_Correo_ElectronicoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Layout_Correo_Electronico", RowKind.New)]
        public void BuildNewLayout_Correo_Electronico()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
