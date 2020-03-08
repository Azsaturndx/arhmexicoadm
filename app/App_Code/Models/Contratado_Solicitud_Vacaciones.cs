using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using arhmexico.Data;

namespace arhmexico.Models
{
	public enum Contratado_Solicitud_VacacionesDataField
    {
        
        Contratado_Solicitud_Vacaciones_Id,
        
        Contratado_Id,
        
        Contratante_Id,
        
        Persona_V_Persona_Nombre,
        
        Fecha_Solicitud,
        
        Dias_Solicitados,
        
        Fecha_Inicio_Vacaciones,
        
        Fecha_Fin_Vacaciones,
        
        Estatus_Solicitud_Id,
        
        Estatus_Solicitud_Estatus_Solicitud,
        
        Fecha_Autorizacion_Rechazo,
        
        Autorizado_Rechazado_Por_Id,
        
        arpUserName,
        
        Notas_Autorizacion_Rechazo,
        
        Dias_Autorizados,
        
        Solicitud_Vacaciones_Key,
        
        Transaccion_Id,
        
        Creado_Por_Id,
        
        cpUserName,
        
        Fecha_Creacion,
        
        Actualizado_Por_Id,
        
        apUserName,
        
        Fecha_Ultima_Actualizacion,
        
        Estatus_Registro_Id,
        
        Estatus_Registro_Estatus_Registro,
        
        Tipo_Prestacion_Id,
        
        Fecha_Inicio_Vacaciones_Autorizado,
        
        Fecha_Fin_Vacaciones_Autorizado,
        
        Permite_Cancelar_Solicitud_Vacaciones,
        
        Mostrar_Boton_Autorizar_Solicitud_Vacaciones,
        
        Mostrar_Boton_Rechazar_Solicitud_Vacaciones,
    }
    
    public partial class Contratado_Solicitud_VacacionesModel : BusinessRulesObjectModel
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratado_Solicitud_Vacaciones_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratado_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratante_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _persona_V_Persona_Nombre;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Solicitud;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _dias_Solicitados;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Inicio_Vacaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Fin_Vacaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Solicitud_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Solicitud_Estatus_Solicitud;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Autorizacion_Rechazo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _autorizado_Rechazado_Por_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _arpUserName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _notas_Autorizacion_Rechazo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _dias_Autorizados;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _solicitud_Vacaciones_Key;
        
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
        private int? _tipo_Prestacion_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Inicio_Vacaciones_Autorizado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Fin_Vacaciones_Autorizado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _permite_Cancelar_Solicitud_Vacaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _mostrar_Boton_Autorizar_Solicitud_Vacaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _mostrar_Boton_Rechazar_Solicitud_Vacaciones;
        
        public Contratado_Solicitud_VacacionesModel()
        {
        }
        
        public Contratado_Solicitud_VacacionesModel(BusinessRules r) : 
                base(r)
        {
        }
        
        public int? Contratado_Solicitud_Vacaciones_Id
        {
            get
            {
                return _contratado_Solicitud_Vacaciones_Id;
            }
            set
            {
                _contratado_Solicitud_Vacaciones_Id = value;
                UpdateFieldValue("Contratado_Solicitud_Vacaciones_Id", value);
            }
        }
        
