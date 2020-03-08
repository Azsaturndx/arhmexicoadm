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
	public partial class Tipo_DomicilioBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Tipo_Domicilio", RowKind.New)]
        public void BuildNewTipo_Domicilio()
        {
            UpdateFieldValue("Es_Domicilio_Propio", ((0)));
            UpdateFieldValue("Es_Domicilio_Rentado", ((0)));
            UpdateFieldValue("Es_Domicilio_Familiar", ((0)));
            UpdateFieldValue("Es_Domicilio_Trabajo", ((0)));
            UpdateFieldValue("Es_Domicilio_Fiscal", ((0)));
            UpdateFieldValue("Es_Domicilio_Empresa", ((0)));
            UpdateFieldValue("Es_Sucursal", ((0)));
            UpdateFieldValue("Es_Matriz", ((0)));
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Aplica_Persona", ((0)));
            UpdateFieldValue("Aplica_Contratante", ((0)));
        }
    }
}
