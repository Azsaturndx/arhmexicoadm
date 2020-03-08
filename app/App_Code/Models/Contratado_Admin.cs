using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using arhmexico.Data;

namespace arhmexico.Models
{
	public enum Contratado_AdminDataField
    {
        
        Contratado_Id,
        
        Contratante_Id,
        
        Contratante_Contratante,
        
        Persona_Id,
        
        PersonanumeroImss,
        
        PersonacurpId,
        
        PersonaregistroFederalCausanteId,
        
        PersonafechaNacimiento,
        
        Persona_Contacto_Etiqueta,
        
        Persona_Contacto_iD,
        
        Persona_Domicilio_Etiqueta,
        
        Persona_Domicilio_Etiqueta_Id,
        
        Candidato_Id,
        
        Identificador_Unico,
        
        Tipo_Contratado_Id,
        
        Tipo_Contratado_Tipo_Contratado,
        
        Tipo_Empleado_Id,
        
        Tipo_Empleado_Tipo_Empleado,
        
        Contratante_Estructura_Organizacional_Id,
        
        Contratante_Estructura_Organizacional_Estructura_Organizacional,
        
        Contratante_Puesto_Id,
        
        Contratante_Puesto_Contratante_Puesto,
        
        Turno_Laboral_Id,
        
        Turno_Laboral_Turno_Laboral,
        
        Fecha_Contratacion,
        
        Fecha_Antiguedad,
        
        Vigencia_Contrato,
        
        Documento_Contrato_Id,
        
        Documento_Contrato_Documento,
        
        Notas_Contratacion,
        
        Estatus_Contratado_Id,
        
        Estatus_Contratado_Estatus_Contratado,
        
        Contratado_Key,
        
        Cliente_Id,
        
        Fecha_Creacion,
        
        cpUserName,
        
        Fecha_Ultima_Actualizacion,
        
        apUserName,
        
        Estatus_Registro_Id,
        
        Estatus_Registro_Estatus_Registro,
        
        Vacante,
        
        Nivel_Organizacional_Id,
        
        NivelOrganizacionalnivelOrganizacional,
        
        Identificador_Unico_A,
        
        Acceso_App_Por_Kiosko,
        
        Genero,
        
        EstadoCivilestadoCivil,
        
        EstatusPersonaestatusPersona,
        
        NivelEscolaridadnivelEscolaridad,
        
        Ciudad,
        
        Contratado_Persona_Nombre,
        
        Persona_Nombre,
        
        Puesto_Contratado_Finiquitar_Id,
        
        Puesto_Contratado_Finiquitar,
        
        Ciudad_Contratado_Id,
        
        Ciudad_Contratado_Ciudad,
        
        Pagadora_Id,
        
        Pagadora_Pagadora,
        
        Cliente_Cliente,
        
        Contratante_Puesto_Jefe,
        
        Persona_Nombre_Jefe,
        
        Jefe_Directo_Id,
        
        Contratante_Puesto_Jefe_Id,
        
        Contratante_Puesto_Jefe_Nuevo,
        
        Numero_Imss,
        
        Usuario_Aplicacion_Id,
        
        Es_Usuario_Bloqueado,
        
        Nuevo_Cliente_Id,
        
        Nuevo_Contratante_Id,
        
        Fecha_Movimiento_Personal,
        
        Motivo_Movimiento_Personal_Id,
        
        Nueva_Estructura_Organizacional_Id,
        
        Nuevo_Contratante_Puesto_Id,
        
        Nueva_Pagadora_Id,
        
        Tipo_Movimiento_Personal_Id,
        
        Motivo_Movimiento_Personal_Alta_Id,
        
        Motivo_Movimiento_Personal_Alta,
        
        Es_Baja,
        
        Apto_Para_Prestamo,
        
        Acceso_Servicio_ARH_Vacaciones,
        
        Acceso_Servicio_ARH_Nomina,
        
        Acceso_Servicio_ARH_Gastos,
        
        Acceso_Servicio_ARH_Prestamos,
        
        Acceso_Servicio_ARH_Documentos,
        
        Es_Vista_Aspirante,
        
        Acceso_Servicio_ARH_Evaluaciones,
        
        Generar_Usuario_Acceso,
        
        Contratante_Domicilio_Etiqueta_Id,
        
        Contratante_Domicilio_Etiqueta,
        
        Contratante_Encargado_RH_Persona_Nombre_Id,
        
        Contratante_Encargado_RH_Persona_Nombre,
        
