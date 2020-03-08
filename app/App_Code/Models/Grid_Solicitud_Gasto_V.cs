using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using arhmexico.Data;

namespace arhmexico.Models
{
	public enum Grid_Solicitud_Gasto_VDataField
    {
        
        Administracion_Gasto_Id,
        
        Estatus_Solicitud_Id,
        
        Estatus_Solicitud,
        
        Monto_Gasto,
        
        Monto_Gasto_Autorizado,
        
        Solicitud_Gasto_Key,
        
        Autorizado_Rechazado_Por_Id,
        
        Comentarios_Autorizacion_Rechazo,
        
        Fecha_Solicitud,
    }
    
    public partial class Grid_Solicitud_Gasto_VModel : BusinessRulesObjectModel
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _administracion_Gasto_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Solicitud_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Solicitud;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _monto_Gasto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _monto_Gasto_Autorizado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _solicitud_Gasto_Key;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _autorizado_Rechazado_Por_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _comentarios_Autorizacion_Rechazo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Solicitud;
        
        public Grid_Solicitud_Gasto_VModel()
        {
        }
        
        public Grid_Solicitud_Gasto_VModel(BusinessRules r) : 
                base(r)
        {
        }
        
        public int? Administracion_Gasto_Id
        {
            get
            {
                return _administracion_Gasto_Id;
            }
            set
            {
                _administracion_Gasto_Id = value;
                UpdateFieldValue("Administracion_Gasto_Id", value);
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
        
        public string Estatus_Solicitud
        {
            get
            {
                return _estatus_Solicitud;
            }
            set
            {
                _estatus_Solicitud = value;
                UpdateFieldValue("Estatus_Solicitud", value);
            }
        }
        
        public decimal? Monto_Gasto
        {
            get
            {
                return _monto_Gasto;
            }
            set
            {
                _monto_Gasto = value;
                UpdateFieldValue("Monto_Gasto", value);
            }
        }
        
        public decimal? Monto_Gasto_Autorizado
        {
            get
            {
                return _monto_Gasto_Autorizado;
            }
            set
            {
                _monto_Gasto_Autorizado = value;
                UpdateFieldValue("Monto_Gasto_Autorizado", value);
            }
        }
        
        public string Solicitud_Gasto_Key
        {
            get
            {
                return _solicitud_Gasto_Key;
            }
            set
            {
                _solicitud_Gasto_Key = value;
                UpdateFieldValue("Solicitud_Gasto_Key", value);
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
        
        public string Comentarios_Autorizacion_Rechazo
        {
            get
            {
                return _comentarios_Autorizacion_Rechazo;
            }
            set
            {
                _comentarios_Autorizacion_Rechazo = value;
                UpdateFieldValue("Comentarios_Autorizacion_Rechazo", value);
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
        
        public FieldValue this[Grid_Solicitud_Gasto_VDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
