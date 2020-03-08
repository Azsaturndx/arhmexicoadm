using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using arhmexico.Data;

namespace arhmexico.Models
{
	public enum Contratante_PuestoDataField
    {
        
        Contratante_Puesto_Id,
        
        Contratante_Puesto,
        
        Contratante_Id,
        
        Contratante_Puesto_Padre_Id,
        
        Contratante_Puesto_Descripcion,
        
        Cliente_Id,
        
        Transaccion_Id,
        
        Creado_Por_Id,
        
        cpUserName,
        
        Fecha_Creacion,
        
        Actualizado_Por_Id,
        
        apUserName,
        
        Fecha_Ultima_Actualizacion,
        
        Estatus_Registro_Id,
        
        Estatus_Registro_Estatus_Registro,
        
        Estatus_Puesto_Estatus_Puesto,
        
        Estatus_Puesto_Id,
        
        Contratante_Estructura_Organizacional_Id,
        
        Contratante_Estructura_Organizacional,
        
        ConsecutivoContratantePuestoId,
        
        Cliente_Nombre,
        
        Contratante_Puesto_Padre,
        
        Contratado_Id,
        
        Contratado,
        
        UserId,
        
        Asignado,
        
        Contratante_Puesto_Consecutivo,
        
        Leyenda_Puesto_Contratante,
    }
    
    public partial class Contratante_PuestoModel : BusinessRulesObjectModel
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratante_Puesto_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante_Puesto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratante_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratante_Puesto_Padre_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante_Puesto_Descripcion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _cliente_Id;
        
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
        private string _estatus_Puesto_Estatus_Puesto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Puesto_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratante_Estructura_Organizacional_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante_Estructura_Organizacional;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _consecutivoContratantePuestoId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cliente_Nombre;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante_Puesto_Padre;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratado_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _userId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _asignado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante_Puesto_Consecutivo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _leyenda_Puesto_Contratante;
        
        public Contratante_PuestoModel()
        {
        }
        
        public Contratante_PuestoModel(BusinessRules r) : 
                base(r)
        {
        }
        
        public int? Contratante_Puesto_Id
        {
            get
            {
                return _contratante_Puesto_Id;
            }
            set
            {
                _contratante_Puesto_Id = value;
                UpdateFieldValue("Contratante_Puesto_Id", value);
            }
        }
        
        public string Contratante_Puesto_
        {
            get
            {
                return _contratante_Puesto;
            }
            set
            {
                _contratante_Puesto = value;
                UpdateFieldValue("Contratante_Puesto_", value);
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
        
        public int? Contratante_Puesto_Padre_Id
        {
            get
            {
                return _contratante_Puesto_Padre_Id;
            }
            set
            {
                _contratante_Puesto_Padre_Id = value;
                UpdateFieldValue("Contratante_Puesto_Padre_Id", value);
            }
        }
        
        public string Contratante_Puesto_Descripcion
        {
            get
            {
                return _contratante_Puesto_Descripcion;
            }
            set
            {
                _contratante_Puesto_Descripcion = value;
                UpdateFieldValue("Contratante_Puesto_Descripcion", value);
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
        
        public string Estatus_Puesto_Estatus_Puesto
        {
            get
            {
                return _estatus_Puesto_Estatus_Puesto;
            }
            set
            {
                _estatus_Puesto_Estatus_Puesto = value;
                UpdateFieldValue("Estatus_Puesto_Estatus_Puesto", value);
            }
        }
        
        public int? Estatus_Puesto_Id
        {
            get
            {
                return _estatus_Puesto_Id;
            }
            set
            {
                _estatus_Puesto_Id = value;
                UpdateFieldValue("Estatus_Puesto_Id", value);
            }
        }
        
        public int? Contratante_Estructura_Organizacional_Id
        {
            get
            {
                return _contratante_Estructura_Organizacional_Id;
            }
            set
            {
                _contratante_Estructura_Organizacional_Id = value;
                UpdateFieldValue("Contratante_Estructura_Organizacional_Id", value);
            }
        }
        
        public string Contratante_Estructura_Organizacional
        {
            get
            {
                return _contratante_Estructura_Organizacional;
            }
            set
            {
                _contratante_Estructura_Organizacional = value;
                UpdateFieldValue("Contratante_Estructura_Organizacional", value);
            }
        }
        
        public int? ConsecutivoContratantePuestoId
        {
            get
            {
                return _consecutivoContratantePuestoId;
            }
            set
            {
                _consecutivoContratantePuestoId = value;
                UpdateFieldValue("ConsecutivoContratantePuestoId", value);
            }
        }
        
        public string Cliente_Nombre
        {
            get
            {
                return _cliente_Nombre;
            }
            set
            {
                _cliente_Nombre = value;
                UpdateFieldValue("Cliente_Nombre", value);
            }
        }
        
        public string Contratante_Puesto_Padre
        {
            get
            {
                return _contratante_Puesto_Padre;
            }
            set
            {
                _contratante_Puesto_Padre = value;
                UpdateFieldValue("Contratante_Puesto_Padre", value);
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
        
        public string Contratado
        {
            get
            {
                return _contratado;
            }
            set
            {
                _contratado = value;
                UpdateFieldValue("Contratado", value);
            }
        }
        
        public string UserId
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
        
        public bool? Asignado
        {
            get
            {
                return _asignado;
            }
            set
            {
                _asignado = value;
                UpdateFieldValue("Asignado", value);
            }
        }
        
        public string Contratante_Puesto_Consecutivo
        {
            get
            {
                return _contratante_Puesto_Consecutivo;
            }
            set
            {
                _contratante_Puesto_Consecutivo = value;
                UpdateFieldValue("Contratante_Puesto_Consecutivo", value);
            }
        }
        
        public string Leyenda_Puesto_Contratante
        {
            get
            {
                return _leyenda_Puesto_Contratante;
            }
            set
            {
                _leyenda_Puesto_Contratante = value;
                UpdateFieldValue("Leyenda_Puesto_Contratante", value);
            }
        }
        
        public FieldValue this[Contratante_PuestoDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
