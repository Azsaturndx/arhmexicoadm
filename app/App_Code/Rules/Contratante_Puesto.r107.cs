using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using arhmexico.Data;
using arhmexico.Models;

namespace arhmexico.Rules
{
	public partial class Contratante_PuestoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS100".
        /// </summary>
        [Rule("r107")]
        public void r107Implementation(Contratante_PuestoModel instance)
        {
            // This is the placeholder for method implementation.
            bool resultadoEjecucionSP;
            string mensajeDeSistema = "";
            int mensajeSistemaId = 0;

            //    //LLamar al procedimiento sp
            resultadoEjecucionSP = adminstrarPuestoVacante(
                  instance.Contratante_Puesto_Id
                 ,instance.Contratado_Id                
                 , out mensajeSistemaId
                 , out mensajeDeSistema
             ); // END resultadoEjecucionSP = spAdministrarCapturaDeDimensiones(

            if (resultadoEjecucionSP == false || (resultadoEjecucionSP == true && mensajeSistemaId != 1))
            {
                RegistrarEnBitacora(0, mensajeSistemaId, "", mensajeDeSistema);
                //Result.ShowMessage(mensajeDeSistema);//Muestra a pantalla el error obtenido
                Result.ExecuteOnClient("alertify.error('" + mensajeDeSistema + "')");
                //Agregado el 10Junio20191030
                Result.Continue();
            }//END if(!resultadoEjecucionSP)
            else
            {

                Result.ExecuteOnClient("alertify.success('" + mensajeDeSistema + "')");
                //Agregado el 10Junio20191030
                Result.Continue();
            }
        }
    }
}
