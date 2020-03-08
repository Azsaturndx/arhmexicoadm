using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using arhmexico.Data;

namespace arhmexico.Models
{
	public enum PersonaDataField
    {
        
        Persona_Id,
        
        Nombre,
        
        Apellido_Paterno,
        
        Apellido_Materno,
        
        Segundo_Nombre,
        
        Fecha_Nacimiento,
        
        Lugar_Nacimiento_Id,
        
        Lugar_Nacimiento_Ciudad,
        
        Lugar_Nacimiento_Entidad_Pais_Entidad_Pais,
        
        Lugar_Nacimiento_Entidad_Pais_Pais_Pais,
        
        Maximo_Nivel_Escolaridad_Id,
        
        Maximo_Nivel_Escolaridad_Nivel_Escolaridad,
        
        Estado_Civil_Id,
        
        Estado_Civil_Estado_Civil,
        
        Genero_Persona_Id,
        
        Genero_Persona,
        
        PictureFileName,
        
        PictureContentType,
        
        PictureLength,
        
        Registro_Federal_Causante_Id,
        
        Curp_Id,
        
        Notas,
        
        Fecha_Creacion,
        
        Fecha_Ultima_Actualizacion,
        
        Estatus_Registro_Id,
        
        Estatus_Registro_Estatus_Registro,
        
        cpUserName,
        
        apUserName,
        
        Numero_Imss,
        
        Cliente_Id,
        
        Cliente,
        
        Persona_Key,
        
        Estatus_Persona_Id,
        
        Estatus_Persona_Estatus_Persona,
        
        Nombre_Completo,
        
        Edad,
        
        Correo_Personal,
        
        Numero_Celular_Personal,
        
        UserId,
        
        PathToImage,
        
        Significa_Vigente_Con_Interes_Por_Laborar,
        
        Contratado,
        
        Es_Vista_Aspirante,
        
        Acceso_Servicio_ARH_Evaluaciones,
        
        Religion_Id,
        
        Religion,
        
        Orientacion_Sexual_Id,
        
        Orientacion_Sexual,
        
        Disposicion_A_Mobilidad,
        
        Disposicion_A_Cambio_Domicilio,
        
        Estatura,
        
        Peso,
        
        Complexion_Fisica_Id,
        
        Complexion_Fisica,
        
        Tiene_Tatuajes,
        
        Tiene_Tatuajes_Visibles,
        
        Estado_Salud_Id,
        
        Estado_Salud,
        
        Sufre_Diabetes,
        
        Problemas_Presion_Arterial_Id,
        
        Consumo_Estupefacientes,
        
        Padece_Discapacidad,
        
        Color_Piel_Id,
        
        Color_Piel,
        
        Mostrar_Religion_A_Aspirante,
        
        Mostrar_Orientacion_Sexual_A_Aspirante,
        
        Mostrar_Senas_Particulares_A_Aspirante,
        
        Permite_Cancelar_Solicitud_Vacaciones,
        
        Problemas_Presion_Arterial,
    }
    
    public partial class PersonaModel : BusinessRulesObjectModel
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _persona_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nombre;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _apellido_Paterno;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _apellido_Materno;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _segundo_Nombre;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Nacimiento;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _lugar_Nacimiento_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _lugar_Nacimiento_Ciudad;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _lugar_Nacimiento_Entidad_Pais_Entidad_Pais;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _lugar_Nacimiento_Entidad_Pais_Pais_Pais;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _maximo_Nivel_Escolaridad_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _maximo_Nivel_Escolaridad_Nivel_Escolaridad;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estado_Civil_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estado_Civil_Estado_Civil;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _genero_Persona_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _genero_Persona;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pictureFileName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pictureContentType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _pictureLength;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _registro_Federal_Causante_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _curp_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _notas;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Creacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Ultima_Actualizacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Registro_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Registro_Estatus_Registro;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cpUserName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _apUserName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _numero_Imss;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _cliente_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cliente;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _persona_Key;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Persona_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Persona_Estatus_Persona;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nombre_Completo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _edad;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _correo_Personal;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _numero_Celular_Personal;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _userId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pathToImage;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _significa_Vigente_Con_Interes_Por_Laborar;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _contratado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Vista_Aspirante;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _acceso_Servicio_ARH_Evaluaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _religion_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _religion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _orientacion_Sexual_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _orientacion_Sexual;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _disposicion_A_Mobilidad;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _disposicion_A_Cambio_Domicilio;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _estatura;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _peso;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _complexion_Fisica_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _complexion_Fisica;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _tiene_Tatuajes;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _tiene_Tatuajes_Visibles;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estado_Salud_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estado_Salud;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _sufre_Diabetes;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _problemas_Presion_Arterial_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _consumo_Estupefacientes;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _padece_Discapacidad;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _color_Piel_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _color_Piel;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _mostrar_Religion_A_Aspirante;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _mostrar_Orientacion_Sexual_A_Aspirante;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _mostrar_Senas_Particulares_A_Aspirante;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _permite_Cancelar_Solicitud_Vacaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _problemas_Presion_Arterial;
        
