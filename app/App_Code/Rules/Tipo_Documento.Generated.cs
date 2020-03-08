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
	public partial class Tipo_DocumentoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Tipo_Documento", RowKind.New)]
        public void BuildNewTipo_Documento()
        {
            UpdateFieldValue("Es_De_Fiscal", 0);
            UpdateFieldValue("Es_Documento_Permanente", 0);
            UpdateFieldValue("Es_Documento_De_Contratacion_Cliente", 0);
            UpdateFieldValue("Es_De_Registro", 0);
            UpdateFieldValue("Es_De_Contratacion_Aspirante", 0);
            UpdateFieldValue("Es_De_Finiquito", 0);
            UpdateFieldValue("Es_De_Laboral", 0);
            UpdateFieldValue("Es_De_Persona", 0);
            UpdateFieldValue("Es_De_Contratado", 0);
            UpdateFieldValue("Es_De_Candidato", 0);
            UpdateFieldValue("Es_Perfil_Rys", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Cliente_Id", 0);
            UpdateFieldValue("Es_Cheque_Impreso", 0);
            UpdateFieldValue("Es_Carta_Renuncia_Arh", 0);
            UpdateFieldValue("Es_Carta_Renuncia_Cliente", 0);
            UpdateFieldValue("Es_Renuncia_Como_Miembro_Sindicato", 0);
            UpdateFieldValue("Es_Carta_Finiquito_SA", 0);
            UpdateFieldValue("Es_Recibo_Sindicato", 0);
            UpdateFieldValue("Es_Convenio", 0);
            UpdateFieldValue("Es_Documento_Demanda", 0);
            UpdateFieldValue("Es_Documento_SA", 0);
            UpdateFieldValue("Es_Documento_Sindicato", 0);
            UpdateFieldValue("Es_Pagadora_Documento", 0);
            UpdateFieldValue("Es_Cliente_Documento", 0);
            UpdateFieldValue("Es_Receptora_Documento", 0);
            UpdateFieldValue("Es_Pagadora_Cuadro_Accionario_Documento", 0);
            UpdateFieldValue("Es_Receptora_Cuadro_Accionario_Documento", 0);
            UpdateFieldValue("Es_Obligatorio_Para_Solicitar_Prestamo", 0);
            UpdateFieldValue("Es_Formulario_Para_Solicitar_Prestamo", 0);
        }
    }
}
