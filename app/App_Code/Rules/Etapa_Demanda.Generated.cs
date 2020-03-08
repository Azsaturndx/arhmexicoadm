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
	public partial class Etapa_DemandaBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Etapa_Demanda", RowKind.New)]
        public void BuildNewEtapa_Demanda()
        {
            UpdateFieldValue("Es_CDE", 0);
            UpdateFieldValue("Es_CDEOAP", 0);
            UpdateFieldValue("Es_Cierre_Instruccion", 0);
            UpdateFieldValue("Es_Amparo", 0);
            UpdateFieldValue("Es_Laudo", 0);
            UpdateFieldValue("Es_No_Notificados", 0);
            UpdateFieldValue("Es_OAP", 0);
            UpdateFieldValue("Es_Otro", 0);
            UpdateFieldValue("Es_Parcial", 0);
            UpdateFieldValue("Es_Reservado", 0);
            UpdateFieldValue("Es_Testimonial", 0);
            UpdateFieldValue("Permitir_Concluir", 0);
        }
    }
}
