// json obtained from http request
var jsonAsignacion;
var contratadoId;

//Delete COT's custom <footer> because it bugs the custom grid.
$(document).ready(function () {
    $("footer").remove();
});

//Toggles Sidebar Hide/View 
$("#menu-toggle").click(function (e) {
    e.preventDefault();
    $("#wrapper").toggleClass("toggled");
});

$(document).ready(function () {
    //Create line to link levels 2 - 3
$("#line-segundo-nivel").HTMLSVGconnect({
    paths: [
        {
            start: "#nivel-2_wrapper",
            end: "#nivel-3_wrapper",
            stroke: "#86ADA4"
        }
    ]
});

});

//HTTP POST Request to LogicApp ARH_ObtenerDatosContratado_LA
$(document).ready(function () {

    var url = "https://prod-09.southcentralus.logic.azure.com:443/workflows/5d96889c20e84bbfb095f50126215355/triggers/request/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Frequest%2Frun&sv=1.0&sig=jNHv8oRukcC97zTRsK0tnJwEdIBfeE4x3fzk5hvbYVM";

    $.ajax({
        type: "POST",
        contentType: "application/json; charset=utf-8",
        url: url,
        data: JSON.stringify({ "user-id": $app.userId() }),
        success: function (result) {
            //Sets attained values and fade-out preloader.
            $("#nombre-completo").html(result["nombre-completo"]);
            $("#telefono").html(result["telefono"]);
            $("#e-mail").html(result["correo"]);
            $("#direccion").html(result["direccion"]);
            $("#rfc").html(result["rfc"]);
            $("#foto-usuario").css("background-image", "url('" + findHeadShot(result["persona-key"]) + "')");
            contratadoId = result["contratado-id"];
            seccionAsignacion();
        },
        error: function (result) {
            console.log('Ocurrio Un error al procesar la petición de información basica para el usuario');
        }
    });

});

/**
 * Returns an URL that can be used in any image element
 * given the identifier key
 *
 * @param {string} key - Azure SQL Server Guid that identify a single person
 * @returns {string} Parsed URL, that drives to endpoint: ObtenerImagen in ARHAPI.
 * 
 * @example
 * ... 
 * myUrl = findHeadshot("189583C9-4C88 ... ");
 * ...
 * $("#my-img").css("background", url(myUrl));
 */
function findHeadShot(key) {
    var url = "https://arhapi.azurewebsites.net/api/peticion/ObtenerImagen/?personaKey=" + key;
    return url;
}


// Listeners
// $("#datos-personales").click(function (e) {
//     $("#line0").HTMLSVGconnect({
//         paths: [
//             {
//                 start: "#datos-personales",
//                 end: "#nivel-2_wrapper",
//                 stroke:"#86ADA4"
//             }
//         ]
//     });

//     $("#line0").toggleClass("line-show");
// });


$(".item").click(function (e) {
    
    //Remove selected class to all items.
    $(".item").each(function(){
        $(this).removeClass("item-selected");
    });

    var element = $(e.currentTarget);
    var linesContainer = $("#lines");
    var id = element.attr('id');
    element.toggleClass("item-selected");
    var line = $("#line-" + id);

    if (line.length) {

    }
    else{
        console.log("line doesn't exists, adding.");
        linesContainer.append("<div id='line-" + id + "' class='line'></div>");
        //Esto parece redundante, pero si no se hace
        //Referencía al objeto no encontrado.
        line = null;
        line = $("#line-" + id);

        line.HTMLSVGconnect({
            paths: [
                {
                    start: "#"+id,
                    end: "#nivel-2_wrapper",
                    stroke: "#86ADA4"
                }
            ]
        });
    }

    $(".line").each(function(){
        $(this).removeClass("line-show");
    });

    line.addClass("line-show");
});


//Listen on Click events and set class on first click
$(".nivel-2-item").click(function (e) { 
    $("#line-segundo-nivel").addClass("line-show");
});