        Contratante_Encargado_RH_Contacto_Id,
        
        Contratante_Encargado_RH_Contacto_Etiqueta,
    }
    
    public partial class Contratado_AdminModel : BusinessRulesObjectModel
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratado_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratante_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante_Contratante;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _persona_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _personanumeroImss;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _personacurpId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _personaregistroFederalCausanteId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _personafechaNacimiento;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _persona_Contacto_Etiqueta;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _persona_Contacto_iD;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _persona_Domicilio_Etiqueta;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _persona_Domicilio_Etiqueta_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _candidato_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _identificador_Unico;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Contratado_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Contratado_Tipo_Contratado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Empleado_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Empleado_Tipo_Empleado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratante_Estructura_Organizacional_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante_Estructura_Organizacional_Estructura_Organizacional;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratante_Puesto_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante_Puesto_Contratante_Puesto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _turno_Laboral_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _turno_Laboral_Turno_Laboral;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Contratacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Antiguedad;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _vigencia_Contrato;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _documento_Contrato_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _documento_Contrato_Documento;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _notas_Contratacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Contratado_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Contratado_Estatus_Contratado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratado_Key;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _cliente_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Creacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cpUserName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Ultima_Actualizacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _apUserName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Registro_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Registro_Estatus_Registro;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vacante;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _nivel_Organizacional_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nivelOrganizacionalnivelOrganizacional;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _identificador_Unico_A;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _acceso_App_Por_Kiosko;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _genero;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estadoCivilestadoCivil;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatusPersonaestatusPersona;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nivelEscolaridadnivelEscolaridad;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ciudad;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratado_Persona_Nombre;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _persona_Nombre;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _puesto_Contratado_Finiquitar_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _puesto_Contratado_Finiquitar;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _ciudad_Contratado_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ciudad_Contratado_Ciudad;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _pagadora_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pagadora_Pagadora;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cliente_Cliente;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante_Puesto_Jefe;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _persona_Nombre_Jefe;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _jefe_Directo_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratante_Puesto_Jefe_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante_Puesto_Jefe_Nuevo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _numero_Imss;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _usuario_Aplicacion_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Usuario_Bloqueado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _nuevo_Cliente_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _nuevo_Contratante_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Movimiento_Personal;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _motivo_Movimiento_Personal_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _nueva_Estructura_Organizacional_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _nuevo_Contratante_Puesto_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _nueva_Pagadora_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Movimiento_Personal_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _motivo_Movimiento_Personal_Alta_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _motivo_Movimiento_Personal_Alta;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Baja;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _apto_Para_Prestamo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _acceso_Servicio_ARH_Vacaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _acceso_Servicio_ARH_Nomina;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _acceso_Servicio_ARH_Gastos;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _acceso_Servicio_ARH_Prestamos;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _acceso_Servicio_ARH_Documentos;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Vista_Aspirante;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _acceso_Servicio_ARH_Evaluaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _generar_Usuario_Acceso;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratante_Domicilio_Etiqueta_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante_Domicilio_Etiqueta;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratante_Encargado_RH_Persona_Nombre_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante_Encargado_RH_Persona_Nombre;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratante_Encargado_RH_Contacto_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante_Encargado_RH_Contacto_Etiqueta;
        
        public Contratado_AdminModel()
        {
        }
        
