using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using arhmexico.Data;

namespace arhmexico.Models
{
	public enum Carga_SGMMenDataField
    {
        
        Temporal_Seguro_Id,
        
        Seguro_Id,
        
        Contratado_Id,
        
        Persona_Id,
        
        Es_Titular,
        
        Beneficiario_Id,
        
        Parentesco_Id,
        
        Genero_Id,
        
        Categoria_Seguro_Id,
        
        Sociedad_Id,
        
        Cliente_Id,
        
        Tipo_Seguro_Id,
        
        Aseguradora_Id,
        
        Tipo_Asegurado_Id,
        
        Periodicidad_Id,
        
        Anio_Id,
        
        Proveedor_Id,
        
        Certificado,
        
        Tipo_Seguro,
        
        Aseguradora,
        
        Categoria_Seguro,
        
        Clave_Categoria_Seguro,
        
        Parentesco,
        
        Clave_Parentesco,
        
        Genero,
        
        Clave_Genero,
        
        Fecha_Movimiento,
        
        Numero_Movimiento,
        
        Tipo_Asegurado,
        
        Clave_Tipo_Asegurado,
        
        Fecha_Calculo,
        
        Prima_Tarifa,
        
        Recargo,
        
        Gastos_Expedicion,
        
        IVA,
        
        Subsecuente,
        
        Complemento,
        
        Solo_Complemento,
        
        Porcentaje_Suma_Asegurada,
        
        Periodicidad,
        
        Anio,
        
        Fecha_Alta,
        
        Fecha_Inicio,
        
        Fecha_Fin,
        
        Importe,
        
        Suma,
        
        Nombre_Completo,
        
        Apellido_Paterno,
        
        Apellido_Materno,
        
        Nombre,
        
        Sociedad,
        
        Cliente,
        
        Proveedor,
        
        Tipo_Movimiento,
        
        Tipo_Registro,
        
        Forma_Recuperacion,
        
        Tipo_Operacion,
        
        Mensaje_Sistema_Id,
        
        Estatus_Procesamiento_Id,
        
        Transaccion_Id,
        
        Creado_Por_Id,
        
        Fecha_Creacion,
        
        Actualizado_Por_Id,
        
        Fecha_Ultima_Actualizacion,
        
        Estatus_Registro_Id,
        
        Estatus_Registro_Estatus_Registro,
        
        Fecha_Nacimiento,
    }
    
    public partial class Carga_SGMMenModel : BusinessRulesObjectModel
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _temporal_Seguro_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _seguro_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratado_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _persona_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Titular;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _beneficiario_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _parentesco_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _genero_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _categoria_Seguro_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _sociedad_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _cliente_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Seguro_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _aseguradora_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Asegurado_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _periodicidad_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _anio_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _proveedor_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _certificado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Seguro;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _aseguradora;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _categoria_Seguro;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _clave_Categoria_Seguro;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parentesco;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _clave_Parentesco;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _genero;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _clave_Genero;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Movimiento;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _numero_Movimiento;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Asegurado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _clave_Tipo_Asegurado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Calculo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _prima_Tarifa;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _recargo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _gastos_Expedicion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _iVA;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _subsecuente;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _complemento;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _solo_Complemento;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _porcentaje_Suma_Asegurada;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _periodicidad;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _anio;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Alta;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Inicio;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Fin;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _importe;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _suma;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nombre_Completo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _apellido_Paterno;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _apellido_Materno;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nombre;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sociedad;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cliente;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _proveedor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Movimiento;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Registro;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _forma_Recuperacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Operacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _mensaje_Sistema_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Procesamiento_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transaccion_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _creado_Por_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Creacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _actualizado_Por_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Ultima_Actualizacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Registro_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Registro_Estatus_Registro;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Nacimiento;
        
        public Carga_SGMMenModel()
        {
        }
        
        public Carga_SGMMenModel(BusinessRules r) : 
                base(r)
        {
        }
        
        public int? Temporal_Seguro_Id
        {
            get
            {
                return _temporal_Seguro_Id;
            }
            set
            {
                _temporal_Seguro_Id = value;
                UpdateFieldValue("Temporal_Seguro_Id", value);
            }
        }
        
