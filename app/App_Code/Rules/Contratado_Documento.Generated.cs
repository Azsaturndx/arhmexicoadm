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
	public partial class Contratado_DocumentoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Contratado_Documento", RowKind.New)]
        public void BuildNewContratado_Documento()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
