using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using arhmexico.Data;

namespace arhmexico.Models
{
	public enum Contratante_AdminDataField
    {
        
        Contratante_Id,
        
        Contratante,
        
        Contratante_Razon_Social,
        
        Contratante_Descripcion,
        
        Cliente_Id,
        
        Cliente_Cliente,
        
        Transaccion_Id,
        
        Creado_Por_Id,
        
        cpUserName,
        
        Fecha_Creacion,
        
        Actualizado_Por_Id,
        
        apUserName,
        
        Fecha_Ultima_Actualizacion,
        
        Estatus_Registro_Id,
        
        Estatus_Registro_Estatus_Registro,
        
        Persona_Nombre,
        
        Contratado_Encargado_RH_Id,
        
        Clave_Contratante,
        
        Vigencia_Dias,
        
        Nombre_Dominio,
        
        Mostrar_Religion_A_Aspirante,
        
        Mostrar_Orientacion_Sexual_A_Aspirante,
        
        Mostrar_Senas_Particulares_A_Aspirante,
        
        Permite_Cancelar_Solicitud_Vacaciones,
        
        Layout_Correo_Electronico_Contratado_Id,
        
        LayoutCorreoElectronicoContratado,
        
        Layout_Correo_Electronico_Jefe_Id,
        
        LayoutCorreoElectronicoJefe,
        
        Layout_Correo_Electronico_RH_Respuesta_Solicitud_Vacaciones_Id,
        
        LayoutCorreoElectronicoRHRespuestaSolicitudVacaciones,
        
        Layout_Correo_Electronico_RH_Solicitud_Vacaciones_Id,
        
        LayoutCorreoElectronicoRHSolicitudVacaciones,
        
        Generar_Usuario_Generico,
        
        Permitir_Solicitar_Gastos,
        
        Numero_Telefono,
        
        Permite_Solicitar_Prestamos,
        
        Contratado_Encargado_Prestamos_Id,
        
        Antiguedad_Minima_Pedir_Prestamo,
        
        Layout_Correo_Electronico_Contratado_Solicitud_Prestamo_Id,
        
        Layout_Correo_Electronico_Encargado_Prestamo_Id,
        
        Layout_Correo_Electronico_RH_Solicitud_Prestamo_Id,
        
        Layout_Correo_Electronico_RH_Respuesta_Solicitud_Prestamo_Id,
        
        LayoutCorreoElectronicoJefeNotificacionCancelacionId,
        
        ValidarVacacionesAlPasado,
        
        ValidarVacacionesDiaActual,
        
        UserId,
        
        Permite_Enviar_Correo_Recibo_Nomina,
        
        Nombre_Completo_Encargado_Prestamos,
        
        Layout_Correo_Electronico_Contratado_Solicitud_Prestamo,
        
        Layout_Correo_Electronico_Encargado_Prestamo,
        
        Layout_Correo_Electronico_RH_Solicitud_Prestamo,
        
        Layout_Correo_Electronico_RH_Respuesta_Solicitud_Prestamo,
        
        Layout_Correo_Electronico_Recibo_Nomina_Id,
        
        Layout_Correo_Electronico_Recibo_Nomina,
        
        Validar_Vacaciones_Al_Pasado,
        
        Validar_Vacaciones_Dia_Actual,
        
        Layout_Correo_Electronico_Jefe_Notificacion_Cancelacion_Id,
        
        Layout_Correo_Electronico_Jefe_Notificacion_Cancelacion,
        
        Acceso_Servicio_ARH_Vacaciones,
        
        Acceso_Servicio_ARH_Nomina,
        
        Acceso_Servicio_ARH_Gastos,
        
        Acceso_Servicio_ARH_Prestamos,
        
        Acceso_Servicio_ARH_Documentos,
    }
    
