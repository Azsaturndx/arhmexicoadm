using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using SelectPdf;
using arhmexico.Data;
using arhmexico.Models;


namespace arhmexico.Rules
{
    public partial class Contratado_Solicitud_DocumentoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        [Rule("r104")]
        public void r104Implementation(Contratado_Solicitud_DocumentoModel instance)
        {
            // This is the placeholder for method implementation.
            int tipoDocumentoId = Convert.ToInt32(instance.Definicion_Solicitud_Documento_Id);
            //string destinatario;
            int contratadoId = Convert.ToInt32(instance.Contratado_Id);
            int tipoOperacionId = 8; //Solicitud
            bool resultado;
            int mensajeSistemaId;
            string mensajeSistema;
            /*
            if(instance.Destinatario.ToString() != null)
            {
                destinatario = instance.Destinatario.ToString();
            }
            */
            SharedBusinessRules sr = new SharedBusinessRules();

            resultado = sr.AdministrarSolicitudDocumento(tipoOperacionId, tipoDocumentoId, contratadoId, out mensajeSistema, out mensajeSistemaId);

            if (resultado)
            {
                Result.ShowAlert("Solicitud Creada Exitosamente.");
            }//if(resultado)
            else
            {
                Result.ShowAlert(mensajeSistema);
            }//else if(resultado)


        }
    }
    
}
   


