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
	public partial class Lugar_AudienciaBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Lugar_Audiencia", RowKind.New)]
        public void BuildNewLugar_Audiencia()
        {
            UpdateFieldValue("Ciudad_Audiencia_Id", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