    public partial class Contratante_AdminModel : BusinessRulesObjectModel
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratante_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante_Razon_Social;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante_Descripcion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _cliente_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cliente_Cliente;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transaccion_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _creado_Por_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cpUserName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Creacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _actualizado_Por_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _apUserName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Ultima_Actualizacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Registro_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Registro_Estatus_Registro;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _persona_Nombre;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratado_Encargado_RH_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _clave_Contratante;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _vigencia_Dias;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nombre_Dominio;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _mostrar_Religion_A_Aspirante;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _mostrar_Orientacion_Sexual_A_Aspirante;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _mostrar_Senas_Particulares_A_Aspirante;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _permite_Cancelar_Solicitud_Vacaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _layout_Correo_Electronico_Contratado_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _layoutCorreoElectronicoContratado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _layout_Correo_Electronico_Jefe_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _layoutCorreoElectronicoJefe;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _layout_Correo_Electronico_RH_Respuesta_Solicitud_Vacaciones_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _layoutCorreoElectronicoRHRespuestaSolicitudVacaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _layout_Correo_Electronico_RH_Solicitud_Vacaciones_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _layoutCorreoElectronicoRHSolicitudVacaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _generar_Usuario_Generico;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _permitir_Solicitar_Gastos;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _numero_Telefono;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _permite_Solicitar_Prestamos;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratado_Encargado_Prestamos_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _antiguedad_Minima_Pedir_Prestamo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _layout_Correo_Electronico_Contratado_Solicitud_Prestamo_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _layout_Correo_Electronico_Encargado_Prestamo_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _layout_Correo_Electronico_RH_Solicitud_Prestamo_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _layout_Correo_Electronico_RH_Respuesta_Solicitud_Prestamo_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _layoutCorreoElectronicoJefeNotificacionCancelacionId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _validarVacacionesAlPasado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _validarVacacionesDiaActual;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _userId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _permite_Enviar_Correo_Recibo_Nomina;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nombre_Completo_Encargado_Prestamos;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _layout_Correo_Electronico_Contratado_Solicitud_Prestamo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _layout_Correo_Electronico_Encargado_Prestamo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _layout_Correo_Electronico_RH_Solicitud_Prestamo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _layout_Correo_Electronico_RH_Respuesta_Solicitud_Prestamo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _layout_Correo_Electronico_Recibo_Nomina_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _layout_Correo_Electronico_Recibo_Nomina;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _validar_Vacaciones_Al_Pasado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _validar_Vacaciones_Dia_Actual;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _layout_Correo_Electronico_Jefe_Notificacion_Cancelacion_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _layout_Correo_Electronico_Jefe_Notificacion_Cancelacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _acceso_Servicio_ARH_Vacaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _acceso_Servicio_ARH_Nomina;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _acceso_Servicio_ARH_Gastos;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _acceso_Servicio_ARH_Prestamos;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _acceso_Servicio_ARH_Documentos;
        
        public Contratante_AdminModel()
        {
        }
        
        public Contratante_AdminModel(BusinessRules r) : 
                base(r)
        {
        }
        
        public int? Contratante_Id
        {
            get
            {
                return _contratante_Id;
            }
            set
            {
                _contratante_Id = value;
                UpdateFieldValue("Contratante_Id", value);
            }
        }
        
        public string Contratante
        {
            get
            {
                return _contratante;
            }
            set
            {
                _contratante = value;
                UpdateFieldValue("Contratante", value);
            }
        }
        
        public string Contratante_Razon_Social
        {
            get
            {
                return _contratante_Razon_Social;
            }
            set
            {
                _contratante_Razon_Social = value;
                UpdateFieldValue("Contratante_Razon_Social", value);
            }
        }
        
        public string Contratante_Descripcion
        {
            get
            {
                return _contratante_Descripcion;
            }
            set
            {
                _contratante_Descripcion = value;
                UpdateFieldValue("Contratante_Descripcion", value);
            }
        }
        
        public int? Cliente_Id
        {
            get
            {
                return _cliente_Id;
            }
            set
            {
                _cliente_Id = value;
                UpdateFieldValue("Cliente_Id", value);
            }
        }
        
        public string Cliente_Cliente
        {
            get
            {
                return _cliente_Cliente;
            }
            set
            {
                _cliente_Cliente = value;
                UpdateFieldValue("Cliente_Cliente", value);
            }
        }
        
        public string Transaccion_Id
        {
            get
            {
                return _transaccion_Id;
            }
            set
            {
                _transaccion_Id = value;
                UpdateFieldValue("Transaccion_Id", value);
            }
        }
        
        public System.Guid? Creado_Por_Id
        {
            get
            {
                return _creado_Por_Id;
            }
            set
            {
                _creado_Por_Id = value;
                UpdateFieldValue("Creado_Por_Id", value);
            }
        }
        
        public string cpUserName
        {
            get
            {
                return _cpUserName;
            }
            set
            {
                _cpUserName = value;
                UpdateFieldValue("cpUserName", value);
            }
        }
        
        public DateTime? Fecha_Creacion
        {
            get
            {
                return _fecha_Creacion;
            }
            set
            {
                _fecha_Creacion = value;
                UpdateFieldValue("Fecha_Creacion", value);
            }
        }
        
