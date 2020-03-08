function init() {

    go.licenseKey = "2bf843e7b26658c511895a25406c7efb0ff02e63ced04df1590717fcec5c611523cce17155d28d94d6a849f91979d2c9dbc23a7c971b553ab764d1d843b28fa9b7367ab1100841dca60621979bfb79f2f87826a6c5b670a2d279d9fbf9b8c5c90ceef38618cb1cab2a7906384977b049b2";
    var debug = 1;
    var $ = go.GraphObject.make;

    myDiagram = $(
        go.Diagram
        , "myDiagramDiv"
        , {
            initialContentAlignment: go.Spot.Center,
            maxSelectionCount: 1, // users can select only one part at a time
            validCycle: go.Diagram.CycleDestinationTree, // make sure users can only create trees
            "clickCreatingTool.archetypeNodeData": {}, // allow double-click in background to create a new node
            "clickCreatingTool.insertPart": function (loc) {  // customize the data for the new node
                this.archetypeNodeData = {
                    key: getNextKey(), // assign the key based on the number of nodes
                    name: "(new person)",
                    title: ""
                };
                return go.ClickCreatingTool.prototype.insertPart.call(this, loc);
            },
            layout:
                $(go.TreeLayout,
                    {
                        treeStyle: go.TreeLayout.StyleLastParents,
                        arrangement: go.TreeLayout.ArrangementHorizontal,
                        // properties for most of the tree:
                        angle: 90,
                        layerSpacing: 35,
                        // properties for the "last parents":
                        alternateAngle: 90,
                        alternateLayerSpacing: 35,
                        alternateAlignment: go.TreeLayout.AlignmentBus,
                        alternateNodeSpacing: 20
                    }),
            "undoManager.isEnabled": true // enable undo & redo
        }
    );
    // when the document is modified, add a "*" to the title and enable the "Save" button
    myDiagram.addDiagramListener("Modified", function (e) {
        var button = document.getElementById("SaveButton");
        if (button) button.disabled = !myDiagram.isModified;
        var idx = document.title.indexOf("*");
        if (myDiagram.isModified) {
            if (idx < 0) document.title += "*";
        } else {
            if (idx >= 0) document.title = document.title.substr(0, idx);
        }
    });
    // manage boss info manually when a node or link is deleted from the diagram
    myDiagram.addDiagramListener("SelectionDeleting", function (e) {
        var part = e.subject.first(); // e.subject is the myDiagram.selection collection,
        // so we'll get the first since we know we only have one selection
        myDiagram.startTransaction("clear boss");
        if (part instanceof go.Node) {
            var it = part.findTreeChildrenNodes(); // find all child nodes
            while (it.next()) { // now iterate through them and clear out the boss information
                var child = it.value;
                var bossText = child.findObject("boss"); // since the boss TextBlock is named, we can access it by name
                if (bossText === null) return;
                bossText.text = "";
            }
        } else if (part instanceof go.Link) {
            var child = part.toNode;
            var bossText = child.findObject("boss"); // since the boss TextBlock is named, we can access it by name
            if (bossText === null) return;
            bossText.text = "";
        }
        myDiagram.commitTransaction("clear boss");
    });

    var color = "#AC193D";

    var levelColors = ["#AC193D", "#2672EC", "#8C0095", "#5133AB",
        "#008299", "#D24726", "#008A00", "#094AB2"];


    // override TreeLayout.commitNodes to also modify the background brush based on the tree depth level
    myDiagram.layout.commitNodes = function () {
        go.TreeLayout.prototype.commitNodes.call(myDiagram.layout);  // do the standard behavior
        // then go through all of the vertexes and set their corresponding node's Shape.fill
        // to a brush dependent on the TreeVertex.level value

        //PARA ASIGNAR COLORES
        myDiagram.layout.network.vertexes.each(function (v) {
            if (v.node) {
                // AGREGAR ESTO
                var tipoOrganigramaId = jQuery('span[data-field="Tipo_Organigrama_Id"] > span.app-field-data').html();

                //console.log(tipoOrganigramaId);

                if (tipoOrganigramaId == "Estructura Organizacional") {
                    tipoOrganigramaId = 0
                } else {
                    tipoOrganigramaId = 1
                }



                if (tipo_Organigrama == 0) {
                    $app.execute({
                        controller: 'Organigrama_Estructura_V',
                        pageSize: 1,
                        filter: [
                            { field: 'Contratante_Estructura_Organizacional_Id', operator: '=', value: v.node.data.key }
                        ],
                        done: function (result) {
                            //          console.log("Estructura");
                            color = result.Organigrama_Estructura_V[0].ColorHexadecimal.toString();

                            var shape = v.node.findObject("SHAPE");
                            if (shape) shape.fill = $(go.Brush, "Linear", { 0: color, 1: go.Brush.lightenBy(color, 0.05), start: go.Spot.Left, end: go.Spot.Right });
                            //}, 2000);
                        }
                    })
                }




                if (tipo_Organigrama == 1) {
                    $app.execute({
                        controller: 'Organigrama_Puesto_V',
                        pageSize: 1,
                        filter: [
                            { field: 'Contratante_Puesto_Id', operator: '=', value: v.node.data.key }
                        ],
                        done: function (result) {
                            //        console.log("Puesto");
                            //console.log(result.Organigrama_Puesto_V[0].ColorHexadecimal);
                            color = result.Organigrama_Puesto_V[0].ColorHexadecimal.toString();
                            //return color;
                            //setTimeout(function () {
                            //console.log(color)
                            var shape = v.node.findObject("SHAPE");
                            if (shape) shape.fill = $(go.Brush, "Linear", { 0: color, 1: go.Brush.lightenBy(color, 0.05), start: go.Spot.Left, end: go.Spot.Right });
                            //}, 2000);
                        }
                    })
                }
            }
        });
    };


    // This function is used to find a suitable ID when modifying/creating nodes.
    // We used the counter combined with findNodeDataForKey to ensure uniqueness.
    function getNextKey() {
        var key = nodeIdCounter;
        while (myDiagram.model.findNodeDataForKey(key) !== null) {
            key = nodeIdCounter--;
        }
        return key;
    }
    var nodeIdCounter = -1; // use a sequence to guarantee key uniqueness as we add/remove/modify nodes
    var keyid;


    //Funcion al generar Organigrama o hacer Drilldown en el Organigrama.
    function muestraOrganigrama() {

        viene_Muestra_Regresa = 1;
        var field = '';

        switch (tipo_Organigrama) {
            case 0:
                controlador = 'Organigrama_Estructura_V';
                field = 'Contratante_Estructura_Organizacional_Id';
                break;
            case 1:
                controlador = 'Organigrama_Puesto_V';
                field = 'Contratante_Puesto_Id';
                break;

        }

        $app.execute({
            controller: controlador,
            pageSize: 1,
            filter: [
                { field: field, operator: '=', value: keyid }
            ],
            done: function (result) { doneMuestraOrganigrama(result); }
        })// $app.execute finaliza
    }


    function doneMuestraOrganigrama(result) {
        if (tipo_Organigrama == 0) {
            var ClienteId = result.Organigrama_Estructura_V[0].ClienteId;
            var ContratanteId = result.Organigrama_Estructura_V[0].ContratanteId;
            var EstructuraOrganizacionalId = result.Organigrama_Estructura_V[0].Contratante_Estructura_Organizacional_Id;
        }

        if (tipo_Organigrama == 1) {
            var ClienteId = result.Organigrama_Puesto_V[0].ClienteId;
            var ContratanteId = result.Organigrama_Puesto_V[0].ContratanteId;
            var EstructuraOrganizacionalId = result.Organigrama_Puesto_V[0].ContratanteEstructuraOrganizacionalId;
        }



        nivel = jQuery('span[data-field="Nivel"] > span.app-field-data').html();

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
                { name: 'Organigrama_Estructura_Id', newValue: keyid },
                { name: 'Organigrama_Puesto_Id', newValue: keyid },
                { name: 'Organigrama_Cliente_Id', newValue: ClienteId },
                { name: 'Organigrama_Contratante_Id', newValue: ContratanteId },
                { name: 'Nivel', newValue: nivel_Organigrama },//nivel },
            ],
            done: function (result) {
                eval(result.clientScript);
                console.log(viene_Muestra_Regresa);
            }
        }) // $app.execute finaliza

    }


    function nodeDoubleClick(e, obj) {
        //console.log(obj.part);
        keyid = obj.part.data.key;
        muestraOrganigrama();
        indicador2 = 1;
        contador = contador + 1;
    }


    // this is used to determine feedback during drags
    function mayWorkFor(node1, node2) {
        if (debug == 1) {
            console.log('Inicia funci?n: mayWorkFor(node1, node2);');
            console.log('node1:' + node1.key);
            console.log('node2:' + node2.key);
        }
        if (!(node1 instanceof go.Node)) {
            if (debug == 1) {
                console.log('El valor de node1 debe pertenecer a algun nodo.;');
            }
            return false;
        } // must be a Node

        if (node1 === node2) {
            if (debug == 1) {
                console.log('El valor de node1 no debe ser igual al node2.;');
            }
            return false;

        } // cannot work for yourself

        if (node2.isInTreeOf(node1)) {

            if (debug == 1) {
                console.log('No puede trabajar para alguien que trabaja para usted.;');
            }
            return false;
        }// cannot work for someone who works for you

        if (debug == 1) {
            console.log('Termina funci?n mayWorkFor(node1, node2), validaciones exitosas.');
            console.log('node1:' + node1.key);
            console.log('node2:' + node2.key);
        }

        return true;

    }// END function mayWorkFor(node1, node2){


    // This function provides a common style for most of the TextBlocks.
    // Some of these values may be overridden in a particular TextBlock.
    function textStyle() {
        return { font: "9pt  Segoe UI,sans-serif", stroke: "white" };
    }


    // This converter is used by the Picture.
    function findHeadShot(key) {
        return "https://arhapi.azurewebsites.net/api/peticion/ObtenerImagen/?personaKey="+key;
    }


    function generarCatalogoHtml(tipoCatalogo, esBaja, esAlta, esCambio, motivoMovimientoId) {
        var textohtml = "";
        //PRODUCTIVO
        var ligaUrlARHAdministrarCatalogoHtml = "https://prod-09.southcentralus.logic.azure.com/workflows/610aee2be865470d84ab85041df89eec/triggers/manual/paths/invoke/AdminCatHtml?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=glNWRHRdLIV1THq6OO6ZfNDF8ryZb97GQfLoMuSfrVI";
        //DESARROLLO
        //var ligaUrlARHAdministrarCatalogoHtml = "https://prod-26.southcentralus.logic.azure.com/workflows/8c3e686b5fe8452589f19cdc768d7241/triggers/manual/paths/invoke/AdminCatHtmlDev?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=JS051Va2q5CiplXI3cqsy6DRFr62SHChRL4DX_v8aNQ";

        var usuario = "5C7568FD-6412-474E-A099-006FAD27CD02";

        if (debug == 1) {
            console.log("1");
        }

        // Arreglo de par?metros a enviar a LA
        var data = {
            "tipoCatalogo": parseInt(tipoCatalogo)
            , "esBaja": parseInt(esBaja)
            , "esAlta": parseInt(esAlta)
            , "esCambio": parseInt(esCambio)
            , "motivoMovimientoId": parseInt(motivoMovimientoId)
            , "usuario": "5C7568FD-6412-474E-A099-006FAD27CD02"
        }

        if (debug == 1) {
            console.log("2");
        }

        // Establecemos valores solicitud	
        var settings = {
            "async": false,
            "crossDomain": true,
            "url": ligaUrlARHAdministrarCatalogoHtml,
            "method": "POST",
            "headers": {
                "content-type": "application/json"
                , "cache-control": "no-cache"
            },
            "processData": true,
            "data": JSON.stringify(data)
        }

        /*if (debug == 1) {
            console.log("3");
            console.log(tipoCatalogo);
            console.log(esBaja);
            console.log(esAlta);
            console.log(esCambio);
            console.log(usuario);
        }*/

        // Si la llamada ajax fue exitosa.
        jQuery.ajax(settings)
            .done(function (response) {
                // Asignamos valores a las variables
                mensajeSistemaId = response.mensajeSistemaId;
                mensajeSistema = response.mensajeSistema;
                textohtml = response.catalogoHtml;

                if (debug == 1) {
                    console.log("Ajax done.");
                    console.log("tipoCatalogo:" + response.tipoCatalogo);
                    console.log("mensajeSistemaId:" + mensajeSistemaId);
                    console.log("mensajeSistema:" + mensajeSistema);
                    console.log("textohtml:" + textohtml);
                }

            })
            //Si la llamada al Ajax fallo
            .fail(function (response) {
                var responseFalloParse = jQuery.parseJSON(response.responseText);
                if (debug == 1) {
                    console.log("Ajax fail.");
                    console.log("errorstatus:" + response.status);
                    console.log("errorText:" + responseFalloParse.error.message);
                }
                // Mostramos mensaje
                alertify.error(responseFalloParse.error.message);
            });


        return textohtml;
    }


    function administrarAccion(motivo1, motivo2, estatus1, estatus2, node1, node2, tipoOperacion, idContent, accionReorganizarPuesto) {
        // LigasUrl LA PRODUCTIVO
        var ligaUrlARHAdminContratantePuestoOrganigramaLA = "https://prod-02.southcentralus.logic.azure.com/workflows/0e9c5f5dd3cd4047ade3acc4578a744c/triggers/manual/paths/invoke/AdminCPOrganigrama?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=bDVSHfrJGZlyVrbj89z1a06FotxrOlnUt506PNTkSmk";
        // LigasUrl LA DESARROLLO
        //var ligaUrlARHAdminContratantePuestoOrganigramaLA = "https://prod-24.southcentralus.logic.azure.com/workflows/5c0a40e7863b41efa069e774ee123839/triggers/manual/paths/invoke/AdminCPOrganigramaDev?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=gBJJPpbESHbEY3mfNGP0K6uSCR5xzgWkpqZMPssgZQ4";




        // Para valores response exitoso.
        var mensajeSistemaId = 0;
        var mensajeSistema = "";
        var nuevoOrganigramaJson = "";
        // Para validar acciones de tipo de operacion 1
        var esReemplazarContratado = 0;
        var esDegradarContratado = 0;
        var esMoverANuevoJefe = 0;
        // Para validar acciones de tipo de operacion 2
        var puestoVacante = 0;

        // Para validar acciones de tipo de operacion 2
        var removerPuesto = 0;

        if (tipoOperacion == 1) {
            // Validaciones por tipo de operacion
            if (accionReorganizarPuesto == 1) {
                esReemplazarContratado = 1;
            }

            if (accionReorganizarPuesto == 2) {
                esDegradarContratado = 1;
            }
            if (accionReorganizarPuesto == 3) {
                esMoverANuevoJefe = 1;
            }

            // Imprimimos par?metros recibidos e inicia llamada ajax
            if (debug == 1) {
                console.log('Inicia funcion: administrarAccion(node1,node2,accionReorganizarPuesto)');
                console.log('node1:' + node1);
                console.log('node2:' + node2);
                console.log('tipoOperacion:' + tipoOperacion);
                console.log('accion:' + accionReorganizarPuesto);
                console.log('Llamada a ajax....');
            }
        }

        if (tipoOperacion == 2) {
            // Imprimimos par?metros recibidos e inicia llamada ajax
            puestoVacante = 1;
            if (debug == 1) {
                console.log('Inicia funcion: administrarAccion(node1,node2,accionReorganizarPuesto)');
                console.log('node1:' + node1);
                console.log('node2:' + 'No ocupa');
                console.log('tipoOperacion:' + tipoOperacion);
                console.log('accion:' + accionReorganizarPuesto);
                console.log('puestoVacante:' + puestoVacante);
                console.log('Llamada a ajax....');
            }

        }

        if (tipoOperacion == 2) {
            // Imprimimos par?metros recibidos e inicia llamada ajax
            removerPuesto = 1;
            if (debug == 1) {
                console.log('Inicia funcion: administrarAccion(node1,node2,accionReorganizarPuesto)');
                console.log('node1:' + node1);
                console.log('node2:' + 'No ocupa');
                console.log('tipoOperacion:' + tipoOperacion);
                console.log('accion:' + accionReorganizarPuesto);
                console.log('puestoVacante:' + puestoVacante);
                console.log('Llamada a ajax....');
            }

        }

        // Arreglo de par?metros a enviar a LA
        var data = {
            "contratadoId": 0
            , "contratantePuestoId": 0
            , "contratantePuesto1Id": parseInt(node1)
            , "contratantePuesto2Id": parseInt(node2)
            , "motivoContratado1Id": parseInt(motivo1)
            , "motivoContratado2Id": parseInt(motivo2)
            , "estatusContratado1Id": parseInt(estatus1)
            , "estatusContratado2Id": parseInt(estatus2)
            , "contratantePuestoPadreId": 1
            , "esAsignarContratado": 0//aun falta
            , "esDegradarContratado": parseInt(esDegradarContratado)
            , "esDesasignarContratado": 0//No se usara
            , "esMoverANuevoJefe": parseInt(esMoverANuevoJefe)
            , "esPuestoVacante": parseInt(puestoVacante)
            , "esReemplazarContratado": parseInt(esReemplazarContratado)
            , "esRemoverContratado": parseInt(removerPuesto)//se usa como remover puesto
            , "personaId": 0 //No se uso
            , "tipoOperacionId": tipoOperacion
            , "tipoOrganigramaId": 1
            , "usuario": $appfactory.userId()//"5C7568FD-6412-474E-A099-006FAD27CD02" //PTE OBTNER USER ID DE COT
        }

        // Establecemos valores solicitud	
        var settings = {
            "async": true,
            "crossDomain": true,
            "url": ligaUrlARHAdminContratantePuestoOrganigramaLA,
            "method": "POST",
            "headers": {
                "content-type": "application/json"
                , "cache-control": "no-cache"
            },
            "processData": false,
            "data": JSON.stringify(data)
        }
        // Si la llamada ajax fue exitosa.
        jQuery.ajax(settings)
            .done(function (response) {
                // Asignamos valores a las variables
                mensajeSistemaId = response.mensajeSistemaId;
                mensajeSistema = response.mensajeSistema;
                //nuevoOrganigramaJson = response.nuevoOrganigramaJson;
                if (debug == 1) {
                    console.log("Ajax done.");
                    console.log("operaci?n:" + response.Operacion);
                    console.log("mensajeSistemaId:" + mensajeSistemaId);
                    console.log("mensajeSistema:" + mensajeSistema);
                    //console.log("organigramaJson:" + nuevoOrganigramaJson);
                }
                // Mostramos mensaje
                if (mensajeSistemaId == 1) {
                    alertify.success(mensajeSistema);

                    keyid = arregloRegresa[contador].id;

                    console.log(keyid);

                    muestraOrganigrama();


                } else {
                    alertify.error(mensajeSistema);
                }



                //// LLenamos textarea con el nuevoOrganigramaJson
                //document.getElementById("mySavedModel").value = nuevoOrganigramaJson;

                //// Cargamos el nuevo organigrama
                //load();



                // Limpiamos custom content mostrados en modales.
                limpiarHtmlCustomContentModal(idContent);
            })
            //Si la llamada al Ajax fallo
            .fail(function (response) {
                var responseFalloParse = jQuery.parseJSON(response.responseText);
                if (debug == 1) {
                    console.log("Ajax fail.");
                    console.log("errorstatus:" + response.status);
                    console.log("errorText:" + responseFalloParse.error.message);
                }
                // Mostramos mensaje
                alertify.error(responseFalloParse.error.message);
            });

    } // END function administrarAccion(node1,node2,tipoOperacion,idContent,accionReorganizarPuesto){


    function generarHtmlCustomContentModal(idContent) {
        if (debug == 1) {
            console.log(idContent);
            console.log('Inicia funcion: generarHtmlCustomContentModal(idContent)');
        }
        var htmlAccionReorganizar = '';
        switch (idContent) {
            case 1:
                htmlAccionReorganizar += '<div id="acciones">';
                htmlAccionReorganizar += '<input type="radio" name="accion" value="1">Reemplazar<br>';
                htmlAccionReorganizar += '<input type="radio" name="accion" value="2">Degradar<br>';
                htmlAccionReorganizar += '<input type="radio" name="accion" value="3">Mover A Nuevo Jefe<br>';
                htmlAccionReorganizar += '</div>';
                break;
            case 2:
                htmlAccionMotivo = textohtml;
                break;
            default: ''
        }

        if (debug == 1) {
            console.log('Termina funcion: generarHtmlCustomContentModal(idContent)');
        }
        // Regresamos el html custom
        return htmlAccionReorganizar;

    }// END function generarHtmlCustomContentModal(idContent){	

    // START function limpiarHtmlCustomContentModal(idContent){
    function limpiarHtmlCustomContentModal(idContent) {
        if (debug == 1) {
            console.log('Inicia funcion: limpiarHtmlCustomContentModal(idContent)');
        }

        if (idContent == 1) {
            // Limpiamos el radio button seleccionado en el modal.
            jQuery('input[name=accion]').prop('checked', false);
        }

        if (debug == 1) {
            console.log('Termina funcion: limpiarHtmlCustomContentModal(idContent)');
        }
    }// END function limpiarHtmlCustomContentModal(idContent){

    // define the Node template
    myDiagram.nodeTemplate =
        $(go.Node, "Auto",
            { doubleClick: nodeDoubleClick },
            { // handle dragging a Node onto a Node to (maybe) change the reporting relationship
                mouseDragEnter: function (e, node, prev) {
                    var diagram = node.diagram;
                    var selnode = diagram.selection.first();
                    if (!mayWorkFor(selnode, node)) return;
                    var shape = node.findObject("SHAPE");
                    if (shape) {
                        shape._prevFill = shape.fill;  // remember the original brush
                        shape.fill = "darkred";
                    }
                },
                mouseDragLeave: function (e, node, next) {
                    if (debug == 1) {
                        console.log('Inicia funcion: mouseDragLeave');
                        console.log('Node Padre a afectar:' + node.data.key);
                    }

                    var shape = node.findObject("SHAPE");
                    if (shape && shape._prevFill) {
                        shape.fill = shape._prevFill;  // restore the original brush
                    }
                    if (debug == 1) {
                        console.log('Termina funcion: mouseDragLeave');
                    }
                },
                mouseDrop: function (e, node) {

                    //EL DRAG AND DROP SOLO ES FUNCIONAL PARA ESTRUCTURAS
                    if (tipo_Organigrama == 1) {
                        if (debug == 1) {
                            console.log('Inicia funcion: mouseDrop');
                            console.log('Node Padre a afectar:' + node.data.key);
                        }
                        var diagram = node.diagram;
                        var selnode = diagram.selection.first();  // assume just one Node in selection
                        // START if (mayWorkFor(selnode, node)){
                        if (mayWorkFor(selnode, node)) {

                            if (debug == 1) {

                            }
                            var idContent = 1;
                            var htmlAccionesDragDrop = generarHtmlCustomContentModal(idContent);
                            if (debug == 1) {
                                console.log('Html Custom Content:' + htmlAccionesDragDrop);
                            }

                            if (htmlAccionesDragDrop != '') {

                                // START alertify.confirm('Seleccione accion'
                                //alertify.confirm(title, message, onok, oncancel);	
                                alertify.confirm('Seleccione Acci?n'
                                    , htmlAccionesDragDrop
                                    // START ,function(closeEvent){
                                    , function () {
                                        var seleccion = jQuery('input[name=accion]:checked').val();

                                        if (seleccion == null) {
                                            seleccion = 0;
                                        }

                                        if (debug == 1) {
                                            console.log("accionSeleccionada:" + seleccion);
                                        }

                                        if (seleccion == 1) {
                                            var catalogoHtmlMotivoMovimiento = generarCatalogoHtml(1, 1, 0, 0, 0);
                                            alertify.confirm('Seleccione Motivo'
                                                , catalogoHtmlMotivoMovimiento // html a pintar en alertify confirm
                                                // START function(closeEvent){ // Para boton Ok
                                                , function (closeEvent) { // Para boton Ok

                                                    var motivoid = document.getElementById("select").value;

                                                    if (debug == 1) {
                                                        console.log("Motivo:" + motivoid);
                                                    }

                                                    if (motivoid == null) {
                                                        motivoid = 0;
                                                    }

                                                    var catalogoHtmlMotivoMovimiento = generarCatalogoHtml(2, 0, 0, 0, motivoid);

                                                    alertify.confirm('Seleccione Estatus'
                                                        , catalogoHtmlMotivoMovimiento // html a pintar en alertify confirm
                                                        // START function(closeEvent){ // Para boton Ok
                                                        , function (closeEvent) { // Para boton Ok

                                                            var estatusid = document.getElementById("select").value;

                                                            if (debug == 1) {
                                                                console.log("Estatus:" + estatusid);
                                                            }

                                                            if (estatusid == null) {
                                                                estatusid = 0;
                                                            }

                                                            console.log("Node1: " + selnode.data.key);
                                                            console.log("Node2: " + node.data.key);
                                                            console.log("Motivo: " + motivoid);
                                                            console.log("Estatus: " + estatusid);

                                                            //administrarAccion(motivoid, estatusid, selnode.data.key, node.data.key, 1, idContent, 1)

                                                            //administrarAccion(motivo1, motivo2, estatus1, estatus2, node1, node2, tipoOperacion, idContent, accionReorganizarPuesto) 
                                                            administrarAccion(0, motivoid, 0, estatusid, selnode.data.key, node.data.key, 1, idContent, 1)

                                                            //function administrarAccion(motivoid, estatusid, node1, node2, tipoOperacion, idContent, accionReorganizarPuesto)
                                                            return true;
                                                        }// END function(closeEvent){ // Para boton Ok
                                                        , 'alert' // PENDIENTE: LLAMAR SP Y HACER ROLLBACK, CUANDO SEA CANCELAR
                                                    ) // ENDalertify.confirm('Seleccione accion' DE CATALOGO MOTIVO MOVIMIENTO

                                                    return false;
                                                }// END function(closeEvent){ // Para boton Ok
                                                , 'alert' // PENDIENTE: LLAMAR SP Y HACER ROLLBACK, CUANDO SEA CANCELAR
                                            ) // ENDalertify.confirm('Seleccione accion' DE CATALOGO MOTIVO MOVIMIENTO
                                            return false;
                                        }

                                        if (seleccion == 2) {
                                            var catalogoHtmlMotivoMovimiento = generarCatalogoHtml(1, 0, 0, 1, 0);
                                            alertify.confirm('Seleccione Motivo Puesto 1'
                                                , catalogoHtmlMotivoMovimiento // html a pintar en alertify confirm
                                                // START function(closeEvent){ // Para boton Ok
                                                , function (closeEvent) { // Para boton Ok

                                                    var motivoid1 = document.getElementById("select").value;

                                                    if (debug == 1) {
                                                        console.log("Motivo 1:" + motivoid1);
                                                    }

                                                    if (motivoid1 == null) {
                                                        motivoid1 = 0;
                                                    }

                                                    var catalogoHtmlMotivoMovimiento = generarCatalogoHtml(1, 0, 0, 1, 0);

                                                    alertify.confirm('Seleccione Motivo Puesto 2'
                                                        , catalogoHtmlMotivoMovimiento // html a pintar en alertify confirm
                                                        // START function(closeEvent){ // Para boton Ok
                                                        , function (closeEvent) { // Para boton Ok

                                                            var motivoid2 = document.getElementById("select").value;

                                                            if (debug == 1) {
                                                                console.log("Motivo 2:" + motivoid2);
                                                            }

                                                            if (motivoid2 == null) {
                                                                motivoid2 = 0;
                                                            }

                                                            console.log("Node 1: " + selnode.data.key);
                                                            console.log("Node 2: " + node.data.key);
                                                            console.log("Motivo 1: " + motivoid1);
                                                            console.log("Motivo 2: " + motivoid2);


                                                            //administrarAccion(motivo1, motivo2, estatus1, estatus2, node1, node2, tipoOperacion, idContent, accionReorganizarPuesto) 
                                                            administrarAccion(motivoid1, motivoid2, 0, 0, selnode.data.key, node.data.key, 1, idContent, 2)


                                                            //function administrarAccion(motivoid, estatusid, node1, node2, tipoOperacion, idContent, accionReorganizarPuesto)
                                                            return true;
                                                        }// END function(closeEvent){ // Para boton Ok
                                                        , 'alert' // PENDIENTE: LLAMAR SP Y HACER ROLLBACK, CUANDO SEA CANCELAR
                                                    ) // ENDalertify.confirm('Seleccione accion' DE CATALOGO MOTIVO MOVIMIENTO

                                                    return false;
                                                }// END function(closeEvent){ // Para boton Ok
                                                , 'alert' // PENDIENTE: LLAMAR SP Y HACER ROLLBACK, CUANDO SEA CANCELAR
                                            ) // ENDalertify.confirm('Seleccione accion' DE CATALOGO MOTIVO MOVIMIENTO
                                            return false;

                                        }

                                        if (seleccion == 3) {
                                            var catalogoHtmlMotivoMovimiento = generarCatalogoHtml(1, 0, 0, 1, 0);
                                            alertify.confirm('Seleccione Motivo Movimiento'
                                                , catalogoHtmlMotivoMovimiento // html a pintar en alertify confirm
                                                // START function(closeEvent){ // Para boton Ok
                                                , function (closeEvent) { // Para boton Ok

                                                    var motivoid1 = document.getElementById("select").value;

                                                    if (debug == 1) {
                                                        console.log("Motivo 1:" + motivoid1);
                                                    }

                                                    if (motivoid1 == null) {
                                                        motivoid1 = 0;
                                                    }
                                                    //administrarAccion(motivo1, motivo2, estatus1, estatus2, node1, node2, tipoOperacion, idContent, accionReorganizarPuesto) 
                                                    administrarAccion(motivoid1, 0, 0, 0, selnode.data.key, node.data.key, 1, idContent, 3)

                                                    return true;
                                                }// END function(closeEvent){ // Para boton Ok
                                                , 'alert' // PENDIENTE: LLAMAR SP Y HACER ROLLBACK, CUANDO SEA CANCELAR
                                            ) // ENDalertify.confirm('Seleccione accion' DE CATALOGO MOTIVO MOVIMIENTO
                                            return false;
                                        }

                                    } // END ,function(closeEvent){
                                    , 'alert' // PENDIENTE: LLAMAR SP Y HACER ROLLBACK, CUANDO SEA CANCELAR
                                )// END alertify.confirm('Seleccione accion'			
                            }

                            if (debug == 1) {
                                console.log('Termina funcion: mouseDrop');
                            }
                        }// END if (mayWorkFor(selnode, node)){             
                    }








                }
            },
            // for sorting, have the Node.text be the data.name
            new go.Binding("text", "name"),
            // bind the Part.layerName to control the Node's layer depending on whether it isSelected
            new go.Binding("layerName", "isSelected", function (sel) { return sel ? "Foreground" : ""; }).ofObject(),
            // define the node's outer shape
            $(go.Shape, "Rectangle",
                {
                    name: "SHAPE", fill: "white", stroke: null,
                    // set the port properties:
                    portId: "", fromLinkable: true, toLinkable: true, cursor: "pointer"
                }),
            $(go.Panel, "Horizontal",
                $(go.Picture,
                    {
                        name: "Picture",
                        desiredSize: new go.Size(39, 50),
                        margin: new go.Margin(6, 8, 6, 10),
                    },
                    new go.Binding("source", "personaKey", findHeadShot)),
                // define the panel where the text will appear
                $(go.Panel, "Table",
                    {
                        maxSize: new go.Size(150, 999),
                        margin: new go.Margin(6, 10, 0, 3),
                        defaultAlignment: go.Spot.Left
                    },
                    $(go.RowColumnDefinition, { column: 2, width: 4 }),
                    $(go.TextBlock, textStyle(),  // the name
                        {
                            row: 0, column: 0, columnSpan: 5,
                            font: "12pt Segoe UI,sans-serif",
                            editable: true, isMultiline: false,
                            minSize: new go.Size(10, 16)
                        },
                        new go.Binding("text", "name").makeTwoWay()),
                    $(go.TextBlock, "Title: ", textStyle(),
                        { row: 1, column: 0 }),
                    $(go.TextBlock, textStyle(),
                        {
                            row: 1, column: 1, columnSpan: 4,
                            editable: true, isMultiline: false,
                            minSize: new go.Size(10, 14),
                            margin: new go.Margin(0, 0, 0, 3)
                        },
                        new go.Binding("text", "title").makeTwoWay()),
                    $(go.TextBlock, textStyle(),
                        { row: 2, column: 0 },
                        new go.Binding("text", "key", function (v) { return "ID: " + v; })),
                    $(go.TextBlock, textStyle(),
                        { name: "boss", row: 2, column: 3, }, // we include a name so we can access this TextBlock when deleting Nodes/Links
                        new go.Binding("text", "parent", function (v) { return "Boss: " + v; })),
                    // $(go.TextBlock, textStyle(),
                    //     { name: "personaKey", row: 2, column: 3, }, // we include a name so we can access this TextBlock when deleting Nodes/Links
                    //     new go.Binding("text", "personaKey", function (v) { return "personaKey: " + v; })),
                    $(go.TextBlock, textStyle(),  // the comments
                        {
                            row: 3, column: 0, columnSpan: 5,
                            font: "italic 9pt sans-serif",
                            wrap: go.TextBlock.WrapFit,
                            editable: true,  // by default newlines are allowed
                            minSize: new go.Size(10, 14)
                        },
                        new go.Binding("text", "comments").makeTwoWay())
                )  // end Table Panel
            ) // end Horizontal Panel
        );  // end Node


    // the context menu allows users to make a position vacant,
    // remove a role and reassign the subtree, or remove a department


    myDiagram.nodeTemplate.contextMenu =
        $(go.Adornment, "Vertical",

            $("ContextMenuButton",
                $(go.TextBlock, "Mas Informaci?n"),
                {
                    click: function (e, obj) {

                        var tipoOrganigrama = jQuery('span[data-field="Tipo_Organigrama_Id"] > span.app-field-data').html();

                        //if (tipoOrganigrama == "Estructura Organizacional") {
                        if (tipo_Organigrama == 0) {

                            var key = obj.part.data.key;
                            $app.touch.show({
                                controller: 'Estructura_Datos_V'
                                , startCommand: 'Edit'
                                , startArgument: 'editForm1'
                                , filter: [
                                    { name: 'Contratante_Estructura_Organizacional_Id', value: key }
                                ]
                            })

                        }

                        else {
                            var key = obj.part.data.key;
                            $app.touch.show({
                                controller: 'Perfil_Persona_V'
                                , startCommand: 'Edit'
                                , startArgument: 'editForm1'
                                , filter: [
                                    { name: 'Contratante_Puesto_Id', value: key }
                                ]
                            })
                        }
                    }
                }
            ),



            $("ContextMenuButton",
                $(go.TextBlock, "Colocar como vacante"),
                {

                    click: function (e, obj) {

                        if (tipo_Organigrama == 1) {

                            var key = obj.part.data.key;
                            if (debug == 1) {
                                console.log("Entrando a administrar accion Vacante");
                            }

                            var catalogoHtmlMotivoMovimiento = generarCatalogoHtml(2, 0, 0, 0, 1);
                            alertify.confirm('Seleccione Estatus Contratado'
                                , catalogoHtmlMotivoMovimiento // html a pintar en alertify confirm
                                // START function(closeEvent){ // Para boton Ok
                                , function (closeEvent) { // Para boton Ok

                                    var estatusid1 = document.getElementById("select").value;

                                    if (debug == 1) {
                                        console.log("Estatus 1:" + estatusid1);
                                    }

                                    if (estatusid1 == null) {
                                        estatusid1 = 0;
                                    }
                                    //administrarAccion(motivo1, motivo2, estatus1, estatus2, node1, node2, tipoOperacion, idContent, accionReorganizarPuesto) 
                                    administrarAccion(0, 0, estatusid1, 0, key, 1, 2, 0, 0)

                                    return true;
                                }// END function(closeEvent){ // Para boton Ok
                                , 'alert' // PENDIENTE: LLAMAR SP Y HACER ROLLBACK, CUANDO SEA CANCELAR
                            ) // ENDalertify.confirm('Seleccione accion' DE CATALOGO MOTIVO MOVIMIENTO
                            return false;

                        }

                    }

                }
            ),


            $("ContextMenuButton",
                $(go.TextBlock, "Agregar nuevo puesto"),
                {
                    click: function (e, obj) {
                        console.log("Esta agregando puesto");
                        if (tipo_Organigrama == 1) {

                            var key = obj.part.data.key;


                            $app.execute({
                                controller: 'Organigrama_Puesto_V',
                                pageSize: 1,
                                filter: [
                                    { field: 'Contratante_Puesto_Id', operator: '=', value: key }
                                ],
                                done: function (result) {
                                    console.log(result.Organigrama_Puesto_V[0].ClienteId);
                                    console.log(result.Organigrama_Puesto_V[0].ContratanteId);
                                    console.log(result.Organigrama_Puesto_V[0].ContratanteEstructuraOrganizacionalId);
                                    var ClienteId = result.Organigrama_Puesto_V[0].ClienteId;
                                    var ContratanteId = result.Organigrama_Puesto_V[0].ContratanteId;
                                    var EstructuraOrganizacionalId = result.Organigrama_Puesto_V[0].ContratanteEstructuraOrganizacionalId;

                                    $app.touch.show({
                                        controller: 'Contratante_Puesto',
                                        startCommand: 'New',
                                        startArgument: 'createForm2',
                                        filter: [
                                            { name: 'Contratante_Id', newValue: 0 },
                                            { name: 'Contratante_Puesto_Padre_Id', newValue: 0 },
                                            { name: 'Contratante_Estructura_Organizacional_Id', newValue: 0 },
                                            { name: 'Estatus_Puesto_Id', newValue: 0 },
                                            { name: 'Cliente_Id', newValue: 0 }
                                        ],

                                        done: function (result) {
                                            console.log("Ejecuta show");

                                            keyid = arregloRegresa[contador].id;
                                            console.log(keyid);
                                            muestraOrganigrama();

                                        }
                                    }) // $app.execute finaliza



                                    setTimeout(function () {
                                        //alert("Hola!!!");
                                        console.log("pasaron3");
                                        $app.input.execute({

                                            values: [
                                                { name: 'Contratante_Puesto', value: "" }, //ya
                                                { name: 'Contratante_Id', value: ContratanteId },
                                                { name: 'Contratante_Puesto_Padre_Id', value: key }, //ya
                                                { name: 'Contratante_Puesto_Descripcion', value: '' }, //ya
                                                { name: 'Contratante_Estructura_Organizacional_Id', value: EstructuraOrganizacionalId },
                                                { name: 'Estatus_Puesto_Id', value: 3 }, //ya
                                                { name: 'Cliente_Id', value: ClienteId } //ya
                                            ]
                                        });

                                    }, 3000);




                                }
                            })

                        }


                    }
                }
            ),


            $("ContextMenuButton",
                $(go.TextBlock, "Remover puesto"),
                {
                    click: function (e, obj) {
                        if (tipo_Organigrama == 1) {

                            var key = obj.part.data.key;
                            if (debug == 1) {
                                console.log("Entrando a administrar accion Remover Puesto");
                            }

                            var catalogoHtmlMotivoMovimiento = generarCatalogoHtml(2, 0, 0, 0, 1);
                            alertify.confirm('Seleccione Estatus Contratado'
                                , catalogoHtmlMotivoMovimiento // html a pintar en alertify confirm
                                // START function(closeEvent){ // Para boton Ok
                                , function (closeEvent) { // Para boton Ok

                                    var estatusid1 = document.getElementById("select").value;

                                    if (debug == 1) {
                                        console.log("Estatus 1:" + estatusid1);
                                    }

                                    if (estatusid1 == null) {
                                        estatusid1 = 0;
                                    }
                                    //administrarAccion(motivo1, motivo2, estatus1, estatus2, node1, node2, tipoOperacion, idContent, accionReorganizarPuesto) 
                                    administrarAccion(0, 0, estatusid1, 0, key, 1, 4, 0, 0)

                                    return true;
                                }// END function(closeEvent){ // Para boton Ok
                                , 'alert' // PENDIENTE: LLAMAR SP Y HACER ROLLBACK, CUANDO SEA CANCELAR
                            ) // ENDalertify.confirm('Seleccione accion' DE CATALOGO MOTIVO MOVIMIENTO
                            return false;

                            //function administrarAccion(node1, node2, tipoOperacion, idContent, accionReorganizarPuesto)


                        }
                    }
                }
            ),


            $("ContextMenuButton",
                $(go.TextBlock, "Agregar Contratado"),
                {
                    click: function (e, obj) {

                        if (tipo_Organigrama == 1) {

                            var key = obj.part.data.key;
                            $app.touch.show({
                                controller: 'Contratante_Puesto'
                                , startCommand: 'Edit'
                                , startArgument: 'editForm2'
                                , filter: [
                                    { name: 'Contratante_Puesto_Id', value: key },
                                    // { name: 'Contratante_Puesto_Id', newValue: key},
                                ],

                                done: function (result) {
                                    console.log(result);
                                    //Agregado el 10Junio20191030
                                    keyid = arregloRegresa[contador].id;
                                    //Agregado el 10Junio20191030
                                    muestraOrganigrama();

                                }
                            })//$app.touch.show({


                        }//if(tipo_Organigrama == 1){

                    } // click: function (e, obj)
                }
            )
        );




    // define the Link template
    myDiagram.linkTemplate =
        $(go.Link, go.Link.Orthogonal,
            { corner: 5, relinkableFrom: true, relinkableTo: true },
            $(go.Shape, { strokeWidth: 4, stroke: "#00a4a4" }));  // the link shape
    // read in the JSON-format data from the "mySavedModel" element
    load();
    // support editing the properties of the selected person in HTML
    if (window.Inspector) myInspector = new Inspector("myInspector", myDiagram,
        {
            properties: {
                "key": { readOnly: true },
                "comments": {}
            }
        });
}