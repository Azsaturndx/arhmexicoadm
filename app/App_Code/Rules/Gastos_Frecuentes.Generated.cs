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
	public partial class Gastos_FrecuentesBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Gastos_Frecuentes", RowKind.New)]
        public void BuildNewGastos_Frecuentes()
        {
            UpdateFieldValue("Contratado_Id", 0);
            UpdateFieldValue("Tipo_Gasto_Id", 0);
            UpdateFieldValue("Ciudad_Origen_Id", 0);
            UpdateFieldValue("Ciudad_Destino_Id", 0);
            UpdateFieldValue("Servicio_Hospedaje_Id", 0);
            UpdateFieldValue("Servicio_Alimentos_Id", 0);
            UpdateFieldValue("Servicio_Transportacion_Id", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Monto_Historico", 0);
        }
    }
}