        public System.Guid? Actualizado_Por_Id
        {
            get
            {
                return _actualizado_Por_Id;
            }
            set
            {
                _actualizado_Por_Id = value;
                UpdateFieldValue("Actualizado_Por_Id", value);
            }
        }
        
        public string apUserName
        {
            get
            {
                return _apUserName;
            }
            set
            {
                _apUserName = value;
                UpdateFieldValue("apUserName", value);
            }
        }
        
        public DateTime? Fecha_Ultima_Actualizacion
        {
            get
            {
                return _fecha_Ultima_Actualizacion;
            }
            set
            {
                _fecha_Ultima_Actualizacion = value;
                UpdateFieldValue("Fecha_Ultima_Actualizacion", value);
            }
        }
        
        public int? Estatus_Registro_Id
        {
            get
            {
                return _estatus_Registro_Id;
            }
            set
            {
                _estatus_Registro_Id = value;
                UpdateFieldValue("Estatus_Registro_Id", value);
            }
        }
        
        public string Estatus_Registro_Estatus_Registro
        {
            get
            {
                return _estatus_Registro_Estatus_Registro;
            }
            set
            {
                _estatus_Registro_Estatus_Registro = value;
                UpdateFieldValue("Estatus_Registro_Estatus_Registro", value);
            }
        }
        
        public string Persona_Nombre
        {
            get
            {
                return _persona_Nombre;
            }
            set
            {
                _persona_Nombre = value;
                UpdateFieldValue("Persona_Nombre", value);
            }
        }
        
        public int? Contratado_Encargado_RH_Id
        {
            get
            {
                return _contratado_Encargado_RH_Id;
            }
            set
            {
                _contratado_Encargado_RH_Id = value;
                UpdateFieldValue("Contratado_Encargado_RH_Id", value);
            }
        }
        
        public string Clave_Contratante
        {
            get
            {
                return _clave_Contratante;
            }
            set
            {
                _clave_Contratante = value;
                UpdateFieldValue("Clave_Contratante", value);
            }
        }
        
        public int? Vigencia_Dias
        {
            get
            {
                return _vigencia_Dias;
            }
            set
            {
                _vigencia_Dias = value;
                UpdateFieldValue("Vigencia_Dias", value);
            }
        }
        
        public string Nombre_Dominio
        {
            get
            {
                return _nombre_Dominio;
            }
            set
            {
                _nombre_Dominio = value;
                UpdateFieldValue("Nombre_Dominio", value);
            }
        }
        
        public bool? Mostrar_Religion_A_Aspirante
        {
            get
            {
                return _mostrar_Religion_A_Aspirante;
            }
            set
            {
                _mostrar_Religion_A_Aspirante = value;
                UpdateFieldValue("Mostrar_Religion_A_Aspirante", value);
            }
        }
        
        public bool? Mostrar_Orientacion_Sexual_A_Aspirante
        {
            get
            {
                return _mostrar_Orientacion_Sexual_A_Aspirante;
            }
            set
            {
                _mostrar_Orientacion_Sexual_A_Aspirante = value;
                UpdateFieldValue("Mostrar_Orientacion_Sexual_A_Aspirante", value);
            }
        }
        
        public bool? Mostrar_Senas_Particulares_A_Aspirante
        {
            get
            {
                return _mostrar_Senas_Particulares_A_Aspirante;
            }
            set
            {
                _mostrar_Senas_Particulares_A_Aspirante = value;
                UpdateFieldValue("Mostrar_Senas_Particulares_A_Aspirante", value);
            }
        }
        
        public bool? Permite_Cancelar_Solicitud_Vacaciones
        {
            get
            {
                return _permite_Cancelar_Solicitud_Vacaciones;
            }
            set
            {
                _permite_Cancelar_Solicitud_Vacaciones = value;
                UpdateFieldValue("Permite_Cancelar_Solicitud_Vacaciones", value);
            }
        }
        
        public int? Layout_Correo_Electronico_Contratado_Id
        {
            get
            {
                return _layout_Correo_Electronico_Contratado_Id;
            }
            set
            {
                _layout_Correo_Electronico_Contratado_Id = value;
                UpdateFieldValue("Layout_Correo_Electronico_Contratado_Id", value);
            }
        }
        
        public string LayoutCorreoElectronicoContratado
        {
            get
            {
                return _layoutCorreoElectronicoContratado;
            }
            set
            {
                _layoutCorreoElectronicoContratado = value;
                UpdateFieldValue("LayoutCorreoElectronicoContratado", value);
            }
        }
        
