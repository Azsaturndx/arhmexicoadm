
    

    // Show the diagram's model in JSON format
    function save() {
        document.getElementById("mySavedModel").value = myDiagram.model.toJson();
        myDiagram.isModified = false;
    }

    
    function load() {
        myDiagram.model = go.Model.fromJson(document.getElementById("mySavedModel").value);
    }

    arregloRegresa = new Array();
    var contador = 0;
    var tem = 0;
    var indicador = 0;
    var indicador2 = 0;


    //FUNCION QUE SE OCUPA PARA MOSTRAR EL ORGANIGRAMA CUANDO REGRESA
    function regresa() {
        //en donde carga el organigrama no guardala los datos de tipo estructura y nivel si vienen de aqui
        viene_Muestra_Regresa = 1;

        key = arregloRegresa[contador - 1].id;

        //---------------------- IDENTIFICA SI ES ESTRUCTURA O PUESTO
        var controladdor = '';
        var field = '';

        if (tipo_Organigrama == 0) {
            controlador = 'Organigrama_Estructura_V';
            field = 'Contratante_Estructura_Organizacional_Id';
        }

        if (tipo_Organigrama == 1) {
            controlador = 'Organigrama_Puesto_V';
            field = 'Contratante_Puesto_Id';
        }
        //----------------------HASTA AQUI

        $app.execute({
            controller: controlador,//'Organigrama_Puesto_V',
            pageSize: 1,
            filter: [
                { field: field/*'Contratante_Puesto_Id'*/, operator: '=', value: key }
            ],
            done: function (result) {
                if (tipo_Organigrama == 0) {
                    var ClienteId = result.Organigrama_Estructura_V[0].ClienteId;
                    var ContratanteId = result.Organigrama_Estructura_V[0].ContratanteId;
                }
                if (tipo_Organigrama == 1) {
                    var ClienteId = result.Organigrama_Puesto_V[0].ClienteId;
                    var ContratanteId = result.Organigrama_Puesto_V[0].ContratanteId;
                }



                nivel = arregloRegresa[contador - 1].nivel;

                // AGREGAR ESTO
                var tipoOrganigramaId = jQuery('span[data-field="Tipo_Organigrama_Id"] > span.app-field-data').html();

                if (tipoOrganigramaId == "Estructura Organizacional") {
                    tipoOrganigramaId = 0
                } else
                    tipoOrganigramaId = 1
                //HASTA AQUI

                $app.execute({
                    controller: 'Organigrama_V',
                    command: 'Custom',
                    argument: 'ExecCS01', values: [
                        { name: 'Tipo_Organigrama_Id', newValue: tipo_Organigrama },//tipoOrganigramaId },
                        { name: 'Organigrama_Estructura_Id', newValue: key },
                        { name: 'Organigrama_Puesto_Id', newValue: key },
                        { name: 'Organigrama_Cliente_Id', newValue: ClienteId },
                        { name: 'Organigrama_Contratante_Id', newValue: ContratanteId },
                        { name: 'Nivel', newValue: nivel },
                    ],
                    done: function (result) {

                        eval(result.clientScript);

                    }
                })
                arregloRegresa.splice(contador, 1);
                contador = contador - 1;
                indicador = 1;
                indicador2 = 1;

            }
        })

    }

    var tipo_Organigrama;
    var nivel_Organigrama;

    var viene_Muestra_Regresa = 0;
    
    function myFunction(json) {
        $("#mySavedModel").val(JSON.stringify(json));
        console.log("Tryna load");
        $("#orgChart").click();
        load();
        console.log("loaded?");
        //en donde carga el organigrama no guardala los datos de tipo estructura y nivel si vienen de aqui
        if (viene_Muestra_Regresa == 0) {
            //GUARDA GLOBALMENTE EL TIPO DE ESTRUCTURA QUE EXISTE
            tipo_Organigrama = jQuery('span[data-field="Tipo_Organigrama_Id"] > span.app-field-data').html();
            if (tipo_Organigrama == "Estructura Organizacional") {
                tipo_Organigrama = 0;
            } else {
                tipo_Organigrama = 1;
            }
            //GUARDA GLOBALMENTE EL NIVEL
            nivel_Organigrama = jQuery('span[data-field="Nivel"] > span.app-field-data').html();
        }

        viene_Muestra_Regresa = 0;

        console.log("paso aqui: " + viene_Muestra_Regresa);






        if (indicador2 == 0) {
            arregloRegresa = [];
            contador = 0;
        }

        if (indicador == 0) {
            tem = jQuery('span[data-field="Nivel"] > span.app-field-data').html();
            if (tem == "&nbsp;") {
                tem = 0;
            }

            arregloRegresa.push({ "id": json.nodeDataArray[0].key, "nivel": tem });

        }
        indicador = 0;
        indicador2 = 0;
    }