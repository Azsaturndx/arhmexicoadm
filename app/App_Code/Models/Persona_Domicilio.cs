using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using arhmexico.Data;

namespace arhmexico.Models
{
	public enum Persona_DomicilioDataField
    {
        
        Persona_Domicilio_Id,
        
        Persona_Id,
        
        Persona_Nombre,
        
        PersonaApellidoPaterno,
        
        PersonaApellidoMaterno,
        
        PersonaSegundoNombre,
        
        Domicilio_Id,
        
        Domicilio_Calle,
        
        Domicilio_Ciudad_Ciudad,
        
        Tipo_Domicilio_Id,
        
        Tipo_Domicilio_Tipo_Domicilio,
        
        Fecha_Creacion,
        
        Fecha_Ultima_Actualizacion,
        
        Estatus_Registro_Id,
        
        Estatus_Registro_Estatus_Registro,
        
        EntidadPaisentidadPais,
        
        Pais,
        
        cpUserName,
        
        apUserName,
        
        Es_Domicilio_Principal,
        
        Nombre_Completo,
        
        Domicilio_Etiqueta,
        
        Custom_Domicilio_Calle,
        
        Custom_Domicilio_Numero_Interior,
        
        Custom_Domicilio_Numero_Exterior,
        
        Custom_Domicilio_Colonia,
        
        Custom_Domicilio_Ciudad_Id,
        
        Custom_Domicilio_Ciudad_Nombre,
        
        Custom_Domicilio_Codigo_Postal_Id,
        
        Custom_Domicilio_Entre_Calles,
        
        Custom_Domicilio_Latitud,
        
        Custom_Domicilio_Longitud,
        
        Custom_Domicilio_Ciudad_Nombre_Etiqueta,
        
        Custom_Domicilio_Etiqueta,
    }
    
    public partial class Persona_DomicilioModel : BusinessRulesObjectModel
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _persona_Domicilio_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _persona_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _persona_Nombre;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _personaApellidoPaterno;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _personaApellidoMaterno;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _personaSegundoNombre;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _domicilio_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _domicilio_Calle;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _domicilio_Ciudad_Ciudad;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Domicilio_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Domicilio_Tipo_Domicilio;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Creacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Ultima_Actualizacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Registro_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Registro_Estatus_Registro;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _entidadPaisentidadPais;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pais;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cpUserName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _apUserName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Domicilio_Principal;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nombre_Completo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _domicilio_Etiqueta;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _custom_Domicilio_Calle;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _custom_Domicilio_Numero_Interior;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _custom_Domicilio_Numero_Exterior;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _custom_Domicilio_Colonia;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _custom_Domicilio_Ciudad_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _custom_Domicilio_Ciudad_Nombre;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _custom_Domicilio_Codigo_Postal_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _custom_Domicilio_Entre_Calles;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _custom_Domicilio_Latitud;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _custom_Domicilio_Longitud;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _custom_Domicilio_Ciudad_Nombre_Etiqueta;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _custom_Domicilio_Etiqueta;
        
        public Persona_DomicilioModel()
        {
        }
        
        public Persona_DomicilioModel(BusinessRules r) : 
                base(r)
        {
        }
        
