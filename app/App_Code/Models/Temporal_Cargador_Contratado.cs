using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using arhmexico.Data;

namespace arhmexico.Models
{
	public enum Temporal_Cargador_ContratadoDataField
    {
        
        Temporal_Cargador_Contratado_Id,
        
        Nombre,
        
        Segundo_Nombre,
        
        Apellido_Paterno,
        
        Apellido_Materno,
        
        Fecha_Nacimiento,
        
        Genero,
        
        RFC,
        
        Correo_Electronico_Personal,
        
        Correo_Electronico_Trabajo,
        
        Acceso_APP_Por_Kiosco,
        
        Identificador_Unico_Ordinario,
        
        Identificador_Unico_Asimilable,
        
        Tipo_Contratado,
        
        Tipo_Empleado,
        
        Turno_Laboral,
        
        Fecha_Contratacion,
        
        Fecha_Antiguedad,
        
        Vigencia_Contrato,
        
        Notas_Contratacion,
        
        Estatus_Contratado,
        
        Cliente,
        
        Clave_Cliente,
        
        Contratante,
        
        Clave_Contratante,
        
        Nombre_Dominio,
        
        Tipo_Estructura_Organizacional,
        
        Estructura_Organizacional,
        
        Permitir_Asociar_Personal,
        
        Estructura_Organizacional_PADRE,
        
        Contratante_Puesto,
        
        Contratante_Puesto_PADRE,
        
        Anio_Id,
        
        Fecha_Inicio,
        
        Fecha_Fin,
        
        Saldo_Vacaciones,
        
        Dias_Pendientes_Por_Tomar,
        
        Notas,
        
        Tipo_Operacion_Id,
        
        Mensaje_Sistema_Id,
        
        MensajeSistemamensajeAmigableUsuario,
        
        Estatus_Procesamiento_Id,
        
        EstatusProcesamientoestatusProcesamiento,
        
        Transaccion_Id,
        
        CreadoPorusername,
        
        Fecha_Creacion,
        
        ActualizadoPorusername,
        
        Fecha_Ultima_Actualizacion,
        
        Estatus_Registro_Id,
        
        Estatus_Registro_Estatus_Registro,
        
        Generar_Usuario_Acceso,
    }
    
    public partial class Temporal_Cargador_ContratadoModel : BusinessRulesObjectModel
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _temporal_Cargador_Contratado_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nombre;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _segundo_Nombre;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _apellido_Paterno;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _apellido_Materno;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Nacimiento;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _genero;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rFC;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _correo_Electronico_Personal;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _correo_Electronico_Trabajo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _acceso_APP_Por_Kiosco;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _identificador_Unico_Ordinario;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _identificador_Unico_Asimilable;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Contratado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Empleado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _turno_Laboral;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Contratacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Antiguedad;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _vigencia_Contrato;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _notas_Contratacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Contratado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cliente;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _clave_Cliente;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _clave_Contratante;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nombre_Dominio;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Estructura_Organizacional;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estructura_Organizacional;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _permitir_Asociar_Personal;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estructura_Organizacional_PADRE;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante_Puesto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contratante_Puesto_PADRE;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _anio_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Inicio;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Fin;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _saldo_Vacaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _dias_Pendientes_Por_Tomar;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _notas;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Operacion_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _mensaje_Sistema_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mensajeSistemamensajeAmigableUsuario;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Procesamiento_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatusProcesamientoestatusProcesamiento;
        
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
        private bool? _generar_Usuario_Acceso;
        
        public Temporal_Cargador_ContratadoModel()
        {
        }
        
        public Temporal_Cargador_ContratadoModel(BusinessRules r) : 
                base(r)
        {
        }
        
