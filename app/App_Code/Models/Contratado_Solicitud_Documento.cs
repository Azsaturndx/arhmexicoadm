using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using arhmexico.Data;

namespace arhmexico.Models
{
	public enum Contratado_Solicitud_DocumentoDataField
    {
        
        Contratado_Solicitud_Documento_Id,
        
        Definicion_Solicitud_Documento_Id,
        
        Definicion_Solicitud_Documento_Definicion_Solicitud_Documento,
        
        Contratado_Id,
        
        Contratado_Identificador_Unico,
        
        Layout_HTML_Id,
        
        Layout_HTML_Layout_HTML_Nombre,
        
        Fecha_Emision_Documento,
        
        Layout_Documento,
        
        Pagadora_Id,
        
        Pagadora_Pagadora,
        
        Leyenda_Sindicato,
        
        Destinatario,
        
        Sueldo_Empleado_Valor_Letra,
        
        Domicilio_Contratante,
        
        Ciudad_Emision,
        
        Fecha_Ingreso_Empleado,
        
        Fecha_Termino_Labores_Empleado,
        
        PictureFileName,
        
        PictureContentType,
        
        PictureLength,
        
        Picture2FileName,
        
        Picture2ContentType,
        
        Picture2Length,
        
        Solicitud_Documento_Key,
        
        Fecha_Solicitud,
        
        Estatus_Solicitud_Id,
        
        Estatus_Solicitud_Estatus_Solicitud,
        
        Fecha_Autorizacion_Rechazo,
        
        AutorizadoRechazadoPorusername,
        
        Notas_Autorizacion_Rechazo,
        
        Transaccion_Id,
        
        CreadoPorusername,
        
        Fecha_Creacion,
        
        ActualizadoPorusername,
        
        Fecha_Ultima_Actualizacion,
        
        Estatus_Registro_Id,
        
        Estatus_Registro_Estatus_Registro,
        
        Nombre_Completo_Contratado,
        
        Emisor,
        
        Jefe_Sindicato,
        
        Fecha_Inicio_Vacaciones,
        
        Fecha_Fin_Vacaciones,
        
        Dias_Descanso,
        
        Nombre_Menor_Guarderia,
        
        Matricula_Persona,
        
        Carrera_Universitaria,
        
        Horas_Trabajadas,
        
        Departamento_Emisor,
        
        Registro_Patronal,
        
        Codigo_Postal_Contratante,
        
        Numero_Telefonico_Contratante,
        
        Finalidad_Documento_Guarderia_Id,
        
        Nombre_Contratado,
        
        Atributo1,
        
        ValorAtributo1,
        
        Atributo2,
        
        ValorAtributo2,
        
        Atributo3,
        
        ValorAtributo3,
        
        Atributo4,
        
        ValorAtributo4,
        
        Atributo5,
        
        ValorAtributo5,
        
        Atributo6,
        
        ValorAtributo6,
        
        Atributo7,
        
        ValorAtributo7,
        
        Atributo8,
        
        ValorAtributo8,
        
        Atributo9,
        
        ValorAtributo9,
        
        Atributo10,
        
        ValorAtributo10,
        
        AtributoId1,
        
        AtributoId2,
        
        AtributoId3,
        
        AtributoId4,
        
        AtributoId5,
        
        AtributoId6,
        
        AtributoId7,
        
        AtributoId8,
        
        AtributoId9,
        
        AtributoId10,
        
        ValorAtributoId1,
        
        ValorAtributoId2,
        
        ValorAtributoId3,
        
        ValorAtributoId4,
        
        ValorAtributoId5,
        
        ValorAtributoId6,
        
        ValorAtributoId7,
        
        ValorAtributoId8,
        
        ValorAtributoId9,
        
        ValorAtributoId10,
    }
    