//HTTP POST Request to LogicApp ARH_ObtenerSeccionAsignacion_LA
function seccionAsignacion(){
    var url = "https://prod-06.southcentralus.logic.azure.com:443/workflows/8e480cc7af05498498841403d3368132/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=E6AO8P_QELxaXfnsd-0vP1bWqnxzT7M9QU6e3yWH2IM";

    $.ajax({
        type: "POST",
        contentType: "application/json; charset=utf-8",
        url: url,
        data: JSON.stringify({ 
            "user-id": $app.userId(),
            "contratado-id" : contratadoId
        }),
        success: function (result) {
            //save response in a variable.
            jsonAsignacion = result;
            $("#datos-personales").click();
            $('#page-loader').fadeOut(500);
            $("#edit-perfil-l3").attr("href", "/pages/contratados?Contratado_Id=" + contratadoId);
        },
        error: function (result) {
            console.log('Ocurrio Un error al procesar la petición de seccion de asignación');
        }
    });

}

/**
 * Display information related to user education
 *
 * @param {JSON} jsonObj - Json with the education information
 * 
 * @returns {void} does not return value
 * 
 * @example
 * ... 
 * showEducation(jsonAsignacion['rows_educacion']);
 * ...
 */
function showEducation(jsonObj) {
    var escolaridades = jsonObj['value'];
    $("#nivel-3_body").html("");
    $(".nivel-3-header>.nivel-3-header__text").html("EDUCACIÓN");
    for (var i = 0; i < escolaridades.length; i++) {
        var fila = $('<div/>', { 'class': 'row' });
        var columna = $('<div/>', { 'class': 'col-lg-12 nivel-3-item' });    
        var myH4 = $('<h4>'+escolaridades[i]['Nivel_Escolaridad']+'</h4>');
        var myH5 = $('<h5>'+escolaridades[i]['Programa_Curso']+'</h5>');
        var myP = $('<p>' + escolaridades[i]['Fecha_Inicio'] + ' - ' + escolaridades[i]['Fecha_Fin'] + '</p>');
        columna.append(myH4);
        columna.append(myH5);
        columna.append(myP);
        fila.append(columna);
        $('#nivel-3_body').append(fila);
    }
}

/**
 * Display information related to user Hobbies
 *
 * @param {JSON} jsonObj - Json with the hobbies information
 * 
 * @returns {void} does not return value
 * 
 * @example
 * ... 
 * showHobbies(jsonAsignacion['rows_pasatiempos']);
 * ...
 */
function showHobbies(jsonObj) {
    var pasatiempos = jsonObj['value'];
    $("#nivel-3_body").html("");
    $(".nivel-3-header>.nivel-3-header__text").html("PASATIEMPOS");
    for (var i = 0; i < pasatiempos.length; i++) {
        var fila = $('<div/>', { 'class': 'row mb-3' });
        var columna = $('<div/>', { 'class': 'col-lg-12 nivel-3-item' });    
        var myH4 = $('<h4>'+pasatiempos[i]['Pasatiempo']+'</h4>');

        columna.append(myH4);        
        if(pasatiempos[i]['Notas']){
            var myP = $('<p>'+pasatiempos[i]['Notas']+'</p>');
            columna.append(myP);
        }
        fila.append(columna);
        $('#nivel-3_body').append(fila);
    }
}

/**
 * Display information related to user documents
 *
 * @param {JSON} jsonObj - Json with the documents information
 * 
 * @returns {void} does not return value
 * 
 * @example
 * ... 
 * showDocuments(jsonAsignacion['rows_documents']);
 * ...
 */
function showDocuments(jsonObj) {
    var documentos = jsonObj['value'];
    $("#nivel-3_body").html("");
    $(".nivel-3-header>.nivel-3-header__text").html("DOCUMENTOS");
    for (var i = 0; i < documentos.length; i++) {
        var fila = $('<div/>', { 'class': 'row' });
        var columna = $('<div/>', { 'class': 'col-lg-12 nivel-3-item' });    
        var myH4 = $('<h4>'+documentos[i]['Tipo_Documento']+'</h4>');
        var myH5 = $('<h5>'+documentos[i]['PictureFileName']+'</h5>');
        var myP = $('<p>'+documentos[i]['Documento']+'</p>');
        columna.append(myH4);
        columna.append(myH5);
        columna.append(myP);
        fila.append(columna);
        $('#nivel-3_body').append(fila);
    }
}

/**
 * Muestra la informacion de Asignación del contratado
 *
 * @param {JSON} jsonObj - Objeto Json con informacion de asignación
 * 
 * @returns {Void} No retorna valor
 * 
 * @example
 * ... 
 * mostrarAsignacion(jsonAsignacion["rows_asignacion"]);
 */
