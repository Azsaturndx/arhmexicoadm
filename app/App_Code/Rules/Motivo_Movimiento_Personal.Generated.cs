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
	public partial class Motivo_Movimiento_PersonalBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Motivo_Movimiento_Personal", RowKind.New)]
        public void BuildNewMotivo_Movimiento_Personal()
        {
            UpdateFieldValue("Tipo_Movimiento_Personal_Id", 0);
            UpdateFieldValue("Tipo_Finiquito_Id", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
