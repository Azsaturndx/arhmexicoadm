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
	public partial class Contratado_Solicitud_VacacionesBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Contratado_Solicitud_Vacaciones", RowKind.New)]
        public void BuildNewContratado_Solicitud_Vacaciones()
        {
            UpdateFieldValue("Notas_Autorizacion_Rechazo", "Sin Notas");
        }
    }
}
