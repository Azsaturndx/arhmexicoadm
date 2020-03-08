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
	public partial class Cambio_Contratante_ContratadoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Cambio_Contratante_Contratado", RowKind.New)]
        public void BuildNewCambio_Contratante_Contratado()
        {
            UpdateFieldValue("Cliente_Id", SelectFieldValue("Context_Cliente_Id"));
        }
    }
}
