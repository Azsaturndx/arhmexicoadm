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
	public partial class Institucion_EducativaBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Institucion_Educativa", RowKind.New)]
        public void BuildNewInstitucion_Educativa()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