        public PersonaModel()
        {
        }
        
        public PersonaModel(BusinessRules r) : 
                base(r)
        {
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
        
        public DateTime? Fecha_Nacimiento
        {
            get
            {
                return _fecha_Nacimiento;
            }
            set
            {
                _fecha_Nacimiento = value;
                UpdateFieldValue("Fecha_Nacimiento", value);
            }
        }
        
        public int? Lugar_Nacimiento_Id
        {
            get
            {
                return _lugar_Nacimiento_Id;
            }
            set
            {
                _lugar_Nacimiento_Id = value;
                UpdateFieldValue("Lugar_Nacimiento_Id", value);
            }
        }
        
        public string Lugar_Nacimiento_Ciudad
        {
            get
            {
                return _lugar_Nacimiento_Ciudad;
            }
            set
            {
                _lugar_Nacimiento_Ciudad = value;
                UpdateFieldValue("Lugar_Nacimiento_Ciudad", value);
            }
        }
        
        public string Lugar_Nacimiento_Entidad_Pais_Entidad_Pais
        {
            get
            {
                return _lugar_Nacimiento_Entidad_Pais_Entidad_Pais;
            }
            set
            {
                _lugar_Nacimiento_Entidad_Pais_Entidad_Pais = value;
                UpdateFieldValue("Lugar_Nacimiento_Entidad_Pais_Entidad_Pais", value);
            }
        }
        
        public string Lugar_Nacimiento_Entidad_Pais_Pais_Pais
        {
            get
            {
                return _lugar_Nacimiento_Entidad_Pais_Pais_Pais;
            }
            set
            {
                _lugar_Nacimiento_Entidad_Pais_Pais_Pais = value;
                UpdateFieldValue("Lugar_Nacimiento_Entidad_Pais_Pais_Pais", value);
            }
        }
        
        public int? Maximo_Nivel_Escolaridad_Id
        {
            get
            {
                return _maximo_Nivel_Escolaridad_Id;
            }
            set
            {
                _maximo_Nivel_Escolaridad_Id = value;
                UpdateFieldValue("Maximo_Nivel_Escolaridad_Id", value);
            }
        }
        
        public string Maximo_Nivel_Escolaridad_Nivel_Escolaridad
        {
            get
            {
                return _maximo_Nivel_Escolaridad_Nivel_Escolaridad;
            }
            set
            {
                _maximo_Nivel_Escolaridad_Nivel_Escolaridad = value;
                UpdateFieldValue("Maximo_Nivel_Escolaridad_Nivel_Escolaridad", value);
            }
        }
        
        public int? Estado_Civil_Id
        {
            get
            {
                return _estado_Civil_Id;
            }
            set
            {
                _estado_Civil_Id = value;
                UpdateFieldValue("Estado_Civil_Id", value);
            }
        }
        
        public string Estado_Civil_Estado_Civil
        {
            get
            {
                return _estado_Civil_Estado_Civil;
            }
            set
            {
                _estado_Civil_Estado_Civil = value;
                UpdateFieldValue("Estado_Civil_Estado_Civil", value);
            }
        }
        
        public int? Genero_Persona_Id
        {
            get
            {
                return _genero_Persona_Id;
            }
            set
            {
                _genero_Persona_Id = value;
                UpdateFieldValue("Genero_Persona_Id", value);
            }
        }
        
        public string Genero_Persona
        {
            get
            {
                return _genero_Persona;
            }
            set
            {
                _genero_Persona = value;
                UpdateFieldValue("Genero_Persona", value);
            }
        }
        
        public string PictureFileName
        {
            get
            {
                return _pictureFileName;
            }
            set
            {
                _pictureFileName = value;
                UpdateFieldValue("PictureFileName", value);
            }
        }
        
        public string PictureContentType
        {
            get
            {
                return _pictureContentType;
            }
            set
            {
                _pictureContentType = value;
                UpdateFieldValue("PictureContentType", value);
            }
        }
        
        public int? PictureLength
        {
            get
            {
                return _pictureLength;
            }
            set
            {
                _pictureLength = value;
                UpdateFieldValue("PictureLength", value);
            }
        }
        
        public string Registro_Federal_Causante_Id
        {
            get
            {
                return _registro_Federal_Causante_Id;
            }
            set
            {
                _registro_Federal_Causante_Id = value;
                UpdateFieldValue("Registro_Federal_Causante_Id", value);
            }
        }
        
        public string Curp_Id
        {
            get
            {
                return _curp_Id;
            }
            set
            {
                _curp_Id = value;
                UpdateFieldValue("Curp_Id", value);
            }
        }
        
        public string Notas
        {
            get
            {
                return _notas;
            }
            set
            {
                _notas = value;
                UpdateFieldValue("Notas", value);
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
        
        public string Numero_Imss
        {
            get
            {
                return _numero_Imss;
            }
            set
            {
                _numero_Imss = value;
                UpdateFieldValue("Numero_Imss", value);
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
        
        public string Persona_Key
        {
            get
            {
                return _persona_Key;
            }
            set
            {
                _persona_Key = value;
                UpdateFieldValue("Persona_Key", value);
            }
        }
        
        public int? Estatus_Persona_Id
        {
            get
            {
                return _estatus_Persona_Id;
            }
            set
            {
                _estatus_Persona_Id = value;
                UpdateFieldValue("Estatus_Persona_Id", value);
            }
        }
        
        public string Estatus_Persona_Estatus_Persona
        {
            get
            {
                return _estatus_Persona_Estatus_Persona;
            }
            set
            {
                _estatus_Persona_Estatus_Persona = value;
                UpdateFieldValue("Estatus_Persona_Estatus_Persona", value);
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
        
        public int? Edad
        {
            get
            {
                return _edad;
            }
            set
            {
                _edad = value;
                UpdateFieldValue("Edad", value);
            }
        }
        
        public string Correo_Personal
        {
            get
            {
                return _correo_Personal;
            }
            set
            {
                _correo_Personal = value;
                UpdateFieldValue("Correo_Personal", value);
            }
        }
        
        public string Numero_Celular_Personal
        {
            get
            {
                return _numero_Celular_Personal;
            }
            set
            {
                _numero_Celular_Personal = value;
                UpdateFieldValue("Numero_Celular_Personal", value);
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
        
        public string PathToImage
        {
            get
            {
                return _pathToImage;
            }
            set
            {
                _pathToImage = value;
                UpdateFieldValue("PathToImage", value);
            }
        }
        
        public bool? Significa_Vigente_Con_Interes_Por_Laborar
        {
            get
            {
                return _significa_Vigente_Con_Interes_Por_Laborar;
            }
            set
            {
                _significa_Vigente_Con_Interes_Por_Laborar = value;
                UpdateFieldValue("Significa_Vigente_Con_Interes_Por_Laborar", value);
            }
        }
        
        public bool? Contratado
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
        
        public bool? Es_Vista_Aspirante
        {
            get
            {
                return _es_Vista_Aspirante;
            }
            set
            {
                _es_Vista_Aspirante = value;
                UpdateFieldValue("Es_Vista_Aspirante", value);
            }
        }
        
        public bool? Acceso_Servicio_ARH_Evaluaciones
        {
            get
            {
                return _acceso_Servicio_ARH_Evaluaciones;
            }
            set
            {
                _acceso_Servicio_ARH_Evaluaciones = value;
                UpdateFieldValue("Acceso_Servicio_ARH_Evaluaciones", value);
            }
        }
        
        public int? Religion_Id
        {
            get
            {
                return _religion_Id;
            }
            set
            {
                _religion_Id = value;
                UpdateFieldValue("Religion_Id", value);
            }
        }
        
        public string Religion
        {
            get
            {
                return _religion;
            }
            set
            {
                _religion = value;
                UpdateFieldValue("Religion", value);
            }
        }
        
        public int? Orientacion_Sexual_Id
        {
            get
            {
                return _orientacion_Sexual_Id;
            }
            set
            {
                _orientacion_Sexual_Id = value;
                UpdateFieldValue("Orientacion_Sexual_Id", value);
            }
        }
        
        public string Orientacion_Sexual
        {
            get
            {
                return _orientacion_Sexual;
            }
            set
            {
                _orientacion_Sexual = value;
                UpdateFieldValue("Orientacion_Sexual", value);
            }
        }
        
        public bool? Disposicion_A_Mobilidad
        {
            get
            {
                return _disposicion_A_Mobilidad;
            }
            set
            {
                _disposicion_A_Mobilidad = value;
                UpdateFieldValue("Disposicion_A_Mobilidad", value);
            }
        }
        
        public bool? Disposicion_A_Cambio_Domicilio
        {
            get
            {
                return _disposicion_A_Cambio_Domicilio;
            }
            set
            {
                _disposicion_A_Cambio_Domicilio = value;
                UpdateFieldValue("Disposicion_A_Cambio_Domicilio", value);
            }
        }
        
        public decimal? Estatura
        {
            get
            {
                return _estatura;
            }
            set
            {
                _estatura = value;
                UpdateFieldValue("Estatura", value);
            }
        }
        
        public decimal? Peso
        {
            get
            {
                return _peso;
            }
            set
            {
                _peso = value;
                UpdateFieldValue("Peso", value);
            }
        }
        
        public int? Complexion_Fisica_Id
        {
            get
            {
                return _complexion_Fisica_Id;
            }
            set
            {
                _complexion_Fisica_Id = value;
                UpdateFieldValue("Complexion_Fisica_Id", value);
            }
        }
        
        public string Complexion_Fisica
        {
            get
            {
                return _complexion_Fisica;
            }
            set
            {
                _complexion_Fisica = value;
                UpdateFieldValue("Complexion_Fisica", value);
            }
        }
        
        public bool? Tiene_Tatuajes
        {
            get
            {
                return _tiene_Tatuajes;
            }
            set
            {
                _tiene_Tatuajes = value;
                UpdateFieldValue("Tiene_Tatuajes", value);
            }
        }
        
        public bool? Tiene_Tatuajes_Visibles
        {
            get
            {
                return _tiene_Tatuajes_Visibles;
            }
            set
            {
                _tiene_Tatuajes_Visibles = value;
                UpdateFieldValue("Tiene_Tatuajes_Visibles", value);
            }
        }
        
        public int? Estado_Salud_Id
        {
            get
            {
                return _estado_Salud_Id;
            }
            set
            {
                _estado_Salud_Id = value;
                UpdateFieldValue("Estado_Salud_Id", value);
            }
        }
        
        public string Estado_Salud
        {
            get
            {
                return _estado_Salud;
            }
            set
            {
                _estado_Salud = value;
                UpdateFieldValue("Estado_Salud", value);
            }
        }
        
        public bool? Sufre_Diabetes
        {
            get
            {
                return _sufre_Diabetes;
            }
            set
            {
                _sufre_Diabetes = value;
                UpdateFieldValue("Sufre_Diabetes", value);
            }
        }
        
        public int? Problemas_Presion_Arterial_Id
        {
            get
            {
                return _problemas_Presion_Arterial_Id;
            }
            set
            {
                _problemas_Presion_Arterial_Id = value;
                UpdateFieldValue("Problemas_Presion_Arterial_Id", value);
            }
        }
        
        public bool? Consumo_Estupefacientes
        {
            get
            {
                return _consumo_Estupefacientes;
            }
            set
            {
                _consumo_Estupefacientes = value;
                UpdateFieldValue("Consumo_Estupefacientes", value);
            }
        }
        
        public bool? Padece_Discapacidad
        {
            get
            {
                return _padece_Discapacidad;
            }
            set
            {
                _padece_Discapacidad = value;
                UpdateFieldValue("Padece_Discapacidad", value);
            }
        }
        
        public int? Color_Piel_Id
        {
            get
            {
                return _color_Piel_Id;
            }
            set
            {
                _color_Piel_Id = value;
                UpdateFieldValue("Color_Piel_Id", value);
            }
        }
        
        public string Color_Piel
        {
            get
            {
                return _color_Piel;
            }
            set
            {
                _color_Piel = value;
                UpdateFieldValue("Color_Piel", value);
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
        
        public string Problemas_Presion_Arterial
        {
            get
            {
                return _problemas_Presion_Arterial;
            }
            set
            {
                _problemas_Presion_Arterial = value;
                UpdateFieldValue("Problemas_Presion_Arterial", value);
            }
        }
        
        public FieldValue this[PersonaDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
