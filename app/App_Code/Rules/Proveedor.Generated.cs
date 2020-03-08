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
	public partial class ProveedorBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Proveedor", RowKind.New)]
        public void BuildNewProveedor()
        {
            UpdateFieldValue("Tipo_Proveedor_Id", 0);
            UpdateFieldValue("Trabaja_Lunes", 0);
            UpdateFieldValue("Trabaja_Martes", 0);
            UpdateFieldValue("Trabaja_Miercoles", 0);
            UpdateFieldValue("Trabaja_Jueves", 0);
            UpdateFieldValue("Trabaja_Viernes", 0);
            UpdateFieldValue("Trabaja_Sabado", 0);
            UpdateFieldValue("Trabaja_Domingo", 0);
            UpdateFieldValue("Contratante_Id", 0);
            UpdateFieldValue("Cliente_Id", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
