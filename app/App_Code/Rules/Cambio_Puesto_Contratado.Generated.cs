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
	public partial class Cambio_Puesto_ContratadoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Cambio_Puesto_Contratado", RowKind.New)]
        public void BuildNewCambio_Puesto_Contratado()
        {
            UpdateFieldValue("Contratante_Id", SelectFieldValue("Context_Contratante_Id"));
        }
    }
}
