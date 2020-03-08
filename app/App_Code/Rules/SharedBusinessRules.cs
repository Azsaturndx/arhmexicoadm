using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using arhmexico.Data;
using System.Web.Security;
using System.Data.Common;

namespace arhmexico.Rules
{
    public partial class SharedBusinessRules : arhmexico.Data.BusinessRules
    {

        public SharedBusinessRules()
        {
            // START private bool ReturnScalarValue(string SQL, bool returnInt, out int intValue, bool returnStr, out string strValue)
        }
        private bool ReturnScalarValue(string SQL, bool returnInt, out int intValue, bool returnStr, out string strValue)
        {
            intValue = 0;
            strValue = "";
            try
            {
                object obj = SqlText.ExecuteScalar(SQL, "arhmexdb_DEV");
                string getValue = "";
                if (obj == null)
                    getValue = null;
                else
                    getValue = obj.ToString();

                if (returnInt && getValue != null)
                    intValue = int.Parse(getValue);
                else if (returnStr && getValue != null)
                    strValue = getValue;
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }//END private bool ReturnScalarValue(string SQL, bool returnInt, out int intValue, bool returnStr, out string strValue)

        // START public bool obtenerMensajeSistema(int mensajeSistemaId, out string mensajeSistema)
        public bool obtenerMensajeSistema(int mensajeSistemaId, out string mensajeSistema)
        {
            mensajeSistema = "";
            int intValue = 0;
            string returnStr = "";
            bool resultadoObtenerMensajeSistema;
            string sqlCommand = "SELECT TOP 1 Mensaje_Amigable_Usuario FROM dbo.Mensaje_Sistema WHERE Mensaje_Sistema_Id = " + mensajeSistemaId.ToString();
            resultadoObtenerMensajeSistema = ReturnScalarValue(sqlCommand, false, out intValue, true, out returnStr);

            if (resultadoObtenerMensajeSistema)
            {
                mensajeSistema = returnStr;
            }
            else
            {
                mensajeSistema = "Sin mensaje de sistema";
                return false;
            }

            return true;
        }// END public bool obtenerMensajeSistema(int mensajeSistemaId, out string mensajeSistema)


        public bool adminstrarPuestoVacante(int? puestoId, int? contratadoId, out int mensajeSistemaId, out string mensajeDeSistema)
        {
            //int mensajeSistemaId;
            mensajeDeSistema = "";
            mensajeSistemaId = 0;
            //string OrganigramaJson1 = "";
            //string ImprimeJson = "";
            //-------------
            bool resultadoObtenerMensajeSistema;
            string mensajeSistema;
            //
            //-------------
            // This is the placeholder for method implementation.
            // invocamos a nuestro sp
            using (SqlProcedure sp = new SqlProcedure("dbo.sp_Administrar_Puesto_Vacante"))
            {
                try
                {
                    //SqlServerCommand.Command.CommandType = System.Data.CommandType.StoredProcedure;
                    //SqlServerCommand.Command.CommandType
                    sp.Command.CommandTimeout = 60 * 10;

                    //PARÁMETROS IDENTIFICACIÓN OBJETO
                    sp.AddParameter("@Puesto_Id", puestoId);
                    sp.AddParameter("@Contratado_Id", contratadoId);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                   
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;

                    //sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                                      
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    //sp.Parameters["@Trace"].Size = 8000;

                    //EJECUCIÓN SP
                    sp.ExecuteNonQuery();
                    //ASIGNACIÓN DE PARÁMETRO DE SALIDA

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeDeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeDeSistema = "Ha ocurrido un error";
                        else
                            mensajeDeSistema = "Éxito";
                    }


                    return true;
                }//try
                catch (Exception ex)
                {
                    mensajeSistemaId = 1234;
                    mensajeSistema = ex.Message;


                    return false;
                }//catch (Exception e)
            }//using (SqlCommand SqlServerCommand = new SqlCommand("dbo.sp_Actualizar_Tablas_En_SDI", SDIConn)) 

        }//public bool administrarCompraUniversal(int tipoOperacionId, string serie, double? folio, string pedimentoComercialId, int? proveedorComercialId, DateTime? fechaFacturacion, int? monedaComercialId, double? tipoCambio, int? rdpAduanaId, string observaciones, int? proyectoComercialId, DateTime? fechaPedimento, int? ordenCompraComercialId, int? ordenCompraMovimientoComercialId, int? almacenComercialId, int? productoComercialId, decimal? precio, double? cantidadEstablecida, double? cantidadIngresada, double? descuento, double? porcentajeIva, string observacionesProducto, int? rdpCompraId, int? rdpCompraMovimientoId, out int? objetoRdpCompraId, out int? objetoRdpCompraMovimientoId)


        public bool generarJsonOrganizacionalPorNivel(int contratanteEstructuraId
            , int contratantePuestoId
            , int estructuraNivel
            , int seleccion
            , int clienteId //agregado
            , int contratanteId //agregado
            , out string mensajeDeSistema
            , out int mensajeSistemaId
            , out string organigramaJson)
        {
            //int mensajeSistemaId;
            mensajeDeSistema = "";
            organigramaJson = "";
            mensajeSistemaId = 0;
            //string OrganigramaJson1 = "";
            //string ImprimeJson = "";
            //-------------
            bool resultadoObtenerMensajeSistema;
            string mensajeSistema;
            //
            //-------------
            // This is the placeholder for method implementation.
            // invocamos a nuestro sp
            using (SqlProcedure sp = new SqlProcedure("dbo.sp_Generar_Json_Organigrama_Organizacional_Por_Nivel"))
            {
                try
                {
                    //SqlServerCommand.Command.CommandType = System.Data.CommandType.StoredProcedure;
                    //SqlServerCommand.Command.CommandType
                    sp.Command.CommandTimeout = 60 * 10;

                    //PARÁMETROS IDENTIFICACIÓN OBJETO
                    sp.AddParameter("@Contratante_Estructura_Organizacional_Id", contratanteEstructuraId);
                    sp.AddParameter("@Estructura_Nivel", estructuraNivel);
                    sp.AddParameter("@Seleccion", seleccion);
                    sp.AddParameter("@Contratante_Puesto_Id", contratantePuestoId);
                    sp.AddParameter("@Cliente_Id", clienteId);
                    sp.AddParameter("@Contratante_Id", contratanteId);
                    sp.AddParameter("@Organigrama_Json", "");

                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                   
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Organigrama_Json"].Direction = ParameterDirection.Output;

                    //sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                                      
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    //sp.Parameters["@Trace"].Size = 8000;
                    sp.Parameters["@Organigrama_Json"].Size = 80000;

                    //EJECUCIÓN SP
                    sp.ExecuteNonQuery();
                    //ASIGNACIÓN DE PARÁMETRO DE SALIDA

                    organigramaJson = Convert.ToString(sp.Parameters["@Organigrama_Json"].Value);

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeDeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeDeSistema = "Ha ocurrido un error";
                        else
                            mensajeDeSistema = "Éxito";
                    }


                    return true;
                }//try
                catch (Exception ex)
                {
                    mensajeSistemaId = 72;
                    mensajeSistema = ex.Message;


                    return false;
                }//catch (Exception e)
            }//using (SqlCommand SqlServerCommand = new SqlCommand("dbo.sp_Actualizar_Tablas_En_SDI", SDIConn)) 

        }//public bool administrarCompraUniversal(int tipoOperacionId, string serie, double? folio, string pedimentoComercialId, int? proveedorComercialId, DateTime? fechaFacturacion, int? monedaComercialId, double? tipoCambio, int? rdpAduanaId, string observaciones, int? proyectoComercialId, DateTime? fechaPedimento, int? ordenCompraComercialId, int? ordenCompraMovimientoComercialId, int? almacenComercialId, int? productoComercialId, decimal? precio, double? cantidadEstablecida, double? cantidadIngresada, double? descuento, double? porcentajeIva, string observacionesProducto, int? rdpCompraId, int? rdpCompraMovimientoId, out int? objetoRdpCompraId, out int? objetoRdpCompraMovimientoId)