        public int? Layout_Correo_Electronico_Jefe_Id
        {
            get
            {
                return _layout_Correo_Electronico_Jefe_Id;
            }
            set
            {
                _layout_Correo_Electronico_Jefe_Id = value;
                UpdateFieldValue("Layout_Correo_Electronico_Jefe_Id", value);
            }
        }
        
        public string LayoutCorreoElectronicoJefe
        {
            get
            {
                return _layoutCorreoElectronicoJefe;
            }
            set
            {
                _layoutCorreoElectronicoJefe = value;
                UpdateFieldValue("LayoutCorreoElectronicoJefe", value);
            }
        }
        
        public int? Layout_Correo_Electronico_RH_Respuesta_Solicitud_Vacaciones_Id
        {
            get
            {
                return _layout_Correo_Electronico_RH_Respuesta_Solicitud_Vacaciones_Id;
            }
            set
            {
                _layout_Correo_Electronico_RH_Respuesta_Solicitud_Vacaciones_Id = value;
                UpdateFieldValue("Layout_Correo_Electronico_RH_Respuesta_Solicitud_Vacaciones_Id", value);
            }
        }
        
        public string LayoutCorreoElectronicoRHRespuestaSolicitudVacaciones
        {
            get
            {
                return _layoutCorreoElectronicoRHRespuestaSolicitudVacaciones;
            }
            set
            {
                _layoutCorreoElectronicoRHRespuestaSolicitudVacaciones = value;
                UpdateFieldValue("LayoutCorreoElectronicoRHRespuestaSolicitudVacaciones", value);
            }
        }
        
        public int? Layout_Correo_Electronico_RH_Solicitud_Vacaciones_Id
        {
            get
            {
                return _layout_Correo_Electronico_RH_Solicitud_Vacaciones_Id;
            }
            set
            {
                _layout_Correo_Electronico_RH_Solicitud_Vacaciones_Id = value;
                UpdateFieldValue("Layout_Correo_Electronico_RH_Solicitud_Vacaciones_Id", value);
            }
        }
        
        public string LayoutCorreoElectronicoRHSolicitudVacaciones
        {
            get
            {
                return _layoutCorreoElectronicoRHSolicitudVacaciones;
            }
            set
            {
                _layoutCorreoElectronicoRHSolicitudVacaciones = value;
                UpdateFieldValue("LayoutCorreoElectronicoRHSolicitudVacaciones", value);
            }
        }
        
        public bool? Generar_Usuario_Generico
        {
            get
            {
                return _generar_Usuario_Generico;
            }
            set
            {
                _generar_Usuario_Generico = value;
                UpdateFieldValue("Generar_Usuario_Generico", value);
            }
        }
        
        public bool? Permitir_Solicitar_Gastos
        {
            get
            {
                return _permitir_Solicitar_Gastos;
            }
            set
            {
                _permitir_Solicitar_Gastos = value;
                UpdateFieldValue("Permitir_Solicitar_Gastos", value);
            }
        }
        
        public string Numero_Telefono
        {
            get
            {
                return _numero_Telefono;
            }
            set
            {
                _numero_Telefono = value;
                UpdateFieldValue("Numero_Telefono", value);
            }
        }
        
        public bool? Permite_Solicitar_Prestamos
        {
            get
            {
                return _permite_Solicitar_Prestamos;
            }
            set
            {
                _permite_Solicitar_Prestamos = value;
                UpdateFieldValue("Permite_Solicitar_Prestamos", value);
            }
        }
        
        public int? Contratado_Encargado_Prestamos_Id
        {
            get
            {
                return _contratado_Encargado_Prestamos_Id;
            }
            set
            {
                _contratado_Encargado_Prestamos_Id = value;
                UpdateFieldValue("Contratado_Encargado_Prestamos_Id", value);
            }
        }
        
        public int? Antiguedad_Minima_Pedir_Prestamo
        {
            get
            {
                return _antiguedad_Minima_Pedir_Prestamo;
            }
            set
            {
                _antiguedad_Minima_Pedir_Prestamo = value;
                UpdateFieldValue("Antiguedad_Minima_Pedir_Prestamo", value);
            }
        }
        
        public int? Layout_Correo_Electronico_Contratado_Solicitud_Prestamo_Id
        {
            get
            {
                return _layout_Correo_Electronico_Contratado_Solicitud_Prestamo_Id;
            }
            set
            {
                _layout_Correo_Electronico_Contratado_Solicitud_Prestamo_Id = value;
                UpdateFieldValue("Layout_Correo_Electronico_Contratado_Solicitud_Prestamo_Id", value);
            }
        }
        
