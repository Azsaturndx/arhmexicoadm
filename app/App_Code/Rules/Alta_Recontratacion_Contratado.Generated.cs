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
	public partial class Alta_Recontratacion_ContratadoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Alta_Recontratacion_Contratado", RowKind.New)]
        public void BuildNewAlta_Recontratacion_Contratado()
        {
            UpdateFieldValue("Fecha_Contratacion", SelectFieldValue("Context_Fecha_Contratacion"));
            UpdateFieldValue("Fecha_Antiguedad", SelectFieldValue("Context_Fecha_Antiguedad"));
            UpdateFieldValue("Tipo_Contratado_Id", SelectFieldValue("Context_Tipo_Contratado_Id"));
            UpdateFieldValue("Tipo_Empleado_Id", SelectFieldValue("Context_Tipo_Empleado_Id"));
            UpdateFieldValue("Turno_Laboral_Id", SelectFieldValue("Context_Turno_Laboral_Id"));
            UpdateFieldValue("Tipo_Contratado", SelectFieldValue("Context_Tipo_Contratado_Tipo_Contratado"));
        }
    }
}