        public int? Contratado_Id
        {
            get
            {
                return _contratado_Id;
            }
            set
            {
                _contratado_Id = value;
                UpdateFieldValue("Contratado_Id", value);
            }
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
        
        public string Persona_V_Persona_Nombre
        {
            get
            {
                return _persona_V_Persona_Nombre;
            }
            set
            {
                _persona_V_Persona_Nombre = value;
                UpdateFieldValue("Persona_V_Persona_Nombre", value);
            }
        }
        
        public DateTime? Fecha_Solicitud
        {
            get
            {
                return _fecha_Solicitud;
            }
            set
            {
                _fecha_Solicitud = value;
                UpdateFieldValue("Fecha_Solicitud", value);
            }
        }
        
        public int? Dias_Solicitados
        {
            get
            {
                return _dias_Solicitados;
            }
            set
            {
                _dias_Solicitados = value;
                UpdateFieldValue("Dias_Solicitados", value);
            }
        }
        
        public DateTime? Fecha_Inicio_Vacaciones
        {
            get
            {
                return _fecha_Inicio_Vacaciones;
            }
            set
            {
                _fecha_Inicio_Vacaciones = value;
                UpdateFieldValue("Fecha_Inicio_Vacaciones", value);
            }
        }
        
        public DateTime? Fecha_Fin_Vacaciones
        {
            get
            {
                return _fecha_Fin_Vacaciones;
            }
            set
            {
                _fecha_Fin_Vacaciones = value;
                UpdateFieldValue("Fecha_Fin_Vacaciones", value);
            }
        }
        
        public int? Estatus_Solicitud_Id
        {
            get
            {
                return _estatus_Solicitud_Id;
            }
            set
            {
                _estatus_Solicitud_Id = value;
                UpdateFieldValue("Estatus_Solicitud_Id", value);
            }
        }
        
        public string Estatus_Solicitud_Estatus_Solicitud
        {
            get
            {
                return _estatus_Solicitud_Estatus_Solicitud;
            }
            set
            {
                _estatus_Solicitud_Estatus_Solicitud = value;
                UpdateFieldValue("Estatus_Solicitud_Estatus_Solicitud", value);
            }
        }
        
        public DateTime? Fecha_Autorizacion_Rechazo
        {
            get
            {
                return _fecha_Autorizacion_Rechazo;
            }
            set
            {
                _fecha_Autorizacion_Rechazo = value;
                UpdateFieldValue("Fecha_Autorizacion_Rechazo", value);
            }
        }
        
        public System.Guid? Autorizado_Rechazado_Por_Id
        {
            get
            {
                return _autorizado_Rechazado_Por_Id;
            }
            set
            {
                _autorizado_Rechazado_Por_Id = value;
                UpdateFieldValue("Autorizado_Rechazado_Por_Id", value);
            }
        }
        
        public string arpUserName
        {
            get
            {
                return _arpUserName;
            }
            set
            {
                _arpUserName = value;
                UpdateFieldValue("arpUserName", value);
            }
        }
        
        public string Notas_Autorizacion_Rechazo
        {
            get
            {
                return _notas_Autorizacion_Rechazo;
            }
            set
            {
                _notas_Autorizacion_Rechazo = value;
                UpdateFieldValue("Notas_Autorizacion_Rechazo", value);
            }
        }
        
        public int? Dias_Autorizados
        {
            get
            {
                return _dias_Autorizados;
            }
            set
            {
                _dias_Autorizados = value;
                UpdateFieldValue("Dias_Autorizados", value);
            }
        }
        
        public string Solicitud_Vacaciones_Key
        {
            get
            {
                return _solicitud_Vacaciones_Key;
            }
            set
            {
                _solicitud_Vacaciones_Key = value;
                UpdateFieldValue("Solicitud_Vacaciones_Key", value);
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
        
        public int? Tipo_Prestacion_Id
        {
            get
            {
                return _tipo_Prestacion_Id;
            }
            set
            {
                _tipo_Prestacion_Id = value;
                UpdateFieldValue("Tipo_Prestacion_Id", value);
            }
        }
        
        public DateTime? Fecha_Inicio_Vacaciones_Autorizado
        {
            get
            {
                return _fecha_Inicio_Vacaciones_Autorizado;
            }
            set
            {
                _fecha_Inicio_Vacaciones_Autorizado = value;
                UpdateFieldValue("Fecha_Inicio_Vacaciones_Autorizado", value);
            }
        }
        
        public DateTime? Fecha_Fin_Vacaciones_Autorizado
        {
            get
            {
                return _fecha_Fin_Vacaciones_Autorizado;
            }
            set
            {
                _fecha_Fin_Vacaciones_Autorizado = value;
                UpdateFieldValue("Fecha_Fin_Vacaciones_Autorizado", value);
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
        
        public bool? Mostrar_Boton_Autorizar_Solicitud_Vacaciones
        {
            get
            {
                return _mostrar_Boton_Autorizar_Solicitud_Vacaciones;
            }
            set
            {
                _mostrar_Boton_Autorizar_Solicitud_Vacaciones = value;
                UpdateFieldValue("Mostrar_Boton_Autorizar_Solicitud_Vacaciones", value);
            }
        }
        
        public bool? Mostrar_Boton_Rechazar_Solicitud_Vacaciones
        {
            get
            {
                return _mostrar_Boton_Rechazar_Solicitud_Vacaciones;
            }
            set
            {
                _mostrar_Boton_Rechazar_Solicitud_Vacaciones = value;
                UpdateFieldValue("Mostrar_Boton_Rechazar_Solicitud_Vacaciones", value);
            }
        }
        
        public FieldValue this[Contratado_Solicitud_VacacionesDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