        public int? Layout_Correo_Electronico_Encargado_Prestamo_Id
        {
            get
            {
                return _layout_Correo_Electronico_Encargado_Prestamo_Id;
            }
            set
            {
                _layout_Correo_Electronico_Encargado_Prestamo_Id = value;
                UpdateFieldValue("Layout_Correo_Electronico_Encargado_Prestamo_Id", value);
            }
        }
        
        public int? Layout_Correo_Electronico_RH_Solicitud_Prestamo_Id
        {
            get
            {
                return _layout_Correo_Electronico_RH_Solicitud_Prestamo_Id;
            }
            set
            {
                _layout_Correo_Electronico_RH_Solicitud_Prestamo_Id = value;
                UpdateFieldValue("Layout_Correo_Electronico_RH_Solicitud_Prestamo_Id", value);
            }
        }
        
        public int? Layout_Correo_Electronico_RH_Respuesta_Solicitud_Prestamo_Id
        {
            get
            {
                return _layout_Correo_Electronico_RH_Respuesta_Solicitud_Prestamo_Id;
            }
            set
            {
                _layout_Correo_Electronico_RH_Respuesta_Solicitud_Prestamo_Id = value;
                UpdateFieldValue("Layout_Correo_Electronico_RH_Respuesta_Solicitud_Prestamo_Id", value);
            }
        }
        
        public int? LayoutCorreoElectronicoJefeNotificacionCancelacionId
        {
            get
            {
                return _layoutCorreoElectronicoJefeNotificacionCancelacionId;
            }
            set
            {
                _layoutCorreoElectronicoJefeNotificacionCancelacionId = value;
                UpdateFieldValue("LayoutCorreoElectronicoJefeNotificacionCancelacionId", value);
            }
        }
        
        public bool? ValidarVacacionesAlPasado
        {
            get
            {
                return _validarVacacionesAlPasado;
            }
            set
            {
                _validarVacacionesAlPasado = value;
                UpdateFieldValue("ValidarVacacionesAlPasado", value);
            }
        }
        
        public bool? ValidarVacacionesDiaActual
        {
            get
            {
                return _validarVacacionesDiaActual;
            }
            set
            {
                _validarVacacionesDiaActual = value;
                UpdateFieldValue("ValidarVacacionesDiaActual", value);
            }
        }
        
        public System.Guid? UserId
        {
            get
            {
                return _userId;
            }
            set
            {
                _userId = value;
                UpdateFieldValue("UserId", value);
            }
        }
        
        public bool? Permite_Enviar_Correo_Recibo_Nomina
        {
            get
            {
                return _permite_Enviar_Correo_Recibo_Nomina;
            }
            set
            {
                _permite_Enviar_Correo_Recibo_Nomina = value;
                UpdateFieldValue("Permite_Enviar_Correo_Recibo_Nomina", value);
            }
        }
        
        public string Nombre_Completo_Encargado_Prestamos
        {
            get
            {
                return _nombre_Completo_Encargado_Prestamos;
            }
            set
            {
                _nombre_Completo_Encargado_Prestamos = value;
                UpdateFieldValue("Nombre_Completo_Encargado_Prestamos", value);
            }
        }
        
        public string Layout_Correo_Electronico_Contratado_Solicitud_Prestamo
        {
            get
            {
                return _layout_Correo_Electronico_Contratado_Solicitud_Prestamo;
            }
            set
            {
                _layout_Correo_Electronico_Contratado_Solicitud_Prestamo = value;
                UpdateFieldValue("Layout_Correo_Electronico_Contratado_Solicitud_Prestamo", value);
            }
        }
        
        public string Layout_Correo_Electronico_Encargado_Prestamo
        {
            get
            {
                return _layout_Correo_Electronico_Encargado_Prestamo;
            }
            set
            {
                _layout_Correo_Electronico_Encargado_Prestamo = value;
                UpdateFieldValue("Layout_Correo_Electronico_Encargado_Prestamo", value);
            }
        }
        
        public string Layout_Correo_Electronico_RH_Solicitud_Prestamo
        {
            get
            {
                return _layout_Correo_Electronico_RH_Solicitud_Prestamo;
            }
            set
            {
                _layout_Correo_Electronico_RH_Solicitud_Prestamo = value;
                UpdateFieldValue("Layout_Correo_Electronico_RH_Solicitud_Prestamo", value);
            }
        }
        
