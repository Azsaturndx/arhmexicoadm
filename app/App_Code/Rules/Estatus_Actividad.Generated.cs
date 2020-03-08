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
	public partial class Estatus_ActividadBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Estatus_Actividad", RowKind.New)]
        public void BuildNewEstatus_Actividad()
        {
            UpdateFieldValue("Significa_Actividad_Pendiente", 0);
            UpdateFieldValue("Significa_Actividad_Completada", 0);
            UpdateFieldValue("Significa_Actividad_Cancelada", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
