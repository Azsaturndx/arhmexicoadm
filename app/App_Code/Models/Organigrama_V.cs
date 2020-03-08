using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using arhmexico.Data;

namespace arhmexico.Models
{
	public enum Organigrama_VDataField
    {
        
        Organigrama_Id,
        
        Contratante_Id,
        
        Contratante,
        
        Contratante_Estructura_Organizacional_Id,
        
        Contratante_Estructura_Organizacional_Estructura_Organizacional,
        
        Permitir_Asociar_Personal,
        
        Estructura_Organizacional_Padre_Id,
        
        Contratante_Estructura_Organizacional1_Estructura_Organizacional,
        
        Contratante_Puesto_Id,
        
        Contratante_Puesto_Contratante_Puesto,
        
        Contratante_Puesto_Padre_Id,
        
        Contratante_Puesto1_Contratante_Puesto,
        
        Contratado_Id,
        
        Persona_Id,
        
        Persona_Nombre,
        
        Nombre,
        
        Segundo_Nombre,
        
        Apellido_Paterno,
        
        Apellido_Materno,
        
        Tipo_Organigrama_Id,
        
        Organigrama_Estructura_Id,
        
        Organigrama_Estructura,
        
        Organigrama_Puesto_Id,
        
        Organigrama_Puesto,
        
        Nivel,
        
        Organigrama_Cliente_Id,
        
        Organigrama_Cliente,
        
        Organigrama_Contratante_Id,
        
        Organigrama_Contratante,
        
        Organigrama_Puesto_Id_1,
        
        Organigrama_Estructura_Id_1,
    }
    
    public partial class Organigrama_VModel : BusinessRulesObjectModel
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _organigrama_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratante_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratante_Estructura_Organizacional_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante_Estructura_Organizacional_Estructura_Organizacional;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _permitir_Asociar_Personal;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estructura_Organizacional_Padre_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante_Estructura_Organizacional1_Estructura_Organizacional;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratante_Puesto_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante_Puesto_Contratante_Puesto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratante_Puesto_Padre_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante_Puesto1_Contratante_Puesto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratado_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _persona_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _persona_Nombre;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nombre;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _segundo_Nombre;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _apellido_Paterno;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _apellido_Materno;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _tipo_Organigrama_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _organigrama_Estructura_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _organigrama_Estructura;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _organigrama_Puesto_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _organigrama_Puesto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _nivel;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _organigrama_Cliente_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _organigrama_Cliente;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _organigrama_Contratante_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _organigrama_Contratante;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _organigrama_Puesto_Id_1;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _organigrama_Estructura_Id_1;
        
        public Organigrama_VModel()
        {
        }
        
        public Organigrama_VModel(BusinessRules r) : 
                base(r)
        {
        }
        