        // START public bool RegistrarEnBitacora(int procesoSistemaId, int mensajeDeSistemaId, string trace, string mensajeErrorSistema)
        public bool RegistrarEnBitacora(int procesoSistemaId, int mensajeDeSistemaId, string trace, string mensajeErrorSistema)
        {
            using (SqlProcedure SqlServerCommand = new SqlProcedure("[dbo].[sp_Registrar_Bitacora]"))
            {
                try
                {
                    SqlServerCommand.Command.CommandTimeout = 60 * 10;

                    SqlServerCommand.AddParameter("@Fecha_Inicio", System.Data.SqlDbType.DateTime).Value = DBNull.Value;
                    SqlServerCommand.AddParameter("@Fecha_Fin", System.Data.SqlDbType.DateTime).Value = DBNull.Value;
                    SqlServerCommand.AddParameter("@Proceso_Sistema_Id", System.Data.SqlDbType.Int).Value = 0;
                    SqlServerCommand.AddParameter("@Mensaje_Sistema_Id", System.Data.SqlDbType.Int).Value = mensajeDeSistemaId;
                    SqlServerCommand.AddParameter("@System_Error_Number", System.Data.SqlDbType.Int).Value = DBNull.Value;
                    SqlServerCommand.AddParameter("@System_ErrorSeverity", System.Data.SqlDbType.Int).Value = DBNull.Value;
                    SqlServerCommand.AddParameter("@System_ErrorState", System.Data.SqlDbType.Int).Value = DBNull.Value;
                    SqlServerCommand.AddParameter("@System_ErrorProcedure", System.Data.SqlDbType.NVarChar).Value = DBNull.Value;
                    SqlServerCommand.AddParameter("@System_ErrorLine", System.Data.SqlDbType.Int).Value = DBNull.Value;
                    SqlServerCommand.AddParameter("@System_ErrorMessage", System.Data.SqlDbType.NVarChar).Value = mensajeErrorSistema;
                    SqlServerCommand.AddParameter("@Transaccion_Id", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                    SqlServerCommand.AddParameter("@Rastreo", System.Data.SqlDbType.VarChar).Value = trace;
                    SqlServerCommand.AddParameter("@Creado_Por_Id", System.Data.SqlDbType.UniqueIdentifier).Value = DBNull.Value;
                    SqlServerCommand.AddParameter("@Mostrar_Tablas_Sistema", System.Data.SqlDbType.Bit).Value = 0;
                    SqlServerCommand.AddParameter("@Simular", System.Data.SqlDbType.Bit).Value = 0;
                    SqlServerCommand.AddParameter("@Trace", System.Data.SqlDbType.VarChar).Value = trace;
                    SqlServerCommand.AddParameter("@Debug", System.Data.SqlDbType.Bit).Value = 0;

                    SqlServerCommand.ExecuteNonQuery();

                }//try
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }//catch (Exception e)
            }

            return true;
        }//END public bool RegistrarEnBitacora(int procesoSistemaId, int mensajeDeSistemaId, string trace, string mensajeErrorSistema)



        public bool ValidarSolicitudVacaciones(int contratadoId, DateTime fechaSolicitud, int diasSolicitados, DateTime fechaInicioVacaciones, DateTime fechaFinVacaciones, out string mensajeSistema, out int mensajeSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            using (SqlProcedure spSQL = new SqlProcedure("[dbo].[sp_Validar_Solicitud_Vacaciones]"))
            {
                bool solicitudVacacionesValida = false;
                spSQL.Command.CommandTimeout = 60 * 2;

                //Definición parámetro para recibir el return
                spSQL.AddParameter("RetVal", 0);
                spSQL.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                spSQL.AddParameter("@Contratado_Id", contratadoId);
                spSQL.AddParameter("@Fecha_Solicitud", fechaSolicitud);
                spSQL.AddParameter("@Dias_Solicitados", diasSolicitados);
                spSQL.AddParameter("@Fecha_Inicio_Vacaciones", fechaInicioVacaciones);
                spSQL.AddParameter("@Fecha_Fin_Vacaciones", fechaFinVacaciones);
                spSQL.AddParameter("@Solicitud_Vacaciones_Valida", solicitudVacacionesValida);
                //Definición de parámetros de Sistema
                spSQL.AddParameter("@Creado_Por_Id", UserId); //spSql.AddParameter("@Creado_Por_Id", UserId);
                spSQL.AddParameter("@Transaccion_Id", DBNull.Value);
                spSQL.AddParameter("@Fijar_Bitacora", 1);
                spSQL.AddParameter("@Mostrar_Tablas_Sistema", 0);
                spSQL.AddParameter("@Mensaje_Sistema_Id", 1);
                spSQL.AddParameter("@Simular", 0);
                spSQL.AddParameter("@Trace", "");
                spSQL.AddParameter("@Debug", 0);

                //Definición de dirección para parametros de salida
                spSQL.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                spSQL.Parameters["@Trace"].Direction = ParameterDirection.Output;
                spSQL.Parameters["@Solicitud_Vacaciones_Valida"].Direction = ParameterDirection.Output;
                spSQL.ExecuteNonQuery();

                if (spSQL.Parameters["@Mensaje_Sistema_Id"].Value.ToString() != "1")
                {
                    if (solicitudVacacionesValida)
                    {
                        mensajeSistemaId = 24;//Ocurrio un error
                        mensajeSistema = "Ocurrio un error al validar la solicitud de vacaciones";
                        return false;
                    }
                    else
                    {
                        mensajeSistemaId = 27;//Ocurrio un error
                        mensajeSistema = "La solicitud de vacaciones no es valida";
                        return false;

                    }

                }//if (spSql.Parameters["RetVal"].Value.ToString() != "1")
                else
                {
                    return true;
                }//else if (spSql.Parameters["RetVal"].Value.ToString() != "1")

            }//  using (SqlProcedure spSQL = new SqlProcedure("[dbo].[sp_Validar_Solicitud_Vacaciones]"))
            // return true;
        }//public bool ValidarSolicitudVacaciones(int contratadoId, DateTime fechaSolicitud, int diasSolicitados, DateTime fechaInicioVacaciones, DateTime fechaFinVacaciones, out string mensajeSistema, out int mensajeSistemaId)
        