        public int? Temporal_Cargador_Contratado_Id
        {
            get
            {
                return _temporal_Cargador_Contratado_Id;
            }
            set
            {
                _temporal_Cargador_Contratado_Id = value;
                UpdateFieldValue("Temporal_Cargador_Contratado_Id", value);
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
        
        public string RFC
        {
            get
            {
                return _rFC;
            }
            set
            {
                _rFC = value;
                UpdateFieldValue("RFC", value);
            }
        }
        
        public string Correo_Electronico_Personal
        {
            get
            {
                return _correo_Electronico_Personal;
            }
            set
            {
                _correo_Electronico_Personal = value;
                UpdateFieldValue("Correo_Electronico_Personal", value);
            }
        }
        
        public string Correo_Electronico_Trabajo
        {
            get
            {
                return _correo_Electronico_Trabajo;
            }
            set
            {
                _correo_Electronico_Trabajo = value;
                UpdateFieldValue("Correo_Electronico_Trabajo", value);
            }
        }
        
        public bool? Acceso_APP_Por_Kiosco
        {
            get
            {
                return _acceso_APP_Por_Kiosco;
            }
            set
            {
                _acceso_APP_Por_Kiosco = value;
                UpdateFieldValue("Acceso_APP_Por_Kiosco", value);
            }
        }
        
        public string Identificador_Unico_Ordinario
        {
            get
            {
                return _identificador_Unico_Ordinario;
            }
            set
            {
                _identificador_Unico_Ordinario = value;
                UpdateFieldValue("Identificador_Unico_Ordinario", value);
            }
        }
        
        public string Identificador_Unico_Asimilable
        {
            get
            {
                return _identificador_Unico_Asimilable;
            }
            set
            {
                _identificador_Unico_Asimilable = value;
                UpdateFieldValue("Identificador_Unico_Asimilable", value);
            }
        }
        
        public string Tipo_Contratado
        {
            get
            {
                return _tipo_Contratado;
            }
            set
            {
                _tipo_Contratado = value;
                UpdateFieldValue("Tipo_Contratado", value);
            }
        }
        
        public string Tipo_Empleado
        {
            get
            {
                return _tipo_Empleado;
            }
            set
            {
                _tipo_Empleado = value;
                UpdateFieldValue("Tipo_Empleado", value);
            }
        }
        
        public string Turno_Laboral
        {
            get
            {
                return _turno_Laboral;
            }
            set
            {
                _turno_Laboral = value;
                UpdateFieldValue("Turno_Laboral", value);
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
        
        public string Estatus_Contratado
        {
            get
            {
                return _estatus_Contratado;
            }
            set
            {
                _estatus_Contratado = value;
                UpdateFieldValue("Estatus_Contratado", value);
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
        
        public string Clave_Cliente
        {
            get
            {
                return _clave_Cliente;
            }
            set
            {
                _clave_Cliente = value;
                UpdateFieldValue("Clave_Cliente", value);
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
        
        public string Clave_Contratante
        {
            get
            {
                return _clave_Contratante;
            }
            set
            {
                _clave_Contratante = value;
                UpdateFieldValue("Clave_Contratante", value);
            }
        }
        
        public string Nombre_Dominio
        {
            get
            {
                return _nombre_Dominio;
            }
            set
            {
                _nombre_Dominio = value;
                UpdateFieldValue("Nombre_Dominio", value);
            }
        }
        
        public string Tipo_Estructura_Organizacional
        {
            get
            {
                return _tipo_Estructura_Organizacional;
            }
            set
            {
                _tipo_Estructura_Organizacional = value;
                UpdateFieldValue("Tipo_Estructura_Organizacional", value);
            }
        }
        
        public string Estructura_Organizacional
        {
            get
            {
                return _estructura_Organizacional;
            }
            set
            {
                _estructura_Organizacional = value;
                UpdateFieldValue("Estructura_Organizacional", value);
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
        
        public string Estructura_Organizacional_PADRE
        {
            get
            {
                return _estructura_Organizacional_PADRE;
            }
            set
            {
                _estructura_Organizacional_PADRE = value;
                UpdateFieldValue("Estructura_Organizacional_PADRE", value);
            }
        }
        
        public string Contratante_Puesto
        {
            get
            {
                return _contratante_Puesto;
            }
            set
            {
                _contratante_Puesto = value;
                UpdateFieldValue("Contratante_Puesto", value);
            }
        }
        
        public string Contratante_Puesto_PADRE
        {
            get
            {
                return _contratante_Puesto_PADRE;
            }
            set
            {
                _contratante_Puesto_PADRE = value;
                UpdateFieldValue("Contratante_Puesto_PADRE", value);
            }
        }
        
        public int? Anio_Id
        {
            get
            {
                return _anio_Id;
            }
            set
            {
                _anio_Id = value;
                UpdateFieldValue("Anio_Id", value);
            }
        }
        
        public DateTime? Fecha_Inicio
        {
            get
            {
                return _fecha_Inicio;
            }
            set
            {
                _fecha_Inicio = value;
                UpdateFieldValue("Fecha_Inicio", value);
            }
        }
        
        public DateTime? Fecha_Fin
        {
            get
            {
                return _fecha_Fin;
            }
            set
            {
                _fecha_Fin = value;
                UpdateFieldValue("Fecha_Fin", value);
            }
        }
        
        public int? Saldo_Vacaciones
        {
            get
            {
                return _saldo_Vacaciones;
            }
            set
            {
                _saldo_Vacaciones = value;
                UpdateFieldValue("Saldo_Vacaciones", value);
            }
        }
        
        public int? Dias_Pendientes_Por_Tomar
        {
            get
            {
                return _dias_Pendientes_Por_Tomar;
            }
            set
            {
                _dias_Pendientes_Por_Tomar = value;
                UpdateFieldValue("Dias_Pendientes_Por_Tomar", value);
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
        
        public int? Tipo_Operacion_Id
        {
            get
            {
                return _tipo_Operacion_Id;
            }
            set
            {
                _tipo_Operacion_Id = value;
                UpdateFieldValue("Tipo_Operacion_Id", value);
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
        
        public string MensajeSistemamensajeAmigableUsuario
        {
            get
            {
                return _mensajeSistemamensajeAmigableUsuario;
            }
            set
            {
                _mensajeSistemamensajeAmigableUsuario = value;
                UpdateFieldValue("MensajeSistemamensajeAmigableUsuario", value);
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
        
        public string EstatusProcesamientoestatusProcesamiento
        {
            get
            {
                return _estatusProcesamientoestatusProcesamiento;
            }
            set
            {
                _estatusProcesamientoestatusProcesamiento = value;
                UpdateFieldValue("EstatusProcesamientoestatusProcesamiento", value);
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
        
        public FieldValue this[Temporal_Cargador_ContratadoDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
