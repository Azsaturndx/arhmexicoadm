using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using arhmexico.Data;

namespace arhmexico.Models
{
	public enum Publicacion_VacanteDataField
    {
        
        Publicacion_Vacante_Id,
        
        Publicacion_HTML,
        
        Liga_Publicacion,
        
        Canal_Publicacion_Id,
        
        Canal_Publicacion,
        
        Fecha_Publicacion,
        
        Estatus_Procesamiento_Id,
        
        Estatus_Procesamiento_Estatus_Procesamiento,
        
        Numero_Intentos,
        
        Mensaje_Sistema_Id,
        
        Mensaje_Sistema_Mensaje_Sistema,
        
        Transaccion_Id,
        
        Creado_Por_Id,
        
        cpUserName,
        
        Fecha_Creacion,
        
        Actualizado_Por_Id,
        
        apUserName,
        
        Fecha_Ultima_Actualizacion,
        
        Estatus_Registro_Id,
        
        Estatus_Registro_Estatus_Registro,
        
        VacanteId,
        
        Vacante,
        
        Publicacion_Texto,
        
        PublicacionVacanteKey,
    }
    
    public partial class Publicacion_VacanteModel : BusinessRulesObjectModel
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _publicacion_Vacante_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _publicacion_HTML;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _liga_Publicacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _canal_Publicacion_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _canal_Publicacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Publicacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Procesamiento_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Procesamiento_Estatus_Procesamiento;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _numero_Intentos;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _mensaje_Sistema_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mensaje_Sistema_Mensaje_Sistema;
        
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
        private int? _vacanteId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vacante;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _publicacion_Texto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _publicacionVacanteKey;
        
        public Publicacion_VacanteModel()
        {
        }
        
        public Publicacion_VacanteModel(BusinessRules r) : 
                base(r)
        {
        }
        
        public int? Publicacion_Vacante_Id
        {
            get
            {
                return _publicacion_Vacante_Id;
            }
            set
            {
                _publicacion_Vacante_Id = value;
                UpdateFieldValue("Publicacion_Vacante_Id", value);
            }
        }
        
        public string Publicacion_HTML
        {
            get
            {
                return _publicacion_HTML;
            }
            set
            {
                _publicacion_HTML = value;
                UpdateFieldValue("Publicacion_HTML", value);
            }
        }
        
        public string Liga_Publicacion
        {
            get
            {
                return _liga_Publicacion;
            }
            set
            {
                _liga_Publicacion = value;
                UpdateFieldValue("Liga_Publicacion", value);
            }
        }
        
        public int? Canal_Publicacion_Id
        {
            get
            {
                return _canal_Publicacion_Id;
            }
            set
            {
                _canal_Publicacion_Id = value;
                UpdateFieldValue("Canal_Publicacion_Id", value);
            }
        }
        
        public string Canal_Publicacion
        {
            get
            {
                return _canal_Publicacion;
            }
            set
            {
                _canal_Publicacion = value;
                UpdateFieldValue("Canal_Publicacion", value);
            }
        }
        
        public DateTime? Fecha_Publicacion
        {
            get
            {
                return _fecha_Publicacion;
            }
            set
            {
                _fecha_Publicacion = value;
                UpdateFieldValue("Fecha_Publicacion", value);
            }
        }
        
        public int? Estatus_Procesamiento_Id
        {
            get
            {
                return _estatus_Procesamiento_Id;
            }
            set
            {
                _estatus_Procesamiento_Id = value;
                UpdateFieldValue("Estatus_Procesamiento_Id", value);
            }
        }
        
        public string Estatus_Procesamiento_Estatus_Procesamiento
        {
            get
            {
                return _estatus_Procesamiento_Estatus_Procesamiento;
            }
            set
            {
                _estatus_Procesamiento_Estatus_Procesamiento = value;
                UpdateFieldValue("Estatus_Procesamiento_Estatus_Procesamiento", value);
            }
        }
        
        public int? Numero_Intentos
        {
            get
            {
                return _numero_Intentos;
            }
            set
            {
                _numero_Intentos = value;
                UpdateFieldValue("Numero_Intentos", value);
            }
        }
        
        public int? Mensaje_Sistema_Id
        {
            get
            {
                return _mensaje_Sistema_Id;
            }
            set
            {
                _mensaje_Sistema_Id = value;
                UpdateFieldValue("Mensaje_Sistema_Id", value);
            }
        }
        
        public string Mensaje_Sistema_Mensaje_Sistema
        {
            get
            {
                return _mensaje_Sistema_Mensaje_Sistema;
            }
            set
            {
                _mensaje_Sistema_Mensaje_Sistema = value;
                UpdateFieldValue("Mensaje_Sistema_Mensaje_Sistema", value);
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
        
        public int? VacanteId
        {
            get
            {
                return _vacanteId;
            }
            set
            {
                _vacanteId = value;
                UpdateFieldValue("VacanteId", value);
            }
        }
        
        public string Vacante
        {
            get
            {
                return _vacante;
            }
            set
            {
                _vacante = value;
                UpdateFieldValue("Vacante", value);
            }
        }
        
        public string Publicacion_Texto
        {
            get
            {
                return _publicacion_Texto;
            }
            set
            {
                _publicacion_Texto = value;
                UpdateFieldValue("Publicacion_Texto", value);
            }
        }
        
        public System.Guid? PublicacionVacanteKey
        {
            get
            {
                return _publicacionVacanteKey;
            }
            set
            {
                _publicacionVacanteKey = value;
                UpdateFieldValue("PublicacionVacanteKey", value);
            }
        }
        
        public FieldValue this[Publicacion_VacanteDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
