//Variables globales; esto es para insertar o editar en SQL

var arhmexico = {
    "servicios": [

        {
            "nombre": "CargaOrganigrama",//Método para obtener el Grid del objeto - Pasar el objetoId
            "url": "../Services/ServiceAdministrarObjeto.asmx/ObtenerGridObjeto",//ObtenerGridObjeto es el nombre del servicio 
            "estatus": 1
        }

    ],

    /*
    "mensajes": [
        {

            "id": 0,
            "texto": "Sin mensaje",
            "tipo": "Sistema",
            "estatus": 1
        },

    ],
*/
    "scripts": [
        {
            "url": "https://cdnjs.cloudflare.com/ajax/libs/gojs/1.8.21/go.js",
            "estatus": 1
        },
        {
            "url": "https://cdnjs.cloudflare.com/ajax/libs/gojs/1.8.21/go-debug.js",
            "estatus": 1
        },
        {
            "url": "https://gojs.net/latest/extensions/DataInspector.js",
            "estatus": 1
        },
    ],
    "styles": [
        {
            "url": "https://gojs.net/latest/extensions/DataInspector.css",
            "estatus": 1
        },        
    ],
    "cargarScripts": function () {

        var scripts = this.scripts;
        //Aqui es la primera vez que se usa Jquery validar si aqui es el conflicto $
        $.each(scripts, function (key, value) {
            if (value.estatus == 1) {
                var script = document.createElement('script');
                script.type = "text/javascript";
                script.src = value.url;
                script.async = false;
                document.getElementsByTagName('head')[0].appendChild(script);
            }
        });
    },
    "cargarEstilos": function () {

        var estilos = this.styles;

        $.each(estilos, function (key, value) {
            if (value.estatus == 1) {
                var head = document.getElementsByTagName('head')[0];
                var link = document.createElement('link');
                link.rel = 'stylesheet';
                link.type = 'text/css';
                link.href = value.url;

                head.appendChild(link);
            }
        });
    }
    , "CargaOrganigrama": function (tipoOperacionId, objetoId, instanciaId) {

        var urlServicio = this.servicios[0].url;

        if (borradoLogico == 1)
            borrado = true;
        else
            borrado = false;

        $.ajax({
            url: urlServicio,
            method: 'POST',
            data: "{'tipoOperacionId':" + tipoOperacionId + ",'objetoId':" + objetoId + ",'tabla':'" + nombreTabla + "', 'datosJSON':'" + jsonParaReemplazo + "','definicionColumnas':'" + definicionColumnas + "','nombreColumnas':'" + ordenDeColumnas + "','instanciaId':'" + instanciaId + "','borradoLogico':'" + borrado + "'}",
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            beforeSend: function (e) {
                id = 8;
                msg = admonbienes.mensajes[id];
                alertify.alert('<i class="material-icon material-icon-alarm" aria-hidden="true">alarm</i>&nbsp;&nbsp;' + msg.tipo + ' (' + id + ') ' + msg.texto).set('basic', true).setHeader(msg.tipo);
            },
            error: function (e, t, a) {
                NotificarMensaje(0, "Ocurrió un error!", true, debug);
            }
        }).done(function (data) {
            alertify.closeAll();  //Cerrar ventana de Alta
            NotificarMensaje(0, "Eliminado Correctamene. Cargando...Espere por favor", true, debug);
            admonbienes.cargarDataTable(5, objeto, 0);
        })
    }
};

arhmexico.cargarScripts();
arhmexico.cargarEstilos();

