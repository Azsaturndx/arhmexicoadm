using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Web;
using System.Web.Security;
using arhmexico.Data;
using arhmexico.Services;

namespace arhmexico.Security
{
    public partial class MembershipBusinessRules
    {
        public override void AccessControlValidation()
        {
            if (!(Context.User.Identity.IsAuthenticated))
                throw new Exception("Not Authorized.");
            if (!(UserIsInRole("Administrators", "ArhAdmin")) && !(((Request != null) && (Request.View == "lookup"))))
                throw new Exception("Not Authorized.");
        }
    }
}

//public class MembershipBusinessRules
//{
//    public MembershipBusinessRules()
//    {
//        //
//        // TODO: Add constructor logic here
//        //
//    }
//}