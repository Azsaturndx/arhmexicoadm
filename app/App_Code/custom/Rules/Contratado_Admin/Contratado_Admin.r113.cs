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
	public partial class Contratado_AdminBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        /// <summary>This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS05".
        /// </summary>
        [Rule("r113")]
        public void r113Implementation(Contratado_AdminModel instance)
        {
            // This is the placeholder for method implementation.

            bool resultado;
            int tipoMovimientoPersonalId = 0;
            DateTime fechaMovimientoPersonal = Convert.ToDateTime("01/01/1900");
            int motivoMovimientoPersonalId = 0;
            int personaId = Convert.ToInt32(instance.Persona_Id);
            int contratadoId = Convert.ToInt32(instance.Contratado_Id);
            int contratanteEstructuraOrganizacionalId = Convert.ToInt32(instance.Contratante_Estructura_Organizacional_Id);
            int pagadoraId = 0;
            int contratantePuestoId = 0;
            int contratanteId = 0;
            int clienteId = 0;
            int contratanteNuevaEstructuraOrganizacionalId = 0;
            int pagadoraNuevaId = 0;
            int contratantePuestoNuevoId = 0;
            int contratanteNuevoId = 0;
            int clienteNuevoId = 0;

            DateTime fechaContratacion = Convert.ToDateTime("01/01/1900");
            DateTime fechaAntiguedad = Convert.ToDateTime("01/01/1900");
            int tipoEmpleadoId = 0;
            int tipoContratadoId = 0;
            int turnoLaboralId = 0;

            int mensajeSistemaId;
            string mensajeSistema;

            if (instance.Tipo_Movimiento_Personal_Id != null)
            {
                tipoMovimientoPersonalId = Convert.ToInt32(instance.Tipo_Movimiento_Personal_Id);

                if (instance.Fecha_Movimiento_Personal != null)
                    fechaMovimientoPersonal = Convert.ToDateTime(instance.Fecha_Movimiento_Personal);

                if (instance.Motivo_Movimiento_Personal_Id != null)
                {
                    motivoMovimientoPersonalId = Convert.ToInt32(instance.Motivo_Movimiento_Personal_Id);

                    if (instance.Pagadora_Id != null)
                        pagadoraId = Convert.ToInt32(instance.Pagadora_Id);

                    if (instance.Contratante_Puesto_Id != null)
                        contratantePuestoId = Convert.ToInt32(instance.Contratante_Puesto_Id);

                    if (instance.Contratante_Id != null)
                        contratanteId = Convert.ToInt32(instance.Contratante_Id);

                    if (instance.Cliente_Id != null)
                        clienteId = Convert.ToInt32(instance.Cliente_Id);

                    if (instance.Nueva_Estructura_Organizacional_Id != null)
                        contratanteNuevaEstructuraOrganizacionalId = Convert.ToInt32(instance.Nueva_Estructura_Organizacional_Id);

                    if (instance.Nueva_Pagadora_Id != null)
                        pagadoraNuevaId = Convert.ToInt32(instance.Nueva_Pagadora_Id);

                    if (instance.Nuevo_Contratante_Puesto_Id != null)
                        contratantePuestoNuevoId = Convert.ToInt32(instance.Nuevo_Contratante_Puesto_Id);

                    if (instance.Nuevo_Contratante_Id != null)
                        contratanteNuevoId = Convert.ToInt32(instance.Nuevo_Contratante_Id);

                    if (instance.Nuevo_Cliente_Id != null)
                        clienteNuevoId = Convert.ToInt32(instance.Nuevo_Cliente_Id);

                    if (instance.Fecha_Contratacion != null)
                        fechaContratacion = Convert.ToDateTime(instance.Fecha_Contratacion);

                    if (instance.Fecha_Antiguedad != null)
                        fechaAntiguedad = Convert.ToDateTime(instance.Fecha_Antiguedad);

                    if (instance.Tipo_Empleado_Id != null)
                        tipoEmpleadoId = Convert.ToInt32(instance.Tipo_Empleado_Id);

                    if (instance.Tipo_Contratado_Id != null)
                        tipoContratadoId = Convert.ToInt32(instance.Tipo_Contratado_Id);

                    if (instance.Turno_Laboral_Id != null)
                        turnoLaboralId = Convert.ToInt32(instance.Turno_Laboral_Id);

                    SharedBusinessRules sr = new SharedBusinessRules();

                    resultado = sr.AdministrarMovimientoPersonal(tipoMovimientoPersonalId, personaId, contratadoId, fechaMovimientoPersonal, motivoMovimientoPersonalId, contratanteEstructuraOrganizacionalId, pagadoraId, contratantePuestoId, contratanteId, clienteId, contratanteNuevaEstructuraOrganizacionalId, pagadoraNuevaId, contratantePuestoNuevoId, contratanteNuevoId, clienteNuevoId, fechaContratacion, fechaAntiguedad, tipoContratadoId, tipoEmpleadoId, turnoLaboralId, out mensajeSistemaId, out mensajeSistema);

                    if (resultado)
                        Result.ShowAlert("Se ha actualizado con éxito al contratado.");
                    else
                        Result.ShowAlert(mensajeSistema);
                }
                else
                    Result.ShowAlert("Debe seleccionar un motivo de movimiento de personal.");

            }
            else
                Result.ShowAlert("Debe seleccionar un tipo de movimiento de personal.");
        }
    }
}