        public long? Organigrama_Id
        {
            get
            {
                return _organigrama_Id;
            }
            set
            {
                _organigrama_Id = value;
                UpdateFieldValue("Organigrama_Id", value);
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
        
        public string Contratante_Estructura_Organizacional_Estructura_Organizacional
        {
            get
            {
                return _contratante_Estructura_Organizacional_Estructura_Organizacional;
            }
            set
            {
                _contratante_Estructura_Organizacional_Estructura_Organizacional = value;
                UpdateFieldValue("Contratante_Estructura_Organizacional_Estructura_Organizacional", value);
            }
        }
        
        public bool? Permitir_Asociar_Personal
        {
            get
            {
                return _permitir_Asociar_Personal;
            }
            set
            {
                _permitir_Asociar_Personal = value;
                UpdateFieldValue("Permitir_Asociar_Personal", value);
            }
        }
        
        public int? Estructura_Organizacional_Padre_Id
        {
            get
            {
                return _estructura_Organizacional_Padre_Id;
            }
            set
            {
                _estructura_Organizacional_Padre_Id = value;
                UpdateFieldValue("Estructura_Organizacional_Padre_Id", value);
            }
        }
        
        public string Contratante_Estructura_Organizacional1_Estructura_Organizacional
        {
            get
            {
                return _contratante_Estructura_Organizacional1_Estructura_Organizacional;
            }
            set
            {
                _contratante_Estructura_Organizacional1_Estructura_Organizacional = value;
                UpdateFieldValue("Contratante_Estructura_Organizacional1_Estructura_Organizacional", value);
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
        
        public string Contratante_Puesto1_Contratante_Puesto
        {
            get
            {
                return _contratante_Puesto1_Contratante_Puesto;
            }
            set
            {
                _contratante_Puesto1_Contratante_Puesto = value;
                UpdateFieldValue("Contratante_Puesto1_Contratante_Puesto", value);
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
        
        public int? Persona_Id
        {
            get
            {
                return _persona_Id;
            }
            set
            {
                _persona_Id = value;
                UpdateFieldValue("Persona_Id", value);
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
        
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
                UpdateFieldValue("Nombre", value);
            }
        }
        
        public string Segundo_Nombre
        {
            get
            {
                return _segundo_Nombre;
            }
            set
            {
                _segundo_Nombre = value;
                UpdateFieldValue("Segundo_Nombre", value);
            }
        }
        
        public string Apellido_Paterno
        {
            get
            {
                return _apellido_Paterno;
            }
            set
            {
                _apellido_Paterno = value;
                UpdateFieldValue("Apellido_Paterno", value);
            }
        }
        
        public string Apellido_Materno
        {
            get
            {
                return _apellido_Materno;
            }
            set
            {
                _apellido_Materno = value;
                UpdateFieldValue("Apellido_Materno", value);
            }
        }
        
        public short? Tipo_Organigrama_Id
        {
            get
            {
                return _tipo_Organigrama_Id;
            }
            set
            {
                _tipo_Organigrama_Id = value;
                UpdateFieldValue("Tipo_Organigrama_Id", value);
            }
        }
        
        public int? Organigrama_Estructura_Id
        {
            get
            {
                return _organigrama_Estructura_Id;
            }
            set
            {
                _organigrama_Estructura_Id = value;
                UpdateFieldValue("Organigrama_Estructura_Id", value);
            }
        }
        
        public string Organigrama_Estructura
        {
            get
            {
                return _organigrama_Estructura;
            }
            set
            {
                _organigrama_Estructura = value;
                UpdateFieldValue("Organigrama_Estructura", value);
            }
        }
        
        public int? Organigrama_Puesto_Id
        {
            get
            {
                return _organigrama_Puesto_Id;
            }
            set
            {
                _organigrama_Puesto_Id = value;
                UpdateFieldValue("Organigrama_Puesto_Id", value);
            }
        }
        
        public string Organigrama_Puesto
        {
            get
            {
                return _organigrama_Puesto;
            }
            set
            {
                _organigrama_Puesto = value;
                UpdateFieldValue("Organigrama_Puesto", value);
            }
        }
        
        public int? Nivel
        {
            get
            {
                return _nivel;
            }
            set
            {
                _nivel = value;
                UpdateFieldValue("Nivel", value);
            }
        }
        
        public int? Organigrama_Cliente_Id
        {
            get
            {
                return _organigrama_Cliente_Id;
            }
            set
            {
                _organigrama_Cliente_Id = value;
                UpdateFieldValue("Organigrama_Cliente_Id", value);
            }
        }
        
        public string Organigrama_Cliente
        {
            get
            {
                return _organigrama_Cliente;
            }
            set
            {
                _organigrama_Cliente = value;
                UpdateFieldValue("Organigrama_Cliente", value);
            }
        }
        
        public int? Organigrama_Contratante_Id
        {
            get
            {
                return _organigrama_Contratante_Id;
            }
            set
            {
                _organigrama_Contratante_Id = value;
                UpdateFieldValue("Organigrama_Contratante_Id", value);
            }
        }
        
        public string Organigrama_Contratante
        {
            get
            {
                return _organigrama_Contratante;
            }
            set
            {
                _organigrama_Contratante = value;
                UpdateFieldValue("Organigrama_Contratante", value);
            }
        }
        
        public int? Organigrama_Puesto_Id_1
        {
            get
            {
                return _organigrama_Puesto_Id_1;
            }
            set
            {
                _organigrama_Puesto_Id_1 = value;
                UpdateFieldValue("Organigrama_Puesto_Id_1", value);
            }
        }
        
        public int? Organigrama_Estructura_Id_1
        {
            get
            {
                return _organigrama_Estructura_Id_1;
            }
            set
            {
                _organigrama_Estructura_Id_1 = value;
                UpdateFieldValue("Organigrama_Estructura_Id_1", value);
            }
        }
        
        public FieldValue this[Organigrama_VDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
