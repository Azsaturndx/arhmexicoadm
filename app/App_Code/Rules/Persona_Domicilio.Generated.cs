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
	public partial class Persona_DomicilioBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Persona_Domicilio", RowKind.New)]
        public void BuildNewPersona_Domicilio()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
