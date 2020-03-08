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
	public partial class Administracion_Gasto_ContratanteBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Administracion_Gasto_Contratante", RowKind.New)]
        public void BuildNewAdministracion_Gasto_Contratante()
        {
            UpdateFieldValue("Direccion_Origen", "");
            UpdateFieldValue("Direccion_Destino", "");
            UpdateFieldValue("Ciudad_Origen_Id", 0);
            UpdateFieldValue("Ciudad_Destino_Id", 0);
            UpdateFieldValue("Viaje_Redondo", 0);
            UpdateFieldValue("Autorizado_Rechazado_Por_Id", "5C7568FD-6412-474E-A099-006FAD27CD02");
            UpdateFieldValue("Fecha_Autorizacion_Rechazo", 01/01/1900);
            UpdateFieldValue("Comentarios_Autorizacion_Rechazo", "");
            UpdateFieldValue("Creado_Por_Id", "5C7568FD-6412-474E-A099-006FAD27CD02");
            UpdateFieldValue("Fecha_Creacion", 01/01/1900);
            UpdateFieldValue("Actualizado_Por_Id", "5C7568FD-6412-474E-A099-006FAD27CD02");
            UpdateFieldValue("Fecha_Ultima_Actualizacion", 01/01/1900);
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Servicio_Id", 0);
            UpdateFieldValue("Notas", "");
            UpdateFieldValue("Latitud", 0);
            UpdateFieldValue("Longitud", 0);
            UpdateFieldValue("Pagado", false);
            UpdateFieldValue("Mostrar_Lista_Gastos_Frecuentes", 0);
            UpdateFieldValue("Mostrar_Mapa", 0);
        }
    }
}
