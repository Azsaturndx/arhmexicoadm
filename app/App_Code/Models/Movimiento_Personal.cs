using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using arhmexico.Data;

namespace arhmexico.Models
{
	public enum Movimiento_PersonalDataField
    {
        
        Movimiento_Personal_Id,
        
        Tipo_Movimiento_Personal_Id,
        
        TipoMovimientoPersonalTipoMovimientoPersonal,
        
        Contratado_Id,
        
        Fecha_Movimiento_Personal,
        
        Motivo_Movimiento_Personal_Id,
        
        Motivo_Movimiento_Personal_Motivo_Movimiento_Personal,
        
        Pagadora_Id,
        
        Pagadora_Pagadora,
        
        Contratante_Puesto_Id,
        
        Contratante_Puesto_Contratante_Puesto,
        
        Contratante_Id,
        
        Contratante_Contratante,
        
        Cliente_Id,
        
        Cliente,
        
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
        
        PersonaId,
        
        Pagadora_Nueva_Id,
        
        Pagadora,
        
        Contratante_Puesto_Nuevo_Id,
        
        ContratantePuestocontratantePuesto,
        
        Contratante_Nuevo_Id,
        
        Contratante,
        
        Cliente_Nuevo_Id,
        
        Cliente1,
        
        Mostrar_En_Historial,
    }
    
    public partial class Movimiento_PersonalModel : BusinessRulesObjectModel
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _movimiento_Personal_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Movimiento_Personal_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipoMovimientoPersonalTipoMovimientoPersonal;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratado_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Movimiento_Personal;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _motivo_Movimiento_Personal_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _motivo_Movimiento_Personal_Motivo_Movimiento_Personal;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _pagadora_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pagadora_Pagadora;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratante_Puesto_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante_Puesto_Contratante_Puesto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratante_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante_Contratante;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _cliente_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cliente;
        
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
        private int? _personaId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _pagadora_Nueva_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pagadora;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratante_Puesto_Nuevo_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratantePuestocontratantePuesto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratante_Nuevo_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _cliente_Nuevo_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cliente1;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _mostrar_En_Historial;
        
        public Movimiento_PersonalModel()
        {
        }
        
        public Movimiento_PersonalModel(BusinessRules r) : 
                base(r)
        {
        }
        
        public int? Movimiento_Personal_Id
        {
            get
            {
                return _movimiento_Personal_Id;
            }
            set
            {
                _movimiento_Personal_Id = value;
                UpdateFieldValue("Movimiento_Personal_Id", value);
            }
        }
        
        public int? Tipo_Movimiento_Personal_Id
        {
            get
            {
                return _tipo_Movimiento_Personal_Id;
            }
            set
            {
                _tipo_Movimiento_Personal_Id = value;
                UpdateFieldValue("Tipo_Movimiento_Personal_Id", value);
            }
        }
        
        public string TipoMovimientoPersonalTipoMovimientoPersonal
        {
            get
            {
                return _tipoMovimientoPersonalTipoMovimientoPersonal;
            }
            set
            {
                _tipoMovimientoPersonalTipoMovimientoPersonal = value;
                UpdateFieldValue("TipoMovimientoPersonalTipoMovimientoPersonal", value);
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
        
        public DateTime? Fecha_Movimiento_Personal
        {
            get
            {
                return _fecha_Movimiento_Personal;
            }
            set
            {
                _fecha_Movimiento_Personal = value;
                UpdateFieldValue("Fecha_Movimiento_Personal", value);
            }
        }
        
        public int? Motivo_Movimiento_Personal_Id
        {
            get
            {
                return _motivo_Movimiento_Personal_Id;
            }
            set
            {
                _motivo_Movimiento_Personal_Id = value;
                UpdateFieldValue("Motivo_Movimiento_Personal_Id", value);
            }
        }
        
        public string Motivo_Movimiento_Personal_Motivo_Movimiento_Personal
        {
            get
            {
                return _motivo_Movimiento_Personal_Motivo_Movimiento_Personal;
            }
            set
            {
                _motivo_Movimiento_Personal_Motivo_Movimiento_Personal = value;
                UpdateFieldValue("Motivo_Movimiento_Personal_Motivo_Movimiento_Personal", value);
            }
        }
        
        public int? Pagadora_Id
        {
            get
            {
                return _pagadora_Id;
            }
            set
            {
                _pagadora_Id = value;
                UpdateFieldValue("Pagadora_Id", value);
            }
        }
        
        public string Pagadora_Pagadora
        {
            get
            {
                return _pagadora_Pagadora;
            }
            set
            {
                _pagadora_Pagadora = value;
                UpdateFieldValue("Pagadora_Pagadora", value);
            }
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
        
        public string Contratante_Puesto_Contratante_Puesto
        {
            get
            {
                return _contratante_Puesto_Contratante_Puesto;
            }
            set
            {
                _contratante_Puesto_Contratante_Puesto = value;
                UpdateFieldValue("Contratante_Puesto_Contratante_Puesto", value);
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
        
        public string Cliente
        {
            get
            {
                return _cliente;
            }
            set
            {
                _cliente = value;
                UpdateFieldValue("Cliente", value);
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
        
        public int? PersonaId
        {
            get
            {
                return _personaId;
            }
            set
            {
                _personaId = value;
                UpdateFieldValue("PersonaId", value);
            }
        }
        
        public int? Pagadora_Nueva_Id
        {
            get
            {
                return _pagadora_Nueva_Id;
            }
            set
            {
                _pagadora_Nueva_Id = value;
                UpdateFieldValue("Pagadora_Nueva_Id", value);
            }
        }
        
        public string Pagadora
        {
            get
            {
                return _pagadora;
            }
            set
            {
                _pagadora = value;
                UpdateFieldValue("Pagadora", value);
            }
        }
        
        public int? Contratante_Puesto_Nuevo_Id
        {
            get
            {
                return _contratante_Puesto_Nuevo_Id;
            }
            set
            {
                _contratante_Puesto_Nuevo_Id = value;
                UpdateFieldValue("Contratante_Puesto_Nuevo_Id", value);
            }
        }
        
        public string ContratantePuestocontratantePuesto
        {
            get
            {
                return _contratantePuestocontratantePuesto;
            }
            set
            {
                _contratantePuestocontratantePuesto = value;
                UpdateFieldValue("ContratantePuestocontratantePuesto", value);
            }
        }
        
        public int? Contratante_Nuevo_Id
        {
            get
            {
                return _contratante_Nuevo_Id;
            }
            set
            {
                _contratante_Nuevo_Id = value;
                UpdateFieldValue("Contratante_Nuevo_Id", value);
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
        
        public int? Cliente_Nuevo_Id
        {
            get
            {
                return _cliente_Nuevo_Id;
            }
            set
            {
                _cliente_Nuevo_Id = value;
                UpdateFieldValue("Cliente_Nuevo_Id", value);
            }
        }
        
        public string Cliente1
        {
            get
            {
                return _cliente1;
            }
            set
            {
                _cliente1 = value;
                UpdateFieldValue("Cliente1", value);
            }
        }
        
        public bool? Mostrar_En_Historial
        {
            get
            {
                return _mostrar_En_Historial;
            }
            set
            {
                _mostrar_En_Historial = value;
                UpdateFieldValue("Mostrar_En_Historial", value);
            }
        }
        
        public FieldValue this[Movimiento_PersonalDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
