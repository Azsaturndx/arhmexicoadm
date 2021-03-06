﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using arhmexico.Data;

namespace arhmexico.Models
{
	public enum Administracion_Gasto_ProveedorDataField
    {
        
        Administracion_Gasto_Id,
        
        Contratado_Id,
        
        Tipo_Gasto_Id,
        
        Tipo_Gasto_Tipo_Gasto,
        
        Es_Otro,
        
        Es_Gasolina,
        
        Monto_Gasto,
        
        Fecha_Gasto,
        
        Direccion_Origen,
        
        Direccion_Destino,
        
        Ciudad_Origen_Id,
        
        Ciudad_Origen,
        
        Ciudad_Destino_Id,
        
        Ciudad_Destino,
        
        Kilometraje,
        
        Viaje_Redondo,
        
        Estatus_Gasto_Id,
        
        Estatus_Gasto_Estatus_Gasto,
        
        Autorizado_Rechazado_Por_Id,
        
        Fecha_Autorizacion_Rechazo,
        
        Comentarios_Autorizacion_Rechazo,
        
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
        
        Servicio_Id,
        
        Servicio,
        
        Gastos_Frecuentes_Id,
        
        Notas,
        
        Latitud,
        
        Longitud,
        
        PictureFileName,
        
        PictureContentType,
        
        PictureLength,
        
        Pagado,
        
        Fecha_Pago,
        
        Notas_Pago,
        
        Fecha_Confirmacion_Pago,
        
        Pago_Confirmado_Por_Id,
        
        PcpUserName,
        
        Sociedad_Id,
        
        Sociedad_Cuadro_Accionario_Id,
        
        Proveedor_Id,
        
        Proveedor_Arrendamiento_Id,
        
        Mes_Gasto_Id,
        
        Solicitado_Por_Id,
        
        Fecha_Solicitud,
        
        Notas_Solicitud,
        
        Fecha_Vencimiento,
        
        Picture2FileName,
        
        Picture2ContentType,
        
        Picture2Length,
        
        MontoGastoAutorizado,
        
        Mostrar_Lista_Gastos_Frecuentes,
        
        Gastos_Frecuentes,
        
        Mostrar_Mapa,
        
        Servicio_Hospedaje_Id,
        
        Otro_Id,
        
        Otros_Etiqueta,
        
        Terrestre_Id,
        
        Terrestre_Etiqueta,
        
        Servicio_Hospedaje_Etiqueta,
        
        Servicio_Vuelo_Id,
        
        Servicio_Vuelo_Etiqueta,
        
        Servicio_Gasolina_Id,
        
        Servicio_Gasolina_Etiqueta,
        
        Servicio_Alimentos_Id,
        
        Servicio_Alimentos_Etiqueta,
        
        Servicio_Terrestre_Id,
        
        Servicio_Terrestre_Etiqueta,
        
        Servicio_Otros_Id,
        
        Servicio_Otros_Etiqueta,
        
        Es_De_Hospedaje,
        
        Es_De_Alimentos,
        
        Es_Aerolinea,
        
        Es_Transporte_Terrestre,
        
        Significa_Pendiente,
        
        Significa_Autorizado,
        
        Significa_Rechazado,
        
        Autorizado_Rechazado_Por,
        
        Mes_Mes,
        
        Solicitado_Por,
        
        Es_Periodico,
        
        Es_Servicio_Basico,
        
        Es_De_Mantenimiento,
        
        Es_Fiscal,
        
        Es_Dividendo,
        
        Es_Renta,
        
        Aplica_Solicitud,
        
        Aplica_Autorizacion,
        
        Aplica_Para_Sociedad,
        
        Aplica_Para_Sociedad_Cuadro_Accionario,
        
        Aplica_Para_Contratado,
        
        Sociedad_Sociedad,
        
        Tipo_Gasto_Mantenimiento_Id,
        
        Tipo_Gasto_Mantenimiento,
        
        Tipo_Gasto_Servicio_Basico_Id,
        