    public partial class Contratado_Solicitud_DocumentoModel : BusinessRulesObjectModel
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratado_Solicitud_Documento_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _definicion_Solicitud_Documento_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _definicion_Solicitud_Documento_Definicion_Solicitud_Documento;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratado_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratado_Identificador_Unico;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _layout_HTML_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _layout_HTML_Layout_HTML_Nombre;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Emision_Documento;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _layout_Documento;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _pagadora_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pagadora_Pagadora;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _leyenda_Sindicato;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _destinatario;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sueldo_Empleado_Valor_Letra;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _domicilio_Contratante;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ciudad_Emision;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Ingreso_Empleado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Termino_Labores_Empleado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pictureFileName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pictureContentType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _pictureLength;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _picture2FileName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _picture2ContentType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _picture2Length;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _solicitud_Documento_Key;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Solicitud;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Solicitud_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Solicitud_Estatus_Solicitud;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Autorizacion_Rechazo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _autorizadoRechazadoPorusername;
        
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
        private string _nombre_Completo_Contratado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _emisor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _jefe_Sindicato;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Inicio_Vacaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Fin_Vacaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _dias_Descanso;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nombre_Menor_Guarderia;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _matricula_Persona;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _carrera_Universitaria;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _horas_Trabajadas;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _departamento_Emisor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _registro_Patronal;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _codigo_Postal_Contratante;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _numero_Telefonico_Contratante;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _finalidad_Documento_Guarderia_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nombre_Contratado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _atributo1;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _valorAtributo1;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _atributo2;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _valorAtributo2;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _atributo3;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _valorAtributo3;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _atributo4;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _valorAtributo4;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _atributo5;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _valorAtributo5;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _atributo6;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _valorAtributo6;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _atributo7;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _valorAtributo7;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _atributo8;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _valorAtributo8;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _atributo9;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _valorAtributo9;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _atributo10;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _valorAtributo10;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _atributoId1;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _atributoId2;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _atributoId3;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _atributoId4;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _atributoId5;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _atributoId6;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _atributoId7;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _atributoId8;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _atributoId9;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _atributoId10;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _valorAtributoId1;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _valorAtributoId2;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _valorAtributoId3;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _valorAtributoId4;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _valorAtributoId5;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _valorAtributoId6;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _valorAtributoId7;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _valorAtributoId8;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _valorAtributoId9;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _valorAtributoId10;
        
        public Contratado_Solicitud_DocumentoModel()
        {
        }
        
        public Contratado_Solicitud_DocumentoModel(BusinessRules r) : 
                base(r)
        {
        }
        
        public int? Contratado_Solicitud_Documento_Id
        {
            get
            {
                return _contratado_Solicitud_Documento_Id;
            }
            set
            {
                _contratado_Solicitud_Documento_Id = value;
                UpdateFieldValue("Contratado_Solicitud_Documento_Id", value);
            }
        }
        
        public int? Definicion_Solicitud_Documento_Id
        {
            get
            {
                return _definicion_Solicitud_Documento_Id;
            }
            set
            {
                _definicion_Solicitud_Documento_Id = value;
                UpdateFieldValue("Definicion_Solicitud_Documento_Id", value);
            }
        }
        
