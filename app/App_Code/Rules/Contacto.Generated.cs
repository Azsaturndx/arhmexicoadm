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
	public partial class ContactoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Contacto", RowKind.New)]
        public void BuildNewContacto()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
