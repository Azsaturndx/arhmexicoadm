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
	public partial class Tipo_Finiquito_DocumentoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Tipo_Finiquito_Documento", RowKind.New)]
        public void BuildNewTipo_Finiquito_Documento()
        {
            UpdateFieldValue("Es_Cheque_Impreso", 0);
            UpdateFieldValue("Es_Carta_Renuncia_ARH", 0);
            UpdateFieldValue("Es_Carta_Renuncia_Cliente", 0);
            UpdateFieldValue("Es_Renuncia_Como_Miembro_Sindicato", 0);
            UpdateFieldValue("Es_Carta_Finiquito_SA", 0);
            UpdateFieldValue("Es_Recibo_Sindicato", 0);
            UpdateFieldValue("Es_Convenio", 0);
            UpdateFieldValue("Es_Documento_Demanda", 0);
            UpdateFieldValue("Es_Documento_SA", 0);
            UpdateFieldValue("Es_Documento_Sindicato", 0);
        }
    }
}