function mostrarAsignacion(jsonObj) {
    var asignacion = jsonObj['Table1'];
    $("#nivel-3_body").html("");
    $(".nivel-3-header>.nivel-3-header__text").html("ASIGNACIÓN");

    $('#nivel-3_body').append(generarEtiquetaNivel3("Tipo de contratado", asignacion[0]['Tipo_Contratado_Tipo_Contratado']));
    $('#nivel-3_body').append(generarEtiquetaNivel3("Tipo de empleado", asignacion[0]['Tipo_Empleado_Tipo_Empleado']));
    $('#nivel-3_body').append(generarEtiquetaNivel3("Cliente", asignacion[0]['Cliente_Cliente']));
    $('#nivel-3_body').append(generarEtiquetaNivel3("Contratante", asignacion[0]['Contratante_Contratante']));
    $('#nivel-3_body').append(generarEtiquetaNivel3("Estructura organizacional", asignacion[0]['Contratante_Estructura_Organizacional_Estructura_Organizacional']));
    $('#nivel-3_body').append(generarEtiquetaNivel3("Puesto de jefe", asignacion[0]['Contratante_Puesto_Jefe']));
    $('#nivel-3_body').append(generarEtiquetaNivel3("Turno laboral", asignacion[0]['Turno_Laboral_Turno_Laboral']));
    $('#nivel-3_body').append(generarEtiquetaNivel3("Pagadora", asignacion[0]['Pagadora_Pagadora']));

}

/**
 * retorna un boton con ID y etiqueta proporcionados
 *
 * @param {string} identificador - Id de elemento
 * @param {string} etiqueta - Texto a mostrar en el botón
 * @returns {Object} estructura html para el botón
 * 
 * @example
 * ... 
 * var miBoton = generarBotonNivel2("boton-1", "Soy un boton");
 * ...
 * $("#container").append(miBoton);
 */
function generarBotonNivel2(identificador, etiqueta) {
    var fila = $("<div/>", { "class": "row" });
    var columna = $("<div/>", { "class": "col-lg-12 nivel-2-item", id: identificador });
    var myP = $("<p/>", { "class" : "nivel-2-item__text" });
    myP.html(etiqueta);
    columna.append(myP);
    fila.append(columna);
    return fila;
}

/**
 * retorna una etiqueta con valor proporcionados
 *
 * @param {string} etiqueta - Texto a mostrar como encabezado
 * @param {string} valor - Texto a mostrar como valor
 * @returns {Object} estructura html para la etiqueta
 * 
 * @example
 * ... 
 * var miEtiqueta = generarEtiquetaNivel3("Saldo: ", "3");
 * ...
 * $("#container").append(miEtiqueta);
 */
function generarEtiquetaNivel3(etiqueta, valor) {
    var fila = $("<div/>", { "class": "row" });
    var columna = $("<div/>", { "class": "col-lg-12 nivel-3-item" });
    var myH4 = $("<h4/>");
    var myP = $("<p/>");
    myH4.html(etiqueta);
    myP.html(valor);
    columna.append(myH4);
    columna.append(myP);
    fila.append(columna);
    return fila;
}

/**
 * retorna un item con los datos necesarios para una solicitud de vacaciones
 *
 * @param {Tipo_Parametro} jsonSolicituVacaciones - Json con informacion de la solicitud de vacaciones
 * @returns {Object} Estructura html para el item
 * 
 * @example
 * ... 
 * var item = generarItemSolicitudVacaciones(jsonAsignacion["rows_solicitud_vacaciones"]);
 * ...
 * $("#container").append(item);
 */
function generarItemSolicitudVacaciones(jsonSolicitudVacaciones) {
    var fila = $("<div/>", { "class": "row" });
    var columna = $("<div/>", { "class": "col-lg-12 nivel-3-item" });
    var myH4 = $("<h4/>");
    var myH5 = $("<h4/>");
    var myP = $("<p/>");

    var encabezado = jsonSolicitudVacaciones["Dias_Solicitados"];
    encabezado += (jsonSolicitudVacaciones["Dias_Solicitados"]>1)?" días solicitados el ":" día solicitado el ";
    myH4.html(encabezado + jsonSolicitudVacaciones["Fecha_Solicitud"]);
    myH5.html("Del " + jsonSolicitudVacaciones["Fecha_Inicio_Vacaciones"] + " al " + jsonSolicitudVacaciones["Fecha_Fin_Vacaciones"]);
    myP.html(jsonSolicitudVacaciones["Estatus_Solicitud_Estatus_Solicitud"]);

    columna.append(myH4);
    columna.append(myH5);
    columna.append(myP);
    fila.append(columna);
    return fila;
}

