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
	public partial class Documento1BusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Documento1", RowKind.New)]
        public void BuildNewDocumento1()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Persona_Id", 0);
            UpdateFieldValue("Cliente_Id", 0);
        }
    }
}
