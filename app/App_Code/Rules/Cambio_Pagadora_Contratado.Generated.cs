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
	public partial class Cambio_Pagadora_ContratadoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Cambio_Pagadora_Contratado", RowKind.New)]
        public void BuildNewCambio_Pagadora_Contratado()
        {
            UpdateFieldValue("Contratante_Id", SelectFieldValue("Context_Contratante_Id"));
            UpdateFieldValue("Cliente_Id", SelectFieldValue("Context_Cliente_Id"));
        }
    }
}
