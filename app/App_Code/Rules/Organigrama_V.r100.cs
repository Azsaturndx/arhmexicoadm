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
	public partial class Organigrama_VBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(Organigrama_VModel instance)
        {
            // This is the placeholder for method implementation.
            /*Declaración de Variables para SP*/
            int organigramaPuestoId = 0;
            int organigramaEstructuraId = 0;



            int tipoOrganigramaId = instance.Tipo_Organigrama_Id ?? 0;
            int organigramaClienteId = instance.Organigrama_Cliente_Id ?? 0;
            int organigramaContratanteId = instance.Organigrama_Contratante_Id ?? 0;
            int nivel = instance.Nivel ?? 0;


            if (organigramaContratanteId == 0) {
                organigramaPuestoId = instance.Organigrama_Puesto_Id_1 ?? 0;
                organigramaEstructuraId = instance.Organigrama_Estructura_Id_1 ?? 0;
            }

            else {
                organigramaPuestoId = instance.Organigrama_Puesto_Id ?? 0;
                organigramaEstructuraId = instance.Organigrama_Estructura_Id ?? 0;
            }

            /*Declaración de Variables de uso en ejecución*/
            bool resultadoEjecucionSP;
            string mensajeDeSistema = "";
            int mensajeSistemaId = 0;
            string organigramaJson = "";
            
            //    //LLamar al procedimiento sp
            resultadoEjecucionSP = generarJsonOrganizacionalPorNivel(
                  organigramaEstructuraId//ContratanteEstructuraId
                 , organigramaPuestoId// ContratantePuestoId
                 , nivel //Nivel
                 , tipoOrganigramaId//TipoOrganigrama
                 , organigramaClienteId //Cliente Id
                 , organigramaContratanteId //Contratante Id
                 , out mensajeDeSistema
                 , out mensajeSistemaId
                 , out organigramaJson
             ); // END resultadoEjecucionSP = spAdministrarCapturaDeDimensiones(

            if (resultadoEjecucionSP == false || (resultadoEjecucionSP == true && mensajeSistemaId != 1))
            {
                RegistrarEnBitacora(0, mensajeSistemaId, "", mensajeDeSistema);
                //Result.ShowMessage(mensajeDeSistema);//Muestra a pantalla el error obtenido
                Result.ExecuteOnClient("alertify.error('" + mensajeDeSistema + "')");
            }//END if(!resultadoEjecucionSP)
            else
            {
                Result.ExecuteOnClient("window.myFunction(" + organigramaJson + ");");//Ejecuta sentecia js para mostrar Organigrama
            }   
        }//public void r100Implementation(Organigrama_VModel instance)
    }//public partial class Organigrama_VBusinessRules : arhmexico.Rules.SharedBusinessRules
}