        Tipo_Gasto_Servicio_Basico,
        
        Accionista,
        
        Proveedor_Arrendamiento_Proveedor_Proveedor,
        
        Proveedor_Proveedor,
    }
    
    public partial class Administracion_Gasto_ProveedorModel : BusinessRulesObjectModel
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _administracion_Gasto_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contratado_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Gasto_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Gasto_Tipo_Gasto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Otro;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Gasolina;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _monto_Gasto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Gasto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _direccion_Origen;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _direccion_Destino;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _ciudad_Origen_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ciudad_Origen;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _ciudad_Destino_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ciudad_Destino;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _kilometraje;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _viaje_Redondo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Gasto_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Gasto_Estatus_Gasto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _autorizado_Rechazado_Por_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Autorizacion_Rechazo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _comentarios_Autorizacion_Rechazo;
        
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
        private int? _servicio_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _servicio;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _gastos_Frecuentes_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _notas;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _latitud;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _longitud;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pictureFileName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pictureContentType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _pictureLength;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _pagado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Pago;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _notas_Pago;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Confirmacion_Pago;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _pago_Confirmado_Por_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pcpUserName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _sociedad_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _sociedad_Cuadro_Accionario_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _proveedor_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _proveedor_Arrendamiento_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _mes_Gasto_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _solicitado_Por_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Solicitud;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _notas_Solicitud;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Vencimiento;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _picture2FileName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _picture2ContentType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _picture2Length;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _montoGastoAutorizado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _mostrar_Lista_Gastos_Frecuentes;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _gastos_Frecuentes;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _mostrar_Mapa;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _servicio_Hospedaje_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _otro_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otros_Etiqueta;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _terrestre_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _terrestre_Etiqueta;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _servicio_Hospedaje_Etiqueta;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _servicio_Vuelo_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _servicio_Vuelo_Etiqueta;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _servicio_Gasolina_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _servicio_Gasolina_Etiqueta;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _servicio_Alimentos_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _servicio_Alimentos_Etiqueta;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _servicio_Terrestre_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _servicio_Terrestre_Etiqueta;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _servicio_Otros_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _servicio_Otros_Etiqueta;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_De_Hospedaje;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_De_Alimentos;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Aerolinea;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Transporte_Terrestre;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _significa_Pendiente;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _significa_Autorizado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _significa_Rechazado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _autorizado_Rechazado_Por;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mes_Mes;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _solicitado_Por;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Periodico;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Servicio_Basico;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_De_Mantenimiento;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Fiscal;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Dividendo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Renta;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _aplica_Solicitud;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _aplica_Autorizacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _aplica_Para_Sociedad;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _aplica_Para_Sociedad_Cuadro_Accionario;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _aplica_Para_Contratado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sociedad_Sociedad;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Gasto_Mantenimiento_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Gasto_Mantenimiento;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Gasto_Servicio_Basico_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Gasto_Servicio_Basico;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accionista;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _proveedor_Arrendamiento_Proveedor_Proveedor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _proveedor_Proveedor;
        
        public Administracion_Gasto_ProveedorModel()
        {
        }
        
        public Administracion_Gasto_ProveedorModel(BusinessRules r) : 
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
        
        public int? Tipo_Gasto_Id
        {
            get
            {
                return _tipo_Gasto_Id;
            }
            set
            {
                _tipo_Gasto_Id = value;
                UpdateFieldValue("Tipo_Gasto_Id", value);
            }
        }
        
        public string Tipo_Gasto_Tipo_Gasto
        {
            get
            {
                return _tipo_Gasto_Tipo_Gasto;
            }
            set
            {
                _tipo_Gasto_Tipo_Gasto = value;
                UpdateFieldValue("Tipo_Gasto_Tipo_Gasto", value);
            }
        }
        
        public bool? Es_Otro
        {
            get
            {
                return _es_Otro;
            }
            set
            {
                _es_Otro = value;
                UpdateFieldValue("Es_Otro", value);
            }
        }
        