        public string Layout_Correo_Electronico_RH_Respuesta_Solicitud_Prestamo
        {
            get
            {
                return _layout_Correo_Electronico_RH_Respuesta_Solicitud_Prestamo;
            }
            set
            {
                _layout_Correo_Electronico_RH_Respuesta_Solicitud_Prestamo = value;
                UpdateFieldValue("Layout_Correo_Electronico_RH_Respuesta_Solicitud_Prestamo", value);
            }
        }
        
        public int? Layout_Correo_Electronico_Recibo_Nomina_Id
        {
            get
            {
                return _layout_Correo_Electronico_Recibo_Nomina_Id;
            }
            set
            {
                _layout_Correo_Electronico_Recibo_Nomina_Id = value;
                UpdateFieldValue("Layout_Correo_Electronico_Recibo_Nomina_Id", value);
            }
        }
        
        public string Layout_Correo_Electronico_Recibo_Nomina
        {
            get
            {
                return _layout_Correo_Electronico_Recibo_Nomina;
            }
            set
            {
                _layout_Correo_Electronico_Recibo_Nomina = value;
                UpdateFieldValue("Layout_Correo_Electronico_Recibo_Nomina", value);
            }
        }
        
        public bool? Validar_Vacaciones_Al_Pasado
        {
            get
            {
                return _validar_Vacaciones_Al_Pasado;
            }
            set
            {
                _validar_Vacaciones_Al_Pasado = value;
                UpdateFieldValue("Validar_Vacaciones_Al_Pasado", value);
            }
        }
        
        public bool? Validar_Vacaciones_Dia_Actual
        {
            get
            {
                return _validar_Vacaciones_Dia_Actual;
            }
            set
            {
                _validar_Vacaciones_Dia_Actual = value;
                UpdateFieldValue("Validar_Vacaciones_Dia_Actual", value);
            }
        }
        
        public int? Layout_Correo_Electronico_Jefe_Notificacion_Cancelacion_Id
        {
            get
            {
                return _layout_Correo_Electronico_Jefe_Notificacion_Cancelacion_Id;
            }
            set
            {
                _layout_Correo_Electronico_Jefe_Notificacion_Cancelacion_Id = value;
                UpdateFieldValue("Layout_Correo_Electronico_Jefe_Notificacion_Cancelacion_Id", value);
            }
        }
        
        public string Layout_Correo_Electronico_Jefe_Notificacion_Cancelacion
        {
            get
            {
                return _layout_Correo_Electronico_Jefe_Notificacion_Cancelacion;
            }
            set
            {
                _layout_Correo_Electronico_Jefe_Notificacion_Cancelacion = value;
                UpdateFieldValue("Layout_Correo_Electronico_Jefe_Notificacion_Cancelacion", value);
            }
        }
        
        public bool? Acceso_Servicio_ARH_Vacaciones
        {
            get
            {
                return _acceso_Servicio_ARH_Vacaciones;
            }
            set
            {
                _acceso_Servicio_ARH_Vacaciones = value;
                UpdateFieldValue("Acceso_Servicio_ARH_Vacaciones", value);
            }
        }
        
        public bool? Acceso_Servicio_ARH_Nomina
        {
            get
            {
                return _acceso_Servicio_ARH_Nomina;
            }
            set
            {
                _acceso_Servicio_ARH_Nomina = value;
                UpdateFieldValue("Acceso_Servicio_ARH_Nomina", value);
            }
        }
        
        public bool? Acceso_Servicio_ARH_Gastos
        {
            get
            {
                return _acceso_Servicio_ARH_Gastos;
            }
            set
            {
                _acceso_Servicio_ARH_Gastos = value;
                UpdateFieldValue("Acceso_Servicio_ARH_Gastos", value);
            }
        }
        
        public bool? Acceso_Servicio_ARH_Prestamos
        {
            get
            {
                return _acceso_Servicio_ARH_Prestamos;
            }
            set
            {
                _acceso_Servicio_ARH_Prestamos = value;
                UpdateFieldValue("Acceso_Servicio_ARH_Prestamos", value);
            }
        }
        
        public bool? Acceso_Servicio_ARH_Documentos
        {
            get
            {
                return _acceso_Servicio_ARH_Documentos;
            }
            set
            {
                _acceso_Servicio_ARH_Documentos = value;
                UpdateFieldValue("Acceso_Servicio_ARH_Documentos", value);
            }
        }
        
        public FieldValue this[Contratante_AdminDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
