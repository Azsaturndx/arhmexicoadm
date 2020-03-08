using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using arhmexico.Handlers;

namespace arhmexico.Services
{
    public partial class ApplicationServices
    {
        public override bool ValidateBlobAccess(HttpContext context, BlobHandlerInfo handler, BlobAdapter ba, string val)
        {
            //* se usa código custom solo si el Override se ejecuta por los Handlers que necesitamos.
            if (handler.Key == "Administracion_GastoPicture"
                || handler.Key == "Administracion_GastoPicture2"
                || handler.Key == "Nombre_De_Handler_A_Usar")
            {
                //* Validar que se haya iniciado sesión y usamos una llave de validación propia de APP Framework de COT (?) No estoy seguro de que hace...
                var key = context.Request.Params["_validationKey"];
                if (((ba == null) || !ba.IsPublic) && (!context.User.Identity.IsAuthenticated && key != BlobAdapter.ValidationKey))
                    return !ApplicationServicesBase.AuthorizationIsSupported;
                else
                {
                    //* Grant ACCESS.
                    return true;
                }
            }
            //* Por último, si no se concuerda con los Handlers a utilizar se llama al código original del método ValidateBlobAccess, para estar más seguros.
            else return base.ValidateBlobAccess(context, handler, ba, val);
        }
    }
}