        public bool AdministrarSolicitudVacaciones(int tipoOperacionId, int contratadoSolicitudVacacionesId, string solicitudVacacionesKey, int contratadoId, DateTime fechaSolicitud, int diasSolicitados, DateTime fechaInicioVacaciones, DateTime fechaFinVacaciones, int estatusSolicitudId, DateTime fechaAutorizacionRechazo, string autorizadoRechazadoPorId, string notasAutorizacionRechazo, int diasAutorizados, out string mensajeSistema, out int mensajeSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            using (SqlProcedure spSQL = new SqlProcedure("[dbo].[sp_Administrar_Solicitud_Vacaciones]"))
            {

                spSQL.Command.CommandTimeout = 60 * 2;

                //Definición parámetro para recibir el return
                spSQL.AddParameter("RetVal", 0);
                spSQL.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                spSQL.AddParameter("@Tipo_Operacion_Id", tipoOperacionId);
                spSQL.AddParameter("@Contratado_Solicitud_Vacaciones_Id", contratadoSolicitudVacacionesId);
                spSQL.AddParameter("@Solicitud_Vacaciones_Key", solicitudVacacionesKey);
                spSQL.AddParameter("@Contratado_Id", contratadoId);
                spSQL.AddParameter("@Fecha_Solicitud", fechaSolicitud);
                spSQL.AddParameter("@Dias_Solicitados", diasSolicitados);
                spSQL.AddParameter("@Fecha_Inicio_Vacaciones", fechaInicioVacaciones);
                spSQL.AddParameter("@Fecha_Fin_Vacaciones", fechaFinVacaciones);
                spSQL.AddParameter("@Estatus_Solicitud_Id", estatusSolicitudId);
                spSQL.AddParameter("@Fecha_Autorizacion_Rechazo", fechaAutorizacionRechazo);
                spSQL.AddParameter("@Autorizado_Rechazado_Por_Id", autorizadoRechazadoPorId);
                spSQL.AddParameter("@Notas_Autorizacion_Rechazo", notasAutorizacionRechazo);
                spSQL.AddParameter("@Dias_Autorizados", diasAutorizados);
                //Definición de parámetros de Sistema
                spSQL.AddParameter("@Creado_Por_Id", UserId); //spSql.AddParameter("@Creado_Por_Id", UserId);
                spSQL.AddParameter("@Transaccion_Id", DBNull.Value);
                spSQL.AddParameter("@Fijar_Bitacora", 1);
                spSQL.AddParameter("@Mostrar_Tablas_Sistema", 0);
                spSQL.AddParameter("@Mensaje_Sistema_Id", 1);
                spSQL.AddParameter("@Simular", 0);
                spSQL.AddParameter("@Trace", "");
                spSQL.AddParameter("@Debug", 0);

                //Definición de dirección para parametros de salida
                spSQL.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                spSQL.Parameters["@Trace"].Direction = ParameterDirection.Output;
                spSQL.Parameters["@Solicitud_Vacaciones_Valida"].Direction = ParameterDirection.Output;
                spSQL.ExecuteNonQuery();

                if (spSQL.Parameters["@Mensaje_Sistema_Id"].Value.ToString() != "1")
                {

                    mensajeSistemaId = 28;//Ocurrio un error
                    mensajeSistema = "Ocurrio un error al guardar la información de la solicitud de vacaciones";
                    return false;

                }//if (spSql.Parameters["RetVal"].Value.ToString() != "1")
                else
                {
                    return true;
                }//else if (spSql.Parameters["RetVal"].Value.ToString() != "1")

            }//  using (SqlProcedure spSQL = new SqlProcedure("[dbo].[sp_Administrar_Solicitud_Vacaciones]"))
            // return true;
        }//public bool AdministrarSolicitudVacaciones(int tipoOperacionId ,int contratadoSolicitudVacacionesId ,string solicitudVacacionesKey ,int contratadoId ,DateTime fechaSolicitud ,int diasSolicitados ,DateTime fechaInicioVacaciones ,DateTime fechaFinVacaciones ,int estatusSolicitudId ,DateTime fechaAutorizacionRechazo ,string autorizadoRechazadoPorId ,string notasAutorizacionRechazo,int diasAutorizados , out string mensajeSistema, out int mensajeSistemaId)

        //--------------------
        /*
        public bool AdministrarPersonaContacto(int tipoOperacionId, string nombre, string apellidoPaterno, string apellidoMaterno, string segundoNombre, DateTime fechaNacimiento, int maximoNivelEscolaridadId, int generoPersonaId, string correoPersonal, string numeroCelularPersonal, out int personaId, out string mensajeSistema, out int mensajeSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            personaId = 0;
            using (SqlProcedure spSQL = new SqlProcedure("[dbo].[sp_Administrar_Persona_Contacto]"))
            {

                spSQL.Command.CommandTimeout = 60 * 2;

                //Definición parámetro para recibir el return
                spSQL.AddParameter("RetVal", 0);
                spSQL.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                spSQL.AddParameter("@Tipo_Operacion_Id", tipoOperacionId);
                spSQL.AddParameter("@Nombre", nombre);
                spSQL.AddParameter("@Apellido_Paterno", apellidoPaterno);
                spSQL.AddParameter("@Apellido_Materno", apellidoMaterno);
                spSQL.AddParameter("@Segundo_Nombre", segundoNombre);
                spSQL.AddParameter("@Fecha_Nacimiento", fechaNacimiento);
                spSQL.AddParameter("@Maximo_Nivel_Escolaridad_Id", maximoNivelEscolaridadId);
                spSQL.AddParameter("@Genero_Persona_Id", generoPersonaId);
                spSQL.AddParameter("@Correo_Personal", correoPersonal);
                spSQL.AddParameter("@Numero_Celular_Personal", numeroCelularPersonal);
                spSQL.AddParameter("@Persona_Jefe_Id", personaId);

                //Definición de parámetros de Sistema
                spSQL.AddParameter("@Creado_Por_Id", UserId); //spSql.AddParameter("@Creado_Por_Id", UserId);
                spSQL.AddParameter("@Transaccion_Id", DBNull.Value);
                spSQL.AddParameter("@Fijar_Bitacora", 1);
                spSQL.AddParameter("@Mostrar_Tablas_Sistema", 0);
                spSQL.AddParameter("@Mensaje_Sistema_Id", 1);
                spSQL.AddParameter("@Simular", 0);
                spSQL.AddParameter("@Trace", "");
                spSQL.AddParameter("@Debug", 0);

                //Definición de dirección para parametros de salida
                spSQL.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                spSQL.Parameters["@Trace"].Direction = ParameterDirection.Output;
                spSQL.Parameters["@Persona_Jefe_Id"].Direction = ParameterDirection.Output;
                spSQL.ExecuteNonQuery();

                if (spSQL.Parameters["@Mensaje_Sistema_Id"].Value.ToString() != "1")
                {

                    mensajeSistemaId = 120;//Ocurrio un error
                    //mensajeSistema = "Ocurrio un error al guardar la información de la solicitud de vacaciones";
                    mensajeSistema = SqlText.ExecuteScalar("SELECT Mensaje_Amigable_Usuario FROM dbo.Mensaje_Sistema WHERE Mensaje_Sistema_Id=" + spSQL.Parameters["@Mensaje_Sistema_Id"].Value.ToString()).ToString();
                    //Result.ShowAlert(ErrorMessage);
                    return false;

                }//if (spSql.Parameters["RetVal"].Value.ToString() != "1")
                else
                {
                    mensajeSistema = "Creación Exitosa";
                    return true;
                }//else if (spSql.Parameters["RetVal"].Value.ToString() != "1")

            }//  using (SqlProcedure spSQL = new SqlProcedure("[dbo].[sp_Administrar_Solicitud_Vacaciones]"))
            // return true;
        }//  public bool AdministrarPersonaContacto(int tipoOperacionId, string nombre, string apellidoPaterno,string  apellidoMaterno, string segundoNombre ,DateTime fechaNacimiento, int maximoNivelEscolaridadId, int generoPersonaId ,string correoPersonal, string numeroCelularPersonal, out int personaId,  out string mensajeSistema, out int mensajeSistemaId)
        */

        public bool CrearMembership(string usuarioCuentaMembership, string correoElectronico, string contrasenaUsuario, string preguntaRecuperacionContrasena, string respuestaPreguntaRecuperacionContrasena, string rolUsuario, out string mensajeSistema, out int mensajeSistemaId)
        {
            bool resultado = false;
            MembershipUser admin;
            MembershipCreateStatus status;
            string mensajeFinal = "";
            mensajeSistemaId = 0;
            mensajeSistema = "";
            //Guid usuario;
            //MembershipUser usuario;

            try
            {
                admin = Membership.CreateUser(usuarioCuentaMembership, contrasenaUsuario, correoElectronico, preguntaRecuperacionContrasena, respuestaPreguntaRecuperacionContrasena, true, out status);
                Roles.AddUserToRole(admin.UserName, rolUsuario);
                resultado = true;
                mensajeFinal = status.ToString();
                mensajeSistemaId = 1;
            }
            catch
            {
                mensajeSistemaId = 139;
                mensajeFinal = "Ocurrió un error al tratar de crear su cuenta: ";
            }
            mensajeSistema = mensajeFinal;
            return resultado;
        }// public bool ValidarMembership(string correoElectronico, string contrasenaUsuario, string preguntaRecuperacionContrasena, string respuestaPreguntaRecuperacionContrasena, string rolUsuario, out string mensajeSistema)

