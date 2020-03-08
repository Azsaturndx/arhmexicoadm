namespace arhmexico.Handlers
{
    
    
    public partial class BlobFactoryConfig : BlobFactory
    {
        
        public static void Initialize()
        {
            // register blob handlers
            RegisterHandler("Accionista_DocumentoPicture", "\"APP\".\"Accionista_Documento\"", "\"Picture\"", new string[] {
                        "\"Accionista_Documento_Id\""}, "Accionista Documento Archivo", "Accionista_Documento", "Picture");
            RegisterHandler("Administracion_GastoPicture", "\"APP\".\"Administracion_Gasto\"", "\"Picture\"", new string[] {
                        "\"Administracion_Gasto_Id\""}, "Administracion Gasto Archivo", "Administracion_Gasto", "Picture");
            RegisterHandler("Administracion_GastoPicture2", "\"APP\".\"Administracion_Gasto\"", "\"Picture2\"", new string[] {
                        "\"Administracion_Gasto_Id\""}, "Administracion Gasto Archivo", "Administracion_Gasto", "Picture2");
            RegisterHandler("Cliente_DPicture", "\"APP\".\"Cliente_Documento\"", "\"Picture\"", new string[] {
                        "\"Cliente_Documento_Id\""}, "Cliente Documento Archivo", "Cliente_Documento", "Picture");
            RegisterHandler("Cliente_DocumentoPicture", "\"APP\".\"Cliente_Documento\"", "\"Picture\"", new string[] {
                        "\"Cliente_Documento_Id\""}, "Cliente Documento1 Archivo", "Cliente_Documento1", "Picture");
            RegisterHandler("Contratado_DocumentoPicture", "\"APP\".\"Contratado_Documento\"", "\"Picture\"", new string[] {
                        "\"Contratado_Documento_Id\""}, "Contratado Documento Archivo", "Contratado_Documento", "Picture");
            RegisterHandler("Contratado_Solicitud_DocumentoPicture", "\"APP\".\"Contratado_Solicitud_Documento\"", "\"Picture\"", new string[] {
                        "\"Contratado_Solicitud_Documento_Id\""}, "Contratado Solicitud Documento Archivo", "Contratado_Solicitud_Documento", "Picture");
            RegisterHandler("Contratado_Solicitud_DocumentoPicture2", "\"APP\".\"Contratado_Solicitud_Documento\"", "\"Picture2\"", new string[] {
                        "\"Contratado_Solicitud_Documento_Id\""}, "Contratado Solicitud Documento Archivo", "Contratado_Solicitud_Documento", "Picture2");
            RegisterHandler("Contratante_Layout_DocumentoPicture", "\"APP\".\"Contratante_Layout_Documento\"", "\"Picture\"", new string[] {
                        "\"Contratante_Layout_Documento_Id\""}, "Contratante Layout Documento Picture", "Contratante_Layout_Documento", "Picture");
            RegisterHandler("DPicture", "\"APP\".\"Documento\"", "\"Picture\"", new string[] {
                        "\"Documento_Id\""}, "Documento Documento", "Documento", "Picture");
            RegisterHandler("Documento_Solicitud_PrestamoPicture", "\"APP\".\"Documento_Solicitud_Prestamo\"", "\"Picture\"", new string[] {
                        "\"Documento_Solicitud_Prestamo_Id\""}, "Documento Solicitud Prestamo Archivo", "Documento_Solicitud_Prestamo", "Picture");
            RegisterHandler("Finiquito_DocumentoPicture", "\"APP\".\"Finiquito_Documento\"", "\"Picture\"", new string[] {
                        "\"Finiquito_Documento_Id\""}, "Finiquito Documento1 Documento", "Finiquito_Documento1", "Picture");
            RegisterHandler("Herramienta_DocumentoPicture", "\"APP\".\"Herramienta_Documento\"", "\"Picture\"", new string[] {
                        "\"Herramienta_Documento_Id\""}, "Herramienta Documento Archivo", "Herramienta_Documento", "Picture");
            RegisterHandler("Pagadora_Cuadro_Accionario_DocumentoPicture", "\"APP\".\"Pagadora_Cuadro_Accionario_Documento\"", "\"Picture\"", new string[] {
                        "\"Pagadora_Cuadro_Accionario_Documento_Id\""}, "Pagadora Cuadro Accionario Documento Picture", "Pagadora_Cuadro_Accionario_Documento", "Picture");
            RegisterHandler("Pagadora_DocumentoPicture", "\"APP\".\"Pagadora_Documento\"", "\"Picture\"", new string[] {
                        "\"Pagadora_Documento_Id\""}, "Pagadora Documento Picture", "Pagadora_Documento", "Picture");
            RegisterHandler("PPicture", "\"APP\".\"Persona\"", "\"Picture\"", new string[] {
                        "\"Persona_Id\""}, "Persona Fotografía", "Persona", "Picture");
            RegisterHandler("Persona_ConocimientoPicture", "\"APP\".\"Persona_Conocimiento\"", "\"Picture\"", new string[] {
                        "\"Persona_Conocimiento_Id\""}, "Persona Conocimiento Certificado", "Persona_Conocimiento", "Picture");
            RegisterHandler("Receptora_Cuadro_Accionario_DocumentoPicture", "\"APP\".\"Receptora_Cuadro_Accionario_Documento\"", "\"Picture\"", new string[] {
                        "\"Receptora_Cuadro_Accionario_Documento_Id\""}, "Receptora Cuadro Accionario Documento Picture", "Receptora_Cuadro_Accionario_Documento", "Picture");
            RegisterHandler("Receptora_DocumentoPicture", "\"APP\".\"Receptora_Documento\"", "\"Picture\"", new string[] {
                        "\"Receptora_Documento_Id\""}, "Receptora Documento Picture", "Receptora_Documento", "Picture");
            RegisterHandler("Sociedad_Cuadro_Accionario_DocumentoPicture", "\"APP\".\"Sociedad_Cuadro_Accionario_Documento\"", "\"Picture\"", new string[] {
                        "\"Sociedad_Cuadro_Accionario_Documento_Id\""}, "Sociedad Cuadro Accionario Documento Archivo", "Sociedad_Cuadro_Accionario_Documento", "Picture");
            RegisterHandler("Sociedad_DocumentoPicture", "\"APP\".\"Sociedad_Documento\"", "\"Picture\"", new string[] {
                        "\"Sociedad_Documento_Id\""}, "Sociedad Documento Archivo", "Sociedad_Documento", "Picture");
            RegisterHandler("Perfil_Persona_VPicture", "\"dbo\".\"Perfil_Persona_V\"", "\"Picture\"", new string[] {
                        "\"Perfil_Id\""}, "Perfil Persona V Picture", "Perfil_Persona_V", "Picture");
        }
    }
}
