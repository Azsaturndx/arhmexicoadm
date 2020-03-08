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
	public partial class DemandaBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Demanda", RowKind.New)]
        public void BuildNewDemanda()
        {
            UpdateFieldValue("Ciudad_Contratado_Id", 0);
            UpdateFieldValue("Es_Demanda_Nueva", 0);
            UpdateFieldValue("Etapa_Demanda_Id", 0);
            UpdateFieldValue("Estatus_Demanda_Id", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Lugar_Audiencia_Id", 0);
            UpdateFieldValue("Monto_Demanda", 0);
            UpdateFieldValue("Finiquito_Id", 0);
            UpdateFieldValue("Monto_Convenio", 0);
            UpdateFieldValue("Salario_Demanda", 0);
            UpdateFieldValue("Salario_Caido", 0);
            UpdateFieldValue("Vacaciones", 0);
            UpdateFieldValue("Prima_Vacacional", 0);
            UpdateFieldValue("Prima_Antiguedad", 0);
            UpdateFieldValue("Aguinaldo", 0);
            UpdateFieldValue("Tiempo_Extra", 0);
            UpdateFieldValue("Fondo_Ahorro", 0);
            UpdateFieldValue("Utilidades", 0);
            UpdateFieldValue("Septimo_Dia", 0);
            UpdateFieldValue("Premio_De_Asistencia_Y_Puntualidad", 0);
            UpdateFieldValue("Pago_Dia_Festivo", 0);
            UpdateFieldValue("Otros", 0);
            UpdateFieldValue("Paga_Cliente", 0);
        }
    }
}