        public int? Seguro_Id
        {
            get
            {
                return _seguro_Id;
            }
            set
            {
                _seguro_Id = value;
                UpdateFieldValue("Seguro_Id", value);
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
        
        public bool? Es_Titular
        {
            get
            {
                return _es_Titular;
            }
            set
            {
                _es_Titular = value;
                UpdateFieldValue("Es_Titular", value);
            }
        }
        
        public int? Beneficiario_Id
        {
            get
            {
                return _beneficiario_Id;
            }
            set
            {
                _beneficiario_Id = value;
                UpdateFieldValue("Beneficiario_Id", value);
            }
        }
        
        public int? Parentesco_Id
        {
            get
            {
                return _parentesco_Id;
            }
            set
            {
                _parentesco_Id = value;
                UpdateFieldValue("Parentesco_Id", value);
            }
        }
        
        public int? Genero_Id
        {
            get
            {
                return _genero_Id;
            }
            set
            {
                _genero_Id = value;
                UpdateFieldValue("Genero_Id", value);
            }
        }
        
        public int? Categoria_Seguro_Id
        {
            get
            {
                return _categoria_Seguro_Id;
            }
            set
            {
                _categoria_Seguro_Id = value;
                UpdateFieldValue("Categoria_Seguro_Id", value);
            }
        }
        
        public int? Sociedad_Id
        {
            get
            {
                return _sociedad_Id;
            }
            set
            {
                _sociedad_Id = value;
                UpdateFieldValue("Sociedad_Id", value);
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
        
        public int? Tipo_Seguro_Id
        {
            get
            {
                return _tipo_Seguro_Id;
            }
            set
            {
                _tipo_Seguro_Id = value;
                UpdateFieldValue("Tipo_Seguro_Id", value);
            }
        }
        
        public int? Aseguradora_Id
        {
            get
            {
                return _aseguradora_Id;
            }
            set
            {
                _aseguradora_Id = value;
                UpdateFieldValue("Aseguradora_Id", value);
            }
        }
        
        public int? Tipo_Asegurado_Id
        {
            get
            {
                return _tipo_Asegurado_Id;
            }
            set
            {
                _tipo_Asegurado_Id = value;
                UpdateFieldValue("Tipo_Asegurado_Id", value);
            }
        }
        
        public int? Periodicidad_Id
        {
            get
            {
                return _periodicidad_Id;
            }
            set
            {
                _periodicidad_Id = value;
                UpdateFieldValue("Periodicidad_Id", value);
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
        
        public int? Proveedor_Id
        {
            get
            {
                return _proveedor_Id;
            }
            set
            {
                _proveedor_Id = value;
                UpdateFieldValue("Proveedor_Id", value);
            }
        }
        
        public string Certificado
        {
            get
            {
                return _certificado;
            }
            set
            {
                _certificado = value;
                UpdateFieldValue("Certificado", value);
            }
        }
        
        public string Tipo_Seguro
        {
            get
            {
                return _tipo_Seguro;
            }
            set
            {
                _tipo_Seguro = value;
                UpdateFieldValue("Tipo_Seguro", value);
            }
        }
        
        public string Aseguradora
        {
            get
            {
                return _aseguradora;
            }
            set
            {
                _aseguradora = value;
                UpdateFieldValue("Aseguradora", value);
            }
        }
        
        public string Categoria_Seguro
        {
            get
            {
                return _categoria_Seguro;
            }
            set
            {
                _categoria_Seguro = value;
                UpdateFieldValue("Categoria_Seguro", value);
            }
        }
        
        public string Clave_Categoria_Seguro
        {
            get
            {
                return _clave_Categoria_Seguro;
            }
            set
            {
                _clave_Categoria_Seguro = value;
                UpdateFieldValue("Clave_Categoria_Seguro", value);
            }
        }
        
        public string Parentesco
        {
            get
            {
                return _parentesco;
            }
            set
            {
                _parentesco = value;
                UpdateFieldValue("Parentesco", value);
            }
        }
        
        public string Clave_Parentesco
        {
            get
            {
                return _clave_Parentesco;
            }
            set
            {
                _clave_Parentesco = value;
                UpdateFieldValue("Clave_Parentesco", value);
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
        
        public string Clave_Genero
        {
            get
            {
                return _clave_Genero;
            }
            set
            {
                _clave_Genero = value;
                UpdateFieldValue("Clave_Genero", value);
            }
        }
        
        public DateTime? Fecha_Movimiento
        {
            get
            {
                return _fecha_Movimiento;
            }
            set
            {
                _fecha_Movimiento = value;
                UpdateFieldValue("Fecha_Movimiento", value);
            }
        }
        
        public int? Numero_Movimiento
        {
            get
            {
                return _numero_Movimiento;
            }
            set
            {
                _numero_Movimiento = value;
                UpdateFieldValue("Numero_Movimiento", value);
            }
        }
        
        public string Tipo_Asegurado
        {
            get
            {
                return _tipo_Asegurado;
            }
            set
            {
                _tipo_Asegurado = value;
                UpdateFieldValue("Tipo_Asegurado", value);
            }
        }
        
        public string Clave_Tipo_Asegurado
        {
            get
            {
                return _clave_Tipo_Asegurado;
            }
            set
            {
                _clave_Tipo_Asegurado = value;
                UpdateFieldValue("Clave_Tipo_Asegurado", value);
            }
        }
        
        public DateTime? Fecha_Calculo
        {
            get
            {
                return _fecha_Calculo;
            }
            set
            {
                _fecha_Calculo = value;
                UpdateFieldValue("Fecha_Calculo", value);
            }
        }
        
        public decimal? Prima_Tarifa
        {
            get
            {
                return _prima_Tarifa;
            }
            set
            {
                _prima_Tarifa = value;
                UpdateFieldValue("Prima_Tarifa", value);
            }
        }
        
        public decimal? Recargo
        {
            get
            {
                return _recargo;
            }
            set
            {
                _recargo = value;
                UpdateFieldValue("Recargo", value);
            }
        }
        
        public decimal? Gastos_Expedicion
        {
            get
            {
                return _gastos_Expedicion;
            }
            set
            {
                _gastos_Expedicion = value;
                UpdateFieldValue("Gastos_Expedicion", value);
            }
        }
        
        public decimal? IVA
        {
            get
            {
                return _iVA;
            }
            set
            {
                _iVA = value;
                UpdateFieldValue("IVA", value);
            }
        }
        
        public decimal? Subsecuente
        {
            get
            {
                return _subsecuente;
            }
            set
            {
                _subsecuente = value;
                UpdateFieldValue("Subsecuente", value);
            }
        }
        
        public decimal? Complemento
        {
            get
            {
                return _complemento;
            }
            set
            {
                _complemento = value;
                UpdateFieldValue("Complemento", value);
            }
        }
        
        public decimal? Solo_Complemento
        {
            get
            {
                return _solo_Complemento;
            }
            set
            {
                _solo_Complemento = value;
                UpdateFieldValue("Solo_Complemento", value);
            }
        }
        
        public int? Porcentaje_Suma_Asegurada
        {
            get
            {
                return _porcentaje_Suma_Asegurada;
            }
            set
            {
                _porcentaje_Suma_Asegurada = value;
                UpdateFieldValue("Porcentaje_Suma_Asegurada", value);
            }
        }
        
        public string Periodicidad
        {
            get
            {
                return _periodicidad;
            }
            set
            {
                _periodicidad = value;
                UpdateFieldValue("Periodicidad", value);
            }
        }
        
        public string Anio
        {
            get
            {
                return _anio;
            }
            set
            {
                _anio = value;
                UpdateFieldValue("Anio", value);
            }
        }
        
        public DateTime? Fecha_Alta
        {
            get
            {
                return _fecha_Alta;
            }
            set
            {
                _fecha_Alta = value;
                UpdateFieldValue("Fecha_Alta", value);
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
        
        public decimal? Importe
        {
            get
            {
                return _importe;
            }
            set
            {
                _importe = value;
                UpdateFieldValue("Importe", value);
            }
        }
        
        public decimal? Suma
        {
            get
            {
                return _suma;
            }
            set
            {
                _suma = value;
                UpdateFieldValue("Suma", value);
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
        
        public string Sociedad
        {
            get
            {
                return _sociedad;
            }
            set
            {
                _sociedad = value;
                UpdateFieldValue("Sociedad", value);
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
        
        public string Proveedor
        {
            get
            {
                return _proveedor;
            }
            set
            {
                _proveedor = value;
                UpdateFieldValue("Proveedor", value);
            }
        }
        
        public string Tipo_Movimiento
        {
            get
            {
                return _tipo_Movimiento;
            }
            set
            {
                _tipo_Movimiento = value;
                UpdateFieldValue("Tipo_Movimiento", value);
            }
        }
        
        public string Tipo_Registro
        {
            get
            {
                return _tipo_Registro;
            }
            set
            {
                _tipo_Registro = value;
                UpdateFieldValue("Tipo_Registro", value);
            }
        }
        
        public string Forma_Recuperacion
        {
            get
            {
                return _forma_Recuperacion;
            }
            set
            {
                _forma_Recuperacion = value;
                UpdateFieldValue("Forma_Recuperacion", value);
            }
        }
        
        public string Tipo_Operacion
        {
            get
            {
                return _tipo_Operacion;
            }
            set
            {
                _tipo_Operacion = value;
                UpdateFieldValue("Tipo_Operacion", value);
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
        
        public FieldValue this[Carga_SGMMenDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
