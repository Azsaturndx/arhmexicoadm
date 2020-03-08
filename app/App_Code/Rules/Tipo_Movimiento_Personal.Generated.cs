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
	public partial class Tipo_Movimiento_PersonalBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Tipo_Movimiento_Personal", RowKind.New)]
        public void BuildNewTipo_Movimiento_Personal()
        {
            UpdateFieldValue("Genera_Finiquito", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Mostrar_En_Historial", 0);
        }
    }
}
