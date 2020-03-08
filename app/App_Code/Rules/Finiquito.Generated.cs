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
	public partial class FiniquitoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Finiquito", RowKind.New)]
        public void BuildNewFiniquito()
        {
            UpdateFieldValue("Tipo_Finiquito_Id", 0);
            UpdateFieldValue("Puesto_Contratado_Finiquitar_Id", 0);
            UpdateFieldValue("Domicilio_Contratado_Finiquitar_Id", 0);
            UpdateFieldValue("Contacto_Contratado_Finiquitar_Id", 0);
            UpdateFieldValue("Estatus_Finiquito_Id", 0);
            UpdateFieldValue("Finiquito_En_Efectivo", 0);
            UpdateFieldValue("Banco_SA_Id", 0);
            UpdateFieldValue("Banco_Sindicato_Id", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Ciudad_Convenio_Id", 0);
            UpdateFieldValue("Cliente_Id", 0);
            UpdateFieldValue("Contratante_Id", 0);
        }
    }
}
