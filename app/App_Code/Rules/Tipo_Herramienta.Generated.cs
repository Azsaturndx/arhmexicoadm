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
	public partial class Tipo_HerramientaBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Tipo_Herramienta", RowKind.New)]
        public void BuildNewTipo_Herramienta()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Es_Vehiculo", 0);
            UpdateFieldValue("Aplica_Numero_Serie", 0);
        }
    }
}
