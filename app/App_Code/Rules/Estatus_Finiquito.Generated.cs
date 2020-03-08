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
	public partial class Estatus_FiniquitoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Estatus_Finiquito", RowKind.New)]
        public void BuildNewEstatus_Finiquito()
        {
            UpdateFieldValue("Significa_Solicitud_Pendiente_Atender", 0);
            UpdateFieldValue("Significa_Solicitud_Terminada", 0);
            UpdateFieldValue("Significa_Solicitud_En_Proceso", 0);
            UpdateFieldValue("Significa_Solicitud_Cancelada", 0);
        }
    }
}
