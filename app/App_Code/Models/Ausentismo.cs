using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using arhmexico.Data;

namespace arhmexico.Models
{
	public enum AusentismoDataField
    {
        
        Ausentismo_Id,
        
        Ausentismo,
        
        Tipo_Ausentismo_Id,
        
        Tipo_Ausentismo,
        
        Contratado_Id,
        
        Contratado_Identificador_Unico,
        
        Fecha_Solicitud_Ausentismo,
        
        Fecha_Inicio_Ausentismo,
        
        Fecha_Fin_Ausentismo,
        
        Dias_Ausentismo_Solicitados,
        
        Motivo_Ausentismo,
        
        Estatus_Ausentismo_Id,
        
        Estatus_Ausentismo,
        
        Fecha_Autorizacion_Rechazo,
        
        Autorizado_Rechazado_Por_Id,
        
        Notas_Autorizacion_Rechazo,
        
        Dias_Autorizados,
        
        Ausentismo_Key,
        
        Contratante_Id,
        
        Contratante_Contratante,
        
        Cliente_Id,
        
        Cliente_Cliente,
        
        Transaccion_Id,
        
        Creado_Por_Id,
        
        Creado_Por,
        
        Fecha_Creacion,
        
        Actualizado_Por_Id,
        
        Actualizado_Por,
        
        Fecha_Ultima_Actualizacion,
        
        Estatus_Registro_Id,
        
        Estatus_Registro_Estatus_Registro,
        
        Contratado_Solicitud_Vacaciones_Id,
        
        Solicitud_Vacaciones_Key,
        
        Es_Solicitud_Vacaciones,
        
        Fecha_Regreso_Vacaciones,
        
        Autorizado_Rechazado_Por,
    }
    
    public partial class AusentismoModel : BusinessRulesObjectModel
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _ausentismo_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ausentismo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Ausentismo_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Ausentismo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratado_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratado_Identificador_Unico;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Solicitud_Ausentismo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Inicio_Ausentismo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Fin_Ausentismo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte? _dias_Ausentismo_Solicitados;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _motivo_Ausentismo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Ausentismo_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Ausentismo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Autorizacion_Rechazo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _autorizado_Rechazado_Por_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _notas_Autorizacion_Rechazo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte? _dias_Autorizados;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ausentismo_Key;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratante_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante_Contratante;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _cliente_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cliente_Cliente;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transaccion_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _creado_Por_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _creado_Por;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Creacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _actualizado_Por_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _actualizado_Por;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Ultima_Actualizacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Registro_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Registro_Estatus_Registro;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratado_Solicitud_Vacaciones_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _solicitud_Vacaciones_Key;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Solicitud_Vacaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Regreso_Vacaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _autorizado_Rechazado_Por;
        
        public AusentismoModel()
        {
        }
        
        public AusentismoModel(BusinessRules r) : 
                base(r)
        {
        }
        
        public int? Ausentismo_Id
        {
            get
            {
                return _ausentismo_Id;
            }
            set
            {
                _ausentismo_Id = value;
                UpdateFieldValue("Ausentismo_Id", value);
            }
        }
        
        public string Ausentismo_
        {
            get
            {
                return _ausentismo;
            }
            set
            {
                _ausentismo = value;
                UpdateFieldValue("Ausentismo_", value);
            }
        }
        
        public int? Tipo_Ausentismo_Id
        {
            get
            {
                return _tipo_Ausentismo_Id;
            }
            set
            {
                _tipo_Ausentismo_Id = value;
                UpdateFieldValue("Tipo_Ausentismo_Id", value);
            }
        }
        