        public string Definicion_Solicitud_Documento_Definicion_Solicitud_Documento
        {
            get
            {
                return _definicion_Solicitud_Documento_Definicion_Solicitud_Documento;
            }
            set
            {
                _definicion_Solicitud_Documento_Definicion_Solicitud_Documento = value;
                UpdateFieldValue("Definicion_Solicitud_Documento_Definicion_Solicitud_Documento", value);
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
        
        public int? Layout_HTML_Id
        {
            get
            {
                return _layout_HTML_Id;
            }
            set
            {
                _layout_HTML_Id = value;
                UpdateFieldValue("Layout_HTML_Id", value);
            }
        }
        
        public string Layout_HTML_Layout_HTML_Nombre
        {
            get
            {
                return _layout_HTML_Layout_HTML_Nombre;
            }
            set
            {
                _layout_HTML_Layout_HTML_Nombre = value;
                UpdateFieldValue("Layout_HTML_Layout_HTML_Nombre", value);
            }
        }
        
        public DateTime? Fecha_Emision_Documento
        {
            get
            {
                return _fecha_Emision_Documento;
            }
            set
            {
                _fecha_Emision_Documento = value;
                UpdateFieldValue("Fecha_Emision_Documento", value);
            }
        }
        
        public string Layout_Documento
        {
            get
            {
                return _layout_Documento;
            }
            set
            {
                _layout_Documento = value;
                UpdateFieldValue("Layout_Documento", value);
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
        
        public string Leyenda_Sindicato
        {
            get
            {
                return _leyenda_Sindicato;
            }
            set
            {
                _leyenda_Sindicato = value;
                UpdateFieldValue("Leyenda_Sindicato", value);
            }
        }
        
        public string Destinatario
        {
            get
            {
                return _destinatario;
            }
            set
            {
                _destinatario = value;
                UpdateFieldValue("Destinatario", value);
            }
        }
        
        public string Sueldo_Empleado_Valor_Letra
        {
            get
            {
                return _sueldo_Empleado_Valor_Letra;
            }
            set
            {
                _sueldo_Empleado_Valor_Letra = value;
                UpdateFieldValue("Sueldo_Empleado_Valor_Letra", value);
            }
        }
        
        public string Domicilio_Contratante
        {
            get
            {
                return _domicilio_Contratante;
            }
            set
            {
                _domicilio_Contratante = value;
                UpdateFieldValue("Domicilio_Contratante", value);
            }
        }
        
        public string Ciudad_Emision
        {
            get
            {
                return _ciudad_Emision;
            }
            set
            {
                _ciudad_Emision = value;
                UpdateFieldValue("Ciudad_Emision", value);
            }
        }
        
        public DateTime? Fecha_Ingreso_Empleado
        {
            get
            {
                return _fecha_Ingreso_Empleado;
            }
            set
            {
                _fecha_Ingreso_Empleado = value;
                UpdateFieldValue("Fecha_Ingreso_Empleado", value);
            }
        }
        
        public DateTime? Fecha_Termino_Labores_Empleado
        {
            get
            {
                return _fecha_Termino_Labores_Empleado;
            }
            set
            {
                _fecha_Termino_Labores_Empleado = value;
                UpdateFieldValue("Fecha_Termino_Labores_Empleado", value);
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
        
        public string Picture2FileName
        {
            get
            {
                return _picture2FileName;
            }
            set
            {
                _picture2FileName = value;
                UpdateFieldValue("Picture2FileName", value);
            }
        }
        
        public string Picture2ContentType
        {
            get
            {
                return _picture2ContentType;
            }
            set
            {
                _picture2ContentType = value;
                UpdateFieldValue("Picture2ContentType", value);
            }
        }
        
        public int? Picture2Length
        {
            get
            {
                return _picture2Length;
            }
            set
            {
                _picture2Length = value;
                UpdateFieldValue("Picture2Length", value);
            }
        }
        
        public System.Guid? Solicitud_Documento_Key
        {
            get
            {
                return _solicitud_Documento_Key;
            }
            set
            {
                _solicitud_Documento_Key = value;
                UpdateFieldValue("Solicitud_Documento_Key", value);
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
        
        public string AutorizadoRechazadoPorusername
        {
            get
            {
                return _autorizadoRechazadoPorusername;
            }
            set
            {
                _autorizadoRechazadoPorusername = value;
                UpdateFieldValue("AutorizadoRechazadoPorusername", value);
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
        
        public string Nombre_Completo_Contratado
        {
            get
            {
                return _nombre_Completo_Contratado;
            }
            set
            {
                _nombre_Completo_Contratado = value;
                UpdateFieldValue("Nombre_Completo_Contratado", value);
            }
        }
        
        public string Emisor
        {
            get
            {
                return _emisor;
            }
            set
            {
                _emisor = value;
                UpdateFieldValue("Emisor", value);
            }
        }
        
        public string Jefe_Sindicato
        {
            get
            {
                return _jefe_Sindicato;
            }
            set
            {
                _jefe_Sindicato = value;
                UpdateFieldValue("Jefe_Sindicato", value);
            }
        }
        
        public DateTime? Fecha_Inicio_Vacaciones
        {
            get
            {
                return _fecha_Inicio_Vacaciones;
            }
            set
            {
                _fecha_Inicio_Vacaciones = value;
                UpdateFieldValue("Fecha_Inicio_Vacaciones", value);
            }
        }
        
        public DateTime? Fecha_Fin_Vacaciones
        {
            get
            {
                return _fecha_Fin_Vacaciones;
            }
            set
            {
                _fecha_Fin_Vacaciones = value;
                UpdateFieldValue("Fecha_Fin_Vacaciones", value);
            }
        }
        
        public string Dias_Descanso
        {
            get
            {
                return _dias_Descanso;
            }
            set
            {
                _dias_Descanso = value;
                UpdateFieldValue("Dias_Descanso", value);
            }
        }
        
        public string Nombre_Menor_Guarderia
        {
            get
            {
                return _nombre_Menor_Guarderia;
            }
            set
            {
                _nombre_Menor_Guarderia = value;
                UpdateFieldValue("Nombre_Menor_Guarderia", value);
            }
        }
        
        public string Matricula_Persona
        {
            get
            {
                return _matricula_Persona;
            }
            set
            {
                _matricula_Persona = value;
                UpdateFieldValue("Matricula_Persona", value);
            }
        }
        
        public string Carrera_Universitaria
        {
            get
            {
                return _carrera_Universitaria;
            }
            set
            {
                _carrera_Universitaria = value;
                UpdateFieldValue("Carrera_Universitaria", value);
            }
        }
        
        public int? Horas_Trabajadas
        {
            get
            {
                return _horas_Trabajadas;
            }
            set
            {
                _horas_Trabajadas = value;
                UpdateFieldValue("Horas_Trabajadas", value);
            }
        }
        
        public string Departamento_Emisor
        {
            get
            {
                return _departamento_Emisor;
            }
            set
            {
                _departamento_Emisor = value;
                UpdateFieldValue("Departamento_Emisor", value);
            }
        }
        
        public string Registro_Patronal
        {
            get
            {
                return _registro_Patronal;
            }
            set
            {
                _registro_Patronal = value;
                UpdateFieldValue("Registro_Patronal", value);
            }
        }
        
        public string Codigo_Postal_Contratante
        {
            get
            {
                return _codigo_Postal_Contratante;
            }
            set
            {
                _codigo_Postal_Contratante = value;
                UpdateFieldValue("Codigo_Postal_Contratante", value);
            }
        }
        
        public string Numero_Telefonico_Contratante
        {
            get
            {
                return _numero_Telefonico_Contratante;
            }
            set
            {
                _numero_Telefonico_Contratante = value;
                UpdateFieldValue("Numero_Telefonico_Contratante", value);
            }
        }
        
        public int? Finalidad_Documento_Guarderia_Id
        {
            get
            {
                return _finalidad_Documento_Guarderia_Id;
            }
            set
            {
                _finalidad_Documento_Guarderia_Id = value;
                UpdateFieldValue("Finalidad_Documento_Guarderia_Id", value);
            }
        }
        
        public string Nombre_Contratado
        {
            get
            {
                return _nombre_Contratado;
            }
            set
            {
                _nombre_Contratado = value;
                UpdateFieldValue("Nombre_Contratado", value);
            }
        }
        
        public string Atributo1
        {
            get
            {
                return _atributo1;
            }
            set
            {
                _atributo1 = value;
                UpdateFieldValue("Atributo1", value);
            }
        }
        
        public string ValorAtributo1
        {
            get
            {
                return _valorAtributo1;
            }
            set
            {
                _valorAtributo1 = value;
                UpdateFieldValue("ValorAtributo1", value);
            }
        }
        
        public string Atributo2
        {
            get
            {
                return _atributo2;
            }
            set
            {
                _atributo2 = value;
                UpdateFieldValue("Atributo2", value);
            }
        }
        
        public string ValorAtributo2
        {
            get
            {
                return _valorAtributo2;
            }
            set
            {
                _valorAtributo2 = value;
                UpdateFieldValue("ValorAtributo2", value);
            }
        }
        
        public string Atributo3
        {
            get
            {
                return _atributo3;
            }
            set
            {
                _atributo3 = value;
                UpdateFieldValue("Atributo3", value);
            }
        }
        
        public string ValorAtributo3
        {
            get
            {
                return _valorAtributo3;
            }
            set
            {
                _valorAtributo3 = value;
                UpdateFieldValue("ValorAtributo3", value);
            }
        }
        
        public string Atributo4
        {
            get
            {
                return _atributo4;
            }
            set
            {
                _atributo4 = value;
                UpdateFieldValue("Atributo4", value);
            }
        }
        
        public string ValorAtributo4
        {
            get
            {
                return _valorAtributo4;
            }
            set
            {
                _valorAtributo4 = value;
                UpdateFieldValue("ValorAtributo4", value);
            }
        }
        
        public string Atributo5
        {
            get
            {
                return _atributo5;
            }
            set
            {
                _atributo5 = value;
                UpdateFieldValue("Atributo5", value);
            }
        }
        
        public string ValorAtributo5
        {
            get
            {
                return _valorAtributo5;
            }
            set
            {
                _valorAtributo5 = value;
                UpdateFieldValue("ValorAtributo5", value);
            }
        }
        
        public string Atributo6
        {
            get
            {
                return _atributo6;
            }
            set
            {
                _atributo6 = value;
                UpdateFieldValue("Atributo6", value);
            }
        }
        
        public string ValorAtributo6
        {
            get
            {
                return _valorAtributo6;
            }
            set
            {
                _valorAtributo6 = value;
                UpdateFieldValue("ValorAtributo6", value);
            }
        }
        
        public string Atributo7
        {
            get
            {
                return _atributo7;
            }
            set
            {
                _atributo7 = value;
                UpdateFieldValue("Atributo7", value);
            }
        }
        
        public string ValorAtributo7
        {
            get
            {
                return _valorAtributo7;
            }
            set
            {
                _valorAtributo7 = value;
                UpdateFieldValue("ValorAtributo7", value);
            }
        }
        
        public string Atributo8
        {
            get
            {
                return _atributo8;
            }
            set
            {
                _atributo8 = value;
                UpdateFieldValue("Atributo8", value);
            }
        }
        
        public string ValorAtributo8
        {
            get
            {
                return _valorAtributo8;
            }
            set
            {
                _valorAtributo8 = value;
                UpdateFieldValue("ValorAtributo8", value);
            }
        }
        
        public string Atributo9
        {
            get
            {
                return _atributo9;
            }
            set
            {
                _atributo9 = value;
                UpdateFieldValue("Atributo9", value);
            }
        }
        
        public string ValorAtributo9
        {
            get
            {
                return _valorAtributo9;
            }
            set
            {
                _valorAtributo9 = value;
                UpdateFieldValue("ValorAtributo9", value);
            }
        }
        
        public string Atributo10
        {
            get
            {
                return _atributo10;
            }
            set
            {
                _atributo10 = value;
                UpdateFieldValue("Atributo10", value);
            }
        }
        
        public string ValorAtributo10
        {
            get
            {
                return _valorAtributo10;
            }
            set
            {
                _valorAtributo10 = value;
                UpdateFieldValue("ValorAtributo10", value);
            }
        }
        
        public int? AtributoId1
        {
            get
            {
                return _atributoId1;
            }
            set
            {
                _atributoId1 = value;
                UpdateFieldValue("AtributoId1", value);
            }
        }
        
        public int? AtributoId2
        {
            get
            {
                return _atributoId2;
            }
            set
            {
                _atributoId2 = value;
                UpdateFieldValue("AtributoId2", value);
            }
        }
        
        public int? AtributoId3
        {
            get
            {
                return _atributoId3;
            }
            set
            {
                _atributoId3 = value;
                UpdateFieldValue("AtributoId3", value);
            }
        }
        
        public int? AtributoId4
        {
            get
            {
                return _atributoId4;
            }
            set
            {
                _atributoId4 = value;
                UpdateFieldValue("AtributoId4", value);
            }
        }
        
        public int? AtributoId5
        {
            get
            {
                return _atributoId5;
            }
            set
            {
                _atributoId5 = value;
                UpdateFieldValue("AtributoId5", value);
            }
        }
        
        public int? AtributoId6
        {
            get
            {
                return _atributoId6;
            }
            set
            {
                _atributoId6 = value;
                UpdateFieldValue("AtributoId6", value);
            }
        }
        
        public int? AtributoId7
        {
            get
            {
                return _atributoId7;
            }
            set
            {
                _atributoId7 = value;
                UpdateFieldValue("AtributoId7", value);
            }
        }
        
        public int? AtributoId8
        {
            get
            {
                return _atributoId8;
            }
            set
            {
                _atributoId8 = value;
                UpdateFieldValue("AtributoId8", value);
            }
        }
        
        public int? AtributoId9
        {
            get
            {
                return _atributoId9;
            }
            set
            {
                _atributoId9 = value;
                UpdateFieldValue("AtributoId9", value);
            }
        }
        
        public int? AtributoId10
        {
            get
            {
                return _atributoId10;
            }
            set
            {
                _atributoId10 = value;
                UpdateFieldValue("AtributoId10", value);
            }
        }
        
        public int? ValorAtributoId1
        {
            get
            {
                return _valorAtributoId1;
            }
            set
            {
                _valorAtributoId1 = value;
                UpdateFieldValue("ValorAtributoId1", value);
            }
        }
        
        public int? ValorAtributoId2
        {
            get
            {
                return _valorAtributoId2;
            }
            set
            {
                _valorAtributoId2 = value;
                UpdateFieldValue("ValorAtributoId2", value);
            }
        }
        
        public int? ValorAtributoId3
        {
            get
            {
                return _valorAtributoId3;
            }
            set
            {
                _valorAtributoId3 = value;
                UpdateFieldValue("ValorAtributoId3", value);
            }
        }
        
        public int? ValorAtributoId4
        {
            get
            {
                return _valorAtributoId4;
            }
            set
            {
                _valorAtributoId4 = value;
                UpdateFieldValue("ValorAtributoId4", value);
            }
        }
        
        public int? ValorAtributoId5
        {
            get
            {
                return _valorAtributoId5;
            }
            set
            {
                _valorAtributoId5 = value;
                UpdateFieldValue("ValorAtributoId5", value);
            }
        }
        
        public int? ValorAtributoId6
        {
            get
            {
                return _valorAtributoId6;
            }
            set
            {
                _valorAtributoId6 = value;
                UpdateFieldValue("ValorAtributoId6", value);
            }
        }
        
        public int? ValorAtributoId7
        {
            get
            {
                return _valorAtributoId7;
            }
            set
            {
                _valorAtributoId7 = value;
                UpdateFieldValue("ValorAtributoId7", value);
            }
        }
        
        public int? ValorAtributoId8
        {
            get
            {
                return _valorAtributoId8;
            }
            set
            {
                _valorAtributoId8 = value;
                UpdateFieldValue("ValorAtributoId8", value);
            }
        }
        
        public int? ValorAtributoId9
        {
            get
            {
                return _valorAtributoId9;
            }
            set
            {
                _valorAtributoId9 = value;
                UpdateFieldValue("ValorAtributoId9", value);
            }
        }
        
        public int? ValorAtributoId10
        {
            get
            {
                return _valorAtributoId10;
            }
            set
            {
                _valorAtributoId10 = value;
                UpdateFieldValue("ValorAtributoId10", value);
            }
        }
        
        public FieldValue this[Contratado_Solicitud_DocumentoDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
