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
	public partial class Herramienta_Trabajo_AsignadaBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Herramienta_Trabajo_Asignada", RowKind.New)]
        public void BuildNewHerramienta_Trabajo_Asignada()
        {
            UpdateFieldValue("Contratado_Id", 0);
            UpdateFieldValue("Marca_Id", 0);
            UpdateFieldValue("Color_Id", 0);
            UpdateFieldValue("Cliente_Id", 0);
            UpdateFieldValue("Anio_Id", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Banco_Id", 0);
            UpdateFieldValue("Compania_Telefonica_Id", 0);
        }
    }
}