        public bool ProcesarTemporalCargaContratado(out int mensajeSistemaId, out string mensajeSistema)
        {
            mensajeSistemaId = 0;
            mensajeSistema = "";

            using (SqlProcedure spSQL = new SqlProcedure("[sp_Procesar_Carga_Temporal_Contratado]"))
            {
                spSQL.Command.CommandTimeout = 60 * 2;

                //Definición parámetro para recibir el return
                spSQL.AddParameter("RetVal", 0);
                spSQL.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;
                //Definición de parámetros de Sistema
                spSQL.AddParameter("@Creado_Por_Id", UserId); 
                spSQL.AddParameter("@Transaccion_Id", DBNull.Value);
                spSQL.AddParameter("@Fijar_Bitacora", 1);
                spSQL.AddParameter("@Mostrar_Tablas_Sistema", 0);
                spSQL.AddParameter("@Mensaje_Sistema_Id", 1);
                spSQL.AddParameter("@Simular", 0);
                spSQL.AddParameter("@Trace", "");
                spSQL.AddParameter("@Debug", 0);

                //Definición de dirección para parametros de salida
                spSQL.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                spSQL.Parameters["@Trace"].Direction = ParameterDirection.Output;


                //Definición de tamaños de parametros de salida
                spSQL.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                spSQL.Parameters["@Trace"].Size = 8000;


                spSQL.ExecuteNonQuery();

                if (spSQL.Parameters["@Mensaje_Sistema_Id"].Value.ToString() != "1")
                {

                    mensajeSistema = SqlText.ExecuteScalar("SELECT Mensaje_Amigable_Usuario FROM dbo.Mensaje_Sistema WHERE Mensaje_Sistema_Id=" + spSQL.Parameters["@Mensaje_Sistema_Id"].Value.ToString()).ToString();
                    return false;

                }//if (spSql.Parameters["RetVal"].Value.ToString() != "1")
                else
                {
                    mensajeSistema = "Creación Exitosa";
                    return true;
                }//else if (spSql.Parameters["RetVal"].Value.ToString() != "1")

            }//using (SqlProcedure spSQL = new SqlProcedure("[sp_Procesar_Carga_Temporal_Contratado]"))

        }//public bool ProcesarTemporalCargaContratado(out int mensajeSistemaId, out string mensajeSistema)

        public bool InsertarTemporalContratanteUsuarioAplicacion(int contratanteId, int contratadoId, int personaId, string identificadorUnico, string correoElectronico, string contrasena, string nota, out string mensajeSistema, out int mensajeSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;

            using (SqlProcedure spSQL = new SqlProcedure("[dbo].[sp_Insertar_Temporal_Contratante_Usuario_Aplicacion]"))
            {

                spSQL.Command.CommandTimeout = 60 * 5;

                //Definición parámetro para recibir el return
                spSQL.AddParameter("RetVal", 0);
                spSQL.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                spSQL.AddParameter("@Contratante_Id", contratanteId);
                spSQL.AddParameter("@Contratado_Id", contratadoId);
                spSQL.AddParameter("@Persona_Id", personaId);
                spSQL.AddParameter("@Identificador_Unico", identificadorUnico);
                spSQL.AddParameter("@Correo_Electronico", correoElectronico);
                spSQL.AddParameter("@Contrasena", contrasena);
                spSQL.AddParameter("@Nota", nota);
                //Definición de parámetros de Sistema
                spSQL.AddParameter("@Creado_Por_Id", UserId); //spSql.AddParameter("@Creado_Por_Id", UserId);
                spSQL.AddParameter("@Transaccion_Id", DBNull.Value);
                spSQL.AddParameter("@Fijar_Bitacora", 1);
                spSQL.AddParameter("@Mostrar_Tablas_Sistema", 0);
                spSQL.AddParameter("@Mensaje_Sistema_Id", 1);
                spSQL.AddParameter("@Simular", 0);
                spSQL.AddParameter("@Trace", "");
                spSQL.AddParameter("@Debug", 0);

                //Definición de dirección para parametros de salida
                spSQL.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                spSQL.Parameters["@Trace"].Direction = ParameterDirection.Output;


                //Definición de tamaños de parametros de salida
                spSQL.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                spSQL.Parameters["@Trace"].Size = 8000;


                spSQL.ExecuteNonQuery();

                if (spSQL.Parameters["@Mensaje_Sistema_Id"].Value.ToString() != "1")
                {

                    mensajeSistemaId = 120;
                    mensajeSistema = SqlText.ExecuteScalar("SELECT Mensaje_Amigable_Usuario FROM dbo.Mensaje_Sistema WHERE Mensaje_Sistema_Id=" + spSQL.Parameters["@Mensaje_Sistema_Id"].Value.ToString()).ToString();
                    //Result.ShowAlert(ErrorMessage);
                    return false;

                }//if (spSql.Parameters["RetVal"].Value.ToString() != "1")
                else
                {
                    mensajeSistema = "Creación Exitosa";
                    return true;
                }//else if (spSql.Parameters["RetVal"].Value.ToString() != "1")

            }//   using (SqlProcedure spSQL = new SqlProcedure("[dbo].[sp_Insertar_Temporal_Contratante_Usuario_Aplicacion]"))
            // return true;
        }//   public bool InsertarTemporalContratanteUsuarioAplicacion(int contratanteId, int contratadoId, int personaId, string identificadorUnico, string correoElectronico, string contrasena, string nota, out string mensajeSistema, out int mensajeSistemaId)

