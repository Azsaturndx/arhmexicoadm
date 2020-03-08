using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using arhmexico.Data;
using arhmexico.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace arhmexico.Rules
{
	public partial class Administracion_GastoBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "EXECCS01".
        /// </summary>
        [Rule("r103")]
        public void r103Implementation(Administracion_GastoModel instance)
        {
            // This is the placeholder for method implementation.
            //PreventDefault();

            string conStr = ConfigurationManager.ConnectionStrings["arhmexico"].ToString();
            int ValorServicioId;
            int CiudadOrigenId;
            int CiudadDestinoId;
            int EstatusRegistroId;
            int EstatusGastoId;
            string DireccionOrigen;
            string DireccionDestino;
            string Comentarios;
            string NotasPago;
            int GastosFrecuentesId;
            int administracionGastoId;
            int esGastoConAutorizacion;
            bool pagado = false;
            int estatusRegistroId = 1;
            bool mostrarListaGastosFrecuentes = false;
            string mensajeSistema = "";

            int motivoPagoId = 0;
            int medioPagoId = 0;
            int tipoComprobanteId = 0;
            int bancoId = 0;

            string numeroCuenta = "";
            string clabe = "";
            string aNombreCheque = "";
            bool esUrgente = false;

            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Administrar_Gasto_Contratado", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandTimeout = 60 * 10;

                    ValorServicioId = Convert.ToInt32(instance.Servicio_Id);
                    if (ValorServicioId == Int32.MinValue)
                        ValorServicioId = 0;                    

                    DireccionOrigen = instance.Direccion_Origen;
                    if (DireccionOrigen == null) 
                        DireccionOrigen = "Sin Dirección Origen";

                    DireccionDestino = instance.Direccion_Destino;
                    if (DireccionDestino == null) 
                        DireccionDestino = "Sin Dirección Destino";

                    Comentarios = instance.Comentarios_Autorizacion_Rechazo;
                    if (Comentarios == null) 
                        Comentarios = "Sin Comentarios";

                    CiudadOrigenId = Convert.ToInt32(instance.Ciudad_Origen_Id);
                    if (CiudadOrigenId == Int32.MinValue)
                        CiudadOrigenId = 0;

                    CiudadDestinoId = Convert.ToInt32(instance.Ciudad_Destino_Id);
                    if (CiudadDestinoId == Int32.MinValue)
                        CiudadDestinoId = 0;  

                    EstatusGastoId = Convert.ToInt32(instance.Estatus_Gasto_Id);
                    if (EstatusGastoId == Int32.MinValue)
                        EstatusGastoId = 5;  // 5 = Pendiente

                    if (instance.Notas_Pago != null)
                        NotasPago = instance.Notas_Pago;
                    else
                        NotasPago = "";

                    if (instance.Gastos_Frecuentes_Id != null)
                        GastosFrecuentesId = Convert.ToInt32(instance.Gastos_Frecuentes_Id);
                    else
                        GastosFrecuentesId = 0;

                    if (instance.Motivo_Pago_Id != null)
                        motivoPagoId = Convert.ToInt32(instance.Motivo_Pago_Id);

                    if (instance.Medio_Pago_Id != null)
                        medioPagoId = Convert.ToInt32(instance.Medio_Pago_Id);

                    if (instance.Tipo_Comprobante_Id != null)
                        tipoComprobanteId = Convert.ToInt32(instance.Tipo_Comprobante_Id);

                    if (instance.Banco_Id != null)
                        bancoId = Convert.ToInt32(instance.Banco_Id);

                    if (instance.Numero_Cuenta != null)
                        numeroCuenta = instance.Numero_Cuenta.ToString();

                    if (instance.Clabe != null)
                        clabe = instance.Clabe.ToString();

                    if (instance.A_Nombre_Cheque != null)
                        aNombreCheque = instance.A_Nombre_Cheque.ToString();

                    if (instance.Es_Urgente != null)
                        esUrgente = Convert.ToBoolean(instance.Es_Urgente);

                    cmd.Parameters.AddWithValue("@Tipo_Operacion_Id", 1);// ES CREACIÓN NUEVO REGISTRO
                    cmd.Parameters.AddWithValue("@Administracion_Gasto_Id", 0);
                    cmd.Parameters.AddWithValue("@Contratado_Id", instance.Contratado_Id);
                    cmd.Parameters.AddWithValue("@Tipo_Gasto_Id", instance.Tipo_Gasto_Id);
                    cmd.Parameters.AddWithValue("@Monto_Gasto", instance.Monto_Gasto);
                    cmd.Parameters.AddWithValue("@Fecha_Gasto", instance.Fecha_Gasto);
                    cmd.Parameters.AddWithValue("@Latitud", instance.Latitud);
                    cmd.Parameters.AddWithValue("@Longitud", instance.Longitud);
                    cmd.Parameters.AddWithValue("@Direccion_Origen", DireccionOrigen); //
                    cmd.Parameters.AddWithValue("@Direccion_Destino", DireccionDestino); //
                    cmd.Parameters.AddWithValue("@Ciudad_Origen_Id", CiudadOrigenId);
                    cmd.Parameters.AddWithValue("@Ciudad_Destino_Id", CiudadDestinoId);
                    cmd.Parameters.AddWithValue("@Kilometraje", instance.Kilometraje);
                    cmd.Parameters.AddWithValue("@Viaje_Redondo", instance.Viaje_Redondo);
                    cmd.Parameters.AddWithValue("@Estatus_Gasto_Id", EstatusGastoId); //
                    cmd.Parameters.AddWithValue("@Autorizado_Rechazado_Por_Id", UserId); //
                    cmd.Parameters.AddWithValue("@Fecha_Autorizacion_Rechazo", instance.Fecha_Autorizacion_Rechazo);
                    cmd.Parameters.AddWithValue("@Comentarios_Autorizacion_Rechazo", Comentarios); //
                    //PAGO
                    cmd.Parameters.AddWithValue("@Pagado", pagado); //
                    cmd.Parameters.AddWithValue("@Fecha_Pago", DBNull.Value); //
                    cmd.Parameters.AddWithValue("@Notas_Pago", NotasPago); //
                    cmd.Parameters.AddWithValue("@Fecha_Confirmacion_Pago", DBNull.Value); //
                    cmd.Parameters.AddWithValue("@Pago_Confirmado_Por_Id", UserId); //cmd.Parameters.AddWithValue("@Pago_Confirmado_Por_Id", instance.Pago_Confirmado_Por_Id);
                    //
                    cmd.Parameters.AddWithValue("@Estatus_Registro_Id", estatusRegistroId); //
                    //cmd.Parameters.AddWithValue("@Servicio_Id", instance.Servicio_Id);
                    cmd.Parameters.AddWithValue("@Servicio_Id", ValorServicioId);
                    cmd.Parameters.AddWithValue("@Mostrar_Lista_Gastos_Frecuentes", mostrarListaGastosFrecuentes);
                    cmd.Parameters.AddWithValue("@Gastos_Frecuentes_Id", GastosFrecuentesId);
                    cmd.Parameters.AddWithValue("@Es_Gasto_Con_Autorizacion", 0);

                    cmd.Parameters.AddWithValue("@Motivo_Pago_Id", motivoPagoId);
                    cmd.Parameters.AddWithValue("@Tipo_Comprobante_Id", tipoComprobanteId);
                    cmd.Parameters.AddWithValue("@Medio_Pago_Id", medioPagoId);
                    cmd.Parameters.AddWithValue("@Banco_Id", bancoId);
                    cmd.Parameters.AddWithValue("@Numero_Cuenta", numeroCuenta);
                    cmd.Parameters.AddWithValue("@Clabe", clabe);
                    cmd.Parameters.AddWithValue("@Nombre_Cheque", aNombreCheque);
                    cmd.Parameters.AddWithValue("@Es_Urgente", esUrgente);

                    /*Parametros de sistema**/
                    cmd.Parameters.AddWithValue("@Creado_Por_Id", UserId);
                    cmd.Parameters.AddWithValue("@Transaccion_Id", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fijar_Bitacora", 1);
                    cmd.Parameters.AddWithValue("@Mostrar_Tablas_Sistema", 0);
                    //cmd.Parameters.Add("@Mensaje_Sistema_Id", 1);//.Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@Mensaje_Sistema_Id", 1);
                    cmd.Parameters.AddWithValue("@Simular", 0);
                    cmd.Parameters.AddWithValue("@Trace", "");//.Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@Debug", 0);

                    cmd.Parameters["@Administracion_Gasto_Id"].Direction = ParameterDirection.Output;
                    cmd.Parameters["@Es_Gasto_Con_Autorizacion"].Direction = ParameterDirection.Output;
                    cmd.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    cmd.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    cmd.Parameters["@Administracion_Gasto_Id"].Size = 4;
                    cmd.Parameters["@Es_Gasto_Con_Autorizacion"].Size = 4;
                    cmd.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    cmd.Parameters["@Trace"].Size = 8000;

                    con.Open();
                    cmd.ExecuteNonQuery();

                    //con.Close();

                    

                    if (cmd.Parameters["@Mensaje_Sistema_Id"].Value.ToString() != "1")
                    {
                        mensajeSistema = SqlText.ExecuteScalar("SELECT Mensaje_Amigable_Usuario FROM [dbo].[Obtener_Mensaje_Sistema_V] WHERE Mensaje_Sistema_Id=" + cmd.Parameters["@Mensaje_Sistema_Id"].Value.ToString()).ToString();
                        Result.ShowAlert(mensajeSistema);
                    }//if (spSql.Parameters["RetVal"].Value.ToString() != "1")
                    else
                    {
                        administracionGastoId = Convert.ToInt32(cmd.Parameters["@Administracion_Gasto_Id"].Value.ToString());
                        esGastoConAutorizacion = Convert.ToInt32(cmd.Parameters["@Es_Gasto_Con_Autorizacion"].Value.ToString());
                        instance.Administracion_Gasto_Id = administracionGastoId;

                        if(esGastoConAutorizacion == 1)
                        {
                            //En caso de que se haya creado con éxito, enviar la solicitud a los autorizadores
                            using (SqlConnection con2 = new SqlConnection(conStr))
                            {
                                using (SqlCommand cmd2 = new SqlCommand("sp_Administrar_Solicitud_Gasto", con))
                                {
                                    cmd2.CommandType = CommandType.StoredProcedure;

                                    cmd2.CommandTimeout = 60 * 10;

                                    cmd2.Parameters.AddWithValue("@Tipo_Operacion_Id", 1);// ES ALTA (Para enviar el correo a los autorizadores)
                                    cmd2.Parameters.AddWithValue("@Administracion_Gasto_Id", administracionGastoId);
                                    cmd2.Parameters.AddWithValue("@Solicitud_Gasto_Key", DBNull.Value);
                                    cmd2.Parameters.AddWithValue("@Fecha_Solicitud", DBNull.Value);
                                    cmd2.Parameters.AddWithValue("@Estatus_Solicitud_Id", 0);
                                    cmd2.Parameters.AddWithValue("@Fecha_Autorizacion_Rechazo", DBNull.Value);
                                    cmd2.Parameters.AddWithValue("@Autorizado_Rechazado_Por_Id", UserId);
                                    cmd2.Parameters.AddWithValue("@Notas_Autorizacion_Rechazo", DBNull.Value);
                                    cmd2.Parameters.AddWithValue("@Monto_Gasto_Autorizado", DBNull.Value);
                                    cmd2.Parameters.AddWithValue("@HTML", DBNull.Value);
                                    cmd2.Parameters.AddWithValue("@Mensaje_Sistema_Id", 1);
                                    cmd2.Parameters.AddWithValue("@Debug", 0);

                                    cmd2.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;

                                    cmd2.Parameters["@Mensaje_Sistema_Id"].Size = 4;

                                    con2.Open();
                                    cmd2.ExecuteNonQuery();

                                    con2.Close();

                                    if (cmd2.Parameters["@Mensaje_Sistema_Id"].Value.ToString() != "1")
                                    {
                                        mensajeSistema = SqlText.ExecuteScalar("SELECT Mensaje_Amigable_Usuario FROM [dbo].[Obtener_Mensaje_Sistema_V] WHERE Mensaje_Sistema_Id=" + cmd2.Parameters["@Mensaje_Sistema_Id"].Value.ToString()).ToString();
                                        Result.ShowAlert(mensajeSistema + " así que no se podrá enviar la solicitud a ningún autorizador.");
                                        Result.Refresh();
                                        Result.RefreshChildren();
                                        Result.Continue();
                                    }//if (spSql.Parameters["RetVal"].Value.ToString() != "1")
                                    else
                                    {
                                        Result.ShowAlert("Guardado con éxito");
                                        Result.Refresh();
                                        /*Result.RefreshChildren();
                                        Result.Continue();*/

                                    }//else if (spSql.Parameters["RetVal"].Value.ToString() != "1")

                                }//using (SqlCommand cmd = new SqlCommand("sp_Administrar_Solicitud_Gasto", con))

                            }//using (SqlConnection con = new SqlConnection(conStr))
                        }//if(esGastoConAutorizacion == 1)

                        
                        //Result.ShowAlert("Creación Exitosa");
                        Result.Refresh();
                        Result.RefreshChildren();
                        Result.Continue();
            
                    }//else if (spSql.Parameters["RetVal"].Value.ToString() != "1")

                }// using (SqlCommand cmd = new SqlCommand("sp_Revision_De_Solicitud", con))
            }// using (SqlConnection con = new SqlConnection(conStr))
            
        }
    }
}