/**
 * retorna un item con los datos necesarios para una saldo de vacaciones
 *
 * @param {JSON} jsonSaldoVacaciones - Json con informacion del saldo de vacaciones
 * 
 * @returns {Object} Estructura html para el item
 * 
 * @example
 * ... 
 * var item = generarItemSaldoVacaciones(jsonAsignacion["rows_saldo_vacaciones"]);
 * ...
 * $("#container").append(item);
 */
function generarItemSaldoVacaciones(jsonSaldoVacaciones) {
    var fila = $("<div/>", { "class": "row mb-2" });
    var columna = $("<div/>", { "class": "col-lg-12 nivel-3-item" });
    var myH4 = $("<h4/>");
    var myH5 = $("<h4/>");
    var myP = $("<p/>");
    var MyB1 = $("<b>Saldo: </b>");
    var MyB2 = $("<b>Pendientes por tomar: </b>");

    myH4.html(jsonSaldoVacaciones["Anio_Anio"]);
    myH5.html("Del " + jsonSaldoVacaciones["Fecha_Inicio_Saldo"] + " al " + jsonSaldoVacaciones["Fecha_Fin_Saldo"]);

    myP.append(MyB1).append(jsonSaldoVacaciones["Saldo_Vacaciones"] + "<br>");
    myP.append(MyB2).append(jsonSaldoVacaciones["Dias_Pendientes_Por_Tomar"]);

    columna.append(myH4);
    columna.append(myH5);
    columna.append(myP);
    fila.append(columna);
    return fila;
}

/**
 * retorna un item con los datos necesarios para una solicitud de gastos
 *
 * @param {JSON} jsonSolicitudGastos - Json con informacion de la solicitud de gastos
 * 
 * @returns {Object} Estructura html para el item
 * 
 * @example
 * ... 
 * var item = generarItemSolicitudGasto(jsonAsignacion["rows_solicitudes_gastos"]);
 * ...
 * $("#container").append(item);
 */
function generarItemSolicitudGasto(jsonSolicitudGastos) {
    var fila = $("<div/>", { "class": "row mb-2" });
    var columna = $("<div/>", { "class": "col-lg-12 nivel-3-item" });
    var myH4 = $("<h4/>");
    var myH5 = $("<h4/>");
    var myP = $("<p/>");
    var MyB1 = $("<b>Motivo de pago: </b>");
    var MyB2 = $("<b>Medio de pago: </b>");
    var MyB3 = $("<b>Medio de pago: </b>");

    myH4.html(jsonSolicitudGastos["Tipo_Gasto_Tipo_Gasto"]);
    //Viaticos y urgentes
    var viaticos = ((jsonSolicitudGastos["Es_Viatico"])?"": "No ") + "Viáticos";
    var urgente = ((jsonSolicitudGastos["Es_Urgente"])?"": "No ") + "urgente";
    myH5.html(viaticos + " - " + urgente);

    myP.append(MyB1).append(jsonSaldoVacaciones["Motivo_Pago"] + "<br>");
    myP.append(MyB2).append(jsonSaldoVacaciones["Medio_Pago"] + "<br>");
    myP.append(MyB3).append(jsonSaldoVacaciones["Tipo_Comprobante"]);

    if (jsonSolicitudGastos["Notas"]) {
        myP.append("<i>" + jsonSolicitudGastos["Notas"] + "</i>");
    }
    columna.append(myH4);
    columna.append(myH5);
    columna.append(myP);
    fila.append(columna);
    return fila;
}


/** Events for level 2 */
//Listen on Click events for #datos-laborales
$("#datos-personales").click(function (e) { 
    $("#nivel-2_wrapper").html("");
    var boton1 = generarBotonNivel2("nivel-2-educacion", "Mi educación");
    var boton2 = generarBotonNivel2("nivel-2-pasatiempos", "Mis pasatiempos");
    var boton3 = generarBotonNivel2("nivel-2-documentos", "Mis documentos");
    var boton4 = generarBotonNivel2("edit-perfil", "Editar perfil");
    var boton5 = generarBotonNivel2("ver-mas", "Ver más...");
    
    $("#nivel-2_wrapper").append(boton1);
    $("#nivel-2_wrapper").append(boton2);
    $("#nivel-2_wrapper").append(boton3);
    $("#nivel-2_wrapper").append(boton4);
    $("#nivel-2_wrapper").append(boton5);
    //add link
    $( "#edit-perfil" ).wrapAll( '<a href="/pages/contratados?Contratado_Id=' + contratadoId + '" />');
    $( "#ver-mas" ).wrapAll( '<a href="/pages/contratados?Contratado_Id=' + contratadoId + '" />');

    $("#nivel-2-educacion").click();
});