        public Contratado_AdminModel(BusinessRules r) : 
                base(r)
        {
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
        
        public string PersonanumeroImss
        {
            get
            {
                return _personanumeroImss;
            }
            set
            {
                _personanumeroImss = value;
                UpdateFieldValue("PersonanumeroImss", value);
            }
        }
        
        public string PersonacurpId
        {
            get
            {
                return _personacurpId;
            }
            set
            {
                _personacurpId = value;
                UpdateFieldValue("PersonacurpId", value);
            }
        }
        
        public string PersonaregistroFederalCausanteId
        {
            get
            {
                return _personaregistroFederalCausanteId;
            }
            set
            {
                _personaregistroFederalCausanteId = value;
                UpdateFieldValue("PersonaregistroFederalCausanteId", value);
            }
        }
        
        public DateTime? PersonafechaNacimiento
        {
            get
            {
                return _personafechaNacimiento;
            }
            set
            {
                _personafechaNacimiento = value;
                UpdateFieldValue("PersonafechaNacimiento", value);
            }
        }
        
        public string Persona_Contacto_Etiqueta
        {
            get
            {
                return _persona_Contacto_Etiqueta;
            }
            set
            {
                _persona_Contacto_Etiqueta = value;
                UpdateFieldValue("Persona_Contacto_Etiqueta", value);
            }
        }
        
        public int? Persona_Contacto_iD
        {
            get
            {
                return _persona_Contacto_iD;
            }
            set
            {
                _persona_Contacto_iD = value;
                UpdateFieldValue("Persona_Contacto_iD", value);
            }
        }
        
        public string Persona_Domicilio_Etiqueta
        {
            get
            {
                return _persona_Domicilio_Etiqueta;
            }
            set
            {
                _persona_Domicilio_Etiqueta = value;
                UpdateFieldValue("Persona_Domicilio_Etiqueta", value);
            }
        }
        
        public int? Persona_Domicilio_Etiqueta_Id
        {
            get
            {
                return _persona_Domicilio_Etiqueta_Id;
            }
            set
            {
                _persona_Domicilio_Etiqueta_Id = value;
                UpdateFieldValue("Persona_Domicilio_Etiqueta_Id", value);
            }
        }
        
        public int? Candidato_Id
        {
            get
            {
                return _candidato_Id;
            }
            set
            {
                _candidato_Id = value;
                UpdateFieldValue("Candidato_Id", value);
            }
        }
        
        public string Identificador_Unico
        {
            get
            {
                return _identificador_Unico;
            }
            set
            {
                _identificador_Unico = value;
                UpdateFieldValue("Identificador_Unico", value);
            }
        }
        
        public int? Tipo_Contratado_Id
        {
            get
            {
                return _tipo_Contratado_Id;
            }
            set
            {
                _tipo_Contratado_Id = value;
                UpdateFieldValue("Tipo_Contratado_Id", value);
            }
        }
        
        public string Tipo_Contratado_Tipo_Contratado
        {
            get
            {
                return _tipo_Contratado_Tipo_Contratado;
            }
            set
            {
                _tipo_Contratado_Tipo_Contratado = value;
                UpdateFieldValue("Tipo_Contratado_Tipo_Contratado", value);
            }
        }
        
        public int? Tipo_Empleado_Id
        {
            get
            {
                return _tipo_Empleado_Id;
            }
            set
            {
                _tipo_Empleado_Id = value;
                UpdateFieldValue("Tipo_Empleado_Id", value);
            }
        }
        
        public string Tipo_Empleado_Tipo_Empleado
        {
            get
            {
                return _tipo_Empleado_Tipo_Empleado;
            }
            set
            {
                _tipo_Empleado_Tipo_Empleado = value;
                UpdateFieldValue("Tipo_Empleado_Tipo_Empleado", value);
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
        
        public int? Turno_Laboral_Id
        {
            get
            {
                return _turno_Laboral_Id;
            }
            set
            {
                _turno_Laboral_Id = value;
                UpdateFieldValue("Turno_Laboral_Id", value);
            }
        }
        
        public string Turno_Laboral_Turno_Laboral
        {
            get
            {
                return _turno_Laboral_Turno_Laboral;
            }
            set
            {
                _turno_Laboral_Turno_Laboral = value;
                UpdateFieldValue("Turno_Laboral_Turno_Laboral", value);
            }
        }
        
        public DateTime? Fecha_Contratacion
        {
            get
            {
                return _fecha_Contratacion;
            }
            set
            {
                _fecha_Contratacion = value;
                UpdateFieldValue("Fecha_Contratacion", value);
            }
        }
        
        public DateTime? Fecha_Antiguedad
        {
            get
            {
                return _fecha_Antiguedad;
            }
            set
            {
                _fecha_Antiguedad = value;
                UpdateFieldValue("Fecha_Antiguedad", value);
            }
        }
        
        public DateTime? Vigencia_Contrato
        {
            get
            {
                return _vigencia_Contrato;
            }
            set
            {
                _vigencia_Contrato = value;
                UpdateFieldValue("Vigencia_Contrato", value);
            }
        }
        
        public int? Documento_Contrato_Id
        {
            get
            {
                return _documento_Contrato_Id;
            }
            set
            {
                _documento_Contrato_Id = value;
                UpdateFieldValue("Documento_Contrato_Id", value);
            }
        }
        
        public string Documento_Contrato_Documento
        {
            get
            {
                return _documento_Contrato_Documento;
            }
            set
            {
                _documento_Contrato_Documento = value;
                UpdateFieldValue("Documento_Contrato_Documento", value);
            }
        }
        
        public string Notas_Contratacion
        {
            get
            {
                return _notas_Contratacion;
            }
            set
            {
                _notas_Contratacion = value;
                UpdateFieldValue("Notas_Contratacion", value);
            }
        }
        
        public int? Estatus_Contratado_Id
        {
            get
            {
                return _estatus_Contratado_Id;
            }
            set
            {
                _estatus_Contratado_Id = value;
                UpdateFieldValue("Estatus_Contratado_Id", value);
            }
        }
        
        public string Estatus_Contratado_Estatus_Contratado
        {
            get
            {
                return _estatus_Contratado_Estatus_Contratado;
            }
            set
            {
                _estatus_Contratado_Estatus_Contratado = value;
                UpdateFieldValue("Estatus_Contratado_Estatus_Contratado", value);
            }
        }
        
        public string Contratado_Key
        {
            get
            {
                return _contratado_Key;
            }
            set
            {
                _contratado_Key = value;
                UpdateFieldValue("Contratado_Key", value);
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
        
        public int? Nivel_Organizacional_Id
        {
            get
            {
                return _nivel_Organizacional_Id;
            }
            set
            {
                _nivel_Organizacional_Id = value;
                UpdateFieldValue("Nivel_Organizacional_Id", value);
            }
        }
        
        public string NivelOrganizacionalnivelOrganizacional
        {
            get
            {
                return _nivelOrganizacionalnivelOrganizacional;
            }
            set
            {
                _nivelOrganizacionalnivelOrganizacional = value;
                UpdateFieldValue("NivelOrganizacionalnivelOrganizacional", value);
            }
        }
        
        public string Identificador_Unico_A
        {
            get
            {
                return _identificador_Unico_A;
            }
            set
            {
                _identificador_Unico_A = value;
                UpdateFieldValue("Identificador_Unico_A", value);
            }
        }
        
        public bool? Acceso_App_Por_Kiosko
        {
            get
            {
                return _acceso_App_Por_Kiosko;
            }
            set
            {
                _acceso_App_Por_Kiosko = value;
                UpdateFieldValue("Acceso_App_Por_Kiosko", value);
            }
        }
        
        public string Genero
        {
            get
            {
                return _genero;
            }
            set
            {
                _genero = value;
                UpdateFieldValue("Genero", value);
            }
        }
        
        public string EstadoCivilestadoCivil
        {
            get
            {
                return _estadoCivilestadoCivil;
            }
            set
            {
                _estadoCivilestadoCivil = value;
                UpdateFieldValue("EstadoCivilestadoCivil", value);
            }
        }
        
        public string EstatusPersonaestatusPersona
        {
            get
            {
                return _estatusPersonaestatusPersona;
            }
            set
            {
                _estatusPersonaestatusPersona = value;
                UpdateFieldValue("EstatusPersonaestatusPersona", value);
            }
        }
        
        public string NivelEscolaridadnivelEscolaridad
        {
            get
            {
                return _nivelEscolaridadnivelEscolaridad;
            }
            set
            {
                _nivelEscolaridadnivelEscolaridad = value;
                UpdateFieldValue("NivelEscolaridadnivelEscolaridad", value);
            }
        }
        
        public string Ciudad
        {
            get
            {
                return _ciudad;
            }
            set
            {
                _ciudad = value;
                UpdateFieldValue("Ciudad", value);
            }
        }
        
        public string Contratado_Persona_Nombre
        {
            get
            {
                return _contratado_Persona_Nombre;
            }
            set
            {
                _contratado_Persona_Nombre = value;
                UpdateFieldValue("Contratado_Persona_Nombre", value);
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
        
        public int? Puesto_Contratado_Finiquitar_Id
        {
            get
            {
                return _puesto_Contratado_Finiquitar_Id;
            }
            set
            {
                _puesto_Contratado_Finiquitar_Id = value;
                UpdateFieldValue("Puesto_Contratado_Finiquitar_Id", value);
            }
        }
        
        public string Puesto_Contratado_Finiquitar
        {
            get
            {
                return _puesto_Contratado_Finiquitar;
            }
            set
            {
                _puesto_Contratado_Finiquitar = value;
                UpdateFieldValue("Puesto_Contratado_Finiquitar", value);
            }
        }
        
        public int? Ciudad_Contratado_Id
        {
            get
            {
                return _ciudad_Contratado_Id;
            }
            set
            {
                _ciudad_Contratado_Id = value;
                UpdateFieldValue("Ciudad_Contratado_Id", value);
            }
        }
        
        public string Ciudad_Contratado_Ciudad
        {
            get
            {
                return _ciudad_Contratado_Ciudad;
            }
            set
            {
                _ciudad_Contratado_Ciudad = value;
                UpdateFieldValue("Ciudad_Contratado_Ciudad", value);
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
        
        public string Contratante_Puesto_Jefe
        {
            get
            {
                return _contratante_Puesto_Jefe;
            }
            set
            {
                _contratante_Puesto_Jefe = value;
                UpdateFieldValue("Contratante_Puesto_Jefe", value);
            }
        }
        
        public string Persona_Nombre_Jefe
        {
            get
            {
                return _persona_Nombre_Jefe;
            }
            set
            {
                _persona_Nombre_Jefe = value;
                UpdateFieldValue("Persona_Nombre_Jefe", value);
            }
        }
        
        public int? Jefe_Directo_Id
        {
            get
            {
                return _jefe_Directo_Id;
            }
            set
            {
                _jefe_Directo_Id = value;
                UpdateFieldValue("Jefe_Directo_Id", value);
            }
        }
        
        public int? Contratante_Puesto_Jefe_Id
        {
            get
            {
                return _contratante_Puesto_Jefe_Id;
            }
            set
            {
                _contratante_Puesto_Jefe_Id = value;
                UpdateFieldValue("Contratante_Puesto_Jefe_Id", value);
            }
        }
        
        public string Contratante_Puesto_Jefe_Nuevo
        {
            get
            {
                return _contratante_Puesto_Jefe_Nuevo;
            }
            set
            {
                _contratante_Puesto_Jefe_Nuevo = value;
                UpdateFieldValue("Contratante_Puesto_Jefe_Nuevo", value);
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
        
        public System.Guid? Usuario_Aplicacion_Id
        {
            get
            {
                return _usuario_Aplicacion_Id;
            }
            set
            {
                _usuario_Aplicacion_Id = value;
                UpdateFieldValue("Usuario_Aplicacion_Id", value);
            }
        }
        
        public bool? Es_Usuario_Bloqueado
        {
            get
            {
                return _es_Usuario_Bloqueado;
            }
            set
            {
                _es_Usuario_Bloqueado = value;
                UpdateFieldValue("Es_Usuario_Bloqueado", value);
            }
        }
        
        public int? Nuevo_Cliente_Id
        {
            get
            {
                return _nuevo_Cliente_Id;
            }
            set
            {
                _nuevo_Cliente_Id = value;
                UpdateFieldValue("Nuevo_Cliente_Id", value);
            }
        }
        
        public int? Nuevo_Contratante_Id
        {
            get
            {
                return _nuevo_Contratante_Id;
            }
            set
            {
                _nuevo_Contratante_Id = value;
                UpdateFieldValue("Nuevo_Contratante_Id", value);
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
        
        public int? Nueva_Estructura_Organizacional_Id
        {
            get
            {
                return _nueva_Estructura_Organizacional_Id;
            }
            set
            {
                _nueva_Estructura_Organizacional_Id = value;
                UpdateFieldValue("Nueva_Estructura_Organizacional_Id", value);
            }
        }
        
        public int? Nuevo_Contratante_Puesto_Id
        {
            get
            {
                return _nuevo_Contratante_Puesto_Id;
            }
            set
            {
                _nuevo_Contratante_Puesto_Id = value;
                UpdateFieldValue("Nuevo_Contratante_Puesto_Id", value);
            }
        }
        
        public int? Nueva_Pagadora_Id
        {
            get
            {
                return _nueva_Pagadora_Id;
            }
            set
            {
                _nueva_Pagadora_Id = value;
                UpdateFieldValue("Nueva_Pagadora_Id", value);
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
        
        public int? Motivo_Movimiento_Personal_Alta_Id
        {
            get
            {
                return _motivo_Movimiento_Personal_Alta_Id;
            }
            set
            {
                _motivo_Movimiento_Personal_Alta_Id = value;
                UpdateFieldValue("Motivo_Movimiento_Personal_Alta_Id", value);
            }
        }
        
        public string Motivo_Movimiento_Personal_Alta
        {
            get
            {
                return _motivo_Movimiento_Personal_Alta;
            }
            set
            {
                _motivo_Movimiento_Personal_Alta = value;
                UpdateFieldValue("Motivo_Movimiento_Personal_Alta", value);
            }
        }
        
        public bool? Es_Baja
        {
            get
            {
                return _es_Baja;
            }
            set
            {
                _es_Baja = value;
                UpdateFieldValue("Es_Baja", value);
            }
        }
        
        public bool? Apto_Para_Prestamo
        {
            get
            {
                return _apto_Para_Prestamo;
            }
            set
            {
                _apto_Para_Prestamo = value;
                UpdateFieldValue("Apto_Para_Prestamo", value);
            }
        }
        
        public bool? Acceso_Servicio_ARH_Vacaciones
        {
            get
            {
                return _acceso_Servicio_ARH_Vacaciones;
            }
            set
            {
                _acceso_Servicio_ARH_Vacaciones = value;
                UpdateFieldValue("Acceso_Servicio_ARH_Vacaciones", value);
            }
        }
        
        public bool? Acceso_Servicio_ARH_Nomina
        {
            get
            {
                return _acceso_Servicio_ARH_Nomina;
            }
            set
            {
                _acceso_Servicio_ARH_Nomina = value;
                UpdateFieldValue("Acceso_Servicio_ARH_Nomina", value);
            }
        }
        
        public bool? Acceso_Servicio_ARH_Gastos
        {
            get
            {
                return _acceso_Servicio_ARH_Gastos;
            }
            set
            {
                _acceso_Servicio_ARH_Gastos = value;
                UpdateFieldValue("Acceso_Servicio_ARH_Gastos", value);
            }
        }
        
        public bool? Acceso_Servicio_ARH_Prestamos
        {
            get
            {
                return _acceso_Servicio_ARH_Prestamos;
            }
            set
            {
                _acceso_Servicio_ARH_Prestamos = value;
                UpdateFieldValue("Acceso_Servicio_ARH_Prestamos", value);
            }
        }
        
        public bool? Acceso_Servicio_ARH_Documentos
        {
            get
            {
                return _acceso_Servicio_ARH_Documentos;
            }
            set
            {
                _acceso_Servicio_ARH_Documentos = value;
                UpdateFieldValue("Acceso_Servicio_ARH_Documentos", value);
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
        
        public bool? Generar_Usuario_Acceso
        {
            get
            {
                return _generar_Usuario_Acceso;
            }
            set
            {
                _generar_Usuario_Acceso = value;
                UpdateFieldValue("Generar_Usuario_Acceso", value);
            }
        }
        
        public int? Contratante_Domicilio_Etiqueta_Id
        {
            get
            {
                return _contratante_Domicilio_Etiqueta_Id;
            }
            set
            {
                _contratante_Domicilio_Etiqueta_Id = value;
                UpdateFieldValue("Contratante_Domicilio_Etiqueta_Id", value);
            }
        }
        
        public string Contratante_Domicilio_Etiqueta
        {
            get
            {
                return _contratante_Domicilio_Etiqueta;
            }
            set
            {
                _contratante_Domicilio_Etiqueta = value;
                UpdateFieldValue("Contratante_Domicilio_Etiqueta", value);
            }
        }
        
        public int? Contratante_Encargado_RH_Persona_Nombre_Id
        {
            get
            {
                return _contratante_Encargado_RH_Persona_Nombre_Id;
            }
            set
            {
                _contratante_Encargado_RH_Persona_Nombre_Id = value;
                UpdateFieldValue("Contratante_Encargado_RH_Persona_Nombre_Id", value);
            }
        }
        
        public string Contratante_Encargado_RH_Persona_Nombre
        {
            get
            {
                return _contratante_Encargado_RH_Persona_Nombre;
            }
            set
            {
                _contratante_Encargado_RH_Persona_Nombre = value;
                UpdateFieldValue("Contratante_Encargado_RH_Persona_Nombre", value);
            }
        }
        
        public int? Contratante_Encargado_RH_Contacto_Id
        {
            get
            {
                return _contratante_Encargado_RH_Contacto_Id;
            }
            set
            {
                _contratante_Encargado_RH_Contacto_Id = value;
                UpdateFieldValue("Contratante_Encargado_RH_Contacto_Id", value);
            }
        }
        
        public string Contratante_Encargado_RH_Contacto_Etiqueta
        {
            get
            {
                return _contratante_Encargado_RH_Contacto_Etiqueta;
            }
            set
            {
                _contratante_Encargado_RH_Contacto_Etiqueta = value;
                UpdateFieldValue("Contratante_Encargado_RH_Contacto_Etiqueta", value);
            }
        }
        
        public FieldValue this[Contratado_AdminDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