        public int? Persona_Domicilio_Id
        {
            get
            {
                return _persona_Domicilio_Id;
            }
            set
            {
                _persona_Domicilio_Id = value;
                UpdateFieldValue("Persona_Domicilio_Id", value);
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
        
        public string PersonaApellidoPaterno
        {
            get
            {
                return _personaApellidoPaterno;
            }
            set
            {
                _personaApellidoPaterno = value;
                UpdateFieldValue("PersonaApellidoPaterno", value);
            }
        }
        
        public string PersonaApellidoMaterno
        {
            get
            {
                return _personaApellidoMaterno;
            }
            set
            {
                _personaApellidoMaterno = value;
                UpdateFieldValue("PersonaApellidoMaterno", value);
            }
        }
        
        public string PersonaSegundoNombre
        {
            get
            {
                return _personaSegundoNombre;
            }
            set
            {
                _personaSegundoNombre = value;
                UpdateFieldValue("PersonaSegundoNombre", value);
            }
        }
        
        public int? Domicilio_Id
        {
            get
            {
                return _domicilio_Id;
            }
            set
            {
                _domicilio_Id = value;
                UpdateFieldValue("Domicilio_Id", value);
            }
        }
        
        public string Domicilio_Calle
        {
            get
            {
                return _domicilio_Calle;
            }
            set
            {
                _domicilio_Calle = value;
                UpdateFieldValue("Domicilio_Calle", value);
            }
        }
        
        public string Domicilio_Ciudad_Ciudad
        {
            get
            {
                return _domicilio_Ciudad_Ciudad;
            }
            set
            {
                _domicilio_Ciudad_Ciudad = value;
                UpdateFieldValue("Domicilio_Ciudad_Ciudad", value);
            }
        }
        
        public int? Tipo_Domicilio_Id
        {
            get
            {
                return _tipo_Domicilio_Id;
            }
            set
            {
                _tipo_Domicilio_Id = value;
                UpdateFieldValue("Tipo_Domicilio_Id", value);
            }
        }
        
        public string Tipo_Domicilio_Tipo_Domicilio
        {
            get
            {
                return _tipo_Domicilio_Tipo_Domicilio;
            }
            set
            {
                _tipo_Domicilio_Tipo_Domicilio = value;
                UpdateFieldValue("Tipo_Domicilio_Tipo_Domicilio", value);
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
        
        public string EntidadPaisentidadPais
        {
            get
            {
                return _entidadPaisentidadPais;
            }
            set
            {
                _entidadPaisentidadPais = value;
                UpdateFieldValue("EntidadPaisentidadPais", value);
            }
        }
        
        public string Pais
        {
            get
            {
                return _pais;
            }
            set
            {
                _pais = value;
                UpdateFieldValue("Pais", value);
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
        
        public bool? Es_Domicilio_Principal
        {
            get
            {
                return _es_Domicilio_Principal;
            }
            set
            {
                _es_Domicilio_Principal = value;
                UpdateFieldValue("Es_Domicilio_Principal", value);
            }
        }
        
        public string Nombre_Completo
        {
            get
            {
                return _nombre_Completo;
            }
            set
            {
                _nombre_Completo = value;
                UpdateFieldValue("Nombre_Completo", value);
            }
        }
        
        public string Domicilio_Etiqueta
        {
            get
            {
                return _domicilio_Etiqueta;
            }
            set
            {
                _domicilio_Etiqueta = value;
                UpdateFieldValue("Domicilio_Etiqueta", value);
            }
        }
        
        public string Custom_Domicilio_Calle
        {
            get
            {
                return _custom_Domicilio_Calle;
            }
            set
            {
                _custom_Domicilio_Calle = value;
                UpdateFieldValue("Custom_Domicilio_Calle", value);
            }
        }
        
        public string Custom_Domicilio_Numero_Interior
        {
            get
            {
                return _custom_Domicilio_Numero_Interior;
            }
            set
            {
                _custom_Domicilio_Numero_Interior = value;
                UpdateFieldValue("Custom_Domicilio_Numero_Interior", value);
            }
        }
        
        public string Custom_Domicilio_Numero_Exterior
        {
            get
            {
                return _custom_Domicilio_Numero_Exterior;
            }
            set
            {
                _custom_Domicilio_Numero_Exterior = value;
                UpdateFieldValue("Custom_Domicilio_Numero_Exterior", value);
            }
        }
        
        public string Custom_Domicilio_Colonia
        {
            get
            {
                return _custom_Domicilio_Colonia;
            }
            set
            {
                _custom_Domicilio_Colonia = value;
                UpdateFieldValue("Custom_Domicilio_Colonia", value);
            }
        }
        
        public int? Custom_Domicilio_Ciudad_Id
        {
            get
            {
                return _custom_Domicilio_Ciudad_Id;
            }
            set
            {
                _custom_Domicilio_Ciudad_Id = value;
                UpdateFieldValue("Custom_Domicilio_Ciudad_Id", value);
            }
        }
        
        public string Custom_Domicilio_Ciudad_Nombre
        {
            get
            {
                return _custom_Domicilio_Ciudad_Nombre;
            }
            set
            {
                _custom_Domicilio_Ciudad_Nombre = value;
                UpdateFieldValue("Custom_Domicilio_Ciudad_Nombre", value);
            }
        }
        
        public int? Custom_Domicilio_Codigo_Postal_Id
        {
            get
            {
                return _custom_Domicilio_Codigo_Postal_Id;
            }
            set
            {
                _custom_Domicilio_Codigo_Postal_Id = value;
                UpdateFieldValue("Custom_Domicilio_Codigo_Postal_Id", value);
            }
        }
        
        public string Custom_Domicilio_Entre_Calles
        {
            get
            {
                return _custom_Domicilio_Entre_Calles;
            }
            set
            {
                _custom_Domicilio_Entre_Calles = value;
                UpdateFieldValue("Custom_Domicilio_Entre_Calles", value);
            }
        }
        
        public int? Custom_Domicilio_Latitud
        {
            get
            {
                return _custom_Domicilio_Latitud;
            }
            set
            {
                _custom_Domicilio_Latitud = value;
                UpdateFieldValue("Custom_Domicilio_Latitud", value);
            }
        }
        
        public int? Custom_Domicilio_Longitud
        {
            get
            {
                return _custom_Domicilio_Longitud;
            }
            set
            {
                _custom_Domicilio_Longitud = value;
                UpdateFieldValue("Custom_Domicilio_Longitud", value);
            }
        }
        
        public string Custom_Domicilio_Ciudad_Nombre_Etiqueta
        {
            get
            {
                return _custom_Domicilio_Ciudad_Nombre_Etiqueta;
            }
            set
            {
                _custom_Domicilio_Ciudad_Nombre_Etiqueta = value;
                UpdateFieldValue("Custom_Domicilio_Ciudad_Nombre_Etiqueta", value);
            }
        }
        
        public string Custom_Domicilio_Etiqueta
        {
            get
            {
                return _custom_Domicilio_Etiqueta;
            }
            set
            {
                _custom_Domicilio_Etiqueta = value;
                UpdateFieldValue("Custom_Domicilio_Etiqueta", value);
            }
        }
        
        public FieldValue this[Persona_DomicilioDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
