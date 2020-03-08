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
	public partial class Motivo_MovimientoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Motivo_Movimiento", RowKind.New)]
        public void BuildNewMotivo_Movimiento()
        {
            UpdateFieldValue("Es_Alta", 0);
            UpdateFieldValue("Es_Baja", 0);
            UpdateFieldValue("Es_Cambio", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