        public bool CrearUsuariosContratantePendientesMembership(int contratanteId, out string mensajeSistema, out int mensajeSistemaId)
        {
            //Crear usuarios que no se han creado en membership ni existen en tabla APP.Persona_Usuario_Aplicacion
            mensajeSistema = "";
            mensajeSistemaId = 0;
            var dt = new DataTable();
            dt = null;
            SqlText dataResult;
            DbDataReader reader;
            int cantidadUsuariosPendientesCrear;



            cantidadUsuariosPendientesCrear = (int)SqlText.ExecuteScalar("SELECT COUNT(*) FROM dbo.Contratante_Correos_Usuarios_Aplicacion_V WHERE Contratante_Id = "
                                              + contratanteId
                                              + " AND Crear_Usuario_MemberShip = 1 "
                                              + "");
            if (cantidadUsuariosPendientesCrear > 0)
            {
                string sentenciaSQL = "";
                sentenciaSQL = "SELECT "
                                    // + "Contratante_Id"
                                    + "Contratado_Id"
                                    + ",Persona_Id"
                                    + ",Identificador_Unico"
                                    + ",Correo_Electronico"
                                    + ",Usuario_Cuenta_Membership" //Ahora este será el usuario para crear la cuenta y no el correo electrónico
                                    + " ,Contrasena"
                                    + ",Rol_Usuario"
                                    + ",Pregunta_Recuperacion_Contrasena"
                                    + ",Respuesta_Pregunta_Recuperacion_Contrasena"
                                + " FROM "
                                    + " dbo.Contratante_Correos_Usuarios_Aplicacion_V"
                                + " WHERE Contratante_Id = " + contratanteId
                                    + " AND Crear_Usuario_MemberShip = 1";
                //Llenado de Datatable
                try
                {
                    dataResult = new SqlText(sentenciaSQL);
                    reader = dataResult.ExecuteReader();
                    //Inicio para obtener variables de consulta
                    int contratadoId;
                    int personaId;
                    string identificadorUnico;
                    string correoElectronico;
                    string usuarioCuentaMembership;
                    string preguntaRecuperacionContrasena;
                    string respuestaPreguntaRecuperacionContrasena;
                    string rolUsuario;
                    string contrasena = "";

                    bool aplicaContacto = false;
                    string numeroCelular = "";
                    int personaUsuarioAplicacionId = 0;
                    string nota = "";
                    //preguntaRecuperacionContrasena = "Ingrese su Identificador Único";
                    //rolUsuario = "rhUsuario";

                    while (reader.Read())
                    {

                        contratadoId = Convert.ToInt32(reader["Contratado_Id"]);
                        personaId = Convert.ToInt32(reader["Persona_Id"]);
                        identificadorUnico = Convert.ToString(reader["Identificador_Unico"]);
                        correoElectronico = Convert.ToString(reader["Correo_Electronico"]);
                        usuarioCuentaMembership = Convert.ToString(reader["Usuario_Cuenta_Membership"]); //Nombre de Usuario
                        contrasena = Convert.ToString(reader["Contrasena"]);
                        rolUsuario = Convert.ToString(reader["Rol_Usuario"]);
                        preguntaRecuperacionContrasena = Convert.ToString(reader["Pregunta_Recuperacion_Contrasena"]);
                        respuestaPreguntaRecuperacionContrasena = Convert.ToString(reader["Respuesta_Pregunta_Recuperacion_Contrasena"]);


                        //Creación de usuario membership
                        bool resultadoCreacionUsuarioMembership = CrearMembership(
                                                                                    usuarioCuentaMembership
                                                                                    ,correoElectronico
                                                                                    , contrasena
                                                                                    , preguntaRecuperacionContrasena
                                                                                    , respuestaPreguntaRecuperacionContrasena
                                                                                    , rolUsuario
                                                                                    , out mensajeSistema
                                                                                    , out mensajeSistemaId
                                                                                  );

                        if (resultadoCreacionUsuarioMembership)
                        {
                            //Creación de usuario aplicación
                            bool resultadoCrearUsuarioAplicacion = CrearUsuarioAplicacion(
                                                                                            personaId
                                                                                            , usuarioCuentaMembership //usuario
                                                                                            , correoElectronico
                                                                                            , numeroCelular
                                                                                            , contrasena
                                                                                            , out personaUsuarioAplicacionId
                                                                                            , aplicaContacto
                                                                                            , out mensajeSistema
                                                                                            , out mensajeSistemaId
                                                                                          );

                            if (resultadoCrearUsuarioAplicacion)
                            {
                                bool resultadoInsertarTemporalContratanteUsuarioAplicacion = InsertarTemporalContratanteUsuarioAplicacion
                                                                                                                                            (
                                                                                                                                                contratanteId
                                                                                                                                                , contratadoId
                                                                                                                                                , personaId
                                                                                                                                                , identificadorUnico
                                                                                                                                                //, correoElectronico
                                                                                                                                                , usuarioCuentaMembership
                                                                                                                                                , contrasena
                                                                                                                                                , nota
                                                                                                                                                , out mensajeSistema
                                                                                                                                                , out mensajeSistemaId
                                                                                                                                            );
                                if (resultadoInsertarTemporalContratanteUsuarioAplicacion)
                                {
                                    mensajeSistemaId = 1;
                                    //return true;
                                }//if(resultadoInsertarTemporalContratanteUsuarioAplicacion)
                                else
                                {
                                    return false;
                                }//if(!resultadoInsertarTemporalContratanteUsuarioAplicacion)
                            }//if(resultadoCrearUsuarioAplicacion)
                            else
                            {
                                return false;
                            }//if(!resultadoCrearUsuarioAplicacion)
                        }//if(resultadoCreacionUsuarioMembership)
                        else
                        {
                            return false;
                        }//if(!resultadoCreacionUsuarioMembership)


                    }//while (reader.Read())

                    return true;

                }//try
                catch (Exception e)
                {
                    mensajeSistema = e.Message;
                    //mensajeSistemaId = 600067;
                    return false;
                }//catch

            }//if (cantidadUsuariosPendientesCrear > 0)
            else
            {
                mensajeSistema = "No existen usuarios con cuentas pendiente de crear. Nota: Si existe algun usuario sin acceso validar que ese usuario tenga asociado un correo electrónico de trabajo";
                mensajeSistemaId = 143;
                return true;

            }//if (cantidadUsuariosPendientesCrear <= 0)


        }//public bool CrearUsuariosContratantePendientesMembership(int contratanteId, out string mensajeSistema, out int mensajeSistemaId)


        public bool CrearUsuariosContratantePendientesAplicacion(int contratanteId, out string mensajeSistema, out int mensajeSistemaId)
        {
            //Crear usuarios que  se han creado en membership pero que no estan asignados a tabla APP.Persona_Usuario_Aplicacion
            mensajeSistema = "";
            mensajeSistemaId = 0;
            var dt = new DataTable();
            dt = null;
            string sentenciaSQL = "";
            SqlText dataResult;
            DbDataReader reader;
            // int cantidadUsuariosPendientesCrear;

            sentenciaSQL = "SELECT "
                // + "Contratante_Id"
                                + "Contratado_Id"
                                + ",Persona_Id"
                                + ",Identificador_Unico"
                                + ",Correo_Electronico"
                                + ",Usuario_Cuenta_Membership" //Ahora será este el usuario para crear la cuenta
                                + ",Contrasena"
                                + ",Rol_Usuario"
                                + ",Pregunta_Recuperacion_Contrasena"
                                + ",Respuesta_Pregunta_Recuperacion_Contrasena"
                            + " FROM "
                                + " dbo.Contratante_Correos_Usuarios_Aplicacion_V"
                            + " WHERE Contratante_Id = " + contratanteId
                                + " AND Crear_Usuario_MemberShip = 0"
                                + " AND Crear_Usuario_Aplicacion = 1";
            //Llenado de Datatable
            try
            {
                dataResult = new SqlText(sentenciaSQL);
                reader = dataResult.ExecuteReader();
                //Inicio para obtener variables de consulta
                int contratadoId;
                int personaId;
                string identificadorUnico;
                string correoElectronico;
                string usuarioCuentaMembership;
                string preguntaRecuperacionContrasena;
                string respuestaPreguntaRecuperacionContrasena;
                string rolUsuario;
                string contrasena = "";

                bool aplicaContacto = false;
                string numeroCelular = "";
                int personaUsuarioAplicacionId = 0;
                string nota = "";
                //preguntaRecuperacionContrasena = "Ingrese su Identificador Único";
                // rolUsuario = "rhUsuario";

                while (reader.Read())
                {

                    contratadoId = Convert.ToInt32(reader["Contratado_Id"]);
                    personaId = Convert.ToInt32(reader["Persona_Id"]);
                    identificadorUnico = Convert.ToString(reader["Identificador_Unico"]);
                    correoElectronico = Convert.ToString(reader["Correo_Electronico"]);
                    usuarioCuentaMembership = Convert.ToString(reader["Usuario_Cuenta_Membership"]);
                    contrasena = Convert.ToString(reader["Contrasena"]);
                    rolUsuario = Convert.ToString(reader["Rol_Usuario"]);
                    preguntaRecuperacionContrasena = Convert.ToString(reader["Pregunta_Recuperacion_Contrasena"]);
                    respuestaPreguntaRecuperacionContrasena = Convert.ToString(reader["Respuesta_Pregunta_Recuperacion_Contrasena"]);
                    //respuestaPreguntaRecuperacionContrasena = identificadorUnico;



                    //Creación de usuario aplicación
                    bool resultadoCrearUsuarioAplicacion = CrearUsuarioAplicacion(
                                                                                        personaId
                                                                                        , usuarioCuentaMembership //usuario
                                                                                        , correoElectronico
                                                                                        , numeroCelular
                                                                                        , contrasena
                                                                                        , out personaUsuarioAplicacionId
                                                                                        , aplicaContacto
                                                                                        , out mensajeSistema
                                                                                        , out mensajeSistemaId
                                                                                      );




                    if (resultadoCrearUsuarioAplicacion)
                    {
                        mensajeSistemaId = 1;
                        //return true;
                    }//if(resultadoCrearUsuarioAplicacion)
                    else
                    {
                        return false;
                    }//if(!resultadoCrearUsuarioAplicacion)
                }//while (reader.Read())
                reader.Close();
                return true;

            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                return false;
            }//catch

        }//public bool CrearUsuariosContratantePendientesAplicacion(int contratanteId, out string mensajeSistema, out int mensajeSistemaId)


