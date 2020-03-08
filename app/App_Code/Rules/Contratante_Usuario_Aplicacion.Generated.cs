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
	public partial class Contratante_Usuario_AplicacionBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Contratante_Usuario_Aplicacion", RowKind.New)]
        public void BuildNewContratante_Usuario_Aplicacion()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