//Listen on Click events for #datos-laborales
$("#datos-laborales").click(function (e) { 
    $("#nivel-2_wrapper").html("");
    var boton1 = generarBotonNivel2("nivel-2-asignacion", "Asignación");
    $("#nivel-2_wrapper").append(boton1);
    $("#nivel-2-asignacion").click();
});

//Listen on Click events for #vacaciones
$("#vacaciones").click(function (e) { 
    $("#nivel-2_wrapper").html("");
    var boton1 = generarBotonNivel2("nivel-2-Solicitudes-vacaciones", "Solicitudes de vacaciones");
    var boton2 = generarBotonNivel2("nivel-2-Saldo-Vacaciones", "Saldo de Vacaciones");
    $("#nivel-2_wrapper").append(boton1);
    $("#nivel-2_wrapper").append(boton2);

    $("#nivel-2-Solicitudes-vacaciones").click();
});

//Listen on Click events for solicitud-gastos
$("#solicitud-gastos").click(function (e) { 
    $("#nivel-2_wrapper").html("");
    var boton1 = generarBotonNivel2("nivel-2-solicitudes-gasto", "Solicitudes de Gasto");
    $("#nivel-2_wrapper").append(boton1);

    $("#nivel-2-solicitudes-gasto").click();
});

/** Events for level 2 */

//Listen on Click events for documents
$("#nivel-2_wrapper").on("click", "#nivel-2-documentos", function(){ 
    showDocuments(jsonAsignacion['rows_documentos']);
});

//Listen on Click events for hobbies
$("#nivel-2_wrapper").on("click", "#nivel-2-pasatiempos", function(){ 
    showHobbies(jsonAsignacion['rows_pasatiempos']);
});

//Listen on Click events for education
$("#nivel-2_wrapper").on("click", "#nivel-2-educacion", function(){ 
    showEducation(jsonAsignacion['rows_educacion']);
});

//Listen on Click events for assignment
$("#nivel-2_wrapper").on("click", "#nivel-2-asignacion", function(){ 
    mostrarAsignacion(jsonAsignacion['rows_asignacion']);
});

//Listen on Click events for holiday requests
$("#nivel-2_wrapper").on("click", "#nivel-2-Solicitudes-vacaciones", function(){ 
    $("#nivel-3_body").html("");
    $(".nivel-3-header>.nivel-3-header__text").html("SOLICITUD VACACIONES");
    var solicitudV = jsonAsignacion["rows_solicitudes_vacaciones"]["Table1"];
    for (var i = 0; i < solicitudV.length; i++) {
        $("#nivel-3_body").append( generarItemSolicitudVacaciones(solicitudV[i]));
    }
});

//Listen on Click events for holiday balance
$("#nivel-2_wrapper").on("click", "#nivel-2-Saldo-Vacaciones", function(){ 
    $("#nivel-3_body").html("");
    $(".nivel-3-header>.nivel-3-header__text").html("SALDO VACACIONES");
    var saldoV = jsonAsignacion["rows_saldo_vacaciones"]["Table1"];
    for (var i = 0; i < saldoV.length; i++) {
        $("#nivel-3_body").append(generarItemSaldoVacaciones(saldoV[i]));
    } 
});

//Listen on Click events for expense requests
$("#nivel-2_wrapper").on("click", "#nivel-2-solicitudes-gasto", function(){ 
    $("#nivel-3_body").html("");
    $(".nivel-3-header>.nivel-3-header__text").html("SOLICITUDES DE GASTO");
    var solicitudG = jsonAsignacion["rows_solicitudes_gastos"]["Table1"];
    for (var i = 0; i < solicitudG.length; i++) {
        $("#nivel-3_body").append(generarItemSolicitudGasto(solicitudG[i]));
    }
});

//Listen on Click events for nivel-2-item items
$("#nivel-2_wrapper").on("click", ".nivel-2-item", function(){ 
    $("#nivel-2_wrapper .nivel-2-item").css("text-decoration", "none");
    $(this).css("text-decoration", "underline");
});