        public bool? Es_Gasolina
        {
            get
            {
                return _es_Gasolina;
            }
            set
            {
                _es_Gasolina = value;
                UpdateFieldValue("Es_Gasolina", value);
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
        
        public DateTime? Fecha_Gasto
        {
            get
            {
                return _fecha_Gasto;
            }
            set
            {
                _fecha_Gasto = value;
                UpdateFieldValue("Fecha_Gasto", value);
            }
        }
        
        public string Direccion_Origen
        {
            get
            {
                return _direccion_Origen;
            }
            set
            {
                _direccion_Origen = value;
                UpdateFieldValue("Direccion_Origen", value);
            }
        }
        
        public string Direccion_Destino
        {
            get
            {
                return _direccion_Destino;
            }
            set
            {
                _direccion_Destino = value;
                UpdateFieldValue("Direccion_Destino", value);
            }
        }
        
        public int? Ciudad_Origen_Id
        {
            get
            {
                return _ciudad_Origen_Id;
            }
            set
            {
                _ciudad_Origen_Id = value;
                UpdateFieldValue("Ciudad_Origen_Id", value);
            }
        }
        
        public string Ciudad_Origen
        {
            get
            {
                return _ciudad_Origen;
            }
            set
            {
                _ciudad_Origen = value;
                UpdateFieldValue("Ciudad_Origen", value);
            }
        }
        
        public int? Ciudad_Destino_Id
        {
            get
            {
                return _ciudad_Destino_Id;
            }
            set
            {
                _ciudad_Destino_Id = value;
                UpdateFieldValue("Ciudad_Destino_Id", value);
            }
        }
        
        public string Ciudad_Destino
        {
            get
            {
                return _ciudad_Destino;
            }
            set
            {
                _ciudad_Destino = value;
                UpdateFieldValue("Ciudad_Destino", value);
            }
        }
        
        public decimal? Kilometraje
        {
            get
            {
                return _kilometraje;
            }
            set
            {
                _kilometraje = value;
                UpdateFieldValue("Kilometraje", value);
            }
        }
        
        public bool? Viaje_Redondo
        {
            get
            {
                return _viaje_Redondo;
            }
            set
            {
                _viaje_Redondo = value;
                UpdateFieldValue("Viaje_Redondo", value);
            }
        }
        
        public int? Estatus_Gasto_Id
        {
            get
            {
                return _estatus_Gasto_Id;
            }
            set
            {
                _estatus_Gasto_Id = value;
                UpdateFieldValue("Estatus_Gasto_Id", value);
            }
        }
        
        public string Estatus_Gasto_Estatus_Gasto
        {
            get
            {
                return _estatus_Gasto_Estatus_Gasto;
            }
            set
            {
                _estatus_Gasto_Estatus_Gasto = value;
                UpdateFieldValue("Estatus_Gasto_Estatus_Gasto", value);
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
        
        public int? Servicio_Id
        {
            get
            {
                return _servicio_Id;
            }
            set
            {
                _servicio_Id = value;
                UpdateFieldValue("Servicio_Id", value);
            }
        }
        
        public string Servicio
        {
            get
            {
                return _servicio;
            }
            set
            {
                _servicio = value;
                UpdateFieldValue("Servicio", value);
            }
        }
        
        public int? Gastos_Frecuentes_Id
        {
            get
            {
                return _gastos_Frecuentes_Id;
            }
            set
            {
                _gastos_Frecuentes_Id = value;
                UpdateFieldValue("Gastos_Frecuentes_Id", value);
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
        
        public decimal? Latitud
        {
            get
            {
                return _latitud;
            }
            set
            {
                _latitud = value;
                UpdateFieldValue("Latitud", value);
            }
        }
        
        public decimal? Longitud
        {
            get
            {
                return _longitud;
            }
            set
            {
                _longitud = value;
                UpdateFieldValue("Longitud", value);
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
        
        public bool? Pagado
        {
            get
            {
                return _pagado;
            }
            set
            {
                _pagado = value;
                UpdateFieldValue("Pagado", value);
            }
        }
        
        public DateTime? Fecha_Pago
        {
            get
            {
                return _fecha_Pago;
            }
            set
            {
                _fecha_Pago = value;
                UpdateFieldValue("Fecha_Pago", value);
            }
        }
        
        public string Notas_Pago
        {
            get
            {
                return _notas_Pago;
            }
            set
            {
                _notas_Pago = value;
                UpdateFieldValue("Notas_Pago", value);
            }
        }
        
        public DateTime? Fecha_Confirmacion_Pago
        {
            get
            {
                return _fecha_Confirmacion_Pago;
            }
            set
            {
                _fecha_Confirmacion_Pago = value;
                UpdateFieldValue("Fecha_Confirmacion_Pago", value);
            }
        }
        
        public System.Guid? Pago_Confirmado_Por_Id
        {
            get
            {
                return _pago_Confirmado_Por_Id;
            }
            set
            {
                _pago_Confirmado_Por_Id = value;
                UpdateFieldValue("Pago_Confirmado_Por_Id", value);
            }
        }
        
        public string PcpUserName
        {
            get
            {
                return _pcpUserName;
            }
            set
            {
                _pcpUserName = value;
                UpdateFieldValue("PcpUserName", value);
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
        
        public int? Sociedad_Cuadro_Accionario_Id
        {
            get
            {
                return _sociedad_Cuadro_Accionario_Id;
            }
            set
            {
                _sociedad_Cuadro_Accionario_Id = value;
                UpdateFieldValue("Sociedad_Cuadro_Accionario_Id", value);
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
        
        public int? Proveedor_Arrendamiento_Id
        {
            get
            {
                return _proveedor_Arrendamiento_Id;
            }
            set
            {
                _proveedor_Arrendamiento_Id = value;
                UpdateFieldValue("Proveedor_Arrendamiento_Id", value);
            }
        }
        
        public int? Mes_Gasto_Id
        {
            get
            {
                return _mes_Gasto_Id;
            }
            set
            {
                _mes_Gasto_Id = value;
                UpdateFieldValue("Mes_Gasto_Id", value);
            }
        }
        
        public System.Guid? Solicitado_Por_Id
        {
            get
            {
                return _solicitado_Por_Id;
            }
            set
            {
                _solicitado_Por_Id = value;
                UpdateFieldValue("Solicitado_Por_Id", value);
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
        
        public string Notas_Solicitud
        {
            get
            {
                return _notas_Solicitud;
            }
            set
            {
                _notas_Solicitud = value;
                UpdateFieldValue("Notas_Solicitud", value);
            }
        }
        
        public DateTime? Fecha_Vencimiento
        {
            get
            {
                return _fecha_Vencimiento;
            }
            set
            {
                _fecha_Vencimiento = value;
                UpdateFieldValue("Fecha_Vencimiento", value);
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
        
        public decimal? MontoGastoAutorizado
        {
            get
            {
                return _montoGastoAutorizado;
            }
            set
            {
                _montoGastoAutorizado = value;
                UpdateFieldValue("MontoGastoAutorizado", value);
            }
        }
        
        public bool? Mostrar_Lista_Gastos_Frecuentes
        {
            get
            {
                return _mostrar_Lista_Gastos_Frecuentes;
            }
            set
            {
                _mostrar_Lista_Gastos_Frecuentes = value;
                UpdateFieldValue("Mostrar_Lista_Gastos_Frecuentes", value);
            }
        }
        
        public string Gastos_Frecuentes
        {
            get
            {
                return _gastos_Frecuentes;
            }
            set
            {
                _gastos_Frecuentes = value;
                UpdateFieldValue("Gastos_Frecuentes", value);
            }
        }
        
        public bool? Mostrar_Mapa
        {
            get
            {
                return _mostrar_Mapa;
            }
            set
            {
                _mostrar_Mapa = value;
                UpdateFieldValue("Mostrar_Mapa", value);
            }
        }
        
        public int? Servicio_Hospedaje_Id
        {
            get
            {
                return _servicio_Hospedaje_Id;
            }
            set
            {
                _servicio_Hospedaje_Id = value;
                UpdateFieldValue("Servicio_Hospedaje_Id", value);
            }
        }
        
        public int? Otro_Id
        {
            get
            {
                return _otro_Id;
            }
            set
            {
                _otro_Id = value;
                UpdateFieldValue("Otro_Id", value);
            }
        }
        
        public string Otros_Etiqueta
        {
            get
            {
                return _otros_Etiqueta;
            }
            set
            {
                _otros_Etiqueta = value;
                UpdateFieldValue("Otros_Etiqueta", value);
            }
        }
        
        public int? Terrestre_Id
        {
            get
            {
                return _terrestre_Id;
            }
            set
            {
                _terrestre_Id = value;
                UpdateFieldValue("Terrestre_Id", value);
            }
        }
        
        public string Terrestre_Etiqueta
        {
            get
            {
                return _terrestre_Etiqueta;
            }
            set
            {
                _terrestre_Etiqueta = value;
                UpdateFieldValue("Terrestre_Etiqueta", value);
            }
        }
        
        public string Servicio_Hospedaje_Etiqueta
        {
            get
            {
                return _servicio_Hospedaje_Etiqueta;
            }
            set
            {
                _servicio_Hospedaje_Etiqueta = value;
                UpdateFieldValue("Servicio_Hospedaje_Etiqueta", value);
            }
        }
        
        public int? Servicio_Vuelo_Id
        {
            get
            {
                return _servicio_Vuelo_Id;
            }
            set
            {
                _servicio_Vuelo_Id = value;
                UpdateFieldValue("Servicio_Vuelo_Id", value);
            }
        }
        
        public string Servicio_Vuelo_Etiqueta
        {
            get
            {
                return _servicio_Vuelo_Etiqueta;
            }
            set
            {
                _servicio_Vuelo_Etiqueta = value;
                UpdateFieldValue("Servicio_Vuelo_Etiqueta", value);
            }
        }
        
        public int? Servicio_Gasolina_Id
        {
            get
            {
                return _servicio_Gasolina_Id;
            }
            set
            {
                _servicio_Gasolina_Id = value;
                UpdateFieldValue("Servicio_Gasolina_Id", value);
            }
        }
        
        public string Servicio_Gasolina_Etiqueta
        {
            get
            {
                return _servicio_Gasolina_Etiqueta;
            }
            set
            {
                _servicio_Gasolina_Etiqueta = value;
                UpdateFieldValue("Servicio_Gasolina_Etiqueta", value);
            }
        }
        
        public int? Servicio_Alimentos_Id
        {
            get
            {
                return _servicio_Alimentos_Id;
            }
            set
            {
                _servicio_Alimentos_Id = value;
                UpdateFieldValue("Servicio_Alimentos_Id", value);
            }
        }
        
        public string Servicio_Alimentos_Etiqueta
        {
            get
            {
                return _servicio_Alimentos_Etiqueta;
            }
            set
            {
                _servicio_Alimentos_Etiqueta = value;
                UpdateFieldValue("Servicio_Alimentos_Etiqueta", value);
            }
        }
        
        public int? Servicio_Terrestre_Id
        {
            get
            {
                return _servicio_Terrestre_Id;
            }
            set
            {
                _servicio_Terrestre_Id = value;
                UpdateFieldValue("Servicio_Terrestre_Id", value);
            }
        }
        
        public string Servicio_Terrestre_Etiqueta
        {
            get
            {
                return _servicio_Terrestre_Etiqueta;
            }
            set
            {
                _servicio_Terrestre_Etiqueta = value;
                UpdateFieldValue("Servicio_Terrestre_Etiqueta", value);
            }
        }
        
        public int? Servicio_Otros_Id
        {
            get
            {
                return _servicio_Otros_Id;
            }
            set
            {
                _servicio_Otros_Id = value;
                UpdateFieldValue("Servicio_Otros_Id", value);
            }
        }
        
        public string Servicio_Otros_Etiqueta
        {
            get
            {
                return _servicio_Otros_Etiqueta;
            }
            set
            {
                _servicio_Otros_Etiqueta = value;
                UpdateFieldValue("Servicio_Otros_Etiqueta", value);
            }
        }
        
        public bool? Es_De_Hospedaje
        {
            get
            {
                return _es_De_Hospedaje;
            }
            set
            {
                _es_De_Hospedaje = value;
                UpdateFieldValue("Es_De_Hospedaje", value);
            }
        }
        
        public bool? Es_De_Alimentos
        {
            get
            {
                return _es_De_Alimentos;
            }
            set
            {
                _es_De_Alimentos = value;
                UpdateFieldValue("Es_De_Alimentos", value);
            }
        }
        
        public bool? Es_Aerolinea
        {
            get
            {
                return _es_Aerolinea;
            }
            set
            {
                _es_Aerolinea = value;
                UpdateFieldValue("Es_Aerolinea", value);
            }
        }
        
        public bool? Es_Transporte_Terrestre
        {
            get
            {
                return _es_Transporte_Terrestre;
            }
            set
            {
                _es_Transporte_Terrestre = value;
                UpdateFieldValue("Es_Transporte_Terrestre", value);
            }
        }
        
        public bool? Significa_Pendiente
        {
            get
            {
                return _significa_Pendiente;
            }
            set
            {
                _significa_Pendiente = value;
                UpdateFieldValue("Significa_Pendiente", value);
            }
        }
        
        public bool? Significa_Autorizado
        {
            get
            {
                return _significa_Autorizado;
            }
            set
            {
                _significa_Autorizado = value;
                UpdateFieldValue("Significa_Autorizado", value);
            }
        }
        
        public bool? Significa_Rechazado
        {
            get
            {
                return _significa_Rechazado;
            }
            set
            {
                _significa_Rechazado = value;
                UpdateFieldValue("Significa_Rechazado", value);
            }
        }
        
        public string Autorizado_Rechazado_Por
        {
            get
            {
                return _autorizado_Rechazado_Por;
            }
            set
            {
                _autorizado_Rechazado_Por = value;
                UpdateFieldValue("Autorizado_Rechazado_Por", value);
            }
        }
        
        public string Mes_Mes
        {
            get
            {
                return _mes_Mes;
            }
            set
            {
                _mes_Mes = value;
                UpdateFieldValue("Mes_Mes", value);
            }
        }
        
        public string Solicitado_Por
        {
            get
            {
                return _solicitado_Por;
            }
            set
            {
                _solicitado_Por = value;
                UpdateFieldValue("Solicitado_Por", value);
            }
        }
        
        public bool? Es_Periodico
        {
            get
            {
                return _es_Periodico;
            }
            set
            {
                _es_Periodico = value;
                UpdateFieldValue("Es_Periodico", value);
            }
        }
        
        public bool? Es_Servicio_Basico
        {
            get
            {
                return _es_Servicio_Basico;
            }
            set
            {
                _es_Servicio_Basico = value;
                UpdateFieldValue("Es_Servicio_Basico", value);
            }
        }
        
        public bool? Es_De_Mantenimiento
        {
            get
            {
                return _es_De_Mantenimiento;
            }
            set
            {
                _es_De_Mantenimiento = value;
                UpdateFieldValue("Es_De_Mantenimiento", value);
            }
        }
        
        public bool? Es_Fiscal
        {
            get
            {
                return _es_Fiscal;
            }
            set
            {
                _es_Fiscal = value;
                UpdateFieldValue("Es_Fiscal", value);
            }
        }
        
        public bool? Es_Dividendo
        {
            get
            {
                return _es_Dividendo;
            }
            set
            {
                _es_Dividendo = value;
                UpdateFieldValue("Es_Dividendo", value);
            }
        }
        
        public bool? Es_Renta
        {
            get
            {
                return _es_Renta;
            }
            set
            {
                _es_Renta = value;
                UpdateFieldValue("Es_Renta", value);
            }
        }
        
        public bool? Aplica_Solicitud
        {
            get
            {
                return _aplica_Solicitud;
            }
            set
            {
                _aplica_Solicitud = value;
                UpdateFieldValue("Aplica_Solicitud", value);
            }
        }
        
        public bool? Aplica_Autorizacion
        {
            get
            {
                return _aplica_Autorizacion;
            }
            set
            {
                _aplica_Autorizacion = value;
                UpdateFieldValue("Aplica_Autorizacion", value);
            }
        }
        
        public bool? Aplica_Para_Sociedad
        {
            get
            {
                return _aplica_Para_Sociedad;
            }
            set
            {
                _aplica_Para_Sociedad = value;
                UpdateFieldValue("Aplica_Para_Sociedad", value);
            }
        }
        
        public bool? Aplica_Para_Sociedad_Cuadro_Accionario
        {
            get
            {
                return _aplica_Para_Sociedad_Cuadro_Accionario;
            }
            set
            {
                _aplica_Para_Sociedad_Cuadro_Accionario = value;
                UpdateFieldValue("Aplica_Para_Sociedad_Cuadro_Accionario", value);
            }
        }
        
        public bool? Aplica_Para_Contratado
        {
            get
            {
                return _aplica_Para_Contratado;
            }
            set
            {
                _aplica_Para_Contratado = value;
                UpdateFieldValue("Aplica_Para_Contratado", value);
            }
        }
        
        public string Sociedad_Sociedad
        {
            get
            {
                return _sociedad_Sociedad;
            }
            set
            {
                _sociedad_Sociedad = value;
                UpdateFieldValue("Sociedad_Sociedad", value);
            }
        }
        
        public int? Tipo_Gasto_Mantenimiento_Id
        {
            get
            {
                return _tipo_Gasto_Mantenimiento_Id;
            }
            set
            {
                _tipo_Gasto_Mantenimiento_Id = value;
                UpdateFieldValue("Tipo_Gasto_Mantenimiento_Id", value);
            }
        }
        
        public string Tipo_Gasto_Mantenimiento
        {
            get
            {
                return _tipo_Gasto_Mantenimiento;
            }
            set
            {
                _tipo_Gasto_Mantenimiento = value;
                UpdateFieldValue("Tipo_Gasto_Mantenimiento", value);
            }
        }
        
        public int? Tipo_Gasto_Servicio_Basico_Id
        {
            get
            {
                return _tipo_Gasto_Servicio_Basico_Id;
            }
            set
            {
                _tipo_Gasto_Servicio_Basico_Id = value;
                UpdateFieldValue("Tipo_Gasto_Servicio_Basico_Id", value);
            }
        }
        
        public string Tipo_Gasto_Servicio_Basico
        {
            get
            {
                return _tipo_Gasto_Servicio_Basico;
            }
            set
            {
                _tipo_Gasto_Servicio_Basico = value;
                UpdateFieldValue("Tipo_Gasto_Servicio_Basico", value);
            }
        }
        
        public string Accionista
        {
            get
            {
                return _accionista;
            }
            set
            {
                _accionista = value;
                UpdateFieldValue("Accionista", value);
            }
        }
        
        public string Proveedor_Arrendamiento_Proveedor_Proveedor
        {
            get
            {
                return _proveedor_Arrendamiento_Proveedor_Proveedor;
            }
            set
            {
                _proveedor_Arrendamiento_Proveedor_Proveedor = value;
                UpdateFieldValue("Proveedor_Arrendamiento_Proveedor_Proveedor", value);
            }
        }
        
        public string Proveedor_Proveedor
        {
            get
            {
                return _proveedor_Proveedor;
            }
            set
            {
                _proveedor_Proveedor = value;
                UpdateFieldValue("Proveedor_Proveedor", value);
            }
        }
        
        public FieldValue this[Administracion_Gasto_ProveedorDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
