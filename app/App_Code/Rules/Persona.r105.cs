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
	public partial class PersonaBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "EXECCS01".
        /// </summary>
        [Rule("r105")]
        public void r105Implementation(PersonaModel instance)
        {
            // This is the placeholder for method implementation.
            using (SqlProcedure sql = new SqlProcedure("dbo.sp_Administrar_Persona_Contacto"))
            {
                sql.Command.CommandTimeout = 60 * 10;
                //Definición parametro especial para recibir el RETURN del SP
                sql.AddParameter("RetVal", 0);
                sql.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                //Definición de Parametros especificos del SP 
                // 
                //sql.AddParameter("@Producto_Nombre", instance.Producto_);

                sql.AddParameter("@Tipo_Operacion_Id", 1);// 1. INSERT
                sql.AddParameter("@Nombre", instance.Nombre);
                sql.AddParameter("@Apellido_Paterno", instance.Apellido_Paterno);
                sql.AddParameter("@Apellido_Materno", instance.Apellido_Materno);
                sql.AddParameter("@Segundo_Nombre", instance.Segundo_Nombre);
                sql.AddParameter("@Fecha_Nacimiento", instance.Fecha_Nacimiento);
                sql.AddParameter("@Maximo_Nivel_Escolaridad_Id", instance.Maximo_Nivel_Escolaridad_Id);
                sql.AddParameter("@Genero_Persona_Id", instance.Genero_Persona_Id);
                sql.AddParameter("@Correo_Personal", instance.Correo_Personal);
                sql.AddParameter("@Numero_Celular_Personal", instance.Numero_Celular_Personal);
                //-------------------------               
                //Definición de parámetros de Salida
                sql.AddParameter("@Persona_Jefe_Id", instance.Persona_Id);

                //Definición de parametros de Sistema
                sql.AddParameter("@Creado_Por_Id", UserId);
                sql.AddParameter("@Transaccion_Id", DBNull.Value);
                sql.AddParameter("@Fijar_Bitacora", 1);
                sql.AddParameter("@Mostrar_Tablas_Sistema", 0);
                sql.AddParameter("@Mensaje_Sistema_Id", 0);
                sql.AddParameter("@Simular", 0);
                sql.AddParameter("@Trace", "");
                sql.AddParameter("@Debug", 0);

                //Definición de dirección para parametros de salida
                //sql.Parameters["@Persona_Domicilio_Id"].Direction = ParameterDirection.Output;
                sql.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                sql.Parameters["@Trace"].Direction = ParameterDirection.Output;

                //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                 
                sql.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                sql.Parameters["@Trace"].Size = 8000;

                sql.ExecuteNonQuery();

                if (sql.Parameters["RetVal"].Value.ToString() != "1")
                {
                    String ErrorMessage = SqlText.ExecuteScalar("SELECT Mensaje_Amigable_Usuario FROM dbo.Mensaje_Sistema WHERE Mensaje_Sistema_Id=" + sql.Parameters["@Mensaje_Sistema_Id"].Value.ToString()).ToString();
                    Result.ShowAlert(ErrorMessage);
                }
                else
                {
                    Result.Continue();
                }
            }// using (SqlProcedure sql = new SqlProcedure("dbo.sp_Administrar_Persona_Contacto"))

            /*
                bool resultadoAdministrarPersonaContacto;
                string mensajeSistema = "";
                int mensajeSistemaId = 0;
                int tipoOperacionId = 1;
                string nombre = instance.Nombre;
                string apellidoPaterno = instance.Apellido_Paterno;
                string apellidoMaterno = instance.Apellido_Materno;
                string segundoNombre = instance.Segundo_Nombre;
                DateTime fechaNacimiento = (DateTime)instance.Fecha_Nacimiento;
                int maximoNivelEscolaridadId = (int)instance.Maximo_Nivel_Escolaridad_Id;
                int generoPersonaId = (int)instance.Genero_Persona_Id;
                string correoPersonal = instance.Correo_Personal;
                string numeroCelularPersonal = instance.Numero_Celular_Personal;
                int personaId = 0;
                SharedBusinessRules sb = new SharedBusinessRules();

                resultadoAdministrarPersonaContacto = sb.AdministrarPersonaContacto(
                                                                                            tipoOperacionId
                                                                                            , nombre
                                                                                            , apellidoPaterno
                                                                                            , apellidoMaterno
                                                                                            , segundoNombre
                                                                                            , fechaNacimiento
                                                                                            , maximoNivelEscolaridadId
                                                                                            , generoPersonaId
                                                                                            , correoPersonal
                                                                                            , numeroCelularPersonal
                                                                                            , out personaId
                                                                                            , out mensajeSistema
                                                                                            , out mensajeSistemaId
                                                                            );
                if (resultadoAdministrarPersonaContacto)
                {
                    //Result.ShowAlert(mensajeSistema);
                    Result.Continue();
                    // Result.Refresh();
                }//if (resultadoAdministrarPersonaContacto)
                else//if (!resultadoAdministrarPersonaContacto)
                {
                    Result.ShowAlert(mensajeSistema);
                }//if (!resultadoAdministrarPersonaContacto)
            */
        }
    }
}
