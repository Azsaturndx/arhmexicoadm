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
	public partial class Tipo_Actividad_RySBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Tipo_Actividad_RyS", RowKind.New)]
        public void BuildNewTipo_Actividad_RyS()
        {
            UpdateFieldValue("Es_Entrevista", 0);
            UpdateFieldValue("Es_Examen_Medico", 0);
            UpdateFieldValue("Es_Visita_Domiciliaria", 0);
            UpdateFieldValue("Contratante_Id", 0);
            UpdateFieldValue("Cliente_Id", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Lista_Resultado_Id", 0);
        }
    }
}
