using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using arhmexico.Data;

namespace arhmexico.Models
{
	public enum Contratado_Solicitud_PrestamoDataField
    {
        
        Contratado_Solicitud_Prestamo_Id,
        
        Contratado_Id,
        
        Contratado_Identificador_Unico,
        
        Notas_Solicitud,
        
        Solicitud_Prestamo_Key,
        
        Fecha_Solicitud,
        
        Estatus_Solicitud_Id,
        
        Estatus_Solicitud_Estatus_Solicitud,
        
        Fecha_Autorizacion_Rechazo,
        
        AutorizadoPorusername,
        
        Notas_Autorizacion_Rechazo,
        
        Transaccion_Id,
        
        CreadoPorusername,
        
        Fecha_Creacion,
        
        ActualizadoPorusername,
        
        Fecha_Ultima_Actualizacion,
        
        Estatus_Registro_Id,
        
        Estatus_Registro_Estatus_Registro,
        
        MontoSolicitado,
        
        MontoPrestado,
    }
    
    public partial class Contratado_Solicitud_PrestamoModel : BusinessRulesObjectModel
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratado_Solicitud_Prestamo_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratado_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratado_Identificador_Unico;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _notas_Solicitud;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _solicitud_Prestamo_Key;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Solicitud;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Solicitud_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Solicitud_Estatus_Solicitud;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Autorizacion_Rechazo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _autorizadoPorusername;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _notas_Autorizacion_Rechazo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transaccion_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _creadoPorusername;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Creacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _actualizadoPorusername;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Ultima_Actualizacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Registro_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Registro_Estatus_Registro;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _montoSolicitado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _montoPrestado;
        
        public Contratado_Solicitud_PrestamoModel()
        {
        }
        
        public Contratado_Solicitud_PrestamoModel(BusinessRules r) : 
                base(r)
        {
        }
        
        public int? Contratado_Solicitud_Prestamo_Id
        {
            get
            {
                return _contratado_Solicitud_Prestamo_Id;
            }
            set
            {
                _contratado_Solicitud_Prestamo_Id = value;
                UpdateFieldValue("Contratado_Solicitud_Prestamo_Id", value);
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
        
        public string Notas_Solicitud
        {
            get
            {
                return _notas_Solicitud;
            }
            set
            {
                _notas_Solicitud = value;
                UpdateFieldValue("Notas_Solicitud", value);
            }
        }
        
        public System.Guid? Solicitud_Prestamo_Key
        {
            get
            {
                return _solicitud_Prestamo_Key;
            }
            set
            {
                _solicitud_Prestamo_Key = value;
                UpdateFieldValue("Solicitud_Prestamo_Key", value);
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
        
        public string AutorizadoPorusername
        {
            get
            {
                return _autorizadoPorusername;
            }
            set
            {
                _autorizadoPorusername = value;
                UpdateFieldValue("AutorizadoPorusername", value);
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
        
        public string CreadoPorusername
        {
            get
            {
                return _creadoPorusername;
            }
            set
            {
                _creadoPorusername = value;
                UpdateFieldValue("CreadoPorusername", value);
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
        
        public string ActualizadoPorusername
        {
            get
            {
                return _actualizadoPorusername;
            }
            set
            {
                _actualizadoPorusername = value;
                UpdateFieldValue("ActualizadoPorusername", value);
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
        
        public decimal? MontoSolicitado
        {
            get
            {
                return _montoSolicitado;
            }
            set
            {
                _montoSolicitado = value;
                UpdateFieldValue("MontoSolicitado", value);
            }
        }
        
        public decimal? MontoPrestado
        {
            get
            {
                return _montoPrestado;
            }
            set
            {
                _montoPrestado = value;
                UpdateFieldValue("MontoPrestado", value);
            }
        }
        
        public FieldValue this[Contratado_Solicitud_PrestamoDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
