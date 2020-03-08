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
	public partial class Tipo_GastoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Tipo_Gasto", RowKind.New)]
        public void BuildNewTipo_Gasto()
        {
            UpdateFieldValue("Es_De_Hospedaje", 0);
            UpdateFieldValue("Es_De_Alimentos", 0);
            UpdateFieldValue("Es_Aerolinea", 0);
            UpdateFieldValue("Es_Transporte_Terrestre", 0);
            UpdateFieldValue("Es_Otro", 0);
            UpdateFieldValue("Es_Gasolina", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
