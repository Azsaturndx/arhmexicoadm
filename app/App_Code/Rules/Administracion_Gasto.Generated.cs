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
	public partial class Administracion_GastoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Administracion_Gasto", RowKind.New)]
        public void BuildNewAdministracion_Gasto()
        {
            UpdateFieldValue("Direccion_Origen", "");
            UpdateFieldValue("Direccion_Destino", "");
            UpdateFieldValue("Ciudad_Origen_Id", 0);
            UpdateFieldValue("Ciudad_Destino_Id", 0);
            UpdateFieldValue("Viaje_Redondo", 0);
            UpdateFieldValue("Autorizado_Rechazado_Por_Id", "5C7568FD-6412-474E-A099-006FAD27CD02");
            UpdateFieldValue("Fecha_Autorizacion_Rechazo", 01/01/1900);
            UpdateFieldValue("Comentarios_Autorizacion_Rechazo", "");
            UpdateFieldValue("Creado_Por_Id", "5C7568FD-6412-474E-A099-006FAD27CD02");
            UpdateFieldValue("Fecha_Creacion", 01/01/1900);
            UpdateFieldValue("Actualizado_Por_Id", "5C7568FD-6412-474E-A099-006FAD27CD02");
            UpdateFieldValue("Fecha_Ultima_Actualizacion", 01/01/1900);
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Servicio_Id", 0);
            UpdateFieldValue("Notas", "");
            UpdateFieldValue("Latitud", 0);
            UpdateFieldValue("Longitud", 0);
            UpdateFieldValue("Pagado", false);
            UpdateFieldValue("Mostrar_Lista_Gastos_Frecuentes", 0);
            UpdateFieldValue("Mostrar_Mapa", 0);
        }
        
        [ControllerAction("Administracion_Gasto", "Insert", ActionPhase.Before)]
        [ControllerAction("Administracion_Gasto", "Update", ActionPhase.Before)]
        public void AssignFieldValuesToAdministracion_Gasto(
                    int? administracion_Gasto_Id, 
                    int? contratado_Id, 
                    int? tipo_Gasto_Id, 
                    string tipo_Gasto_Tipo_Gasto, 
                    bool? es_Otro, 
                    bool? es_Gasolina, 
                    decimal? monto_Gasto, 
                    DateTime? fecha_Gasto, 
                    string direccion_Origen, 
                    string direccion_Destino, 
                    int? ciudad_Origen_Id, 
                    string ciudad_Origen, 
                    int? ciudad_Destino_Id, 
                    string ciudad_Destino, 
                    decimal? kilometraje, 
                    bool? viaje_Redondo, 
                    int? estatus_Gasto_Id, 
                    string estatus_Gasto_Estatus_Gasto, 
                    System.Guid? autorizado_Rechazado_Por_Id, 
                    DateTime? fecha_Autorizacion_Rechazo, 
                    string comentarios_Autorizacion_Rechazo, 
                    string transaccion_Id, 
                    System.Guid? creado_Por_Id, 
                    string cpUserName, 
                    DateTime? fecha_Creacion, 
                    System.Guid? actualizado_Por_Id, 
                    string apUserName, 
                    DateTime? fecha_Ultima_Actualizacion, 
                    int? estatus_Registro_Id, 
                    string estatus_Registro_Estatus_Registro, 
                    string persona_Nombre, 
                    int? servicio_Id, 
                    string servicio, 
                    int? gastos_Frecuentes_Id, 
                    decimal? latitud, 
                    decimal? longitud, 
                    string pictureFileName, 
                    string pictureContentType, 
                    int? pictureLength, 
                    bool? pagado, 
                    DateTime? fecha_Pago, 
                    DateTime? fecha_Confirmacion_Pago, 
                    System.Guid? pago_Confirmado_Por_Id, 
                    string pcpUserName, 
                    int? sociedad_Id, 
                    int? sociedad_Cuadro_Accionario_Id, 
                    int? proveedor_Id, 
                    int? proveedor_Arrendamiento_Id, 
                    int? mes_Gasto_Id, 
                    System.Guid? solicitado_Por_Id, 
                    DateTime? fecha_Solicitud, 
                    string notas_Solicitud, 
                    DateTime? fecha_Vencimiento, 
                    string picture2FileName, 
                    string picture2ContentType, 
                    int? picture2Length, 
                    decimal? montoGastoAutorizado, 
                    bool? mostrar_Lista_Gastos_Frecuentes, 
                    string gastos_Frecuentes, 
                    bool? mostrar_Mapa, 
                    int? servicio_Hospedaje_Id, 
                    int? otro_Id, 
                    string otros_Etiqueta, 
                    int? terrestre_Id, 
                    string terrestre_Etiqueta, 
                    string servicio_Hospedaje_Etiqueta, 
                    int? servicio_Vuelo_Id, 
                    string servicio_Vuelo_Etiqueta, 
                    int? servicio_Gasolina_Id, 
                    string servicio_Gasolina_Etiqueta, 
                    int? servicio_Alimentos_Id, 
                    string servicio_Alimentos_Etiqueta, 
                    int? servicio_Terrestre_Id, 
                    string servicio_Terrestre_Etiqueta, 
                    int? servicio_Otros_Id, 
                    string servicio_Otros_Etiqueta, 
                    bool? es_De_Hospedaje, 
                    bool? es_De_Alimentos, 
                    bool? es_Aerolinea, 
                    bool? es_Transporte_Terrestre, 
                    bool? significa_Pendiente, 
                    bool? significa_Autorizado, 
                    bool? significa_Rechazado, 
                    string autorizado_Rechazado_Por, 
                    string mes_Mes, 
                    string solicitado_Por, 
                    bool? es_Periodico, 
                    bool? aplica_Para_Contratado, 
                    int? medio_Pago_Id, 
                    string medio_Pago, 
                    string solicitud_Gasto_Key, 
                    decimal? monto_Gasto_Autorizado, 
                    int? tipo_Gasto_Terrestre_Id, 
                    string tipo_Gasto_Terrestre, 
                    int? contratante_Id, 
                    string contratante, 
                    int? cliente_Id, 
                    string cliente, 
                    bool? es_Viatico, 
                    string nombre_Viatico, 
                    string numero_Cuenta, 
                    string clabe, 
                    string a_Nombre_Cheque, 
                    int? banco_Id, 
                    string banco, 
                    int? motivo_Pago_Id, 
                    string motivo_Pago, 
                    bool? es_Urgente, 
                    int? tipo_Comprobante_Id, 
                    string tipo_Comprobante, 
                    bool? es_Transferencia, 
                    bool? es_Cheque, 
                    bool? es_Efectivo, 
                    string leyenda_Urgente)
        {
            var Aplica_Para_ContratadoFieldValue = SelectFieldValueObject("Aplica_Para_Contratado");
            var Aplica_Para_ContratadoCodeValue = 1;
            if (Aplica_Para_ContratadoFieldValue == null)
            	AddFieldValue("Aplica_Para_Contratado", Aplica_Para_ContratadoCodeValue);
            else
            {
                Aplica_Para_ContratadoFieldValue.NewValue = Aplica_Para_ContratadoCodeValue;
                Aplica_Para_ContratadoFieldValue.Modified = true;
                Aplica_Para_ContratadoFieldValue.ReadOnly = false;
            }
        }
    }
}
