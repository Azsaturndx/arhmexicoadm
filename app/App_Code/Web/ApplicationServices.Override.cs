using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Security;
using arhmexico.Services;
using arhmexico.Data;
using System.IO;

namespace arhmexico.Services
{
    public partial class ApplicationServices
    {
        public override Image UserPictureImage(MembershipUser user)
        {
            using (SqlText sql = new SqlText("SELECT gpu.Picture FROM Grid_Persona_Usuario_V gpu WHERE gpu.UserName = @UserName"))
            {
                sql.AssignParameter("@UserName",user.UserName);
                if (sql.Read())
                {
                    byte[] value = (byte[])sql["Picture"];
                    if (value != null)
                        return Image.FromStream(new MemoryStream(value));                        
                }
            }
            return base.UserPictureImage(user);
        }
    }
}