        public bool CrearUsuariosContratante(int contratanteId, out string mensajeSistema, out int mensajeSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;

            try
            {
                //Crear Usuarios que no estan en membership
                bool resultadoCrearUsuariosContratantePendientesMembership = CrearUsuariosContratantePendientesMembership
                                                                                                                        (
                                                                                                                            contratanteId
                                                                                                                            , out mensajeSistema
                                                                                                                            , out mensajeSistemaId
                                                                                                                         );
                if (resultadoCrearUsuariosContratantePendientesMembership)
                {
                    //Asociar usuarios que estan en membership pero que no estan en usuario aplicación
                    //Validar si existe usuarios pendientes por asociar a usuario aplicación
                    int cantidadUsuariosPendientesCrear = (int)SqlText.ExecuteScalar("SELECT COUNT(*) FROM dbo.Contratante_Correos_Usuarios_Aplicacion_V WHERE Contratante_Id = "
                                               + contratanteId
                                               + " AND Crear_Usuario_MemberShip = 1"
                                               + " AND Crear_Usuario_Aplicacion = 1"
                                               + "");
                    if (cantidadUsuariosPendientesCrear > 0)
                    {
                        bool resultadoCrearUsuariosContratantePendientesAplicacion = CrearUsuariosContratantePendientesAplicacion
                                                                                                                             (
                                                                                                                                    contratanteId
                                                                                                                                    , out mensajeSistema
                                                                                                                                    , out mensajeSistemaId
                                                                                                                              );
                        if (resultadoCrearUsuariosContratantePendientesAplicacion)
                        {
                            mensajeSistemaId = 1;
                            return true;
                        }//if(resultadoCrearUsuariosContratantePendientesAplicacion)
                        else
                        {
                            return false;
                        }//if(!resultadoCrearUsuariosContratantePendientesAplicacion)

                    }//if (cantidadUsuariosPendientesCrear > 0)

                    mensajeSistemaId = 1;
                    return true;
                }//if(resultadoCrearUsuariosContratantePendientesMembership)
                else
                {
                    return false;
                }//if(!resultadoCrearUsuariosContratantePendientesMembership)
            }
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                // mensajeSistemaId = 141;
                return false;
            }
        }//public bool CrearUsuariosContratante(int contratanteId, out string mensajeSistema, out int mensajeSistemaId)        


        public bool CrearUsuarioAplicacion(int personaId, string usuario, string correoElectronico, string numeroCelular, string contrasena, out int personaUsuarioAplicacionId, bool aplicaContacto, out string mensajeSistema, out int mensajeSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            personaUsuarioAplicacionId = 0;

            using (SqlProcedure spSQL = new SqlProcedure("[dbo].[sp_Crear_Usuario_Aplicacion]"))
            {

                spSQL.Command.CommandTimeout = 60 * 5;

                //Definición parámetro para recibir el return
                spSQL.AddParameter("RetVal", 0);
                spSQL.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                spSQL.AddParameter("@Persona_Id", personaId);
                spSQL.AddParameter("@Usuario", usuario);
                spSQL.AddParameter("@Correo_Electronico", correoElectronico);
                spSQL.AddParameter("@Numero_Celular", numeroCelular);
                spSQL.AddParameter("@Contrasena", contrasena);
                spSQL.AddParameter("@Aplica_Contacto", aplicaContacto);
                spSQL.AddParameter("@Persona_Usuario_Aplicacion_Id", personaUsuarioAplicacionId);
                //Definición de parámetros de Sistema
                spSQL.AddParameter("@Creado_Por_Id", UserId); //spSql.AddParameter("@Creado_Por_Id", UserId);
                spSQL.AddParameter("@Transaccion_Id", DBNull.Value);
                spSQL.AddParameter("@Fijar_Bitacora", 1);
                spSQL.AddParameter("@Mostrar_Tablas_Sistema", 0);
                spSQL.AddParameter("@Mensaje_Sistema_Id", 1);
                spSQL.AddParameter("@Simular", 0);
                spSQL.AddParameter("@Trace", "");
                spSQL.AddParameter("@Debug", 0);

                //Definición de dirección para parametros de salida
                spSQL.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                spSQL.Parameters["@Trace"].Direction = ParameterDirection.Output;
                spSQL.Parameters["@Persona_Usuario_Aplicacion_Id"].Direction = ParameterDirection.Output;

                //Definición de tamaños de parametros de salida
                spSQL.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                spSQL.Parameters["@Trace"].Size = 8000;
                spSQL.Parameters["@Persona_Usuario_Aplicacion_Id"].Size = 4;

                spSQL.ExecuteNonQuery();
                


                if (spSQL.Parameters["@Mensaje_Sistema_Id"].Value.ToString() != "1")
                {

                    mensajeSistemaId = 120;
                    mensajeSistema = SqlText.ExecuteScalar("SELECT Mensaje_Amigable_Usuario FROM dbo.Mensaje_Sistema WHERE Mensaje_Sistema_Id=" + spSQL.Parameters["@Mensaje_Sistema_Id"].Value.ToString()).ToString();
                    //Result.ShowAlert(ErrorMessage);
                    return false;

                }//if (spSql.Parameters["RetVal"].Value.ToString() != "1")
                else
                {
                    personaUsuarioAplicacionId = Convert.ToInt32(spSQL.Parameters["@Persona_Usuario_Aplicacion_Id"].Value);
                    mensajeSistema = "Creación Exitosa";
                    return true;
                }//else if (spSql.Parameters["RetVal"].Value.ToString() != "1")

            }//   using (SqlProcedure spSQL = new SqlProcedure("[dbo].[sp_Crear_Usuario_Aplicacion]"))
            // return true;
        }//  public bool CrearUsuarioAplicacion(int personaId , string usuario, string correoElectronico, string numeroCelular, string contrasena, out string mensajeSistema, out int mensajeSistemaId)

        public bool CargarSGMMYSV(out int mensajeSistemaId, out string mensajeSistema)
        {
            mensajeSistemaId = 0;
            mensajeSistema = "";

            using (SqlProcedure spSQL = new SqlProcedure("[dbo].[sp_Cargar_Informacion_SGMM_Vida]"))
            {

                spSQL.Command.CommandTimeout = 60 * 2;

                //Definición de parámetros de Sistema
                spSQL.AddParameter("@Creado_Por_Id", UserId); //spSql.AddParameter("@Creado_Por_Id", UserId);
                spSQL.AddParameter("@Transaccion_Id", DBNull.Value);
                spSQL.AddParameter("@Fijar_Bitacora", 1);
                spSQL.AddParameter("@Mostrar_Tablas_Sistema", 0);
                spSQL.AddParameter("@Mensaje_Sistema_Id", 1);
                spSQL.AddParameter("@Mensaje_Sistema", "");
                spSQL.AddParameter("@Simular", 0);
                spSQL.AddParameter("@Trace", "");
                spSQL.AddParameter("@Debug", 0);

                //Definición de dirección para parametros de salida
                spSQL.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                spSQL.Parameters["@Trace"].Direction = ParameterDirection.Output;


                //Definición de tamaños de parametros de salida
                spSQL.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                spSQL.Parameters["@Trace"].Size = 8000;


                spSQL.ExecuteNonQuery();

                if (spSQL.Parameters["@Mensaje_Sistema_Id"].Value.ToString() != "1")
                {

                    mensajeSistemaId = 120;
                    mensajeSistema = SqlText.ExecuteScalar("SELECT Mensaje_Amigable_Usuario FROM dbo.Mensaje_Sistema WHERE Mensaje_Sistema_Id=" + spSQL.Parameters["@Mensaje_Sistema_Id"].Value.ToString()).ToString();
                    //Result.ShowAlert(ErrorMessage);
                    return false;

                }//if (spSql.Parameters["RetVal"].Value.ToString() != "1")
                else
                {
                    mensajeSistema = "Datos Procesados con éxito";
                    return true;
                }//else if (spSql.Parameters["RetVal"].Value.ToString() != "1")

            }//using (SqlProcedure spSQL = new SqlProcedure("[dbo].[sp_Cargar_Informacion_SGMM_Vida]"))

            //--------------------
        }//public bool CargarSGMMYSV(out int mensajeSistemaId, out string mensajeSistema)

        public bool AdministrarMovimientoPersonal(int tipoMovimientoPersonalId, int personaId, int contratadoId, DateTime fechaMovimientoPersonal, int motivoMovimientoPersonalId, int contratanteEstructuraOrganizacionalId, int pagadoraId, int contratantePuestoId, int contratanteId, int clienteId, int contratanteNuevaEstructuraOrganizacionalId, int pagadoraNuevaId, int contratantePuestoNuevoId, int contratanteNuevoId, int clienteNuevoId, DateTime fechaContratacion, DateTime fechaAntiguedad, int tipoContratadoId, int tipoEmpleadoId, int turnoLaboralId ,out int mensajeSistemaId, out string mensajeSistema)
        {
            mensajeSistemaId = 0;
            mensajeSistema = "";

            using (SqlProcedure spSQL = new SqlProcedure("[dbo].[sp_Administrar_Movimiento_Personal]"))
            {
                spSQL.Command.CommandTimeout = 60 * 2;

                //Definición de parámetros de SP
                spSQL.AddParameter("@Tipo_Movimiento_Personal_Id", tipoMovimientoPersonalId); //spSql.AddParameter("@Creado_Por_Id", UserId);
                spSQL.AddParameter("@Persona_Id", personaId);
                spSQL.AddParameter("@Contratado_Id", contratadoId);
                spSQL.AddParameter("@Fecha_Movimiento_Personal", fechaMovimientoPersonal);
                spSQL.AddParameter("@Motivo_Movimiento_Personal_Id", motivoMovimientoPersonalId);
                spSQL.AddParameter("@Contratante_Estructura_Organizacional_Id", contratanteEstructuraOrganizacionalId);
                spSQL.AddParameter("@Pagadora_Id", pagadoraId);
                spSQL.AddParameter("@Contratante_Puesto_Id", contratantePuestoId);
                spSQL.AddParameter("@Contratante_Id", contratanteId);
                spSQL.AddParameter("@Cliente_Id", clienteId);
                //Nuevos
                spSQL.AddParameter("@Contratante_Nueva_Estructura_Organizacional_Id", contratanteNuevaEstructuraOrganizacionalId);
                spSQL.AddParameter("@Pagadora_Nueva_Id", pagadoraNuevaId);
                spSQL.AddParameter("@Contratante_Puesto_Nuevo_Id", contratantePuestoNuevoId);
                spSQL.AddParameter("@Contratante_Nuevo_Id", contratanteNuevoId);
                spSQL.AddParameter("@Cliente_Nuevo_Id", clienteNuevoId);
                //Recontratacion
                spSQL.AddParameter("@Fecha_Contratacion", fechaContratacion);
                spSQL.AddParameter("@Fecha_Antiguedad", fechaAntiguedad);
                spSQL.AddParameter("@Tipo_Contratado_Id", tipoContratadoId);
                spSQL.AddParameter("@Tipo_Empleado_Id", tipoEmpleadoId);
                spSQL.AddParameter("@Turno_Laboral_Id", turnoLaboralId);

                //Definición de parámetros de Sistema
                spSQL.AddParameter("@Creado_Por_Id", UserId); //spSql.AddParameter("@Creado_Por_Id", UserId);
                spSQL.AddParameter("@Transaccion_Id", DBNull.Value);
                spSQL.AddParameter("@Fijar_Bitacora", 1);
                spSQL.AddParameter("@Mostrar_Tablas_Sistema", 0);
                spSQL.AddParameter("@Mensaje_Sistema_Id", 1);
                spSQL.AddParameter("@Simular", 0);
                spSQL.AddParameter("@Trace", "");
                spSQL.AddParameter("@Debug", 0);

                //Definición de dirección para parametros de salida
                spSQL.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                spSQL.Parameters["@Trace"].Direction = ParameterDirection.Output;


                //Definición de tamaños de parametros de salida
                spSQL.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                spSQL.Parameters["@Trace"].Size = 8000;


                spSQL.ExecuteNonQuery();

                if (spSQL.Parameters["@Mensaje_Sistema_Id"].Value.ToString() != "1")
                {

                    mensajeSistemaId = Convert.ToInt32(spSQL.Parameters["@Mensaje_Sistema_Id"].Value.ToString());
                    mensajeSistema = SqlText.ExecuteScalar("SELECT Mensaje_Amigable_Usuario FROM dbo.Mensaje_Sistema WHERE Mensaje_Sistema_Id=" + mensajeSistemaId.ToString()).ToString();
                    //Result.ShowAlert(ErrorMessage);
                    return false;

                }//if (spSql.Parameters["RetVal"].Value.ToString() != "1")
                else
                {
                    mensajeSistema = "Actualizado con éxito";
                    return true;
                }//else if (spSql.Parameters["RetVal"].Value.ToString() != "1")

            }//using (SqlProcedure spSQL = new SqlProcedure("[dbo].[sp_Administrar_Movimiento_Personal]"))
        }//public bool AdministrarMovimientoPersonal(int tipoMovimientoPersonalId, int personaId, int contratadoId, DateTime fechaMovimientoPersonal, int motivoMovimientoPersonalId, int contratanteEstructuraOrganizacionalId, int pagadoraId, int contratantePuestoId, int contratanteId, int clienteId, int contratanteNuevaEstructuraOrganizacionalId, int pagadoraNuevaId, int contratantePuestoNuevoId, int contratanteNuevoId, int clienteNuevoId, out int mensajeSistemaId, out string mensajeSistema)


        public bool AdministrarSolicitudDocumento(int tipoOperacionId, int definicionDocumentoId, int contratadoId, out string mensajeSistema, out int mensajeSistemaId)
        {
            mensajeSistemaId = 0;
            mensajeSistema = "";

            using (SqlProcedure spSQL = new SqlProcedure("[dbo].[sp_Administrar_Solicitud_Documento]"))
            {
                spSQL.Command.CommandTimeout = 60 * 2;

                //Definición parámetro para recibir el return
                spSQL.AddParameter("RetVal", 0);
                spSQL.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                spSQL.AddParameter("@Tipo_Operacion_Id", tipoOperacionId);
                spSQL.AddParameter("@Definicion_Solicitud_Documento_Id", definicionDocumentoId);
                spSQL.AddParameter("@Contratado_Id", contratadoId);
                spSQL.AddParameter("@Solicitud_Documento_Key", DBNull.Value);
                spSQL.AddParameter("@Fecha_Solicitud", DBNull.Value);
                spSQL.AddParameter("@Estatus_Solicitud_Id", 0);
                spSQL.AddParameter("@Fecha_Autorizacion_Rechazo", DBNull.Value);
                spSQL.AddParameter("@Autorizado_Rechazado_Por_Id", Guid.NewGuid());
                spSQL.AddParameter("@Notas_Autorizacion_Rechazo", DBNull.Value);
                spSQL.AddParameter("@HTML", DBNull.Value);
                //Definición de parámetros de Sistema
                spSQL.AddParameter("@Mensaje_Sistema_Id", 1);
                spSQL.AddParameter("@Debug", 0);
                //Definición de dirección para parametros de salida
                spSQL.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;

                //Definición de tamaños de parametros de salida
                spSQL.Parameters["@Mensaje_Sistema_Id"].Size = 4;

                spSQL.ExecuteNonQuery();

                if (spSQL.Parameters["@Mensaje_Sistema_Id"].Value.ToString() != "1")
                {
                    mensajeSistema = SqlText.ExecuteScalar("SELECT Mensaje_Amigable_Usuario FROM dbo.Mensaje_Sistema WHERE Mensaje_Sistema_Id=" + spSQL.Parameters["@Mensaje_Sistema_Id"].Value.ToString()).ToString();
                    return false;
                }//if (spSQL.Parameters["@Mensaje_Sistema_Id"].Value.ToString() != "1")
                else
                {
                    mensajeSistema = "Creación Exitosa";
                    return true;
                }//if (spSQL.Parameters["@Mensaje_Sistema_Id"].Value.ToString() != "1")

            }//using (SqlProcedure spSQL = new SqlProcedure("[dbo].[sp_Administrar_Solicitud_Documento]"))


        }//public bool AdministrarSolicitudDocumento(int tipoOperacionId, int definicionDocumentoId, int contratadoId, out string mensajeSistema, out int mensajeSistemaId)

        public bool AdministrarSolicitudPrestamo(int tipoOperacionId, int contratadoId, int contratadoSolicitudPrestamoId, int estatusSolicitudId, string notasSolicitud, string notasAutorizacionRechazo, string solicitudPrestamoKey, decimal montoSolicitado, out string mensajeSistema, out int mensajeSistemaId)
        {
            mensajeSistemaId = 0;
            mensajeSistema = "";

            using (SqlProcedure spSQL = new SqlProcedure("[dbo].[sp_Administrar_Solicitud_Prestamo]"))
            {
                spSQL.Command.CommandTimeout = 60 * 2;

                //Definición parámetro para recibir el return
                spSQL.AddParameter("RetVal", 0);
                spSQL.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                spSQL.AddParameter("@Tipo_Operacion_Id", tipoOperacionId);
                spSQL.AddParameter("@Contratado_Solicitud_Prestamo_Id", contratadoSolicitudPrestamoId);
                spSQL.AddParameter("@Contratado_Id", contratadoId);
                spSQL.AddParameter("@Solicitud_Prestamo_Key", solicitudPrestamoKey);
                spSQL.AddParameter("@Fecha_Solicitud", DateTime.Now);
                spSQL.AddParameter("@Monto_Solicitado", montoSolicitado);
                spSQL.AddParameter("@Monto_Prestado", 0);
                spSQL.AddParameter("@Notas_Solicitud", notasSolicitud);
                spSQL.AddParameter("@Estatus_Solicitud_Id", estatusSolicitudId);
                spSQL.AddParameter("@Fecha_Autorizacion_Rechazo", DateTime.Now);
                spSQL.AddParameter("@Autorizado_Rechazado_Por_Id", UserId);
                spSQL.AddParameter("@Notas_Autorizacion_Rechazo", notasAutorizacionRechazo);

                spSQL.AddParameter("@HTML", DBNull.Value);

                //Definición de parámetros de Sistema

                spSQL.AddParameter("@Mensaje_Sistema_Id", 1);
                spSQL.AddParameter("@Debug", 0);

                //Definición de dirección para parametros de salida
                spSQL.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;

                //Definición de tamaños de parametros de salida
                spSQL.Parameters["@Mensaje_Sistema_Id"].Size = 4;


                spSQL.ExecuteNonQuery();

                if (spSQL.Parameters["@Mensaje_Sistema_Id"].Value.ToString() != "1")
                {
                    mensajeSistema = SqlText.ExecuteScalar("SELECT Mensaje_Amigable_Usuario FROM dbo.Mensaje_Sistema WHERE Mensaje_Sistema_Id=" + spSQL.Parameters["@Mensaje_Sistema_Id"].Value.ToString()).ToString();
                    return false;
                }//if (spSQL.Parameters["@Mensaje_Sistema_Id"].Value.ToString() != "1")
                else
                {
                    mensajeSistema = "Solicitud creada con éxito";
                    return true;
                }//if (spSQL.Parameters["@Mensaje_Sistema_Id"].Value.ToString() != "1")

            }//using (SqlProcedure spSQL = new SqlProcedure("[dbo].[sp_Administrar_Solicitud_Prestamo]"))
        }//public bool AdministrarSolicitudPrestamo(int tipoOperacionId, int contratadoId, string notasSolicitud, out string mensajeSistema, out int mensajeSistemaId)
        public bool AdministrarSolicitudVacaciones(int tipoOperacionId, int contratadoSolicitudVacacionesId, string solicitudVacacionesKey, int contratadoId, DateTime fechaSolicitud, int diasSolicitados, DateTime fechaInicioVacaciones, DateTime fechaFinVacaciones, int estatusSolicitudId, DateTime fechaAutorizacionRechazo, string autorizadoRechazadoPorId, string notasAutorizacionRechazo, int diasAutorizados, DateTime fechaInicioVacacionesAutorizado, DateTime fechaFinVacacionesAutorizado, out string html, out string mensajeSistema, out int mensajeSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            html = "";
            using (SqlProcedure spSQL = new SqlProcedure("[dbo].[sp_Administrar_Solicitud_Vacaciones]"))
            {

                spSQL.Command.CommandTimeout = 60 * 2;

                //Definición parámetro para recibir el return
                spSQL.AddParameter("RetVal", 0);
                spSQL.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                spSQL.AddParameter("@Tipo_Operacion_Id", tipoOperacionId);
                spSQL.AddParameter("@Contratado_Solicitud_Vacaciones_Id", contratadoSolicitudVacacionesId);
                spSQL.AddParameter("@Solicitud_Vacaciones_Key", solicitudVacacionesKey);
                spSQL.AddParameter("@Contratado_Id", contratadoId);
                spSQL.AddParameter("@Fecha_Solicitud", fechaSolicitud);
                spSQL.AddParameter("@Dias_Solicitados", diasSolicitados);
                spSQL.AddParameter("@Fecha_Inicio_Vacaciones", fechaInicioVacaciones);
                spSQL.AddParameter("@Fecha_Fin_Vacaciones", fechaFinVacaciones);
                spSQL.AddParameter("@Estatus_Solicitud_Id", estatusSolicitudId);
                spSQL.AddParameter("@Fecha_Autorizacion_Rechazo", fechaAutorizacionRechazo);
                spSQL.AddParameter("@Autorizado_Rechazado_Por_Id", UserId);
                //spSQL.AddParameter("@Autorizado_Rechazado_Por_Id", autorizadoRechazadoPorId);
                spSQL.AddParameter("@Notas_Autorizacion_Rechazo", notasAutorizacionRechazo);
                spSQL.AddParameter("@Dias_Autorizados", diasAutorizados);
                spSQL.AddParameter("@Fecha_Inicio_Vacaciones_Autorizado", fechaInicioVacacionesAutorizado);
                spSQL.AddParameter("@Fecha_Fin_Vacaciones_Autorizado", fechaFinVacacionesAutorizado);
                spSQL.AddParameter("@HTML", html);
                //Definición de parámetros de Sistema
                spSQL.AddParameter("@Creado_Por_Id", UserId); //spSql.AddParameter("@Creado_Por_Id", UserId);
                spSQL.AddParameter("@Transaccion_Id", DBNull.Value);
                spSQL.AddParameter("@Fijar_Bitacora", 1);
                spSQL.AddParameter("@Mostrar_Tablas_Sistema", 0);
                spSQL.AddParameter("@Mensaje_Sistema_Id", 1);
                spSQL.AddParameter("@Simular", 0);
                spSQL.AddParameter("@Trace", "");
                spSQL.AddParameter("@Debug", 0);

                //Definición de dirección para parametros de salida
                spSQL.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                spSQL.Parameters["@Trace"].Direction = ParameterDirection.Output;
                spSQL.Parameters["@HTML"].Direction = ParameterDirection.Output;
                spSQL.ExecuteNonQuery();

                if (spSQL.Parameters["@Mensaje_Sistema_Id"].Value.ToString() != "1")
                {

                    mensajeSistemaId = 28;//Ocurrio un error
                                          //mensajeSistema = "Ocurrio un error al guardar la información de la solicitud de vacaciones";
                    mensajeSistema = SqlText.ExecuteScalar("SELECT Mensaje_Amigable_Usuario FROM dbo.Mensaje_Sistema WHERE Mensaje_Sistema_Id=" + spSQL.Parameters["@Mensaje_Sistema_Id"].Value.ToString()).ToString();
                    //Result.ShowAlert(ErrorMessage);
                    return false;

                }//if (spSql.Parameters["RetVal"].Value.ToString() != "1")
                else
                {
                    mensajeSistema = "Solicitud Creada Exitosamente";
                    return true;
                }//else if (spSql.Parameters["RetVal"].Value.ToString() != "1")

            }//  using (SqlProcedure spSQL = new SqlProcedure("[dbo].[sp_Administrar_Solicitud_Vacaciones]"))
             // return true;
        }//public bool AdministrarSolicitudVacaciones(int tipoOperacionId ,int contratadoSolicitudVacacionesId ,string solicitudVacacionesKey ,int contratadoId ,DateTime fechaSolicitud ,int diasSolicitados ,DateTime fechaInicioVacaciones ,DateTime fechaFinVacaciones ,int estatusSolicitudId ,DateTime fechaAutorizacionRechazo ,string autorizadoRechazadoPorId ,string notasAutorizacionRechazo,int diasAutorizados , out string mensajeSistema, out int mensajeSistemaId)


        //--------------------
    }

}