        public string Tipo_Ausentismo
        {
            get
            {
                return _tipo_Ausentismo;
            }
            set
            {
                _tipo_Ausentismo = value;
                UpdateFieldValue("Tipo_Ausentismo", value);
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
        
        public string Contratado_Identificador_Unico
        {
            get
            {
                return _contratado_Identificador_Unico;
            }
            set
            {
                _contratado_Identificador_Unico = value;
                UpdateFieldValue("Contratado_Identificador_Unico", value);
            }
        }
        
        public DateTime? Fecha_Solicitud_Ausentismo
        {
            get
            {
                return _fecha_Solicitud_Ausentismo;
            }
            set
            {
                _fecha_Solicitud_Ausentismo = value;
                UpdateFieldValue("Fecha_Solicitud_Ausentismo", value);
            }
        }
        
        public DateTime? Fecha_Inicio_Ausentismo
        {
            get
            {
                return _fecha_Inicio_Ausentismo;
            }
            set
            {
                _fecha_Inicio_Ausentismo = value;
                UpdateFieldValue("Fecha_Inicio_Ausentismo", value);
            }
        }
        
        public DateTime? Fecha_Fin_Ausentismo
        {
            get
            {
                return _fecha_Fin_Ausentismo;
            }
            set
            {
                _fecha_Fin_Ausentismo = value;
                UpdateFieldValue("Fecha_Fin_Ausentismo", value);
            }
        }
        
        public byte? Dias_Ausentismo_Solicitados
        {
            get
            {
                return _dias_Ausentismo_Solicitados;
            }
            set
            {
                _dias_Ausentismo_Solicitados = value;
                UpdateFieldValue("Dias_Ausentismo_Solicitados", value);
            }
        }
        
        public string Motivo_Ausentismo
        {
            get
            {
                return _motivo_Ausentismo;
            }
            set
            {
                _motivo_Ausentismo = value;
                UpdateFieldValue("Motivo_Ausentismo", value);
            }
        }
        
        public int? Estatus_Ausentismo_Id
        {
            get
            {
                return _estatus_Ausentismo_Id;
            }
            set
            {
                _estatus_Ausentismo_Id = value;
                UpdateFieldValue("Estatus_Ausentismo_Id", value);
            }
        }
        
        public string Estatus_Ausentismo
        {
            get
            {
                return _estatus_Ausentismo;
            }
            set
            {
                _estatus_Ausentismo = value;
                UpdateFieldValue("Estatus_Ausentismo", value);
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
        
        public byte? Dias_Autorizados
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
        
        public string Ausentismo_Key
        {
            get
            {
                return _ausentismo_Key;
            }
            set
            {
                _ausentismo_Key = value;
                UpdateFieldValue("Ausentismo_Key", value);
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
        
        public string Contratante_Contratante
        {
            get
            {
                return _contratante_Contratante;
            }
            set
            {
                _contratante_Contratante = value;
                UpdateFieldValue("Contratante_Contratante", value);
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
        
        public string Creado_Por
        {
            get
            {
                return _creado_Por;
            }
            set
            {
                _creado_Por = value;
                UpdateFieldValue("Creado_Por", value);
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
        
        public string Actualizado_Por
        {
            get
            {
                return _actualizado_Por;
            }
            set
            {
                _actualizado_Por = value;
                UpdateFieldValue("Actualizado_Por", value);
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
        
        public bool? Es_Solicitud_Vacaciones
        {
            get
            {
                return _es_Solicitud_Vacaciones;
            }
            set
            {
                _es_Solicitud_Vacaciones = value;
                UpdateFieldValue("Es_Solicitud_Vacaciones", value);
            }
        }
        
        public DateTime? Fecha_Regreso_Vacaciones
        {
            get
            {
                return _fecha_Regreso_Vacaciones;
            }
            set
            {
                _fecha_Regreso_Vacaciones = value;
                UpdateFieldValue("Fecha_Regreso_Vacaciones", value);
            }
        }
        
        public string Autorizado_Rechazado_Por
        {
            get
            {
                return _autorizado_Rechazado_Por;
            }
            set
            {
                _autorizado_Rechazado_Por = value;
                UpdateFieldValue("Autorizado_Rechazado_Por", value);
            }
        }
        
        public FieldValue this[AusentismoDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
