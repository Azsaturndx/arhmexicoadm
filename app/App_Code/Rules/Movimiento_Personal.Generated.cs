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
	public partial class Movimiento_PersonalBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Movimiento_Personal", RowKind.New)]
        public void BuildNewMovimiento_Personal()
        {
            UpdateFieldValue("Tipo_Movimiento_Personal_Id", 0);
            UpdateFieldValue("Contratado_Id", 0);
            UpdateFieldValue("Motivo_Movimiento_Personal_Id", 0);
            UpdateFieldValue("Pagadora_Id", 0);
            UpdateFieldValue("Contratante_Puesto_Id", 0);
            UpdateFieldValue("Contratante_Id", 0);
            UpdateFieldValue("Cliente_Id", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Mostrar_En_Historial", 0);
        }
    }
}
